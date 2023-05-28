using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public enum AVAuthorizationMediaType
{
	Video,
	Audio
}
