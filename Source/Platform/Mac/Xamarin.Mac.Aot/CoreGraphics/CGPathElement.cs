namespace CoreGraphics;

public struct CGPathElement
{
	public CGPathElementType Type;

	public CGPoint Point1;

	public CGPoint Point2;

	public CGPoint Point3;

	public CGPathElement(int t)
	{
		Type = (CGPathElementType)t;
		Point1 = (Point2 = (Point3 = new CGPoint(0, 0)));
	}
}
