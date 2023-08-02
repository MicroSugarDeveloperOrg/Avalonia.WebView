using System;

namespace CoreGraphics;

[Flags]
public enum CGWindowImageOption
{
	Default = 0,
	BoundsIgnoreFraming = 1,
	ShouldBeOpaque = 2,
	OnlyShadows = 4
}
