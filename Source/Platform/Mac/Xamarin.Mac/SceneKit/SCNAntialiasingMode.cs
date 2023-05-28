using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Native]
public enum SCNAntialiasingMode : ulong
{
	None,
	Multisampling2X,
	Multisampling4X,
	Multisampling8X,
	Multisampling16X
}
