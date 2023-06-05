namespace Linux.WebView.Core.Interoperates;

internal class Interop_gdk
{
    //const string _Gdk = "gdk";
    const string _Gdk = "libgdk-3.so.0";

    [DllImport(_Gdk)]
    public static extern ulong g_signal_connect_data(nint instance, string detailed_signal, nint c_handler, nint data, nint destroy_data, GConnectFlags connect_flags);

    public static ulong g_signal_connect(nint instance, string detailed_signal, nint c_handler, nint data)
    {
        return g_signal_connect_data(instance, detailed_signal, c_handler, data, 0, 0);
    }

    [DllImport(_Gdk)]
    public static extern nint g_memory_input_stream_new_from_data(byte[] data, uint len, nint destroy);

    [DllImport(_Gdk)]
    public static extern void g_free(nint o);


    [DllImport(_Gdk)]
    public static extern nint gdk_x11_window_foreign_new_for_display(nint display, nint xid);

    [DllImport(_Gdk)]
    public static extern nint gdk_x11_window_get_xid(nint window);


    [DllImport(_Gdk)]
    public static extern nint gdk_set_allowed_backends(string backends);

    [DllImport(_Gdk)]
    public static extern nint gdk_display_get_default();

    [DllImport(_Gdk)]
    public static extern void gdk_window_set_transient_for(nint window, nint parent);

    public static void SetWindowParent(nint gdkWindow, nint x11Window) => gdk_window_set_transient_for(gdkWindow, x11Window);

    public static nint GetForeignWindow(nint display, nint xid) => gdk_x11_window_foreign_new_for_display(display, xid);
}
