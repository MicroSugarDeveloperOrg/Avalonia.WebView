namespace WebViewCore;

public interface IPlatformWebView : IPlatformWebViewControl, IDisposable, IAsyncDisposable
{
    object? PlatformViewContext { get; }
}
