using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKOverlayPathRenderer", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKOverlayPathRenderer : MKOverlayRenderer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyFillPropertiesToContext_AtZoomScale_ = "applyFillPropertiesToContext:atZoomScale:";

	private static readonly IntPtr selApplyFillPropertiesToContext_AtZoomScale_Handle = Selector.GetHandle("applyFillPropertiesToContext:atZoomScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyStrokePropertiesToContext_AtZoomScale_ = "applyStrokePropertiesToContext:atZoomScale:";

	private static readonly IntPtr selApplyStrokePropertiesToContext_AtZoomScale_Handle = Selector.GetHandle("applyStrokePropertiesToContext:atZoomScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreatePath = "createPath";

	private static readonly IntPtr selCreatePathHandle = Selector.GetHandle("createPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillColor = "fillColor";

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillPath_InContext_ = "fillPath:inContext:";

	private static readonly IntPtr selFillPath_InContext_Handle = Selector.GetHandle("fillPath:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOverlay_ = "initWithOverlay:";

	private static readonly IntPtr selInitWithOverlay_Handle = Selector.GetHandle("initWithOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidatePath = "invalidatePath";

	private static readonly IntPtr selInvalidatePathHandle = Selector.GetHandle("invalidatePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineCap = "lineCap";

	private static readonly IntPtr selLineCapHandle = Selector.GetHandle("lineCap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineDashPattern = "lineDashPattern";

	private static readonly IntPtr selLineDashPatternHandle = Selector.GetHandle("lineDashPattern");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineDashPhase = "lineDashPhase";

	private static readonly IntPtr selLineDashPhaseHandle = Selector.GetHandle("lineDashPhase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineJoin = "lineJoin";

	private static readonly IntPtr selLineJoinHandle = Selector.GetHandle("lineJoin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineWidth = "lineWidth";

	private static readonly IntPtr selLineWidthHandle = Selector.GetHandle("lineWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiterLimit = "miterLimit";

	private static readonly IntPtr selMiterLimitHandle = Selector.GetHandle("miterLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillColor_ = "setFillColor:";

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineCap_ = "setLineCap:";

	private static readonly IntPtr selSetLineCap_Handle = Selector.GetHandle("setLineCap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineDashPattern_ = "setLineDashPattern:";

	private static readonly IntPtr selSetLineDashPattern_Handle = Selector.GetHandle("setLineDashPattern:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineDashPhase_ = "setLineDashPhase:";

	private static readonly IntPtr selSetLineDashPhase_Handle = Selector.GetHandle("setLineDashPhase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineJoin_ = "setLineJoin:";

	private static readonly IntPtr selSetLineJoin_Handle = Selector.GetHandle("setLineJoin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineWidth_ = "setLineWidth:";

	private static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle("setLineWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMiterLimit_ = "setMiterLimit:";

	private static readonly IntPtr selSetMiterLimit_Handle = Selector.GetHandle("setMiterLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPath_ = "setPath:";

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldRasterize_ = "setShouldRasterize:";

	private static readonly IntPtr selSetShouldRasterize_Handle = Selector.GetHandle("setShouldRasterize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrokeColor_ = "setStrokeColor:";

	private static readonly IntPtr selSetStrokeColor_Handle = Selector.GetHandle("setStrokeColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldRasterize = "shouldRasterize";

	private static readonly IntPtr selShouldRasterizeHandle = Selector.GetHandle("shouldRasterize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeColor = "strokeColor";

	private static readonly IntPtr selStrokeColorHandle = Selector.GetHandle("strokeColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokePath_InContext_ = "strokePath:inContext:";

	private static readonly IntPtr selStrokePath_InContext_Handle = Selector.GetHandle("strokePath:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKOverlayPathRenderer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor? FillColor
	{
		[Export("fillColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle));
		}
		[Export("setFillColor:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGLineCap LineCap
	{
		[Export("lineCap")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CGLineCap)Messaging.int_objc_msgSend(base.Handle, selLineCapHandle);
			}
			return (CGLineCap)Messaging.int_objc_msgSendSuper(base.SuperHandle, selLineCapHandle);
		}
		[Export("setLineCap:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLineCap_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLineCap_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? LineDashPattern
	{
		[Export("lineDashPattern", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selLineDashPatternHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLineDashPatternHandle));
		}
		[Export("setLineDashPattern:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLineDashPattern_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLineDashPattern_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LineDashPhase
	{
		[Export("lineDashPhase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineDashPhaseHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineDashPhaseHandle);
		}
		[Export("setLineDashPhase:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineDashPhase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineDashPhase_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGLineJoin LineJoin
	{
		[Export("lineJoin")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CGLineJoin)Messaging.int_objc_msgSend(base.Handle, selLineJoinHandle);
			}
			return (CGLineJoin)Messaging.int_objc_msgSendSuper(base.SuperHandle, selLineJoinHandle);
		}
		[Export("setLineJoin:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLineJoin_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLineJoin_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LineWidth
	{
		[Export("lineWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineWidthHandle);
		}
		[Export("setLineWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MiterLimit
	{
		[Export("miterLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMiterLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMiterLimitHandle);
		}
		[Export("setMiterLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMiterLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMiterLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPath? Path
	{
		[Export("path")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGPath(intPtr);
		}
		[Export("setPath:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool ShouldRasterize
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("shouldRasterize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldRasterizeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldRasterizeHandle);
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setShouldRasterize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldRasterize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldRasterize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor? StrokeColor
	{
		[Export("strokeColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selStrokeColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStrokeColorHandle));
		}
		[Export("setStrokeColor:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStrokeColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStrokeColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKOverlayPathRenderer()
		: base(NSObjectFlag.Empty)
	{
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKOverlayPathRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKOverlayPathRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithOverlay:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKOverlayPathRenderer(IMKOverlay overlay)
		: base(NSObjectFlag.Empty)
	{
		if (overlay == null)
		{
			throw new ArgumentNullException("overlay");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithOverlay_Handle, overlay.Handle), "initWithOverlay:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithOverlay_Handle, overlay.Handle), "initWithOverlay:");
		}
	}

	[Export("applyFillPropertiesToContext:atZoomScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyFillPropertiesToContext(CGContext context, nfloat zoomScale)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selApplyFillPropertiesToContext_AtZoomScale_Handle, context.Handle, zoomScale);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selApplyFillPropertiesToContext_AtZoomScale_Handle, context.Handle, zoomScale);
		}
	}

	[Export("applyStrokePropertiesToContext:atZoomScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyStrokePropertiesToContext(CGContext context, nfloat zoomScale)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selApplyStrokePropertiesToContext_AtZoomScale_Handle, context.Handle, zoomScale);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selApplyStrokePropertiesToContext_AtZoomScale_Handle, context.Handle, zoomScale);
		}
	}

	[Export("createPath")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CreatePath()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCreatePathHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCreatePathHandle);
		}
	}

	[Export("fillPath:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FillPath(CGPath path, CGContext context)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFillPath_InContext_Handle, path.Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFillPath_InContext_Handle, path.Handle, context.Handle);
		}
	}

	[Export("invalidatePath")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidatePath()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidatePathHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidatePathHandle);
		}
	}

	[Export("strokePath:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StrokePath(CGPath path, CGContext context)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStrokePath_InContext_Handle, path.Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStrokePath_InContext_Handle, path.Handle, context.Handle);
		}
	}
}
