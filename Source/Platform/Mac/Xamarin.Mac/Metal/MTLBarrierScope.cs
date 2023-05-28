using System;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MTLBarrierScope : ulong
{
	Buffers = 1uL,
	Textures = 2uL,
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	RenderTargets = 4uL
}
