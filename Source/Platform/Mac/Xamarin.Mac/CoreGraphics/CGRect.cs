using System;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[Serializable]
public struct CGRect : IEquatable<CGRect>
{
	[Field("CGRectZero", "CoreGraphics")]
	public static readonly CGRect Empty;

	private nfloat x;

	private nfloat y;

	private nfloat width;

	private nfloat height;

	[Field("CGRectNull", "CoreGraphics")]
	public static CGRect Null => Dlfcn.GetCGRect(Libraries.CoreGraphics.Handle, "CGRectNull");

	[Field("CGRectInfinite", "CoreGraphics")]
	public static CGRect Infinite => Dlfcn.GetCGRect(Libraries.CoreGraphics.Handle, "CGRectInfinite");

	public bool IsEmpty => (double)width == 0.0 || (double)height == 0.0;

	public nfloat X
	{
		get
		{
			return x;
		}
		set
		{
			x = value;
		}
	}

	public nfloat Y
	{
		get
		{
			return y;
		}
		set
		{
			y = value;
		}
	}

	public nfloat Width
	{
		get
		{
			return width;
		}
		set
		{
			width = value;
		}
	}

	public nfloat Height
	{
		get
		{
			return height;
		}
		set
		{
			height = value;
		}
	}

	public nfloat Top => Y;

	public nfloat Bottom => Y + Height;

	public nfloat Left => X;

	public nfloat Right => X + Width;

	public CGPoint Location
	{
		get
		{
			return new CGPoint(x, y);
		}
		set
		{
			x = value.X;
			y = value.Y;
		}
	}

	public CGSize Size
	{
		get
		{
			return new CGSize(width, height);
		}
		set
		{
			width = value.Width;
			height = value.Height;
		}
	}

	public static bool operator ==(CGRect left, CGRect right)
	{
		return left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;
	}

	public static bool operator !=(CGRect left, CGRect right)
	{
		return left.X != right.X || left.Y != right.Y || left.Width != right.Width || left.Height != right.Height;
	}

	public static CGRect Intersect(CGRect a, CGRect b)
	{
		if (!a.IntersectsWithInclusive(b))
		{
			return Empty;
		}
		return FromLTRB((nfloat)Math.Max(a.Left, b.Left), (nfloat)Math.Max(a.Top, b.Top), (nfloat)Math.Min(a.Right, b.Right), (nfloat)Math.Min(a.Bottom, b.Bottom));
	}

	public void Intersect(CGRect rect)
	{
		this = Intersect(this, rect);
	}

	public static CGRect Union(CGRect a, CGRect b)
	{
		return FromLTRB((nfloat)Math.Min(a.Left, b.Left), (nfloat)Math.Min(a.Top, b.Top), (nfloat)Math.Max(a.Right, b.Right), (nfloat)Math.Max(a.Bottom, b.Bottom));
	}

	public static CGRect FromLTRB(nfloat left, nfloat top, nfloat right, nfloat bottom)
	{
		return new CGRect(left, top, right - left, bottom - top);
	}

	public static CGRect Inflate(CGRect rect, nfloat x, nfloat y)
	{
		CGRect result = new CGRect(rect.X, rect.Y, rect.Width, rect.Height);
		result.Inflate(x, y);
		return result;
	}

	public CGRect(CGPoint location, CGSize size)
	{
		x = location.X;
		y = location.Y;
		width = size.Width;
		height = size.Height;
	}

	public CGRect(nfloat x, nfloat y, nfloat width, nfloat height)
	{
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
	}

	public CGRect(double x, double y, double width, double height)
	{
		this.x = (nfloat)x;
		this.y = (nfloat)y;
		this.width = (nfloat)width;
		this.height = (nfloat)height;
	}

	public CGRect(float x, float y, float width, float height)
	{
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
	}

	public bool Contains(nfloat x, nfloat y)
	{
		return x >= Left && x < Right && y >= Top && y < Bottom;
	}

	public bool Contains(float x, float y)
	{
		return Contains((nfloat)x, (nfloat)y);
	}

	public bool Contains(double x, double y)
	{
		return Contains((nfloat)x, (nfloat)y);
	}

	public bool Contains(CGPoint point)
	{
		return Contains(point.X, point.Y);
	}

	public bool Contains(CGRect rect)
	{
		return X <= rect.X && Right >= rect.Right && Y <= rect.Y && Bottom >= rect.Bottom;
	}

	public void Inflate(nfloat x, nfloat y)
	{
		this.x -= x;
		this.y -= y;
		width += x * 2;
		height += y * 2;
	}

	public void Inflate(float x, float y)
	{
		Inflate((nfloat)x, (nfloat)y);
	}

	public void Inflate(double x, double y)
	{
		Inflate((nfloat)x, (nfloat)y);
	}

	public void Inflate(CGSize size)
	{
		Inflate(size.Width, size.Height);
	}

	public void Offset(nfloat x, nfloat y)
	{
		X += x;
		Y += y;
	}

	public void Offset(float x, float y)
	{
		Offset((nfloat)x, (nfloat)y);
	}

	public void Offset(double x, double y)
	{
		Offset((nfloat)x, (nfloat)y);
	}

	public void Offset(CGPoint pos)
	{
		Offset(pos.X, pos.Y);
	}

	public bool IntersectsWith(CGRect rect)
	{
		return !(Left >= rect.Right) && !(Right <= rect.Left) && !(Top >= rect.Bottom) && !(Bottom <= rect.Top);
	}

	private bool IntersectsWithInclusive(CGRect r)
	{
		return !(Left > r.Right) && !(Right < r.Left) && !(Top > r.Bottom) && !(Bottom < r.Top);
	}

	public override bool Equals(object obj)
	{
		if (obj is CGRect)
		{
			return this == (CGRect)obj;
		}
		return false;
	}

	public bool Equals(CGRect rect)
	{
		return this == rect;
	}

	public override int GetHashCode()
	{
		int num = 23;
		num = num * 31 + x.GetHashCode();
		num = num * 31 + y.GetHashCode();
		num = num * 31 + width.GetHashCode();
		return num * 31 + height.GetHashCode();
	}

	public override string ToString()
	{
		return $"{{X={x},Y={y},Width={width},Height={height}}}";
	}

	public static bool TryParse(NSDictionary dictionaryRepresentation, out CGRect rect)
	{
		if (dictionaryRepresentation == null)
		{
			rect = Empty;
			return false;
		}
		return NativeDrawingMethods.CGRectMakeWithDictionaryRepresentation(dictionaryRepresentation.Handle, out rect);
	}

	public NSDictionary ToDictionary()
	{
		return new NSDictionary(NativeDrawingMethods.CGRectCreateDictionaryRepresentation(this));
	}
}
