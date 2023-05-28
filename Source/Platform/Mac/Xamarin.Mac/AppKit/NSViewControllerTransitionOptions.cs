using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSViewControllerTransitionOptions : ulong
{
	None = 0uL,
	Crossfade = 1uL,
	SlideUp = 0x10uL,
	SlideDown = 0x20uL,
	SlideLeft = 0x40uL,
	SlideRight = 0x80uL,
	SlideForward = 0x140uL,
	SlideBackward = 0x180uL,
	AllowUserInteraction = 0x1000uL
}
