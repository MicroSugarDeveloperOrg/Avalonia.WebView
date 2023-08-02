using Avalonia.WebView.Mac.Delegates;
using Avalonia.WebView.Mac.Helpers;
using System.Web;

namespace Avalonia.WebView.Mac.Core;
partial class MacWebViewCore  
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider)
    {
        WebView.NavigationDelegate = new WebViewNavigationDelegate(this, _callBack, _filter);
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

        if (args.Source is null && _webView.Url is not null && !string.IsNullOrWhiteSpace(_webView.Url.AbsoluteString))
            args.Source = new Uri(_webView.Url.AbsoluteString);

        _callBack?.PlatformWebViewMessageReceived(this, args);
        _provider?.PlatformWebViewMessageReceived(this, new WebViewMessageReceivedEventArgs() { Source = uri, Message = message });
    }

}
