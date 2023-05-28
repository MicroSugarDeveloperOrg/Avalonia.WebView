using System;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MTLTextureUsage : ulong
{
	Unknown = 0uL,
	ShaderRead = 1uL,
	ShaderWrite = 2uL,
	RenderTarget = 4uL,
	Blit = 8uL,
	PixelFormatView = 0x10uL
}
