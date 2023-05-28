using System;
using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKPointAnnotation", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKPointAnnotation : MKShape, IMKGeoJsonObject, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinate = "coordinate";

	private static readonly IntPtr selCoordinateHandle = Selector.GetHandle("coordinate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_ = "initWithCoordinate:";

	private static readonly IntPtr selInitWithCoordinate_Handle = Selector.GetHandle("initWithCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoordinate_Title_Subtitle_ = "initWithCoordinate:title:subtitle:";

	private static readonly IntPtr selInitWithCoordinate_Title_Subtitle_Handle = Selector.GetHandle("initWithCoordinate:title:subtitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCoordinate_ = "setCoordinate:";

	private static readonly IntPtr selSetCoordinate_Handle = Selector.GetHandle("setCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKPointAnnotation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CLLocationCoordinate2D Coordinate
	{
		[Export("coordinate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selCoordinateHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selCoordinateHandle);
		}
		[Export("setCoordinate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CLLocationCoordinate2D(base.Handle, selSetCoordinate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selSetCoordinate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKPointAnnotation()
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
	protected MKPointAnnotation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKPointAnnotation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoordinate:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPointAnnotation(CLLocationCoordinate2D coordinate)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D(base.Handle, selInitWithCoordinate_Handle, coordinate), "initWithCoordinate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D(base.SuperHandle, selInitWithCoordinate_Handle, coordinate), "initWithCoordinate:");
		}
	}

	[Export("initWithCoordinate:title:subtitle:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPointAnnotation(CLLocationCoordinate2D coordinate, string? title, string? subtitle)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(subtitle);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_IntPtr_IntPtr(base.Handle, selInitWithCoordinate_Title_Subtitle_Handle, coordinate, arg, arg2), "initWithCoordinate:title:subtitle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr_IntPtr(base.SuperHandle, selInitWithCoordinate_Title_Subtitle_Handle, coordinate, arg, arg2), "initWithCoordinate:title:subtitle:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}
}
