using ObjCRuntime;

namespace PhotosUI;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public enum PHProjectCategory
{
	Book,
	Calendar,
	Card,
	Prints,
	Slideshow,
	WallDecor,
	Other,
	[Introduced(PlatformName.MacOSX, 10, 14, 2, PlatformArchitecture.All, null)]
	Undefined
}
