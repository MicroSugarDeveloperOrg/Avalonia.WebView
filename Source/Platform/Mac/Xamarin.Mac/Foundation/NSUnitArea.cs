using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitArea", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitArea : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcres = "acres";

	private static readonly IntPtr selAcresHandle = Selector.GetHandle("acres");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAres = "ares";

	private static readonly IntPtr selAresHandle = Selector.GetHandle("ares");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHectares = "hectares";

	private static readonly IntPtr selHectaresHandle = Selector.GetHandle("hectares");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareCentimeters = "squareCentimeters";

	private static readonly IntPtr selSquareCentimetersHandle = Selector.GetHandle("squareCentimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareFeet = "squareFeet";

	private static readonly IntPtr selSquareFeetHandle = Selector.GetHandle("squareFeet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareInches = "squareInches";

	private static readonly IntPtr selSquareInchesHandle = Selector.GetHandle("squareInches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareKilometers = "squareKilometers";

	private static readonly IntPtr selSquareKilometersHandle = Selector.GetHandle("squareKilometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareMegameters = "squareMegameters";

	private static readonly IntPtr selSquareMegametersHandle = Selector.GetHandle("squareMegameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareMeters = "squareMeters";

	private static readonly IntPtr selSquareMetersHandle = Selector.GetHandle("squareMeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareMicrometers = "squareMicrometers";

	private static readonly IntPtr selSquareMicrometersHandle = Selector.GetHandle("squareMicrometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareMiles = "squareMiles";

	private static readonly IntPtr selSquareMilesHandle = Selector.GetHandle("squareMiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareMillimeters = "squareMillimeters";

	private static readonly IntPtr selSquareMillimetersHandle = Selector.GetHandle("squareMillimeters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareNanometers = "squareNanometers";

	private static readonly IntPtr selSquareNanometersHandle = Selector.GetHandle("squareNanometers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSquareYards = "squareYards";

	private static readonly IntPtr selSquareYardsHandle = Selector.GetHandle("squareYards");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitArea");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea Acres
	{
		[Export("acres", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selAcresHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea Ares
	{
		[Export("ares", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selAresHandle));
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
	public static NSUnitArea Hectares
	{
		[Export("hectares", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selHectaresHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareCentimeters
	{
		[Export("squareCentimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareCentimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareFeet
	{
		[Export("squareFeet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareFeetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareInches
	{
		[Export("squareInches", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareInchesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareKilometers
	{
		[Export("squareKilometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareKilometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareMegameters
	{
		[Export("squareMegameters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareMegametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareMeters
	{
		[Export("squareMeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareMetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareMicrometers
	{
		[Export("squareMicrometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareMicrometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareMiles
	{
		[Export("squareMiles", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareMilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareMillimeters
	{
		[Export("squareMillimeters", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareMillimetersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareNanometers
	{
		[Export("squareNanometers", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareNanometersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitArea SquareYards
	{
		[Export("squareYards", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitArea>(Messaging.IntPtr_objc_msgSend(class_ptr, selSquareYardsHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitArea()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitArea(NSCoder coder)
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
	protected NSUnitArea(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitArea(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitArea(string symbol, NSUnitConverter converter)
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
