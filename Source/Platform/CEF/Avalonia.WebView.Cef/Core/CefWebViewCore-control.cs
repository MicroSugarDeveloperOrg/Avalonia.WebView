namespace Avalonia.WebView.Core;
partial class CefWebViewCore : IViewHandlerControl
{
    IImage? IViewHandlerControl.DrawingImage() => _bitmap;

    bool AttachViewHandlers()
    {
        //
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is null)
            return false;

        //_dpiScaling = 1;
        _dpiScaling = topLevel.RenderScaling;
        topLevel.ScalingChanged += TopLevel_ScalingChanged;
        topLevel.Closed += TopLevel_Closed;

        int width = (int)_handler.Bounds.Width;
        int height = (int)_handler.Bounds.Height;
        _width = width;
        _height = height;

        _browserWidth = width * _dpiScaling;
        _browserHeight = height * _dpiScaling;

        _handler.SizeChanged += Handler_SizeChanged;

        return true;
    }

    private void TopLevel_Closed(object sender, EventArgs e)
    {
        Disposing();
    }

    private void TopLevel_ScalingChanged(object sender, EventArgs e)
    {
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is null)
            return;

        _dpiScaling = topLevel.RenderScaling;
        int width = (int)_handler.Bounds.Width;
        int height = (int)_handler.Bounds.Height;
        _width = width;
        _height = height;

        _browserWidth = width * _dpiScaling;
        _browserHeight = height * _dpiScaling;

        _cefBrowserHost?.WasResized();
    }

    private void Handler_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is null)
            return;

        _dpiScaling = topLevel.RenderScaling;
        int width = (int)_handler.Bounds.Width;
        int height = (int)_handler.Bounds.Height;
        _width = width;
        _height = height;

        _browserWidth = width * _dpiScaling;
        _browserHeight = height * _dpiScaling;

        _cefBrowserHost?.WasResized();
    }

}
