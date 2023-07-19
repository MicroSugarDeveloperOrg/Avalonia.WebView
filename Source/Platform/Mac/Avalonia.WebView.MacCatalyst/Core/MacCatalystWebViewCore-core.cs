namespace Avalonia.WebView.MacCatalyst.Core;
partial class MacCatalystWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider)
    {
        WebView.NavigationDelegate = new WebViewNavigationDelegate(this, _callBack, _filter);
        //WebView.UIDelegate = new WebViewUIDelegate();

        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }

    private void MessageReceived(Uri uri, string message)
    {
        WebViewMessageReceivedEventArgs args = new()
        {
            Source = uri,
            Message = message
        };

        if (args.Source is null && _webView.Url is not null)
            args.Source = new Uri(_webView.Url.AbsoluteString);

        _callBack?.PlatformWebViewMessageReceived(this, args);
        _provider?.PlatformWebViewMessageReceived(this, new WebViewMessageReceivedEventArgs() { Source = uri, Message = message });
    }
}
