using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSCalendarUnit : ulong
{
	Era = 2uL,
	Year = 4uL,
	Month = 8uL,
	Day = 0x10uL,
	Hour = 0x20uL,
	Minute = 0x40uL,
	Second = 0x80uL,
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
	Week = 0x100uL,
	Weekday = 0x200uL,
	WeekdayOrdinal = 0x400uL,
	Quarter = 0x800uL,
	WeekOfMonth = 0x1000uL,
	WeekOfYear = 0x2000uL,
	YearForWeakOfYear = 0x4000uL,
	Nanosecond = 0x8000uL,
	Calendar = 0x100000uL,
	TimeZone = 0x200000uL
}
