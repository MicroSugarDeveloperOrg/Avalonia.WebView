using ObjCRuntime;

namespace Metal;

[iOS(10, 0)]
[TV(10, 0)]
[NoWatch]
[Mac(10, 12)]
public struct MTLDrawPatchIndirectArguments
{
	public uint PatchCount;

	public uint InstanceCount;

	public uint PatchStart;

	public uint BaseInstance;

	public MTLDrawPatchIndirectArguments(uint pathCount, uint instanceCount, uint patchStart, uint baseInstance)
	{
		PatchCount = pathCount;
		InstanceCount = instanceCount;
		PatchStart = patchStart;
		BaseInstance = baseInstance;
	}
}
