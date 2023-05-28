using ObjCRuntime;

namespace SpriteKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum SKTileDefinitionRotation : ulong
{
	Angle0,
	Angle90,
	Angle180,
	Angle270
}
