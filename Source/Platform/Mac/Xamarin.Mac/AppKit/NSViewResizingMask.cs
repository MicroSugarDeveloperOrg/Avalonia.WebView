using System;

namespace AppKit;

[Flags]
public enum NSViewResizingMask : ulong
{
	NotSizable = 0uL,
	MinXMargin = 1uL,
	WidthSizable = 2uL,
	MaxXMargin = 4uL,
	MinYMargin = 8uL,
	HeightSizable = 0x10uL,
	MaxYMargin = 0x20uL
}
