using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitSpeed", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitSpeed : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilometersPerHour = "kilometersPerHour";

	private static readonly IntPtr selKilometersPerHourHandle = Selector.GetHandle("kilometersPerHour");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnots = "knots";

	private static readonly IntPtr selKnotsHandle = Selector.GetHandle("knots");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetersPerSecond = "metersPerSecond";

	private static readonly IntPtr selMetersPerSecondHandle = Selector.GetHandle("metersPerSecond");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMilesPerHour = "milesPerHour";

	private static readonly IntPtr selMilesPerHourHandle = Selector.GetHandle("milesPerHour");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitSpeed");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSDimension BaseUnit
	{
		[Export("baseUnit")]
		get
		{
			return Runtime.GetNSObject<NSDimension>(Messaging.IntPtr_objc_msgSend(class_ptr, selBaseUnitHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitSpeed KilometersPerHour
	{
		[Export("kilometersPerHour", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitSpeed>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilometersPerHourHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitSpeed Knots
	{
		[Export("knots", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitSpeed>(Messaging.IntPtr_objc_msgSend(class_ptr, selKnotsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitSpeed MetersPerSecond
	{
		[Export("metersPerSecond", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitSpeed>(Messaging.IntPtr_objc_msgSend(class_ptr, selMetersPerSecondHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitSpeed MilesPerHour
	{
		[Export("milesPerHour", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitSpeed>(Messaging.IntPtr_objc_msgSend(class_ptr, selMilesPerHourHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitSpeed()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitSpeed(NSCoder coder)
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
	protected NSUnitSpeed(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitSpeed(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitSpeed(string symbol, NSUnitConverter converter)
		: base(NSObjectFlag.Empty)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		if (converter == null)
		{
			throw new ArgumentNullException("converter");
		}
		IntPtr arg = NSString.CreateNative(symbol);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSymbol_Converter_Handle, arg, converter.Handle), "initWithSymbol:converter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSymbol_Converter_Handle, arg, converter.Handle), "initWithSymbol:converter:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
