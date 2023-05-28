using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSDatePickerElementFlags : ulong
{
	HourMinute = 0xCuL,
	HourMinuteSecond = 0xEuL,
	TimeZone = 0x10uL,
	YearMonthDate = 0xC0uL,
	YearMonthDateDay = 0xE0uL,
	Era = 0x100uL
}
