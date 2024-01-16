using Avalonia.WebView.Helpers;
using System.Diagnostics;

namespace Avalonia.WebView.Core;

partial class CefWebViewCore : IViewHandlerControl, IPopupViewHandlerControl
{
    IImage? IViewHandlerControl.DrawingImage() => _bitmap;

    IImage? IPopupViewHandlerControl.PopupDrawingImage() => _popupBitmap;

    bool AttachViewHandlers()
    {
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is null)
            return false;

        _dpiScaling = topLevel.RenderScaling;
        topLevel.ScalingChanged += TopLevel_ScalingChanged;
        topLevel.Closed += TopLevel_Closed;

        int width = (int)_handler.Bounds.Width;
        int height = (int)_handler.Bounds.Height;
        _width = width;
        _height = height;

        _handler.SizeChanged += Handler_SizeChanged;

        _handler.GotFocus += Handler_GotFocus;
        _handler.LostFocus += Handler_LostFocus;
        _handler.PointerMoved += Handler_PointerMoved;
        _handler.PointerPressed += Handler_PointerPressed;
        _handler.PointerReleased += Handler_PointerReleased;
        _handler.PointerExited += Handler_PointerExited;
        _handler.PointerWheelChanged += Handler_PointerWheelChanged;

        _handler.TextInput += Handler_TextInput;
        _handler.KeyDown += Handler_KeyDown;
        _handler.KeyUp += Handler_KeyUp;
        //_disposable = InputElement.TextInputEvent.AddClassHandler<InputElement>((x, e) => 
        //{
        //    if (x != _handler)
        //        return;
        //
        //    Handler_TextInput(x, e);
        //}, RoutingStrategies.Bubble);

        return true;
    }

    bool DetachViewHandlers()
    {
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is null)
            return false;

        _dpiScaling = topLevel.RenderScaling;
        topLevel.ScalingChanged -= TopLevel_ScalingChanged;
        topLevel.Closed -= TopLevel_Closed;

        _handler.SizeChanged -= Handler_SizeChanged;

        _handler.GotFocus -= Handler_GotFocus;
        _handler.LostFocus -= Handler_LostFocus;
        _handler.PointerMoved -= Handler_PointerMoved;
        _handler.PointerPressed -= Handler_PointerPressed;
        _handler.PointerReleased -= Handler_PointerReleased;
        _handler.PointerExited -= Handler_PointerExited;
        _handler.PointerWheelChanged -= Handler_PointerWheelChanged;

        _handler.TextInput -= Handler_TextInput;
        _handler.KeyDown -= Handler_KeyDown;
        _handler.KeyUp -= Handler_KeyUp;

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
        mouseEvent.Modifiers = AsCefMouseModifiers(pointer.Properties);

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
        mouseEvent.Modifiers = AsCefMouseModifiers(pointer.Properties);
        var mouseType = AsCefMouseButtonType(pointer.Properties);

        try
        {
            _cefBrowserHost?.SendMouseClickEvent(mouseEvent, mouseType, false, e.ClickCount);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerPressed, {ex}");
        }

        if (mouseType == CefMouseButtonType.Left)
            e.Pointer.Capture(_handler);
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
        mouseEvent.Modifiers = AsCefMouseModifiers(pointer.Properties);
        var mouseType = AsCefMouseButtonType(pointer.Properties);

        try
        {
            _cefBrowserHost?.SendMouseClickEvent(mouseEvent, mouseType, true, 0);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerReleased, {ex}");
        }

        if (mouseType == CefMouseButtonType.Left)
            e.Pointer.Capture(null);
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
            mouseEvent.Modifiers = AsCefMouseModifiers(pointer.Properties);
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
            int x = (int)(e.Delta.X * _mouseDeltaScaling);
            int y = (int)(e.Delta.Y * _mouseDeltaScaling);
            _cefBrowserHost?.SendMouseWheelEvent(mouseEvent, x, y);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"PointerWheelChanged, {ex}");
        }
    }

    private void Handler_TextInput(object sender, TextInputEventArgs e)
    {
        if (e.Text is null)
            return;

        foreach (var item in e.Text)
        {
            CefKeyEvent keyEvent = new CefKeyEvent()
            {
                EventType = CefKeyEventType.Char,
                WindowsKeyCode = (int)item,
            };
            try
            {
                _cefBrowserHost?.SendKeyEvent(keyEvent);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"TextInput, {ex}");
            }

        }
    }

    private void Handler_KeyUp(object sender, KeyEventArgs e)
    {
        if (_cefBrowserHost is null)
            return;

        var modifers = AsCefKeyboardModifiers(e.KeyModifiers);
        CefKeyEvent keyEvent = new CefKeyEvent()
        {
            EventType = CefKeyEventType.KeyUp,
            WindowsKeyCode = KeyboardHelper.VirtualKeyFromKey(e.Key),
            NativeKeyCode = (int)modifers,
            IsSystemKey = e.Key == Key.System,
            Modifiers = modifers
        };

        try
        {
            _cefBrowserHost.SendKeyEvent(keyEvent);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"KeyUp, {ex}");
        }
    }
    
    private void Handler_KeyDown(object sender, KeyEventArgs e)
    {
        if (_cefBrowserHost is null)
            return;

        var modifers = AsCefKeyboardModifiers(e.KeyModifiers);
        CefKeyEvent keyEvent = new CefKeyEvent()
        {
            EventType = CefKeyEventType.RawKeyDown,
            WindowsKeyCode = KeyboardHelper.VirtualKeyFromKey(e.Key),
            NativeKeyCode = (int)modifers,
            IsSystemKey = e.Key == Key.System,
            Modifiers = modifers
        };

        try
        {
            _cefBrowserHost.SendKeyEvent(keyEvent);
            Debug.WriteLine($"KeyDown,{e.Key}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"KeyDown, {ex}");
        }
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

        _cefBrowserHost?.WasResized();
    }

    private void Handler_Loaded(object sender, RoutedEventArgs e)
    {
        var topLevel = TopLevel.GetTopLevel(_handler);
        if (topLevel is null)
            return;

        var hWnd = topLevel.TryGetPlatformHandle()?.Handle;
        if (hWnd is null)
            return;
        var windowInfo = CefWindowInfo.Create();
        windowInfo.SetAsWindowless(hWnd.Value, true);

        CefBrowserHost.CreateBrowser(windowInfo, _cefClient!, _settings!, "about:blank");
    }

    CefEventFlags AsCefMouseModifiers(PointerPointProperties properties)
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

    CefMouseButtonType AsCefMouseButtonType(PointerPointProperties properties)
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

    CefEventFlags AsCefKeyboardModifiers(KeyModifiers keyModifiers)
    {
        CefEventFlags modifiers = new();
        if (keyModifiers.HasFlag(KeyModifiers.Alt))
            modifiers |= CefEventFlags.AltDown;

        if (keyModifiers.HasFlag(KeyModifiers.Control))
            modifiers |= CefEventFlags.ControlDown;

        if (keyModifiers.HasFlag(KeyModifiers.Shift))
            modifiers |= CefEventFlags.ShiftDown;

        return modifiers;
    }

}
