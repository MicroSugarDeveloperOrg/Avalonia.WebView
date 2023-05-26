using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGradient", true)]
public class NSGradient : NSObject
{
	private static IntPtr selInitWithColorsAtLocationsColorSpace = Selector.GetHandle("initWithColors:atLocations:colorSpace:");

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	private static readonly IntPtr selNumberOfColorStopsHandle = Selector.GetHandle("numberOfColorStops");

	private static readonly IntPtr selInitWithStartingColorEndingColor_Handle = Selector.GetHandle("initWithStartingColor:endingColor:");

	private static readonly IntPtr selInitWithColors_Handle = Selector.GetHandle("initWithColors:");

	private static readonly IntPtr selDrawFromPointToPointOptions_Handle = Selector.GetHandle("drawFromPoint:toPoint:options:");

	private static readonly IntPtr selDrawInRectAngle_Handle = Selector.GetHandle("drawInRect:angle:");

	private static readonly IntPtr selDrawInBezierPathAngle_Handle = Selector.GetHandle("drawInBezierPath:angle:");

	private static readonly IntPtr selDrawFromCenterRadiusToCenterRadiusOptions_Handle = Selector.GetHandle("drawFromCenter:radius:toCenter:radius:options:");

	private static readonly IntPtr selDrawInRectRelativeCenterPosition_Handle = Selector.GetHandle("drawInRect:relativeCenterPosition:");

	private static readonly IntPtr selDrawInBezierPathRelativeCenterPosition_Handle = Selector.GetHandle("drawInBezierPath:relativeCenterPosition:");

	private static readonly IntPtr selGetColorLocationAtIndex_Handle = Selector.GetHandle("getColor:location:atIndex:");

	private static readonly IntPtr selInterpolatedColorAtLocation_Handle = Selector.GetHandle("interpolatedColorAtLocation:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSGradient");

	private object __mt_ColorSpace_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_ColorSpace_var = ((!IsDirectBinding) ? ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle))) : ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle)))));
		}
	}

	public virtual long ColorStopsCount
	{
		[Export("numberOfColorStops")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfColorStopsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfColorStopsHandle);
		}
	}

	[Export("initWithColorsAndLocations:")]
	public NSGradient(NSColor[] colors, double[] locations)
		: this(colors, locations, NSColorSpace.GenericRGBColorSpace)
	{
	}

	[Export("initWithColors:atLocations:colorSpace:")]
	public NSGradient(NSColor[] colors, double[] locations, NSColorSpace colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (colors == null)
		{
			throw new ArgumentNullException("colors");
		}
		if (locations == null)
		{
			throw new ArgumentNullException("locations");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		NSArray nSArray = NSArray.FromNSObjects(colors);
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(locations[0]) * locations.Length);
		Marshal.Copy(locations, 0, intPtr, locations.Length);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithColorsAtLocationsColorSpace, nSArray.Handle, intPtr, colorSpace.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithColorsAtLocationsColorSpace, nSArray.Handle, intPtr, colorSpace.Handle);
		}
		nSArray.Dispose();
		Marshal.FreeHGlobal(intPtr);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGradient()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSGradient(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithStartingColor:endingColor:")]
	public NSGradient(NSColor startingColor, NSColor endingColor)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (startingColor == null)
		{
			throw new ArgumentNullException("startingColor");
		}
		if (endingColor == null)
		{
			throw new ArgumentNullException("endingColor");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStartingColorEndingColor_Handle, startingColor.Handle, endingColor.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStartingColorEndingColor_Handle, startingColor.Handle, endingColor.Handle);
		}
	}

	[Export("initWithColors:")]
	public NSGradient(NSColor[] colorArray)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (colorArray == null)
		{
			throw new ArgumentNullException("colorArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(colorArray);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithColors_Handle, nSArray.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithColors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("drawFromPoint:toPoint:options:")]
	public virtual void DrawFromPoint(CGPoint startingPoint, CGPoint endingPoint, NSGradientDrawingOptions options)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_UInt64(base.Handle, selDrawFromPointToPointOptions_Handle, startingPoint, endingPoint, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_UInt64(base.SuperHandle, selDrawFromPointToPointOptions_Handle, startingPoint, endingPoint, (ulong)options);
		}
	}

	[Export("drawInRect:angle:")]
	public virtual void DrawInRect(CGRect rect, double angle)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_Double(base.Handle, selDrawInRectAngle_Handle, rect, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_Double(base.SuperHandle, selDrawInRectAngle_Handle, rect, angle);
		}
	}

	[Export("drawInBezierPath:angle:")]
	public virtual void DrawInBezierPath(NSBezierPath path, double angle)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selDrawInBezierPathAngle_Handle, path.Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selDrawInBezierPathAngle_Handle, path.Handle, angle);
		}
	}

	[Export("drawFromCenter:radius:toCenter:radius:options:")]
	public virtual void DrawFromCenterRadius(CGPoint startCenter, double startRadius, CGPoint endCenter, double endRadius, NSGradientDrawingOptions options)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_Double_CGPoint_Double_UInt64(base.Handle, selDrawFromCenterRadiusToCenterRadiusOptions_Handle, startCenter, startRadius, endCenter, endRadius, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_Double_CGPoint_Double_UInt64(base.SuperHandle, selDrawFromCenterRadiusToCenterRadiusOptions_Handle, startCenter, startRadius, endCenter, endRadius, (ulong)options);
		}
	}

	[Export("drawInRect:relativeCenterPosition:")]
	public virtual void DrawInRect(CGRect rect, CGPoint relativeCenterPosition)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGPoint(base.Handle, selDrawInRectRelativeCenterPosition_Handle, rect, relativeCenterPosition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGPoint(base.SuperHandle, selDrawInRectRelativeCenterPosition_Handle, rect, relativeCenterPosition);
		}
	}

	[Export("drawInBezierPath:relativeCenterPosition:")]
	public virtual void DrawInBezierPath(NSBezierPath path, CGPoint relativeCenterPosition)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDrawInBezierPathRelativeCenterPosition_Handle, path.Handle, relativeCenterPosition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDrawInBezierPathRelativeCenterPosition_Handle, path.Handle, relativeCenterPosition);
		}
	}

	[Export("getColor:location:atIndex:")]
	public virtual void GetColor(out NSColor color, out double location, long index)
	{
		NSApplication.EnsureUIThread();
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_out_Double_Int64(base.Handle, selGetColorLocationAtIndex_Handle, intPtr, out location, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_out_Double_Int64(base.SuperHandle, selGetColorLocationAtIndex_Handle, intPtr, out location, index);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		color = ((intPtr2 != IntPtr.Zero) ? ((NSColor)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("interpolatedColorAtLocation:")]
	public virtual NSColor GetInterpolatedColor(double location)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInterpolatedColorAtLocation_Handle, location));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInterpolatedColorAtLocation_Handle, location));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ColorSpace_var = null;
		}
	}
}
