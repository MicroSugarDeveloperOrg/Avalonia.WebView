namespace Avalonia.WebView.Android.Core;

public partial class AndroidWebViewCore : IPlatformWebView<AndroidWebViewCore>
{
    public AndroidWebViewCore(ViewHandler handler, IVirtualWebViewControlCallBack callback, IVirtualBlazorWebViewProvider? provider, WebViewCreationProperties webViewCreationProperties)
    {
        _provider = provider;
        _callBack = callback;
        _handler = handler;
        _creationProperties = webViewCreationProperties;

        _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());
        AndroidWebView.SetWebContentsDebuggingEnabled(webViewCreationProperties.AreDevToolEnabled);

        var parentContext = AndroidApplication.Context;
        var webView = new AndroidWebView(parentContext)
        {
#pragma warning disable CS0618, CA1422  // Type or member is obsolete // Validate platform compatibility
            LayoutParameters = new AbsoluteLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent, 0, 0),
#pragma warning restore CS0618, CA1422 // Type or member is obsolete
        };
        webView.SetBackgroundColor(new AndroidColor(webViewCreationProperties.DefaultWebViewBackgroundColor.R, webViewCreationProperties.DefaultWebViewBackgroundColor.G, webViewCreationProperties.DefaultWebViewBackgroundColor.B));

        _webView = webView;
        NativeHandler = webView.Handle;
        RegisterEvents();
    }

    ~AndroidWebViewCore()
    {
        Dispose(disposing: false);
    }

    AndroidWebView _webView;
    readonly IVirtualBlazorWebViewProvider? _provider;
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

    WebViewClient? _webViewClient;
    WebChromeClient? _webChromeClient;

    public AndroidWebView WebView
    {
        get => _webView;
        set => _webView = value;
    }
}

