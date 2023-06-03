namespace Linux.WebView.Core.Interoperates;

internal class Interop_gdk_x11
{
    const string _Gdk_x11 = "libgdk-x11-2.0.so.0";

    [DllImport(_Gdk_x11, CallingConvention = CallingConvention.Cdecl)]
    public static extern nint gdk_x11_drawable_get_xid(nint gdkWindowHandle);
}