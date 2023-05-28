using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum MKErrorCode : ulong
{
	Unknown = 1uL,
	ServerFailure,
	LoadingThrottled,
	PlacemarkNotFound,
	DirectionsNotFound
}
