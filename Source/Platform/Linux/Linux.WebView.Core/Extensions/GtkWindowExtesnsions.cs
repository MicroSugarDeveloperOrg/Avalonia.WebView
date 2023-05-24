namespace Linux.WebView.Core.Extensions;

internal static class GtkWindowExtesnsions
{
    public static nint X11Handle(this Gtk.Window window) => Interop_gdk_x11.gdk_x11_drawable_get_xid(window.Handle);
}
