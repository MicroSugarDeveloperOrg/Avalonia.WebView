using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSLocale", true)]
public class NSLocale : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveCurrentLocaleDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(CurrentLocaleDidChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selSystemLocaleHandle = Selector.GetHandle("systemLocale");

	private static readonly IntPtr selCurrentLocaleHandle = Selector.GetHandle("currentLocale");

	private static readonly IntPtr selAutoupdatingCurrentLocaleHandle = Selector.GetHandle("autoupdatingCurrentLocale");

	private static readonly IntPtr selLocaleIdentifierHandle = Selector.GetHandle("localeIdentifier");

	private static readonly IntPtr selAvailableLocaleIdentifiersHandle = Selector.GetHandle("availableLocaleIdentifiers");

	private static readonly IntPtr selISOLanguageCodesHandle = Selector.GetHandle("ISOLanguageCodes");

	private static readonly IntPtr selISOCurrencyCodesHandle = Selector.GetHandle("ISOCurrencyCodes");

	private static readonly IntPtr selISOCountryCodesHandle = Selector.GetHandle("ISOCountryCodes");

	private static readonly IntPtr selCommonISOCurrencyCodesHandle = Selector.GetHandle("commonISOCurrencyCodes");

	private static readonly IntPtr selPreferredLanguagesHandle = Selector.GetHandle("preferredLanguages");

	private static readonly IntPtr selInitWithLocaleIdentifier_Handle = Selector.GetHandle("initWithLocaleIdentifier:");

	private static readonly IntPtr selComponentsFromLocaleIdentifier_Handle = Selector.GetHandle("componentsFromLocaleIdentifier:");

	private static readonly IntPtr selLocaleIdentifierFromComponents_Handle = Selector.GetHandle("localeIdentifierFromComponents:");

	private static readonly IntPtr selCanonicalLanguageIdentifierFromString_Handle = Selector.GetHandle("canonicalLanguageIdentifierFromString:");

	private static readonly IntPtr selCanonicalLocaleIdentifierFromString_Handle = Selector.GetHandle("canonicalLocaleIdentifierFromString:");

	private static readonly IntPtr selCharacterDirectionForLanguage_Handle = Selector.GetHandle("characterDirectionForLanguage:");

	private static readonly IntPtr selLineDirectionForLanguage_Handle = Selector.GetHandle("lineDirectionForLanguage:");

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	private static readonly IntPtr selDisplayNameForKeyValue_Handle = Selector.GetHandle("displayNameForKey:value:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSLocale");

	private static object __mt_SystemLocale_var_static;

	private static object __mt_CurrentLocale_var_static;

	private static object __mt_AutoUpdatingCurrentLocale_var_static;

	private static NSString _CurrentLocaleDidChangeNotification;

	private static NSString __Identifier;

	private static NSString __LanguageCode;

	private static NSString __CountryCode;

	private static NSString __ScriptCode;

	private static NSString __VariantCode;

	private static NSString __ExemplarCharacterSet;

	private static NSString __Calendar;

	private static NSString __CollationIdentifier;

	private static NSString __UsesMetricSystem;

	private static NSString __MeasurementSystem;

	private static NSString __DecimalSeparator;

	private static NSString __GroupingSeparator;

	private static NSString __CurrencySymbol;

	private static NSString __CurrencyCode;

	private static NSString __CollatorIdentifier;

	private static NSString __QuotationBeginDelimiterKey;

	private static NSString __QuotationEndDelimiterKey;

	private static NSString __AlternateQuotationBeginDelimiterKey;

	private static NSString __AlternateQuotationEndDelimiterKey;

	public string Identifier => (NSString)ObjectForKey(_Identifier);

	public string LanguageCode => (NSString)ObjectForKey(_LanguageCode);

	public string CountryCode => (NSString)ObjectForKey(_CountryCode);

	public string ScriptCode => (NSString)ObjectForKey(_ScriptCode);

	public string VariantCode => (NSString)ObjectForKey(_VariantCode);

	public NSCharacterSet ExemplarCharacterSet => ObjectForKey(_ExemplarCharacterSet) as NSCharacterSet;

	public NSCalendar Calendar => ObjectForKey(_Calendar) as NSCalendar;

	public string CollationIdentifier => (NSString)ObjectForKey(_CollationIdentifier);

	public bool UsesMetricSystem => ((NSNumber)ObjectForKey(_UsesMetricSystem)).Int32Value != 0;

	public string MeasurementSystem => (NSString)ObjectForKey(_MeasurementSystem);

	public string DecimalSeparator => (NSString)ObjectForKey(_DecimalSeparator);

	public string GroupingSeparator => (NSString)ObjectForKey(_GroupingSeparator);

	public string CurrencySymbol => (NSString)ObjectForKey(_CurrencySymbol);

	public string CurrencyCode => (NSString)ObjectForKey(_CurrencyCode);

	public string CollatorIdentifier => (NSString)ObjectForKey(_CollatorIdentifier);

	public string QuotationBeginDelimiterKey => (NSString)ObjectForKey(_QuotationBeginDelimiterKey);

	public string QuotationEndDelimiterKey => (NSString)ObjectForKey(_QuotationEndDelimiterKey);

	public string AlternateQuotationBeginDelimiterKey => (NSString)ObjectForKey(_AlternateQuotationBeginDelimiterKey);

	public string AlternateQuotationEndDelimiterKey => (NSString)ObjectForKey(_AlternateQuotationEndDelimiterKey);

	public override IntPtr ClassHandle => class_ptr;

	public static NSLocale SystemLocale
	{
		[Export("systemLocale")]
		get
		{
			return (NSLocale)(__mt_SystemLocale_var_static = (NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemLocaleHandle)));
		}
	}

	public static NSLocale CurrentLocale
	{
		[Export("currentLocale")]
		get
		{
			return (NSLocale)(__mt_CurrentLocale_var_static = (NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentLocaleHandle)));
		}
	}

	public static NSLocale AutoUpdatingCurrentLocale
	{
		[Export("autoupdatingCurrentLocale")]
		get
		{
			return (NSLocale)(__mt_AutoUpdatingCurrentLocale_var_static = (NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAutoupdatingCurrentLocaleHandle)));
		}
	}

	public virtual string LocaleIdentifier
	{
		[Export("localeIdentifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleIdentifierHandle));
		}
	}

	public static string[] AvailableLocaleIdentifiers
	{
		[Export("availableLocaleIdentifiers")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAvailableLocaleIdentifiersHandle));
		}
	}

	public static string[] ISOLanguageCodes
	{
		[Export("ISOLanguageCodes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selISOLanguageCodesHandle));
		}
	}

	public static string[] ISOCurrencyCodes
	{
		[Export("ISOCurrencyCodes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selISOCurrencyCodesHandle));
		}
	}

	public static string[] ISOCountryCodes
	{
		[Export("ISOCountryCodes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selISOCountryCodesHandle));
		}
	}

	public static string[] CommonISOCurrencyCodes
	{
		[Export("commonISOCurrencyCodes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selCommonISOCurrencyCodesHandle));
		}
	}

	public static string[] PreferredLanguages
	{
		[Export("preferredLanguages")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selPreferredLanguagesHandle));
		}
	}

	[Field("NSCurrentLocaleDidChangeNotification", "Foundation")]
	public static NSString CurrentLocaleDidChangeNotification
	{
		get
		{
			if (_CurrentLocaleDidChangeNotification == null)
			{
				_CurrentLocaleDidChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCurrentLocaleDidChangeNotification");
			}
			return _CurrentLocaleDidChangeNotification;
		}
	}

	[Field("NSLocaleIdentifier", "Foundation")]
	internal static NSString _Identifier
	{
		get
		{
			if (__Identifier == null)
			{
				__Identifier = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleIdentifier");
			}
			return __Identifier;
		}
	}

	[Field("NSLocaleLanguageCode", "Foundation")]
	internal static NSString _LanguageCode
	{
		get
		{
			if (__LanguageCode == null)
			{
				__LanguageCode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleLanguageCode");
			}
			return __LanguageCode;
		}
	}

	[Field("NSLocaleCountryCode", "Foundation")]
	internal static NSString _CountryCode
	{
		get
		{
			if (__CountryCode == null)
			{
				__CountryCode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleCountryCode");
			}
			return __CountryCode;
		}
	}

	[Field("NSLocaleScriptCode", "Foundation")]
	internal static NSString _ScriptCode
	{
		get
		{
			if (__ScriptCode == null)
			{
				__ScriptCode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleScriptCode");
			}
			return __ScriptCode;
		}
	}

	[Field("NSLocaleVariantCode", "Foundation")]
	internal static NSString _VariantCode
	{
		get
		{
			if (__VariantCode == null)
			{
				__VariantCode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleVariantCode");
			}
			return __VariantCode;
		}
	}

	[Field("NSLocaleExemplarCharacterSet", "Foundation")]
	internal static NSString _ExemplarCharacterSet
	{
		get
		{
			if (__ExemplarCharacterSet == null)
			{
				__ExemplarCharacterSet = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleExemplarCharacterSet");
			}
			return __ExemplarCharacterSet;
		}
	}

	[Field("NSLocaleCalendar", "Foundation")]
	internal static NSString _Calendar
	{
		get
		{
			if (__Calendar == null)
			{
				__Calendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleCalendar");
			}
			return __Calendar;
		}
	}

	[Field("NSLocaleCollationIdentifier", "Foundation")]
	internal static NSString _CollationIdentifier
	{
		get
		{
			if (__CollationIdentifier == null)
			{
				__CollationIdentifier = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleCollationIdentifier");
			}
			return __CollationIdentifier;
		}
	}

	[Field("NSLocaleUsesMetricSystem", "Foundation")]
	internal static NSString _UsesMetricSystem
	{
		get
		{
			if (__UsesMetricSystem == null)
			{
				__UsesMetricSystem = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleUsesMetricSystem");
			}
			return __UsesMetricSystem;
		}
	}

	[Field("NSLocaleMeasurementSystem", "Foundation")]
	internal static NSString _MeasurementSystem
	{
		get
		{
			if (__MeasurementSystem == null)
			{
				__MeasurementSystem = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleMeasurementSystem");
			}
			return __MeasurementSystem;
		}
	}

	[Field("NSLocaleDecimalSeparator", "Foundation")]
	internal static NSString _DecimalSeparator
	{
		get
		{
			if (__DecimalSeparator == null)
			{
				__DecimalSeparator = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleDecimalSeparator");
			}
			return __DecimalSeparator;
		}
	}

	[Field("NSLocaleGroupingSeparator", "Foundation")]
	internal static NSString _GroupingSeparator
	{
		get
		{
			if (__GroupingSeparator == null)
			{
				__GroupingSeparator = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleGroupingSeparator");
			}
			return __GroupingSeparator;
		}
	}

	[Field("NSLocaleCurrencySymbol", "Foundation")]
	internal static NSString _CurrencySymbol
	{
		get
		{
			if (__CurrencySymbol == null)
			{
				__CurrencySymbol = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleCurrencySymbol");
			}
			return __CurrencySymbol;
		}
	}

	[Field("NSLocaleCurrencyCode", "Foundation")]
	internal static NSString _CurrencyCode
	{
		get
		{
			if (__CurrencyCode == null)
			{
				__CurrencyCode = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleCurrencyCode");
			}
			return __CurrencyCode;
		}
	}

	[Field("NSLocaleCollatorIdentifier", "Foundation")]
	internal static NSString _CollatorIdentifier
	{
		get
		{
			if (__CollatorIdentifier == null)
			{
				__CollatorIdentifier = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleCollatorIdentifier");
			}
			return __CollatorIdentifier;
		}
	}

	[Field("NSLocaleQuotationBeginDelimiterKey", "Foundation")]
	internal static NSString _QuotationBeginDelimiterKey
	{
		get
		{
			if (__QuotationBeginDelimiterKey == null)
			{
				__QuotationBeginDelimiterKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleQuotationBeginDelimiterKey");
			}
			return __QuotationBeginDelimiterKey;
		}
	}

	[Field("NSLocaleQuotationEndDelimiterKey", "Foundation")]
	internal static NSString _QuotationEndDelimiterKey
	{
		get
		{
			if (__QuotationEndDelimiterKey == null)
			{
				__QuotationEndDelimiterKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleQuotationEndDelimiterKey");
			}
			return __QuotationEndDelimiterKey;
		}
	}

	[Field("NSLocaleAlternateQuotationBeginDelimiterKey", "Foundation")]
	internal static NSString _AlternateQuotationBeginDelimiterKey
	{
		get
		{
			if (__AlternateQuotationBeginDelimiterKey == null)
			{
				__AlternateQuotationBeginDelimiterKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleAlternateQuotationBeginDelimiterKey");
			}
			return __AlternateQuotationBeginDelimiterKey;
		}
	}

	[Field("NSLocaleAlternateQuotationEndDelimiterKey", "Foundation")]
	internal static NSString _AlternateQuotationEndDelimiterKey
	{
		get
		{
			if (__AlternateQuotationEndDelimiterKey == null)
			{
				__AlternateQuotationEndDelimiterKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocaleAlternateQuotationEndDelimiterKey");
			}
			return __AlternateQuotationEndDelimiterKey;
		}
	}

	public string GetIdentifierDisplayName(string value)
	{
		return DisplayNameForKey(_Identifier, value);
	}

	public string GetLanguageCodeDisplayName(string value)
	{
		return DisplayNameForKey(_LanguageCode, value);
	}

	public string GetCountryCodeDisplayName(string value)
	{
		return DisplayNameForKey(_CountryCode, value);
	}

	public string GetCurrencyCodeDisplayName(string value)
	{
		return DisplayNameForKey(_CurrencyCode, value);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSLocale(NSCoder coder)
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
	public NSLocale(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLocale(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLocaleIdentifier:")]
	public NSLocale(string identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithLocaleIdentifier_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithLocaleIdentifier_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("componentsFromLocaleIdentifier:")]
	public static NSDictionary ComponentsFromLocaleIdentifier(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selComponentsFromLocaleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localeIdentifierFromComponents:")]
	public static string LocaleIdentifierFromComponents(NSDictionary dict)
	{
		if (dict == null)
		{
			throw new ArgumentNullException("dict");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocaleIdentifierFromComponents_Handle, dict.Handle));
	}

	[Export("canonicalLanguageIdentifierFromString:")]
	public static string CanonicalLanguageIdentifierFromString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCanonicalLanguageIdentifierFromString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("canonicalLocaleIdentifierFromString:")]
	public static string CanonicalLocaleIdentifierFromString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCanonicalLocaleIdentifierFromString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("characterDirectionForLanguage:")]
	public static NSLocaleLanguageDirection GetCharacterDirection(string isoLanguageCode)
	{
		if (isoLanguageCode == null)
		{
			throw new ArgumentNullException("isoLanguageCode");
		}
		IntPtr arg = NSString.CreateNative(isoLanguageCode);
		ulong result = Messaging.UInt64_objc_msgSend_IntPtr(class_ptr, selCharacterDirectionForLanguage_Handle, arg);
		NSString.ReleaseNative(arg);
		return (NSLocaleLanguageDirection)result;
	}

	[Export("lineDirectionForLanguage:")]
	public static NSLocaleLanguageDirection GetLineDirection(string isoLanguageCode)
	{
		if (isoLanguageCode == null)
		{
			throw new ArgumentNullException("isoLanguageCode");
		}
		IntPtr arg = NSString.CreateNative(isoLanguageCode);
		ulong result = Messaging.UInt64_objc_msgSend_IntPtr(class_ptr, selLineDirectionForLanguage_Handle, arg);
		NSString.ReleaseNative(arg);
		return (NSLocaleLanguageDirection)result;
	}

	[Export("objectForKey:")]
	internal virtual NSObject ObjectForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, key.Handle));
	}

	[Export("displayNameForKey:value:")]
	internal virtual NSString DisplayNameForKey(NSString key, string value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(value);
		NSString result = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDisplayNameForKeyValue_Handle, key.Handle, arg))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDisplayNameForKeyValue_Handle, key.Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}
}
