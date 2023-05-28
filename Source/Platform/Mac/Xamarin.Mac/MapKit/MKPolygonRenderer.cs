using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKPolygonRenderer", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKPolygonRenderer : MKOverlayPathRenderer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPolygon_ = "initWithPolygon:";

	private static readonly IntPtr selInitWithPolygon_Handle = Selector.GetHandle("initWithPolygon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolygon = "polygon";

	private static readonly IntPtr selPolygonHandle = Selector.GetHandle("polygon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKPolygonRenderer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKPolygon Polygon
	{
		[Export("polygon")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKPolygon>(Messaging.IntPtr_objc_msgSend(base.Handle, selPolygonHandle));
			}
			return Runtime.GetNSObject<MKPolygon>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPolygonHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKPolygonRenderer()
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
	protected MKPolygonRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKPolygonRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPolygon:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPolygonRenderer(MKPolygon polygon)
		: base(NSObjectFlag.Empty)
	{
		if (polygon == null)
		{
			throw new ArgumentNullException("polygon");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPolygon_Handle, polygon.Handle), "initWithPolygon:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPolygon_Handle, polygon.Handle), "initWithPolygon:");
		}
	}
}
