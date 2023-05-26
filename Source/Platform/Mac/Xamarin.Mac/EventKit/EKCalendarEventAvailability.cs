using System;
using ObjCRuntime;

namespace EventKit;

[Flags]
[Native]
public enum EKCalendarEventAvailability : ulong
{
	None = 0uL,
	Busy = 1uL,
	Free = 2uL,
	Tentative = 4uL,
	Unavailable = 8uL
}
