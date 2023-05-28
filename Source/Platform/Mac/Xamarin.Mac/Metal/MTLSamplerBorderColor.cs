using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum MTLSamplerBorderColor : ulong
{
	TransparentBlack,
	OpaqueBlack,
	OpaqueWhite
}
