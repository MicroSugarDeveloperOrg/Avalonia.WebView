using Avalonia.Controls;
using Avalonia.Controls.Platform;
using Avalonia.Platform;
using System.Runtime.InteropServices;
using WebViewCore;

namespace AvaloniaWebView.Shared.Handlers;

public abstract class ViewHandler : NativeControlHost, IViewHandler, INativeControlHostDestroyableControlHandle, IPlatformHandle, IDisposable
{
    public ViewHandler()
    {

    }

    ~ViewHandler()
    {
        Dispose(disposing: false);
    }

    private bool _disposedValue;
    protected bool KeepAlive { get; set; }  
    public HandleRef RefHandler { get; private set; }

    //#nullable disable
    public object PlatformViewContextObject { get; protected set; } = default!;
    public object VisualViewContextObject { get; protected set; } = default!;
    public IPlatformWebView PlatformWebView { get; protected set; } = default!;
    //#nullable restore

    public Control AttachableControl => this;

    public IntPtr Handle => RefHandler.Handle;

    public string? HandleDescriptor { get; protected set; }

    public event EventHandler<EventArgs>? PlatformHandlerChanged;

    protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
    {
        if (RefHandler.Handle == IntPtr.Zero)
        {
            var nativeHandle = CreatePlatformHandler(parent, () => base.CreateNativeControlCore(parent));
            RefHandler = nativeHandle;
            PlatformHandlerChanged?.Invoke(this, EventArgs.Empty);
        }

        return this;
    }

    protected override void DestroyNativeControlCore(IPlatformHandle control)
    {
        if (!KeepAlive)
        {
            ((IDisposable)this).Dispose();
            base.DestroyNativeControlCore(control);
        }

    }

    protected abstract HandleRef CreatePlatformHandler(IPlatformHandle parent, Func<IPlatformHandle> createFromSystem);

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
                Disposing();

            _disposedValue = true;
        }
    }

    protected abstract void Disposing();

    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    public void Destroy() => ((IDisposable)this).Dispose();
}
