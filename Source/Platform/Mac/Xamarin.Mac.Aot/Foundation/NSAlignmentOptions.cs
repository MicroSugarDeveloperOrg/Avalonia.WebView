using System;

namespace Foundation;

[Flags]
public enum NSAlignmentOptions : ulong
{
	MinXInward = 1uL,
	MinYInward = 2uL,
	MaxXInward = 4uL,
	MaxYInward = 8uL,
	WidthInward = 0x10uL,
	HeightInward = 0x20uL,
	MinXOutward = 0x100uL,
	MinYOutward = 0x200uL,
	MaxXOutward = 0x400uL,
	MaxYOutward = 0x800uL,
	WidthOutward = 0x1000uL,
	HeightOutward = 0x2000uL,
	MinXNearest = 0x10000uL,
	MinYNearest = 0x20000uL,
	MaxXNearest = 0x40000uL,
	MaxYNearest = 0x80000uL,
	WidthNearest = 0x100000uL,
	HeightNearest = 0x200000uL,
	RectFlipped = 18446744071562067968uL,
	AllEdgesInward = 0xFuL,
	AllEdgesOutward = 0xF00uL,
	AllEdgesNearest = 0xF0000uL
}
