using System;

namespace AppKit;

[Flags]
public enum NSTableViewAnimation : ulong
{
	None = 0uL,
	Fade = 1uL,
	Gap = 2uL,
	SlideUp = 0x10uL,
	SlideDown = 0x20uL,
	SlideLeft = 0x30uL,
	SlideRight = 0x40uL
}
