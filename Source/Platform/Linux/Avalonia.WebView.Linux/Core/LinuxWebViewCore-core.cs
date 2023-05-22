using WebViewCore.Helpers;

namespace Avalonia.WebView.Linux.Core;

partial class LinuxWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider, LinuxWebView webView)
    {
        if (provider is null || WebView is null)
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        _webScheme = filter;
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

    private void WebView_UserMessageReceived(object o, UserMessageReceivedArgs args)
    {

    }

    void WebView_WebMessageReceived(nint contentManager, nint jsResult, nint arg)
    {
        var jsValue = JavascriptResult.New(jsResult);

        var message = new WebViewMessageReceivedEventArgs
        {
            Message = jsValue.ToString(),
            Source = new Uri("")
        };
        jsValue.Unref();

        _callBack.PlatformWebViewMessageReceived(this, message);
        _provider?.PlatformWebViewMessageReceived(this, message);
    }

    unsafe void WebView_WebResourceRequest(URISchemeRequest request)
    {
        if (_provider is null)
            return;

        if (_webScheme is null)
            return;

        if (request.Scheme != _webScheme.Scheme)
            return;

        var requestWrapper = new WebResourceRequest
        {
            RequestUri = request.Uri,
            AllowFallbackOnHostPage = false,
        };

        var bRet = _provider.PlatformWebViewResourceRequested(this, requestWrapper, out var response);
        if (!bRet)
            return;

        if (response is null)
            return;

        var headerString = response.Headers[QueryStringHelper.ContentTypeKey];
        using var ms = new MemoryStream();
        response.Content.CopyTo(ms);
        var span = ms.GetBuffer().AsSpan();
        void* ptr = &span; 
        using var inputStream = new GInputStream(new IntPtr(ptr));
        request.Finish(inputStream, span.Length, headerString); 
    }

}
