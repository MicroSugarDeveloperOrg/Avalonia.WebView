using System;

namespace Foundation;

[Flags]
public enum NSAttributedStringEnumeration : ulong
{
	None = 0uL,
	Reverse = 2uL,
	LongestEffectiveRangeNotRequired = 0x100000uL
}
