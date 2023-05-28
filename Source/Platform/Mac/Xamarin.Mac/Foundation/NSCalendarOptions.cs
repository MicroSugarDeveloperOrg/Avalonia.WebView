using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSCalendarOptions : ulong
{
	None = 0uL,
	WrapCalendarComponents = 1uL,
	[Mac(10, 9)]
	[iOS(7, 0)]
	MatchStrictly = 2uL,
	[Mac(10, 9)]
	[iOS(7, 0)]
	SearchBackwards = 4uL,
	[Mac(10, 9)]
	[iOS(7, 0)]
	MatchPreviousTimePreservingSmallerUnits = 0x100uL,
	[Mac(10, 9)]
	[iOS(7, 0)]
	MatchNextTimePreservingSmallerUnits = 0x200uL,
	[Mac(10, 9)]
	[iOS(7, 0)]
	MatchNextTime = 0x400uL,
	[Mac(10, 9)]
	[iOS(7, 0)]
	MatchFirst = 0x1000uL,
	[Mac(10, 9)]
	[iOS(7, 0)]
	MatchLast = 0x2000uL
}
