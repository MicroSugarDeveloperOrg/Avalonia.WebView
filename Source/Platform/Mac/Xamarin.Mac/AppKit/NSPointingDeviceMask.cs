using System;

namespace AppKit;

[Flags]
public enum NSPointingDeviceMask
{
	Pen = 1,
	PenLower = 2,
	PenUpper = 4
}
