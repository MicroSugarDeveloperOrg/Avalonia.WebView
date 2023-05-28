using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum AVAuthorizationStatus : long
{
	NotDetermined,
	Restricted,
	Denied,
	Authorized
}
