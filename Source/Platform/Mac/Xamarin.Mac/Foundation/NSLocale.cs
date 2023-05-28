using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSLocale", true)]
public class NSLocale : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveCurrentLocaleDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CurrentLocaleDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCurrentLocaleDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CurrentLocaleDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selISOCountryCodes = "ISOCountryCodes";

	private static readonly IntPtr selISOCountryCodesHandle = Selector.GetHandle("ISOCountryCodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selISOCurrencyCodes = "ISOCurrencyCodes";

	private static readonly IntPtr selISOCurrencyCodesHandle = Selector.GetHandle("ISOCurrencyCodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selISOLanguageCodes = "ISOLanguageCodes";

	private static readonly IntPtr selISOLanguageCodesHandle = Selector.GetHandle("ISOLanguageCodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoupdatingCurrentLocale = "autoupdatingCurrentLocale";

	private static readonly IntPtr selAutoupdatingCurrentLocaleHandle = Selector.GetHandle("autoupdatingCurrentLocale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableLocaleIdentifiers = "availableLocaleIdentifiers";

	private static readonly IntPtr selAvailableLocaleIdentifiersHandle = Selector.GetHandle("availableLocaleIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarIdentifier = "calendarIdentifier";

	private static readonly IntPtr selCalendarIdentifierHandle = Selector.GetHandle("calendarIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanonicalLanguageIdentifierFromString_ = "canonicalLanguageIdentifierFromString:";

	private static readonly IntPtr selCanonicalLanguageIdentifierFromString_Handle = Selector.GetHandle("canonicalLanguageIdentifierFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanonicalLocaleIdentifierFromString_ = "canonicalLocaleIdentifierFromString:";

	private static readonly IntPtr selCanonicalLocaleIdentifierFromString_Handle = Selector.GetHandle("canonicalLocaleIdentifierFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterDirectionForLanguage_ = "characterDirectionForLanguage:";

	private static readonly IntPtr selCharacterDirectionForLanguage_Handle = Selector.GetHandle("characterDirectionForLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommonISOCurrencyCodes = "commonISOCurrencyCodes";

	private static readonly IntPtr selCommonISOCurrencyCodesHandle = Selector.GetHandle("commonISOCurrencyCodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentsFromLocaleIdentifier_ = "componentsFromLocaleIdentifier:";

	private static readonly IntPtr selComponentsFromLocaleIdentifier_Handle = Selector.GetHandle("componentsFromLocaleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentLocale = "currentLocale";

	private static readonly IntPtr selCurrentLocaleHandle = Selector.GetHandle("currentLocale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayNameForKey_Value_ = "displayNameForKey:value:";

	private static readonly IntPtr selDisplayNameForKey_Value_Handle = Selector.GetHandle("displayNameForKey:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLocaleIdentifier_ = "initWithLocaleIdentifier:";

	private static readonly IntPtr selInitWithLocaleIdentifier_Handle = Selector.GetHandle("initWithLocaleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineDirectionForLanguage_ = "lineDirectionForLanguage:";

	private static readonly IntPtr selLineDirectionForLanguage_Handle = Selector.GetHandle("lineDirectionForLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocaleIdentifier = "localeIdentifier";

	private static readonly IntPtr selLocaleIdentifierHandle = Selector.GetHandle("localeIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocaleIdentifierFromComponents_ = "localeIdentifierFromComponents:";

	private static readonly IntPtr selLocaleIdentifierFromComponents_Handle = Selector.GetHandle("localeIdentifierFromComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocaleWithLocaleIdentifier_ = "localeWithLocaleIdentifier:";

	private static readonly IntPtr selLocaleWithLocaleIdentifier_Handle = Selector.GetHandle("localeWithLocaleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForCalendarIdentifier_ = "localizedStringForCalendarIdentifier:";

	private static readonly IntPtr selLocalizedStringForCalendarIdentifier_Handle = Selector.GetHandle("localizedStringForCalendarIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKey_ = "objectForKey:";

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredLanguages = "preferredLanguages";

	private static readonly IntPtr selPreferredLanguagesHandle = Selector.GetHandle("preferredLanguages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemLocale = "systemLocale";

	private static readonly IntPtr selSystemLocaleHandle = Selector.GetHandle("systemLocale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLocale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CurrentLocaleDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __AlternateQuotationBeginDelimiterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __AlternateQuotationEndDelimiterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Calendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __CollationIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __CollatorIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __CountryCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __CurrencyCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __CurrencySymbol;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __DecimalSeparator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __ExemplarCharacterSet;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __GroupingSeparator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Identifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __LanguageCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __MeasurementSystem;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __QuotationBeginDelimiterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __QuotationEndDelimiterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __ScriptCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __UsesMetricSystem;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __VariantCode;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLocale AutoUpdatingCurrentLocale
	{
		[Export("autoupdatingCurrentLocale", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(class_ptr, selAutoupdatingCurrentLocaleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] AvailableLocaleIdentifiers
	{
		[Export("availableLocaleIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAvailableLocaleIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual string CalendarIdentifier
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("calendarIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] CommonISOCurrencyCodes
	{
		[Export("commonISOCurrencyCodes", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selCommonISOCurrencyCodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLocale CurrentLocale
	{
		[Export("currentLocale", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentLocaleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ISOCountryCodes
	{
		[Export("ISOCountryCodes", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selISOCountryCodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ISOCurrencyCodes
	{
		[Export("ISOCurrencyCodes", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selISOCurrencyCodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ISOLanguageCodes
	{
		[Export("ISOLanguageCodes", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selISOLanguageCodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocaleIdentifier
	{
		[Export("localeIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] PreferredLanguages
	{
		[Export("preferredLanguages", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selPreferredLanguagesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLocale SystemLocale
	{
		[Export("systemLocale", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemLocaleHandle));
		}
	}

	[Field("NSCurrentLocaleDidChangeNotification", "Foundation")]
	[Advice("Use NSLocale.Notifications.ObserveCurrentLocaleDidChange helper method instead.")]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSLocale(NSCoder coder)
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
	protected NSLocale(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLocale(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLocaleIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSLocale(string identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithLocaleIdentifier_Handle, arg), "initWithLocaleIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithLocaleIdentifier_Handle, arg), "initWithLocaleIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("canonicalLanguageIdentifierFromString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("componentsFromLocaleIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary ComponentsFromLocaleIdentifier(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selComponentsFromLocaleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("displayNameForKey:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSString result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDisplayNameForKey_Value_Handle, key.Handle, arg)) : Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDisplayNameForKey_Value_Handle, key.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
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

	[Export("localeWithLocaleIdentifier:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLocale FromLocaleIdentifier(string ident)
	{
		if (ident == null)
		{
			throw new ArgumentNullException("ident");
		}
		IntPtr arg = NSString.CreateNative(ident);
		NSLocale nSObject = Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocaleWithLocaleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("characterDirectionForLanguage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLocaleLanguageDirection GetCharacterDirection(string isoLanguageCode)
	{
		if (isoLanguageCode == null)
		{
			throw new ArgumentNullException("isoLanguageCode");
		}
		IntPtr arg = NSString.CreateNative(isoLanguageCode);
		NSLocaleLanguageDirection result = (NSLocaleLanguageDirection)Messaging.UInt64_objc_msgSend_IntPtr(class_ptr, selCharacterDirectionForLanguage_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("lineDirectionForLanguage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLocaleLanguageDirection GetLineDirection(string isoLanguageCode)
	{
		if (isoLanguageCode == null)
		{
			throw new ArgumentNullException("isoLanguageCode");
		}
		IntPtr arg = NSString.CreateNative(isoLanguageCode);
		NSLocaleLanguageDirection result = (NSLocaleLanguageDirection)Messaging.UInt64_objc_msgSend_IntPtr(class_ptr, selLineDirectionForLanguage_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedStringForCalendarIdentifier:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetLocalizedCalendarIdentifier(string calendarIdentifier)
	{
		if (calendarIdentifier == null)
		{
			throw new ArgumentNullException("calendarIdentifier");
		}
		IntPtr arg = NSString.CreateNative(calendarIdentifier);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocalizedStringForCalendarIdentifier_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLocalizedStringForCalendarIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localeIdentifierFromComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocaleIdentifierFromComponents(NSDictionary dict)
	{
		if (dict == null)
		{
			throw new ArgumentNullException("dict");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocaleIdentifierFromComponents_Handle, dict.Handle));
	}

	[Export("objectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSObject ObjectForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, key.Handle));
	}
}
