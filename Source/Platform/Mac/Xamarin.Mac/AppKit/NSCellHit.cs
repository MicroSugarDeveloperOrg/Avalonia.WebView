using System;

namespace AppKit;

[Flags]
public enum NSCellHit : ulong
{
	None = 0uL,
	ContentArea = 1uL,
	EditableTextArea = 2uL,
	TrackableArae = 4uL
}
