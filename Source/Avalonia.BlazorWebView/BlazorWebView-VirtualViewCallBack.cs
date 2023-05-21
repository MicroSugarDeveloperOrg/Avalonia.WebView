namespace AvaloniaBlazorWebView;

partial class BlazorWebView  
{
    bool IVirtualWebViewControlCallBack.PlatformWebViewCreating(object? sender, WebViewCreatingEventArgs arg)
    {
        return true;
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewCreated(object? sender, WebViewCreatedEventArgs arg)
    {
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewNavigationStarting(object? sender, WebViewUrlLoadingEventArg arg)
    {
        return true;
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
