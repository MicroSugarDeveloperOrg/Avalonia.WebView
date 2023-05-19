namespace Avalonia.WebView.Windows;

public class WebViewHandler : ViewHandler<IVirtualWebView, WebView2Core>
{
    public WebViewHandler(IVirtualWebView virtualWebView, IVirtualWebViewControlCallBack callback , WebViewCreationProperties webViewCreationProperties)
    {
        var webview2core = new WebView2Core(this, callback, webViewCreationProperties);
        PlatformWebView = webview2core;
        VirtualViewContext = virtualWebView;
        PlatformViewContext = webview2core;
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
