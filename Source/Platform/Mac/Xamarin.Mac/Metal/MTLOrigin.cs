using System;

namespace Metal;

public struct MTLOrigin
{
	public nint X;

	public nint Y;

	public nint Z;

	public MTLOrigin(nint x, nint y, nint z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public override string ToString()
	{
		return $"({X},{Y},{Z})";
	}
}
