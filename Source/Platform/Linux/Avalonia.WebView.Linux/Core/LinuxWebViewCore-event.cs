using Linux.WebView.Core;

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

    void RegisterWebViewEvents(WebKitWebView webView)
    {
        if (webView is null)
            return;

        var bRet = _dispatcher.InvokeAsync(() =>
        {
            GtkApi.AddSignalConnect(webView.Handle, "decide-policy", LinuxApplicationManager.LoadFunction(_decidePolicyArgsChanged), IntPtr.Zero);
            webView.DecidePolicy += WebView_DecidePolicy;
            webView.PermissionRequest += WebView_PermissionRequest;
            webView.UserMessageReceived += WebView_UserMessageReceived;
            //webView.UserContentManager.AddSignalHandler("script-message-received::webview", WebView_WebMessageReceived);
        }).Result;
    }

    void UnregisterWebViewEvents(WebKitWebView webView)
    {
        if (webView is null)
            return;

        var bRet = _dispatcher.InvokeAsync(() =>
        {
            webView.DecidePolicy -= WebView_DecidePolicy;
            webView.PermissionRequest -= WebView_PermissionRequest;
            webView.UserMessageReceived -= WebView_UserMessageReceived;
        }).Result;
    }


}
