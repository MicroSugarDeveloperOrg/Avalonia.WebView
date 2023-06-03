namespace Linux.WebView.Core.Extensions;

public static class GtkWindowExtesnsions
{
    public static nint X11Handle(this GWidget widget) => GtkApi.GetWidgetXid(widget);
}
