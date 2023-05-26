using System;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum NSDirectionalRectEdge : ulong
{
	None = 0uL,
	Top = 1uL,
	Leading = 2uL,
	Bottom = 4uL,
	Trailing = 8uL,
	All = 0xFuL
}
