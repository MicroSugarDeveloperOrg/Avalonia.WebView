using System.Runtime.CompilerServices;
using static Linux.WebView.Core.LinuxApplicationManager;

namespace Linux.WebView.Core.Interoperates;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr gdk_set_allowed_backends_delegate(string backends);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint gdk_x11_window_get_xid_delegate(nint gdkWindowHandle);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void gtk_widget_realize_delegate(nint widgetHandle);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate ulong g_signal_connect_data_delegate(nint instance, string detailed_signal, nint c_handler, nint data, nint destroy_data, GConnectFlags connect_flags);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint g_memory_input_stream_new_from_data_delegate(byte[] data, uint length, nint destroy);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint webkit_user_script_new_delegate(string script, WebKitUserContentInjectedFrames injected_frames, WebKitUserScriptInjectionTime injection_time, string? allow_list, string? block_list);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void webkit_user_script_unref_delegate(nint scriptHandle);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void webkit_user_content_manager_add_script_delegate(nint userContentManagerInstance, nint script);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool webkit_user_content_manager_register_script_message_handler_delegate(nint userContentManagerInstance, string name);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint webkit_javascript_result_get_js_value_delegate(nint jsResult);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void webkit_javascript_result_unref_delegate(nint jsResult);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool jsc_value_is_string_delegate(nint value);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint jsc_value_to_string_delegate(nint value);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void webkit_policy_decision_ignore_delegate(nint decision);

public static class GtkApi
{
    static GtkApi()
    {
        __gdk_set_allowed_backends = LoadDelegate<gdk_set_allowed_backends_delegate>(gLibrary.Gdk, gdk_set_allowed_backends)!;
        __gdk_x11_window_get_xid = LoadDelegate<gdk_x11_window_get_xid_delegate>(gLibrary.Gdk, gdk_x11_window_get_xid)!;

        __gtk_widget_realize_delegate = LoadDelegate<gtk_widget_realize_delegate>(gLibrary.Gtk, gtk_widget_realize)!;
        __g_signal_connect_data = LoadDelegate<g_signal_connect_data_delegate>(gLibrary.Gtk, g_signal_connect_data)!;
        __g_memory_input_stream_new_from_data = LoadDelegate<g_memory_input_stream_new_from_data_delegate>(gLibrary.Gtk, g_memory_input_stream_new_from_data)!;

        __webkit_user_script_new = LoadDelegate<webkit_user_script_new_delegate>(gLibrary.Webkit, webkit_user_script_new)!;
        __webkit_user_script_unref = LoadDelegate<webkit_user_script_unref_delegate>(gLibrary.Webkit, webkit_user_script_unref)!;
        __webkit_user_content_manager_add_script = LoadDelegate<webkit_user_content_manager_add_script_delegate>(gLibrary.Webkit, webkit_user_content_manager_add_script)!;
        __webkit_user_content_manager_register_script_message_handler = LoadDelegate<webkit_user_content_manager_register_script_message_handler_delegate>(gLibrary.Webkit, webkit_user_content_manager_register_script_message_handler)!;
        __webkit_javascript_result_get_js_value = LoadDelegate<webkit_javascript_result_get_js_value_delegate>(gLibrary.Webkit, webkit_javascript_result_get_js_value)!;
        __webkit_javascript_result_unref = LoadDelegate<webkit_javascript_result_unref_delegate>(gLibrary.Webkit, webkit_javascript_result_unref)!;
        __jsc_value_is_string = LoadDelegate<jsc_value_is_string_delegate>(gLibrary.Webkit, jsc_value_is_string)!;
        __jsc_value_to_string = LoadDelegate<jsc_value_to_string_delegate>(gLibrary.Webkit, jsc_value_to_string)!;

        __webkit_policy_decision_ignore = LoadDelegate<webkit_policy_decision_ignore_delegate>(gLibrary.Webkit, webkit_policy_decision_ignore)!;

    }

    private static string gdk_set_allowed_backends => nameof(gdk_set_allowed_backends);
    private static string gtk_widget_realize => nameof(gtk_widget_realize);
    private static string gdk_x11_window_get_xid => nameof(gdk_x11_window_get_xid);

    private static string g_signal_connect_data => nameof(g_signal_connect_data);
    private static string g_memory_input_stream_new_from_data => nameof(g_memory_input_stream_new_from_data);

    private static string webkit_user_script_new => nameof(webkit_user_script_new);
    private static string webkit_user_script_unref => nameof(webkit_user_script_unref);
    private static string webkit_user_content_manager_add_script => nameof(webkit_user_content_manager_add_script);
    private static string webkit_user_content_manager_register_script_message_handler => nameof(webkit_user_content_manager_register_script_message_handler);
    private static string webkit_javascript_result_get_js_value => nameof(webkit_javascript_result_get_js_value);
    private static string webkit_javascript_result_unref => nameof(webkit_javascript_result_unref);
    private static string jsc_value_is_string => nameof(jsc_value_is_string);
    private static string jsc_value_to_string => nameof(jsc_value_to_string);
    private static string webkit_policy_decision_ignore => nameof(webkit_policy_decision_ignore);

    private static gdk_set_allowed_backends_delegate __gdk_set_allowed_backends;
    private static gdk_x11_window_get_xid_delegate __gdk_x11_window_get_xid;

    private static gtk_widget_realize_delegate __gtk_widget_realize_delegate;
    private static g_signal_connect_data_delegate __g_signal_connect_data;
    private static g_memory_input_stream_new_from_data_delegate __g_memory_input_stream_new_from_data;

    private static webkit_user_script_new_delegate __webkit_user_script_new;
    private static webkit_user_script_unref_delegate __webkit_user_script_unref;
    private static webkit_user_content_manager_add_script_delegate __webkit_user_content_manager_add_script;
    private static webkit_user_content_manager_register_script_message_handler_delegate __webkit_user_content_manager_register_script_message_handler;
    private static webkit_javascript_result_get_js_value_delegate __webkit_javascript_result_get_js_value;
    private static webkit_javascript_result_unref_delegate __webkit_javascript_result_unref;
    private static jsc_value_is_string_delegate __jsc_value_is_string;
    private static jsc_value_to_string_delegate __jsc_value_to_string;
    private static webkit_policy_decision_ignore_delegate __webkit_policy_decision_ignore;


    public static bool SetAllowedBackends(string backends)
    {
        if (string.IsNullOrWhiteSpace(backends))
            return false;

        try
        {
           var hWnd =  __gdk_set_allowed_backends.Invoke(backends);
           if (hWnd == IntPtr.Zero)
           {
               
           }
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public static nint GetWidgetXid(GWidget widget)
    {
        if (widget is null)
            return 0;

        return __gdk_x11_window_get_xid.Invoke(widget.Window.Handle);
    }

    public static void WidgetRealize(GWidget widget)
    {
        if (widget is null)
            return;

        __gtk_widget_realize_delegate.Invoke(widget.Handle);
    }

    public static ulong AddSignalConnect(nint instance, string detailed_signal, nint c_handler, nint data)
    {
        return __g_signal_connect_data.Invoke(instance, detailed_signal, c_handler, data, IntPtr.Zero, GConnectFlags.G_CONNECT_AFTER);
    }

    public static nint MarshalToGLibInputStream(byte[] data, uint length, nint destroy) => __g_memory_input_stream_new_from_data.Invoke(data, length, destroy);
    public static nint MarshalToGLibInputStream(byte[] data, long length) => MarshalToGLibInputStream(data, (uint)length, IntPtr.Zero);

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

    public static nint CreateUserScriptX(string script)
    {
        if (string.IsNullOrWhiteSpace(script))
            return default;

        return __webkit_user_script_new.Invoke(script,
                                               WebKitUserContentInjectedFrames.WEBKIT_USER_CONTENT_INJECT_ALL_FRAMES,
                                               WebKitUserScriptInjectionTime.WEBKIT_USER_SCRIPT_INJECT_AT_DOCUMENT_START,
                                               null, null);
    }

    public static void ReleaseScript(nint scriptHandle) => __webkit_user_script_unref.Invoke(scriptHandle);

    public static void AddScriptForUserContentManager(nint userContentManager, nint script) => __webkit_user_content_manager_add_script.Invoke(userContentManager, script);

    public static bool RegisterScriptMessageHandler(nint userContentManager, string name) => __webkit_user_content_manager_register_script_message_handler.Invoke(userContentManager, name);

    public static nint CreateJavaScriptResult(nint jsResult) => __webkit_javascript_result_get_js_value.Invoke(jsResult);

    public static void ReleaseJavaScriptResult(nint jsResult) => __webkit_javascript_result_unref.Invoke(jsResult);

    public static bool IsString(nint value) => __jsc_value_is_string.Invoke(value);
    public static bool IsStringEx(this nint value) => IsString(value);

    public static nint ToString(nint value) => __jsc_value_to_string.Invoke(value);
    public static string ToStringX(nint value)
    {
        var pString = ToString(value);
        var stringValue = Marshal.PtrToStringAuto(pString);
        Marshal.FreeHGlobal(pString);
        return stringValue;
    }
    public static string ToStringEx(this nint value) => ToStringX(value);

    public static void IgnorePolicyDecision(nint decision) => __webkit_policy_decision_ignore.Invoke(decision);
    public static void IgnorePolicyDecision(this PolicyDecision decision) => IgnorePolicyDecision(decision.Handle);
}