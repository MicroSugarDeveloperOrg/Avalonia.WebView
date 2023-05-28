using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitVolume", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitVolume : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcreFeet = "acreFeet";

	private static readonly IntPtr selAcreFeetHandle = Selector.GetHandle("acreFeet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBushels = "bushels";

	private static readonly IntPtr selBushelsHandle = Selector.GetHandle("bushels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCentiliters = "centiliters";

	private static readonly IntPtr selCentilitersHandle = Selector.GetHandle("centiliters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicCentimeters = "cubicCentimeters";

	private static readonly IntPtr selCubicCentimetersHandle = Selector.GetHandle("cubicCentimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicDecimeters = "cubicDecimeters";

	private static readonly IntPtr selCubicDecimetersHandle = Selector.GetHandle("cubicDecimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicFeet = "cubicFeet";

	private static readonly IntPtr selCubicFeetHandle = Selector.GetHandle("cubicFeet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicInches = "cubicInches";

	private static readonly IntPtr selCubicInchesHandle = Selector.GetHandle("cubicInches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicKilometers = "cubicKilometers";

	private static readonly IntPtr selCubicKilometersHandle = Selector.GetHandle("cubicKilometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicMeters = "cubicMeters";

	private static readonly IntPtr selCubicMetersHandle = Selector.GetHandle("cubicMeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicMiles = "cubicMiles";

	private static readonly IntPtr selCubicMilesHandle = Selector.GetHandle("cubicMiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicMillimeters = "cubicMillimeters";

	private static readonly IntPtr selCubicMillimetersHandle = Selector.GetHandle("cubicMillimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubicYards = "cubicYards";

	private static readonly IntPtr selCubicYardsHandle = Selector.GetHandle("cubicYards");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCups = "cups";

	private static readonly IntPtr selCupsHandle = Selector.GetHandle("cups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeciliters = "deciliters";

	private static readonly IntPtr selDecilitersHandle = Selector.GetHandle("deciliters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFluidOunces = "fluidOunces";

	private static readonly IntPtr selFluidOuncesHandle = Selector.GetHandle("fluidOunces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGallons = "gallons";

	private static readonly IntPtr selGallonsHandle = Selector.GetHandle("gallons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImperialFluidOunces = "imperialFluidOunces";

	private static readonly IntPtr selImperialFluidOuncesHandle = Selector.GetHandle("imperialFluidOunces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImperialGallons = "imperialGallons";

	private static readonly IntPtr selImperialGallonsHandle = Selector.GetHandle("imperialGallons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImperialPints = "imperialPints";

	private static readonly IntPtr selImperialPintsHandle = Selector.GetHandle("imperialPints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImperialQuarts = "imperialQuarts";

	private static readonly IntPtr selImperialQuartsHandle = Selector.GetHandle("imperialQuarts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImperialTablespoons = "imperialTablespoons";

	private static readonly IntPtr selImperialTablespoonsHandle = Selector.GetHandle("imperialTablespoons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImperialTeaspoons = "imperialTeaspoons";

	private static readonly IntPtr selImperialTeaspoonsHandle = Selector.GetHandle("imperialTeaspoons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKiloliters = "kiloliters";

	private static readonly IntPtr selKilolitersHandle = Selector.GetHandle("kiloliters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLiters = "liters";

	private static readonly IntPtr selLitersHandle = Selector.GetHandle("liters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMegaliters = "megaliters";

	private static readonly IntPtr selMegalitersHandle = Selector.GetHandle("megaliters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetricCups = "metricCups";

	private static readonly IntPtr selMetricCupsHandle = Selector.GetHandle("metricCups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMilliliters = "milliliters";

	private static readonly IntPtr selMillilitersHandle = Selector.GetHandle("milliliters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPints = "pints";

	private static readonly IntPtr selPintsHandle = Selector.GetHandle("pints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuarts = "quarts";

	private static readonly IntPtr selQuartsHandle = Selector.GetHandle("quarts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTablespoons = "tablespoons";

	private static readonly IntPtr selTablespoonsHandle = Selector.GetHandle("tablespoons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTeaspoons = "teaspoons";

	private static readonly IntPtr selTeaspoonsHandle = Selector.GetHandle("teaspoons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitVolume");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume AcreFeet
	{
		[Export("acreFeet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selAcreFeetHandle));
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
	public static NSUnitVolume Bushels
	{
		[Export("bushels", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selBushelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Centiliters
	{
		[Export("centiliters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCentilitersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicCentimeters
	{
		[Export("cubicCentimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicCentimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicDecimeters
	{
		[Export("cubicDecimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicDecimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicFeet
	{
		[Export("cubicFeet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicFeetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicInches
	{
		[Export("cubicInches", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicInchesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicKilometers
	{
		[Export("cubicKilometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicKilometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicMeters
	{
		[Export("cubicMeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicMetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicMiles
	{
		[Export("cubicMiles", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicMilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicMillimeters
	{
		[Export("cubicMillimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicMillimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume CubicYards
	{
		[Export("cubicYards", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCubicYardsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Cups
	{
		[Export("cups", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selCupsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Deciliters
	{
		[Export("deciliters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selDecilitersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume FluidOunces
	{
		[Export("fluidOunces", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selFluidOuncesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Gallons
	{
		[Export("gallons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selGallonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume ImperialFluidOunces
	{
		[Export("imperialFluidOunces", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selImperialFluidOuncesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume ImperialGallons
	{
		[Export("imperialGallons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selImperialGallonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume ImperialPints
	{
		[Export("imperialPints", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selImperialPintsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume ImperialQuarts
	{
		[Export("imperialQuarts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selImperialQuartsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume ImperialTablespoons
	{
		[Export("imperialTablespoons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selImperialTablespoonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume ImperialTeaspoons
	{
		[Export("imperialTeaspoons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selImperialTeaspoonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Kiloliters
	{
		[Export("kiloliters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilolitersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Liters
	{
		[Export("liters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selLitersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Megaliters
	{
		[Export("megaliters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selMegalitersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume MetricCups
	{
		[Export("metricCups", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selMetricCupsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Milliliters
	{
		[Export("milliliters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selMillilitersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Pints
	{
		[Export("pints", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selPintsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Quarts
	{
		[Export("quarts", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selQuartsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Tablespoons
	{
		[Export("tablespoons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selTablespoonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitVolume Teaspoons
	{
		[Export("teaspoons", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitVolume>(Messaging.IntPtr_objc_msgSend(class_ptr, selTeaspoonsHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitVolume()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitVolume(NSCoder coder)
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
	protected NSUnitVolume(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitVolume(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitVolume(string symbol, NSUnitConverter converter)
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
