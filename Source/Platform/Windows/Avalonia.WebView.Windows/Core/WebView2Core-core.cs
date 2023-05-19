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

    void RegisterWebViewEvents(CoreWebView2Controller coreWebView2Controller)
    {
        if (coreWebView2Controller is null)
            return;

        if (!_browserHitTransparent)
            coreWebView2Controller.AcceleratorKeyPressed += CoreWebView2Controller_AcceleratorKeyPressed; ;

        coreWebView2Controller.GotFocus += CoreWebView2Controller_GotFocus;
        coreWebView2Controller.LostFocus += CoreWebView2Controller_LostFocus;
        coreWebView2Controller.MoveFocusRequested += CoreWebView2Controller_MoveFocusRequested;
        coreWebView2Controller.ZoomFactorChanged += CoreWebView2Controller_ZoomFactorChanged;

        var corewebview2 = coreWebView2Controller.CoreWebView2;
        if (corewebview2 is null)
            return;

        corewebview2.NewWindowRequested += Corewebview2_NewWindowRequested;
        corewebview2.ContentLoading += Corewebview2_ContentLoading;
        corewebview2.HistoryChanged += Corewebview2_HistoryChanged;
        corewebview2.NavigationCompleted += Corewebview2_NavigationCompleted;
        corewebview2.NavigationStarting += Corewebview2_NavigationStarting;
        corewebview2.ProcessFailed += Corewebview2_ProcessFailed;
        corewebview2.SourceChanged += Corewebview2_SourceChanged;
        corewebview2.WebMessageReceived += Corewebview2_WebMessageReceived;
        corewebview2.WebResourceRequested += CoreWebView2_WebResourceRequested;
        corewebview2.DOMContentLoaded += Corewebview2_DOMContentLoaded;
        corewebview2.Profile.Deleted += Profile_Deleted;
    }

    void UnregisterWebViewEvents(CoreWebView2Controller coreWebView2Controller, bool browserCrashed = false)
    {
        if (coreWebView2Controller is null)
            return;

        var corewebview2 = coreWebView2Controller.CoreWebView2;

        if (!_browserHitTransparent)
            coreWebView2Controller.AcceleratorKeyPressed -= CoreWebView2Controller_AcceleratorKeyPressed; ;

        coreWebView2Controller.GotFocus -= CoreWebView2Controller_GotFocus;
        coreWebView2Controller.LostFocus -= CoreWebView2Controller_LostFocus;
        coreWebView2Controller.MoveFocusRequested -= CoreWebView2Controller_MoveFocusRequested;
        coreWebView2Controller.ZoomFactorChanged -= CoreWebView2Controller_ZoomFactorChanged;
        coreWebView2Controller.Close();

        if (corewebview2 is null)
            return;

        corewebview2.NewWindowRequested -= Corewebview2_NewWindowRequested;
        corewebview2.ContentLoading -= Corewebview2_ContentLoading;
        corewebview2.HistoryChanged -= Corewebview2_HistoryChanged;
        corewebview2.NavigationCompleted -= Corewebview2_NavigationCompleted;
        corewebview2.NavigationStarting -= Corewebview2_NavigationStarting;
        corewebview2.ProcessFailed -= Corewebview2_ProcessFailed;
        corewebview2.SourceChanged -= Corewebview2_SourceChanged;
        corewebview2.WebMessageReceived -= Corewebview2_WebMessageReceived;
        corewebview2.WebResourceRequested += CoreWebView2_WebResourceRequested;
        corewebview2.DOMContentLoaded -= Corewebview2_DOMContentLoaded;
        corewebview2.Profile.Deleted -= Profile_Deleted;
    }

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
        if (coreWebView2 is null)
            return;

        if (!_isBlazorWebView)
            return;

        coreWebView2.WebResourceRequested -= CoreWebView2_WebResourceRequested;
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

    private void Corewebview2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
    {
    }

    private void Corewebview2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
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

    private void Corewebview2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
    {
    }

    private void Corewebview2_ProcessFailed(object sender, CoreWebView2ProcessFailedEventArgs e)
    {
    }

    private void Corewebview2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
    {
    }

    private void Corewebview2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
    {
    }

    private void Corewebview2_HistoryChanged(object sender, object e)
    {
    }

    private void Corewebview2_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
    {
    }

    private void Corewebview2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
    {

    }

    private void Profile_Deleted(object sender, object e)
    {
    }
}
