namespace WebViewCore;

public interface IVirtualWebView<TVirtualView> : IVirtualWebView
{
    TVirtualView VirtualView { get; }
}
