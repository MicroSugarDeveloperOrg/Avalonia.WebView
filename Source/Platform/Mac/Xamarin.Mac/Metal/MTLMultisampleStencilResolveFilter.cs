using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Native]
public enum MTLMultisampleStencilResolveFilter : ulong
{
	Sample0,
	DepthResolvedSample
}
