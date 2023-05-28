namespace CoreMotion;

[Mac(10, 15)]
public struct CMMagneticField
{
	public double X;

	public double Y;

	public double Z;

	public override string ToString()
	{
		return $"({X},{Y},{Z})";
	}
}
