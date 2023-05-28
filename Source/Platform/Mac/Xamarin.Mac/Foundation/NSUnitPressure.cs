using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitPressure", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitPressure : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBars = "bars";

	private static readonly IntPtr selBarsHandle = Selector.GetHandle("bars");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGigapascals = "gigapascals";

	private static readonly IntPtr selGigapascalsHandle = Selector.GetHandle("gigapascals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHectopascals = "hectopascals";

	private static readonly IntPtr selHectopascalsHandle = Selector.GetHandle("hectopascals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInchesOfMercury = "inchesOfMercury";

	private static readonly IntPtr selInchesOfMercuryHandle = Selector.GetHandle("inchesOfMercury");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilopascals = "kilopascals";

	private static readonly IntPtr selKilopascalsHandle = Selector.GetHandle("kilopascals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMegapascals = "megapascals";

	private static readonly IntPtr selMegapascalsHandle = Selector.GetHandle("megapascals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMillibars = "millibars";

	private static readonly IntPtr selMillibarsHandle = Selector.GetHandle("millibars");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMillimetersOfMercury = "millimetersOfMercury";

	private static readonly IntPtr selMillimetersOfMercuryHandle = Selector.GetHandle("millimetersOfMercury");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewtonsPerMetersSquared = "newtonsPerMetersSquared";

	private static readonly IntPtr selNewtonsPerMetersSquaredHandle = Selector.GetHandle("newtonsPerMetersSquared");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPoundsForcePerSquareInch = "poundsForcePerSquareInch";

	private static readonly IntPtr selPoundsForcePerSquareInchHandle = Selector.GetHandle("poundsForcePerSquareInch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitPressure");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure Bars
	{
		[Export("bars", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selBarsHandle));
		}
	}

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
	public static NSUnitPressure Gigapascals
	{
		[Export("gigapascals", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selGigapascalsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure Hectopascals
	{
		[Export("hectopascals", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selHectopascalsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure InchesOfMercury
	{
		[Export("inchesOfMercury", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selInchesOfMercuryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure Kilopascals
	{
		[Export("kilopascals", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilopascalsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure Megapascals
	{
		[Export("megapascals", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selMegapascalsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure Millibars
	{
		[Export("millibars", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selMillibarsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure MillimetersOfMercury
	{
		[Export("millimetersOfMercury", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selMillimetersOfMercuryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure NewtonsPerMetersSquared
	{
		[Export("newtonsPerMetersSquared", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selNewtonsPerMetersSquaredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitPressure PoundsForcePerSquareInch
	{
		[Export("poundsForcePerSquareInch", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitPressure>(Messaging.IntPtr_objc_msgSend(class_ptr, selPoundsForcePerSquareInchHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitPressure()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitPressure(NSCoder coder)
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
	protected NSUnitPressure(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitPressure(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitPressure(string symbol, NSUnitConverter converter)
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
