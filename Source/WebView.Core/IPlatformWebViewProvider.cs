using WebViewCore.Configurations;

namespace WebViewCore;

public interface IPlatformWebViewProvider
{
    IPlatformWebViewControl CreatePlatformWebView(IVirtualWebView virtualView, Action<WebViewCreationProperties>? configDelegate = default);

}
