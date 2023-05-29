namespace Avalonia.WebView.MacCatalyst;

internal class ViewHandlerProvider : IViewHandlerProvider
{
    public ViewHandlerProvider()
    {
        NSApplication.Init();
    }

    IViewHandler IViewHandlerProvider.CreatePlatformWebViewHandler(IVirtualWebView virtualView, IVirtualWebViewControlCallBack virtualViewCallBack, IVirtualBlazorWebViewProvider? provider, Action<WebViewCreationProperties>? configDelegate)
    {
        var creatonProperty = new WebViewCreationProperties();
        configDelegate?.Invoke(creatonProperty);

        return new WebViewHandler(virtualView, virtualViewCallBack, provider, creatonProperty);
    }
}
