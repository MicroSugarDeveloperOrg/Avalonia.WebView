using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
[Native]
public enum SKProductPeriodUnit : ulong
{
	Day,
	Week,
	Month,
	Year
}
