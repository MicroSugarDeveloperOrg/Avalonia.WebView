using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Metal;

[iOS(10, 0)]
[TV(10, 0)]
[NoWatch]
[Mac(10, 12)]
public struct MTLQuadTessellationFactorsHalf
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public ushort[] EdgeTessellationFactor;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public ushort[] InsideTessellationFactor;

	public MTLQuadTessellationFactorsHalf(ushort[] edgeTessellationFactor, ushort[] insideTessellationFactor)
	{
		EdgeTessellationFactor = edgeTessellationFactor;
		InsideTessellationFactor = insideTessellationFactor;
	}
}
