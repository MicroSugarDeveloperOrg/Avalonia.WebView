using System;

namespace AppKit;

[Flags]
public enum NSCellMask : ulong
{
	NoCell = 0uL,
	ContentsCell = 1uL,
	PushInCell = 2uL,
	ChangeGrayCell = 4uL,
	ChangeBackgroundCell = 8uL
}
