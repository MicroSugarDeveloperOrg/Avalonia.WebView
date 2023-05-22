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

    private void HostControl_SizeChanged(object sender, SizeChangedEventArgs e)
    {

    }

    private void Handler_PlatformHandlerChanged(object sender, EventArgs e)
    {

    }


    void RegisterWebViewEvents(MacosWebView webView)
    {
        if (webView is null)
            return;

        //WebView.DecidePolicyForNewWindow += WebView_DecidePolicyForNewWindow;
        webView.ReceivedTitle += WebView_ReceivedTitle;
        webView.FinishedLoad += WebView_FinishedLoad;
        webView.FailedLoadWithError += WebView_FailedLoadWithError;
        webView.OnReceivedResponse += WebView_OnReceivedResponse;
        webView.WindowScriptObjectAvailable += WebView_WindowScriptObjectAvailable;
        webView.WillPerformClientRedirect += WebView_WillPerformClientRedirect;
    }


    void UnregisterWebViewEvents(MacosWebView webView)
    {
        if (webView is null)
            return;
        
        webView.ReceivedTitle -= WebView_ReceivedTitle;
        webView.FinishedLoad -= WebView_FinishedLoad;
        webView.FailedLoadWithError -= WebView_FailedLoadWithError;
        webView.OnReceivedResponse -= WebView_OnReceivedResponse;
        webView.WindowScriptObjectAvailable -= WebView_WindowScriptObjectAvailable;
    }

    private void WebView_WillPerformClientRedirect(object sender, WebFrameClientRedirectEventArgs e)
    {

    }

    private void WebView_FailedLoadWithError(object sender, WebFrameErrorEventArgs e)
    {
        //e.ForFrame.StopLoading();
    }

    private void WebView_FinishedLoad(object sender, WebFrameEventArgs e)
    {
        //e.ForFrame.
    }

    private void WebView_ReceivedTitle(object sender, WebFrameTitleEventArgs e)
    {
    }

    private void WebView_WindowScriptObjectAvailable(object sender, WebFrameScriptObjectEventArgs e)
    {

    }

    private void WebView_OnReceivedResponse(object sender, WebResourceReceivedResponseEventArgs e)
    {

    }
}
