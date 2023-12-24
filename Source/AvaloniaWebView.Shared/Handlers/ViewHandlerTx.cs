using Avalonia.Controls;
using WebViewCore;

namespace AvaloniaWebView.Shared.Handlers;

public abstract class ViewHandlerTx : Control, IViewHandler, IDisposable
{
    public ViewHandlerTx()
    {

    }

    ~ViewHandlerTx()
    {
        Dispose(disposing: false);
    }

    private bool _disposedValue;
    protected bool KeepAlive { get; set; }
    public string? HandleDescriptor { get; protected set; }

    //#nullable disable
    public object PlatformViewContextObject { get; protected set; } = default!;
    public object VisualViewContextObject { get; protected set; } = default!;
    public IPlatformWebView PlatformWebView { get; protected set; } = default!;
    //#nullable restore

    public Control AttachableControl => this;

    protected abstract void Disposing();

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
                Disposing();

            _disposedValue = true;
        }
    }

    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
