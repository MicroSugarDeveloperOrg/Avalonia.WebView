namespace Linux.WebView.Core.Extensions;

internal static class GtkWindowExtesnsions
{
    public static nint X11Handle(this Gtk.Window window) => Interop_gdk.gdk_x11_window_get_xid(window.Handle);
}
