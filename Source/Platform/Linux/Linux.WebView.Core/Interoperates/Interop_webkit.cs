namespace Linux.WebView.Core.Interoperates;

public enum WebKitUserContentInjectedFrames
{
    WEBKIT_USER_CONTENT_INJECT_ALL_FRAMES = 0,
    WEBKIT_USER_CONTENT_INJECT_TOP_FRAME = 1
}

public enum WebKitUserScriptInjectionTime
{
    WEBKIT_USER_SCRIPT_INJECT_AT_DOCUMENT_START = 0,
    WEBKIT_USER_SCRIPT_INJECT_AT_DOCUMENT_END = 1
}

internal static class Interop_webkit
{
    const string _WebKit = "webkit";

    [DllImport(_WebKit)]
    public static extern nint webkit_user_script_new(string source, WebKitUserContentInjectedFrames injected_frames, WebKitUserScriptInjectionTime injection_time, string? allow_list, string? block_list);

    [DllImport(_WebKit)]
    public static extern void webkit_user_content_manager_add_script(nint manager, nint script);

    [DllImport(_WebKit)]
    public static extern void webkit_user_script_unref(nint script);

    [DllImport(_WebKit)]
    public static extern bool webkit_user_content_manager_register_script_message_handler(nint manager, string name);

    [DllImport(_WebKit)]
    public static extern void webkit_javascript_result_unref(nint js_result);

    [DllImport(_WebKit)]
    public static extern nint webkit_javascript_result_get_js_value(nint js_result);

    [DllImport(_WebKit)]
    public static extern bool jsc_value_is_string(nint value);

    [DllImport(_WebKit)]
    public static extern nint jsc_value_to_string(nint value);
}
