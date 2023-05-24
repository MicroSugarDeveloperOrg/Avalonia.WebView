namespace Linux.WebView.Core;

internal class LinuxDispatcher : ILinuxDispatcher
{
    public LinuxDispatcher()
    {

    }

    bool _isRunning = false;
    bool ILinuxDispatcher.Start()
    {
        _isRunning = true;
        return true;
    }

    bool ILinuxDispatcher.Stop()
    {
        _isRunning = false;
        return true;
    }

    Task<bool> ILinuxDispatcher.InvokeAsync(Action action)
    {
        if (action is null)
            throw new ArgumentNullException(nameof(action));
        
        if (!_isRunning)
            return Task.FromResult(false);

        var task = new TaskCompletionSource<bool>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke((s, e) =>
            {
                action?.Invoke();
                task.SetResult(true);
            });
        });
        return task.Task;
    }
    
    Task<bool> ILinuxDispatcher.InvokeAsync(Action<object, EventArgs> action)
    {
        if (action is null)
            throw new ArgumentNullException(nameof(action));
        
        if (!_isRunning)
            return Task.FromResult(false);

        var task = new TaskCompletionSource<bool>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke((s, e) =>
            {
                action?.Invoke(s, e);
                task.SetResult(true);
            });
        });
        return task.Task;
    }
    
    Task<bool> ILinuxDispatcher.InvokeAsync(object sender, EventArgs args, Action<object, EventArgs> action)
    {
        if (action is null)
            throw new ArgumentNullException(nameof(action));
        
        if (!_isRunning)
            return Task.FromResult(false);

        var task = new TaskCompletionSource<bool>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke(sender, args,(s, e) =>
            {
                action?.Invoke(s, e);
                task.SetResult(true);
            });
        });
        return task.Task;
    }
    
    Task<T> ILinuxDispatcher.InvokeAsync<T>(Func<T> func)
    {
        if (func is null)
            throw new ArgumentNullException(nameof(func));
        
        if (!_isRunning)
            return Task.FromResult<T>(default(T)!);

        var task = new TaskCompletionSource<T>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke((s, e) =>
            {
                var ret = func.Invoke();
                task.SetResult(ret);
            });
        });
        return task.Task;
    }
    
    Task<T> ILinuxDispatcher.InvokeAsync<T>(Func<object, EventArgs, T> func)
    {
        if (func is null)
            throw new ArgumentNullException(nameof(func));
        
        if (!_isRunning)
            return Task.FromResult<T>(default(T)!);

        var task = new TaskCompletionSource<T>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke((s, e) =>
            {
                var ret = func.Invoke(s, e);
                task.SetResult(ret);
            });
        });
        return task.Task;
    }
    
    Task<T> ILinuxDispatcher.InvokeAsync<T>(object sender, EventArgs args, Func<object, EventArgs, T> func)
    {
        if (func is null)
            throw new ArgumentNullException(nameof(func));
        
        if (!_isRunning)
            return Task.FromResult<T>(default(T)!);

        var task = new TaskCompletionSource<T>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke(sender, args,(s, e) =>
            {
                var ret = func.Invoke(s, e);
                task.SetResult(ret);
            });
        });
        return task.Task;
    }
}
