using WebViewCore.Events;
using WebViewCore.Models;

namespace WebViewCore;
public interface IVirtualWebViewControlCallBack
{
    void PlatformWebViewCreating(object? sender, WebViewCreatingEventArgs arg);

    void PlatformWebViewCreated(object? sender, WebViewCreatedEventArgs arg);

    void PlatformWebViewNavigationStarting(object? sender, WebViewUrlLoadingEventArg arg);

    void PlatformWebViewNavigationCompleted(object? sender, WebViewUrlLoadedEventArg arg);

    void PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg);

    bool PlatformWebViewNewWindowRequest(object? sender, WebViewNewWindowEventArgs arg);


}
