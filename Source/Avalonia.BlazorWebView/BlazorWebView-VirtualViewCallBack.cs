namespace AvaloniaBlazorWebView;

partial class BlazorWebView  
{
    void IVirtualWebViewControlCallBack.PlatformWebViewCreating(object? sender, WebViewCreatingEventArgs arg)
    {
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewCreated(object? sender, WebViewCreatedEventArgs arg)
    {
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewNavigationStarting(object? sender, WebViewUrlLoadingEventArg arg)
    {
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewNavigationCompleted(object? sender, WebViewUrlLoadedEventArg arg)
    {
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg)
    {
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewNewWindowRequest(object? sender, WebViewNewWindowEventArgs arg)
    {
        return true;
    }
}
