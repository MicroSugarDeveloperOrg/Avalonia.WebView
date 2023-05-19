namespace AvaloniaBlazorWebView.Components;
public class BlazorRootComponent
{
    public string Selector { get; set; } = default!;
    public Type ComponentType { get; set; } = default!;
    public IDictionary<string, object?>? Parameters { get; set; }

    internal Task AddToWebViewManagerAsync(WebViewManager webViewManager)
    {
        if (string.IsNullOrWhiteSpace(Selector))
            throw new InvalidOperationException($"{nameof(BlazorRootComponent)} requires a value for its {nameof(Selector)} property, but no value was set.");

        if (ComponentType is null)
            throw new InvalidOperationException($"{nameof(BlazorRootComponent)} requires a value for its {nameof(ComponentType)} property, but no value was set.");

        var parameterView = Parameters == null ? ParameterView.Empty : ParameterView.FromDictionary(Parameters);
        return webViewManager.AddRootComponentAsync(ComponentType, Selector, parameterView);
    }

    internal Task RemoveFromWebViewManagerAsync(AvaloniaWebViewManager webviewManager)
    {
        return webviewManager.RemoveRootComponentAsync(Selector);
    }
}