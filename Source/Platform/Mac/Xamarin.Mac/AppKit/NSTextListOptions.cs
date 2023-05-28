using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSTextListOptions : ulong
{
	PrependEnclosingMarker = 1uL
}
