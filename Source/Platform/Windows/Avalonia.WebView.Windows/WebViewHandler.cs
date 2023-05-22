namespace Avalonia.WebView.Windows;

public class WebViewHandler : ViewHandler<IVirtualWebView, WebView2Core>
{
    public WebViewHandler(IVirtualWebView virtualWebView, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        var webView = new WebView2Core(this, callback, provider, webViewCreationProperties);
        PlatformWebView = webView;
        VirtualViewContext = virtualWebView;
        PlatformViewContext = webView;
    }

    protected override HandleRef CreatePlatformHandler(IPlatformHandle parent, Func<IPlatformHandle> createFromSystem)
    {
        var handler = createFromSystem.Invoke();
        return new HandleRef(this, handler.Handle);
    }

    protected override void Disposing()
    {
        PlatformWebView.Dispose();
        PlatformWebView = default!;
        VirtualViewContext = default!;
    }
}
