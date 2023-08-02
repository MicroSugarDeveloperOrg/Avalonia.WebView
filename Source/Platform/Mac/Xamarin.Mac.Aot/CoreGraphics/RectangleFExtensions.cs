using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreGraphics;

[Since(3, 2)]
public static class RectangleFExtensions
{
	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGRectGetMinX(CGRect rect);

	public static double GetMinX(this CGRect self)
	{
		return CGRectGetMinX(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGRectGetMidX(CGRect rect);

	public static double GetMidX(this CGRect self)
	{
		return CGRectGetMidX(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGRectGetMaxX(CGRect rect);

	public static double GetMaxX(this CGRect self)
	{
		return CGRectGetMaxX(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGRectGetMinY(CGRect rect);

	public static double GetMinY(this CGRect self)
	{
		return CGRectGetMinY(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGRectGetMidY(CGRect rect);

	public static double GetMidY(this CGRect self)
	{
		return CGRectGetMidY(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern double CGRectGetMaxY(CGRect rect);

	public static double GetMaxY(this CGRect self)
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
		return CGRectIsNull(self);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGRect CGRectInset(CGRect rect, double dx, double dy);

	public static CGRect Inset(this CGRect self, double dx, double dy)
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
	private static extern void CGRectDivide(CGRect rect, out CGRect slice, out CGRect remainder, double amount, NSRectEdge edge);

	public static void Divide(this CGRect self, double amount, NSRectEdge edge, out CGRect slice, out CGRect remainder)
	{
		CGRectDivide(self, out slice, out remainder, amount, edge);
	}
}
