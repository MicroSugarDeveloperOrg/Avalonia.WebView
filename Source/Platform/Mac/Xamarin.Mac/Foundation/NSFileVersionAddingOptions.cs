using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSFileVersionAddingOptions : ulong
{
	ByMoving = 1uL
}
