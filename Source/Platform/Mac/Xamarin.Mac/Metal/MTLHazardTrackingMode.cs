using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum MTLHazardTrackingMode : ulong
{
	Default,
	Untracked,
	Tracked
}
