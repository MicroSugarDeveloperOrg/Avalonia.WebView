namespace Avalonia.WebView.iOS.Core;

partial class IosWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider)
    {
        if (provider is null)
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        _config.UserContentController.AddScriptMessageHandler(new WebViewScriptMessageHandler(filter.BaseUri, MessageReceived), _filterKeyWord);
        _config.UserContentController.AddUserScript(new WKUserScript(new NSString(BlazorScriptHelper.BlazorStartingScript), WKUserScriptInjectionTime.AtDocumentEnd, true));

        _config.SetUrlSchemeHandler(new SchemeHandler(this, provider, filter), urlScheme: filter.Scheme);
        WebView.NavigationDelegate = new WebViewNavigationDelegate(this, _callBack, filter);
        WebView.UIDelegate = new WebViewUIDelegate();

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

