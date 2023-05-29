using System;
using System.Runtime.InteropServices;

namespace CoreGraphics;

public struct CGAffineTransform
{
	public double xx;

	public double yx;

	public double xy;

	public double yy;

	public double x0;

	public double y0;

	public bool IsIdentity
	{
		get
		{
			if (xx == 1.0 && yx == 0.0 && xy == 0.0 && yy == 1.0 && x0 == 0.0)
			{
				return y0 == 0.0;
			}
			return false;
		}
	}

	public CGAffineTransform(double xx, double yx, double xy, double yy, double x0, double y0)
	{
		this.xx = xx;
		this.yx = yx;
		this.xy = xy;
		this.yy = yy;
		this.x0 = x0;
		this.y0 = y0;
	}

	public static CGAffineTransform MakeIdentity()
	{
		return new CGAffineTransform(1.0, 0.0, 0.0, 1.0, 0.0, 0.0);
	}

	public static CGAffineTransform MakeRotation(double angle)
	{
		return new CGAffineTransform(Math.Cos(angle), Math.Sin(angle), 0.0 - Math.Sin(angle), Math.Cos(angle), 0.0, 0.0);
	}

	public static CGAffineTransform MakeScale(double sx, double sy)
	{
		return new CGAffineTransform(sx, 0.0, 0.0, sy, 0.0, 0.0);
	}

	public static CGAffineTransform MakeTranslation(double tx, double ty)
	{
		return new CGAffineTransform(1.0, 0.0, 0.0, 1.0, tx, ty);
	}

	public static CGAffineTransform Multiply(CGAffineTransform a, CGAffineTransform b)
	{
		return new CGAffineTransform(a.xx * b.xx + a.yx * b.xy, a.xx * b.yx + a.yx * b.yy, a.xy * b.xx + a.yy * b.xy, a.xy * b.yx + a.yy * b.yy, a.x0 * b.xx + a.y0 * b.xy + b.x0, a.x0 * b.yx + a.y0 * b.yy + b.y0);
	}

	public void Multiply(CGAffineTransform b)
	{
		CGAffineTransform cGAffineTransform = this;
		xx = cGAffineTransform.xx * b.xx + cGAffineTransform.yx * b.xy;
		yx = cGAffineTransform.xx * b.yx + cGAffineTransform.yx * b.yy;
		xy = cGAffineTransform.xy * b.xx + cGAffineTransform.yy * b.xy;
		yy = cGAffineTransform.xy * b.yx + cGAffineTransform.yy * b.yy;
		x0 = cGAffineTransform.x0 * b.xx + cGAffineTransform.y0 * b.xy + b.x0;
		y0 = cGAffineTransform.x0 * b.yx + cGAffineTransform.y0 * b.yy + b.y0;
	}

	public void Scale(double sx, double sy)
	{
		Multiply(MakeScale(sx, sy));
	}

	public void Translate(double tx, double ty)
	{
		Multiply(MakeTranslation(tx, ty));
	}

	public void Rotate(double angle)
	{
		Multiply(MakeRotation(angle));
	}

	public override string ToString()
	{
		return $"xx:{xx:##0.0#} yx:{yx:##0.0#} xy:{xy:##0.0#} yy:{yy:##0.0#} x0:{x0:##0.0#} y0:{y0:##0.0#}";
	}

	public static bool operator ==(CGAffineTransform lhs, CGAffineTransform rhs)
	{
		if (lhs.xx == rhs.xx && lhs.xy == rhs.xy && lhs.yx == rhs.yx && lhs.yy == rhs.yy && lhs.x0 == rhs.x0)
		{
			return lhs.y0 == rhs.y0;
		}
		return false;
	}

	public static bool operator !=(CGAffineTransform lhs, CGAffineTransform rhs)
	{
		return !(lhs == rhs);
	}

	public static CGAffineTransform operator *(CGAffineTransform a, CGAffineTransform b)
	{
		return new CGAffineTransform(a.xx * b.xx + a.yx * b.xy, a.xx * b.yx + a.yx * b.yy, a.xy * b.xx + a.yy * b.xy, a.xy * b.yx + a.yy * b.yy, a.x0 * b.xx + a.y0 * b.xy + b.x0, a.x0 * b.yx + a.y0 * b.yy + b.y0);
	}

	public override bool Equals(object o)
	{
		if (!(o is CGAffineTransform))
		{
			return false;
		}
		return this == (CGAffineTransform)o;
	}

	public override int GetHashCode()
	{
		return (int)xx ^ (int)xy ^ (int)yx ^ (int)yy ^ (int)x0 ^ (int)y0;
	}

	public CGPoint TransformPoint(CGPoint point)
	{
		return new CGPoint(xx * point.X + xy * point.Y + x0, yx * point.X + yy * point.Y + y0);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	public static extern CGRect CGRectApplyAffineTransform(CGRect rect, CGAffineTransform t);

	public CGRect TransformRect(CGRect rect)
	{
		return CGRectApplyAffineTransform(rect, this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	public static extern CGAffineTransform CGAffineTransformInvert(CGAffineTransform t);

	public CGAffineTransform Invert()
	{
		return CGAffineTransformInvert(this);
	}
}
