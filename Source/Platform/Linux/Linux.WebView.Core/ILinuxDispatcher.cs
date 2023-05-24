namespace Linux.WebView.Core;
public interface ILinuxDispatcher
{
    internal bool Start();

    internal bool Stop();

    void Invoke(Action action);

    T Invoke<T>(Func<T> func);

    void Invoke(EventHandler handler);

    void Invoke(object sender, EventArgs args, EventHandler handler);

    Task<bool> InvokeAsync(EventHandler handler);

    Task<bool> InvokeAsync(object sender, EventArgs args, EventHandler handler);
}
