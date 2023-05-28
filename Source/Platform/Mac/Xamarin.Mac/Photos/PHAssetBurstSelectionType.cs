using System;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum PHAssetBurstSelectionType : ulong
{
	None = 0uL,
	AutoPick = 1uL,
	UserPick = 2uL
}
