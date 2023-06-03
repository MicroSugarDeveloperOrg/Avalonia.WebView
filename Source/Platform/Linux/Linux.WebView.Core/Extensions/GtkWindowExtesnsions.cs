namespace Linux.WebView.Core.Extensions;

public static class GtkWindowExtesnsions
{
    public static nint X11Handle(this Gtk.Widget widget) => Interop_gdk.gdk_x11_window_get_xid(widget.Window.Handle);
}
