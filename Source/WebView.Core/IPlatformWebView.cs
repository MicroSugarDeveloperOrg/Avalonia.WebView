namespace WebViewCore;

public interface IPlatformWebView : IPlatformWebViewControl
{
    IntPtr Handle { get; }
    string? HandleDescriptor { get; }
    object? PlatformViewContext { get; }

 

}
