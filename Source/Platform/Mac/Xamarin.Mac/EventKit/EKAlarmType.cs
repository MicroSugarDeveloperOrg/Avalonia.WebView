using ObjCRuntime;

namespace EventKit;

[Native]
public enum EKAlarmType : long
{
	Display,
	Audio,
	Procedure,
	Email
}
