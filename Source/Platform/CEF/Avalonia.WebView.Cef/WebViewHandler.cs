using Avalonia.WebView.Core;

namespace Avalonia.WebView;
public partial class WebViewHandler : ViewHandlerTx<IVirtualWebView, CefWebViewCore>
{
    public WebViewHandler(IVirtualWebView virtualWebView, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
        : base(webViewCreationProperties.KeepAlive)
    {
        CefWebViewCore webView = new();
        PlatformWebView = webView;
        VirtualViewContext = virtualWebView;
        PlatformViewContext = webView;

    }




    protected override void Disposing()
    {
        PlatformWebView.Dispose();
        PlatformWebView = default!;
        VirtualViewContext = default!;
    }
}
