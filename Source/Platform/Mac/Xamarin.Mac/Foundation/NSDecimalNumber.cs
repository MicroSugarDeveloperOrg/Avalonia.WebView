using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSDecimalNumber", true)]
public class NSDecimalNumber : NSNumber, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompare_ = "compare:";

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByAdding_ = "decimalNumberByAdding:";

	private static readonly IntPtr selDecimalNumberByAdding_Handle = Selector.GetHandle("decimalNumberByAdding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByAdding_WithBehavior_ = "decimalNumberByAdding:withBehavior:";

	private static readonly IntPtr selDecimalNumberByAdding_WithBehavior_Handle = Selector.GetHandle("decimalNumberByAdding:withBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByDividingBy_ = "decimalNumberByDividingBy:";

	private static readonly IntPtr selDecimalNumberByDividingBy_Handle = Selector.GetHandle("decimalNumberByDividingBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByDividingBy_WithBehavior_ = "decimalNumberByDividingBy:withBehavior:";

	private static readonly IntPtr selDecimalNumberByDividingBy_WithBehavior_Handle = Selector.GetHandle("decimalNumberByDividingBy:withBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByMultiplyingBy_ = "decimalNumberByMultiplyingBy:";

	private static readonly IntPtr selDecimalNumberByMultiplyingBy_Handle = Selector.GetHandle("decimalNumberByMultiplyingBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByMultiplyingBy_WithBehavior_ = "decimalNumberByMultiplyingBy:withBehavior:";

	private static readonly IntPtr selDecimalNumberByMultiplyingBy_WithBehavior_Handle = Selector.GetHandle("decimalNumberByMultiplyingBy:withBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByMultiplyingByPowerOf10_ = "decimalNumberByMultiplyingByPowerOf10:";

	private static readonly IntPtr selDecimalNumberByMultiplyingByPowerOf10_Handle = Selector.GetHandle("decimalNumberByMultiplyingByPowerOf10:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_ = "decimalNumberByMultiplyingByPowerOf10:withBehavior:";

	private static readonly IntPtr selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_Handle = Selector.GetHandle("decimalNumberByMultiplyingByPowerOf10:withBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByRaisingToPower_ = "decimalNumberByRaisingToPower:";

	private static readonly IntPtr selDecimalNumberByRaisingToPower_Handle = Selector.GetHandle("decimalNumberByRaisingToPower:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByRaisingToPower_WithBehavior_ = "decimalNumberByRaisingToPower:withBehavior:";

	private static readonly IntPtr selDecimalNumberByRaisingToPower_WithBehavior_Handle = Selector.GetHandle("decimalNumberByRaisingToPower:withBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberByRoundingAccordingToBehavior_ = "decimalNumberByRoundingAccordingToBehavior:";

	private static readonly IntPtr selDecimalNumberByRoundingAccordingToBehavior_Handle = Selector.GetHandle("decimalNumberByRoundingAccordingToBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberBySubtracting_ = "decimalNumberBySubtracting:";

	private static readonly IntPtr selDecimalNumberBySubtracting_Handle = Selector.GetHandle("decimalNumberBySubtracting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalNumberBySubtracting_WithBehavior_ = "decimalNumberBySubtracting:withBehavior:";

	private static readonly IntPtr selDecimalNumberBySubtracting_WithBehavior_Handle = Selector.GetHandle("decimalNumberBySubtracting:withBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalValue = "decimalValue";

	private static readonly IntPtr selDecimalValueHandle = Selector.GetHandle("decimalValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultBehavior = "defaultBehavior";

	private static readonly IntPtr selDefaultBehaviorHandle = Selector.GetHandle("defaultBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptionWithLocale_ = "descriptionWithLocale:";

	private static readonly IntPtr selDescriptionWithLocale_Handle = Selector.GetHandle("descriptionWithLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValue = "doubleValue";

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDecimal_ = "initWithDecimal:";

	private static readonly IntPtr selInitWithDecimal_Handle = Selector.GetHandle("initWithDecimal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMantissa_Exponent_IsNegative_ = "initWithMantissa:exponent:isNegative:";

	private static readonly IntPtr selInitWithMantissa_Exponent_IsNegative_Handle = Selector.GetHandle("initWithMantissa:exponent:isNegative:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_Locale_ = "initWithString:locale:";

	private static readonly IntPtr selInitWithString_Locale_Handle = Selector.GetHandle("initWithString:locale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumDecimalNumber = "maximumDecimalNumber";

	private static readonly IntPtr selMaximumDecimalNumberHandle = Selector.GetHandle("maximumDecimalNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumDecimalNumber = "minimumDecimalNumber";

	private static readonly IntPtr selMinimumDecimalNumberHandle = Selector.GetHandle("minimumDecimalNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotANumber = "notANumber";

	private static readonly IntPtr selNotANumberHandle = Selector.GetHandle("notANumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOne = "one";

	private static readonly IntPtr selOneHandle = Selector.GetHandle("one");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultBehavior_ = "setDefaultBehavior:";

	private static readonly IntPtr selSetDefaultBehavior_Handle = Selector.GetHandle("setDefaultBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZero = "zero";

	private static readonly IntPtr selZeroHandle = Selector.GetHandle("zero");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDecimalNumber");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultBehavior
	{
		[Export("defaultBehavior", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultBehaviorHandle));
		}
		[Export("setDefaultBehavior:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetDefaultBehavior_Handle, value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDecimalNumber MaxValue
	{
		[Export("maximumDecimalNumber", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend(class_ptr, selMaximumDecimalNumberHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDecimalNumber MinValue
	{
		[Export("minimumDecimalNumber", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend(class_ptr, selMinimumDecimalNumberHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSDecimal NSDecimalValue
	{
		[Export("decimalValue")]
		get
		{
			NSDecimal retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSDecimal_objc_msgSend_stret(out retval, base.Handle, selDecimalValueHandle);
			}
			else
			{
				Messaging.NSDecimal_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDecimalValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDecimalNumber NaN
	{
		[Export("notANumber", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotANumberHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDecimalNumber One
	{
		[Export("one", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend(class_ptr, selOneHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDecimalNumber Zero
	{
		[Export("zero", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend(class_ptr, selZeroHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDecimalNumber()
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
	public NSDecimalNumber(NSCoder coder)
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
	protected NSDecimalNumber(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDecimalNumber(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMantissa:exponent:isNegative:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDecimalNumber(long mantissa, short exponent, bool isNegative)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_short_bool(base.Handle, selInitWithMantissa_Exponent_IsNegative_Handle, mantissa, exponent, isNegative), "initWithMantissa:exponent:isNegative:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_short_bool(base.SuperHandle, selInitWithMantissa_Exponent_IsNegative_Handle, mantissa, exponent, isNegative), "initWithMantissa:exponent:isNegative:");
		}
	}

	[Export("initWithDecimal:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDecimalNumber(NSDecimal dec)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_NSDecimal(base.Handle, selInitWithDecimal_Handle, dec), "initWithDecimal:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_NSDecimal(base.SuperHandle, selInitWithDecimal_Handle, dec), "initWithDecimal:");
		}
	}

	[Export("initWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDecimalNumber(string numberValue)
		: base(NSObjectFlag.Empty)
	{
		if (numberValue == null)
		{
			throw new ArgumentNullException("numberValue");
		}
		IntPtr arg = NSString.CreateNative(numberValue);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:locale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDecimalNumber(string numberValue, NSObject locale)
		: base(NSObjectFlag.Empty)
	{
		if (numberValue == null)
		{
			throw new ArgumentNullException("numberValue");
		}
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		IntPtr arg = NSString.CreateNative(numberValue);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithString_Locale_Handle, arg, locale.Handle), "initWithString:locale:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithString_Locale_Handle, arg, locale.Handle), "initWithString:locale:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("decimalNumberByAdding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Add(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByAdding_Handle, d.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByAdding_Handle, d.Handle));
	}

	[Export("decimalNumberByAdding:withBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Add(NSDecimalNumber d, NSObject Behavior)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberByAdding_WithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberByAdding_WithBehavior_Handle, d.Handle, Behavior.Handle));
	}

	[Export("compare:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nint Compare(NSNumber other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, other.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, other.Handle);
	}

	[Export("descriptionWithLocale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override string DescriptionWithLocale(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescriptionWithLocale_Handle, locale.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescriptionWithLocale_Handle, locale.Handle));
	}

	[Export("decimalNumberByDividingBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Divide(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByDividingBy_Handle, d.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByDividingBy_Handle, d.Handle));
	}

	[Export("decimalNumberByDividingBy:withBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Divide(NSDecimalNumber d, NSObject Behavior)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberByDividingBy_WithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberByDividingBy_WithBehavior_Handle, d.Handle, Behavior.Handle));
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

	[Export("decimalNumberByMultiplyingBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Multiply(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByMultiplyingBy_Handle, d.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByMultiplyingBy_Handle, d.Handle));
	}

	[Export("decimalNumberByMultiplyingBy:withBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Multiply(NSDecimalNumber d, NSObject Behavior)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberByMultiplyingBy_WithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberByMultiplyingBy_WithBehavior_Handle, d.Handle, Behavior.Handle));
	}

	[Export("decimalNumberByMultiplyingByPowerOf10:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber MultiplyPowerOf10(short power)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_short(base.Handle, selDecimalNumberByMultiplyingByPowerOf10_Handle, power));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_short(base.SuperHandle, selDecimalNumberByMultiplyingByPowerOf10_Handle, power));
	}

	[Export("decimalNumberByMultiplyingByPowerOf10:withBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber MultiplyPowerOf10(short power, NSObject Behavior)
	{
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_short_IntPtr(base.Handle, selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_Handle, power, Behavior.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_short_IntPtr(base.SuperHandle, selDecimalNumberByMultiplyingByPowerOf10_WithBehavior_Handle, power, Behavior.Handle));
	}

	[Export("decimalNumberByRaisingToPower:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber RaiseTo(nuint power)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selDecimalNumberByRaisingToPower_Handle, power));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selDecimalNumberByRaisingToPower_Handle, power));
	}

	[Export("decimalNumberByRaisingToPower:withBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber RaiseTo(nuint power, NSObject Behavior)
	{
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_nuint_IntPtr(base.Handle, selDecimalNumberByRaisingToPower_WithBehavior_Handle, power, Behavior.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selDecimalNumberByRaisingToPower_WithBehavior_Handle, power, Behavior.Handle));
	}

	[Export("decimalNumberByRoundingAccordingToBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Rounding(NSObject behavior)
	{
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByRoundingAccordingToBehavior_Handle, behavior.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByRoundingAccordingToBehavior_Handle, behavior.Handle));
	}

	[Export("decimalNumberBySubtracting:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Subtract(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberBySubtracting_Handle, d.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberBySubtracting_Handle, d.Handle));
	}

	[Export("decimalNumberBySubtracting:withBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Subtract(NSDecimalNumber d, NSObject Behavior)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberBySubtracting_WithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberBySubtracting_WithBehavior_Handle, d.Handle, Behavior.Handle));
	}
}
