namespace WebViewCore;

public interface IPlatformWebView<T>
{
    T? PlatformView { get; }

}
