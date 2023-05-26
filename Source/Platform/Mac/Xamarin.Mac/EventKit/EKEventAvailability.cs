using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKEventAvailability : long
{
	NotSupported = -1L,
	Busy,
	Free,
	Tentative,
	Unavailable
}
