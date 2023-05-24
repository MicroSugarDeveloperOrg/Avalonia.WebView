using Linux.WebView.Core.Extensions;

namespace Linux.WebView.Core.Core;
internal class LinuxWebViewCore : ILinuxWebView
{
    public LinuxWebViewCore(ILinuxDispatcher dispatcher, Gtk.Application application)
    {
        _application = application;
        _dispathcer = dispatcher;

        Gtk.Window window = default!;
        WebKit.WebView webView = default!;

        var bRet = dispatcher.InvokeAsync(() =>
        {
            window = new Gtk.Window(Gtk.WindowType.Toplevel);
            window.Title = nameof(WebView);
            window.KeepAbove = true;
            _application.AddWindow(window);

            webView = new WebKit.WebView();
            webView.Realize();

            window.Add(webView);
            window.ShowAll();
            window.Present();

        }).Result;

        if (!bRet)
            throw new ArgumentNullException(nameof(WebKit.WebView));
        
        _window = window;
        _webView = webView;
    }
    ~LinuxWebViewCore()
    {
        Dispose(disposing: false);
    }

    readonly Gtk.Application _application;
    readonly ILinuxDispatcher _dispathcer;
    readonly Gtk.Window _window;
    readonly WebKit.WebView _webView;

    public WebKit.WebView WebView => _webView;

    bool _isDisposed = false;
    public bool IsDisposed
    {
        get => _isDisposed;
        set => _isDisposed = value;
    }

    nint ILinuxWebView.NativeHandle => IsDisposed ? IntPtr.Zero : _window.X11Handle();

    //bool ILinuxWebView.IsCanGoBack
    //{
    //    get
    //    {
    //        if (IsDisposed)
    //            return false;

    //        bool isCanGoBack = false;
    //        _dispathcer.Invoke(() => isCanGoBack = _webView.CanGoBack());

    //        return isCanGoBack;
    //    }
    //}

    //bool ILinuxWebView.IsCanGoForward
    //{
    //    get
    //    {
    //        if (IsDisposed)
    //            return false;

    //        bool isCanGoForward = false;
    //        _dispathcer.Invoke(() => isCanGoForward = _webView.CanGoForward());

    //        return isCanGoForward;
    //    }
    //}

    //bool ILinuxWebView.GoBack()
    //{
    //    if (IsDisposed)
    //        return false;

    //    bool isFlag = false;
    //    _dispathcer.Invoke(() => 
    //    {
    //        if (!_webView.CanGoBack())
    //        {
    //            isFlag = false;
    //            return;
    //        }
            
    //        _webView.GoBack();
    //        isFlag = true;
    //    });

    //    return isFlag;
    //}

    //bool ILinuxWebView.GoForward()
    //{
    //    if (IsDisposed)
    //        return false;

    //    bool isFlag = false;
    //    _dispathcer.Invoke(() =>
    //    {
    //        if (!_webView.CanGoForward())
    //        {
    //            isFlag = false;
    //            return;
    //        }

    //        _webView.GoForward();
    //        isFlag = true;
    //    });

    //    return isFlag;
    //}

    //bool ILinuxWebView.LoadUri(Uri? uri)
    //{
    //    if (IsDisposed)
    //        return false;

    //    if (uri is null)
    //        return false;

    //    _dispathcer.Invoke(() => _webView.LoadUri(uri.AbsoluteUri));
    //    return true;
    //}

    //bool ILinuxWebView.LoadHtml(string htmlContent)
    //{
    //    if (IsDisposed)
    //        return false;

    //    if (string.IsNullOrWhiteSpace(htmlContent))
    //        return false;

    //    _dispathcer.Invoke(() => _webView.LoadHtml(htmlContent));
    //    return true;
    //}

    //bool ILinuxWebView.OpenDevToolWindow()
    //{
    //    return true;
    //}

    //bool ILinuxWebView.RunJavascript(string webMessageAsString, Uri? baseUri)
    //{
    //    if (IsDisposed)
    //        return false;

    //    if (string.IsNullOrWhiteSpace(webMessageAsString))
    //        return false;

    //    bool isFlag = false;    
    //    _dispathcer.Invoke(() => _webView.RunJavascript(webMessageAsString, default, (GLib.Object source_object, GLib.IAsyncResult res) =>
    //    {
    //        isFlag = res.LegacyPropagateError();
    //    }));
    //    return isFlag;    
    //}

    //bool ILinuxWebView.Reload()
    //{
    //    if (IsDisposed)
    //        return false;

    //    _dispathcer.Invoke(_webView.Reload);
    //    return true;
    //}

    //bool ILinuxWebView.Stop()
    //{
    //    if (IsDisposed)
    //        return false;

    //    _dispathcer.Invoke(_webView.StopLoading);
    //    return true;
    //}

    protected virtual void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
                 
            }

            var bRet = _dispathcer.InvokeAsync(() =>
            {
                _webView.Dispose(); 
                _window.Dispose();
                _application.RemoveWindow(_window);
            }).Result;

            IsDisposed = true;
        }
    }

    void IDisposable.Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
