namespace AvaloniaBlazorWebView;

public static class AppBuilderExtensions
{
    public static AvaloniaLocator UseAvaloniaBlazorWebView(this AvaloniaLocator avaloniaLocator, Action<WebViewCreationProperties>? webConfigDelegate,  Action<BlazorWebViewSetting> configDelegate, Action<IServiceCollection>? injectDelegate)
    {
        WebViewCreationProperties creationProperties = new();
        webConfigDelegate?.Invoke(creationProperties);
        avaloniaLocator.BindToSelf(creationProperties);

        var builder = new BlazorWebViewApplicationBuilder(injectDelegate, configDelegate);
        avaloniaLocator.BindToSelf<IBlazorWebViewApplicationBuilder>(builder);

        return avaloniaLocator;
    }
}