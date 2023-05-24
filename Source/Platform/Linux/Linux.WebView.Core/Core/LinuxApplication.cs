using Linux.WebView.Core.Core;

namespace Linux.WebView.Core;

internal class LinuxApplication : ILinuxApplication
{
    public LinuxApplication()
    {
        _dispatcher = new LinuxDispatcher();
    }

    ~LinuxApplication()
    {
        Dispose(disposing: false);
    }

    readonly string _applicationCheckString = "WebViewApplication";
    readonly ILinuxDispatcher _dispatcher;
    Task? _appRunning;
    Gtk.Application? _application;
    Gdk.Display? _defaultDisplay;

    bool _isInitilazed = false;

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

    bool Initialize(string? applicationName, string[]? args)
    {
        if (_isInitilazed)
            return true;

        try
        {
            using var backends = new Utf8Buffer("x11");
            Interop_gdk.gdk_set_allowed_backends(backends);
        }
        catch
        {
        }
 
        Environment.SetEnvironmentVariable("WAYLAND_DISPLAY", "/proc/fake-display-to-prevent-wayland-initialization-by-gtk3");

        if (args is null)
            args = new string[] { };

        Gtk.Application.Init(); 
        //Gtk.Application.InitCheck(_applicationCheckString, ref args);

        var appName = string.IsNullOrWhiteSpace(applicationName) ? $"webview.app.a{Guid.NewGuid():N}" : applicationName!;
        _application = new Gtk.Application(appName, GLib.ApplicationFlags.None);
        _defaultDisplay = Gdk.Display.Default;

        _isInitilazed = true;
        return true;
    }

    Task<bool> ILinuxApplication.RunAsync(string? applicationName, string[]? args)
    {
        if (IsRunning)
            return Task.FromResult(true);

        var tcs = new TaskCompletionSource<bool>();
        _appRunning = Task.Factory.StartNew(obj =>
        {
            if (!Initialize(applicationName, args))
                tcs.SetResult(false);

            _dispatcher.Start();
            IsRunning = true;
            tcs.SetResult(true);
            //Gtk.Application.Run();
            while (true)
                Gtk.Application.RunIteration();

        }, TaskCreationOptions.LongRunning);

        return tcs.Task;
    }

    Task ILinuxApplication.StopAsync()
    {
        if (!IsRunning)
            return Task.CompletedTask;

        _dispatcher.Stop();
        Gtk.Application.Quit();
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

            _application?.Dispose();
            _application = null;

            IsDisposed = true;
        }
    }

    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    ILinuxWebView? ILinuxApplication.CreateWebView()
    {
        if (!_isRunning)
            return default;

        if (_application is null)
            return default;

        var linuxWebView = new LinuxWebViewCore(_dispatcher, _application);
        return linuxWebView;
    }
}
