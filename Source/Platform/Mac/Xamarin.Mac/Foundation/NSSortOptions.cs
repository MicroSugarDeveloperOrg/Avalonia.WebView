using System;

namespace Foundation;

[Flags]
public enum NSSortOptions : ulong
{
	Concurrent = 1uL,
	Stable = 0x10uL
}
