using System;

namespace AppKit;

[Flags]
public enum NSGradientDrawingOptions : ulong
{
	None = 0uL,
	BeforeStartingLocation = 1uL,
	AfterEndingLocation = 2uL
}
