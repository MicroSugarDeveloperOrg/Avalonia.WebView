using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
public struct MPSMatrixCopyOffsets
{
	public uint SourceRowOffset;

	public uint SourceColumnOffset;

	public uint DestinationRowOffset;

	public uint DestinationColumnOffset;
}
