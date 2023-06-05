namespace AvaloniaWebView;

public static class AvaloniaWebViewBuilder
{
    public static void Initialize(Action<WebViewCreationProperties>? configDelegate)
    {
        WebViewCreationProperties creationProperties = new();
        configDelegate?.Invoke(creationProperties);
        WebViewLocator.s_Registrator.RegisterInstance<WebViewCreationProperties>(creationProperties);
    }
}
