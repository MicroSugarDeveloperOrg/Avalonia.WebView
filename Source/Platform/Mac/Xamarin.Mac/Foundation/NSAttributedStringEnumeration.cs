using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSAttributedStringEnumeration : ulong
{
	None = 0uL,
	Reverse = 2uL,
	LongestEffectiveRangeNotRequired = 0x100000uL
}
