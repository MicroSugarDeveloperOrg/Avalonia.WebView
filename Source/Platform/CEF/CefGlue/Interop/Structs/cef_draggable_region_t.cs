//
// This file manually written from cef/include/internal/cef_types.h.
//
namespace CefGlue.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    internal unsafe struct cef_draggable_region_t
    {
        public cef_rect_t bounds;
        public int draggable;
    }
}
