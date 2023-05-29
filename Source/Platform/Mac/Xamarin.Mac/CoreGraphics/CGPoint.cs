using System.Globalization;
using System.Runtime.InteropServices;

namespace CoreGraphics;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct CGPoint
{
	public static readonly CGPoint Empty;

	public double X;

	public double Y;

	public override int GetHashCode()
	{
		return X.GetHashCode() ^ Y.GetHashCode();
	}

	public static bool operator ==(CGPoint left, CGPoint right)
	{
		if (left.X == right.X)
		{
			return left.Y == right.Y;
		}
		return false;
	}

	public static bool operator !=(CGPoint left, CGPoint right)
	{
		if (left.X == right.X)
		{
			return left.Y != right.Y;
		}
		return true;
	}

	public static CGPoint operator +(CGPoint pt, CGSize sz)
	{
		return new CGPoint(pt.X + sz.Width, pt.Y + sz.Height);
	}

	public static CGPoint operator -(CGPoint pt, CGSize sz)
	{
		return new CGPoint(pt.X - sz.Width, pt.Y - sz.Height);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{{X={0},Y={1}}}", X, Y);
	}

	public CGPoint(int x, int y)
	{
		X = x;
		Y = y;
	}

	public CGPoint(double x, double y)
	{
		X = x;
		Y = y;
	}
}
