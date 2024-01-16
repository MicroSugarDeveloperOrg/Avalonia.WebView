using Avalonia.Controls.Primitives;
using Avalonia.Threading;
using CefGlue.Adapter;

namespace Avalonia.WebView.Core;

public partial class CefWebViewCore : IPlatformWebView<CefWebViewCore>,
                                      ILifeSpanHandler,
                                      IDisplayHandler,
                                      IRenderHandler,
                                      ILoadedHandler,
                                      IJSDialogHandler
{
    public CefWebViewCore(ViewHandlerTx handler, 
                          Popup popup, 
                          IVirtualWebViewControlCallBack callback, 
                          IVirtualBlazorWebViewProvider? provider, 
                          WebViewCreationProperties webViewCreationProperties)
    {
        _dispatcher = Dispatcher.UIThread;
        _callBack = callback;
        _handler = handler;
        _popup = popup;
        _creationProperties = webViewCreationProperties;
        _provider = provider;
    }

    readonly Dispatcher _dispatcher;
    readonly IVirtualBlazorWebViewProvider? _provider;
    readonly IVirtualWebViewControlCallBack _callBack;
    readonly ViewHandlerTx _handler;
    readonly Popup _popup;  
    readonly WebViewCreationProperties _creationProperties;

    CefBrowserSettings? _settings;
    CefClient? _cefClient;
    CefBrowser? _cefBrowser;
    CefBrowserHost? _cefBrowserHost;

    double _width = 0;
    double _height = 0;

    double _dpiScaling = 0;
    double _dpi = 96;
    double _mouseDeltaScaling = 100;

    int _bytePerPixel = 4;

    bool _isInitialized = false;
    public bool IsInitialized
    {
        get => Volatile.Read(ref _isInitialized);
        private set => Volatile.Write(ref _isInitialized, value);
    }

    bool _isCreated = false;
    public bool IsCreated
    {
        get => Volatile.Read(ref _isCreated);
        private set => Volatile.Write(ref _isCreated, value);
    }

    bool _isDisposing = false;
    public bool IsDisposing
    {
        get => Volatile.Read(ref _isDisposing);
        private set => Volatile.Write(ref _isDisposing, value);
    }

    bool _isDisposed = false;
    public bool IsDisposed
    {
        get => Volatile.Read(ref _isDisposed);
        private set => Volatile.Write(ref _isDisposed, value);
    }

    Uri? _uri;
    WriteableBitmap? _bitmap;
    WriteableBitmap? _popupBitmap;
}
