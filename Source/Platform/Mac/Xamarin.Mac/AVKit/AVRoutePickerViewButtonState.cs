using ObjCRuntime;

namespace AVKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum AVRoutePickerViewButtonState : long
{
	Normal,
	NormalHighlighted,
	Active,
	ActiveHighlighted
}
