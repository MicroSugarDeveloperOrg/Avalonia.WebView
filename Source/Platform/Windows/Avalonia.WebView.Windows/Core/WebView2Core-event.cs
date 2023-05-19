namespace Avalonia.WebView.Windows.Core;

partial class WebView2Core
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

    private void HostControl_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        if (_coreWebView2Controller is null)
            return;

        double scale = 1;
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is not null)
            scale = topLevel.RenderScaling;

        _coreWebView2Controller.Bounds = new System.Drawing.Rectangle(0, 0, Convert.ToInt32(e.NewSize.Width * scale), Convert.ToInt32(e.NewSize.Height * scale));
        _coreWebView2Controller.NotifyParentWindowPositionChanged();
    }

    private void Handler_PlatformHandlerChanged(object sender, EventArgs e)
    {
        if (_handler.RefHandler.Handle != IntPtr.Zero)
            _hwndTaskSource.SetResult(_handler.RefHandler.Handle);
    }


}
