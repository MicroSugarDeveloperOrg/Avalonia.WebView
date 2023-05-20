namespace Avalonia.WebView.iOS.Core;

partial class IosWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualWebViewProvider? provider)
    {
        if (provider is null)
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        // iOS WKWebView doesn't allow handling 'http'/'https' schemes, so we use the fake 'app' scheme
        var blazorProvider = AvaloniaLocator.Current.GetRequiredService<IPlatformBlazorWebViewProvider>();
        _config.SetUrlSchemeHandler(new SchemeHandler(), urlScheme: blazorProvider.Scheme);

        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }
}

