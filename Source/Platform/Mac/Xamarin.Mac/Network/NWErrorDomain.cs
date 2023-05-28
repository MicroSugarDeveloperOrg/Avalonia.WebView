using ObjCRuntime;

namespace Network;

[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public enum NWErrorDomain
{
	Invalid,
	Posix,
	Dns,
	Tls
}
