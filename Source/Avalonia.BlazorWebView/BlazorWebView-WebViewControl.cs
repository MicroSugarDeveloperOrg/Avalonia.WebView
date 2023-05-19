using System;

namespace AvaloniaBlazorWebView;

partial class BlazorWebView  
{
    bool IWebViewControl.IsCanGoForward => throw new NotImplementedException();

    bool IWebViewControl.IsCanGoBack => throw new NotImplementedException();

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

    bool IWebViewControl.Stop()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Reload()
    {
        throw new NotImplementedException();
    }

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.PostWebMessageAsJson(string webMessageAsJson)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString)
    {
        if (_platformWebView is null || !_platformWebView.IsInitialized)
            return false;

       return _platformWebView.PostWebMessageAsString(webMessageAsString);
    }

    bool IWebViewControl.OpenDevToolsWindow()
    {
        throw new NotImplementedException();
    }

}
