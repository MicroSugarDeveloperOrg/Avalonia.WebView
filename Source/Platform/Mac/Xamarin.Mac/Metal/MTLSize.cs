using Xamarin.Mac.System.Mac;

namespace Metal;

public struct MTLSize
{
	public nint Width;

	public nint Height;

	public nint Depth;

	public MTLSize(nint width, nint height, nint depth)
	{
		Width = width;
		Height = height;
		Depth = depth;
	}
}
