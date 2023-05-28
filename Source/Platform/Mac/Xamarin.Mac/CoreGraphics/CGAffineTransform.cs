using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreGraphics;

public struct CGAffineTransform
{
	public nfloat xx;

	public nfloat yx;

	public nfloat xy;

	public nfloat yy;

	public nfloat x0;

	public nfloat y0;

	public bool IsIdentity => xx == 1 && yx == 0 && xy == 0 && yy == 1 && x0 == 0 && y0 == 0;

	public CGAffineTransform(nfloat xx, nfloat yx, nfloat xy, nfloat yy, nfloat x0, nfloat y0)
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
		return new CGAffineTransform(1, 0, 0, 1, 0, 0);
	}

	public static CGAffineTransform MakeRotation(nfloat angle)
	{
		nfloat nfloat = (nfloat)Math.Cos(angle);
		nfloat nfloat2 = (nfloat)Math.Sin(angle);
		return new CGAffineTransform(nfloat, nfloat2, -nfloat2, nfloat, 0, 0);
	}

	public static CGAffineTransform MakeScale(nfloat sx, nfloat sy)
	{
		return new CGAffineTransform(sx, 0, 0, sy, 0, 0);
	}

	public static CGAffineTransform MakeTranslation(nfloat tx, nfloat ty)
	{
		return new CGAffineTransform(1, 0, 0, 1, tx, ty);
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

	public void Scale(nfloat sx, nfloat sy, MatrixOrder order)
	{
		switch (order)
		{
		case MatrixOrder.Prepend:
			this = Multiply(MakeScale(sx, sy), this);
			break;
		case MatrixOrder.Append:
			this = Multiply(this, MakeScale(sx, sy));
			break;
		default:
			throw new ArgumentOutOfRangeException("order");
		}
	}

	[Advice("By default, the new operation is applied after the old operation: t' = t * [ sx 0 0 sy 0 0 ].\nTo have the same behavior as the native Swift API, pass 'MatrixOrder.Prepend' to 'Scale (nfloat, nfloat, MatrixOrder)'.")]
	public void Scale(nfloat sx, nfloat sy)
	{
		Scale(sx, sy, MatrixOrder.Append);
	}

	public static CGAffineTransform Scale(CGAffineTransform transform, nfloat sx, nfloat sy)
	{
		return new CGAffineTransform(sx * transform.xx, sx * transform.yx, sy * transform.xy, sy * transform.yy, transform.x0, transform.y0);
	}

	public void Translate(nfloat tx, nfloat ty, MatrixOrder order)
	{
		switch (order)
		{
		case MatrixOrder.Prepend:
			this = Multiply(MakeTranslation(tx, ty), this);
			break;
		case MatrixOrder.Append:
			this = Multiply(this, MakeTranslation(tx, ty));
			break;
		default:
			throw new ArgumentOutOfRangeException("order");
		}
	}

	[Advice("By default, the new operation is applied after the old operation: t' = t * [ 1 0 0 1 tx ty ].\nTo have the same behavior as the native Swift API, pass 'MatrixOrder.Prepend' to 'Translate (nfloat, nfloat, MatrixOrder)'.")]
	public void Translate(nfloat tx, nfloat ty)
	{
		Translate(tx, ty, MatrixOrder.Append);
	}

	public static CGAffineTransform Translate(CGAffineTransform transform, nfloat tx, nfloat ty)
	{
		return new CGAffineTransform(transform.xx, transform.yx, transform.xy, transform.yy, tx * transform.xx + ty * transform.xy + transform.x0, tx * transform.yx + ty * transform.yy + transform.y0);
	}

	public void Rotate(nfloat angle, MatrixOrder order)
	{
		switch (order)
		{
		case MatrixOrder.Prepend:
			this = Multiply(MakeRotation(angle), this);
			break;
		case MatrixOrder.Append:
			this = Multiply(this, MakeRotation(angle));
			break;
		default:
			throw new ArgumentOutOfRangeException("order");
		}
	}

	[Advice("By default, the new operation is applied after the old operation: t' = t * [ cos(angle) sin(angle) -sin(angle) cos(angle) 0 0 ].\nTo have the same behavior as the native Swift API, pass 'MatrixOrder.Prepend' to 'Rotate (nfloat, MatrixOrder)'.")]
	public void Rotate(nfloat angle)
	{
		Rotate(angle, MatrixOrder.Append);
	}

	public static CGAffineTransform Rotate(CGAffineTransform transform, nfloat angle)
	{
		nfloat nfloat = (nfloat)Math.Cos(angle);
		nfloat nfloat2 = (nfloat)Math.Sin(angle);
		return new CGAffineTransform(nfloat * transform.xx + nfloat2 * transform.xy, nfloat * transform.yx + nfloat2 * transform.yy, nfloat * transform.xy - nfloat2 * transform.xx, nfloat * transform.yy - nfloat2 * transform.yx, transform.x0, transform.y0);
	}

	public override string ToString()
	{
		return $"xx:{xx:##0.0#} yx:{yx:##0.0#} xy:{xy:##0.0#} yy:{yy:##0.0#} x0:{x0:##0.0#} y0:{y0:##0.0#}";
	}

	public static bool operator ==(CGAffineTransform lhs, CGAffineTransform rhs)
	{
		return lhs.xx == rhs.xx && lhs.xy == rhs.xy && lhs.yx == rhs.yx && lhs.yy == rhs.yy && lhs.x0 == rhs.x0 && lhs.y0 == rhs.y0;
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
	private static extern CGSize CGSizeApplyAffineTransform(CGSize rect, CGAffineTransform t);

	public CGSize TransformSize(CGSize size)
	{
		return CGSizeApplyAffineTransform(size, this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	public static extern CGAffineTransform CGAffineTransformInvert(CGAffineTransform t);

	public CGAffineTransform Invert()
	{
		return CGAffineTransformInvert(this);
	}
}
