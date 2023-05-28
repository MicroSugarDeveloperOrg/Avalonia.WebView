using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum MDLTransformOpRotationOrder : ulong
{
	Xyz = 1uL,
	Xzy,
	Yxz,
	Yzx,
	Zxy,
	Zyx
}
