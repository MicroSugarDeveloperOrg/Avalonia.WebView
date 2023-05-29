using System.Globalization;

namespace CoreGraphics;

public struct CGRect
{
	public static readonly CGRect Empty;

	public CGPoint Origin;

	public CGSize Size;

	public CGPoint Location => Origin;

	public double Left => X;

	public double Top => Y;

	public double Right => X + Width;

	public double Bottom => Y + Height;

	public double X
	{
		get
		{
			return Origin.X;
		}
		set
		{
			Origin.X = value;
		}
	}

	public double Y
	{
		get
		{
			return Origin.Y;
		}
		set
		{
			Origin.Y = value;
		}
	}

	public double Width
	{
		get
		{
			return Size.Width;
		}
		set
		{
			Size.Width = value;
		}
	}

	public double Height
	{
		get
		{
			return Size.Height;
		}
		set
		{
			Size.Height = value;
		}
	}

	public CGRect(CGPoint location, CGSize size)
	{
		Origin.X = location.X;
		Origin.Y = location.Y;
		Size.Width = size.Width;
		Size.Height = size.Height;
	}

	public CGRect(double x, double y, double width, double height)
	{
		Origin.X = x;
		Origin.Y = y;
		Size.Width = width;
		Size.Height = height;
	}

	public override bool Equals(object obj)
	{
		if (obj is CGRect)
		{
			return this == (CGRect)obj;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Origin.GetHashCode() ^ Size.GetHashCode();
	}

	public static bool operator ==(CGRect left, CGRect right)
	{
		if (left.Origin == right.Origin)
		{
			return left.Size == right.Size;
		}
		return false;
	}

	public static bool operator !=(CGRect left, CGRect right)
	{
		if (!(left.Origin != right.Origin))
		{
			return left.Size != right.Size;
		}
		return true;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{{X={0},Y={1},Width={2},Height={3}}}", X, Y, Width, Height);
	}
}
