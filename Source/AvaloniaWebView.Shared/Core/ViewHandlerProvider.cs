using WebViewCore;
using WebViewCore.Configurations;

namespace AvaloniaWebView.Shared.Core;
public class ViewHandlerProvider : IViewHandlerProvider
{
    IViewHandler IViewHandlerProvider.CreatePlatformWebViewHandler(IVirtualWebView virtualView, IVirtualWebViewControlCallBack virtualViewCallBack, Action<WebViewCreationProperties>? configDelegate)
    {
        throw new NotImplementedException();
    }
}
