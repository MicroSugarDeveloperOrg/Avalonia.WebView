using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitLength", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitLength : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAstronomicalUnits = "astronomicalUnits";

	private static readonly IntPtr selAstronomicalUnitsHandle = Selector.GetHandle("astronomicalUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCentimeters = "centimeters";

	private static readonly IntPtr selCentimetersHandle = Selector.GetHandle("centimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecameters = "decameters";

	private static readonly IntPtr selDecametersHandle = Selector.GetHandle("decameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimeters = "decimeters";

	private static readonly IntPtr selDecimetersHandle = Selector.GetHandle("decimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFathoms = "fathoms";

	private static readonly IntPtr selFathomsHandle = Selector.GetHandle("fathoms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeet = "feet";

	private static readonly IntPtr selFeetHandle = Selector.GetHandle("feet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFurlongs = "furlongs";

	private static readonly IntPtr selFurlongsHandle = Selector.GetHandle("furlongs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHectometers = "hectometers";

	private static readonly IntPtr selHectometersHandle = Selector.GetHandle("hectometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInches = "inches";

	private static readonly IntPtr selInchesHandle = Selector.GetHandle("inches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilometers = "kilometers";

	private static readonly IntPtr selKilometersHandle = Selector.GetHandle("kilometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightyears = "lightyears";

	private static readonly IntPtr selLightyearsHandle = Selector.GetHandle("lightyears");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMegameters = "megameters";

	private static readonly IntPtr selMegametersHandle = Selector.GetHandle("megameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeters = "meters";

	private static readonly IntPtr selMetersHandle = Selector.GetHandle("meters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMicrometers = "micrometers";

	private static readonly IntPtr selMicrometersHandle = Selector.GetHandle("micrometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiles = "miles";

	private static readonly IntPtr selMilesHandle = Selector.GetHandle("miles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMillimeters = "millimeters";

	private static readonly IntPtr selMillimetersHandle = Selector.GetHandle("millimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNanometers = "nanometers";

	private static readonly IntPtr selNanometersHandle = Selector.GetHandle("nanometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNauticalMiles = "nauticalMiles";

	private static readonly IntPtr selNauticalMilesHandle = Selector.GetHandle("nauticalMiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParsecs = "parsecs";

	private static readonly IntPtr selParsecsHandle = Selector.GetHandle("parsecs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPicometers = "picometers";

	private static readonly IntPtr selPicometersHandle = Selector.GetHandle("picometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScandinavianMiles = "scandinavianMiles";

	private static readonly IntPtr selScandinavianMilesHandle = Selector.GetHandle("scandinavianMiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYards = "yards";

	private static readonly IntPtr selYardsHandle = Selector.GetHandle("yards");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitLength");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength AstronomicalUnits
	{
		[Export("astronomicalUnits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selAstronomicalUnitsHandle));
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
	public static NSUnitLength Centimeters
	{
		[Export("centimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selCentimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Decameters
	{
		[Export("decameters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selDecametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Decimeters
	{
		[Export("decimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selDecimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Fathoms
	{
		[Export("fathoms", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selFathomsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Feet
	{
		[Export("feet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selFeetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Furlongs
	{
		[Export("furlongs", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selFurlongsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Hectometers
	{
		[Export("hectometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selHectometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Inches
	{
		[Export("inches", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selInchesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Kilometers
	{
		[Export("kilometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Lightyears
	{
		[Export("lightyears", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selLightyearsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Megameters
	{
		[Export("megameters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selMegametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Meters
	{
		[Export("meters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selMetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Micrometers
	{
		[Export("micrometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selMicrometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Miles
	{
		[Export("miles", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selMilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Millimeters
	{
		[Export("millimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selMillimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Nanometers
	{
		[Export("nanometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selNanometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength NauticalMiles
	{
		[Export("nauticalMiles", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selNauticalMilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Parsecs
	{
		[Export("parsecs", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selParsecsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Picometers
	{
		[Export("picometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selPicometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength ScandinavianMiles
	{
		[Export("scandinavianMiles", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selScandinavianMilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitLength Yards
	{
		[Export("yards", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitLength>(Messaging.IntPtr_objc_msgSend(class_ptr, selYardsHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitLength()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitLength(NSCoder coder)
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
	protected NSUnitLength(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitLength(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitLength(string symbol, NSUnitConverter converter)
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
