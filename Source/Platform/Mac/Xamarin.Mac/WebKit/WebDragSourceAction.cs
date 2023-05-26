using System;

namespace WebKit;

[Flags]
public enum WebDragSourceAction : uint
{
	None = 0u,
	DHTML = 1u,
	Image = 2u,
	Link = 4u,
	Selection = 8u,
	Any = uint.MaxValue
}
