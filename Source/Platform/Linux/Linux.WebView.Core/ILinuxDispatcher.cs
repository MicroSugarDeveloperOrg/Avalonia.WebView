namespace Linux.WebView.Core;
public interface ILinuxDispatcher
{
    internal bool Start();
    internal bool Stop();
     
    Task<bool> InvokeAsync(Action action);
    Task<bool> InvokeAsync(Action<object, EventArgs> action);
    Task<bool> InvokeAsync(object sender, EventArgs args, Action<object, EventArgs> action);

    Task<T> InvokeAsync<T>(Func<T> func);
    Task<T> InvokeAsync<T>(Func<object, EventArgs, T> func);
    Task<T> InvokeAsync<T>(object sender, EventArgs args, Func<object, EventArgs, T> func);

}
