using System;
using ObjCRuntime;

namespace AppKit;

[Mac(10, 12, 2)]
[Native]
[Flags]
public enum NSTouchTypeMask : ulong
{
	Direct = 1uL,
	Indirect = 2uL
}
