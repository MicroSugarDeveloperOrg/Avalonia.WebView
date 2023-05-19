using Avalonia.WebView.Mac.Core;

namespace Avalonia.WebView.Mac;

public class WebViewHandler : ViewHandler<IVirtualWebView, MacWebViewCore>
{
    public WebViewHandler(IVirtualWebView virtualWebView, IVirtualWebViewControlCallBack callback, WebViewCreationProperties webViewCreationProperties)
    {
        var webView = new MacWebViewCore(this, callback, webViewCreationProperties);
        _webViewCore = webView;
        PlatformWebView = webView;
        VirtualViewContext = virtualWebView;
        PlatformViewContext = webView;
    }
    readonly MacWebViewCore _webViewCore;

    protected override HandleRef CreatePlatformHandler(IPlatformHandle parent, Func<IPlatformHandle> createFromSystem)
    {
        //var handler = createFromSystem.Invoke();
        return new HandleRef(this, _webViewCore.NativeHandler);
    }

    protected override void Disposing()
    {
        PlatformWebView.Dispose();
        PlatformWebView = default!;
        VirtualViewContext = default!;
    }
}
