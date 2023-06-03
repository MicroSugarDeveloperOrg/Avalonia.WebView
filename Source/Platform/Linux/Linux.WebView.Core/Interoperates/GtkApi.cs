namespace Linux.WebView.Core.Interoperates;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void gdk_set_allowed_backends_delegate(Utf8Buffer backends);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint gdk_x11_window_get_xid_delegate(nint widgetWindowHandle);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate ulong g_signal_connect_data_delegate(nint instance, string detailed_signal, nint c_handler, nint data, nint destroy_data, GConnectFlags connect_flags);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint webkit_user_script_new_delegate(string script, WebKitUserContentInjectedFrames injected_frames, WebKitUserScriptInjectionTime injection_time, string? allow_list, string? block_list);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void webkit_user_content_manager_add_script_delegate(nint userContentManagerInstance, nint script);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool webkit_user_content_manager_register_script_message_delegate(nint userContentManagerInstance, string name);

public class GtkApi
{
    static GtkApi()
    {
        __gdk_set_allowed_backends = LinuxApplicationManager.LoadDelegate<gdk_set_allowed_backends_delegate>(gLibrary.Gdk, gdk_set_allowed_backends)!;
        __gdk_x11_window_get_xid = LinuxApplicationManager.LoadDelegate<gdk_x11_window_get_xid_delegate>(gLibrary.Gdk, gdk_x11_window_get_xid)!;

        __g_signal_connect_data = LinuxApplicationManager.LoadDelegate<g_signal_connect_data_delegate>(gLibrary.Gtk, g_signal_connect_data)!;

        __webkit_user_script_new = LinuxApplicationManager.LoadDelegate<webkit_user_script_new_delegate>(gLibrary.Webkit, webkit_user_script_new)!;
        __webkit_user_content_manager_add_script = LinuxApplicationManager.LoadDelegate<webkit_user_content_manager_add_script_delegate>(gLibrary.Webkit, webkit_user_content_manager_add_script)!;
        __webkit_user_content_manager_register_script_message = LinuxApplicationManager.LoadDelegate<webkit_user_content_manager_register_script_message_delegate>(gLibrary.Webkit, webkit_user_content_manager_register_script_message)!;
    }

    private static string gdk_set_allowed_backends => nameof(gdk_set_allowed_backends);
    private static string gdk_x11_window_get_xid => nameof(gdk_x11_window_get_xid);

    private static string g_signal_connect_data => nameof(g_signal_connect_data);

    private static string webkit_user_script_new => nameof(webkit_user_script_new);
    private static string webkit_user_content_manager_add_script => nameof(webkit_user_content_manager_add_script);
    private static string webkit_user_content_manager_register_script_message => nameof(webkit_user_content_manager_register_script_message);

    private static gdk_set_allowed_backends_delegate __gdk_set_allowed_backends;
    private static gdk_x11_window_get_xid_delegate __gdk_x11_window_get_xid;

    private static g_signal_connect_data_delegate __g_signal_connect_data;

    private static webkit_user_script_new_delegate __webkit_user_script_new;
    private static webkit_user_content_manager_add_script_delegate __webkit_user_content_manager_add_script;
    private static webkit_user_content_manager_register_script_message_delegate __webkit_user_content_manager_register_script_message;

    public static bool SetAllowedBackends(string backends)
    {
        if (string.IsNullOrWhiteSpace(backends))
            return false;

        using var utf8Backends = new Utf8Buffer(backends);
        try
        {
            __gdk_set_allowed_backends.Invoke(utf8Backends);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public static UserScript? CreateUserScript(string script)
    {
        if (string.IsNullOrWhiteSpace(script))
            return default;

        var scriptHandle = __webkit_user_script_new.Invoke(script, 
                                                           WebKitUserContentInjectedFrames.WEBKIT_USER_CONTENT_INJECT_ALL_FRAMES,
                                                           WebKitUserScriptInjectionTime.WEBKIT_USER_SCRIPT_INJECT_AT_DOCUMENT_START,
                                                           null, null);

        return UserScript.New(scriptHandle);
    }

    public static nint CreateUserScriptx(string script)
    {
        if (string.IsNullOrWhiteSpace(script))
            return default;

        return __webkit_user_script_new.Invoke(script,
                                               WebKitUserContentInjectedFrames.WEBKIT_USER_CONTENT_INJECT_ALL_FRAMES,
                                               WebKitUserScriptInjectionTime.WEBKIT_USER_SCRIPT_INJECT_AT_DOCUMENT_START,
                                               null, null);
    }

    public static void AddScriptForUserContentManager(nint userContentManager, nint script) => __webkit_user_content_manager_add_script.Invoke(userContentManager, script);

    public static bool RegisterScriptMessageHandler(nint userContentManager, string name) => __webkit_user_content_manager_register_script_message.Invoke(userContentManager, name);

    public static nint GetWidgetXid(GWidget widget)
    {
        if (widget is null)
            return 0;

        return __gdk_x11_window_get_xid.Invoke(widget.Window.Handle);
    }

    public static ulong AddSignalConnect(nint instance, string detailed_signal, nint c_handler, nint data)
    {
       return __g_signal_connect_data.Invoke(instance, detailed_signal, c_handler, data, IntPtr.Zero, GConnectFlags.G_CONNECT_AFTER);
    }
}