using System;
using ObjCRuntime;

namespace CoreAnimation;

[NoWatch]
[iOS(11, 0)]
[TV(11, 0)]
[Mac(10, 13)]
[Native]
[Flags]
public enum CACornerMask : ulong
{
	MinXMinYCorner = 1uL,
	MaxXMinYCorner = 2uL,
	MinXMaxYCorner = 4uL,
	MaxXMaxYCorner = 8uL
}
