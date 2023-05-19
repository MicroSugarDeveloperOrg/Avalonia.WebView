using Android.Runtime;
using System.Runtime.Versioning;

namespace Avalonia.WebView.Android.Clients;

[SupportedOSPlatform("android23.0")]
internal class AvaloniaWebViewClient : WebViewClient
{
    public AvaloniaWebViewClient(WebViewHandler webViewHandler)
    {
        ArgumentNullException.ThrowIfNull(webViewHandler);
        _webViewHandler = webViewHandler;
    }

    protected AvaloniaWebViewClient(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
        // This constructor is called whenever the .NET proxy was disposed, and it was recreated by Java. It also
        // happens when overridden methods are called between execution of this constructor and the one above.
        // because of these facts, we have to check all methods below for null field references and properties.
    }

    private static readonly string AppOrigin = $"https://0.0.0.0";

    private static readonly Uri AppOriginUri = new(AppOrigin);

    private readonly WebViewHandler? _webViewHandler;

    public override bool ShouldOverrideUrlLoading(AndroidWebView? view, IWebResourceRequest? request)
    {
#pragma warning disable CA1416
        return base.ShouldOverrideUrlLoading(view, request);
#pragma warning restore CA1416

    }

    bool ShouldOverrideUrlLoadingCore(IWebResourceRequest? request)
    {
        if (_webViewHandler is null || !Uri.TryCreate(request?.Url?.ToString(), UriKind.RelativeOrAbsolute, out var uri))
            return false;

        // This method never gets called for navigation to a new window ('_blank'),
        // so we know we can safely invoke the UrlLoading event.
        //var callbackArgs = UrlLoadingEventArgs.CreateWithDefaultLoadingStrategy(uri, AppOriginUri);
        //_webViewHandler.UrlLoading(callbackArgs);
        //_webViewHandler.Logger.NavigationEvent(uri, callbackArgs.UrlLoadingStrategy);

        //if (callbackArgs.UrlLoadingStrategy == UrlLoadingStrategy.OpenExternally)
        //{
        //    _webViewHandler.Logger.LaunchExternalBrowser(uri);
        //    try
        //    {
        //        var intent = Intent.ParseUri(uri.OriginalString, IntentUriType.Scheme);
        //        _webViewHandler.Context.StartActivity(intent);
        //    }
        //    catch (URISyntaxException)
        //    {
        //        // This can occur if there is a problem with the URI formatting given its specified scheme.
        //        // Other platforms will silently ignore formatting issues, so we do the same here.
        //    }
        //    catch (ActivityNotFoundException)
        //    {
        //        // Do nothing if there is no activity to handle the intent. This is consistent with the
        //        // behavior on other platforms when a URL with an unknown scheme is clicked.
        //    }
        //    return true;
        //}

        //return callbackArgs.UrlLoadingStrategy != UrlLoadingStrategy.OpenInWebView;

        return true;
    }

}
