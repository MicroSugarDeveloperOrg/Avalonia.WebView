namespace Avalonia.WebView.Windows.Core;

partial class WebView2Core
{
    Task<CoreWebView2Environment> CreateEnvironmentAsync()
    {
        var options = new CoreWebView2EnvironmentOptions(_creationProperties.AdditionalBrowserArguments!, _creationProperties.Language!);
        //return CoreWebView2Environment.CreateAsync(_creationProperties.BrowserExecutableFolder!, _creationProperties.UserDataFolder!, options);
        return CoreWebView2Environment.CreateAsync();
    }

    CoreWebView2ControllerOptions? CreateCoreWebView2ControllerOptions(CoreWebView2Environment environment)
    {
        if (string.IsNullOrWhiteSpace(_creationProperties.ProfileName) && _creationProperties.IsInPrivateModeEnabled is null)
            return default;

        var coreWebView2ControllerOptions = environment.CreateCoreWebView2ControllerOptions();
        coreWebView2ControllerOptions.ProfileName = _creationProperties.ProfileName!;
        coreWebView2ControllerOptions.IsInPrivateModeEnabled = _creationProperties.IsInPrivateModeEnabled.GetValueOrDefault();

        return coreWebView2ControllerOptions;
    }

    void SetEnvirmentDefaultBackground(Color color) => Environment.SetEnvironmentVariable("WEBVIEW2_DEFAULT_BACKGROUND_COLOR", color.Name);

    Task PrepareBlazorWebViewStarting(IVirtualWebViewProvider provider, CoreWebView2 coreWebView2)
    {
        if (provider is null || coreWebView2 is null)
            return Task.CompletedTask;

        if (!provider.ResourceRequestedFilterProvider(this, out var fileter))
            return Task.CompletedTask;

        _isBlazorWebView = true;
        coreWebView2.AddWebResourceRequestedFilter(fileter, CoreWebView2WebResourceContext.All);
        return coreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(BlazorScriptHelper.BlazorStartingScript);
    }

    void ClearBlazorWebViewCompleted(CoreWebView2 coreWebView2)
    {
        _isBlazorWebView = false;
    }

    private async void CoreWebView2_WebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs e)
    {
        await CoreWebView2_WebResourceRequestedAsync(sender, e);
    }

    private Task CoreWebView2_WebResourceRequestedAsync(object sender, CoreWebView2WebResourceRequestedEventArgs e)
    {
        if (_provider is null)
            return Task.CompletedTask;

        if (_coreWebView2Environment is null)
            return Task.CompletedTask;

        var allowFallbackOnHostPage = e.ResourceContext == CoreWebView2WebResourceContext.Document ||
                                      e.ResourceContext == CoreWebView2WebResourceContext.Other;

        var request = new WebResourceRequest
        {
            RequestUri = e.Request.Uri,
            AllowFallbackOnHostPage = allowFallbackOnHostPage
        };

        if (!_provider.PlatformWebViewResourceRequested(this, request, out var reponse))
            return Task.CompletedTask;

        if (reponse is null)
            return Task.CompletedTask;

        e.Response = _coreWebView2Environment.CreateWebResourceResponse(reponse.Content, reponse.StatusCode, reponse.StatusMessage, reponse.HeaderString);

        return Task.CompletedTask;
    }

    private void CoreWebView2Controller_ZoomFactorChanged(object sender, object e)
    {
    }

    private void CoreWebView2Controller_MoveFocusRequested(object sender, CoreWebView2MoveFocusRequestedEventArgs e)
    {
    }

    private void CoreWebView2Controller_LostFocus(object sender, object e)
    {
    }

    private void CoreWebView2Controller_GotFocus(object sender, object e)
    {
    }

    private void CoreWebView2Controller_AcceleratorKeyPressed(object sender, CoreWebView2AcceleratorKeyPressedEventArgs e)
    {
    }

    private void CoreWebView2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
    {
    }

    private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
    {
        var message = new WebViewMessageReceivedEventArgs
        {
            Message = e.TryGetWebMessageAsString(),
            MessageAsJson = e.WebMessageAsJson,
            Source = e.Source,
        };
        _callBack.PlatformWebViewMessageReceived(this, message);
        _provider?.PlatformWebViewMessageReceived(this, message);
    }

    private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
    {
    }

    private void CoreWebView2_ProcessFailed(object sender, CoreWebView2ProcessFailedEventArgs e)
    {
    }

    private void CoreWebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
    {
    }

    private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
    {
    }

    private void CoreWebView2_HistoryChanged(object sender, object e)
    {
    }

    private void CoreWebView2_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
    {
    }

    private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
    {

    }

    private void Profile_Deleted(object sender, object e)
    {
    }
}
