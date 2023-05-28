using System;

namespace CoreAnimation;

[Flags]
public enum CAAutoresizingMask : uint
{
	NotSizable = 0u,
	MinXMargin = 1u,
	WidthSizable = 2u,
	MaxXMargin = 4u,
	MinYMargin = 8u,
	HeightSizable = 0x10u,
	MaxYMargin = 0x20u
}
