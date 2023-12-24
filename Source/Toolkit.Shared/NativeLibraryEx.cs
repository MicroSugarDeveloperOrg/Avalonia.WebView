using System;
using System.Collections.Generic;
using System.Text;

namespace Toolkit.Shared;
public class NativeLibraryEx
{
    public static nint LoadLibrary(string libraryPath)
    {
        return 0;
    }

    public static void FreeLibrary(nint handle)
    {

    }

    public static nint GetProcessAddress(nint handler, string name)
    {
        return 0;
    }
}
