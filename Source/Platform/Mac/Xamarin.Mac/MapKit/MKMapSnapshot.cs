using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMapSnapshot", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMapSnapshot : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppearance = "appearance";

	private static readonly IntPtr selAppearanceHandle = Selector.GetHandle("appearance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointForCoordinate_ = "pointForCoordinate:";

	private static readonly IntPtr selPointForCoordinate_Handle = Selector.GetHandle("pointForCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMapSnapshot");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual NSAppearance Appearance
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("appearance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppearanceHandle));
			}
			return Runtime.GetNSObject<NSAppearance>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppearanceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage Image
	{
		[Export("image")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapSnapshot()
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
	protected MKMapSnapshot(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapSnapshot(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pointForCoordinate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint PointForCoordinate(CLLocationCoordinate2D coordinate)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D(base.Handle, selPointForCoordinate_Handle, coordinate);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selPointForCoordinate_Handle, coordinate);
	}
}
