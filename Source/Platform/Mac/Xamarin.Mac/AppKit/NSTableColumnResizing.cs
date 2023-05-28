using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSTableColumnResizing : long
{
	None = -1L,
	Autoresizing = 1L,
	UserResizingMask = 2L
}
