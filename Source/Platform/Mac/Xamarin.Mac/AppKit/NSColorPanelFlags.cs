using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSColorPanelFlags : ulong
{
	Gray = 1uL,
	RGB = 2uL,
	CMYK = 4uL,
	HSB = 8uL,
	CustomPalette = 0x10uL,
	ColorList = 0x20uL,
	Wheel = 0x40uL,
	Crayon = 0x80uL,
	All = 0xFFFFuL
}
