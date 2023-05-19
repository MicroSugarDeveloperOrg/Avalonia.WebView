namespace AvaloniaBlazorWebView.Core;

internal class AvaloniaDispatcher : Dispatcher
{
    public AvaloniaDispatcher(AvaloniaUIDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    readonly AvaloniaUIDispatcher _dispatcher;

    public override bool CheckAccess()
    {
        return _dispatcher.CheckAccess();
    }

    public override Task InvokeAsync(Action workItem)
    {
        return _dispatcher.InvokeAsync(workItem).GetTask();
    }

    public override Task InvokeAsync(Func<Task> workItem)
    {
        return _dispatcher.InvokeAsync(workItem);
    }

    public override Task<TResult> InvokeAsync<TResult>(Func<TResult> workItem)
    {
        return _dispatcher.InvokeAsync(workItem).GetTask();
    }

    public override Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> workItem)
    {
        return _dispatcher.InvokeAsync(workItem);
    }
}
