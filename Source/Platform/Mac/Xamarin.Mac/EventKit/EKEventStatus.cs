using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKEventStatus : long
{
	None,
	Confirmed,
	Tentative,
	Cancelled
}
