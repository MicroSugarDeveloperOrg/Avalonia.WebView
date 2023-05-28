using System;
using System.ComponentModel;
using System.Diagnostics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMultiPolygon", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MKMultiPolygon : MKShape, IMKGeoJsonObject, INativeObject, IDisposable, IMKOverlay, IMKAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingMapRect = "boundingMapRect";

	private static readonly IntPtr selBoundingMapRectHandle = Selector.GetHandle("boundingMapRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanReplaceMapContent = "canReplaceMapContent";

	private static readonly IntPtr selCanReplaceMapContentHandle = Selector.GetHandle("canReplaceMapContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPolygons_ = "initWithPolygons:";

	private static readonly IntPtr selInitWithPolygons_Handle = Selector.GetHandle("initWithPolygons:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsMapRect_ = "intersectsMapRect:";

	private static readonly IntPtr selIntersectsMapRect_Handle = Selector.GetHandle("intersectsMapRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolygons = "polygons";

	private static readonly IntPtr selPolygonsHandle = Selector.GetHandle("polygons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMultiPolygon");

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
	public virtual MKPolygon[] Polygons
	{
		[Export("polygons", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MKPolygon>(Messaging.IntPtr_objc_msgSend(base.Handle, selPolygonsHandle));
			}
			return NSArray.ArrayFromHandle<MKPolygon>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPolygonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMultiPolygon()
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
	protected MKMultiPolygon(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMultiPolygon(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPolygons:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMultiPolygon(MKPolygon[] polygons)
		: base(NSObjectFlag.Empty)
	{
		if (polygons == null)
		{
			throw new ArgumentNullException("polygons");
		}
		NSArray nSArray = NSArray.FromNSObjects(polygons);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPolygons_Handle, nSArray.Handle), "initWithPolygons:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPolygons_Handle, nSArray.Handle), "initWithPolygons:");
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
