namespace WebViewCore;

public interface IVirtualWebView
{
    object VirtualViewObject { get; }
    IPlatformWebView? PlatformView { get; }
}
