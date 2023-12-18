//
// This file manually written from cef/include/internal/cef_types_content_settings.h.
// C API name: cef_content_setting_values_t.
//
namespace CefGlue
{
    using System;

    /// <summary>
    /// Supported content setting values. Should be kept in sync with Chromium's
    /// ContentSetting type.
    /// </summary>
    public enum CefContentSettingValues
    {
        Default = 0,
        Allow,
        Block,
        Ask,
        SessionOnly,
        DetectImportantContent,
    }
}
