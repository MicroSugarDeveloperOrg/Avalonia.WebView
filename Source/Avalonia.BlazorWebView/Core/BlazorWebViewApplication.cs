namespace AvaloniaBlazorWebView.Core;

internal class BlazorWebViewApplication : IBlazorWebViewApplication
{
    public BlazorWebViewApplication(Action<IServiceCollection>? injectDelegate, Action<BlazorWebViewSetting> configDelegate)
    {
        _serviceCollection = new ServiceCollection();
        injectDelegate?.Invoke(_serviceCollection);
        _serviceCollection.AddOptions<BlazorWebViewSetting>().Configure(configDelegate);
        _serviceCollection.AddBlazorWebView()
                          .AddSingleton<JSComponentConfigurationStore>()
                          .AddSingleton<AvaloniaDispatcher>(provider => new AvaloniaDispatcher(AvaloniaUIDispatcher.UIThread))
                          .AddSingleton<IJSComponentConfiguration>(provider =>new JsComponentConfigration(provider.GetRequiredService<JSComponentConfigurationStore>()));
    }

    readonly IServiceCollection _serviceCollection;
    public IServiceProvider ServiceProvider => _serviceCollection.BuildServiceProvider();
}
