using WebViewCore.Helpers;

namespace Avalonia.WebView.Linux.Core;

partial class LinuxWebViewCore
{
    void RegisterEvents()
    {
        _handler.SizeChanged += HostControl_SizeChanged;
        _handler.PlatformHandlerChanged += Handler_PlatformHandlerChanged;
    }

    void UnregisterEvents()
    {
        _handler.SizeChanged -= HostControl_SizeChanged;
        _handler.PlatformHandlerChanged -= Handler_PlatformHandlerChanged;
    }

    private void HostControl_SizeChanged(object sender, SizeChangedEventArgs e)
    {

    }

    private void Handler_PlatformHandlerChanged(object sender, EventArgs e)
    {

    }

    void RegisterWebViewEvents(LinuxWebView webView)
    {
        if (webView is null)
            return;


        webView.UserMessageReceived += WebView_UserMessageReceived;
        //webView.UserContentManager.AddSignalHandler("script-message-received::webview", WebView_WebMessageReceived);
        webView.AddSignalHandler($"script-message-received::{_messageKeyWord}", WebView_WebMessageReceived);
    }



    void UnregisterWebViewEvents(LinuxWebView webView)
    {
        if (webView is null)
            return;

        webView.UserMessageReceived -= WebView_UserMessageReceived;
        webView.RemoveSignalHandler($"script-message-received::{_messageKeyWord}", WebView_WebMessageReceived);
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
            Source = string.Empty
        };
        jsValue.Unref();

        _callBack.PlatformWebViewMessageReceived(this, message);
        _provider?.PlatformWebViewMessageReceived(this, message);
    }

    unsafe void WebView_WebResourceRequest(URISchemeRequest request)
    {
        if (_provider is null)
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
