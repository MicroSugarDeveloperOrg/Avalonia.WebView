using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Native]
public enum MTLPrimitiveTopologyClass : ulong
{
	Unspecified,
	Point,
	Line,
	Triangle
}
