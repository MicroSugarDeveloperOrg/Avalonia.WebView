using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSGradientDrawingOptions : ulong
{
	None = 0uL,
	BeforeStartingLocation = 1uL,
	AfterEndingLocation = 2uL
}
