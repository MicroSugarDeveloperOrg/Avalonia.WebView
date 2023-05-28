using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
[Native]
public enum SKProductDiscountType : long
{
	Introductory,
	Subscription
}
