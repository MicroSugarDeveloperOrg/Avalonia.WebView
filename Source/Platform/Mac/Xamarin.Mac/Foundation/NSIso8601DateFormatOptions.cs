using System;
using ObjCRuntime;

namespace Foundation;

[iOS(10, 0)]
[TV(10, 0)]
[Watch(3, 0)]
[Mac(10, 12)]
[Native]
[Flags]
public enum NSIso8601DateFormatOptions : ulong
{
	Year = 1uL,
	Month = 2uL,
	WeekOfYear = 4uL,
	Day = 0x10uL,
	Time = 0x20uL,
	TimeZone = 0x40uL,
	SpaceBetweenDateAndTime = 0x80uL,
	DashSeparatorInDate = 0x100uL,
	ColonSeparatorInTime = 0x200uL,
	ColonSeparatorInTimeZone = 0x400uL,
	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	FractionalSeconds = 0x800uL,
	FullDate = 0x113uL,
	FullTime = 0x660uL,
	InternetDateTime = 0x773uL
}
