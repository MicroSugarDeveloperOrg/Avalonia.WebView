namespace AvaloniaWebView;
public static class AppBuilderExtensions
{
    public static AvaloniaLocator UseAvaloniaWebView(this AvaloniaLocator avaloniaLocator, Action<WebViewCreationProperties>? configDelegate)
    {
        WebViewCreationProperties creationProperties = new();
        configDelegate?.Invoke(creationProperties);
        avaloniaLocator.BindToSelf(creationProperties);
        return avaloniaLocator;
    }
}
