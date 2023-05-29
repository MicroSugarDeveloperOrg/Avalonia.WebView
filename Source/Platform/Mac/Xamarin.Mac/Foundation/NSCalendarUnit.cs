using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
public enum NSCalendarUnit : ulong
{
	Era = 2uL,
	Year = 4uL,
	Month = 8uL,
	Day = 0x10uL,
	Hour = 0x20uL,
	Minute = 0x40uL,
	Second = 0x80uL,
	Week = 0x100uL,
	Weekday = 0x200uL,
	WeekdayOrdinal = 0x400uL,
	Quarter = 0x800uL,
	[Since(5, 0)]
	WeekOfMonth = 0x1000uL,
	[Since(5, 0)]
	WeekOfYear = 0x2000uL,
	[Since(5, 0)]
	YearForWeakOfYear = 0x4000uL,
	[Since(4, 0)]
	Calendar = 0x100000uL,
	[Since(4, 0)]
	TimeZone = 0x200000uL
}
