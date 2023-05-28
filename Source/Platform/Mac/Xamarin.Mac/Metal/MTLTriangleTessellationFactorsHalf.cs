using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Metal;

[iOS(10, 0)]
[TV(10, 0)]
[NoWatch]
[Mac(10, 12)]
public struct MTLTriangleTessellationFactorsHalf
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public ushort[] EdgeTessellationFactor;

	public ushort InsideTessellationFactor;

	public MTLTriangleTessellationFactorsHalf(ushort[] edgeTessellationFactor, ushort insideTessellationFactor)
	{
		EdgeTessellationFactor = edgeTessellationFactor;
		InsideTessellationFactor = insideTessellationFactor;
	}
}
