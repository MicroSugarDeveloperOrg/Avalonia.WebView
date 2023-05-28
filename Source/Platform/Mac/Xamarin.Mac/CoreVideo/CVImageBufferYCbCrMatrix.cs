using ObjCRuntime;

namespace CoreVideo;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public enum CVImageBufferYCbCrMatrix
{
	Unknown = 2,
	ItuR709_2,
	ItuR601_4,
	Smpte240M1995,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	DciP3,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	P3D65,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	ItuR2020
}
