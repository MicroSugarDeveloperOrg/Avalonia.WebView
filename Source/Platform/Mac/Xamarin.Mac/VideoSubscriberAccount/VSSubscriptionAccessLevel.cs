using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Native]
public enum VSSubscriptionAccessLevel : long
{
	Unknown,
	FreeWithAccount,
	Paid
}
