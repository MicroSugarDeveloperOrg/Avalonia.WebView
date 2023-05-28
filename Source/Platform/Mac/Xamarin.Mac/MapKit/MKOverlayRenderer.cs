using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKOverlayRenderer", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKOverlayRenderer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDrawMapRect_ZoomScale_ = "canDrawMapRect:zoomScale:";

	private static readonly IntPtr selCanDrawMapRect_ZoomScale_Handle = Selector.GetHandle("canDrawMapRect:zoomScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentScaleFactor = "contentScaleFactor";

	private static readonly IntPtr selContentScaleFactorHandle = Selector.GetHandle("contentScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawMapRect_ZoomScale_InContext_ = "drawMapRect:zoomScale:inContext:";

	private static readonly IntPtr selDrawMapRect_ZoomScale_InContext_Handle = Selector.GetHandle("drawMapRect:zoomScale:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOverlay_ = "initWithOverlay:";

	private static readonly IntPtr selInitWithOverlay_Handle = Selector.GetHandle("initWithOverlay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapPointForPoint_ = "mapPointForPoint:";

	private static readonly IntPtr selMapPointForPoint_Handle = Selector.GetHandle("mapPointForPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapRectForRect_ = "mapRectForRect:";

	private static readonly IntPtr selMapRectForRect_Handle = Selector.GetHandle("mapRectForRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlay = "overlay";

	private static readonly IntPtr selOverlayHandle = Selector.GetHandle("overlay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointForMapPoint_ = "pointForMapPoint:";

	private static readonly IntPtr selPointForMapPoint_Handle = Selector.GetHandle("pointForMapPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForMapRect_ = "rectForMapRect:";

	private static readonly IntPtr selRectForMapRect_Handle = Selector.GetHandle("rectForMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplay = "setNeedsDisplay";

	private static readonly IntPtr selSetNeedsDisplayHandle = Selector.GetHandle("setNeedsDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplayInMapRect_ = "setNeedsDisplayInMapRect:";

	private static readonly IntPtr selSetNeedsDisplayInMapRect_Handle = Selector.GetHandle("setNeedsDisplayInMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeedsDisplayInMapRect_ZoomScale_ = "setNeedsDisplayInMapRect:zoomScale:";

	private static readonly IntPtr selSetNeedsDisplayInMapRect_ZoomScale_Handle = Selector.GetHandle("setNeedsDisplayInMapRect:zoomScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKOverlayRenderer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Alpha
	{
		[Export("alpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
		[Export("setAlpha:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ContentScaleFactor
	{
		[Export("contentScaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selContentScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selContentScaleFactorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMKOverlay Overlay
	{
		[Export("overlay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMKOverlay>(Messaging.IntPtr_objc_msgSend(base.Handle, selOverlayHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMKOverlay>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOverlayHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKOverlayRenderer()
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
	protected MKOverlayRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKOverlayRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithOverlay:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKOverlayRenderer(IMKOverlay overlay)
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

	[Export("canDrawMapRect:zoomScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDrawMapRect(MKMapRect mapRect, nfloat zoomScale)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_MKMapRect_nfloat(base.Handle, selCanDrawMapRect_ZoomScale_Handle, mapRect, zoomScale);
		}
		return Messaging.bool_objc_msgSendSuper_MKMapRect_nfloat(base.SuperHandle, selCanDrawMapRect_ZoomScale_Handle, mapRect, zoomScale);
	}

	[Export("drawMapRect:zoomScale:inContext:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawMapRect(MKMapRect mapRect, nfloat zoomScale, CGContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_MKMapRect_nfloat_IntPtr(base.Handle, selDrawMapRect_ZoomScale_InContext_Handle, mapRect, zoomScale, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_MKMapRect_nfloat_IntPtr(base.SuperHandle, selDrawMapRect_ZoomScale_InContext_Handle, mapRect, zoomScale, context.Handle);
		}
	}

	[Export("mapPointForPoint:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapPoint MapPointForPoint(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.MKMapPoint_objc_msgSend_CGPoint(base.Handle, selMapPointForPoint_Handle, point);
		}
		return Messaging.MKMapPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selMapPointForPoint_Handle, point);
	}

	[Export("mapRectForRect:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapRect MapRectForRect(CGRect rect)
	{
		MKMapRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.MKMapRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selMapRectForRect_Handle, rect);
		}
		else
		{
			Messaging.MKMapRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selMapRectForRect_Handle, rect);
		}
		return retval;
	}

	[Export("pointForMapPoint:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint PointForMapPoint(MKMapPoint mapPoint)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_MKMapPoint(base.Handle, selPointForMapPoint_Handle, mapPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_MKMapPoint(base.SuperHandle, selPointForMapPoint_Handle, mapPoint);
	}

	[Export("rectForMapRect:")]
	[ThreadSafe]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectForMapRect(MKMapRect mapRect)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_MKMapRect(out retval, base.Handle, selRectForMapRect_Handle, mapRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_MKMapRect(out retval, base.SuperHandle, selRectForMapRect_Handle, mapRect);
		}
		return retval;
	}

	[Export("setNeedsDisplay")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplay()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNeedsDisplayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNeedsDisplayHandle);
		}
	}

	[Export("setNeedsDisplayInMapRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplay(MKMapRect mapRect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_MKMapRect(base.Handle, selSetNeedsDisplayInMapRect_Handle, mapRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_MKMapRect(base.SuperHandle, selSetNeedsDisplayInMapRect_Handle, mapRect);
		}
	}

	[Export("setNeedsDisplayInMapRect:zoomScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNeedsDisplay(MKMapRect mapRect, nfloat zoomScale)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_MKMapRect_nfloat(base.Handle, selSetNeedsDisplayInMapRect_ZoomScale_Handle, mapRect, zoomScale);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_MKMapRect_nfloat(base.SuperHandle, selSetNeedsDisplayInMapRect_ZoomScale_Handle, mapRect, zoomScale);
		}
	}
}
