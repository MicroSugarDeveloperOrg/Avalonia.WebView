using System;

namespace AppKit;

[Flags]
public enum NSEventPhase : ulong
{
	None = 0uL,
	Began = 1uL,
	Stationary = 2uL,
	Changed = 4uL,
	Ended = 8uL,
	Cancelled = 0x10uL,
	MayBegin = 0x20uL
}
