namespace Avalonia.WebView.iOS;

internal class ViewHandlerProvider : IViewHandlerProvider
{
    IViewHandler IViewHandlerProvider.CreatePlatformWebViewHandler(IVirtualWebView virtualView, IVirtualWebViewControlCallBack virtualViewCallBack, Action<WebViewCreationProperties>? configDelegate)
    {
        var creatonProperty = new WebViewCreationProperties();
        configDelegate?.Invoke(creatonProperty);

        return new WebViewHandler(virtualView, virtualViewCallBack, creatonProperty);
    }
}
