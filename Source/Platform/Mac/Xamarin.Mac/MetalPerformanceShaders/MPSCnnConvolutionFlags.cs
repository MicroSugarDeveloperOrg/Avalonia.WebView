using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MPSCnnConvolutionFlags : ulong
{
	None = 0uL
}
