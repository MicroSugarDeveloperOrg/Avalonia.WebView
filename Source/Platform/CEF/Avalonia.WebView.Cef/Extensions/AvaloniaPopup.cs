using Avalonia.Controls.Primitives;

namespace Avalonia.WebView.Extensions;
internal class AvaloniaPopup : Popup
{
    public AvaloniaPopup()
    {
    }

    IPopupViewHandlerControl? _popupViewHandlerControl;

    public void SetViewHandlerControl(IPopupViewHandlerControl popupViewHandlerControl)
    {
        _popupViewHandlerControl = popupViewHandlerControl;
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);

        var bitmap = _popupViewHandlerControl?.PopupDrawingImage();
        if (bitmap is null)
            return;

        context.DrawImage(bitmap, new Rect(0, 0, Bounds.Width, Bounds.Height));
    }
}

