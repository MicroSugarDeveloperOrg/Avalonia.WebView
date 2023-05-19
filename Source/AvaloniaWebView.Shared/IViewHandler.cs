using Avalonia.Controls;
using WebViewCore;

namespace AvaloniaWebView.Shared;

public interface IViewHandler
{
    Control AttachableControl { get; }
    IPlatformWebView PlatformWebView { get; }
}
