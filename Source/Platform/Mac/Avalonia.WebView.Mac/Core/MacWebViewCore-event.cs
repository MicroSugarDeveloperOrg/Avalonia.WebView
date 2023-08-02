using Avalonia.Controls;

namespace Avalonia.WebView.Mac.Core;
partial class MacWebViewCore
{
    void RegisterEvents()
    {
        _handler.SizeChanged += HostControl_SizeChanged;
        _handler.PlatformHandlerChanged += Handler_PlatformHandlerChanged;
    }

    void UnregisterEvents()
    {
        _handler.SizeChanged -= HostControl_SizeChanged;
        _handler.PlatformHandlerChanged -= Handler_PlatformHandlerChanged;
    }

    private void HostControl_SizeChanged(object? sender, SizeChangedEventArgs e)
    {

    }

    private void Handler_PlatformHandlerChanged(object? sender, EventArgs e)
    {

    }
}
