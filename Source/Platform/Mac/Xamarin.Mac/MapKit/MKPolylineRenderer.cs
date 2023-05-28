using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKPolylineRenderer", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKPolylineRenderer : MKOverlayPathRenderer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPolyline_ = "initWithPolyline:";

	private static readonly IntPtr selInitWithPolyline_Handle = Selector.GetHandle("initWithPolyline:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPolyline = "polyline";

	private static readonly IntPtr selPolylineHandle = Selector.GetHandle("polyline");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKPolylineRenderer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKPolyline Polyline
	{
		[Export("polyline")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKPolyline>(Messaging.IntPtr_objc_msgSend(base.Handle, selPolylineHandle));
			}
			return Runtime.GetNSObject<MKPolyline>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPolylineHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKPolylineRenderer()
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
	protected MKPolylineRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKPolylineRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPolyline:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPolylineRenderer(MKPolyline polyline)
		: base(NSObjectFlag.Empty)
	{
		if (polyline == null)
		{
			throw new ArgumentNullException("polyline");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPolyline_Handle, polyline.Handle), "initWithPolyline:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPolyline_Handle, polyline.Handle), "initWithPolyline:");
		}
	}
}
