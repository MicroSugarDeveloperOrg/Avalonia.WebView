using System;
using System.Collections.Generic;
using System.Text;

namespace ObjCRuntime;
public enum PlatformName : byte
{
    None = 0,
    MacOSX = 1,
    iOS = 2,
    WatchOS = 3,
    TvOS = 4,
    MacCatalyst = 5,
    UIKitForMac = 5
}
