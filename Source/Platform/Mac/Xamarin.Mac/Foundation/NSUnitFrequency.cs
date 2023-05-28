using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitFrequency", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitFrequency : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnit = "baseUnit";

	private static readonly IntPtr selBaseUnitHandle = Selector.GetHandle("baseUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFramesPerSecond = "framesPerSecond";

	private static readonly IntPtr selFramesPerSecondHandle = Selector.GetHandle("framesPerSecond");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGigahertz = "gigahertz";

	private static readonly IntPtr selGigahertzHandle = Selector.GetHandle("gigahertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHertz = "hertz";

	private static readonly IntPtr selHertzHandle = Selector.GetHandle("hertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilohertz = "kilohertz";

	private static readonly IntPtr selKilohertzHandle = Selector.GetHandle("kilohertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMegahertz = "megahertz";

	private static readonly IntPtr selMegahertzHandle = Selector.GetHandle("megahertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMicrohertz = "microhertz";

	private static readonly IntPtr selMicrohertzHandle = Selector.GetHandle("microhertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMillihertz = "millihertz";

	private static readonly IntPtr selMillihertzHandle = Selector.GetHandle("millihertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNanohertz = "nanohertz";

	private static readonly IntPtr selNanohertzHandle = Selector.GetHandle("nanohertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerahertz = "terahertz";

	private static readonly IntPtr selTerahertzHandle = Selector.GetHandle("terahertz");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitFrequency");

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
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSUnitFrequency FramesPerSecond
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("framesPerSecond", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selFramesPerSecondHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Gigahertz
	{
		[Export("gigahertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selGigahertzHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Hertz
	{
		[Export("hertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selHertzHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Kilohertz
	{
		[Export("kilohertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilohertzHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Megahertz
	{
		[Export("megahertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selMegahertzHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Microhertz
	{
		[Export("microhertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selMicrohertzHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Millihertz
	{
		[Export("millihertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selMillihertzHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Nanohertz
	{
		[Export("nanohertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selNanohertzHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitFrequency Terahertz
	{
		[Export("terahertz", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitFrequency>(Messaging.IntPtr_objc_msgSend(class_ptr, selTerahertzHandle));
		}
	}

	[Obsolete("Use .ctor(string, NSUnitConverter) or any of the static properties.")]
	public NSUnitFrequency()
		: base(NSObjectFlag.Empty)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitFrequency(NSCoder coder)
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
	protected NSUnitFrequency(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitFrequency(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitFrequency(string symbol, NSUnitConverter converter)
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
