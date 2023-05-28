using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSGradient", true)]
public class NSGradient : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	private static IntPtr selInitWithColorsAtLocationsColorSpace = Selector.GetHandle("initWithColors:atLocations:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawFromCenter_Radius_ToCenter_Radius_Options_ = "drawFromCenter:radius:toCenter:radius:options:";

	private static readonly IntPtr selDrawFromCenter_Radius_ToCenter_Radius_Options_Handle = Selector.GetHandle("drawFromCenter:radius:toCenter:radius:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawFromPoint_ToPoint_Options_ = "drawFromPoint:toPoint:options:";

	private static readonly IntPtr selDrawFromPoint_ToPoint_Options_Handle = Selector.GetHandle("drawFromPoint:toPoint:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInBezierPath_Angle_ = "drawInBezierPath:angle:";

	private static readonly IntPtr selDrawInBezierPath_Angle_Handle = Selector.GetHandle("drawInBezierPath:angle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInBezierPath_RelativeCenterPosition_ = "drawInBezierPath:relativeCenterPosition:";

	private static readonly IntPtr selDrawInBezierPath_RelativeCenterPosition_Handle = Selector.GetHandle("drawInBezierPath:relativeCenterPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_Angle_ = "drawInRect:angle:";

	private static readonly IntPtr selDrawInRect_Angle_Handle = Selector.GetHandle("drawInRect:angle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_RelativeCenterPosition_ = "drawInRect:relativeCenterPosition:";

	private static readonly IntPtr selDrawInRect_RelativeCenterPosition_Handle = Selector.GetHandle("drawInRect:relativeCenterPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetColor_Location_AtIndex_ = "getColor:location:atIndex:";

	private static readonly IntPtr selGetColor_Location_AtIndex_Handle = Selector.GetHandle("getColor:location:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithColors_ = "initWithColors:";

	private static readonly IntPtr selInitWithColors_Handle = Selector.GetHandle("initWithColors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStartingColor_EndingColor_ = "initWithStartingColor:endingColor:";

	private static readonly IntPtr selInitWithStartingColor_EndingColor_Handle = Selector.GetHandle("initWithStartingColor:endingColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterpolatedColorAtLocation_ = "interpolatedColorAtLocation:";

	private static readonly IntPtr selInterpolatedColorAtLocation_Handle = Selector.GetHandle("interpolatedColorAtLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColorStops = "numberOfColorStops";

	private static readonly IntPtr selNumberOfColorStopsHandle = Selector.GetHandle("numberOfColorStops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			}
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColorStopsCount
	{
		[Export("numberOfColorStops")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfColorStopsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfColorStopsHandle);
		}
	}

	public NSGradient(NSColor[] colors, float[] locations)
		: this(colors, locations, NSColorSpace.GenericRGBColorSpace)
	{
	}

	public NSGradient(NSColor[] colors, double[] locations)
		: this(colors, locations, NSColorSpace.GenericRGBColorSpace)
	{
	}

	public unsafe NSGradient(NSColor[] colors, float[] locations, NSColorSpace colorSpace)
	{
		fixed (double* ptr = Array.ConvertAll(locations, (Converter<float, double>)((float a) => a)))
		{
			void* locationPtr = ptr;
			Initialize(colors, locationPtr, colorSpace);
		}
	}

	public unsafe NSGradient(NSColor[] colors, double[] locations, NSColorSpace colorSpace)
		: base(NSObjectFlag.Empty)
	{
		fixed (double* ptr = locations)
		{
			void* locationPtr = ptr;
			Initialize(colors, locationPtr, colorSpace);
		}
	}

	private unsafe void Initialize(NSColor[] colors, void* locationPtr, NSColorSpace colorSpace)
	{
		if (colors == null)
		{
			throw new ArgumentNullException("colors");
		}
		if (locationPtr == null)
		{
			throw new ArgumentNullException("locationPtr");
		}
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		NSArray nSArray = NSArray.FromNSObjects(colors);
		IntPtr arg = new IntPtr(locationPtr);
		if (base.IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithColorsAtLocationsColorSpace, nSArray.Handle, arg, colorSpace.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithColorsAtLocationsColorSpace, nSArray.Handle, arg, colorSpace.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGradient()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSGradient(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithStartingColor:endingColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStartingColor_EndingColor_Handle, startingColor.Handle, endingColor.Handle), "initWithStartingColor:endingColor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStartingColor_EndingColor_Handle, startingColor.Handle, endingColor.Handle), "initWithStartingColor:endingColor:");
		}
	}

	[Export("initWithColors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSGradient(NSColor[] colorArray)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (colorArray == null)
		{
			throw new ArgumentNullException("colorArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(colorArray);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithColors_Handle, nSArray.Handle), "initWithColors:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithColors_Handle, nSArray.Handle), "initWithColors:");
		}
		nSArray.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("drawFromCenter:radius:toCenter:radius:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawFromCenterRadius(CGPoint startCenter, nfloat startRadius, CGPoint endCenter, nfloat endRadius, NSGradientDrawingOptions options)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_nfloat_CGPoint_nfloat_UInt64(base.Handle, selDrawFromCenter_Radius_ToCenter_Radius_Options_Handle, startCenter, startRadius, endCenter, endRadius, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_nfloat_CGPoint_nfloat_UInt64(base.SuperHandle, selDrawFromCenter_Radius_ToCenter_Radius_Options_Handle, startCenter, startRadius, endCenter, endRadius, (ulong)options);
		}
	}

	[Export("drawFromPoint:toPoint:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawFromPoint(CGPoint startingPoint, CGPoint endingPoint, NSGradientDrawingOptions options)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_UInt64(base.Handle, selDrawFromPoint_ToPoint_Options_Handle, startingPoint, endingPoint, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_UInt64(base.SuperHandle, selDrawFromPoint_ToPoint_Options_Handle, startingPoint, endingPoint, (ulong)options);
		}
	}

	[Export("drawInBezierPath:angle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawInBezierPath(NSBezierPath path, nfloat angle)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selDrawInBezierPath_Angle_Handle, path.Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selDrawInBezierPath_Angle_Handle, path.Handle, angle);
		}
	}

	[Export("drawInBezierPath:relativeCenterPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawInBezierPath(NSBezierPath path, CGPoint relativeCenterPosition)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGPoint(base.Handle, selDrawInBezierPath_RelativeCenterPosition_Handle, path.Handle, relativeCenterPosition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGPoint(base.SuperHandle, selDrawInBezierPath_RelativeCenterPosition_Handle, path.Handle, relativeCenterPosition);
		}
	}

	[Export("drawInRect:angle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawInRect(CGRect rect, nfloat angle)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_nfloat(base.Handle, selDrawInRect_Angle_Handle, rect, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_nfloat(base.SuperHandle, selDrawInRect_Angle_Handle, rect, angle);
		}
	}

	[Export("drawInRect:relativeCenterPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawInRect(CGRect rect, CGPoint relativeCenterPosition)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGPoint(base.Handle, selDrawInRect_RelativeCenterPosition_Handle, rect, relativeCenterPosition);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGPoint(base.SuperHandle, selDrawInRect_RelativeCenterPosition_Handle, rect, relativeCenterPosition);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("getColor:location:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetColor(out NSColor color, out nfloat location, nint index)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_ref_IntPtr_out_nfloat_nint(base.Handle, selGetColor_Location_AtIndex_Handle, ref arg, out location, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_ref_IntPtr_out_nfloat_nint(base.SuperHandle, selGetColor_Location_AtIndex_Handle, ref arg, out location, index);
		}
		color = Runtime.GetNSObject<NSColor>(arg);
	}

	[Export("interpolatedColorAtLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor GetInterpolatedColor(nfloat location)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selInterpolatedColorAtLocation_Handle, location));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selInterpolatedColorAtLocation_Handle, location));
	}
}
