namespace Avalonia.WebView.Android.Core;

partial class AndroidWebViewCore
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
        //e.Handled = true;
    }

    private void Handler_PlatformHandlerChanged(object? sender, EventArgs e)
    {

    }
}

