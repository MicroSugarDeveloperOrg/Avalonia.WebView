using Avalonia.Controls.Primitives;
using DryIoc;
using System.Diagnostics;
using static CefGlue.Wrapper.CefMessageRouterBrowserSide;

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

        _handler.GotFocus += Handler_GotFocus;
        _handler.LostFocus += Handler_LostFocus;
        _handler.PointerMoved += Handler_PointerMoved;
        _handler.PointerPressed += Handler_PointerPressed;
        _handler.PointerReleased += Handler_PointerReleased;
        _handler.PointerExited += Handler_PointerExited;
        _handler.PointerWheelChanged += Handler_PointerWheelChanged;
        _handler.TextInput += Handler_TextInput;
        return true;
    }

    private void Handler_GotFocus(object sender, GotFocusEventArgs e)
    {
        try
        {
            _cefBrowserHost?.SetFocus(true);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"GotFocus, {ex}");
        }
    }

    private void Handler_LostFocus(object sender, RoutedEventArgs e)
    {
        try
        {
            _cefBrowserHost?.SetFocus(false);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"LostFocus, {ex}");
        }
    }

    private void Handler_PointerMoved(object sender, PointerEventArgs e)
    {
        Point cursorPos = e.GetPosition(_handler);
        CefMouseEvent mouseEvent = new()
        {
            X = (int)cursorPos.X,
            Y = (int)cursorPos.Y
        };
        var pointer = e.GetCurrentPoint(_handler);
        mouseEvent.Modifiers = GetMouseModifiers(pointer.Properties);

        try
        {
            _cefBrowserHost?.SendMouseMoveEvent(mouseEvent, false);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerMoved, {ex}");
        }
    }

    private void Handler_PointerPressed(object sender, PointerPressedEventArgs e)
    {
        _handler.Focus();
        Point cursorPos = e.GetPosition(_handler);
        CefMouseEvent mouseEvent = new()
        {
            X = (int)cursorPos.X,
            Y = (int)cursorPos.Y
        };
        var pointer = e.GetCurrentPoint(_handler);
        mouseEvent.Modifiers = GetMouseModifiers(pointer.Properties);
        var mouseType = GetMouseButtonType(pointer.Properties);

        try
        {
            _cefBrowserHost?.SendMouseClickEvent(mouseEvent, mouseType, false, e.ClickCount);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerPressed, {ex}");
        }
    }

    private void Handler_PointerReleased(object sender, PointerReleasedEventArgs e)
    {
        _handler.Focus();
        Point cursorPos = e.GetPosition(_handler);
        CefMouseEvent mouseEvent = new()
        {
            X = (int)cursorPos.X,
            Y = (int)cursorPos.Y
        };
        var pointer = e.GetCurrentPoint(_handler);
        mouseEvent.Modifiers = GetMouseModifiers(pointer.Properties);
        var mouseType = GetMouseButtonType(pointer.Properties);

        try
        {
            _cefBrowserHost?.SendMouseClickEvent(mouseEvent, mouseType, true, 0);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerReleased, {ex}");
        }
    }

    private void Handler_PointerExited(object sender, PointerEventArgs e)
    {
        try
        {
            CefMouseEvent mouseEvent = new()
            {
                X = 0,
                Y = 0
            };

            var pointer = e.GetCurrentPoint(_handler);
            mouseEvent.Modifiers = GetMouseModifiers(pointer.Properties);
            _cefBrowserHost?.SendMouseMoveEvent(mouseEvent, true);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerExited, {ex}");
        }
    }

    private void Handler_PointerWheelChanged(object sender, PointerWheelEventArgs e)
    {
        Point cursorPos = e.GetPosition(_handler);
        CefMouseEvent mouseEvent = new()
        {
            X = (int)cursorPos.X,
            Y = (int)cursorPos.Y
        };

        try
        {
            _cefBrowserHost?.SendMouseWheelEvent(mouseEvent, 0, (int)e.Delta.Y);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerWheelChanged, {ex}");
        }
    }

    private void Handler_TextInput(object sender, TextInputEventArgs e)
    {
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

    CefEventFlags GetMouseModifiers(PointerPointProperties properties)
    {
        CefEventFlags modifiers = new();
        if (properties.IsLeftButtonPressed)
            modifiers |= CefEventFlags.LeftMouseButton;

        if (properties.IsMiddleButtonPressed)
            modifiers |= CefEventFlags.MiddleMouseButton;

        if (properties.IsRightButtonPressed)
            modifiers |= CefEventFlags.RightMouseButton;

        return modifiers;
    }

    CefMouseButtonType GetMouseButtonType(PointerPointProperties properties)
    {
        CefMouseButtonType type = CefMouseButtonType.Left;
        switch (properties.PointerUpdateKind)
        {
            case PointerUpdateKind.LeftButtonPressed:
                break;
            case PointerUpdateKind.MiddleButtonPressed:
                type = CefMouseButtonType.Middle;
                break;
            case PointerUpdateKind.RightButtonPressed:
                type = CefMouseButtonType.Right;
                break;
            case PointerUpdateKind.XButton1Pressed:
                break;
            case PointerUpdateKind.XButton2Pressed:
                type = CefMouseButtonType.Right;
                break;
            case PointerUpdateKind.LeftButtonReleased:
                break;
            case PointerUpdateKind.MiddleButtonReleased:
                type = CefMouseButtonType.Middle;
                break;
            case PointerUpdateKind.RightButtonReleased:
                type = CefMouseButtonType.Right;
                break;
            case PointerUpdateKind.XButton1Released:
                break;
            case PointerUpdateKind.XButton2Released:
                type = CefMouseButtonType.Right;
                break;
            case PointerUpdateKind.Other:
                break;
            default:
                break;
        }

        return type;
    }
}
