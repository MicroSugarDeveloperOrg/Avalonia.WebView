using Xamarin.Mac.System.Mac;

namespace Metal;

public struct MTLScissorRect
{
	public nuint X;

	public nuint Y;

	public nuint Width;

	public nuint Height;

	public MTLScissorRect(nuint x, nuint y, nuint width, nuint height)
	{
		X = x;
		Y = y;
		Width = width;
		Height = height;
	}

	public override string ToString()
	{
		return $"({X},{Y},{Width},{Height}";
	}
}
