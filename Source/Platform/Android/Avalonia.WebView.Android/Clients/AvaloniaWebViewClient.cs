using Android.Graphics;
using WebViewCore.Enums;

namespace Avalonia.WebView.Android.Clients;

[SupportedOSPlatform("android23.0")]
internal class AvaloniaWebViewClient : WebViewClient
{
    public AvaloniaWebViewClient(
        AndroidWebViewCore webViewHandler,
        IVirtualWebViewControlCallBack callBack
    )
    {
        ArgumentNullException.ThrowIfNull(webViewHandler);
        ArgumentNullException.ThrowIfNull(callBack);
        _callBack = callBack;
        _webViewCore = webViewHandler;
        _webView = webViewHandler.WebView;
    }

    protected AvaloniaWebViewClient(IntPtr javaReference, JniHandleOwnership transfer)
        : base(javaReference, transfer)
    {
        // This constructor is called whenever the .NET proxy was disposed, and it was recreated by Java. It also
        // happens when overridden methods are called between execution of this constructor and the one above.
        // because of these facts, we have to check all methods below for null field references and properties.
    }

    readonly AndroidWebViewCore? _webViewCore;
    readonly AndroidWebView? _webView;
    readonly IVirtualWebViewControlCallBack? _callBack;

    public override bool ShouldOverrideUrlLoading(
        AndroidWebView? view,
        IWebResourceRequest? request
    )
#pragma warning disable CA1416
        =>
        ShouldOverrideUrlLoadingCore(view, request) || base.ShouldOverrideUrlLoading(view, request);
#pragma warning restore CA1416

    public override void OnPageFinished(AndroidWebView? view, string? url)
    {
        base.OnPageFinished(view, url);

        if (view is null)
            return;
        System.Diagnostics.Debug.WriteLine($"OnPageFinished: {url}");
        if (_callBack is null || !Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out var uri))
            return;
        _callBack.PlatformWebViewNavigationCompleted(
            _webViewCore,
            new WebViewUrlLoadedEventArg { IsSuccess = true }
        );
    }

    bool ShouldOverrideUrlLoadingCore(AndroidWebView? view, IWebResourceRequest? request)
    {
        if (view is null)
        {
            return false;
        }
        System.Diagnostics.Debug.WriteLine(
            $"ShouldOverrideUrlLoadingCore: {request?.Url?.ToString()}"
        );
        if (
            _callBack is null
            || !Uri.TryCreate(request?.Url?.ToString(), UriKind.RelativeOrAbsolute, out var uri)
        )
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
        _callBack.PlatformWebViewNavigationCompleted(
            _webViewCore,
            new WebViewUrlLoadedEventArg { IsSuccess = isSucceed }
        );
        return true;
    }
}
