namespace Avalonia.WebView.Mac.Core;
partial class MacWebViewCore  
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

    void RegisterWebViewEvents(MacosWebView webView)
    {
        if (webView is null)
            return;

        webView.ReceivedTitle += WebView_ReceivedTitle;
        webView.FinishedLoad += WebView_FinishedLoad;
        webView.FailedLoadWithError += WebView_FailedLoadWithError;
    }

    void UnregisterWebViewEvents(MacosWebView webView)
    {
        if (webView is null)
            return;

        webView.ReceivedTitle -= WebView_ReceivedTitle;
        webView.FinishedLoad -= WebView_FinishedLoad;
        webView.FailedLoadWithError -= WebView_FailedLoadWithError;
    }

    private void WebView_FailedLoadWithError(object sender, WebFrameErrorEventArgs e)
    {
    }

    private void WebView_FinishedLoad(object sender, WebFrameEventArgs e)
    {
    }

    private void WebView_ReceivedTitle(object sender, WebFrameTitleEventArgs e)
    {
    }

    private void HostControl_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        
    }

    private void Handler_PlatformHandlerChanged(object sender, EventArgs e)
    {
         
    }

}
