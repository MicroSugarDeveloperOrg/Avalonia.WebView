using System.Text.Encodings.Web;
namespace Avalonia.WebView.MacCatalyst.Core;

partial class MacCatalystWebViewCore
{
    MacCatalystWebViewCore IPlatformWebView<MacCatalystWebViewCore>.PlatformView => this;

    public nint NativeHandler { get; private set; }

    bool IPlatformWebView.IsInitialized => IsInitialized;

    object? IPlatformWebView.PlatformViewContext => this;

    bool IWebViewControl.IsCanGoForward => WebView.CanGoForward;

    bool IWebViewControl.IsCanGoBack => WebView.CanGoBack;

    async Task<bool> IPlatformWebView.Initialize()
    {
        if (IsInitialized)
            return true;

        await PrepareBlazorWebViewStarting(_provider);

        IsInitialized = true;
        _callBack.PlatformWebViewCreated(this, new WebViewCreatedEventArgs() { IsSucceed = true });
        return true;
    }

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        if (WebView is null)
            return Task.FromResult<string?>(default);

        if (string.IsNullOrWhiteSpace(javaScript))
            return Task.FromResult<string?>(default);

        string? resultString = default;
        var messageJSStringLiteral = JavaScriptEncoder.Default.Encode(javaScript);
        WebView.EvaluateJavaScript(javascript: $"{_dispatchMessageCallback}(\"{messageJSStringLiteral}\")",
                                   completionHandler: (NSObject result, NSError error) =>
                                   {
                                       resultString = result.ToString();
                                   });

        return Task.FromResult(resultString); ;
    }

    bool IWebViewControl.GoBack()
    {
        if (WebView is null)
            return false;

        if (!WebView.CanGoBack)
            return false;

        return WebView.GoBack() == null ? false : true;
    }

    bool IWebViewControl.GoForward()
    {
        if (WebView is null)
            return false;

        if (!WebView.CanGoForward)
            return false;

        return WebView.GoForward() == null ? false : true;
    }

    bool IWebViewControl.Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        using var nsUrl = new NSUrl(uri.AbsoluteUri);
        using var request = new NSUrlRequest(nsUrl);

        return WebView.LoadRequest(request) == null ? false : true;
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        if (string.IsNullOrWhiteSpace(htmlContent))
            return false;

        return WebView.LoadHtmlString(htmlContent, default!) == null ? false : true;
    }

    bool IWebViewControl.OpenDevToolsWindow()
    {
        return true;
    }

    bool IWebViewControl.PostWebMessageAsJson(string webMessageAsJson, Uri? baseUri)
    {
        if (string.IsNullOrWhiteSpace(webMessageAsJson))
            return false;

        var messageJSStringLiteral = JavaScriptEncoder.Default.Encode(webMessageAsJson);
        WebView.EvaluateJavaScript(javascript: $"{_dispatchMessageCallback}(\"{messageJSStringLiteral}\")",
                                   completionHandler: (NSObject result, NSError error) =>
                                   {

                                   });
        return true;
    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString, Uri? baseUri)
    {
        if (string.IsNullOrWhiteSpace(webMessageAsString))
            return false;

        var messageJSStringLiteral = JavaScriptEncoder.Default.Encode(webMessageAsString);
        WebView.EvaluateJavaScript(javascript: $"{_dispatchMessageCallback}(\"{messageJSStringLiteral}\")",
                                   completionHandler: (NSObject result, NSError error) =>
                                   {

                                   });
        return true;
    }

    bool IWebViewControl.Reload()
    {
        if (WebView is null)
            return false;

        WebView.Reload();
        return true;
    }

    bool IWebViewControl.Stop()
    {
        if (WebView is null)
            return false;

        WebView.StopLoading();
        return true;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {

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
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        ((IDisposable)this)?.Dispose();
        return new ValueTask();
    }
}
