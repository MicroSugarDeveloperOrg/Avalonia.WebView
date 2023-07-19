using Toolkit.Shared;

namespace AvaloniaBlazorWebView;

partial class BlazorWebView
{
    void CheckDisposed()
    {
        if (_isDisposed)
            throw new ObjectDisposedException(GetType().Name);
    }

    async Task<bool> CreateWebViewManager()
    {
        CheckDisposed();

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

        //IFileProvider fileProvider;
        //if (_setting.IsAvaloniaResource)
        //    fileProvider = new AvaloniaResourceFileProvider(_setting.ResourceAssembly!, contentRootDir);
        //else
        var fileProvider = _platformBlazorWebViewProvider.CreateFileProvider(_setting.ResourceAssembly, contentRootDirFullPath);
        var webViewManager = new AvaloniaWebViewManager(this, _serviceProvider, _dispatcher, _appScheme, _appHostAddress, _baseUri, fileProvider, _jsComponents, contentRootDirFullPath, hostPageRelativePath);
        //StaticContentHotReloadManager.AttachToWebViewManagerIfEnabled(webviewManager);

        var viewHandler = _viewHandlerProvider.CreatePlatformWebViewHandler(this, this, webViewManager, config =>
        {
            config.AreDevToolEnabled = _creationProperties.AreDevToolEnabled;
            config.AreDefaultContextMenusEnabled = _creationProperties.AreDefaultContextMenusEnabled;
            config.IsStatusBarEnabled = _creationProperties.IsStatusBarEnabled;
            config.BrowserExecutableFolder = _creationProperties.BrowserExecutableFolder;
            config.UserDataFolder = _creationProperties.UserDataFolder;
            config.Language = _creationProperties.Language;
            config.AdditionalBrowserArguments = _creationProperties.AdditionalBrowserArguments;
            config.ProfileName = _creationProperties.ProfileName;
            config.IsInPrivateModeEnabled = _creationProperties.IsInPrivateModeEnabled;
            config.DefaultWebViewBackgroundColor = _creationProperties.DefaultWebViewBackgroundColor;
        });

        if (viewHandler is null)
            throw new ArgumentNullException(nameof(viewHandler));

        var control = viewHandler.AttachableControl;
        if (control is null)
            return false;

        _platformWebView = viewHandler.PlatformWebView;
        if (_platformWebView is null)
            return false;

        Child = control;

        var bRet = await _platformWebView.Initialize();
        if (!bRet)
            return false;
        foreach (var rootComponent in RootComponents)
            await rootComponent.AddToWebViewManagerAsync(webViewManager);

        _webviewManager = webViewManager;
        return true;
    }

    ValueTask IAsyncDisposable.DisposeAsync()
    {
        return ValueTask.CompletedTask;
    }
}
