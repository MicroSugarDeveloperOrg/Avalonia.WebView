using System;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MTLBlitOption : ulong
{
	None = 0uL,
	DepthFromDepthStencil = 1uL,
	StencilFromDepthStencil = 2uL
}
