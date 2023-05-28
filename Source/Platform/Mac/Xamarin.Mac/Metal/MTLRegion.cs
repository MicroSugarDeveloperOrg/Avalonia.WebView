using System;

namespace Metal;

public struct MTLRegion
{
	public MTLOrigin Origin;

	public MTLSize Size;

	public MTLRegion(MTLOrigin origin, MTLSize size)
	{
		Origin = origin;
		Size = size;
	}

	public static MTLRegion Create1D(nuint x, nuint width)
	{
		return Create1D((nint)x, (nint)width);
	}

	public static MTLRegion Create1D(nint x, nint width)
	{
		MTLRegion result = default(MTLRegion);
		result.Origin.X = x;
		result.Origin.Y = 0;
		result.Origin.Z = 0;
		result.Size.Width = width;
		result.Size.Height = 1;
		result.Size.Depth = 1;
		return result;
	}

	public static MTLRegion Create2D(nuint x, nuint y, nuint width, nuint height)
	{
		return Create2D((nint)x, (nint)y, (nint)width, (nint)height);
	}

	public static MTLRegion Create2D(nint x, nint y, nint width, nint height)
	{
		MTLRegion result = default(MTLRegion);
		result.Origin.X = x;
		result.Origin.Y = y;
		result.Origin.Z = 0;
		result.Size.Width = width;
		result.Size.Height = height;
		result.Size.Depth = 1;
		return result;
	}

	public static MTLRegion Create3D(nuint x, nuint y, nuint z, nuint width, nuint height, nuint depth)
	{
		return Create3D((nint)x, (nint)y, (nint)z, (nint)width, (nint)height, (nint)depth);
	}

	public static MTLRegion Create3D(nint x, nint y, nint z, nint width, nint height, nint depth)
	{
		MTLRegion result = default(MTLRegion);
		result.Origin.X = x;
		result.Origin.Y = y;
		result.Origin.Z = z;
		result.Size.Width = width;
		result.Size.Height = height;
		result.Size.Depth = depth;
		return result;
	}
}
