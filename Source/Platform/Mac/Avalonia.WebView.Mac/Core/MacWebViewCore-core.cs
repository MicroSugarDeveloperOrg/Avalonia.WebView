namespace Avalonia.WebView.Mac.Core;
partial class MacWebViewCore  
{
    Task PrepareBlazorWebViewStarting(IVirtualWebViewProvider? provider)
    {
        if (provider is null )
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var fileter))
            return Task.CompletedTask;

        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }
}
