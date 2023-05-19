using WebViewCore;
using WebViewCore.Configurations;

namespace AvaloniaWebView.Shared;

public interface IViewHandlerProvider
{
    IViewHandler CreatePlatformWebViewHandler(IVirtualWebView virtualView, IVirtualWebViewControlCallBack virtualViewCallBack, Action<WebViewCreationProperties>? configDelegate = default);
}
