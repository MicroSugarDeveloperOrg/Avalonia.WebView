using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum MDLDataPrecision : ulong
{
	Undefined,
	Float,
	Double
}
