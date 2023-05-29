using System;

namespace Foundation;

[Flags]
public enum NSJsonReadingOptions : ulong
{
	MutableContainers = 1uL,
	MutableLeaves = 2uL,
	AllowFragments = 4uL
}
