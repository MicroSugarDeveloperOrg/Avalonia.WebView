using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNumberFormatter", true)]
public class NSNumberFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsFloats = "allowsFloats";

	private static readonly IntPtr selAllowsFloatsHandle = Selector.GetHandle("allowsFloats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlwaysShowsDecimalSeparator = "alwaysShowsDecimalSeparator";

	private static readonly IntPtr selAlwaysShowsDecimalSeparatorHandle = Selector.GetHandle("alwaysShowsDecimalSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrencyCode = "currencyCode";

	private static readonly IntPtr selCurrencyCodeHandle = Selector.GetHandle("currencyCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrencyDecimalSeparator = "currencyDecimalSeparator";

	private static readonly IntPtr selCurrencyDecimalSeparatorHandle = Selector.GetHandle("currencyDecimalSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrencyGroupingSeparator = "currencyGroupingSeparator";

	private static readonly IntPtr selCurrencyGroupingSeparatorHandle = Selector.GetHandle("currencyGroupingSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrencySymbol = "currencySymbol";

	private static readonly IntPtr selCurrencySymbolHandle = Selector.GetHandle("currencySymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalSeparator = "decimalSeparator";

	private static readonly IntPtr selDecimalSeparatorHandle = Selector.GetHandle("decimalSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultFormatterBehavior = "defaultFormatterBehavior";

	private static readonly IntPtr selDefaultFormatterBehaviorHandle = Selector.GetHandle("defaultFormatterBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExponentSymbol = "exponentSymbol";

	private static readonly IntPtr selExponentSymbolHandle = Selector.GetHandle("exponentSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatWidth = "formatWidth";

	private static readonly IntPtr selFormatWidthHandle = Selector.GetHandle("formatWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatterBehavior = "formatterBehavior";

	private static readonly IntPtr selFormatterBehaviorHandle = Selector.GetHandle("formatterBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeneratesDecimalNumbers = "generatesDecimalNumbers";

	private static readonly IntPtr selGeneratesDecimalNumbersHandle = Selector.GetHandle("generatesDecimalNumbers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupingSeparator = "groupingSeparator";

	private static readonly IntPtr selGroupingSeparatorHandle = Selector.GetHandle("groupingSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupingSize = "groupingSize";

	private static readonly IntPtr selGroupingSizeHandle = Selector.GetHandle("groupingSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInternationalCurrencySymbol = "internationalCurrencySymbol";

	private static readonly IntPtr selInternationalCurrencySymbolHandle = Selector.GetHandle("internationalCurrencySymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLenient = "isLenient";

	private static readonly IntPtr selIsLenientHandle = Selector.GetHandle("isLenient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPartialStringValidationEnabled = "isPartialStringValidationEnabled";

	private static readonly IntPtr selIsPartialStringValidationEnabledHandle = Selector.GetHandle("isPartialStringValidationEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringFromNumber_NumberStyle_ = "localizedStringFromNumber:numberStyle:";

	private static readonly IntPtr selLocalizedStringFromNumber_NumberStyle_Handle = Selector.GetHandle("localizedStringFromNumber:numberStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximum = "maximum";

	private static readonly IntPtr selMaximumHandle = Selector.GetHandle("maximum");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumFractionDigits = "maximumFractionDigits";

	private static readonly IntPtr selMaximumFractionDigitsHandle = Selector.GetHandle("maximumFractionDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumIntegerDigits = "maximumIntegerDigits";

	private static readonly IntPtr selMaximumIntegerDigitsHandle = Selector.GetHandle("maximumIntegerDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumSignificantDigits = "maximumSignificantDigits";

	private static readonly IntPtr selMaximumSignificantDigitsHandle = Selector.GetHandle("maximumSignificantDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimum = "minimum";

	private static readonly IntPtr selMinimumHandle = Selector.GetHandle("minimum");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumFractionDigits = "minimumFractionDigits";

	private static readonly IntPtr selMinimumFractionDigitsHandle = Selector.GetHandle("minimumFractionDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumIntegerDigits = "minimumIntegerDigits";

	private static readonly IntPtr selMinimumIntegerDigitsHandle = Selector.GetHandle("minimumIntegerDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumSignificantDigits = "minimumSignificantDigits";

	private static readonly IntPtr selMinimumSignificantDigitsHandle = Selector.GetHandle("minimumSignificantDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinusSign = "minusSign";

	private static readonly IntPtr selMinusSignHandle = Selector.GetHandle("minusSign");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiplier = "multiplier";

	private static readonly IntPtr selMultiplierHandle = Selector.GetHandle("multiplier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNegativeFormat = "negativeFormat";

	private static readonly IntPtr selNegativeFormatHandle = Selector.GetHandle("negativeFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNegativeInfinitySymbol = "negativeInfinitySymbol";

	private static readonly IntPtr selNegativeInfinitySymbolHandle = Selector.GetHandle("negativeInfinitySymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNegativePrefix = "negativePrefix";

	private static readonly IntPtr selNegativePrefixHandle = Selector.GetHandle("negativePrefix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNegativeSuffix = "negativeSuffix";

	private static readonly IntPtr selNegativeSuffixHandle = Selector.GetHandle("negativeSuffix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNilSymbol = "nilSymbol";

	private static readonly IntPtr selNilSymbolHandle = Selector.GetHandle("nilSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotANumberSymbol = "notANumberSymbol";

	private static readonly IntPtr selNotANumberSymbolHandle = Selector.GetHandle("notANumberSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberFromString_ = "numberFromString:";

	private static readonly IntPtr selNumberFromString_Handle = Selector.GetHandle("numberFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberStyle = "numberStyle";

	private static readonly IntPtr selNumberStyleHandle = Selector.GetHandle("numberStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingCharacter = "paddingCharacter";

	private static readonly IntPtr selPaddingCharacterHandle = Selector.GetHandle("paddingCharacter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingPosition = "paddingPosition";

	private static readonly IntPtr selPaddingPositionHandle = Selector.GetHandle("paddingPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerMillSymbol = "perMillSymbol";

	private static readonly IntPtr selPerMillSymbolHandle = Selector.GetHandle("perMillSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPercentSymbol = "percentSymbol";

	private static readonly IntPtr selPercentSymbolHandle = Selector.GetHandle("percentSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlusSign = "plusSign";

	private static readonly IntPtr selPlusSignHandle = Selector.GetHandle("plusSign");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositiveFormat = "positiveFormat";

	private static readonly IntPtr selPositiveFormatHandle = Selector.GetHandle("positiveFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositiveInfinitySymbol = "positiveInfinitySymbol";

	private static readonly IntPtr selPositiveInfinitySymbolHandle = Selector.GetHandle("positiveInfinitySymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositivePrefix = "positivePrefix";

	private static readonly IntPtr selPositivePrefixHandle = Selector.GetHandle("positivePrefix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositiveSuffix = "positiveSuffix";

	private static readonly IntPtr selPositiveSuffixHandle = Selector.GetHandle("positiveSuffix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoundingIncrement = "roundingIncrement";

	private static readonly IntPtr selRoundingIncrementHandle = Selector.GetHandle("roundingIncrement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoundingMode = "roundingMode";

	private static readonly IntPtr selRoundingModeHandle = Selector.GetHandle("roundingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryGroupingSize = "secondaryGroupingSize";

	private static readonly IntPtr selSecondaryGroupingSizeHandle = Selector.GetHandle("secondaryGroupingSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsFloats_ = "setAllowsFloats:";

	private static readonly IntPtr selSetAllowsFloats_Handle = Selector.GetHandle("setAllowsFloats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlwaysShowsDecimalSeparator_ = "setAlwaysShowsDecimalSeparator:";

	private static readonly IntPtr selSetAlwaysShowsDecimalSeparator_Handle = Selector.GetHandle("setAlwaysShowsDecimalSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrencyCode_ = "setCurrencyCode:";

	private static readonly IntPtr selSetCurrencyCode_Handle = Selector.GetHandle("setCurrencyCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrencyDecimalSeparator_ = "setCurrencyDecimalSeparator:";

	private static readonly IntPtr selSetCurrencyDecimalSeparator_Handle = Selector.GetHandle("setCurrencyDecimalSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrencyGroupingSeparator_ = "setCurrencyGroupingSeparator:";

	private static readonly IntPtr selSetCurrencyGroupingSeparator_Handle = Selector.GetHandle("setCurrencyGroupingSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrencySymbol_ = "setCurrencySymbol:";

	private static readonly IntPtr selSetCurrencySymbol_Handle = Selector.GetHandle("setCurrencySymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDecimalSeparator_ = "setDecimalSeparator:";

	private static readonly IntPtr selSetDecimalSeparator_Handle = Selector.GetHandle("setDecimalSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultFormatterBehavior_ = "setDefaultFormatterBehavior:";

	private static readonly IntPtr selSetDefaultFormatterBehavior_Handle = Selector.GetHandle("setDefaultFormatterBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExponentSymbol_ = "setExponentSymbol:";

	private static readonly IntPtr selSetExponentSymbol_Handle = Selector.GetHandle("setExponentSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormatWidth_ = "setFormatWidth:";

	private static readonly IntPtr selSetFormatWidth_Handle = Selector.GetHandle("setFormatWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormatterBehavior_ = "setFormatterBehavior:";

	private static readonly IntPtr selSetFormatterBehavior_Handle = Selector.GetHandle("setFormatterBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGeneratesDecimalNumbers_ = "setGeneratesDecimalNumbers:";

	private static readonly IntPtr selSetGeneratesDecimalNumbers_Handle = Selector.GetHandle("setGeneratesDecimalNumbers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupingSeparator_ = "setGroupingSeparator:";

	private static readonly IntPtr selSetGroupingSeparator_Handle = Selector.GetHandle("setGroupingSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupingSize_ = "setGroupingSize:";

	private static readonly IntPtr selSetGroupingSize_Handle = Selector.GetHandle("setGroupingSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInternationalCurrencySymbol_ = "setInternationalCurrencySymbol:";

	private static readonly IntPtr selSetInternationalCurrencySymbol_Handle = Selector.GetHandle("setInternationalCurrencySymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLenient_ = "setLenient:";

	private static readonly IntPtr selSetLenient_Handle = Selector.GetHandle("setLenient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocale_ = "setLocale:";

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximum_ = "setMaximum:";

	private static readonly IntPtr selSetMaximum_Handle = Selector.GetHandle("setMaximum:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumFractionDigits_ = "setMaximumFractionDigits:";

	private static readonly IntPtr selSetMaximumFractionDigits_Handle = Selector.GetHandle("setMaximumFractionDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumIntegerDigits_ = "setMaximumIntegerDigits:";

	private static readonly IntPtr selSetMaximumIntegerDigits_Handle = Selector.GetHandle("setMaximumIntegerDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumSignificantDigits_ = "setMaximumSignificantDigits:";

	private static readonly IntPtr selSetMaximumSignificantDigits_Handle = Selector.GetHandle("setMaximumSignificantDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimum_ = "setMinimum:";

	private static readonly IntPtr selSetMinimum_Handle = Selector.GetHandle("setMinimum:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumFractionDigits_ = "setMinimumFractionDigits:";

	private static readonly IntPtr selSetMinimumFractionDigits_Handle = Selector.GetHandle("setMinimumFractionDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumIntegerDigits_ = "setMinimumIntegerDigits:";

	private static readonly IntPtr selSetMinimumIntegerDigits_Handle = Selector.GetHandle("setMinimumIntegerDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumSignificantDigits_ = "setMinimumSignificantDigits:";

	private static readonly IntPtr selSetMinimumSignificantDigits_Handle = Selector.GetHandle("setMinimumSignificantDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinusSign_ = "setMinusSign:";

	private static readonly IntPtr selSetMinusSign_Handle = Selector.GetHandle("setMinusSign:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMultiplier_ = "setMultiplier:";

	private static readonly IntPtr selSetMultiplier_Handle = Selector.GetHandle("setMultiplier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNegativeFormat_ = "setNegativeFormat:";

	private static readonly IntPtr selSetNegativeFormat_Handle = Selector.GetHandle("setNegativeFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNegativeInfinitySymbol_ = "setNegativeInfinitySymbol:";

	private static readonly IntPtr selSetNegativeInfinitySymbol_Handle = Selector.GetHandle("setNegativeInfinitySymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNegativePrefix_ = "setNegativePrefix:";

	private static readonly IntPtr selSetNegativePrefix_Handle = Selector.GetHandle("setNegativePrefix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNegativeSuffix_ = "setNegativeSuffix:";

	private static readonly IntPtr selSetNegativeSuffix_Handle = Selector.GetHandle("setNegativeSuffix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNilSymbol_ = "setNilSymbol:";

	private static readonly IntPtr selSetNilSymbol_Handle = Selector.GetHandle("setNilSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNotANumberSymbol_ = "setNotANumberSymbol:";

	private static readonly IntPtr selSetNotANumberSymbol_Handle = Selector.GetHandle("setNotANumberSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberStyle_ = "setNumberStyle:";

	private static readonly IntPtr selSetNumberStyle_Handle = Selector.GetHandle("setNumberStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaddingCharacter_ = "setPaddingCharacter:";

	private static readonly IntPtr selSetPaddingCharacter_Handle = Selector.GetHandle("setPaddingCharacter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaddingPosition_ = "setPaddingPosition:";

	private static readonly IntPtr selSetPaddingPosition_Handle = Selector.GetHandle("setPaddingPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPartialStringValidationEnabled_ = "setPartialStringValidationEnabled:";

	private static readonly IntPtr selSetPartialStringValidationEnabled_Handle = Selector.GetHandle("setPartialStringValidationEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerMillSymbol_ = "setPerMillSymbol:";

	private static readonly IntPtr selSetPerMillSymbol_Handle = Selector.GetHandle("setPerMillSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPercentSymbol_ = "setPercentSymbol:";

	private static readonly IntPtr selSetPercentSymbol_Handle = Selector.GetHandle("setPercentSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlusSign_ = "setPlusSign:";

	private static readonly IntPtr selSetPlusSign_Handle = Selector.GetHandle("setPlusSign:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPositiveFormat_ = "setPositiveFormat:";

	private static readonly IntPtr selSetPositiveFormat_Handle = Selector.GetHandle("setPositiveFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPositiveInfinitySymbol_ = "setPositiveInfinitySymbol:";

	private static readonly IntPtr selSetPositiveInfinitySymbol_Handle = Selector.GetHandle("setPositiveInfinitySymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPositivePrefix_ = "setPositivePrefix:";

	private static readonly IntPtr selSetPositivePrefix_Handle = Selector.GetHandle("setPositivePrefix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPositiveSuffix_ = "setPositiveSuffix:";

	private static readonly IntPtr selSetPositiveSuffix_Handle = Selector.GetHandle("setPositiveSuffix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRoundingIncrement_ = "setRoundingIncrement:";

	private static readonly IntPtr selSetRoundingIncrement_Handle = Selector.GetHandle("setRoundingIncrement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRoundingMode_ = "setRoundingMode:";

	private static readonly IntPtr selSetRoundingMode_Handle = Selector.GetHandle("setRoundingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryGroupingSize_ = "setSecondaryGroupingSize:";

	private static readonly IntPtr selSetSecondaryGroupingSize_Handle = Selector.GetHandle("setSecondaryGroupingSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAttributesForNegativeInfinity_ = "setTextAttributesForNegativeInfinity:";

	private static readonly IntPtr selSetTextAttributesForNegativeInfinity_Handle = Selector.GetHandle("setTextAttributesForNegativeInfinity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAttributesForNegativeValues_ = "setTextAttributesForNegativeValues:";

	private static readonly IntPtr selSetTextAttributesForNegativeValues_Handle = Selector.GetHandle("setTextAttributesForNegativeValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAttributesForNil_ = "setTextAttributesForNil:";

	private static readonly IntPtr selSetTextAttributesForNil_Handle = Selector.GetHandle("setTextAttributesForNil:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAttributesForNotANumber_ = "setTextAttributesForNotANumber:";

	private static readonly IntPtr selSetTextAttributesForNotANumber_Handle = Selector.GetHandle("setTextAttributesForNotANumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAttributesForPositiveInfinity_ = "setTextAttributesForPositiveInfinity:";

	private static readonly IntPtr selSetTextAttributesForPositiveInfinity_Handle = Selector.GetHandle("setTextAttributesForPositiveInfinity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAttributesForPositiveValues_ = "setTextAttributesForPositiveValues:";

	private static readonly IntPtr selSetTextAttributesForPositiveValues_Handle = Selector.GetHandle("setTextAttributesForPositiveValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextAttributesForZero_ = "setTextAttributesForZero:";

	private static readonly IntPtr selSetTextAttributesForZero_Handle = Selector.GetHandle("setTextAttributesForZero:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesGroupingSeparator_ = "setUsesGroupingSeparator:";

	private static readonly IntPtr selSetUsesGroupingSeparator_Handle = Selector.GetHandle("setUsesGroupingSeparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesSignificantDigits_ = "setUsesSignificantDigits:";

	private static readonly IntPtr selSetUsesSignificantDigits_Handle = Selector.GetHandle("setUsesSignificantDigits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZeroSymbol_ = "setZeroSymbol:";

	private static readonly IntPtr selSetZeroSymbol_Handle = Selector.GetHandle("setZeroSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromNumber_ = "stringFromNumber:";

	private static readonly IntPtr selStringFromNumber_Handle = Selector.GetHandle("stringFromNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextAttributesForNegativeInfinity = "textAttributesForNegativeInfinity";

	private static readonly IntPtr selTextAttributesForNegativeInfinityHandle = Selector.GetHandle("textAttributesForNegativeInfinity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextAttributesForNegativeValues = "textAttributesForNegativeValues";

	private static readonly IntPtr selTextAttributesForNegativeValuesHandle = Selector.GetHandle("textAttributesForNegativeValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextAttributesForNil = "textAttributesForNil";

	private static readonly IntPtr selTextAttributesForNilHandle = Selector.GetHandle("textAttributesForNil");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextAttributesForNotANumber = "textAttributesForNotANumber";

	private static readonly IntPtr selTextAttributesForNotANumberHandle = Selector.GetHandle("textAttributesForNotANumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextAttributesForPositiveInfinity = "textAttributesForPositiveInfinity";

	private static readonly IntPtr selTextAttributesForPositiveInfinityHandle = Selector.GetHandle("textAttributesForPositiveInfinity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextAttributesForPositiveValues = "textAttributesForPositiveValues";

	private static readonly IntPtr selTextAttributesForPositiveValuesHandle = Selector.GetHandle("textAttributesForPositiveValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextAttributesForZero = "textAttributesForZero";

	private static readonly IntPtr selTextAttributesForZeroHandle = Selector.GetHandle("textAttributesForZero");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesGroupingSeparator = "usesGroupingSeparator";

	private static readonly IntPtr selUsesGroupingSeparatorHandle = Selector.GetHandle("usesGroupingSeparator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesSignificantDigits = "usesSignificantDigits";

	private static readonly IntPtr selUsesSignificantDigitsHandle = Selector.GetHandle("usesSignificantDigits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZeroSymbol = "zeroSymbol";

	private static readonly IntPtr selZeroSymbolHandle = Selector.GetHandle("zeroSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSNumberFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsFloats
	{
		[Export("allowsFloats")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsFloatsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsFloatsHandle);
		}
		[Export("setAllowsFloats:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsFloats_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsFloats_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AlwaysShowsDecimalSeparator
	{
		[Export("alwaysShowsDecimalSeparator")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysShowsDecimalSeparatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysShowsDecimalSeparatorHandle);
		}
		[Export("setAlwaysShowsDecimalSeparator:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysShowsDecimalSeparator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysShowsDecimalSeparator_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CurrencyCode
	{
		[Export("currencyCode")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CurrencyDecimalSeparator
	{
		[Export("currencyDecimalSeparator")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CurrencyGroupingSeparator
	{
		[Export("currencyGroupingSeparator")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CurrencySymbol
	{
		[Export("currencySymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DecimalSeparator
	{
		[Export("decimalSeparator")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ExponentSymbol
	{
		[Export("exponentSymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FormatWidth
	{
		[Export("formatWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFormatWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFormatWidthHandle);
		}
		[Export("setFormatWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetFormatWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetFormatWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumberFormatterBehavior FormatterBehavior
	{
		[Export("formatterBehavior")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSNumberFormatterBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selFormatterBehaviorHandle);
			}
			return (NSNumberFormatterBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatterBehaviorHandle);
		}
		[Export("setFormatterBehavior:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFormatterBehavior_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFormatterBehavior_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GeneratesDecimalNumbers
	{
		[Export("generatesDecimalNumbers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selGeneratesDecimalNumbersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGeneratesDecimalNumbersHandle);
		}
		[Export("setGeneratesDecimalNumbers:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGeneratesDecimalNumbers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGeneratesDecimalNumbers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GroupingSeparator
	{
		[Export("groupingSeparator")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GroupingSize
	{
		[Export("groupingSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selGroupingSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selGroupingSizeHandle);
		}
		[Export("setGroupingSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetGroupingSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetGroupingSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string InternationalCurrencySymbol
	{
		[Export("internationalCurrencySymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Lenient
	{
		[Export("isLenient")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLenientHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLenientHandle);
		}
		[Export("setLenient:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLenient_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLenient_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale Locale
	{
		[Export("locale", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle));
			}
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle));
		}
		[Export("setLocale:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocale_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocale_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? Maximum
	{
		[Export("maximum", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selMaximumHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaximumHandle));
		}
		[Export("setMaximum:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMaximum_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMaximum_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumFractionDigits
	{
		[Export("maximumFractionDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumFractionDigitsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumFractionDigitsHandle);
		}
		[Export("setMaximumFractionDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaximumFractionDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaximumFractionDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumIntegerDigits
	{
		[Export("maximumIntegerDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumIntegerDigitsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumIntegerDigitsHandle);
		}
		[Export("setMaximumIntegerDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaximumIntegerDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaximumIntegerDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaximumSignificantDigits
	{
		[Export("maximumSignificantDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaximumSignificantDigitsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaximumSignificantDigitsHandle);
		}
		[Export("setMaximumSignificantDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaximumSignificantDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaximumSignificantDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? Minimum
	{
		[Export("minimum", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selMinimumHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMinimumHandle));
		}
		[Export("setMinimum:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMinimum_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMinimum_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MinimumFractionDigits
	{
		[Export("minimumFractionDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMinimumFractionDigitsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMinimumFractionDigitsHandle);
		}
		[Export("setMinimumFractionDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMinimumFractionDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMinimumFractionDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MinimumIntegerDigits
	{
		[Export("minimumIntegerDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMinimumIntegerDigitsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMinimumIntegerDigitsHandle);
		}
		[Export("setMinimumIntegerDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMinimumIntegerDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMinimumIntegerDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MinimumSignificantDigits
	{
		[Export("minimumSignificantDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMinimumSignificantDigitsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMinimumSignificantDigitsHandle);
		}
		[Export("setMinimumSignificantDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMinimumSignificantDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMinimumSignificantDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MinusSign
	{
		[Export("minusSign")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? Multiplier
	{
		[Export("multiplier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selMultiplierHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultiplierHandle));
		}
		[Export("setMultiplier:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMultiplier_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMultiplier_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NegativeFormat
	{
		[Export("negativeFormat")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NegativeInfinitySymbol
	{
		[Export("negativeInfinitySymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NegativePrefix
	{
		[Export("negativePrefix")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NegativeSuffix
	{
		[Export("negativeSuffix")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NilSymbol
	{
		[Export("nilSymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NotANumberSymbol
	{
		[Export("notANumberSymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumberFormatterStyle NumberStyle
	{
		[Export("numberStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSNumberFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selNumberStyleHandle);
			}
			return (NSNumberFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNumberStyleHandle);
		}
		[Export("setNumberStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetNumberStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetNumberStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PaddingCharacter
	{
		[Export("paddingCharacter")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumberFormatterPadPosition PaddingPosition
	{
		[Export("paddingPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSNumberFormatterPadPosition)Messaging.UInt64_objc_msgSend(base.Handle, selPaddingPositionHandle);
			}
			return (NSNumberFormatterPadPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPaddingPositionHandle);
		}
		[Export("setPaddingPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPaddingPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPaddingPosition_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PartialStringValidationEnabled
	{
		[Export("isPartialStringValidationEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPartialStringValidationEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPartialStringValidationEnabledHandle);
		}
		[Export("setPartialStringValidationEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPartialStringValidationEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPartialStringValidationEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PerMillSymbol
	{
		[Export("perMillSymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PercentSymbol
	{
		[Export("percentSymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PlusSign
	{
		[Export("plusSign")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PositiveFormat
	{
		[Export("positiveFormat")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PositiveInfinitySymbol
	{
		[Export("positiveInfinitySymbol")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PositivePrefix
	{
		[Export("positivePrefix")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PositiveSuffix
	{
		[Export("positiveSuffix")]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber RoundingIncrement
	{
		[Export("roundingIncrement", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selRoundingIncrementHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRoundingIncrementHandle));
		}
		[Export("setRoundingIncrement:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRoundingIncrement_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRoundingIncrement_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumberFormatterRoundingMode RoundingMode
	{
		[Export("roundingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSNumberFormatterRoundingMode)Messaging.UInt64_objc_msgSend(base.Handle, selRoundingModeHandle);
			}
			return (NSNumberFormatterRoundingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRoundingModeHandle);
		}
		[Export("setRoundingMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRoundingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRoundingMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryGroupingSize
	{
		[Export("secondaryGroupingSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryGroupingSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryGroupingSizeHandle);
		}
		[Export("setSecondaryGroupingSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryGroupingSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryGroupingSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? TextAttributesForNegativeInfinity
	{
		[Export("textAttributesForNegativeInfinity", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNegativeInfinityHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNegativeInfinityHandle));
		}
		[Export("setTextAttributesForNegativeInfinity:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNegativeInfinity_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNegativeInfinity_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? TextAttributesForNegativeValues
	{
		[Export("textAttributesForNegativeValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNegativeValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNegativeValuesHandle));
		}
		[Export("setTextAttributesForNegativeValues:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNegativeValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNegativeValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? TextAttributesForNil
	{
		[Export("textAttributesForNil", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNilHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNilHandle));
		}
		[Export("setTextAttributesForNil:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNil_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNil_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? TextAttributesForNotANumber
	{
		[Export("textAttributesForNotANumber", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForNotANumberHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForNotANumberHandle));
		}
		[Export("setTextAttributesForNotANumber:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForNotANumber_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForNotANumber_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? TextAttributesForPositiveInfinity
	{
		[Export("textAttributesForPositiveInfinity", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForPositiveInfinityHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForPositiveInfinityHandle));
		}
		[Export("setTextAttributesForPositiveInfinity:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForPositiveInfinity_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForPositiveInfinity_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? TextAttributesForPositiveValues
	{
		[Export("textAttributesForPositiveValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForPositiveValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForPositiveValuesHandle));
		}
		[Export("setTextAttributesForPositiveValues:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForPositiveValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForPositiveValues_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? TextAttributesForZero
	{
		[Export("textAttributesForZero", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextAttributesForZeroHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextAttributesForZeroHandle));
		}
		[Export("setTextAttributesForZero:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextAttributesForZero_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextAttributesForZero_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesGroupingSeparator
	{
		[Export("usesGroupingSeparator")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesGroupingSeparatorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesGroupingSeparatorHandle);
		}
		[Export("setUsesGroupingSeparator:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesGroupingSeparator_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesGroupingSeparator_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesSignificantDigits
	{
		[Export("usesSignificantDigits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesSignificantDigitsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesSignificantDigitsHandle);
		}
		[Export("setUsesSignificantDigits:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesSignificantDigits_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesSignificantDigits_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ZeroSymbol
	{
		[Export("zeroSymbol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selZeroSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selZeroSymbolHandle));
		}
		[Export("setZeroSymbol:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNumberFormatter()
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
	public NSNumberFormatter(NSCoder coder)
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
	protected NSNumberFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNumberFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("localizedStringFromNumber:numberStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizedStringFromNumbernumberStyle(NSNumber num, NSNumberFormatterStyle nstyle)
	{
		if (num == null)
		{
			throw new ArgumentNullException("num");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selLocalizedStringFromNumber_NumberStyle_Handle, num.Handle, (ulong)nstyle));
	}

	[Export("numberFromString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber NumberFromString(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		NSNumber result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNumberFromString_Handle, arg)) : Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNumberFromString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringFromNumber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromNumber(NSNumber number)
	{
		if (number == null)
		{
			throw new ArgumentNullException("number");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromNumber_Handle, number.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromNumber_Handle, number.Handle));
	}
}
