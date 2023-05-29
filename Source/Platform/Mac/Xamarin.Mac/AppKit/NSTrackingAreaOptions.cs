using System;

namespace AppKit;

[Flags]
public enum NSTrackingAreaOptions : ulong
{
	MouseEnteredAndExited = 1uL,
	MouseMoved = 2uL,
	CursorUpdate = 4uL,
	ActiveWhenFirstResponder = 0x10uL,
	ActiveInKeyWindow = 0x20uL,
	ActiveInActiveApp = 0x40uL,
	ActiveAlways = 0x80uL,
	AssumeInside = 0x100uL,
	InVisibleRect = 0x200uL,
	EnabledDuringMouseDrag = 0x400uL
}
