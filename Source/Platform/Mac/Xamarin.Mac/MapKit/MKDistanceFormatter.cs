using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKDistanceFormatter", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKDistanceFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistanceFromString_ = "distanceFromString:";

	private static readonly IntPtr selDistanceFromString_Handle = Selector.GetHandle("distanceFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocale_ = "setLocale:";

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnitStyle_ = "setUnitStyle:";

	private static readonly IntPtr selSetUnitStyle_Handle = Selector.GetHandle("setUnitStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnits_ = "setUnits:";

	private static readonly IntPtr selSetUnits_Handle = Selector.GetHandle("setUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromDistance_ = "stringFromDistance:";

	private static readonly IntPtr selStringFromDistance_Handle = Selector.GetHandle("stringFromDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnitStyle = "unitStyle";

	private static readonly IntPtr selUnitStyleHandle = Selector.GetHandle("unitStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnits = "units";

	private static readonly IntPtr selUnitsHandle = Selector.GetHandle("units");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKDistanceFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale Locale
	{
		[Export("locale", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle));
			}
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle));
		}
		[Export("setLocale:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocale_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocale_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKDistanceFormatterUnitStyle UnitStyle
	{
		[Export("unitStyle", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKDistanceFormatterUnitStyle)Messaging.UInt64_objc_msgSend(base.Handle, selUnitStyleHandle);
			}
			return (MKDistanceFormatterUnitStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUnitStyleHandle);
		}
		[Export("setUnitStyle:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetUnitStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetUnitStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKDistanceFormatterUnits Units
	{
		[Export("units", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKDistanceFormatterUnits)Messaging.UInt64_objc_msgSend(base.Handle, selUnitsHandle);
			}
			return (MKDistanceFormatterUnits)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUnitsHandle);
		}
		[Export("setUnits:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetUnits_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetUnits_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKDistanceFormatter()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MKDistanceFormatter(NSCoder coder)
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
	protected MKDistanceFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKDistanceFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("distanceFromString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DistanceFromString(string distance)
	{
		if (distance == null)
		{
			throw new ArgumentNullException("distance");
		}
		IntPtr arg = NSString.CreateNative(distance);
		double result = ((!base.IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDistanceFromString_Handle, arg) : Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDistanceFromString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringFromDistance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromDistance(double distance)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selStringFromDistance_Handle, distance));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selStringFromDistance_Handle, distance));
	}
}
