namespace Avalonia.WebView.iOS.Core;

public partial class IosWebViewCore: IPlatformWebView<IosWebViewCore>
{
    public IosWebViewCore(ViewHandler handler, IVirtualWebViewControlCallBack callback, WebViewCreationProperties webViewCreationProperties)
    {
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;
        _config = new WKWebViewConfiguration();

        _webView = new WKWebView(CGRect.Empty, _config)
        {
            BackgroundColor = UIColor.Clear,
            AutosizesSubviews = true
        };

        NativeHandler = _webView.Handle.Handle;
        RegisterEvents();
    }

    ~IosWebViewCore()
    {
        Dispose(disposing: false);
    }

    WKWebView _webView;
    readonly WKWebViewConfiguration _config;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandler _handler;
    readonly WebViewCreationProperties _creationProperties;
    readonly string _filterKeyWord = "webwindowinterop";
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

    IVirtualBlazorWebViewProvider? _provider;

    public WKWebView WebView
    {
        get => _webView;
        private set => _webView = value;
    }
}

