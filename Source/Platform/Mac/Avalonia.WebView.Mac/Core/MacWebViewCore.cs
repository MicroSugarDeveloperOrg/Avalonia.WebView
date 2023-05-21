namespace Avalonia.WebView.Mac.Core;
public partial class MacWebViewCore : IPlatformWebView<MacWebViewCore>
{
    public MacWebViewCore(ViewHandler handler, IVirtualWebViewControlCallBack callback, WebViewCreationProperties webViewCreationProperties)
    { 
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;

        _webView = new MacosWebView();
        NativeHandler = _webView.Handle;
        RegisterEvents();
    }

    ~MacWebViewCore()
    {
        Dispose(disposing: false);
    }

    MacosWebView _webView;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandler _handler;
    readonly WebViewCreationProperties _creationProperties;

    bool _isBlazorWebView = false;

    bool _isInitialized = false;
    public bool IsInitialized
    {
        get => Volatile.Read(ref _isInitialized);
        private set => Volatile.Write(ref _isInitialized, value);
    }

    bool _isdisposed = false;
    public bool IsDisposed
    {
        get => Volatile.Read(ref _isdisposed);
        private set => Volatile.Write(ref _isdisposed, value);
    }

    IVirtualBlazorWebViewProvider? _provider;

    public MacosWebView WebView
    {
        get => _webView;
        private set => _webView = value;
    }
}
