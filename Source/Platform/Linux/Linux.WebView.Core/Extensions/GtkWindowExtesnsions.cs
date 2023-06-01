namespace Linux.WebView.Core.Extensions;

public static class GtkWindowExtesnsions
{
    public static nint X11Handle(this Gtk.Window window) => Interop_gdk_x11.gdk_x11_drawable_get_xid(window.Handle);

    public static void SetParent(this Gtk.Window window, nint parent)
    {
        //var handle = Interop_gdk.GetForeignWindow(GDisplay.Default.Handle, parent);
        //Interop_gdk.SetWindowParent(window.Handle, handle);

        Interop_gdk.SetWindowParent(window.Handle, parent);
    }
}
