using ObjCRuntime;

namespace CoreMotion;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum CMAuthorizationStatus : long
{
	NotDetermined,
	Restricted,
	Denied,
	Authorized
}
