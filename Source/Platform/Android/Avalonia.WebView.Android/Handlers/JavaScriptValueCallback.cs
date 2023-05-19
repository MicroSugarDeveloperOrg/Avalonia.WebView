namespace Avalonia.WebView.Android.Handlers;
internal class JavaScriptValueCallback : Java.Lang.Object, IValueCallback
{
    public JavaScriptValueCallback(Action<Java.Lang.Object?> callback)
    {
        ArgumentNullException.ThrowIfNull(callback);
        _callback = callback;
    }

    readonly Action<Java.Lang.Object?> _callback;

    public void OnReceiveValue(Java.Lang.Object? value)
    {
        _callback?.Invoke(value);   
    }
}
