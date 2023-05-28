using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
public enum SCNSceneSourceStatus : long
{
	Error = -1L,
	Parsing = 4L,
	Validating = 8L,
	Processing = 12L,
	Complete = 16L
}
