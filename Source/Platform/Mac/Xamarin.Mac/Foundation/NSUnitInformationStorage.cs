using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitInformationStorage", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSUnitInformationStorage : NSDimension, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBits = "bits";

	private static readonly IntPtr selBitsHandle = Selector.GetHandle("bits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytes = "bytes";

	private static readonly IntPtr selBytesHandle = Selector.GetHandle("bytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExabits = "exabits";

	private static readonly IntPtr selExabitsHandle = Selector.GetHandle("exabits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExabytes = "exabytes";

	private static readonly IntPtr selExabytesHandle = Selector.GetHandle("exabytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExbibits = "exbibits";

	private static readonly IntPtr selExbibitsHandle = Selector.GetHandle("exbibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExbibytes = "exbibytes";

	private static readonly IntPtr selExbibytesHandle = Selector.GetHandle("exbibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGibibits = "gibibits";

	private static readonly IntPtr selGibibitsHandle = Selector.GetHandle("gibibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGibibytes = "gibibytes";

	private static readonly IntPtr selGibibytesHandle = Selector.GetHandle("gibibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGigabits = "gigabits";

	private static readonly IntPtr selGigabitsHandle = Selector.GetHandle("gigabits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGigabytes = "gigabytes";

	private static readonly IntPtr selGigabytesHandle = Selector.GetHandle("gigabytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_ = "initWithSymbol:";

	private static readonly IntPtr selInitWithSymbol_Handle = Selector.GetHandle("initWithSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSymbol_Converter_ = "initWithSymbol:converter:";

	private static readonly IntPtr selInitWithSymbol_Converter_Handle = Selector.GetHandle("initWithSymbol:converter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKibibits = "kibibits";

	private static readonly IntPtr selKibibitsHandle = Selector.GetHandle("kibibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKibibytes = "kibibytes";

	private static readonly IntPtr selKibibytesHandle = Selector.GetHandle("kibibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilobits = "kilobits";

	private static readonly IntPtr selKilobitsHandle = Selector.GetHandle("kilobits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKilobytes = "kilobytes";

	private static readonly IntPtr selKilobytesHandle = Selector.GetHandle("kilobytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMebibits = "mebibits";

	private static readonly IntPtr selMebibitsHandle = Selector.GetHandle("mebibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMebibytes = "mebibytes";

	private static readonly IntPtr selMebibytesHandle = Selector.GetHandle("mebibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMegabits = "megabits";

	private static readonly IntPtr selMegabitsHandle = Selector.GetHandle("megabits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMegabytes = "megabytes";

	private static readonly IntPtr selMegabytesHandle = Selector.GetHandle("megabytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNibbles = "nibbles";

	private static readonly IntPtr selNibblesHandle = Selector.GetHandle("nibbles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPebibits = "pebibits";

	private static readonly IntPtr selPebibitsHandle = Selector.GetHandle("pebibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPebibytes = "pebibytes";

	private static readonly IntPtr selPebibytesHandle = Selector.GetHandle("pebibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPetabits = "petabits";

	private static readonly IntPtr selPetabitsHandle = Selector.GetHandle("petabits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPetabytes = "petabytes";

	private static readonly IntPtr selPetabytesHandle = Selector.GetHandle("petabytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTebibits = "tebibits";

	private static readonly IntPtr selTebibitsHandle = Selector.GetHandle("tebibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTebibytes = "tebibytes";

	private static readonly IntPtr selTebibytesHandle = Selector.GetHandle("tebibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerabits = "terabits";

	private static readonly IntPtr selTerabitsHandle = Selector.GetHandle("terabits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTerabytes = "terabytes";

	private static readonly IntPtr selTerabytesHandle = Selector.GetHandle("terabytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYobibits = "yobibits";

	private static readonly IntPtr selYobibitsHandle = Selector.GetHandle("yobibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYobibytes = "yobibytes";

	private static readonly IntPtr selYobibytesHandle = Selector.GetHandle("yobibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYottabits = "yottabits";

	private static readonly IntPtr selYottabitsHandle = Selector.GetHandle("yottabits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYottabytes = "yottabytes";

	private static readonly IntPtr selYottabytesHandle = Selector.GetHandle("yottabytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZebibits = "zebibits";

	private static readonly IntPtr selZebibitsHandle = Selector.GetHandle("zebibits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZebibytes = "zebibytes";

	private static readonly IntPtr selZebibytesHandle = Selector.GetHandle("zebibytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZettabits = "zettabits";

	private static readonly IntPtr selZettabitsHandle = Selector.GetHandle("zettabits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZettabytes = "zettabytes";

	private static readonly IntPtr selZettabytesHandle = Selector.GetHandle("zettabytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitInformationStorage");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Bits
	{
		[Export("bits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selBitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Bytes
	{
		[Export("bytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selBytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Exabits
	{
		[Export("exabits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selExabitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Exabytes
	{
		[Export("exabytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selExabytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Exbibits
	{
		[Export("exbibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selExbibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Exbibytes
	{
		[Export("exbibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selExbibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Gibibits
	{
		[Export("gibibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selGibibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Gibibytes
	{
		[Export("gibibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selGibibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Gigabits
	{
		[Export("gigabits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selGigabitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Gigabytes
	{
		[Export("gigabytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selGigabytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Kibibits
	{
		[Export("kibibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selKibibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Kibibytes
	{
		[Export("kibibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selKibibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Kilobits
	{
		[Export("kilobits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilobitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Kilobytes
	{
		[Export("kilobytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selKilobytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Mebibits
	{
		[Export("mebibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selMebibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Mebibytes
	{
		[Export("mebibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selMebibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Megabits
	{
		[Export("megabits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selMegabitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Megabytes
	{
		[Export("megabytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selMegabytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Nibbles
	{
		[Export("nibbles", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selNibblesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Pebibits
	{
		[Export("pebibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selPebibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Pebibytes
	{
		[Export("pebibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selPebibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Petabits
	{
		[Export("petabits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selPetabitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Petabytes
	{
		[Export("petabytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selPetabytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Tebibits
	{
		[Export("tebibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selTebibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Tebibytes
	{
		[Export("tebibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selTebibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Terabits
	{
		[Export("terabits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selTerabitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Terabytes
	{
		[Export("terabytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selTerabytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Yobibits
	{
		[Export("yobibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selYobibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Yobibytes
	{
		[Export("yobibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selYobibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Yottabits
	{
		[Export("yottabits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selYottabitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Yottabytes
	{
		[Export("yottabytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selYottabytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Zebibits
	{
		[Export("zebibits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selZebibitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Zebibytes
	{
		[Export("zebibytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selZebibytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Zettabits
	{
		[Export("zettabits", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selZettabitsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUnitInformationStorage Zettabytes
	{
		[Export("zettabytes", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSUnitInformationStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selZettabytesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUnitInformationStorage(NSCoder coder)
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
	protected NSUnitInformationStorage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitInformationStorage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSymbol:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitInformationStorage(string symbol)
		: base(NSObjectFlag.Empty)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		IntPtr arg = NSString.CreateNative(symbol);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSymbol_Handle, arg), "initWithSymbol:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSymbol_Handle, arg), "initWithSymbol:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithSymbol:converter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUnitInformationStorage(string symbol, NSUnitConverter converter)
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
