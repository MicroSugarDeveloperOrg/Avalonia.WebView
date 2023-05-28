using System;
using System.ComponentModel;
using System.Diagnostics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMultiPolyline", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MKMultiPolyline : MKShape, IMKGeoJsonObject, INativeObject, IDisposable, IMKOverlay, IMKAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingMapRect = "boundingMapRect";

	private static readonly IntPtr selBoundingMapRectHandle = Selector.GetHandle("boundingMapRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanReplaceMapContent = "canReplaceMapContent";

	private static readonly IntPtr selCanReplaceMapContentHandle = Selector.GetHandle("canReplaceMapContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPolylines_ = "initWithPolylines:";

	private static readonly IntPtr selInitWithPolylines_Handle = Selector.GetHandle("initWithPolylines:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsMapRect_ = "intersectsMapRect:";

	private static readonly IntPtr selIntersectsMapRect_Handle = Selector.GetHandle("intersectsMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolylines = "polylines";

	private static readonly IntPtr selPolylinesHandle = Selector.GetHandle("polylines");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMultiPolyline");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual MKMapRect BoundingMapRect
	{
		[Export("boundingMapRect")]
		get
		{
			MKMapRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKMapRect_objc_msgSend_stret(out retval, base.Handle, selBoundingMapRectHandle);
			}
			else
			{
				Messaging.MKMapRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingMapRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool CanReplaceMapContent
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("canReplaceMapContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanReplaceMapContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanReplaceMapContentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKPolyline[] Polylines
	{
		[Export("polylines", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MKPolyline>(Messaging.IntPtr_objc_msgSend(base.Handle, selPolylinesHandle));
			}
			return NSArray.ArrayFromHandle<MKPolyline>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPolylinesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMultiPolyline()
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
	protected MKMultiPolyline(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMultiPolyline(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPolylines:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMultiPolyline(MKPolyline[] polylines)
		: base(NSObjectFlag.Empty)
	{
		if (polylines == null)
		{
			throw new ArgumentNullException("polylines");
		}
		NSArray nSArray = NSArray.FromNSObjects(polylines);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPolylines_Handle, nSArray.Handle), "initWithPolylines:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPolylines_Handle, nSArray.Handle), "initWithPolylines:");
		}
		nSArray.Dispose();
	}

	[Export("intersectsMapRect:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(MKMapRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_MKMapRect(base.Handle, selIntersectsMapRect_Handle, rect);
		}
		return Messaging.bool_objc_msgSendSuper_MKMapRect(base.SuperHandle, selIntersectsMapRect_Handle, rect);
	}
}
