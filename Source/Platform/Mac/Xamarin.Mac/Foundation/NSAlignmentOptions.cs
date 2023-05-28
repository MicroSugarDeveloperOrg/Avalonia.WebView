using System;

namespace Foundation;

[Flags]
public enum NSAlignmentOptions : long
{
	MinXInward = 1L,
	MinYInward = 2L,
	MaxXInward = 4L,
	MaxYInward = 8L,
	WidthInward = 0x10L,
	HeightInward = 0x20L,
	MinXOutward = 0x100L,
	MinYOutward = 0x200L,
	MaxXOutward = 0x400L,
	MaxYOutward = 0x800L,
	WidthOutward = 0x1000L,
	HeightOutward = 0x2000L,
	MinXNearest = 0x10000L,
	MinYNearest = 0x20000L,
	MaxXNearest = 0x40000L,
	MaxYNearest = 0x80000L,
	WidthNearest = 0x100000L,
	HeightNearest = 0x200000L,
	RectFlipped = long.MinValue,
	AllEdgesInward = 0xFL,
	AllEdgesOutward = 0xF00L,
	AllEdgesNearest = 0xF0000L
}
