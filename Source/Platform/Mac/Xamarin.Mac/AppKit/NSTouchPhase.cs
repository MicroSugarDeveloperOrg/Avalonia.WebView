using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSTouchPhase : ulong
{
	Began = 1uL,
	Moved = 2uL,
	Stationary = 4uL,
	Ended = 8uL,
	Cancelled = 0x10uL,
	Touching = 7uL,
	Any = ulong.MaxValue
}
