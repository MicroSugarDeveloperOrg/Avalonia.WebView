namespace WebViewCore;

public interface IPlatformWebView<T> : IPlatformWebView
{
    T PlatformView { get; }

}
