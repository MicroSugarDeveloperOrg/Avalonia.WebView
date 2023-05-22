namespace Avalonia.WebView.Mac.Core;

partial class MacWebViewCore
{
    public IntPtr NativeHandler { get; private set; }
    MacWebViewCore IPlatformWebView<MacWebViewCore>.PlatformView => this;

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => this;

    bool IWebViewControl.IsCanGoForward => WebView.CanGoForward();

    bool IWebViewControl.IsCanGoBack => WebView.CanGoBack();

    async Task<bool> IPlatformWebView.Initialize()
    {
        if (IsInitialized)
            return true;
 
        NSApplication.Init();
        try
        {
            _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());

            RegisterWebViewEvents(WebView);

            await PrepareBlazorWebViewStarting(_provider);

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

    bool IWebViewControl.GoBack() => WebView.GoBack();

    bool IWebViewControl.GoForward() => WebView.GoForward();

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
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        ((IDisposable)this)?.Dispose();
        return new ValueTask();
    }
}
