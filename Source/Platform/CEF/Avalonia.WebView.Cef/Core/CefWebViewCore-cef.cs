﻿using CefGlue.Adapter;

namespace Avalonia.WebView.Core;

partial class CefWebViewCore
{
    CefAccessibilityHandler IRenderHandler.GetAccessibilityHandler()
    {
        return null!;
    }

    bool IRenderHandler.GetScreenInfo(CefBrowser browser, CefScreenInfo screenInfo)
    {
        screenInfo.DeviceScaleFactor = (float)_dpiScaling;
        return false;
    }

    bool IRenderHandler.GetScreenPoint(CefBrowser cefBrowser, int viewX, int viewY, ref int screenX, ref int screenY)
    {
        PixelPoint pixelPoint = new();
        _dispatcher.Invoke(() =>
        {
            pixelPoint = _handler.PointToScreen(new Point(viewX, viewY));
        });

        screenX = pixelPoint.X;
        screenY = pixelPoint.Y;
        return true;
    }

    void IRenderHandler.GetViewRect(CefBrowser browser, out CefRectangle rect)
    {
        rect = new CefRectangle(0, 0, (int)_width, (int)_height);
    }

    void IRenderHandler.OnAcceleratedPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr sharedHandle)
    {
        //throw new NotImplementedException();
    }

    void IDisplayHandler.OnAddressChange(CefBrowser browser, CefFrame frame, string url)
    {
        //throw new NotImplementedException();
    }

    void ILifeSpanHandler.OnAfterCreated(CefBrowser browser)
    {
        _dispatcher.Invoke(() =>
        {
            _cefBrowser = browser;
            _cefBrowserHost = browser.GetHost();
        });

        AppBuilderExtensions.__CefBroswerManager.AddHost(_cefBrowser!, _cefBrowserHost!);
        AttachViewHandlers();
        _cefBrowserHost?.WasResized();

        if (_uri is not null)
            _cefBrowser?.GetMainFrame()?.LoadUrl(_uri.ToString());

        IsCreated = true;
    }

    void ILifeSpanHandler.OnBeforeClose(CefBrowser browser)
    {
        AppBuilderExtensions.__CefBroswerManager.RemoveHost(_cefBrowser!, _cefBrowserHost!);

        _cefBrowser = null;
        _cefBrowserHost = null;
    }

    bool ILifeSpanHandler.OnBeforePopup(CefBrowser browser, CefFrame frame, string targetUrl, string targetFrameName, CefWindowOpenDisposition targetDisposition, bool userGesture, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings, ref CefDictionaryValue extraInfo, ref bool noJavascriptAccess)
    {
        return false;
    }

    bool IJSDialogHandler.OnBeforeUnloadDialog(CefBrowser browser, string messageText, bool isReload, CefJSDialogCallback callback)
    {
        return true;
    }

    bool IDisplayHandler.OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
    {
        return false;
    }

    void IJSDialogHandler.OnDialogClosed(CefBrowser browser)
    {

    }

    void IRenderHandler.OnImeCompositionRangeChanged(CefBrowser browser, CefRange selectedRange, CefRectangle[] characterBounds)
    {
    }

    bool IJSDialogHandler.OnJSDialog(CefBrowser browser, string originUrl, CefJSDialogType dialogType, string message_text, string default_prompt_text, CefJSDialogCallback callback, out bool suppress_message)
    {
        suppress_message = true;
        return true;
    }

    void ILoadedHandler.OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
    {

    }

    void ILoadedHandler.OnLoadError(CefBrowser browser, CefFrame frame, CefErrorCode errorCode, string errorText, string failedUrl)
    {

    }

    void ILoadedHandler.OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward)
    {

    }

    void ILoadedHandler.OnLoadStart(CefBrowser browser, CefFrame frame, CefTransitionType transitionType)
    {

    }

    void IRenderHandler.OnPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr buffer, int width, int height)
    {
        if (width <= 0 || height <= 0)
            return;

        if (IsDisposing)
            return;

        switch (type)
        {
            case CefPaintElementType.View:
                _dispatcher.Invoke(() =>
                {
                    CreateWriteableBitmap(dirtyRects, buffer, width, height);
                    _handler.InvalidateVisual();
                });
                break;
            case CefPaintElementType.Popup:
                _dispatcher.Invoke(() =>
                {
                    CreatePopupWritableBitmap(dirtyRects, buffer, width, height);
                    _popup.InvalidateVisual();
                });
                break;
            default:
                break;
        }
    }

    void IRenderHandler.OnPopupSize(CefBrowser browser, CefRectangle rect)
    {
        _dispatcher.Invoke(() =>
        {
            _popup.Width = rect.Width;
            _popup.Height = rect.Height;
            _popup.HorizontalOffset = rect.X;
            _popup.VerticalOffset = rect.Y;
            //_popup.InvalidateVisual();
        });
    }

    void IRenderHandler.OnPopupShow(CefBrowser browser, bool show)
    {
        _dispatcher.Invoke(() => _popup.IsOpen = show);
    }

    void IJSDialogHandler.OnResetDialogState(CefBrowser browser)
    {



    }

    void IRenderHandler.OnScrollOffsetChanged(CefBrowser browser, double x, double y)
    {

    }

    void IDisplayHandler.OnStatusMessage(CefBrowser browser, string value)
    {

    }

    void IDisplayHandler.OnTitleChange(CefBrowser browser, string title)
    {

    }

    bool IDisplayHandler.OnTooltip(CefBrowser browser, string text)
    {


        return true;
    }

    void CreateWriteableBitmap(CefRectangle[] dirtyRects, IntPtr buffer, int width, int height)
    {
        var dpi = _dpi;
        int stride = width * _bytePerPixel;

        foreach (CefRectangle dirtyRect in dirtyRects)
        {
            if (dirtyRect.Width == 0 || dirtyRect.Height == 0)
                continue;

            var bitmap = new WriteableBitmap(PixelFormat.Bgra8888, AlphaFormat.Opaque, buffer, new PixelSize(width, height), new Vector(dpi, dpi), stride);

            //bitmap.CopyPixels(new PixelRect(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height), buffer, sourceBufferSize, stride);

            //using var lockedFrameBuffer = bitmap.Lock();
            //var pointer = lockedFrameBuffer.Address;

            //unsafe
            //{
            //    Buffer.MemoryCopy((void*)buffer, (void*)pointer, sourceBufferSize, sourceBufferSize);
            //}

            _bitmap?.Dispose();
            _bitmap = bitmap;
        }
    }

    void CreatePopupWritableBitmap(CefRectangle[] dirtyRects, IntPtr buffer, int width, int height)
    {
        var dpi = _dpi;
        int stride = width * _bytePerPixel;

        foreach (CefRectangle dirtyRect in dirtyRects)
        {
            if (dirtyRect.Width == 0 || dirtyRect.Height == 0)
                continue;

            var bitmap = new WriteableBitmap(PixelFormat.Bgra8888, AlphaFormat.Opaque, buffer, new PixelSize(width, height), new Vector(dpi, dpi), stride);

            _popupBitmap?.Dispose();
            _popupBitmap = bitmap;
        }
    }
}