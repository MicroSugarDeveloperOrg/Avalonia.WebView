using ObjCRuntime;

namespace NetworkExtension;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 5, PlatformArchitecture.All, null)]
[Native]
public enum NEFilterDataAttribute : long
{
	HasIpHeader = 1L
}
