namespace AvaloniaWebView;

partial class WebView
{
    void IVirtualWebViewControlCallBack.PlatformWebViewCreated(object? sender, WebViewCreatedEventArgs arg)
    {
         
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewCreating(object? sender, WebViewCreatingEventArgs arg)
    {
         
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg)
    {
        
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewNavigationCompleted(object? sender, WebViewUrlLoadedEventArg arg)
    {
         
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewNavigationStarting(object? sender, WebViewUrlLoadingEventArg arg)
    {
         
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewNewWindowRequest(object? sender, WebViewNewWindowEventArgs arg)
    {
        return false;
    }
}
