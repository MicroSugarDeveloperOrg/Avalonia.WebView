using ObjCRuntime;

namespace Metal;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum MTLDeviceLocation : ulong
{
	BuiltIn = 0uL,
	Slot = 1uL,
	External = 2uL,
	Unspecified = ulong.MaxValue
}
