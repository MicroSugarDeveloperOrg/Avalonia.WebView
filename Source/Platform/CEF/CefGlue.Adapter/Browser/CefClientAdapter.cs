using CefGlue.Adapter.Handler;

namespace CefGlue.Adapter.Browser;
public sealed class CefClientAdapter : CefClient
{
    public CefClientAdapter(ILifeSpanHandler lifeSpanHandler, 
                            IDisplayHandler displayHandler,
                            IRenderHandler renderHandler,
                            ILoadedHandler loadedHandler,
                            IJSDialogHandler jsDialogHandler)
    {
        _lifeSpanHandler = new(lifeSpanHandler);
        _displayHandler = new(displayHandler);
        _renderHandler = new(renderHandler);
        _loadHandler = new(loadedHandler);
        _jsDialogHandler = new(jsDialogHandler);
    }

    private CefLifeSpanHandlerAdapter _lifeSpanHandler;
    private CefDisplayHandlerAdapter _displayHandler;
    private CefRenderHandlerAdapter _renderHandler;
    private CefLoadHandlerAdapter _loadHandler;
    private CefJSDialogHandlerAdapter _jsDialogHandler;

    protected override CefLifeSpanHandler GetLifeSpanHandler()
    {
        return _lifeSpanHandler;
    }

    protected override CefDisplayHandler GetDisplayHandler()
    {
        return _displayHandler;
    }

    protected override CefRenderHandler GetRenderHandler()
    {
        return _renderHandler;
    }

    protected override CefLoadHandler GetLoadHandler()
    {
        return _loadHandler;
    }

    protected override CefJSDialogHandler GetJSDialogHandler()
    {
        return _jsDialogHandler;
    }
}
