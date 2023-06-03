using Linux.WebView.Core.Interoperates;
using WebKit;
using WebViewCore.Helpers;

namespace Avalonia.WebView.Linux.Core;

unsafe partial class LinuxWebViewCore
{
    Task PrepareBlazorWebViewStarting(IVirtualBlazorWebViewProvider? provider, WebKit.WebView webView)
    {
        if (provider is null || WebView is null)
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var filter))
            return Task.CompletedTask;

        _webScheme = filter;
        var bRet = _dispatcher.InvokeAsync(() =>
        {
            webView.Context.RegisterUriScheme(filter.Scheme, WebView_WebResourceRequest);

            var script = GtkApi.CreateUserScript(BlazorScriptHelper.BlazorStartingScript);
            if (script is null)
                return;

            webView.UserContentManager.AddSignalHandler($"script-message-received::{_messageKeyWord}", WebView_WebMessageReceived);
            webView.UserContentManager.RegisterScriptMessageHandler(_messageKeyWord);
            webView.UserContentManager.AddScript(script.Value);
            script.Value.Unref();


           

        }).Result;

        _isBlazorWebView = true;
        return Task.CompletedTask;
    }

    void ClearBlazorWebViewCompleted(WebKit.WebView webView)
    {
        if (WebView is null)
            return;

        var bRet = _dispatcher.InvokeAsync(() => 
        {
            webView.UserContentManager.UnregisterScriptMessageHandler(_messageKeyWord);
            webView.RemoveSignalHandler($"script-message-received::{_messageKeyWord}", WebView_WebMessageReceived);
        }).Result;
  
        _isBlazorWebView = false;
    }

    private void WebView_UserMessageReceived(object o, UserMessageReceivedArgs args)
    {

    }



    void WebView_WebMessageReceived(nint pContentManagerm, nint pJsResult, nint pArg)
    {
        var userConentManager = new UserContentManager(pContentManagerm);
        var jsValue = JavascriptResult.New(pJsResult);

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

        bRet = _dispatcher.InvokeAsync(() =>
        {
            var span = ms.GetBuffer().AsSpan();
            fixed (void* pBuffer = span)
            {
                using var inputStream = new GLib.InputStream(new IntPtr(pBuffer));
                request.Finish(inputStream, span.Length, headerString);
            }
        }).Result;
    }

}
