using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSDataReadingOptions : ulong
{
	Mapped = 1uL,
	Uncached = 2uL,
	Coordinated = 4uL,
	MappedAlways = 8uL
}
