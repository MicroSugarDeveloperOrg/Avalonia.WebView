using System;

namespace CoreGraphics;

[Flags]
public enum CGEventMask : ulong
{
	Null = 1uL,
	LeftMouseDown = 2uL,
	LeftMouseUp = 4uL,
	RightMouseDown = 8uL,
	RightMouseUp = 0x10uL,
	MouseMoved = 0x20uL,
	LeftMouseDragged = 0x40uL,
	RightMouseDragged = 0x80uL,
	KeyDown = 0x400uL,
	KeyUp = 0x800uL,
	FlagsChanged = 0x1000uL,
	ScrollWheel = 0x400000uL,
	TabletPointer = 0x800000uL,
	TabletProximity = 0x1000000uL,
	OtherMouseDown = 0x2000000uL,
	OtherMouseUp = 0x4000000uL,
	OtherMouseDragged = 0x8000000uL
}
