namespace AvaloniaBlazorWebView;

partial class BlazorWebView
{
    static bool LoadHostDependencyObjectsChanged()
    {
        HostPageProperty.Changed.AddClassHandler<BlazorWebView, string?>((s, e) =>
        {
            if (s._platformWebView is null)
                return;

            var hostPage = e.NewValue.Value;
            if (string.IsNullOrWhiteSpace(hostPage))
                return;

            var webviewManager = s._webviewManager;
            //if (webviewManager is null)
               // await s.CreateWebViewManager(s._platformWebView);

            if (webviewManager is not null)
                webviewManager.Navigate(s._startAddress);
        });

        return true;
    }

    public static readonly StyledProperty<string?> HostPageProperty =
           AvaloniaProperty.Register<BlazorWebView, string?>(nameof(HostPage));

    public static readonly StyledProperty<BlazorRootComponentsCollection> RootComponentsProperty =
            AvaloniaProperty.Register<BlazorWebView, BlazorRootComponentsCollection>(nameof(RootComponents), defaultValue: new BlazorRootComponentsCollection());


    public string? HostPage
    {
        get => GetValue(HostPageProperty);
        set => SetValue(HostPageProperty, value);
    }

    public BlazorRootComponentsCollection RootComponents => GetValue(RootComponentsProperty);

    private async void RootComponents_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        CheckDisposed();

        if (_webviewManager is null)
        {
            //await CreateWebViewManager(_platformWebView);
            return;
        }

        await _dispatcher.InvokeAsync(async () =>
        {
            var newItems = (e.NewItems ?? Array.Empty<BlazorRootComponent>()).Cast<BlazorRootComponent>();
            var oldItems = (e.OldItems ?? Array.Empty<BlazorRootComponent>()).Cast<BlazorRootComponent>();

            foreach (var item in newItems.Except(oldItems))
                await item.AddToWebViewManagerAsync(_webviewManager);

            foreach (var item in oldItems.Except(newItems))
                await item.RemoveFromWebViewManagerAsync(_webviewManager);
        });
    }



}
