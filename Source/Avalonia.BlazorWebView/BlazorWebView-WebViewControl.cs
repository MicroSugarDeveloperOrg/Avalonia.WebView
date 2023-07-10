namespace AvaloniaBlazorWebView;

partial class BlazorWebView
{
    public bool IsCanGoForward => _platformWebView?.IsCanGoForward ?? false;

    public bool IsCanGoBack => _platformWebView?.IsCanGoBack ?? false;

    public bool Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.Navigate(uri);
    }

    public bool NavigateToString(string htmlContent)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.NavigateToString(htmlContent);
    }

    public bool GoBack()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.GoBack();
    }

    public bool GoForward()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.GoForward();
    }

    public bool Stop()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.Stop();
    }

    public bool Reload()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.Reload();
    }

    public Task<string?> ExecuteScriptAsync(string javaScript)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return Task.FromResult<string?>(default);

        return _platformWebView.ExecuteScriptAsync(javaScript);
    }

    public bool PostWebMessageAsJson(string webMessageAsJson, Uri? baseUri)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.PostWebMessageAsString(webMessageAsJson, baseUri);
    }

    public bool PostWebMessageAsString(string webMessageAsString, Uri? baseUri)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.PostWebMessageAsString(webMessageAsString, baseUri);
    }

    public bool OpenDevToolsWindow()
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

        return _platformWebView.OpenDevToolsWindow();
    }

}
