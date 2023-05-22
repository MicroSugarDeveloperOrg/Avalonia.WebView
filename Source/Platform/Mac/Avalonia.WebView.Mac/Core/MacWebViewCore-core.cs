using Avalonia.WebView.Mac.Helpers;

namespace Avalonia.WebView.Mac.Core;
partial class MacWebViewCore  
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider)
    {
        if (provider is null )
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        MacosWebView.RegisterUrlSchemeAsLocal(filter.Scheme);

        //NSHttpUrlResponse

        WebView.StringByEvaluatingJavaScriptFromString(BlazorScriptHelper.BlazorStartingScript);

        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted()
    {
        _isBlazorWebView = false;
    }

    

}
