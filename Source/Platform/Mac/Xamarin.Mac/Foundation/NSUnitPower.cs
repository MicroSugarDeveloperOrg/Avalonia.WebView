using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitPower", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitPower : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFemtowatts = "femtowatts";

	private static readonly IntPtr selFemtowattsHandle = Selector.GetHandle("femtowatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGigawatts = "gigawatts";

	private static readonly IntPtr selGigawattsHandle = Selector.GetHandle("gigawatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorsepower = "horsepower";

	private static readonly IntPtr selHorsepowerHandle = Selector.GetHandle("horsepower");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilowatts = "kilowatts";

	private static readonly IntPtr selKilowattsHandle = Selector.GetHandle("kilowatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMegawatts = "megawatts";

	private static readonly IntPtr selMegawattsHandle = Selector.GetHandle("megawatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMicrowatts = "microwatts";

	private static readonly IntPtr selMicrowattsHandle = Selector.GetHandle("microwatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMilliwatts = "milliwatts";

	private static readonly IntPtr selMilliwattsHandle = Selector.GetHandle("milliwatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNanowatts = "nanowatts";

	private static readonly IntPtr selNanowattsHandle = Selector.GetHandle("nanowatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPicowatts = "picowatts";

	private static readonly IntPtr selPicowattsHandle = Selector.GetHandle("picowatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerawatts = "terawatts";

	private static readonly IntPtr selTerawattsHandle = Selector.GetHandle("terawatts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWatts = "watts";

	private static readonly IntPtr selWattsHandle = Selector.GetHandle("watts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitPower");

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
	public static NSUnitPower Femtowatts
	{
		[Export("femtowatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selFemtowattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Gigawatts
	{
		[Export("gigawatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selGigawattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Horsepower
	{
		[Export("horsepower", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selHorsepowerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Kilowatts
	{
		[Export("kilowatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilowattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Megawatts
	{
		[Export("megawatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selMegawattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Microwatts
	{
		[Export("microwatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selMicrowattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Milliwatts
	{
		[Export("milliwatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selMilliwattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Nanowatts
	{
		[Export("nanowatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selNanowattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Picowatts
	{
		[Export("picowatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selPicowattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Terawatts
	{
		[Export("terawatts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selTerawattsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPower Watts
	{
		[Export("watts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPower>(Messaging.IntPtr_objc_msgSend(class_ptr, selWattsHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitPower()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitPower(NSCoder coder)
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
	protected NSUnitPower(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitPower(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitPower(string symbol, NSUnitConverter converter)
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
