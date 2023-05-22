namespace Avalonia.WebView.Mac.Core;
public partial class MacWebViewCore : IPlatformWebView<MacWebViewCore>
{
    public MacWebViewCore(ViewHandler handler, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        _provider = provider;
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
    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandler _handler;
    readonly WebViewCreationProperties _creationProperties;
    readonly string _dispatchMessageCallback = "__dispatchMessageCallback";

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


    public MacosWebView WebView
    {
        get => _webView;
        private set => _webView = value;
    }
}
