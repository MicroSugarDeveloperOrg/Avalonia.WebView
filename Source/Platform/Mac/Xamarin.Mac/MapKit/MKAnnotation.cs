using System;
using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Protocol]
[Register("MKAnnotation", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public abstract class MKAnnotation : NSObject, IMKAnnotation, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Subtitle
	{
		[Export("subtitle", ArgumentSemantic.Copy)]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MKAnnotation()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKAnnotation(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKAnnotation(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("setCoordinate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCoordinate(CLLocationCoordinate2D value)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
