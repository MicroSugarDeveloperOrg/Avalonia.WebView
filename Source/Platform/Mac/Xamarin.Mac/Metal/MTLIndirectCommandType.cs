using System;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MTLIndirectCommandType : ulong
{
	Draw = 1uL,
	DrawIndexed = 2uL,
	DrawPatches = 4uL,
	DrawIndexedPatches = 8uL
}
