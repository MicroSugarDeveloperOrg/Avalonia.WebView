namespace Avalonia.WebView.Linux.Core;

partial class LinuxWebViewCore
{
    public IntPtr NativeHandler { get; private set; }
    LinuxWebViewCore IPlatformWebView<LinuxWebViewCore>.PlatformView => this;

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => this;

    bool IWebViewControl.IsCanGoForward => _dispatcher.Invoke(WebView.CanGoForward);

    bool IWebViewControl.IsCanGoBack => _dispatcher.Invoke(WebView.CanGoBack);

    async Task<bool> IPlatformWebView.Initialize()
    {
        if (IsInitialized)
            return true;

        try
        {
            _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());

            _dispatcher.Invoke(() =>
            {
                WebView.Settings.EnableDeveloperExtras = _creationProperties.AreDevToolEnabled;
                WebView.Settings.AllowFileAccessFromFileUrls = true;
                WebView.Settings.AllowModalDialogs = true;
                WebView.Settings.AllowTopNavigationToDataUrls = true;
                WebView.Settings.AllowUniversalAccessFromFileUrls = true;
                WebView.Settings.EnableBackForwardNavigationGestures = true;
                WebView.Settings.EnableCaretBrowsing = true;
                WebView.Settings.EnableMediaCapabilities = true;
                WebView.Settings.EnableMediaStream = true;
                WebView.Settings.JavascriptCanAccessClipboard = true;
                WebView.Settings.JavascriptCanOpenWindowsAutomatically = true;
            });


            RegisterWebViewEvents(WebView);

            await PrepareBlazorWebViewStarting(_provider, WebView);

            IsInitialized = true;
            _callBack.PlatformWebViewCreated(this, new WebViewCreatedEventArgs { IsSucceed = true });

            return true;
        }
        catch (Exception ex)
        {
            _callBack.PlatformWebViewCreated(this, new WebViewCreatedEventArgs { IsSucceed = false, Message = ex.ToString() });
        }

        return false;
    }

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        if (string.IsNullOrWhiteSpace(javaScript))
            return Task.FromResult<string?>(default);

        var messageJSStringLiteral = HttpUtility.JavaScriptStringEncode(javaScript);
        var script = $"{_dispatchMessageCallback}((\"{messageJSStringLiteral}\"))";

        _dispatcher.Invoke(() =>
        {
            WebView.RunJavascript(script, default, (GLib.Object source_object, GLib.IAsyncResult res) =>
            {
        
            });
        }) ;

        return Task.FromResult<string?>(string.Empty);
    }

    bool IWebViewControl.GoBack()
    {
        return _dispatcher.Invoke(() =>
        {
            if (!WebView.CanGoBack())
                return false;

            WebView.GoBack();
            return true;
        });
    }

    bool IWebViewControl.GoForward()
    {
        return _dispatcher.Invoke(() =>
        {
            if (!WebView.CanGoForward())
                return false;

            WebView.GoForward();
            return true;
        });

    }

    bool IWebViewControl.Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        _dispatcher.Invoke(() => WebView.LoadUri(uri.AbsoluteUri));
        return true;
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        if (string.IsNullOrWhiteSpace(htmlContent))
            return false;

        _dispatcher.Invoke(() => WebView.LoadHtml(htmlContent));
        return true;
    }

    bool IWebViewControl.OpenDevToolsWindow()
    {
        return false;
    }

    bool IWebViewControl.PostWebMessageAsJson(string webMessageAsJson, Uri? baseUri)
    {
        if (string.IsNullOrWhiteSpace(webMessageAsJson))
            return false;

        var messageJSStringLiteral = HttpUtility.JavaScriptStringEncode(webMessageAsJson);
        var script = $"{_dispatchMessageCallback}((\"{messageJSStringLiteral}\"))";

        _dispatcher.Invoke(() =>
        {
            WebView.RunJavascript(script, default, (GLib.Object source_object, GLib.IAsyncResult res) =>
            {

            });
        });

        return true;
    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString, Uri? baseUri)
    {
        if (string.IsNullOrWhiteSpace(webMessageAsString))
            return false;

        var messageJSStringLiteral = HttpUtility.JavaScriptStringEncode(webMessageAsString);
        var script = $"{_dispatchMessageCallback}((\"{messageJSStringLiteral}\"))";

        _dispatcher.Invoke(() =>
        {
            WebView.RunJavascript(script, default, (GLib.Object source_object, GLib.IAsyncResult res) =>
            {

            });
        });

        return true;
    }

    bool IWebViewControl.Reload()
    {
        _dispatcher.Invoke(WebView.Reload);
        return true;
    }

    bool IWebViewControl.Stop()
    {
        _dispatcher.Invoke(WebView.StopLoading);
        return true;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
                try
                {
                    ClearBlazorWebViewCompleted(WebView);
                    UnregisterWebViewEvents(WebView);
                    UnregisterEvents();

                    _linuxWebView.Dispose();
                }
                catch (Exception)
                {

                }
            }

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
