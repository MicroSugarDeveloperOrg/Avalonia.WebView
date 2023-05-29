using System;

namespace AppKit;

[Flags]
public enum NSTableViewGridStyle : ulong
{
	None = 0uL,
	SolidVerticalLine = 1uL,
	SolidHorizontalLine = 2uL,
	DashedHorizontalGridLine = 8uL
}
