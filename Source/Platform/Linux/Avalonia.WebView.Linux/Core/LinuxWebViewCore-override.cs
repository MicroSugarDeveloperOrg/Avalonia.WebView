namespace Avalonia.WebView.Linux.Core;

partial class LinuxWebViewCore
{
    public IntPtr NativeHandler { get; private set; }
    LinuxWebViewCore IPlatformWebView<LinuxWebViewCore>.PlatformView => this;

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => this;

    bool IWebViewControl.IsCanGoForward => WebView.CanGoForward();

    bool IWebViewControl.IsCanGoBack => WebView.CanGoBack();

    async Task<bool> IPlatformWebView.Initialize(IVirtualWebViewProvider? virtualProvider)
    {
        if (IsInitialized)
            return true;

        _provider = virtualProvider;

        try
        {
            _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());

            RegisterWebViewEvents(WebView);

            await PrepareBlazorWebViewStarting(virtualProvider, WebView);

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
        throw new NotImplementedException();
    }

    bool IWebViewControl.GoBack()
    {
        if (!WebView.CanGoBack())
            return false;

        WebView.GoBack();
        return true;
    }

    bool IWebViewControl.GoForward()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        WebView.LoadUri(uri.AbsoluteUri);
        return true;
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        if (!string.IsNullOrWhiteSpace(htmlContent))
        {
            WebView.LoadHtml(htmlContent);
            return true;
        }

        return false;
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
        if (string.IsNullOrWhiteSpace(webMessageAsString))
            return false;
        WebView.RunJavascript(webMessageAsString);
        return true;
    }

    bool IWebViewControl.Reload()
    {
        WebView.Reload();
        return true;
    }

    bool IWebViewControl.Stop()
    {
        WebView.StopLoading();
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

                    WebView.Dispose();
                    WebView = default!;
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
