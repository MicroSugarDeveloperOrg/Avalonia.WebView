using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMultiPolygonRenderer", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MKMultiPolygonRenderer : MKOverlayPathRenderer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMultiPolygon_ = "initWithMultiPolygon:";

	private static readonly IntPtr selInitWithMultiPolygon_Handle = Selector.GetHandle("initWithMultiPolygon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiPolygon = "multiPolygon";

	private static readonly IntPtr selMultiPolygonHandle = Selector.GetHandle("multiPolygon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMultiPolygonRenderer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMultiPolygon MultiPolygon
	{
		[Export("multiPolygon")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMultiPolygon>(Messaging.IntPtr_objc_msgSend(base.Handle, selMultiPolygonHandle));
			}
			return Runtime.GetNSObject<MKMultiPolygon>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultiPolygonHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMultiPolygonRenderer()
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
	protected MKMultiPolygonRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMultiPolygonRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMultiPolygon:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMultiPolygonRenderer(MKMultiPolygon multiPolygon)
		: base(NSObjectFlag.Empty)
	{
		if (multiPolygon == null)
		{
			throw new ArgumentNullException("multiPolygon");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMultiPolygon_Handle, multiPolygon.Handle), "initWithMultiPolygon:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMultiPolygon_Handle, multiPolygon.Handle), "initWithMultiPolygon:");
		}
	}
}
