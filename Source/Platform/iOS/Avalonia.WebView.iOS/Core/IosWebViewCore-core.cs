namespace Avalonia.WebView.iOS.Core;

partial class IosWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider)
    {
        if (_filter is not null)
        {
            WebView.NavigationDelegate = new WebViewNavigationDelegate(this, _callBack, _filter);
            WebView.UIDelegate = new WebViewUIDelegate();
        }
 
        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }

    private void MessageReceived(Uri uri, string message)
    {
        _provider?.PlatformWebViewMessageReceived(this, new WebViewMessageReceivedEventArgs() { Source = uri, Message = message });
    }
}

