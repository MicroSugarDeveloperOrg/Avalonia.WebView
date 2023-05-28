using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public struct CMVideoDimensions
{
	public int Width;

	public int Height;

	public CMVideoDimensions(int width, int height)
	{
		Width = width;
		Height = height;
	}
}
