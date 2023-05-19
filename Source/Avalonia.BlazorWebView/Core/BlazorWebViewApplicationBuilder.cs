namespace AvaloniaBlazorWebView.Core;
internal class BlazorWebViewApplicationBuilder : IBlazorWebViewApplicationBuilder
{
    public BlazorWebViewApplicationBuilder(Action<IServiceCollection>? injectDelegate, Action<BlazorWebViewSetting> configDelegate)
    {
        _injectDelegate = injectDelegate;
        _configDelegate = configDelegate;
    }

    readonly Action<IServiceCollection>? _injectDelegate;
    readonly Action<BlazorWebViewSetting> _configDelegate;

    public IBlazorWebViewApplication Build() => new BlazorWebViewApplication(_injectDelegate, _configDelegate);
}
