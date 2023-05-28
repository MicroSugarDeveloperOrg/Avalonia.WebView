using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMultiPolylineRenderer", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MKMultiPolylineRenderer : MKOverlayPathRenderer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMultiPolyline_ = "initWithMultiPolyline:";

	private static readonly IntPtr selInitWithMultiPolyline_Handle = Selector.GetHandle("initWithMultiPolyline:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiPolyline = "multiPolyline";

	private static readonly IntPtr selMultiPolylineHandle = Selector.GetHandle("multiPolyline");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMultiPolylineRenderer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMultiPolyline MultiPolyline
	{
		[Export("multiPolyline")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMultiPolyline>(Messaging.IntPtr_objc_msgSend(base.Handle, selMultiPolylineHandle));
			}
			return Runtime.GetNSObject<MKMultiPolyline>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultiPolylineHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMultiPolylineRenderer()
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
	protected MKMultiPolylineRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMultiPolylineRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMultiPolyline:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMultiPolylineRenderer(MKMultiPolyline multiPolyline)
		: base(NSObjectFlag.Empty)
	{
		if (multiPolyline == null)
		{
			throw new ArgumentNullException("multiPolyline");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMultiPolyline_Handle, multiPolyline.Handle), "initWithMultiPolyline:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMultiPolyline_Handle, multiPolyline.Handle), "initWithMultiPolyline:");
		}
	}
}
