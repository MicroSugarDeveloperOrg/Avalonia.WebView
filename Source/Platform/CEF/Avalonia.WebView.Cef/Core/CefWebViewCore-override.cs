namespace Avalonia.WebView.Core;
partial class CefWebViewCore  
{
    CefWebViewCore IPlatformWebView<CefWebViewCore>.PlatformView => throw new NotImplementedException();

    bool IPlatformWebView.IsInitialized => throw new NotImplementedException();

    object? IPlatformWebView.PlatformViewContext => throw new NotImplementedException();

    IntPtr IPlatformWebView.NativeHandler => throw new NotImplementedException();

    bool IWebViewControl.IsCanGoForward => throw new NotImplementedException();

    bool IWebViewControl.IsCanGoBack => throw new NotImplementedException();

    Task<bool> IPlatformWebView.Initialize()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        throw new NotImplementedException();
    }
}
