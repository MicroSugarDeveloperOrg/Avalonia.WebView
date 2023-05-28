using System;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum PHAssetMediaSubtype : ulong
{
	None = 0uL,
	PhotoPanorama = 1uL,
	PhotoHDR = 2uL,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	Screenshot = 4uL,
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	PhotoLive = 8uL,
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	PhotoDepthEffect = 0x10uL,
	VideoStreamed = 0x10000uL,
	VideoHighFrameRate = 0x20000uL,
	VideoTimelapse = 0x40000uL
}
