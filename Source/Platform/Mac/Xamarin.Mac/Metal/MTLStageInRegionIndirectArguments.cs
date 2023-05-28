using ObjCRuntime;

namespace Metal;

[Mac(10, 14)]
[iOS(12, 0)]
[TV(12, 0)]
public struct MTLStageInRegionIndirectArguments
{
	public uint StageInOrigin1;

	public uint StageInOrigin2;

	public uint StageInOrigin3;

	public uint StageInSize1;

	public uint StageInSize2;

	public uint StageInSize3;
}
