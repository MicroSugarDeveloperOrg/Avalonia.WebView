namespace Avalonia.WebView.Linux.Core;

partial class LinuxWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider, LinuxWebView webView)
    {
        if (provider is null || WebView is null)
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        webView.Context.RegisterUriScheme(filter.Scheme, WebView_WebResourceRequest);

        var scriptString = new GString(BlazorScriptHelper.BlazorStartingScript);
        var script = UserScript.New(scriptString.Handle);
        webView.UserContentManager.AddScript(script);
        script.Unref();

        webView.UserContentManager.RegisterScriptMessageHandler(_messageKeyWord);
        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted(LinuxWebView webView)
    {
        if (WebView is null)
            return;

        webView.UserContentManager.UnregisterScriptMessageHandler(_messageKeyWord);

        _isBlazorWebView = false;
    }
}
