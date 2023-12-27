

namespace Avalonia.WebView.Core;
public partial class CefWebViewCore : IPlatformWebView<CefWebViewCore>
{
    public CefWebViewCore(ViewHandlerTx handler, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;
        _provider = provider;
    }

    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandlerTx _handler;
    readonly WebViewCreationProperties _creationProperties;

    //CefBrowser _cefBrowser;
    //CefBrowserHost _cefBrowserHost;

}
