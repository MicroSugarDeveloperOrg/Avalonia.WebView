using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSCellStyleMask : ulong
{
	NoCell = 0uL,
	ContentsCell = 1uL,
	PushInCell = 2uL,
	ChangeGrayCell = 4uL,
	ChangeBackgroundCell = 8uL
}
