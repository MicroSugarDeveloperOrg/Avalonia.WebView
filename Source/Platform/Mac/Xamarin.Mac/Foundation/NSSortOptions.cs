using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSSortOptions : ulong
{
	Concurrent = 1uL,
	Stable = 0x10uL
}
