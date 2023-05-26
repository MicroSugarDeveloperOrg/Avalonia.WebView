using ObjCRuntime;

namespace EventKit;

[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'EKWeekday'.")]
[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'EKWeekday'.")]
public enum EKDay
{
	NotSet,
	Sunday,
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday
}
