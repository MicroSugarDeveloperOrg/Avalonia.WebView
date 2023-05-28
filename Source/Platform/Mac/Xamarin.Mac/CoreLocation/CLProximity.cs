using ObjCRuntime;

namespace CoreLocation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Native]
public enum CLProximity : long
{
	Unknown,
	Immediate,
	Near,
	Far
}
