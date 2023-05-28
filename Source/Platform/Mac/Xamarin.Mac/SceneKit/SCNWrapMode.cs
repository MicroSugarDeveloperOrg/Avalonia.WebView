using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
public enum SCNWrapMode : long
{
	Clamp = 1L,
	Repeat,
	ClampToBorder,
	Mirror
}
