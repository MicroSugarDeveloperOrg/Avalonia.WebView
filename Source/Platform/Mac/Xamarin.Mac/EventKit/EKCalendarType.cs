using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKCalendarType : long
{
	Local,
	CalDav,
	Exchange,
	Subscription,
	Birthday
}
