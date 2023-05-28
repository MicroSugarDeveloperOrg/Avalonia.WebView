using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSGraphics
{
	public static readonly float White = 1f;

	public static readonly float Black = 0f;

	public static readonly float LightGray = 2f / 3f;

	public static readonly float DarkGray = 1f / 3f;

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
	private static extern NSWindowDepth NSBestDepth(IntPtr colorspaceHandle, nint bitsPerSample, nint bitsPerPixel, bool planar, ref bool exactMatch);

	public static NSWindowDepth BestDepth(NSString colorspace, nint bitsPerSample, nint bitsPerPixel, bool planar, ref bool exactMatch)
	{
		if (colorspace == null)
		{
			throw new ArgumentNullException("colorspace");
		}
		return NSBestDepth(colorspace.Handle, bitsPerSample, bitsPerPixel, planar, ref exactMatch);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern bool NSPlanarFromDepth(NSWindowDepth depth);

	public static bool PlanarFromDepth(NSWindowDepth depth)
	{
		return NSPlanarFromDepth(depth);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSColorSpaceFromDepth(NSWindowDepth depth);

	public static NSString ColorSpaceFromDepth(NSWindowDepth depth)
	{
		return new NSString(NSColorSpaceFromDepth(depth));
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSBitsPerSampleFromDepth")]
	public static extern nint BitsPerSampleFromDepth(NSWindowDepth depth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSBitsPerPixelFromDepth")]
	public static extern nint BitsPerPixelFromDepth(NSWindowDepth depth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern nint NSNumberOfColorComponents(IntPtr str);

	public static nint NumberOfColorComponents(NSString colorspaceName)
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

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void NSRectFillUsingOperation(CGRect rect, nuint op);

	public static void RectFill(CGRect rect, NSCompositingOperation op)
	{
		NSRectFillUsingOperation(rect, (nuint)(ulong)op);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSRectFillList")]
	private unsafe static extern void RectFillList(CGRect* rects, nint count);

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
	public static extern void FrameRect(CGRect rect, nfloat frameWidth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSFrameRectWithWidth")]
	public static extern void FrameRectWithWidth(CGRect rect, nfloat frameWidth);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void NSFrameRectWithWidthUsingOperation(CGRect rect, nfloat frameWidth, nuint operation);

	public static void FrameRect(CGRect rect, nfloat frameWidth, NSCompositingOperation operation)
	{
		NSFrameRectWithWidthUsingOperation(rect, frameWidth, (nuint)(ulong)operation);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void NSShowAnimationEffect(nuint animationEffect, CGPoint centerLocation, CGSize size, NSObject animationDelegate, Selector didEndSelector, IntPtr contextInfo);

	public static void ShowAnimationEffect(NSAnimationEffect animationEffect, CGPoint centerLocation, CGSize size, NSObject animationDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		NSShowAnimationEffect((nuint)(ulong)animationEffect, centerLocation, size, animationDelegate, didEndSelector, contextInfo);
	}

	public static void ShowAnimationEffect(NSAnimationEffect animationEffect, CGPoint centerLocation, CGSize size, Action endedCallback)
	{
		NSAsyncActionDispatcher nSAsyncActionDispatcher = new NSAsyncActionDispatcher(endedCallback);
		ShowAnimationEffect(animationEffect, centerLocation, size, nSAsyncActionDispatcher, NSDispatcher.Selector, IntPtr.Zero);
		GC.KeepAlive(nSAsyncActionDispatcher);
	}

	public static void SetFocusRingStyle(NSFocusRingPlacement placement)
	{
		SetFocusRingStyle((nuint)(ulong)placement);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSSetFocusRingStyle")]
	private static extern void SetFocusRingStyle(nuint placement);

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
	private unsafe static extern CGRect DrawTiledRects(CGRect aRect, CGRect clipRect, NSRectEdge* sides, nfloat* grays, nint count);

	public unsafe static CGRect DrawTiledRects(CGRect aRect, CGRect clipRect, NSRectEdge[] sides, nfloat[] grays)
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
			fixed (nfloat* grays2 = &grays[0])
			{
				return DrawTiledRects(aRect, clipRect, sides2, grays2, sides.Length);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDrawWindowBackground")]
	public static extern void DrawWindowBackground(CGRect aRect);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSDisableScreenUpdates")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Not usually necessary, 'NSAnimationContext.RunAnimation' can be used instead and not suffer from performance issues.")]
	public static extern void DisableScreenUpdates();

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit", EntryPoint = "NSEnableScreenUpdates")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Not usually necessary, 'NSAnimationContext.RunAnimation' can be used instead and not suffer from performance issues.")]
	public static extern void EnableScreenUpdates();
}
