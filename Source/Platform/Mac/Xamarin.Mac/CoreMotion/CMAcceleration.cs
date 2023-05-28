namespace CoreMotion;

public struct CMAcceleration
{
	public double X;

	public double Y;

	public double Z;

	public CMAcceleration(double x, double y, double z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public override string ToString()
	{
		return $"a=({X},{Y},{Z})";
	}
}
