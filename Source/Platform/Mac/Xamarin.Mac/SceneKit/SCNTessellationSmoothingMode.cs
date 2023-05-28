using ObjCRuntime;

namespace SceneKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Native]
public enum SCNTessellationSmoothingMode : long
{
	None,
	PNTriangles,
	Phong
}
