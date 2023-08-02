using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
public enum NSDataReadingOptions : ulong
{
	Mapped = 1uL,
	Uncached = 2uL,
	[Since(5, 0)]
	Coordinated = 4uL,
	[Since(5, 0)]
	MappedAlways = 8uL
}
