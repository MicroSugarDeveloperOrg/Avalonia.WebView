namespace Linux.WebView.Core;

internal class LinuxApplication : ILinuxApplication
{
    static LinuxApplication()
    {
    }

    public LinuxApplication(bool isWslDevelop)
    {
        _isWslDevelop = isWslDevelop;
        _dispatcher = new LinuxDispatcher();
    }

    ~LinuxApplication()
    {
        Dispose(disposing: false);
    }

    private readonly bool _isWslDevelop;
    readonly ILinuxDispatcher _dispatcher;
    //Task? _appRunning;
    Thread? _appThread;
    GDisplay? _defaultDisplay;
    GApplication? _application;

    bool _isRunning = false;
    public bool IsRunning
    {
        get => _isRunning;
        protected set => _isRunning = value;
    }

    bool _isDisposed;
    public bool IsDisposed
    {
        get => _isDisposed;
        protected set => _isDisposed = value;
    }

    bool ILinuxApplication.IsRunning => IsRunning;

    ILinuxDispatcher ILinuxApplication.Dispatcher => _dispatcher;

    Task<bool> ILinuxApplication.RunAsync(string? applicationName, string[]? args)
    {
        if (IsRunning)
            return Task.FromResult(true);

        var tcs = new TaskCompletionSource<bool>();
        //_appRunning = Task.Factory.StartNew(obj =>
        //{
        //    Environment.SetEnvironmentVariable("WAYLAND_DISPLAY", "/proc/fake-display-to-prevent-wayland-initialization-by-gtk3");
        //    if (!_isWslDevelop)
        //        GtkApi.SetAllowedBackends("x11,wayland,quartz,*");
        //        //GtkApi.SetAllowedBackends("x11");
        //    GApplication.Init();   
        //    _defaultDisplay = GDisplay.Default;
//
        //    _application = new("WebView.Application", GLib.ApplicationFlags.None);
        //    _application.Register(GLib.Cancellable.Current);
//
        //    _dispatcher.Start();
        //    IsRunning = true;
//
        //    tcs.SetResult(true);
        //    GApplication.Run();
        //}, TaskCreationOptions.LongRunning);
//

        _appThread = new Thread(()=> Run(tcs))
        {
            Name = "GTK3WORKINGTHREAD",
            IsBackground = true,
        };
        _appThread.Start();

        return tcs.Task;
    }

    void Run(TaskCompletionSource<bool> taskSource)
    {
        if (!_isWslDevelop)
                GtkApi.SetAllowedBackends("x11");
                //GtkApi.SetAllowedBackends("x11,wayland,quartz,*");
        Environment.SetEnvironmentVariable("WAYLAND_DISPLAY", "/proc/fake-display-to-prevent-wayland-initialization-by-gtk3");

        try
        {
            GApplication.Init();   
            _application = new("WebView.Application", GLib.ApplicationFlags.None);
            _application.Register(GLib.Cancellable.Current);
            _dispatcher.Start();

            _defaultDisplay = GDisplay.Default;
            IsRunning = true;
            taskSource.SetResult(true);
            GApplication.Run();
        }
        catch
        {
            taskSource.SetResult(false);
        }
    }

    Task ILinuxApplication.StopAsync()
    {
        if (!IsRunning)
            return Task.CompletedTask;

        _application = null;
        _dispatcher.Stop();
        GApplication.Quit();
        _appThread?.Join();
        //_appRunning?.Wait();
        return Task.CompletedTask;
    }

    protected virtual async void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
            }

            await ((ILinuxApplication)this).StopAsync();

            _defaultDisplay?.Dispose();
            _defaultDisplay = null;

            IsDisposed = true;
        }
    }

    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    Task<(GWindow, WebKitWebView, IntPtr hostHandle)> ILinuxApplication.CreateWebView()
    {
        if (!_isRunning) throw new InvalidOperationException(nameof(IsRunning));
        return _dispatcher.InvokeAsync(() =>
        {
            GWindow window = new("WebView.Gtk.Window");
            _application?.AddWindow(window);
            window.KeepAbove = true;
            //window.DefaultSize = new GSize(100,100); 
            WebKitWebView webView = new(new Settings(){ EnableFullscreen = true}); 
            window.Add(webView);
            window.ShowAll();
            return (window, webView, window.X11Handle());
        });
    }


}
