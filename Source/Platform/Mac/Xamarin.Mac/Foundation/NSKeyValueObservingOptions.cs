using System;

namespace Foundation;

[Flags]
public enum NSKeyValueObservingOptions : ulong
{
	New = 1uL,
	Old = 2uL,
	OldNew = 3uL,
	Initial = 4uL,
	Prior = 8uL
}
