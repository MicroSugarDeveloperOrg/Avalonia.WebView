namespace Avalonia.WebView.Linux.Handlers;
internal class JavaScriptValueCallback : GLib.Object, GLib.IAsyncResult
{
    public JavaScriptValueCallback(Action<string> callback)
    {
        _callback = callback;
    }

    readonly Action<string> _callback;

    public GLib.Object SourceObject => throw new NotImplementedException();

    public IntPtr UserData => throw new NotImplementedException();


    public bool IsTagged(IntPtr source_tag)
    {
        return true;
    }

    public bool LegacyPropagateError()
    {
        return false;
    }
}
