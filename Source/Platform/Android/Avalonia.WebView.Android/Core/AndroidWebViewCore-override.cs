using Avalonia.WebView.Android.Clients;
using Avalonia.WebView.Android.Handlers;

namespace Avalonia.WebView.Android.Core;

partial class AndroidWebViewCore
{
    AndroidWebViewCore IPlatformWebView<AndroidWebViewCore>.PlatformView => this;

    public nint NativeHandler { get; private set; }

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => this;

    bool IWebViewControl.IsCanGoForward => WebView.CanGoForward();

    bool IWebViewControl.IsCanGoBack => WebView.CanGoBack();

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        _webView.EvaluateJavascript(javaScript, new JavaScriptValueCallback(result =>
        {
            

        }));
        throw new NotImplementedException();
    }

    bool IWebViewControl.GoBack()
    {
        var webView = WebView;
        if (webView is null)
            return false;

        if (!webView.CanGoBack())
            return false;

        webView.GoBack();
        return true;
    }

    bool IWebViewControl.GoForward()
    {
        var webView = WebView;
        if (webView is null)
            return false;

        if (!webView.CanGoForward())
            return false;

        webView.GoForward();
        return true;
    }

    async Task<bool> IPlatformWebView.Initialize(IVirtualBlazorWebViewProvider? virtualProvider)
    {
        if (IsInitialized)
            return true;

        _provider = virtualProvider;
        var webview = WebView;

        webview.Settings.SetSupportMultipleWindows(true);
        webview.Settings.JavaScriptEnabled = true;
        webview.Settings.DomStorageEnabled = true;
        webview.Settings.SetSupportZoom(true);
        //webview.ZoomBy(1.2f);
        _webViewClient = new WebViewClient();
        webview.SetWebViewClient(_webViewClient);

        _webChromeClient = new WebChromeClient();
        //_webChromeClient = new WebChromeClient();
        webview.SetWebChromeClient(_webChromeClient);

        await PrepareBlazorWebViewStarting(virtualProvider);

        return true;
    }

    bool IWebViewControl.Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        var webView = WebView;
        if (webView is null)
            return false;

        webView.LoadUrl(uri.AbsoluteUri);
        return true;
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        if (string.IsNullOrWhiteSpace(htmlContent))
            return false;

        var webView = WebView;
        if (webView is null)
            return false;

        webView.LoadData(htmlContent, default, default);
        return true;
    }

    bool IWebViewControl.OpenDevToolsWindow()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.PostWebMessageAsJson(string webMessageAsJson)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Reload()
    {
        var webView = WebView;
        if (webView is null)
            return false;

        webView.Reload();
        return true;
    }

    bool IWebViewControl.Stop()
    {
        var webView = WebView;
        if (webView is null)
            return false;

        webView.StopLoading();
        return true;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            ClearBlazorWebViewCompleted();
            UnregisterEvents();
            WebView.Dispose();
            WebView = default!;
            IsDisposed = true;
        }
    }

    void IDisposable.Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }


    ValueTask IAsyncDisposable.DisposeAsync()
    {
        ((IDisposable)this)?.Dispose();
        return new ValueTask();
    }

}

