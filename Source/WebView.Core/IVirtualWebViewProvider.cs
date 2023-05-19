using WebViewCore.Events;
using WebViewCore.Models;

namespace WebViewCore;
public interface IVirtualWebViewProvider
{
    bool ResourceRequestedFilterProvider(object? requester, out string filter);

    bool PlatformWebViewResourceRequested(object? sender, WebResourceRequest request, out WebResourceResponse? response);

    void PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg);

}
