using CoreGraphics;
using Foundation;

namespace AppKit;

public static class NSStringDrawing
{
	public static void DrawAtPoint(this string This, CGPoint point, NSDictionary attributes)
	{
		using NSString @this = (NSString)This;
		@this.DrawAtPoint(point, attributes);
	}

	public static void DrawAtPoint(this string This, CGPoint point, NSStringAttributes attributes)
	{
		This.DrawAtPoint(point, attributes?.Dictionary);
	}

	public static void DrawInRect(this string This, CGRect rect, NSDictionary attributes)
	{
		using NSString @this = (NSString)This;
		@this.DrawInRect(rect, attributes);
	}

	public static void DrawInRect(this string This, CGRect rect, NSStringAttributes attributes)
	{
		This.DrawInRect(rect, attributes?.Dictionary);
	}

	public static CGSize StringSize(this string This, NSDictionary attributes)
	{
		using NSString nSString = (NSString)This;
		return nSString.StringSize(attributes);
	}

	public static CGSize StringSize(this string This, NSStringAttributes attributes)
	{
		return This.StringSize(attributes?.Dictionary);
	}
}
