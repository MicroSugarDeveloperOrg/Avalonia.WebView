using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Native]
public enum VNDetectTextRectanglesRequestRevision : ulong
{
	Unspecified,
	One
}
