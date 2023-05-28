using System;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MKLocalSearchCompleterResultType : ulong
{
	Address = 1uL,
	PointOfInterest = 2uL,
	Query = 4uL
}
