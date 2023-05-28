namespace PrintCore;

public struct PMPaperMargins
{
	private PMRect Rect;

	public double Top => Rect.top;

	public double Left => Rect.left;

	public double Bottom => Rect.bottom;

	public double Right => Rect.right;

	public PMPaperMargins(double top, double bottom, double left, double right)
	{
		Rect = new PMRect(top, bottom, left, right);
	}

	public override string ToString()
	{
		return Rect.ToString();
	}
}
