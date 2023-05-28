namespace PrintCore;

public struct PMRect
{
	internal double top;

	internal double left;

	internal double bottom;

	internal double right;

	public double Top => top;

	public double Left => left;

	public double Bottom => bottom;

	public double Right => right;

	public PMRect(double top, double bottom, double left, double right)
	{
		this.top = top;
		this.bottom = bottom;
		this.left = left;
		this.right = right;
	}

	public override string ToString()
	{
		return $"[Top={top},Bottom={bottom},Left={left},Right={right}]";
	}
}
