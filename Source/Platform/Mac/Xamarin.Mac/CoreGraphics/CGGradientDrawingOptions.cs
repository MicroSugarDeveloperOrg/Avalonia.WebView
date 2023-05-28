using System;

namespace CoreGraphics;

[Flags]
public enum CGGradientDrawingOptions : uint
{
	None = 0u,
	DrawsBeforeStartLocation = 1u,
	DrawsAfterEndLocation = 2u
}
