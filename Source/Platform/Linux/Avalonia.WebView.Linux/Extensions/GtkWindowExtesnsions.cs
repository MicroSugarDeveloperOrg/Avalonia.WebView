using Avalonia.WebView.Linux.Interoperates;

namespace Avalonia.WebView.Linux.Extensions;
internal static class GtkWindowExtesnsions
{
    public static nint Handler(this Gtk.Window window) => Interop_gdk.gdk_x11_window_get_xid(window.Handle);
}
