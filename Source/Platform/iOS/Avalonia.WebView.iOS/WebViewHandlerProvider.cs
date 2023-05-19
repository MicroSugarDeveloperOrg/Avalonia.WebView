namespace Avalonia.WebView.iOS;

internal class WebViewHandlerProvider : IPlatformWebViewProvider
{
    public IPlatformWebView CreatePlatformView(IVirtualView virtualView, Action<WebViewCreationProperties>? configDelegate = null)
    {
        var settings = new WebViewCreationProperties();
        configDelegate?.Invoke(settings);
        var webView = new WebViewHandler(virtualView);
        webView.Initialize(settings);
        return webView;
    }
}