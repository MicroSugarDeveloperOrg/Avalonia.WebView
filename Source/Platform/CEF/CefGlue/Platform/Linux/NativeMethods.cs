using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CefGlue.Platform.Linux;
internal class NativeMethods
{
    public const int RTLD_LAZY = 0x0001;
    public const int RTLD_GLOBAL = 0x0100;

    private const string _libdlName = "libdl.so.2";

    [DllImport(_libdlName)]
    private static extern nint dlopen(string path, int flags);

    [DllImport(_libdlName)]
    private static extern nint dlsym(nint handle, string symbol);

    [DllImport(_libdlName)]
    public static extern int dlclose(nint handle);

}
