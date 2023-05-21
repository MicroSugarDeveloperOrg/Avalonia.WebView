namespace Avalonia.WebView.Android.Core;

partial class AndroidWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider)
    {
        if (provider is null)
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        var blazorProvider = AvaloniaLocator.Current.GetRequiredService<IPlatformBlazorWebViewProvider>();
      
        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }
}

