namespace PrintCore;

public struct PMResolution
{
	private double hRes;

	private double vRes;

	public double HorizontalResolution => hRes;

	public double VerticalResolution => vRes;

	public PMResolution(double horizontal, double vertical)
	{
		hRes = horizontal;
		vRes = vertical;
	}

	public override string ToString()
	{
		return $"[HorizontalResolution={hRes},VerticalResolution={vRes}]";
	}
}
