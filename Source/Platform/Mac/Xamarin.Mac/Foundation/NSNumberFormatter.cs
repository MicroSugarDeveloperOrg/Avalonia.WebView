using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNumberFormatter", true)]
public class NSNumberFormatter : NSFormatter
{
	private static readonly IntPtr selNumberStyleHandle = Selector.GetHandle("numberStyle");

	private static readonly IntPtr selSetNumberStyle_Handle = Selector.GetHandle("setNumberStyle:");

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	private static readonly IntPtr selGeneratesDecimalNumbersHandle = Selector.GetHandle("generatesDecimalNumbers");

	private static readonly IntPtr selSetGeneratesDecimalNumbers_Handle = Selector.GetHandle("setGeneratesDecimalNumbers:");

	private static readonly IntPtr selFormatterBehaviorHandle = Selector.GetHandle("formatterBehavior");

	private static readonly IntPtr selSetFormatterBehavior_Handle = Selector.GetHandle("setFormatterBehavior:");

	private static readonly IntPtr selDefaultFormatterBehaviorHandle = Selector.GetHandle("defaultFormatterBehavior");

	private static readonly IntPtr selSetDefaultFormatterBehavior_Handle = Selector.GetHandle("setDefaultFormatterBehavior:");

	private static readonly IntPtr selNegativeFormatHandle = Selector.GetHandle("negativeFormat");

	private static readonly IntPtr selSetNegativeFormat_Handle = Selector.GetHandle("setNegativeFormat:");

	private static readonly IntPtr selTextAttributesForNegativeValuesHandle = Selector.GetHandle("textAttributesForNegativeValues");

	private static readonly IntPtr selSetTextAttributesForNegativeValues_Handle = Selector.GetHandle("setTextAttributesForNegativeValues:");

	private static readonly IntPtr selPositiveFormatHandle = Selector.GetHandle("positiveFormat");

	private static readonly IntPtr selSetPositiveFormat_Handle = Selector.GetHandle("setPositiveFormat:");

	private static readonly IntPtr selTextAttributesForPositiveValuesHandle = Selector.GetHandle("textAttributesForPositiveValues");

	private static readonly IntPtr selSetTextAttributesForPositiveValues_Handle = Selector.GetHandle("setTextAttributesForPositiveValues:");

	private static readonly IntPtr selAllowsFloatsHandle = Selector.GetHandle("allowsFloats");

	private static readonly IntPtr selSetAllowsFloats_Handle = Selector.GetHandle("setAllowsFloats:");

	private static readonly IntPtr selDecimalSeparatorHandle = Selector.GetHandle("decimalSeparator");

	private static readonly IntPtr selSetDecimalSeparator_Handle = Selector.GetHandle("setDecimalSeparator:");

	private static readonly IntPtr selAlwaysShowsDecimalSeparatorHandle = Selector.GetHandle("alwaysShowsDecimalSeparator");

	private static readonly IntPtr selSetAlwaysShowsDecimalSeparator_Handle = Selector.GetHandle("setAlwaysShowsDecimalSeparator:");

	private static readonly IntPtr selCurrencyDecimalSeparatorHandle = Selector.GetHandle("currencyDecimalSeparator");

	private static readonly IntPtr selSetCurrencyDecimalSeparator_Handle = Selector.GetHandle("setCurrencyDecimalSeparator:");

	private static readonly IntPtr selUsesGroupingSeparatorHandle = Selector.GetHandle("usesGroupingSeparator");

	private static readonly IntPtr selSetUsesGroupingSeparator_Handle = Selector.GetHandle("setUsesGroupingSeparator:");

	private static readonly IntPtr selGroupingSeparatorHandle = Selector.GetHandle("groupingSeparator");

	private static readonly IntPtr selSetGroupingSeparator_Handle = Selector.GetHandle("setGroupingSeparator:");

	private static readonly IntPtr selZeroSymbolHandle = Selector.GetHandle("zeroSymbol");

	private static readonly IntPtr selSetZeroSymbol_Handle = Selector.GetHandle("setZeroSymbol:");

	private static readonly IntPtr selTextAttributesForZeroHandle = Selector.GetHandle("textAttributesForZero");

	private static readonly IntPtr selSetTextAttributesForZero_Handle = Selector.GetHandle("setTextAttributesForZero:");

	private static readonly IntPtr selNilSymbolHandle = Selector.GetHandle("nilSymbol");

	private static readonly IntPtr selSetNilSymbol_Handle = Selector.GetHandle("setNilSymbol:");

	private static readonly IntPtr selTextAttributesForNilHandle = Selector.GetHandle("textAttributesForNil");

	private static readonly IntPtr selSetTextAttributesForNil_Handle = Selector.GetHandle("setTextAttributesForNil:");

	private static readonly IntPtr selNotANumberSymbolHandle = Selector.GetHandle("notANumberSymbol");

	private static readonly IntPtr selSetNotANumberSymbol_Handle = Selector.GetHandle("setNotANumberSymbol:");

	private static readonly IntPtr selTextAttributesForNotANumberHandle = Selector.GetHandle("textAttributesForNotANumber");

	private static readonly IntPtr selSetTextAttributesForNotANumber_Handle = Selector.GetHandle("setTextAttributesForNotANumber:");

	private static readonly IntPtr selPositiveInfinitySymbolHandle = Selector.GetHandle("positiveInfinitySymbol");

	private static readonly IntPtr selSetPositiveInfinitySymbol_Handle = Selector.GetHandle("setPositiveInfinitySymbol:");

	private static readonly IntPtr selTextAttributesForPositiveInfinityHandle = Selector.GetHandle("textAttributesForPositiveInfinity");

	private static readonly IntPtr selSetTextAttributesForPositiveInfinity_Handle = Selector.GetHandle("setTextAttributesForPositiveInfinity:");

	private static readonly IntPtr selNegativeInfinitySymbolHandle = Selector.GetHandle("negativeInfinitySymbol");

	private static readonly IntPtr selSetNegativeInfinitySymbol_Handle = Selector.GetHandle("setNegativeInfinitySymbol:");

	private static readonly IntPtr selTextAttributesForNegativeInfinityHandle = Selector.GetHandle("textAttributesForNegativeInfinity");

	private static readonly IntPtr selSetTextAttributesForNegativeInfinity_Handle = Selector.GetHandle("setTextAttributesForNegativeInfinity:");

	private static readonly IntPtr selPositivePrefixHandle = Selector.GetHandle("positivePrefix");

	private static readonly IntPtr selSetPositivePrefix_Handle = Selector.GetHandle("setPositivePrefix:");

	private static readonly IntPtr selPositiveSuffixHandle = Selector.GetHandle("positiveSuffix");

	private static readonly IntPtr selSetPositiveSuffix_Handle = Selector.GetHandle("setPositiveSuffix:");

	private static readonly IntPtr selNegativePrefixHandle = Selector.GetHandle("negativePrefix");

	private static readonly IntPtr selSetNegativePrefix_Handle = Selector.GetHandle("setNegativePrefix:");

	private static readonly IntPtr selNegativeSuffixHandle = Selector.GetHandle("negativeSuffix");

	private static readonly IntPtr selSetNegativeSuffix_Handle = Selector.GetHandle("setNegativeSuffix:");

	private static readonly IntPtr selCurrencyCodeHandle = Selector.GetHandle("currencyCode");

	private static readonly IntPtr selSetCurrencyCode_Handle = Selector.GetHandle("setCurrencyCode:");

	private static readonly IntPtr selCurrencySymbolHandle = Selector.GetHandle("currencySymbol");

	private static readonly IntPtr selSetCurrencySymbol_Handle = Selector.GetHandle("setCurrencySymbol:");

	private static readonly IntPtr selInternationalCurrencySymbolHandle = Selector.GetHandle("internationalCurrencySymbol");

	private static readonly IntPtr selSetInternationalCurrencySymbol_Handle = Selector.GetHandle("setInternationalCurrencySymbol:");

	private static readonly IntPtr selPercentSymbolHandle = Selector.GetHandle("percentSymbol");

	private static readonly IntPtr selSetPercentSymbol_Handle = Selector.GetHandle("setPercentSymbol:");

	private static readonly IntPtr selPerMillSymbolHandle = Selector.GetHandle("perMillSymbol");

	private static readonly IntPtr selSetPerMillSymbol_Handle = Selector.GetHandle("setPerMillSymbol:");

	private static readonly IntPtr selMinusSignHandle = Selector.GetHandle("minusSign");

	private static readonly IntPtr selSetMinusSign_Handle = Selector.GetHandle("setMinusSign:");

	private static readonly IntPtr selPlusSignHandle = Selector.GetHandle("plusSign");

	private static readonly IntPtr selSetPlusSign_Handle = Selector.GetHandle("setPlusSign:");

	private static readonly IntPtr selExponentSymbolHandle = Selector.GetHandle("exponentSymbol");

	private static readonly IntPtr selSetExponentSymbol_Handle = Selector.GetHandle("setExponentSymbol:");

	private static readonly IntPtr selGroupingSizeHandle = Selector.GetHandle("groupingSize");

	private static readonly IntPtr selSetGroupingSize_Handle = Selector.GetHandle("setGroupingSize:");

	private static readonly IntPtr selSecondaryGroupingSizeHandle = Selector.GetHandle("secondaryGroupingSize");

	private static readonly IntPtr selSetSecondaryGroupingSize_Handle = Selector.GetHandle("setSecondaryGroupingSize:");

	private static readonly IntPtr selMultiplierHandle = Selector.GetHandle("multiplier");

	private static readonly IntPtr selSetMultiplier_Handle = Selector.GetHandle("setMultiplier:");

	private static readonly IntPtr selFormatWidthHandle = Selector.GetHandle("formatWidth");

	private static readonly IntPtr selSetFormatWidth_Handle = Selector.GetHandle("setFormatWidth:");

	private static readonly IntPtr selPaddingCharacterHandle = Selector.GetHandle("paddingCharacter");

	private static readonly IntPtr selSetPaddingCharacter_Handle = Selector.GetHandle("setPaddingCharacter:");

	private static readonly IntPtr selPaddingPositionHandle = Selector.GetHandle("paddingPosition");

	private static readonly IntPtr selSetPaddingPosition_Handle = Selector.GetHandle("setPaddingPosition:");

	private static readonly IntPtr selRoundingModeHandle = Selector.GetHandle("roundingMode");

	private static readonly IntPtr selSetRoundingMode_Handle = Selector.GetHandle("setRoundingMode:");

	private static readonly IntPtr selRoundingIncrementHandle = Selector.GetHandle("roundingIncrement");

	private static readonly IntPtr selSetRoundingIncrement_Handle = Selector.GetHandle("setRoundingIncrement:");

	private static readonly IntPtr selMinimumIntegerDigitsHandle = Selector.GetHandle("minimumIntegerDigits");

	private static readonly IntPtr selSetMinimumIntegerDigits_Handle = Selector.GetHandle("setMinimumIntegerDigits:");

	private static readonly IntPtr selMaximumIntegerDigitsHandle = Selector.GetHandle("maximumIntegerDigits");

	private static readonly IntPtr selSetMaximumIntegerDigits_Handle = Selector.GetHandle("setMaximumIntegerDigits:");

	private static readonly IntPtr selMinimumFractionDigitsHandle = Selector.GetHandle("minimumFractionDigits");

	private static readonly IntPtr selSetMinimumFractionDigits_Handle = Selector.GetHandle("setMinimumFractionDigits:");

	private static readonly IntPtr selMaximumFractionDigitsHandle = Selector.GetHandle("maximumFractionDigits");

	private static readonly IntPtr selSetMaximumFractionDigits_Handle = Selector.GetHandle("setMaximumFractionDigits:");

	private static readonly IntPtr selMinimumHandle = Selector.GetHandle("minimum");

	private static readonly IntPtr selSetMinimum_Handle = Selector.GetHandle("setMinimum:");

	private static readonly IntPtr selMaximumHandle = Selector.GetHandle("maximum");

	private static readonly IntPtr selSetMaximum_Handle = Selector.GetHandle("setMaximum:");

	private static readonly IntPtr selCurrencyGroupingSeparatorHandle = Selector.GetHandle("currencyGroupingSeparator");

	private static readonly IntPtr selSetCurrencyGroupingSeparator_Handle = Selector.GetHandle("setCurrencyGroupingSeparator:");

	private static readonly IntPtr selIsLenientHandle = Selector.GetHandle("isLenient");

	private static readonly IntPtr selSetLenient_Handle = Selector.GetHandle("setLenient:");

	private static readonly IntPtr selUsesSignificantDigitsHandle = Selector.GetHandle("usesSignificantDigits");

	private static readonly IntPtr selSetUsesSignificantDigits_Handle = Selector.GetHandle("setUsesSignificantDigits:");

	private static readonly IntPtr selMinimumSignificantDigitsHandle = Selector.GetHandle("minimumSignificantDigits");

	private static readonly IntPtr selSetMinimumSignificantDigits_Handle = Selector.GetHandle("setMinimumSignificantDigits:");

	private static readonly IntPtr selMaximumSignificantDigitsHandle = Selector.GetHandle("maximumSignificantDigits");

	private static readonly IntPtr selSetMaximumSignificantDigits_Handle = Selector.GetHandle("setMaximumSignificantDigits:");

	private static readonly IntPtr selIsPartialStringValidationEnabledHandle = Selector.GetHandle("isPartialStringValidationEnabled");

	private static readonly IntPtr selSetPartialStringValidationEnabled_Handle = Selector.GetHandle("setPartialStringValidationEnabled:");

	private static readonly IntPtr selStringFromNumber_Handle = Selector.GetHandle("stringFromNumber:");

	private static readonly IntPtr selNumberFromString_Handle = Selector.GetHandle("numberFromString:");

	private static readonly IntPtr selLocalizedStringFromNumberNumberStyle_Handle = Selector.GetHandle("localizedStringFromNumber:numberStyle:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNumberFormatter");

	private object __mt_Locale_var;

	private object __mt_TextAttributesForNegativeValues_var;

	private object __mt_TextAttributesForPositiveValues_var;

	private object __mt_TextAttributesForZero_var;

	private object __mt_TextAttributesForNil_var;

	private object __mt_TextAttributesForNotANumber_var;

	private object __mt_TextAttributesForPositiveInfinity_var;

	private object __mt_TextAttributesForNegativeInfinity_var;

	private object __mt_Multiplier_var;

	private object __mt_RoundingIncrement_var;

	private object __mt_Minimum_var;

	private object __mt_Maximum_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSNumberFormatterStyle NumberStyle
	{
		[Export("numberStyle")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSNumberFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selNumberStyleHandle);
			}
			return (NSNumberFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNumberStyleHandle);
		}
		[Export("setNumberStyle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetNumberStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetNumberStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual NSLocale Locale
	{
		[Export("locale")]
		get
		{
			return (NSLocale)(__mt_Locale_var = ((!IsDirectBinding) ? ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle))) : ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle)))));
		}
		[Export("setLocale:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocale_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocale_Handle, value.Handle);
			}
			__mt_Locale_var = value;
		}
	}

	public virtual bool GeneratesDecimalNumbers
	{
		[Export("generatesDecimalNumbers")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selGeneratesDecimalNumbersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGeneratesDecimalNumbersHandle);
		}
		[Export("setGeneratesDecimalNumbers:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGeneratesDecimalNumbers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGeneratesDecimalNumbers_Handle, value);
			}
		}
	}

	public virtual NSNumberFormatterBehavior FormatterBehavior
	{
		[Export("formatterBehavior")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSNumberFormatterBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selFormatterBehaviorHandle);
			}
			return (NSNumberFormatterBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatterBehaviorHandle);
		}
		[Export("setFormatterBehavior:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFormatterBehavior_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFormatterBehavior_Handle, (ulong)value);
			}
		}
	}

	public static NSNumberFormatterBehavior DefaultFormatterBehavior
	{
		[Export("defaultFormatterBehavior")]
		get
		{
			return (NSNumberFormatterBehavior)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultFormatterBehaviorHandle);
		}
		[Export("setDefaultFormatterBehavior:")]
		set
		{
			Messaging.void_objc_msgSend_UInt64(class_ptr, selSetDefaultFormatterBehavior_Handle, (ulong)value);
		}
	}

	public virtual string NegativeFormat
	{
		[Export("negativeFormat")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNegativeFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNegativeFormatHandle));
		}
		[Export("setNegativeFormat:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNegativeFormat_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNegativeFormat_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary TextAttributesForNegativeValues
	{
		[Export("textAttributesForNegativeValues")]
		get
		{
			return (NSDictionary)(__mt_TextAttributesForNegativeValues_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNegativeValuesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNegativeValuesHandle)))));
		}
		[Export("setTextAttributesForNegativeValues:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNegativeValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNegativeValues_Handle, value.Handle);
			}
			__mt_TextAttributesForNegativeValues_var = value;
		}
	}

	public virtual string PositiveFormat
	{
		[Export("positiveFormat")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPositiveFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPositiveFormatHandle));
		}
		[Export("setPositiveFormat:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPositiveFormat_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPositiveFormat_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary TextAttributesForPositiveValues
	{
		[Export("textAttributesForPositiveValues")]
		get
		{
			return (NSDictionary)(__mt_TextAttributesForPositiveValues_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForPositiveValuesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForPositiveValuesHandle)))));
		}
		[Export("setTextAttributesForPositiveValues:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForPositiveValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForPositiveValues_Handle, value.Handle);
			}
			__mt_TextAttributesForPositiveValues_var = value;
		}
	}

	public virtual bool AllowsFloats
	{
		[Export("allowsFloats")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsFloatsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsFloatsHandle);
		}
		[Export("setAllowsFloats:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsFloats_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsFloats_Handle, value);
			}
		}
	}

	public virtual string DecimalSeparator
	{
		[Export("decimalSeparator")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDecimalSeparatorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDecimalSeparatorHandle));
		}
		[Export("setDecimalSeparator:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDecimalSeparator_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDecimalSeparator_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool AlwaysShowsDecimalSeparator
	{
		[Export("alwaysShowsDecimalSeparator")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysShowsDecimalSeparatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysShowsDecimalSeparatorHandle);
		}
		[Export("setAlwaysShowsDecimalSeparator:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysShowsDecimalSeparator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysShowsDecimalSeparator_Handle, value);
			}
		}
	}

	public virtual string CurrencyDecimalSeparator
	{
		[Export("currencyDecimalSeparator")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrencyDecimalSeparatorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrencyDecimalSeparatorHandle));
		}
		[Export("setCurrencyDecimalSeparator:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrencyDecimalSeparator_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrencyDecimalSeparator_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool UsesGroupingSeparator
	{
		[Export("usesGroupingSeparator")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesGroupingSeparatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesGroupingSeparatorHandle);
		}
		[Export("setUsesGroupingSeparator:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesGroupingSeparator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesGroupingSeparator_Handle, value);
			}
		}
	}

	public virtual string GroupingSeparator
	{
		[Export("groupingSeparator")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupingSeparatorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupingSeparatorHandle));
		}
		[Export("setGroupingSeparator:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroupingSeparator_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroupingSeparator_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ZeroSymbol
	{
		[Export("zeroSymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selZeroSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selZeroSymbolHandle));
		}
		[Export("setZeroSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetZeroSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetZeroSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary TextAttributesForZero
	{
		[Export("textAttributesForZero")]
		get
		{
			return (NSDictionary)(__mt_TextAttributesForZero_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForZeroHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForZeroHandle)))));
		}
		[Export("setTextAttributesForZero:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForZero_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForZero_Handle, value.Handle);
			}
			__mt_TextAttributesForZero_var = value;
		}
	}

	public virtual string NilSymbol
	{
		[Export("nilSymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNilSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNilSymbolHandle));
		}
		[Export("setNilSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNilSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNilSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary TextAttributesForNil
	{
		[Export("textAttributesForNil")]
		get
		{
			return (NSDictionary)(__mt_TextAttributesForNil_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNilHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNilHandle)))));
		}
		[Export("setTextAttributesForNil:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNil_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNil_Handle, value.Handle);
			}
			__mt_TextAttributesForNil_var = value;
		}
	}

	public virtual string NotANumberSymbol
	{
		[Export("notANumberSymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNotANumberSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotANumberSymbolHandle));
		}
		[Export("setNotANumberSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNotANumberSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNotANumberSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary TextAttributesForNotANumber
	{
		[Export("textAttributesForNotANumber")]
		get
		{
			return (NSDictionary)(__mt_TextAttributesForNotANumber_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNotANumberHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNotANumberHandle)))));
		}
		[Export("setTextAttributesForNotANumber:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNotANumber_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNotANumber_Handle, value.Handle);
			}
			__mt_TextAttributesForNotANumber_var = value;
		}
	}

	public virtual string PositiveInfinitySymbol
	{
		[Export("positiveInfinitySymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPositiveInfinitySymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPositiveInfinitySymbolHandle));
		}
		[Export("setPositiveInfinitySymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPositiveInfinitySymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPositiveInfinitySymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary TextAttributesForPositiveInfinity
	{
		[Export("textAttributesForPositiveInfinity")]
		get
		{
			return (NSDictionary)(__mt_TextAttributesForPositiveInfinity_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForPositiveInfinityHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForPositiveInfinityHandle)))));
		}
		[Export("setTextAttributesForPositiveInfinity:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForPositiveInfinity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForPositiveInfinity_Handle, value.Handle);
			}
			__mt_TextAttributesForPositiveInfinity_var = value;
		}
	}

	public virtual string NegativeInfinitySymbol
	{
		[Export("negativeInfinitySymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNegativeInfinitySymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNegativeInfinitySymbolHandle));
		}
		[Export("setNegativeInfinitySymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNegativeInfinitySymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNegativeInfinitySymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSDictionary TextAttributesForNegativeInfinity
	{
		[Export("textAttributesForNegativeInfinity")]
		get
		{
			return (NSDictionary)(__mt_TextAttributesForNegativeInfinity_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNegativeInfinityHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNegativeInfinityHandle)))));
		}
		[Export("setTextAttributesForNegativeInfinity:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNegativeInfinity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNegativeInfinity_Handle, value.Handle);
			}
			__mt_TextAttributesForNegativeInfinity_var = value;
		}
	}

	public virtual string PositivePrefix
	{
		[Export("positivePrefix")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPositivePrefixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPositivePrefixHandle));
		}
		[Export("setPositivePrefix:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPositivePrefix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPositivePrefix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string PositiveSuffix
	{
		[Export("positiveSuffix")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPositiveSuffixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPositiveSuffixHandle));
		}
		[Export("setPositiveSuffix:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPositiveSuffix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPositiveSuffix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string NegativePrefix
	{
		[Export("negativePrefix")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNegativePrefixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNegativePrefixHandle));
		}
		[Export("setNegativePrefix:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNegativePrefix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNegativePrefix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string NegativeSuffix
	{
		[Export("negativeSuffix")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNegativeSuffixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNegativeSuffixHandle));
		}
		[Export("setNegativeSuffix:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNegativeSuffix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNegativeSuffix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string CurrencyCode
	{
		[Export("currencyCode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrencyCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrencyCodeHandle));
		}
		[Export("setCurrencyCode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrencyCode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrencyCode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string CurrencySymbol
	{
		[Export("currencySymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrencySymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrencySymbolHandle));
		}
		[Export("setCurrencySymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrencySymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrencySymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string InternationalCurrencySymbol
	{
		[Export("internationalCurrencySymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInternationalCurrencySymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInternationalCurrencySymbolHandle));
		}
		[Export("setInternationalCurrencySymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInternationalCurrencySymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInternationalCurrencySymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string PercentSymbol
	{
		[Export("percentSymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPercentSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPercentSymbolHandle));
		}
		[Export("setPercentSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPercentSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPercentSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string PerMillSymbol
	{
		[Export("perMillSymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPerMillSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPerMillSymbolHandle));
		}
		[Export("setPerMillSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPerMillSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPerMillSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string MinusSign
	{
		[Export("minusSign")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMinusSignHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMinusSignHandle));
		}
		[Export("setMinusSign:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMinusSign_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMinusSign_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string PlusSign
	{
		[Export("plusSign")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlusSignHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlusSignHandle));
		}
		[Export("setPlusSign:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlusSign_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlusSign_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ExponentSymbol
	{
		[Export("exponentSymbol")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExponentSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExponentSymbolHandle));
		}
		[Export("setExponentSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExponentSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExponentSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual uint GroupingSize
	{
		[Export("groupingSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selGroupingSizeHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selGroupingSizeHandle);
		}
		[Export("setGroupingSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetGroupingSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetGroupingSize_Handle, value);
			}
		}
	}

	public virtual uint SecondaryGroupingSize
	{
		[Export("secondaryGroupingSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selSecondaryGroupingSizeHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selSecondaryGroupingSizeHandle);
		}
		[Export("setSecondaryGroupingSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetSecondaryGroupingSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetSecondaryGroupingSize_Handle, value);
			}
		}
	}

	public virtual NSNumber Multiplier
	{
		[Export("multiplier")]
		get
		{
			return (NSNumber)(__mt_Multiplier_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultiplierHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMultiplierHandle)))));
		}
		[Export("setMultiplier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMultiplier_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMultiplier_Handle, value.Handle);
			}
			__mt_Multiplier_var = value;
		}
	}

	public virtual ulong FormatWidth
	{
		[Export("formatWidth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selFormatWidthHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatWidthHandle);
		}
		[Export("setFormatWidth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFormatWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFormatWidth_Handle, value);
			}
		}
	}

	public virtual string PaddingCharacter
	{
		[Export("paddingCharacter")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPaddingCharacterHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaddingCharacterHandle));
		}
		[Export("setPaddingCharacter:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPaddingCharacter_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPaddingCharacter_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSNumberFormatterPadPosition PaddingPosition
	{
		[Export("paddingPosition")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSNumberFormatterPadPosition)Messaging.UInt64_objc_msgSend(base.Handle, selPaddingPositionHandle);
			}
			return (NSNumberFormatterPadPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPaddingPositionHandle);
		}
		[Export("setPaddingPosition:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPaddingPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPaddingPosition_Handle, (ulong)value);
			}
		}
	}

	public virtual NSNumberFormatterRoundingMode RoundingMode
	{
		[Export("roundingMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSNumberFormatterRoundingMode)Messaging.UInt64_objc_msgSend(base.Handle, selRoundingModeHandle);
			}
			return (NSNumberFormatterRoundingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRoundingModeHandle);
		}
		[Export("setRoundingMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRoundingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRoundingMode_Handle, (ulong)value);
			}
		}
	}

	public virtual NSNumber RoundingIncrement
	{
		[Export("roundingIncrement")]
		get
		{
			return (NSNumber)(__mt_RoundingIncrement_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRoundingIncrementHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRoundingIncrementHandle)))));
		}
		[Export("setRoundingIncrement:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRoundingIncrement_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRoundingIncrement_Handle, value.Handle);
			}
			__mt_RoundingIncrement_var = value;
		}
	}

	public virtual ulong MinimumIntegerDigits
	{
		[Export("minimumIntegerDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMinimumIntegerDigitsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMinimumIntegerDigitsHandle);
		}
		[Export("setMinimumIntegerDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMinimumIntegerDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMinimumIntegerDigits_Handle, value);
			}
		}
	}

	public virtual ulong MaximumIntegerDigits
	{
		[Export("maximumIntegerDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMaximumIntegerDigitsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMaximumIntegerDigitsHandle);
		}
		[Export("setMaximumIntegerDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMaximumIntegerDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMaximumIntegerDigits_Handle, value);
			}
		}
	}

	public virtual ulong MinimumFractionDigits
	{
		[Export("minimumFractionDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMinimumFractionDigitsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMinimumFractionDigitsHandle);
		}
		[Export("setMinimumFractionDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMinimumFractionDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMinimumFractionDigits_Handle, value);
			}
		}
	}

	public virtual ulong MaximumFractionDigits
	{
		[Export("maximumFractionDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMaximumFractionDigitsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMaximumFractionDigitsHandle);
		}
		[Export("setMaximumFractionDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMaximumFractionDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMaximumFractionDigits_Handle, value);
			}
		}
	}

	public virtual NSNumber Minimum
	{
		[Export("minimum")]
		get
		{
			return (NSNumber)(__mt_Minimum_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMinimumHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMinimumHandle)))));
		}
		[Export("setMinimum:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMinimum_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMinimum_Handle, value.Handle);
			}
			__mt_Minimum_var = value;
		}
	}

	public virtual NSNumber Maximum
	{
		[Export("maximum")]
		get
		{
			return (NSNumber)(__mt_Maximum_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaximumHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMaximumHandle)))));
		}
		[Export("setMaximum:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMaximum_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMaximum_Handle, value.Handle);
			}
			__mt_Maximum_var = value;
		}
	}

	public virtual string CurrencyGroupingSeparator
	{
		[Export("currencyGroupingSeparator")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrencyGroupingSeparatorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrencyGroupingSeparatorHandle));
		}
		[Export("setCurrencyGroupingSeparator:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrencyGroupingSeparator_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrencyGroupingSeparator_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool Lenient
	{
		[Export("isLenient")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLenientHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLenientHandle);
		}
		[Export("setLenient:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLenient_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLenient_Handle, value);
			}
		}
	}

	public virtual bool UsesSignificantDigits
	{
		[Export("usesSignificantDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesSignificantDigitsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesSignificantDigitsHandle);
		}
		[Export("setUsesSignificantDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesSignificantDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesSignificantDigits_Handle, value);
			}
		}
	}

	public virtual ulong MinimumSignificantDigits
	{
		[Export("minimumSignificantDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMinimumSignificantDigitsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMinimumSignificantDigitsHandle);
		}
		[Export("setMinimumSignificantDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMinimumSignificantDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMinimumSignificantDigits_Handle, value);
			}
		}
	}

	public virtual ulong MaximumSignificantDigits
	{
		[Export("maximumSignificantDigits")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMaximumSignificantDigitsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMaximumSignificantDigitsHandle);
		}
		[Export("setMaximumSignificantDigits:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMaximumSignificantDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMaximumSignificantDigits_Handle, value);
			}
		}
	}

	public virtual bool PartialStringValidationEnabled
	{
		[Export("isPartialStringValidationEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPartialStringValidationEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPartialStringValidationEnabledHandle);
		}
		[Export("setPartialStringValidationEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPartialStringValidationEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPartialStringValidationEnabled_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNumberFormatter()
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
	public NSNumberFormatter(NSCoder coder)
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
	public NSNumberFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNumberFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("stringFromNumber:")]
	public virtual string StringFromNumber(NSNumber number)
	{
		if (number == null)
		{
			throw new ArgumentNullException("number");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromNumber_Handle, number.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromNumber_Handle, number.Handle));
	}

	[Export("numberFromString:")]
	public virtual NSNumber NumberFromString(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		NSNumber result = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNumberFromString_Handle, arg))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNumberFromString_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedStringFromNumber:numberStyle:")]
	public static string LocalizedStringFromNumbernumberStyle(NSNumber num, NSNumberFormatterStyle nstyle)
	{
		if (num == null)
		{
			throw new ArgumentNullException("num");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selLocalizedStringFromNumberNumberStyle_Handle, num.Handle, (ulong)nstyle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Locale_var = null;
			__mt_TextAttributesForNegativeValues_var = null;
			__mt_TextAttributesForPositiveValues_var = null;
			__mt_TextAttributesForZero_var = null;
			__mt_TextAttributesForNil_var = null;
			__mt_TextAttributesForNotANumber_var = null;
			__mt_TextAttributesForPositiveInfinity_var = null;
			__mt_TextAttributesForNegativeInfinity_var = null;
			__mt_Multiplier_var = null;
			__mt_RoundingIncrement_var = null;
			__mt_Minimum_var = null;
			__mt_Maximum_var = null;
		}
	}
}
