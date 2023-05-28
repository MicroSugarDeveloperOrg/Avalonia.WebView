namespace CoreMotion;

public struct CMQuaternion
{
	public double x;

	public double y;

	public double z;

	public double w;

	public CMQuaternion(double x, double y, double z, double w)
	{
		this.x = x;
		this.y = y;
		this.z = z;
		this.w = w;
	}

	public override string ToString()
	{
		return $"quaternion=({x},{y},{z},{w})";
	}
}
