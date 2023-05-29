using System;

namespace AppKit;

[Flags]
public enum NSFontTraitMask : ulong
{
	Italic = 1uL,
	Bold = 2uL,
	Unbold = 4uL,
	NonStandardCharacterSet = 8uL,
	Narrow = 0x10uL,
	Expanded = 0x20uL,
	Condensed = 0x40uL,
	SmallCaps = 0x80uL,
	Poster = 0x100uL,
	Compressed = 0x200uL,
	FixedPitch = 0x400uL,
	Unitalic = 0x1000000uL
}
