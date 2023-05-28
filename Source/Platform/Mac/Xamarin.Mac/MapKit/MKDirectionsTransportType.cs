using ObjCRuntime;

namespace MapKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Native]
public enum MKDirectionsTransportType : ulong
{
	Automobile = 1uL,
	Walking = 2uL,
	Transit = 4uL,
	Any = 268435455uL
}
