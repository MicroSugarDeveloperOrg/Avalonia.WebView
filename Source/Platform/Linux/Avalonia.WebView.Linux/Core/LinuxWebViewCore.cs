using Avalonia.WebView.Linux.Extensions;
using Avalonia.WebView.Linux.Runtimes;

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

        _linuxApplication = new();
        var bRet = _linuxApplication.RunAsync().Result;
        if (!bRet)
            throw new ArgumentNullException(nameof(LinuxApplication));
        _webView = new LinuxWebView();
        var webViewWindow =  _linuxApplication.CreatWindow(_webView);
        if (webViewWindow is null)
            throw new ArgumentNullException(nameof(webViewWindow));

        NativeHandler = webViewWindow.Handler();
        RegisterEvents();
    }

    ~LinuxWebViewCore()
    {
        Dispose(disposing: false);
    }

    readonly LinuxApplication _linuxApplication;

    LinuxWebView _webView;
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

    public LinuxWebView WebView
    {
        get => _webView;
        private set => _webView = value;
    }

}
