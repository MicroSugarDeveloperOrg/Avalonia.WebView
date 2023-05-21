namespace Avalonia.WebView.Android.Core;

partial class AndroidWebViewCore
{
    Task<bool> PrepareBlazorWebViewStarting(AndroidWebView webView, IVirtualBlazorWebViewProvider? provider)
    {
        if (webView is null)
            return Task.FromResult(false);

        if (provider is null)
            return Task.FromResult(false);

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.FromResult(false);

        _webViewClient = new AvaloniaWebViewClient(this, _callBack, provider, filter);
        _webChromeClient = new AvaloniaWebChromeClient(this);
        webView.SetWebViewClient(_webViewClient);
        webView.SetWebChromeClient(_webChromeClient);
        _isBlazorWebView = true;
        return Task.FromResult(true);
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }
}

