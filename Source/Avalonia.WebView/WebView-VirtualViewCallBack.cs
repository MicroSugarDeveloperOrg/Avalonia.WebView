namespace AvaloniaWebView;

partial class WebView
{
    void IVirtualWebViewControlCallBack.PlatformWebViewCreated(object? sender, WebViewCreatedEventArgs arg)
    {
         
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewCreating(object? sender, WebViewCreatingEventArgs arg)
    {
         return true;
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg)
    {
        
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewNavigationCompleted(object? sender, WebViewUrlLoadedEventArg arg)
    {
         
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewNavigationStarting(object? sender, WebViewUrlLoadingEventArg arg)
    {
         return true;
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewNewWindowRequest(object? sender, WebViewNewWindowEventArgs arg)
    {
        return false;
    }
}
