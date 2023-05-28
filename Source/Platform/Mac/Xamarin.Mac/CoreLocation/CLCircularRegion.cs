using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreLocation;

[Register("CLCircularRegion", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class CLCircularRegion : CLRegion
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenter = "center";

	private static readonly IntPtr selCenterHandle = Selector.GetHandle("center");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsCoordinate_ = "containsCoordinate:";

	private static readonly IntPtr selContainsCoordinate_Handle = Selector.GetHandle("containsCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCenter_Radius_Identifier_ = "initWithCenter:radius:identifier:";

	private static readonly IntPtr selInitWithCenter_Radius_Identifier_Handle = Selector.GetHandle("initWithCenter:radius:identifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadius = "radius";

	private static readonly IntPtr selRadiusHandle = Selector.GetHandle("radius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CLCircularRegion");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CLLocationCoordinate2D Center
	{
		[Export("center")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCenterHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCenterHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual double Radius
	{
		[Export("radius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRadiusHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRadiusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CLCircularRegion(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CLCircularRegion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CLCircularRegion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCenter:radius:identifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CLCircularRegion(CLLocationCoordinate2D center, double radius, string identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_IntPtr(base.Handle, selInitWithCenter_Radius_Identifier_Handle, center, radius, arg), "initWithCenter:radius:identifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_IntPtr(base.SuperHandle, selInitWithCenter_Radius_Identifier_Handle, center, radius, arg), "initWithCenter:radius:identifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("containsCoordinate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsCoordinate(CLLocationCoordinate2D coordinate)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CLLocationCoordinate2D(base.Handle, selContainsCoordinate_Handle, coordinate);
		}
		return Messaging.bool_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selContainsCoordinate_Handle, coordinate);
	}
}
