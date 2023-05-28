using System;

namespace CoreGraphics;

[Flags]
public enum CGWindowImageOption : uint
{
	Default = 0u,
	BoundsIgnoreFraming = 1u,
	ShouldBeOpaque = 2u,
	OnlyShadows = 4u
}
