using ObjCRuntime;

namespace NotificationCenter;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum NCUpdateResult : ulong
{
	NewData,
	NoData,
	Failed
}
