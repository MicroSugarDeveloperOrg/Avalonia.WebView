using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSTableViewGridStyle : ulong
{
	None = 0uL,
	SolidVerticalLine = 1uL,
	SolidHorizontalLine = 2uL,
	DashedHorizontalGridLine = 8uL
}
