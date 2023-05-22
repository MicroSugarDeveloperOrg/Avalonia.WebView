using WebViewCore.Helpers;

namespace Avalonia.WebView.Linux.Core;

unsafe partial class LinuxWebViewCore
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
}
