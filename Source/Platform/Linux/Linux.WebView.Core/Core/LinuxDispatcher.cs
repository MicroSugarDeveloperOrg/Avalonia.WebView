namespace Linux.WebView.Core;

internal class LinuxDispatcher : ILinuxDispatcher
{
    public LinuxDispatcher()
    {

    }

    bool _isRuning = false;

    void ILinuxDispatcher.Invoke(EventHandler handler)
    {
        if (_isRuning)
            Gtk.Application.Invoke(handler);
    }

    void ILinuxDispatcher.Invoke(object sender, EventArgs args, EventHandler handler)
    {
        if (_isRuning)
            Gtk.Application.Invoke(sender, args, handler);
    }


    Task<bool> ILinuxDispatcher.InvokeAsync(EventHandler handler)
    {
        if (_isRuning)
            return Task.FromResult(false);

        var task = new TaskCompletionSource<bool>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke(handler);
            task.SetResult(true);
        });
        return task.Task;
    }

    Task<bool> ILinuxDispatcher.InvokeAsync(object sender, EventArgs args, EventHandler handler)
    {
        if (_isRuning)
            return Task.FromResult(false);

        var task = new TaskCompletionSource<bool>();
        Task.Run(() =>
        {
            Gtk.Application.Invoke(sender, args, handler);
            task.SetResult(true);
        });
        return task.Task;
    }

    bool ILinuxDispatcher.Start()
    {
        _isRuning = true;
        return true;
    }

    bool ILinuxDispatcher.Stop()
    {
        _isRuning = false;
        return true;
    }

    void ILinuxDispatcher.Invoke(Action action)
    {
        if (!_isRuning)
            return;
        Gtk.Application.Invoke((s, e) =>
        {
            action?.Invoke();
        });
    }

    T ILinuxDispatcher.Invoke<T>(Func<T> func)
    {
        if (!_isRuning)
            return default(T)!;

        T flag = default(T)!;
        Gtk.Application.Invoke((s, e) =>
        {
            flag = func.Invoke();
        });

        return flag;    
    }
}
