using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSGraphics
{
	public static readonly double White = 1.0;

	public static readonly double Black = 0.0;

	public static readonly double LightGray = 2.0 / 3.0;

	public static readonly double DarkGray = 1.0 / 3.0;

	public static NSWindowDepth[] AvailableWindowDepths
	{
		get
		{
			IntPtr ptr = NSAvailableWindowDepths();
			int i;
			for (i = 0; Marshal.ReadInt32(ptr, i) != 0; i++)
			{
			}
			NSWindowDepth[] array = new NSWindowDepth[i];
			for (int num = 0; num < i; i++)
			{
				array[num] = (NSWindowDepth)Marshal.ReadInt32(ptr, num);
			}
			return array;
		}
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern NSWindowDepth NSBestDepth(IntPtr colorspaceHandle, long bitsPerSample, long bitsPerPixel, bool planar, ref bool exactMatch);

	public static NSWindowDepth BestDepth(NSString colorspace, long bitsPerSample, long bitsPerPixel, bool planar, ref bool exactMatch)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		return NSBestDepth(colorspace.Handle, bitsPerSample, bitsPerPixel, planar, ref exactMatch);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern int NSPlanarFromDepth(NSWindowDepth depth);

	public static bool PlanarFromDepth(NSWindowDepth depth)
	{
		return NSPlanarFromDepth(depth) != 0;
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSColorSpaceFromDepth(NSWindowDepth depth);

	public static NSString ColorSpaceFromDepth(NSWindowDepth depth)
	{
		return new NSString(NSColorSpaceFromDepth(depth));
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSBitsPerSampleFromDepth")]
	public static extern int BitsPerSampleFromDepth(NSWindowDepth depth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSBitsPerPixelFromDepth")]
	public static extern int BitsPerPixelFromDepth(NSWindowDepth depth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern int NSNumberOfColorComponents(IntPtr str);

	public static int NumberOfColorComponents(NSString colorspaceName)
	{
		if (colorspaceName == null)
		{
			throw new ArgumentNullException("colorspaceName");
		}
		return NSNumberOfColorComponents(colorspaceName.Handle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAvailableWindowDepths();

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSRectFill")]
	public static extern void RectFill(CGRect rect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSRectFillList")]
	private unsafe static extern void RectFillList(CGRect* rects, int count);

	public unsafe static void RectFill(CGRect[] rects)
	{
		if (rects == null)
		{
			throw new ArgumentNullException("rects");
		}
		fixed (CGRect* rects2 = &rects[0])
		{
			RectFillList(rects2, rects.Length);
		}
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSRectClip")]
	public static extern void RectClip(CGRect rect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSFrameRect")]
	public static extern void FrameRect(CGRect rect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSFrameRectWithWidth")]
	public static extern void FrameRect(CGRect rect, double frameWidth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSFrameRectWithWidth")]
	public static extern void FrameRectWithWidth(CGRect rect, double frameWidth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSFrameRectWithWidthUsingOperation")]
	public static extern void FrameRect(CGRect rect, double frameWidth, NSCompositingOperation operation);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSShowAnimationEffect")]
	public static extern void ShowAnimationEffect(NSAnimationEffect animationEffect, CGPoint centerLocation, CGSize size, NSObject animationDelegate, Selector didEndSelector, IntPtr contextInfo);

	public static void ShowAnimationEffect(NSAnimationEffect animationEffect, CGPoint centerLocation, CGSize size, NSAction endedCallback)
	{
		NSAsyncActionDispatcher nSAsyncActionDispatcher = new NSAsyncActionDispatcher(endedCallback);
		ShowAnimationEffect(animationEffect, centerLocation, size, nSAsyncActionDispatcher, NSActionDispatcher.Selector, IntPtr.Zero);
		GC.KeepAlive(nSAsyncActionDispatcher);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDrawWhiteBezel")]
	public static extern void DrawWhiteBezel(CGRect aRect, CGRect clipRect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDrawLightBezel")]
	public static extern void DrawLightBezel(CGRect aRect, CGRect clipRect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDrawGrayBezel")]
	public static extern void DrawGrayBezel(CGRect aRect, CGRect clipRect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDrawDarkBezel")]
	public static extern void DrawDarkBezel(CGRect aRect, CGRect clipRect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDrawGroove")]
	public static extern void DrawGroove(CGRect aRect, CGRect clipRect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDrawTiledRects")]
	private unsafe static extern CGRect DrawTiledRects(CGRect aRect, CGRect clipRect, NSRectEdge* sides, double* grays, long count);

	public unsafe static CGRect DrawTiledRects(CGRect aRect, CGRect clipRect, NSRectEdge[] sides, double[] grays)
	{
		if (sides == null)
		{
			throw new ArgumentNullException("sides");
		}
		if (grays == null)
		{
			throw new ArgumentNullException("grays");
		}
		if (sides.Length != grays.Length)
		{
			throw new ArgumentOutOfRangeException("grays", "Both array parameters must have the same length");
		}
		fixed (NSRectEdge* sides2 = &sides[0])
		{
			fixed (double* grays2 = &grays[0])
			{
				return DrawTiledRects(aRect, clipRect, sides2, grays2, sides.Length);
			}
		}
	}
}
