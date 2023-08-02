using System;

namespace Foundation;

[Flags]
public enum NSEnumerationOptions : ulong
{
	SortConcurrent = 1uL,
	Reverse = 2uL
}
