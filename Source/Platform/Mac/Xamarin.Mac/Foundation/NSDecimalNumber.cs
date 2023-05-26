using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDecimalNumber", true)]
public class NSDecimalNumber : NSNumber
{
	private static readonly IntPtr selDecimalValueHandle = Selector.GetHandle("decimalValue");

	private static readonly IntPtr selZeroHandle = Selector.GetHandle("zero");

	private static readonly IntPtr selOneHandle = Selector.GetHandle("one");

	private static readonly IntPtr selMinimumDecimalNumberHandle = Selector.GetHandle("minimumDecimalNumber");

	private static readonly IntPtr selMaximumDecimalNumberHandle = Selector.GetHandle("maximumDecimalNumber");

	private static readonly IntPtr selNotANumberHandle = Selector.GetHandle("notANumber");

	private static readonly IntPtr selDefaultBehaviorHandle = Selector.GetHandle("defaultBehavior");

	private static readonly IntPtr selSetDefaultBehavior_Handle = Selector.GetHandle("setDefaultBehavior:");

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	private static readonly IntPtr selInitWithMantissaExponentIsNegative_Handle = Selector.GetHandle("initWithMantissa:exponent:isNegative:");

	private static readonly IntPtr selInitWithDecimal_Handle = Selector.GetHandle("initWithDecimal:");

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	private static readonly IntPtr selInitWithStringLocale_Handle = Selector.GetHandle("initWithString:locale:");

	private static readonly IntPtr selDescriptionWithLocale_Handle = Selector.GetHandle("descriptionWithLocale:");

	private static readonly IntPtr selDecimalNumberByAdding_Handle = Selector.GetHandle("decimalNumberByAdding:");

	private static readonly IntPtr selDecimalNumberByAddingWithBehavior_Handle = Selector.GetHandle("decimalNumberByAdding:withBehavior:");

	private static readonly IntPtr selDecimalNumberBySubtracting_Handle = Selector.GetHandle("decimalNumberBySubtracting:");

	private static readonly IntPtr selDecimalNumberBySubtractingWithBehavior_Handle = Selector.GetHandle("decimalNumberBySubtracting:withBehavior:");

	private static readonly IntPtr selDecimalNumberByMultiplyingBy_Handle = Selector.GetHandle("decimalNumberByMultiplyingBy:");

	private static readonly IntPtr selDecimalNumberByMultiplyingByWithBehavior_Handle = Selector.GetHandle("decimalNumberByMultiplyingBy:withBehavior:");

	private static readonly IntPtr selDecimalNumberByDividingBy_Handle = Selector.GetHandle("decimalNumberByDividingBy:");

	private static readonly IntPtr selDecimalNumberByDividingByWithBehavior_Handle = Selector.GetHandle("decimalNumberByDividingBy:withBehavior:");

	private static readonly IntPtr selDecimalNumberByRaisingToPower_Handle = Selector.GetHandle("decimalNumberByRaisingToPower:");

	private static readonly IntPtr selDecimalNumberByRaisingToPowerWithBehavior_Handle = Selector.GetHandle("decimalNumberByRaisingToPower:withBehavior:");

	private static readonly IntPtr selDecimalNumberByMultiplyingByPowerOf10_Handle = Selector.GetHandle("decimalNumberByMultiplyingByPowerOf10:");

	private static readonly IntPtr selDecimalNumberByMultiplyingByPowerOf10WithBehavior_Handle = Selector.GetHandle("decimalNumberByMultiplyingByPowerOf10:withBehavior:");

	private static readonly IntPtr selDecimalNumberByRoundingAccordingToBehavior_Handle = Selector.GetHandle("decimalNumberByRoundingAccordingToBehavior:");

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDecimalNumber");

	private static object __mt_Zero_var_static;

	private static object __mt_One_var_static;

	private static object __mt_MinValue_var_static;

	private static object __mt_MaxValue_var_static;

	private static object __mt_NaN_var_static;

	private static object __mt_DefaultBehavior_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual NSDecimal NSDecimalValue
	{
		[Export("decimalValue")]
		get
		{
			NSDecimal retval;
			if (IsDirectBinding)
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

	public static NSDecimalNumber Zero
	{
		[Export("zero")]
		get
		{
			return (NSDecimalNumber)(__mt_Zero_var_static = (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selZeroHandle)));
		}
	}

	public static NSDecimalNumber One
	{
		[Export("one")]
		get
		{
			return (NSDecimalNumber)(__mt_One_var_static = (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selOneHandle)));
		}
	}

	public static NSDecimalNumber MinValue
	{
		[Export("minimumDecimalNumber")]
		get
		{
			return (NSDecimalNumber)(__mt_MinValue_var_static = (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMinimumDecimalNumberHandle)));
		}
	}

	public static NSDecimalNumber MaxValue
	{
		[Export("maximumDecimalNumber")]
		get
		{
			return (NSDecimalNumber)(__mt_MaxValue_var_static = (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMaximumDecimalNumberHandle)));
		}
	}

	public static NSDecimalNumber NaN
	{
		[Export("notANumber")]
		get
		{
			return (NSDecimalNumber)(__mt_NaN_var_static = (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selNotANumberHandle)));
		}
	}

	public static NSObject DefaultBehavior
	{
		[Export("defaultBehavior")]
		get
		{
			return (NSObject)(__mt_DefaultBehavior_var_static = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultBehaviorHandle)));
		}
		[Export("setDefaultBehavior:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetDefaultBehavior_Handle, value.Handle);
		}
	}

	public new virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDecimalNumber()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSDecimalNumber(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDecimalNumber(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDecimalNumber(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMantissa:exponent:isNegative:")]
	public NSDecimalNumber(long mantissa, short exponent, bool isNegative)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Int64_short_bool(base.Handle, selInitWithMantissaExponentIsNegative_Handle, mantissa, exponent, isNegative);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Int64_short_bool(base.SuperHandle, selInitWithMantissaExponentIsNegative_Handle, mantissa, exponent, isNegative);
		}
	}

	[Export("initWithDecimal:")]
	public NSDecimalNumber(NSDecimal dec)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_NSDecimal(base.Handle, selInitWithDecimal_Handle, dec);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_NSDecimal(base.SuperHandle, selInitWithDecimal_Handle, dec);
		}
	}

	[Export("initWithString:")]
	public NSDecimalNumber(string numberValue)
		: base(NSObjectFlag.Empty)
	{
		if (numberValue == null)
		{
			throw new ArgumentNullException("numberValue");
		}
		IntPtr arg = NSString.CreateNative(numberValue);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:locale:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStringLocale_Handle, arg, locale.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStringLocale_Handle, arg, locale.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("descriptionWithLocale:")]
	public new virtual string DescriptionWithLocale(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescriptionWithLocale_Handle, locale.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescriptionWithLocale_Handle, locale.Handle));
	}

	[Export("decimalNumberByAdding:")]
	public virtual NSDecimalNumber Add(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByAdding_Handle, d.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByAdding_Handle, d.Handle));
	}

	[Export("decimalNumberByAdding:withBehavior:")]
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
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberByAddingWithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberByAddingWithBehavior_Handle, d.Handle, Behavior.Handle));
	}

	[Export("decimalNumberBySubtracting:")]
	public virtual NSDecimalNumber Subtract(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberBySubtracting_Handle, d.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberBySubtracting_Handle, d.Handle));
	}

	[Export("decimalNumberBySubtracting:withBehavior:")]
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
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberBySubtractingWithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberBySubtractingWithBehavior_Handle, d.Handle, Behavior.Handle));
	}

	[Export("decimalNumberByMultiplyingBy:")]
	public virtual NSDecimalNumber Multiply(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByMultiplyingBy_Handle, d.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByMultiplyingBy_Handle, d.Handle));
	}

	[Export("decimalNumberByMultiplyingBy:withBehavior:")]
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
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberByMultiplyingByWithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberByMultiplyingByWithBehavior_Handle, d.Handle, Behavior.Handle));
	}

	[Export("decimalNumberByDividingBy:")]
	public virtual NSDecimalNumber Divide(NSDecimalNumber d)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByDividingBy_Handle, d.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByDividingBy_Handle, d.Handle));
	}

	[Export("decimalNumberByDividingBy:withBehavior:")]
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
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecimalNumberByDividingByWithBehavior_Handle, d.Handle, Behavior.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecimalNumberByDividingByWithBehavior_Handle, d.Handle, Behavior.Handle));
	}

	[Export("decimalNumberByRaisingToPower:")]
	public virtual NSDecimalNumber RaiseTo(ulong power)
	{
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selDecimalNumberByRaisingToPower_Handle, power));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selDecimalNumberByRaisingToPower_Handle, power));
	}

	[Export("decimalNumberByRaisingToPower:withBehavior:")]
	public virtual NSDecimalNumber RaiseTo(ulong power, NSObject Behavior)
	{
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selDecimalNumberByRaisingToPowerWithBehavior_Handle, power, Behavior.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selDecimalNumberByRaisingToPowerWithBehavior_Handle, power, Behavior.Handle));
	}

	[Export("decimalNumberByMultiplyingByPowerOf10:")]
	public virtual NSDecimalNumber MultiplyPowerOf10(short power)
	{
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_short(base.Handle, selDecimalNumberByMultiplyingByPowerOf10_Handle, power));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_short(base.SuperHandle, selDecimalNumberByMultiplyingByPowerOf10_Handle, power));
	}

	[Export("decimalNumberByMultiplyingByPowerOf10:withBehavior:")]
	public virtual NSDecimalNumber MultiplyPowerOf10(short power, NSObject Behavior)
	{
		if (Behavior == null)
		{
			throw new ArgumentNullException("Behavior");
		}
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_short_IntPtr(base.Handle, selDecimalNumberByMultiplyingByPowerOf10WithBehavior_Handle, power, Behavior.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_short_IntPtr(base.SuperHandle, selDecimalNumberByMultiplyingByPowerOf10WithBehavior_Handle, power, Behavior.Handle));
	}

	[Export("decimalNumberByRoundingAccordingToBehavior:")]
	public virtual NSDecimalNumber Rounding(NSObject behavior)
	{
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (IsDirectBinding)
		{
			return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecimalNumberByRoundingAccordingToBehavior_Handle, behavior.Handle));
		}
		return (NSDecimalNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecimalNumberByRoundingAccordingToBehavior_Handle, behavior.Handle));
	}

	[Export("compare:")]
	public new virtual long Compare(NSNumber other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, other.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, other.Handle);
	}
}
