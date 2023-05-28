using ObjCRuntime;

namespace MetalPerformanceShaders;

[iOS(9, 0)]
[Mac(10, 13)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Native]
public enum MPSImageEdgeMode : ulong
{
	Zero,
	Clamp,
	[iOS(12, 1)]
	[TV(12, 1)]
	[Mac(10, 14, 1)]
	Mirror,
	[iOS(12, 1)]
	[TV(12, 1)]
	[Mac(10, 14, 1)]
	MirrorWithEdge,
	[iOS(12, 1)]
	[TV(12, 1)]
	[Mac(10, 14, 1)]
	Constant
}
