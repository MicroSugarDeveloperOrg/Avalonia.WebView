using System;

namespace WebKit;

[Flags]
public enum WebDragSourceAction : ulong
{
	None = 0uL,
	DHTML = 1uL,
	Image = 2uL,
	Link = 4uL,
	Selection = 8uL,
	Any = ulong.MaxValue
}
