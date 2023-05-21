using WebViewCore.Events;
using WebViewCore.Models;

namespace WebViewCore;
public interface IVirtualBlazorWebViewProvider
{
    bool ResourceRequestedFilterProvider(object? requester, out WebScheme filter);

    bool PlatformWebViewResourceRequested(object? sender, WebResourceRequest request, out WebResourceResponse? response);

    void PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg);

}
