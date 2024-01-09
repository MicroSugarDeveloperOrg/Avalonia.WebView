using Avalonia.Controls.Platform;
using CefGlue;
using CefGlue.Adapter.Browser;

namespace Avalonia.WebView.Core;
partial class CefWebViewCore  
{
    CefWebViewCore IPlatformWebView<CefWebViewCore>.PlatformView => throw new NotImplementedException();

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => throw new NotImplementedException();

    IntPtr IPlatformWebView.NativeHandler => throw new NotImplementedException();

    bool IWebViewControl.IsCanGoForward => throw new NotImplementedException();

    bool IWebViewControl.IsCanGoBack => throw new NotImplementedException();

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

    private void _handler_Loaded(object sender, RoutedEventArgs e)
    {
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is null)
            return;

        var hWnd = topLevel.TryGetPlatformHandle()?.Handle;
        if (hWnd is null)
            return;
        var windowInfo = CefWindowInfo.Create();
        windowInfo.SetAsWindowless(hWnd.Value, true);

        CefBrowserHost.CreateBrowser(windowInfo, _cefClient!, _settings!, "about:blank");
    }

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.GoBack()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.GoForward()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    bool IWebViewControl.OpenDevToolsWindow()
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
        throw new NotImplementedException();
    }

    bool IWebViewControl.Stop()
    {
        throw new NotImplementedException();
    }

    void IDisposable.Dispose()
    {
        Disposing();
        //throw new NotImplementedException();
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        // throw new NotImplementedException();

        return new ValueTask();
    }

    void Disposing()
    {
        if (IsDisposed)
            return;

        IsDisposing = true;

        _cefClient = null;
        _cefBrowser?.Dispose();
        _cefBrowser = null;
        _cefBrowserHost?.CloseBrowser();
        _cefBrowserHost?.Dispose();
        _cefBrowserHost = null;

        IsDisposed = true;  
    }
}
