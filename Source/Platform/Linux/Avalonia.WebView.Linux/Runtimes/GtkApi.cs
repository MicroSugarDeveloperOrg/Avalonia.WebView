namespace Avalonia.WebView.Linux.Runtimes;

public class GtkApi
{
    private const string __gdk = "libgdk-3.so.0";
    private const string __gtk = "libgtk-3.so.0";

    [DllImport(__gdk)]
    public static extern IntPtr gdk_x11_window_get_xid(IntPtr window);

    [DllImport(__gtk)]
    public static extern void gtk_widget_destroy(IntPtr gtkWidget);

}