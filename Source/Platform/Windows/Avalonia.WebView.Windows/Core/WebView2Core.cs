namespace Avalonia.WebView.Windows.Core;

public partial class WebView2Core : IPlatformWebView<WebView2Core>
{
    public WebView2Core(ViewHandler handler, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        _hwndTaskSource = new();
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;
        _provider = provider;

        if (handler.RefHandler.Handle != IntPtr.Zero)
        {
            NativeHandler = handler.RefHandler.Handle;
            _hwndTaskSource.SetResult(handler.RefHandler.Handle);
        }

        SetEnvirmentDefaultBackground(webViewCreationProperties.DefaultWebViewBackgroundColor);
        RegisterEvents();
    }

    ~WebView2Core()
    {
        Dispose(disposing: false);
    }

    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandler _handler;
    readonly WebViewCreationProperties _creationProperties;
    readonly TaskCompletionSource<IntPtr> _hwndTaskSource;

    bool _browserHitTransparent;
    bool _browserCrashed;

    bool _isBlazorWebView = false;

    bool _isInitialized = false;
    public bool IsInitialized
    {
        get => Volatile.Read(ref _isInitialized);
        private set => Volatile.Write(ref _isInitialized, value);
    }

    bool _isDisposed = false;
    public bool IsDisposed
    {
        get => Volatile.Read(ref _isDisposed);
        private set => Volatile.Write(ref _isDisposed, value);
    }
 
    CoreWebView2Environment? _coreWebView2Environment { get; set; }
    CoreWebView2Controller? _coreWebView2Controller { get; set; }
    CoreWebView2ControllerOptions? _controllerOptions { get; set; }

    [Browsable(false)]
    public CoreWebView2? CoreWebView2
    {
        get
        {
            VerifyNotDisposed();
            VerifyBrowserNotCrashed();
            return _coreWebView2Controller?.CoreWebView2;
        }
    }
}
