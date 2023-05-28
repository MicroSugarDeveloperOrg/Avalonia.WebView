using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum MLModelError : long
{
	Generic = 0L,
	FeatureType = 1L,
	IO = 3L,
	[Introduced(PlatformName.WatchOS, 4, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	CustomLayer = 4L,
	CustomModel = 5L,
	Update = 6L,
	Parameters = 7L
}
