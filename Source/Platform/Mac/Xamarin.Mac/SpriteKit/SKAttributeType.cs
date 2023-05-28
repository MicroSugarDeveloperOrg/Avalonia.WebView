using ObjCRuntime;

namespace SpriteKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Native]
public enum SKAttributeType : long
{
	None,
	Float,
	VectorFloat2,
	VectorFloat3,
	VectorFloat4,
	HalfFloat,
	VectorHalfFloat2,
	VectorHalfFloat3,
	VectorHalfFloat4
}
