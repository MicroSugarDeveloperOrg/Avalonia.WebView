namespace Avalonia.WebView.Mac.Core;

partial class MacWebViewCore
{
    public IntPtr NativeHandler { get; private set; }
    MacWebViewCore IPlatformWebView<MacWebViewCore>.PlatformView => this;

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => this;

    bool IWebViewControl.IsCanGoForward => throw new NotImplementedException();

    bool IWebViewControl.IsCanGoBack => throw new NotImplementedException();

    async Task<bool> IPlatformWebView.Initialize(IVirtualWebViewProvider? virtualProvider)
    {
        if (IsInitialized)
            return true;

        _provider = virtualProvider;

        NSApplication.Init();
        try
        {
            _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());

            RegisterWebViewEvents(WebView);

            await PrepareBlazorWebViewStarting(virtualProvider);

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
        throw new NotImplementedException();
    }

    bool IWebViewControl.GoForward()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        using var nsUrl = new NSUrl(uri.AbsoluteUri);
        using var request = new NSUrlRequest(nsUrl);
        WebView.MainFrame.LoadRequest(request);
        return true;
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        if (!string.IsNullOrWhiteSpace(htmlContent))
        {
            WebView.MainFrame.LoadHtmlString(htmlContent, default);
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
        throw new NotImplementedException();
    }

    bool IWebViewControl.Reload()
    {
        WebView.MainFrame.Reload();
        return true;
    }

    bool IWebViewControl.Stop()
    {
        WebView.MainFrame.StopLoading();
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
                    ClearBlazorWebViewCompleted();
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
