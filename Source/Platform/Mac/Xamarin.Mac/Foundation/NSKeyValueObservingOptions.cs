using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSKeyValueObservingOptions : ulong
{
	New = 1uL,
	Old = 2uL,
	OldNew = 3uL,
	Initial = 4uL,
	Prior = 8uL
}
