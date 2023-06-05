namespace Linux.WebView.Core.Interoperates;

internal class Interop_gobject
{
    //const string _GObject = "gobject";
    const string _GObject = "libgobject-2.0.so.0";

    [DllImport(_GObject)]
    private static extern void g_object_ref(nint instance);

    [DllImport(_GObject)]
    private static extern ulong g_signal_connect_object(nint instance, string signal, nint handler, nint userData, int flags);

    [DllImport(_GObject)]
    private static extern void g_object_unref(nint instance);

    [DllImport(_GObject)]
    private static extern ulong g_signal_handler_disconnect(nint instance, ulong connectionId);

}
