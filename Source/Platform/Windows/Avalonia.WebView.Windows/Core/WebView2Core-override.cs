namespace Avalonia.WebView.Windows.Core;

partial class WebView2Core
{
    WebView2Core IPlatformWebView<WebView2Core>.PlatformView => this;

    object? IPlatformWebView.PlatformViewContext => this;

    bool IPlatformWebView.IsInitialized => IsInitialized;

    bool IWebViewControl.IsCanGoForward => throw new NotImplementedException();

    bool IWebViewControl.IsCanGoBack => throw new NotImplementedException();


    async Task<bool> IPlatformWebView.Initialize(IVirtualWebViewProvider? virtualProvider)
    {
        if (IsInitialized)
            return true;

        _provider = virtualProvider;

        try
        {
            _callBack.PlatformWebViewCreating(this, new WebViewCreatingEventArgs());

            var environment2 = await CreateEnvironmentAsync().ConfigureAwait(true);
            _coreWebView2Environment = environment2;

            var options = CreateCoreWebView2ControllerOptions(environment2);
            IntPtr intPtr = await _hwndTaskSource.Task;
            if (options is not null)
            {
                CoreWebView2Environment environment3 = environment2;
                CoreWebView2Controller coreWebView2Controller = await environment3.CreateCoreWebView2ControllerAsync(intPtr, options).ConfigureAwait(true);
                _coreWebView2Controller = coreWebView2Controller;
                _controllerOptions = options;
            }
            else
            {
                CoreWebView2Environment environment3 = environment2;
                CoreWebView2Controller coreWebView2Controller = await environment3.CreateCoreWebView2ControllerAsync(intPtr).ConfigureAwait(true);
                _coreWebView2Controller = coreWebView2Controller;
            }

            var corewebview2 = _coreWebView2Controller.CoreWebView2;
            if (corewebview2 is null)
                throw new ArgumentNullException(nameof(corewebview2), "corewebview2 is null!");

            try
            {
                _browserHitTransparent = _coreWebView2Controller.IsBrowserHitTransparent;
            }
            catch (NotImplementedException)
            {

            }

            ResetWebViewSize(_coreWebView2Controller);

            if (_coreWebView2Controller.ParentWindow != intPtr)
                ReparentController(_coreWebView2Controller, intPtr);

            if (_coreWebView2Controller.ParentWindow != IntPtr.Zero)
                SyncControllerWithParentWindow(_coreWebView2Controller);

            ApplyDefaultWebViewSettings(corewebview2);
            RegisterWebViewEvents(_coreWebView2Controller);

            if (virtualProvider is not null)
                await PrepareBlazorWebViewStarting(virtualProvider, corewebview2).ConfigureAwait(true);

            IsInitialized = true;
            _callBack.PlatformWebViewCreated(this, new WebViewCreatedEventArgs { IsSucceed = true });
        }
        catch (Exception ex2)
        {
            _callBack.PlatformWebViewCreated(this, new WebViewCreatedEventArgs { IsSucceed = false, Message = ex2.ToString() });
            throw;
        }

        return true;
    }

    bool IWebViewControl.GoBack()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.GoForward()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        if (CoreWebView2 is null)
            return false;

        CoreWebView2.Navigate(uri.AbsoluteUri);
        return true;
    }

    bool IWebViewControl.NavigateToString(string htmlContent)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.OpenDevToolsWindow()
    {
        throw new NotImplementedException();
    }

    Task<string?> IWebViewControl.ExecuteScriptAsync(string javaScript)
    {
        throw new NotImplementedException();
    }


    bool IWebViewControl.PostWebMessageAsJson(string webMessageAsJson)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.PostWebMessageAsString(string webMessageAsString)
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Reload()
    {
        throw new NotImplementedException();
    }

    bool IWebViewControl.Stop()
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
                try
                {
                    ClearBlazorWebViewCompleted(CoreWebView2!);
                    UnregisterWebViewEvents(_coreWebView2Controller!);
                    UnregisterEvents();
                }
                catch (Exception)
                {

                }

                _controllerOptions = null;
                _coreWebView2Controller = null;
                _coreWebView2Environment = null;
            }
 
            IsDisposed = true;
        }
    }

    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        ((IDisposable)this)?.Dispose();
        return new ValueTask();
    }
}
