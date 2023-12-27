namespace CefGlue.Adapter;
public interface IRenderHandler
{
    CefAccessibilityHandler GetAccessibilityHandler();
    bool GetScreenInfo(CefBrowser browser, CefScreenInfo screenInfo);
    void GetViewRect(CefBrowser browser, out CefRectangle rect);
    void OnAcceleratedPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr sharedHandle);
    void OnImeCompositionRangeChanged(CefBrowser browser, CefRange selectedRange, CefRectangle[] characterBounds);
    void OnPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr buffer, int width, int height);
    void OnPopupSize(CefBrowser browser, CefRectangle rect);
    void OnScrollOffsetChanged(CefBrowser browser, double x, double y);
}
