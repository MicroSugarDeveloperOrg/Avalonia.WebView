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
        //if (_handler.RefHandler.Handle != IntPtr.Zero)
        //{
        //    NativeHandler = _handler.RefHandler.Handle;
        //    _= _dispatcher.InvokeAsync(() =>
        //    {
        //        _hostWindow.SetParent(NativeHandler);
        //    }).Result;
        //    //_hwndTaskSource.SetResult(_handler.RefHandler.Handle);
        //}
    }

    void RegisterWebViewEvents(WebKit.WebView webView)
    {
        var bRet =  GtkInteropHelper.RunOnGlibThread(() =>
        {
            webView.UserMessageReceived += WebView_UserMessageReceived;
            //webView.UserContentManager.AddSignalHandler("script-message-received::webview", WebView_WebMessageReceived);
            return true;
        }).Result;
    }



    void UnregisterWebViewEvents(WebKit.WebView webView)
    {
        var bRet =  GtkInteropHelper.RunOnGlibThread(() =>
        {
            webView.UserMessageReceived -= WebView_UserMessageReceived;
            return true;
        }).Result;
    }
}
