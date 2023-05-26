using System.Globalization;
using System.Runtime.InteropServices;

namespace CoreGraphics;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct CGSize
{
	public static readonly CGSize Empty;

	public double Width;

	public double Height;

	public CGSize(double width, double height)
	{
		Width = width;
		Height = height;
	}

	public override int GetHashCode()
	{
		return Width.GetHashCode() ^ Height.GetHashCode();
	}

	public static bool operator ==(CGSize left, CGSize right)
	{
		if (left.Width == right.Width)
		{
			return left.Height == right.Height;
		}
		return false;
	}

	public static bool operator !=(CGSize left, CGSize right)
	{
		if (left.Width == right.Width)
		{
			return left.Height != right.Height;
		}
		return true;
	}

	public static CGSize operator +(CGSize size1, CGSize size2)
	{
		return new CGSize(size1.Width + size2.Width, size1.Height + size2.Height);
	}

	public static CGSize operator -(CGSize size1, CGSize size2)
	{
		return new CGSize(size1.Width - size2.Width, size1.Height - size2.Height);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{{Width={0},Height={1}}}", Width, Height);
	}
}
