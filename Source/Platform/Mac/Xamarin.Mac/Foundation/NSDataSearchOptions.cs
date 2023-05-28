using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSDataSearchOptions : ulong
{
	SearchBackwards = 1uL,
	SearchAnchored = 2uL
}
