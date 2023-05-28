using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Native]
public enum SCNPhysicsCollisionCategory : ulong
{
	None = 0uL,
	Default = 1uL,
	Static = 2uL,
	All = ulong.MaxValue
}
