using System;

namespace AppKit;

[Flags]
public enum NSEventMask : ulong
{
	LeftMouseDown = 2uL,
	LeftMouseUp = 4uL,
	RightMouseDown = 8uL,
	RightMouseUp = 0x10uL,
	MouseMoved = 0x20uL,
	LeftMouseDragged = 0x40uL,
	RightMouseDragged = 0x80uL,
	MouseEntered = 0x100uL,
	MouseExited = 0x200uL,
	KeyDown = 0x400uL,
	KeyUp = 0x800uL,
	FlagsChanged = 0x1000uL,
	AppKitDefined = 0x2000uL,
	SystemDefined = 0x4000uL,
	ApplicationDefined = 0x8000uL,
	Periodic = 0x10000uL,
	CursorUpdate = 0x20000uL,
	ScrollWheel = 0x400000uL,
	TabletPoint = 0x800000uL,
	TabletProximity = 0x1000000uL,
	OtherMouseDown = 0x2000000uL,
	OtherMouseUp = 0x4000000uL,
	OtherMouseDragged = 0x8000000uL,
	EventGesture = 0x20000000uL,
	EventMagnify = 0x40000000uL,
	EventSwipe = 0x80000000uL,
	EventRotate = 0x40000uL,
	EventBeginGesture = 0x80000uL,
	EventEndGesture = 0x100000uL,
	AnyEvent = 0xFFFFFFFFuL
}
