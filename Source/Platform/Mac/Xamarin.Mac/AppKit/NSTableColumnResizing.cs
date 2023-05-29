using System;

namespace AppKit;

[Flags]
public enum NSTableColumnResizing : ulong
{
	None = 0uL,
	Autoresizing = 1uL,
	UserResizingMask = 2uL
}
