using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLSamplerAddressMode : ulong
{
	ClampToEdge,
	MirrorClampToEdge,
	Repeat,
	MirrorRepeat,
	ClampToZero,
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	ClampToBorderColor
}
