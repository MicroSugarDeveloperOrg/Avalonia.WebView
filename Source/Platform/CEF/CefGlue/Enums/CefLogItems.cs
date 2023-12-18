//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_color_type_t.
//
namespace CefGlue
{
    using System;

    /// <summary>
    /// Log items prepended to each log line.
    /// </summary>
    [Flags]
    public enum CefLogItems
    {
        /// <summary>
        /// Prepend the default list of items.
        /// </summary>
        Default = 0,

        /// <summary>Prepend no items.</summary>
        None = 1,

        /// <summary>Prepend the process ID.</summary>
        ProcessId = 1 << 1,

        /// <summary>Prepend the thread ID.</summary>
        ThreadId = 1 << 2,

        /// <summary>Prepend the timestamp.</summary>
        TimeStamp = 1 << 3,

        /// <summary>Prepend the tickcount.</summary>
        TickCount = 1 << 4,
    }
}
