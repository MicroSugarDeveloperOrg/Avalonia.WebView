using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum MKUserTrackingMode : ulong
{
	None,
	Follow,
	FollowWithHeading
}
