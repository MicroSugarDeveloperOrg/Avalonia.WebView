using System.Runtime.ExceptionServices;
using WindowsDispatcher = System.Windows.Threading.Dispatcher;

namespace Microsoft.AspNetCore.Components.WebView.Wpf;

internal sealed class WpfDispatcher : Dispatcher
{
    private readonly WindowsDispatcher _windowsDispatcher;

    public WpfDispatcher(WindowsDispatcher windowsDispatcher)
    {
        _windowsDispatcher = windowsDispatcher ?? throw new ArgumentNullException(nameof(windowsDispatcher));
    }

    private static Action<Exception> RethrowException = exception =>
        ExceptionDispatchInfo.Capture(exception).Throw();

    public override bool CheckAccess()
        => _windowsDispatcher.CheckAccess();

    public override async Task InvokeAsync(Action workItem)
    {
        try
        {
            if (_windowsDispatcher.CheckAccess())
            {
                workItem();
            }
            else
            {
                await _windowsDispatcher.InvokeAsync(workItem);
            }
        }
        catch (Exception ex)
        {
            _ = _windowsDispatcher.BeginInvoke(RethrowException, ex);
            throw;
        }
    }

    public override async Task InvokeAsync(Func<Task> workItem)
    {
        try
        {
            if (_windowsDispatcher.CheckAccess())
            {
                await workItem();
            }
            else
            {
                await _windowsDispatcher.InvokeAsync(workItem);
            }
        }
        catch (Exception ex)
        {
            _ = _windowsDispatcher.BeginInvoke(RethrowException, ex);
            throw;
        }
    }

    public override async Task<TResult> InvokeAsync<TResult>(Func<TResult> workItem)
    {
        try
        {
            if (_windowsDispatcher.CheckAccess())
            {
                return workItem();
            }
            else
            {
                return await _windowsDispatcher.InvokeAsync(workItem);
            }
        }
        catch (Exception ex)
        {
            _ = _windowsDispatcher.BeginInvoke(RethrowException, ex);
            throw;
        }
    }

    public override async Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> workItem)
    {
        try
        {
            if (_windowsDispatcher.CheckAccess())
            {
                return await workItem();
            }
            else
            {
                return await _windowsDispatcher.InvokeAsync(workItem).Task.Unwrap();
            }
        }
        catch (Exception ex)
        {
            _ = _windowsDispatcher.BeginInvoke(RethrowException, ex);
            throw;
        }
    }
}