using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
[Native]
public enum MPSNNPaddingMethod : ulong
{
	AlignCentered = 0uL,
	AlignTopLeft = 1uL,
	AlignBottomRight = 2uL,
	AlignReserved = 3uL,
	AddRemainderToTopLeft = 0uL,
	AddRemainderToTopRight = 4uL,
	AddRemainderToBottomLeft = 8uL,
	AddRemainderToBottomRight = 12uL,
	SizeValidOnly = 0uL,
	SizeSame = 16uL,
	SizeFull = 32uL,
	SizeReserved = 48uL,
	CustomWhitelistForNodeFusion = 8192uL,
	Custom = 16384uL,
	SizeMask = 2032uL,
	ExcludeEdges = 32768uL
}
