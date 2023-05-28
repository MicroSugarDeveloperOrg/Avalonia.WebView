namespace Metal;

public struct MTLViewport
{
	public double OriginX;

	public double OriginY;

	public double Width;

	public double Height;

	public double ZNear;

	public double ZFar;

	public MTLViewport(double originX, double originY, double width, double height, double znear, double zfar)
	{
		OriginX = originX;
		OriginY = originY;
		Width = width;
		Height = height;
		ZNear = znear;
		ZFar = zfar;
	}

	public override string ToString()
	{
		return $"({OriginX},{OriginY},{Width},{Height} Znear={ZNear} Zfar={ZFar})";
	}
}
