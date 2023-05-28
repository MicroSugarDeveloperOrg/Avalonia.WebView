using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitMass", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitMass : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCarats = "carats";

	private static readonly IntPtr selCaratsHandle = Selector.GetHandle("carats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCentigrams = "centigrams";

	private static readonly IntPtr selCentigramsHandle = Selector.GetHandle("centigrams");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecigrams = "decigrams";

	private static readonly IntPtr selDecigramsHandle = Selector.GetHandle("decigrams");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrams = "grams";

	private static readonly IntPtr selGramsHandle = Selector.GetHandle("grams");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilograms = "kilograms";

	private static readonly IntPtr selKilogramsHandle = Selector.GetHandle("kilograms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetricTons = "metricTons";

	private static readonly IntPtr selMetricTonsHandle = Selector.GetHandle("metricTons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMicrograms = "micrograms";

	private static readonly IntPtr selMicrogramsHandle = Selector.GetHandle("micrograms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMilligrams = "milligrams";

	private static readonly IntPtr selMilligramsHandle = Selector.GetHandle("milligrams");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNanograms = "nanograms";

	private static readonly IntPtr selNanogramsHandle = Selector.GetHandle("nanograms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOunces = "ounces";

	private static readonly IntPtr selOuncesHandle = Selector.GetHandle("ounces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOuncesTroy = "ouncesTroy";

	private static readonly IntPtr selOuncesTroyHandle = Selector.GetHandle("ouncesTroy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPicograms = "picograms";

	private static readonly IntPtr selPicogramsHandle = Selector.GetHandle("picograms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPoundsMass = "poundsMass";

	private static readonly IntPtr selPoundsMassHandle = Selector.GetHandle("poundsMass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortTons = "shortTons";

	private static readonly IntPtr selShortTonsHandle = Selector.GetHandle("shortTons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSlugs = "slugs";

	private static readonly IntPtr selSlugsHandle = Selector.GetHandle("slugs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStones = "stones";

	private static readonly IntPtr selStonesHandle = Selector.GetHandle("stones");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitMass");

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
	public static NSUnitMass Carats
	{
		[Export("carats", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selCaratsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Centigrams
	{
		[Export("centigrams", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selCentigramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Decigrams
	{
		[Export("decigrams", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selDecigramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Grams
	{
		[Export("grams", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selGramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Kilograms
	{
		[Export("kilograms", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilogramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass MetricTons
	{
		[Export("metricTons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selMetricTonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Micrograms
	{
		[Export("micrograms", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selMicrogramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Milligrams
	{
		[Export("milligrams", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selMilligramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Nanograms
	{
		[Export("nanograms", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selNanogramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Ounces
	{
		[Export("ounces", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selOuncesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass OuncesTroy
	{
		[Export("ouncesTroy", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selOuncesTroyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Picograms
	{
		[Export("picograms", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selPicogramsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Pounds
	{
		[Export("poundsMass", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selPoundsMassHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass ShortTons
	{
		[Export("shortTons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selShortTonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Slugs
	{
		[Export("slugs", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selSlugsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitMass Stones
	{
		[Export("stones", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitMass>(Messaging.IntPtr_objc_msgSend(class_ptr, selStonesHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitMass()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitMass(NSCoder coder)
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
	protected NSUnitMass(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitMass(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitMass(string symbol, NSUnitConverter converter)
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
