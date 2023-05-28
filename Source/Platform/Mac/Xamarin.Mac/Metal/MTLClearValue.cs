using System.Runtime.InteropServices;

namespace Metal;

[StructLayout(LayoutKind.Explicit)]
public struct MTLClearValue
{
	[FieldOffset(0)]
	public MTLClearColor Color;

	[FieldOffset(0)]
	public double Depth;

	[FieldOffset(0)]
	public ulong Stencil;

	public MTLClearValue(MTLClearColor color)
	{
		Depth = 0.0;
		Stencil = 0uL;
		Color = color;
	}

	public MTLClearValue(double depth)
	{
		Color.Red = 0.0;
		Stencil = 0uL;
		Depth = depth;
		Color.Green = 0.0;
		Color.Blue = 0.0;
		Color.Alpha = 0.0;
	}

	public MTLClearValue(ulong stencil)
	{
		Color.Red = 0.0;
		Depth = 0.0;
		Stencil = stencil;
		Color.Green = 0.0;
		Color.Blue = 0.0;
		Color.Alpha = 0.0;
	}
}
