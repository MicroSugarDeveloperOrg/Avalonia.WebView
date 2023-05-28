using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Native]
public enum MKDistanceFormatterUnitStyle : ulong
{
	Default,
	Abbreviated,
	Full
}
