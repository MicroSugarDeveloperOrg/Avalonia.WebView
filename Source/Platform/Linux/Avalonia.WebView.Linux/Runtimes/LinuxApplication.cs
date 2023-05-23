using Avalonia.WebView.Linux.Interoperates;

namespace Avalonia.WebView.Linux.Runtimes;
internal class LinuxApplication : IDisposable
{
    public LinuxApplication()
    {

    }

    ~LinuxApplication()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }
    
    readonly CancellationTokenSource _cts = new CancellationTokenSource();
    Task? _appRunning;
    IntPtr _appHandle;
    IntPtr _displayHandle;

    Gtk.Application? _application;
    List<Gtk.Window> _windows = new();

    private bool disposedValue;

    bool Initialize(out IntPtr handle)
    {
        handle = IntPtr.Zero;
        try
        {
            using var backends = new Utf8Buffer("x11");
            Interop_gdk.gdk_set_allowed_backends(backends);
        }
        catch
        {
            //Ignore
        }

        Environment.SetEnvironmentVariable("WAYLAND_DISPLAY", "/proc/fake-display-to-prevent-wayland-initialization-by-gtk3");

        if (!Interop_gtk.gtk_init_check(0, IntPtr.Zero))
            return false;

        IntPtr appHandle;
        using var utf = new Utf8Buffer($"webview.app.a{Guid.NewGuid():N}");
        appHandle = Interop_gtk.gtk_application_new(utf, 0);

        if (appHandle == IntPtr.Zero)
            return false;
        _appHandle = appHandle;
        handle = appHandle;

        var displayHandle = Interop_gdk.gdk_display_get_default();
        _displayHandle = displayHandle;

        return true;
    }

    public Task<bool> RunAsync()
    {
        var tcs = new TaskCompletionSource<bool>();
        _appRunning = Task.Factory.StartNew(obj =>
        {
            if (obj is not CancellationTokenSource tokenSource)
            {
                tcs.SetResult(false);
                return false;
            }

            if (tokenSource.IsCancellationRequested)
            {
                tcs.SetResult(false);
                return false;
            }

            if (!Initialize(out var appHandle))
            {
                tcs.SetResult(false);
                return false;
            }

            _application = new Gtk.Application(appHandle);
            tcs.SetResult(true);

            for (; ; )
            {
                if (tokenSource.IsCancellationRequested)
                    break;

                Interop_gtk.gtk_main_iteration();
            }

            return true;

        }, _cts, TaskCreationOptions.LongRunning);

        return tcs.Task;
    }

    public Gtk.Window? CreatWindow(Gtk.Widget child)
    {
        if (_application is null)  return default;

        if (child is null) return default;

        var window = new Gtk.Window(Gtk.WindowType.Toplevel);
        window.Title = nameof(WebView);
        window.KeepAbove = true;
        _application.AddWindow(window);

        child.Realize();
        window.Add(child);
        window.ShowAll();
        window.Present();

        window.Destroyed += Window_Destroyed;
        _windows.Add(window);  
        
        return window;  
    }

    private void Window_Destroyed(object sender, EventArgs e)
    {
        if (sender is not Gtk.Window window)
            return;

        window.Destroyed -= Window_Destroyed;
        _windows.Remove(window);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
            }

            _cts.Cancel();
            _appRunning?.Wait();
            _appRunning?.Dispose();
            _appRunning = null;

            for (; ; )
            {
                if (_windows.Count <= 0)
                    break;

                _windows[0].Destroy();  
            }
           
            _application?.Dispose();
            _application = null;

            disposedValue = true;
        }
    }
 
    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
