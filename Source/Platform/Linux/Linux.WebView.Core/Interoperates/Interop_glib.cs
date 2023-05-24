namespace Linux.WebView.Core.Interoperates;

public delegate bool timeout_callback(IntPtr data);

internal unsafe class Interop_glib
{
    //const string _Glib = "glib";
    const string _Glib = "libglib-2.0.so.0";


    [DllImport(_Glib)]
    public static extern void g_slist_free(GSList* data);


    [DllImport(_Glib)]
    private static extern ulong g_timeout_add_full(int prio, uint interval, timeout_callback callback, nint data, nint destroy);
}
