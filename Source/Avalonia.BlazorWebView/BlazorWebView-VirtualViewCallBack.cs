namespace AvaloniaBlazorWebView;

partial class BlazorWebView  
{
    void IVirtualWebViewControlCallBack.PlatformWebViewCreated(object? sender, WebViewCreatedEventArgs arg)
    {
        WebViewCreated?.Invoke(sender, arg);
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewCreating(object? sender, WebViewCreatingEventArgs arg)
    {
        WebViewCreating?.Invoke(sender, arg);
        return true;
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg)
    {
        WebMessageReceived?.Invoke(sender, arg);
    }

    void IVirtualWebViewControlCallBack.PlatformWebViewNavigationCompleted(object? sender, WebViewUrlLoadedEventArg arg)
    {
        NavigationCompleted?.Invoke(sender, arg);
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewNavigationStarting(object? sender, WebViewUrlLoadingEventArg arg)
    {
        NavigationStarting?.Invoke(sender, arg);
        return true;
    }

    bool IVirtualWebViewControlCallBack.PlatformWebViewNewWindowRequest(object? sender, WebViewNewWindowEventArgs arg)
    {
        WebViewNewWindowRequested?.Invoke(sender, arg);
        return true;
    }
}
