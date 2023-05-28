using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Native]
public enum PHAssetPlaybackStyle : long
{
	Unsupported,
	Image,
	ImageAnimated,
	LivePhoto,
	Video,
	VideoLooping
}
