using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CefGlue.Platform.Mac;
internal class NativeMethods
{
    public const int RTLD_LAZY = 0x0001;
    public const int RTLD_GLOBAL = 0x0100;

    const string _libSystem = "/usr/lib/libSystem.dylib";


    [DllImport(_libSystem)]
    public static extern IntPtr dlopen(string path, int flag);

    [DllImport(_libSystem)]
    public static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport(_libSystem)]
    public static extern IntPtr dlerror();

    [DllImport(_libSystem)]
    public static extern int dlclose(IntPtr handle);

}
