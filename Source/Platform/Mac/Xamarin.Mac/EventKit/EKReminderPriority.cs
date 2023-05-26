using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKReminderPriority : ulong
{
	None = 0uL,
	High = 1uL,
	Medium = 5uL,
	Low = 9uL
}
