namespace AvaloniaBlazorWebView;

partial class BlazorWebView
{
    async Task<bool> CreateWebViewManager(IPlatformWebView? platformWebView)
    {
        CheckDisposed();
        if (platformWebView is null)
            return false;

        if (platformWebView.IsInitialized)
            return true;

        if (_webviewManager is not null)
            return true;

        if (string.IsNullOrEmpty(HostPage))
            return false;

        if (RootComponents.Count <= 0)
            return false;

        string appRootDir;
        var entryAssemblyLocation = Assembly.GetEntryAssembly()?.Location;
        if (!string.IsNullOrEmpty(entryAssemblyLocation))
            appRootDir = Path.GetDirectoryName(entryAssemblyLocation)!;
        else
            appRootDir = Environment.CurrentDirectory;

        var hostPageFullPath = Path.GetFullPath(Path.Combine(appRootDir, HostPage));
        var contentRootDirFullPath = Path.GetDirectoryName(hostPageFullPath)!;
        var hostPageRelativePath = Path.GetRelativePath(contentRootDirFullPath, hostPageFullPath);
        var contentRootDirRelativePath = Path.GetRelativePath(appRootDir, contentRootDirFullPath);
        var fileProvider = new PhysicalFileProvider(contentRootDirFullPath);

        var webviewManager = new AvaloniaWebViewManager(this, _serviceProvider, _dispatcher, _baseUri, fileProvider, _jsComponents, contentRootDirRelativePath, hostPageRelativePath);
        var bRet = await platformWebView.Initialize(webviewManager);
        if (!bRet)
            return false;
        foreach (var rootComponent in RootComponents)
            await rootComponent.AddToWebViewManagerAsync(webviewManager);
        _webviewManager = webviewManager;
        return true;
    }

    void CheckDisposed()
    {
        if (_isDisposed)
            throw new ObjectDisposedException(GetType().Name);
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        throw new NotImplementedException();
    }
}
