using System;

namespace CoreGraphics;

[Flags]
public enum CGEventFlags : ulong
{
	NonCoalesced = 0x100uL,
	AlphaShift = 0x10000uL,
	Shift = 0x20000uL,
	Control = 0x40000uL,
	Alternate = 0x80000uL,
	Command = 0x100000uL,
	NumericPad = 0x200000uL,
	Help = 0x400000uL,
	SecondaryFn = 0x800000uL
}
