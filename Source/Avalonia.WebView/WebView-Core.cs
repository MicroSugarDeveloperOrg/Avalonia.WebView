namespace AvaloniaWebView;

partial class WebView
{
    async Task<bool> Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        if (_platformWebView is null)
            return false;

        if (!_platformWebView.IsInitialized)
        {
            var bRet = await _platformWebView.Initialize();
            if (!bRet)
                return false;
        }

        return _platformWebView.Navigate(uri);
    }

    async Task<bool> NavigateToString(string? htmlContent)
    {
        if (string.IsNullOrWhiteSpace(htmlContent))
            return false;

        if (_platformWebView is null)
            return false;

        if (!_platformWebView.IsInitialized)
        {
            var bRet = await _platformWebView.Initialize();
            if (!bRet)
                return false;
        }

        return _platformWebView.NavigateToString(htmlContent!);
    }

}
