using ObjCRuntime;

namespace CoreVideo;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public enum CVImageBufferColorPrimaries
{
	Unknown = 2,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	DciP3,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	ItuR2020,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	P3D65,
	ItuR709_2,
	Ebu3213,
	SmpteC,
	P22
}
