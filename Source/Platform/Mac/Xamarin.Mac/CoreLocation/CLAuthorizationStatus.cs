using ObjCRuntime;

namespace CoreLocation;

public enum CLAuthorizationStatus : uint
{
	NotDetermined = 0u,
	Restricted = 1u,
	Denied = 2u,
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'AuthorizedAlways' instead.")]
	Authorized = 3u,
	AuthorizedAlways = 3u,
	AuthorizedWhenInUse = 4u
}
