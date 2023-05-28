namespace AvaloniaBlazorWebView.Core;

internal class AvaloniaDispatcher : Dispatcher
{
    public AvaloniaDispatcher(AvaloniaUIDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    readonly AvaloniaUIDispatcher _dispatcher;

    public override bool CheckAccess() => _dispatcher.CheckAccess();

    public override async Task InvokeAsync(Action workItem)
    {
        try
        {
            if (_dispatcher.CheckAccess())
                workItem();
            else
                await _dispatcher.InvokeAsync(workItem).GetTask();
        }
        catch (Exception)
        {      
            throw;
        }
    }

    public override async Task InvokeAsync(Func<Task> workItem)
    {
        try
        {
            if (_dispatcher.CheckAccess())
               await workItem();
            else
                await _dispatcher.InvokeAsync(workItem);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public override async Task<TResult> InvokeAsync<TResult>(Func<TResult> workItem)
    {
        try
        {
            if (_dispatcher.CheckAccess())
                return workItem();
            else
                return await _dispatcher.InvokeAsync(workItem);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public override async Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> workItem)
    {
        try
        {
            if (_dispatcher.CheckAccess())
                return await workItem();
            else
                return await _dispatcher.InvokeAsync(workItem);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
