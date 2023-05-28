using System.Web;

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
 
        try
        {
            _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());
           
            RegisterWebViewEvents(WebView);
            WebView.Preferences.JavaEnabled = true;
            WebView.Preferences.JavaScriptEnabled = true;
            WebView.Preferences.JavaScriptCanOpenWindowsAutomatically = true;
            //WebView.Preferences.PrivateBrowsingEnabled = true;
            //WebView.Preferences.AllowAir
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
        if (string.IsNullOrWhiteSpace(javaScript))
            return Task.FromResult<string?>(default);

        var messageJSStringLiteral = HttpUtility.JavaScriptStringEncode(javaScript);
        var script = $"{_dispatchMessageCallback}((\"{messageJSStringLiteral}\"))";

        var result = WebView.StringByEvaluatingJavaScriptFromString(script);
        return Task.FromResult<string?>(result);
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
        if (string.IsNullOrWhiteSpace(htmlContent))
            return false;

        WebView.MainFrame.LoadHtmlString(htmlContent, default!);
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

        WebView.WindowScriptObject.EvaluateWebScript(script);
        return true;

    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString, Uri? baseUri)
    {
        if (string.IsNullOrWhiteSpace(webMessageAsString))
            return false;

        var messageJSStringLiteral = HttpUtility.JavaScriptStringEncode(webMessageAsString);
        var script = $"{_dispatchMessageCallback}((\"{messageJSStringLiteral}\"))";

        WebView.WindowScriptObject.EvaluateWebScript(script);
        return true;
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
