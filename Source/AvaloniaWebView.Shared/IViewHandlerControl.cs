using Avalonia.Media;

namespace AvaloniaWebView.Shared;
public interface IViewHandlerControl
{
    IImage? DrawingImage();
}

public interface IPopupViewHandlerControl
{
    IImage? PopupDrawingImage();
}