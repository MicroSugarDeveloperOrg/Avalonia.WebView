namespace Linux.WebView.Core.Interoperates;

public enum GtkWindowType : int
{
    GTK_WINDOW_TOPLEVEL,
    GTK_WINDOW_WINDOW_POPUP
}

public enum GConnectFlags : int
{
    G_CONNECT_AFTER,
    G_CONNECT_SWAPPED
}

enum GtkFileChooserAction
{
    Open,
    Save,
    SelectFolder,
}

// ReSharper disable UnusedMember.Global
enum GtkResponseType
{
    Help = -11,
    Apply = -10,
    No = -9,
    Yes = -8,
    Close = -7,
    Cancel = -6,
    Ok = -5,
    DeleteEvent = -4,
    Accept = -3,
    Reject = -2,
    None = -1,
}


internal unsafe class Interop_gtk
{
    //const string _Gtk = "gtk";
    const string _Gtk = "libgtk-3.so.0";

    [DllImport(_Gtk)]
    public static extern ulong g_signal_connect_data(nint instance, string detailed_signal, nint c_handler, nint data, nint destroy_data, GConnectFlags connect_flags);

    public static ulong g_signal_connect(nint instance, string detailed_signal, nint c_handler, nint data)
    {
        return g_signal_connect_data(instance, detailed_signal, c_handler, data, 0, 0);
    }

    [DllImport(_Gtk)]
    public static extern nint g_memory_input_stream_new_from_data(byte[] data, uint len, nint destroy);

    [DllImport(_Gtk)]
    public static extern void g_free(nint o);


    [DllImport(_Gtk)]
    public static extern void gtk_main_iteration();


    [DllImport(_Gtk)]
    public static extern void gtk_window_set_modal(nint window, bool modal);

    [DllImport(_Gtk)]
    public static extern void gtk_window_present(nint gtkWindow);


    public delegate bool signal_generic(nint gtkWidget, nint userData);

    public delegate bool signal_dialog_response(nint gtkWidget, GtkResponseType response, nint userData);

    [DllImport(_Gtk)]
    public static extern nint gtk_file_chooser_dialog_new(string title, nint parent,
        GtkFileChooserAction action, nint ignore);

    [DllImport(_Gtk)]
    public static extern void gtk_file_chooser_set_select_multiple(nint chooser, bool allow);

    [DllImport(_Gtk)]
    public static extern void gtk_file_chooser_set_do_overwrite_confirmation(nint chooser, bool do_overwrite_confirmation);

    [DllImport(_Gtk)]
    public static extern void gtk_dialog_add_button(nint raw, string button_text, GtkResponseType response_id);

    [DllImport(_Gtk)]
    public static extern GSList* gtk_file_chooser_get_filenames(nint chooser);

    [DllImport(_Gtk)]
    public static extern void gtk_file_chooser_set_filename(nint chooser, string file);

    [DllImport(_Gtk)]
    public static extern void gtk_file_chooser_set_current_name(nint chooser, string file);

    [DllImport(_Gtk)]
    public static extern nint gtk_file_filter_new();

    [DllImport(_Gtk)]
    public static extern nint gtk_file_filter_set_name(nint filter, string name);

    [DllImport(_Gtk)]
    public static extern nint gtk_file_filter_add_pattern(nint filter, string pattern);

    [DllImport(_Gtk)]
    public static extern nint gtk_file_chooser_add_filter(nint chooser, nint filter);

    [DllImport(_Gtk)]
    public static extern nint gtk_file_chooser_get_filter(nint chooser);

    [DllImport(_Gtk)]
    public static extern void gtk_widget_realize(nint gtkWidget);

    [DllImport(_Gtk)]
    public static extern void gtk_widget_destroy(nint gtkWidget);

    [DllImport(_Gtk)]
    public static extern nint gtk_widget_get_window(nint gtkWidget);

    [DllImport(_Gtk)]
    public static extern void gtk_widget_hide(nint gtkWidget);

    [DllImport(_Gtk)]
    public static extern bool gtk_init_check(int argc, nint argv);

    [DllImport(_Gtk)]
    public static extern nint gtk_container_add(nint container, nint widget);

    [DllImport(_Gtk)]
    public static extern nint gtk_application_new(string appId, int flags);
}
