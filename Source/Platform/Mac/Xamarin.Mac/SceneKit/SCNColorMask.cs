using System;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum SCNColorMask : long
{
	None = 0L,
	Red = 8L,
	Green = 4L,
	Blue = 2L,
	Alpha = 1L,
	All = 0xFL
}
