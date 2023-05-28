using ObjCRuntime;

namespace Metal;

[NoiOS]
[NoTV]
[NoWatch]
[Mac(10, 14)]
public struct MTLIndirectCommandBufferExecutionRange
{
	public uint Location;

	public uint Length;

	public MTLIndirectCommandBufferExecutionRange(uint location, uint length)
	{
		Location = location;
		Length = length;
	}
}
