using AvaloniaBlazorWebView.Common;

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

        string contentRootDirFullPath;
        string hostPageRelativePath;
        string contentRootDir;

        if (OperatingSystemEx.IsDesktop())
        {
            var appRootDir = AppContext.BaseDirectory;
            var hostPageFullPath = Path.GetFullPath(Path.Combine(appRootDir, HostPage));
            contentRootDirFullPath = Path.GetDirectoryName(hostPageFullPath)!;
            hostPageRelativePath = Path.GetRelativePath(contentRootDirFullPath, hostPageFullPath);
            contentRootDir = Path.GetRelativePath(appRootDir, contentRootDirFullPath);
        }
        else
        {
            contentRootDirFullPath = Path.GetDirectoryName(HostPage) ?? string.Empty;
            hostPageRelativePath = Path.GetRelativePath(contentRootDirFullPath, HostPage!);
            contentRootDir = contentRootDirFullPath;
        }

        IFileProvider fileProvider;
        if (_setting.IsAvaloniaResource)
            fileProvider = new AvaloniaResourceFileProvider(_setting.ResourceAssembly!, contentRootDir);
        else
            fileProvider = _platformBlazorWebViewProvider.CreateFileProvider(_setting.ResourceAssembly, contentRootDirFullPath);

        var webViewManager = new AvaloniaWebViewManager(this, _serviceProvider, _dispatcher, _appScheme, _appHostAddress, _baseUri, fileProvider, _jsComponents, contentRootDirFullPath, hostPageRelativePath);
        //StaticContentHotReloadManager.AttachToWebViewManagerIfEnabled(webviewManager);
        var bRet = await platformWebView.Initialize(webViewManager);
        if (!bRet)
            return false;
        foreach (var rootComponent in RootComponents)
            await rootComponent.AddToWebViewManagerAsync(webViewManager);
        _webviewManager = webViewManager;
        return true;
    }

    void CheckDisposed()
    {
        if (_isDisposed)
            throw new ObjectDisposedException(GetType().Name);
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        return ValueTask.CompletedTask;
    }
}
