using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum MTLTessellationFactorStepFunction : ulong
{
	Constant,
	PerPatch,
	PerInstance,
	PerPatchAndPerInstance
}
