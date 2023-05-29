using System;

namespace AppKit;

[Flags]
public enum NSColorPanelFlags
{
	Gray = 1,
	RGB = 2,
	CMYK = 4,
	HSB = 8,
	CustomPalette = 0x10,
	ColorList = 0x20,
	Wheel = 0x40,
	Crayon = 0x80,
	All = 0xFFFF
}
