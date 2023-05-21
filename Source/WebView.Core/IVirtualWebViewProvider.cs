namespace WebViewCore;
public interface IVirtualWebViewProvider
{
    string AppHostAddress { get; }
    Uri BaseUri { get; }
}
