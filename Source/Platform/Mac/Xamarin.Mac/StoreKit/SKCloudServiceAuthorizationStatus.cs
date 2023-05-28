using ObjCRuntime;

namespace StoreKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
[Native]
public enum SKCloudServiceAuthorizationStatus : long
{
	NotDetermined,
	Denied,
	Restricted,
	Authorized
}
