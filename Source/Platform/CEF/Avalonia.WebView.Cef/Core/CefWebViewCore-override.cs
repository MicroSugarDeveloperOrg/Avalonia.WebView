using CefGlue.Adapter.Browser;

namespace Avalonia.WebView.Core;

partial class CefWebViewCore
{
    CefWebViewCore IPlatformWebView<CefWebViewCore>.PlatformView => throw new NotImplementedException();

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => this;

    IntPtr IPlatformWebView.NativeHandler =>  IntPtr.Zero;  

    bool IWebViewControl.IsCanGoForward
    {
        get 
        {
            if (_cefBrowser is null)
                return false;

            return _cefBrowser.CanGoForward;
        }
    }

    bool IWebViewControl.IsCanGoBack
    {
        get
        {
            if (_cefBrowser is null)
                return false;

            return _cefBrowser.CanGoBack;   
        }
    }

    Task<bool> IPlatformWebView.Initialize()
    {
        if (IsInitialized)
            return Task.FromResult(true);

        var settings = new CefBrowserSettings();
        _settings = settings;
        var cefClient = new CefClientAdapter(this, this, this, this, this);
        _cefClient = cefClient;

        var windowInfo = CefWindowInfo.Create();
        windowInfo.SetAsWindowless(IntPtr.Zero, true);
        CefBrowserHost.CreateBrowser(windowInfo, _cefClient!, _settings!, "http://www.bilibili.com");

        IsInitialized = true;
        return Task.FromResult(true);
    }

    bool IWebViewControl.GoBack()
    {
        if (_cefBrowser is null)
            return false;

        _cefBrowser.GoBack();
        return true;
    }

    bool IWebViewControl.GoForward()
    {
        if (_cefBrowser is null)
            return false;

        _cefBrowser.GoForward();
        return true;
    }

    bool IWebViewControl.Navigate(Uri? uri)
    {
        _uri = uri;
        if (_cefBrowser is null)
            return false;

        if (uri is null)
            return false;

        _cefBrowser.GetMainFrame().LoadUrl(uri.ToString());
        return true;
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        if (_cefBrowser is null)
            return false;

        if (string.IsNullOrWhiteSpace(htmlContent))
            return false;


        //_cefBrowser.GetMainFrame().LoadRequest(new CefRequest() { })

        return true;
    }

    bool IWebViewControl.OpenDevToolsWindow()
    {
        if (_cefBrowserHost is null)
            return false;

        //_cefBrowserHost.ShowDevTools

        return true;
    }

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.PostWebMessageAsJson(string webMessageAsJson, Uri? baseUri)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString, Uri? baseUri)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Reload()
    {
        if (_cefBrowser is null)
            return false;

        _cefBrowser.Reload();
        return true;
    }

    bool IWebViewControl.Stop()
    {
        if (_cefBrowser is null)
            return false;

        _cefBrowser.StopLoad();
        return true;
    }

    void IDisposable.Dispose()
    {
        Disposing();
        //throw new NotImplementedException();
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        // throw new NotImplementedException();
        Disposing();
        return new ValueTask();
    }

    void Disposing()
    {
        if (IsDisposed)
            return;

        IsDisposing = true;

        DetachViewHandlers();

        _cefClient = null;
        _cefBrowser?.Dispose();
        _cefBrowser = null;
        _cefBrowserHost?.CloseBrowser();
        _cefBrowserHost?.Dispose();
        _cefBrowserHost = null;

        IsDisposed = true;
    }
}
