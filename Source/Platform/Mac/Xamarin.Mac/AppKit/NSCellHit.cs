using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSCellHit : ulong
{
	None = 0uL,
	ContentArea = 1uL,
	EditableTextArea = 2uL,
	TrackableArae = 4uL
}
