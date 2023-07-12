using WebViewCore.Enums;

namespace Avalonia.WebView.Android.Clients;

[SupportedOSPlatform("android23.0")]
internal class AvaloniaWebViewClient : WebViewClient
{
    public AvaloniaWebViewClient(AndroidWebViewCore webViewHandler, IVirtualWebViewControlCallBack callBack, IVirtualBlazorWebViewProvider provider, WebScheme webScheme)
    {
        ArgumentNullException.ThrowIfNull(webViewHandler);
        ArgumentNullException.ThrowIfNull(callBack);
        ArgumentNullException.ThrowIfNull(provider);
        ArgumentNullException.ThrowIfNull(webScheme);
        _callBack = callBack;
        _webViewCore = webViewHandler;
        _provider = provider;
        _webView = webViewHandler.WebView;
        _webScheme = webScheme;
    }


    protected AvaloniaWebViewClient(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
        // This constructor is called whenever the .NET proxy was disposed, and it was recreated by Java. It also
        // happens when overridden methods are called between execution of this constructor and the one above.
        // because of these facts, we have to check all methods below for null field references and properties.
    }

    readonly AndroidWebViewCore? _webViewCore;
    readonly AndroidWebView? _webView;
    readonly IVirtualWebViewControlCallBack? _callBack;
    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly WebScheme? _webScheme;

    bool _isStarted = false;

    public override bool ShouldOverrideUrlLoading(AndroidWebView? view, IWebResourceRequest? request)
#pragma warning disable CA1416
        => ShouldOverrideUrlLoadingCore(request) || base.ShouldOverrideUrlLoading(view, request);
#pragma warning restore CA1416

    public override AndroidWebResourceResponse? ShouldInterceptRequest(AndroidWebView? view, IWebResourceRequest? request)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(request));
        Func<AndroidWebResourceResponse?> func = () =>
        {
            if (_webScheme is null || _provider is null)
                return default;

            var requestUri = request?.Url?.ToString();
            if (requestUri == null)
                return default;

            var allowFallbackOnHostPage = _webScheme.BaseUri.IsBaseOfPage(requestUri);

            var webRequest = new WebResourceRequest
            {
                RequestUri = requestUri!,
                AllowFallbackOnHostPage = allowFallbackOnHostPage
            };

            if (!_provider.PlatformWebViewResourceRequested(_webViewCore, webRequest, out var webResponse))
                return default;

            if (webResponse is null)
                return default;

            var contentType = webResponse.Headers[QueryStringHelper.ContentTypeKey];

            return new AndroidWebResourceResponse(contentType, "UTF-8", webResponse.StatusCode, webResponse.StatusMessage, webResponse.Headers, webResponse.Content);
        };
        var ret = func.Invoke();

        if (ret is null)
            return base.ShouldInterceptRequest(view, request);
        else
            return ret;
    }

    public override void OnPageFinished(AndroidWebView? view, string? url)
    {
        base.OnPageFinished(view, url);

        if (view is null)
            return;

        if (string.IsNullOrWhiteSpace(url))
            return;

        if (_webScheme is null)
            return;

        if (_webScheme.BaseUri.IsBaseOfPage(url))
            RunBlazorStarupScripts();
    }

    bool ShouldOverrideUrlLoadingCore(IWebResourceRequest? request)
    {
        if (_callBack is null || !Uri.TryCreate(request?.Url?.ToString(), UriKind.RelativeOrAbsolute, out var uri))
            return false;
        WebViewUrlLoadingEventArg args = new() { Url = uri, RawArgs = request };
        _callBack.PlatformWebViewNavigationStarting(_webViewCore, args);
        if (args.Cancel)
            return false;

        var newWindowEventArgs = new WebViewNewWindowEventArgs()
        {
            Url = uri,
            UrlLoadingStrategy = UrlRequestStrategy.OpenInWebView
        };

        if (!_callBack.PlatformWebViewNewWindowRequest(_webViewCore, newWindowEventArgs))
            return false;

        bool isSucceed = false;
        switch (newWindowEventArgs.UrlLoadingStrategy)
        {
            case UrlRequestStrategy.OpenExternally:
            case UrlRequestStrategy.OpenInNewWindow:
                var intent = Intent.ParseUri(uri.OriginalString, IntentUriType.Scheme);
                AndroidApplication.Context.StartActivity(intent);
                isSucceed = true;
                break;
            case UrlRequestStrategy.OpenInWebView:
                _webView?.LoadUrl(uri.OriginalString);
                isSucceed = true;
                break;
            case UrlRequestStrategy.CancelLoad:            
                break;
            default:
                break;
        }

        _callBack.PlatformWebViewNavigationCompleted(_webViewCore, new WebViewUrlLoadedEventArg() {IsSuccess = isSucceed });

        return true;
    }

    void RunBlazorStarupScripts()
    {
        if (_webView is null)
            return;

        _webView.EvaluateJavascript(BlazorScriptHelper.BlazorStartedScript, new JavaScriptValueCallback(blazorStarted =>
        {
            var result = blazorStarted?.ToString();

            if (result != BlazorScriptHelper.UndefinedString)
                return;

            _webView.EvaluateJavascript(BlazorScriptHelper.BlazorMessageScript, new JavaScriptValueCallback(_ =>
            {
                _isStarted = true;
                BlazorMessageChannel(_webView, _provider!);

                _webView.EvaluateJavascript(BlazorScriptHelper.BlazorStartingScript, new JavaScriptValueCallback(_ =>
                {

                }));

            }));
        }));
    }

    void BlazorMessageChannel(AndroidWebView webView, IVirtualBlazorWebViewProvider provider)
    {
        if (webView is null)
            return;

        if (provider is null)
            return;

        if (_webScheme is null)
            return;

        var nativeToJSPorts = webView.CreateWebMessageChannel();
        var nativeToJs = new BlazorWebMessageCallback(message =>
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

              provider.PlatformWebViewMessageReceived(_webViewCore, new WebViewMessageReceivedEventArgs() 
              {
                  Source = _webScheme.BaseUri,
                  Message = message
              });
        });

        var destPort = new[] { nativeToJSPorts[1] };
        nativeToJSPorts[0].SetWebMessageCallback(nativeToJs);

        webView.PostWebMessage(new WebMessage("capturePort", destPort), AndroidUri.Parse(_webScheme.BaseUri.AbsoluteUri)!);
    }

}
