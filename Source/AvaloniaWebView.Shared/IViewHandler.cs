using Avalonia.Controls;
using WebViewCore;

namespace AvaloniaWebView.Shared;

public interface IViewHandler
{
    Control HandlerView { get; }
    IPlatformWebView PlatformWebView { get; }
}
