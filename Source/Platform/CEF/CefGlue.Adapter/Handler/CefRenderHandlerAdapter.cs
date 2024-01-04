namespace CefGlue.Adapter.Handler;
internal sealed class CefRenderHandlerAdapter : CefRenderHandler
{
    public CefRenderHandlerAdapter(IRenderHandler render)
    {
        _render = render;
    }

    readonly IRenderHandler _render;

    protected override CefAccessibilityHandler GetAccessibilityHandler()
    {
        return _render.GetAccessibilityHandler();
    }

    protected override bool GetScreenInfo(CefBrowser browser, CefScreenInfo screenInfo)
    {
        return _render.GetScreenInfo(browser, screenInfo);
    }

    protected override void GetViewRect(CefBrowser browser, out CefRectangle rect)
    {
        _render.GetViewRect(browser, out rect);
    }

    protected override bool GetScreenPoint(CefBrowser browser, int viewX, int viewY, ref int screenX, ref int screenY)
    {
        return _render.GetScreenPoint(browser, viewX, viewY, ref screenX, ref screenY);
    }

    protected override void OnAcceleratedPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr sharedHandle)
    {
        _render.OnAcceleratedPaint(browser, type, dirtyRects, sharedHandle);
    }

    protected override void OnImeCompositionRangeChanged(CefBrowser browser, CefRange selectedRange, CefRectangle[] characterBounds)
    {
        _render.OnImeCompositionRangeChanged(browser, selectedRange, characterBounds);
    }

    protected override void OnPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr buffer, int width, int height)
    {
        _render.OnPaint(browser, type, dirtyRects, buffer, width, height);
    }

    protected override void OnPopupSize(CefBrowser browser, CefRectangle rect)
    {
        _render.OnPopupSize(browser, rect);
    }

    protected override void OnScrollOffsetChanged(CefBrowser browser, double x, double y)
    {
        _render.OnScrollOffsetChanged(browser, x, y);
    }
}
