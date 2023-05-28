using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSFileVersionReplacingOptions : ulong
{
	ByMoving = 1uL
}
