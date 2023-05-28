using System;
using System.ComponentModel;
using System.Diagnostics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Protocol]
[Register("MKOverlay", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public abstract class MKOverlay : MKAnnotation, IMKOverlay, INativeObject, IDisposable, IMKAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract MKMapRect BoundingMapRect
	{
		[Export("boundingMapRect")]
		get;
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
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MKOverlay()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKOverlay(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKOverlay(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("intersectsMapRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(MKMapRect rect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
