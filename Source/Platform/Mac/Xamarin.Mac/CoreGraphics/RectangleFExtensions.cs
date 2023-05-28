using System;
using System.Runtime.InteropServices;

namespace CoreGraphics;

public static class RectangleFExtensions
{
	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGRectGetMinX(CGRect rect);

	public static nfloat GetMinX(this CGRect self)
	{
		return CGRectGetMinX(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGRectGetMidX(CGRect rect);

	public static nfloat GetMidX(this CGRect self)
	{
		return CGRectGetMidX(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGRectGetMaxX(CGRect rect);

	public static nfloat GetMaxX(this CGRect self)
	{
		return CGRectGetMaxX(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGRectGetMinY(CGRect rect);

	public static nfloat GetMinY(this CGRect self)
	{
		return CGRectGetMinY(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGRectGetMidY(CGRect rect);

	public static nfloat GetMidY(this CGRect self)
	{
		return CGRectGetMidY(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nfloat CGRectGetMaxY(CGRect rect);

	public static nfloat GetMaxY(this CGRect self)
	{
		return CGRectGetMaxY(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGRectStandardize(CGRect rect);

	public static CGRect Standardize(this CGRect self)
	{
		return CGRectStandardize(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGRectIsNull(CGRect rect);

	public static bool IsNull(this CGRect self)
	{
		return CGRectIsNull(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGRectIsInfinite(CGRect rect);

	public static bool IsInfinite(this CGRect self)
	{
		return CGRectIsInfinite(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGRectInset(CGRect rect, nfloat dx, nfloat dy);

	public static CGRect Inset(this CGRect self, nfloat dx, nfloat dy)
	{
		return CGRectInset(self, dx, dy);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGRectIntegral(CGRect rect);

	public static CGRect Integral(this CGRect self)
	{
		return CGRectIntegral(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGRectUnion(CGRect r1, CGRect r2);

	public static CGRect UnionWith(this CGRect self, CGRect other)
	{
		return CGRectUnion(self, other);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGRectDivide(CGRect rect, out CGRect slice, out CGRect remainder, nfloat amount, CGRectEdge edge);

	public static void Divide(this CGRect self, nfloat amount, CGRectEdge edge, out CGRect slice, out CGRect remainder)
	{
		CGRectDivide(self, out slice, out remainder, amount, edge);
	}
}
