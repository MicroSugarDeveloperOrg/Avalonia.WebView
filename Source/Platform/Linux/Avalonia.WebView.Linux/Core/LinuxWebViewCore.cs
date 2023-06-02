namespace Avalonia.WebView.Linux.Core;

public partial class LinuxWebViewCore : IPlatformWebView<LinuxWebViewCore>
{
    public LinuxWebViewCore(ViewHandler handler, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        _provider = provider;
        _messageKeyWord = "webview";
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;

        var container = GtkInteropHelper.RunOnGlibThread(() =>
        {
            GWindow window = new(WindowType.Toplevel);
            WebKitWebView webView = new()
            {
                Valign = Align.Center,
                Halign = Align.Center,
                Hexpand = true,
                Vexpand = true,
                Visible = true,
            };
            window.Add(webView);  
            window.Show();
            IntPtr xid = GtkApi.gdk_x11_window_get_xid(window.Window.Handle);
            return (window, webView, xid);
        }).Result;

        _hostWindow = container.window;
        _webView = container.webView;
        NativeHandler = container.xid;
        RegisterEvents();
    }

    ~LinuxWebViewCore()
    {
        Dispose(disposing: false);
    }

    readonly GWindow _hostWindow;
    readonly WebKitWebView _webView;
    readonly string _messageKeyWord;
    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandler _handler;
    readonly WebViewCreationProperties _creationProperties;
    readonly string _dispatchMessageCallback = "__dispatchMessageCallback";

    WebScheme? _webScheme;

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

    public WebKitWebView WebView => _webView;

}
