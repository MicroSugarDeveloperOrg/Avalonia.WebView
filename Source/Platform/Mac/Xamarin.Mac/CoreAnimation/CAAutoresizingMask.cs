using System;

namespace CoreAnimation;

[Flags]
public enum CAAutoresizingMask
{
	NotSizable = 0,
	MinXMargin = 1,
	WidthSizable = 2,
	MaxXMargin = 4,
	MinYMargin = 8,
	HeightSizable = 0x10,
	MaxYMargin = 0x20
}
