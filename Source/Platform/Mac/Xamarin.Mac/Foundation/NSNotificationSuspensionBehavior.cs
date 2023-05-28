using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSNotificationSuspensionBehavior : ulong
{
	Drop = 1uL,
	Coalesce,
	Hold,
	DeliverImmediately
}
