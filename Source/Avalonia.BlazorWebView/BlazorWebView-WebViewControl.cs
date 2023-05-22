namespace AvaloniaBlazorWebView;

partial class BlazorWebView
{
    bool IWebViewControl.IsCanGoForward => _platformWebView?.IsCanGoForward ?? false;

    bool IWebViewControl.IsCanGoBack => _platformWebView?.IsCanGoBack ?? false;

    bool IWebViewControl.Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.Navigate(uri);
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.NavigateToString(htmlContent);
    }

    bool IWebViewControl.GoBack()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.GoBack();
    }

    bool IWebViewControl.GoForward()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.GoForward();
    }

    bool IWebViewControl.Stop()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.Stop();
    }

    bool IWebViewControl.Reload()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.Reload();
    }

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return Task.FromResult<string?>(default);

        return _platformWebView.ExecuteScriptAsync(javaScript);
    }

    bool IWebViewControl.PostWebMessageAsJson(string webMessageAsJson, Uri? baseUri)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.PostWebMessageAsString(webMessageAsJson, baseUri);
    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString, Uri? baseUri)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.PostWebMessageAsString(webMessageAsString, baseUri);
    }

    bool IWebViewControl.OpenDevToolsWindow()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.OpenDevToolsWindow();
    }

}
