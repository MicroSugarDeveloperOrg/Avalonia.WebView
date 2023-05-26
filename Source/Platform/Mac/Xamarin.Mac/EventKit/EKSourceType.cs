using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKSourceType : long
{
	Local,
	Exchange,
	CalDav,
	MobileMe,
	Subscribed,
	Birthdays
}
