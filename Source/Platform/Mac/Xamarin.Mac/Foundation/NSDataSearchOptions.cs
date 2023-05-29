using System;

namespace Foundation;

[Flags]
public enum NSDataSearchOptions : ulong
{
	SearchBackwards = 1uL,
	SearchAnchored = 2uL
}
