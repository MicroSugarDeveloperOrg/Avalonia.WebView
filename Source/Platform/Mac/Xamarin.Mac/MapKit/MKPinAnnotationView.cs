using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKPinAnnotationView", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKPinAnnotationView : MKAnnotationView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimatesDrop = "animatesDrop";

	private static readonly IntPtr selAnimatesDropHandle = Selector.GetHandle("animatesDrop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGreenPinColor = "greenPinColor";

	private static readonly IntPtr selGreenPinColorHandle = Selector.GetHandle("greenPinColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAnnotation_ReuseIdentifier_ = "initWithAnnotation:reuseIdentifier:";

	private static readonly IntPtr selInitWithAnnotation_ReuseIdentifier_Handle = Selector.GetHandle("initWithAnnotation:reuseIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPinColor = "pinColor";

	private static readonly IntPtr selPinColorHandle = Selector.GetHandle("pinColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPinTintColor = "pinTintColor";

	private static readonly IntPtr selPinTintColorHandle = Selector.GetHandle("pinTintColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPurplePinColor = "purplePinColor";

	private static readonly IntPtr selPurplePinColorHandle = Selector.GetHandle("purplePinColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedPinColor = "redPinColor";

	private static readonly IntPtr selRedPinColorHandle = Selector.GetHandle("redPinColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimatesDrop_ = "setAnimatesDrop:";

	private static readonly IntPtr selSetAnimatesDrop_Handle = Selector.GetHandle("setAnimatesDrop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPinColor_ = "setPinColor:";

	private static readonly IntPtr selSetPinColor_Handle = Selector.GetHandle("setPinColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPinTintColor_ = "setPinTintColor:";

	private static readonly IntPtr selSetPinTintColor_Handle = Selector.GetHandle("setPinTintColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKPinAnnotationView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AnimatesDrop
	{
		[Export("animatesDrop")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesDropHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesDropHandle);
		}
		[Export("setAnimatesDrop:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimatesDrop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimatesDrop_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSColor GreenPinColor
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("greenPinColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selGreenPinColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'PinTintColor' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'PinTintColor' instead.")]
	public virtual MKPinAnnotationColor PinColor
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'PinTintColor' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'PinTintColor' instead.")]
		[Export("pinColor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKPinAnnotationColor)Messaging.UInt64_objc_msgSend(base.Handle, selPinColorHandle);
			}
			return (MKPinAnnotationColor)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPinColorHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'PinTintColor' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'PinTintColor' instead.")]
		[Export("setPinColor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPinColor_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPinColor_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSColor? PinTintColor
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("pinTintColor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selPinTintColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPinTintColorHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setPinTintColor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPinTintColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPinTintColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSColor PurplePinColor
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("purplePinColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selPurplePinColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSColor RedPinColor
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("redPinColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selRedPinColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MKPinAnnotationView(NSCoder coder)
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
	protected MKPinAnnotationView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKPinAnnotationView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPinAnnotationView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
	}

	[Export("initWithAnnotation:reuseIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKPinAnnotationView(IMKAnnotation? annotation, string? reuseIdentifier)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(reuseIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAnnotation_ReuseIdentifier_Handle, annotation?.Handle ?? IntPtr.Zero, arg), "initWithAnnotation:reuseIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAnnotation_ReuseIdentifier_Handle, annotation?.Handle ?? IntPtr.Zero, arg), "initWithAnnotation:reuseIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}
}
