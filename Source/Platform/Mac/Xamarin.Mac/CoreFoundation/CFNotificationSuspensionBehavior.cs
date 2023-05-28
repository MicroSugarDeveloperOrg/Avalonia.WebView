using ObjCRuntime;

namespace CoreFoundation;

[Native]
public enum CFNotificationSuspensionBehavior : long
{
	Drop = 1L,
	Coalesce,
	Hold,
	DeliverImmediately
}
