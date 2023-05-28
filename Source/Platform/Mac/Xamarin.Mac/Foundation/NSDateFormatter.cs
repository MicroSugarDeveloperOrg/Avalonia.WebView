using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSDateFormatter", true)]
public class NSDateFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAMSymbol = "AMSymbol";

	private static readonly IntPtr selAMSymbolHandle = Selector.GetHandle("AMSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPMSymbol = "PMSymbol";

	private static readonly IntPtr selPMSymbolHandle = Selector.GetHandle("PMSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendar = "calendar";

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateFormat = "dateFormat";

	private static readonly IntPtr selDateFormatHandle = Selector.GetHandle("dateFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateFormatFromTemplate_Options_Locale_ = "dateFormatFromTemplate:options:locale:";

	private static readonly IntPtr selDateFormatFromTemplate_Options_Locale_Handle = Selector.GetHandle("dateFormatFromTemplate:options:locale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateFromString_ = "dateFromString:";

	private static readonly IntPtr selDateFromString_Handle = Selector.GetHandle("dateFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateStyle = "dateStyle";

	private static readonly IntPtr selDateStyleHandle = Selector.GetHandle("dateStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDate = "defaultDate";

	private static readonly IntPtr selDefaultDateHandle = Selector.GetHandle("defaultDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultFormatterBehavior = "defaultFormatterBehavior";

	private static readonly IntPtr selDefaultFormatterBehaviorHandle = Selector.GetHandle("defaultFormatterBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoesRelativeDateFormatting = "doesRelativeDateFormatting";

	private static readonly IntPtr selDoesRelativeDateFormattingHandle = Selector.GetHandle("doesRelativeDateFormatting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEraSymbols = "eraSymbols";

	private static readonly IntPtr selEraSymbolsHandle = Selector.GetHandle("eraSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatterBehavior = "formatterBehavior";

	private static readonly IntPtr selFormatterBehaviorHandle = Selector.GetHandle("formatterBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormattingContext = "formattingContext";

	private static readonly IntPtr selFormattingContextHandle = Selector.GetHandle("formattingContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeneratesCalendarDates = "generatesCalendarDates";

	private static readonly IntPtr selGeneratesCalendarDatesHandle = Selector.GetHandle("generatesCalendarDates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGregorianStartDate = "gregorianStartDate";

	private static readonly IntPtr selGregorianStartDateHandle = Selector.GetHandle("gregorianStartDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLenient = "isLenient";

	private static readonly IntPtr selIsLenientHandle = Selector.GetHandle("isLenient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringFromDate_DateStyle_TimeStyle_ = "localizedStringFromDate:dateStyle:timeStyle:";

	private static readonly IntPtr selLocalizedStringFromDate_DateStyle_TimeStyle_Handle = Selector.GetHandle("localizedStringFromDate:dateStyle:timeStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongEraSymbols = "longEraSymbols";

	private static readonly IntPtr selLongEraSymbolsHandle = Selector.GetHandle("longEraSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonthSymbols = "monthSymbols";

	private static readonly IntPtr selMonthSymbolsHandle = Selector.GetHandle("monthSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuarterSymbols = "quarterSymbols";

	private static readonly IntPtr selQuarterSymbolsHandle = Selector.GetHandle("quarterSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAMSymbol_ = "setAMSymbol:";

	private static readonly IntPtr selSetAMSymbol_Handle = Selector.GetHandle("setAMSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendar_ = "setCalendar:";

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDateFormat_ = "setDateFormat:";

	private static readonly IntPtr selSetDateFormat_Handle = Selector.GetHandle("setDateFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDateStyle_ = "setDateStyle:";

	private static readonly IntPtr selSetDateStyle_Handle = Selector.GetHandle("setDateStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultDate_ = "setDefaultDate:";

	private static readonly IntPtr selSetDefaultDate_Handle = Selector.GetHandle("setDefaultDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultFormatterBehavior_ = "setDefaultFormatterBehavior:";

	private static readonly IntPtr selSetDefaultFormatterBehavior_Handle = Selector.GetHandle("setDefaultFormatterBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoesRelativeDateFormatting_ = "setDoesRelativeDateFormatting:";

	private static readonly IntPtr selSetDoesRelativeDateFormatting_Handle = Selector.GetHandle("setDoesRelativeDateFormatting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEraSymbols_ = "setEraSymbols:";

	private static readonly IntPtr selSetEraSymbols_Handle = Selector.GetHandle("setEraSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormatterBehavior_ = "setFormatterBehavior:";

	private static readonly IntPtr selSetFormatterBehavior_Handle = Selector.GetHandle("setFormatterBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormattingContext_ = "setFormattingContext:";

	private static readonly IntPtr selSetFormattingContext_Handle = Selector.GetHandle("setFormattingContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGeneratesCalendarDates_ = "setGeneratesCalendarDates:";

	private static readonly IntPtr selSetGeneratesCalendarDates_Handle = Selector.GetHandle("setGeneratesCalendarDates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGregorianStartDate_ = "setGregorianStartDate:";

	private static readonly IntPtr selSetGregorianStartDate_Handle = Selector.GetHandle("setGregorianStartDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLenient_ = "setLenient:";

	private static readonly IntPtr selSetLenient_Handle = Selector.GetHandle("setLenient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocale_ = "setLocale:";

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedDateFormatFromTemplate_ = "setLocalizedDateFormatFromTemplate:";

	private static readonly IntPtr selSetLocalizedDateFormatFromTemplate_Handle = Selector.GetHandle("setLocalizedDateFormatFromTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLongEraSymbols_ = "setLongEraSymbols:";

	private static readonly IntPtr selSetLongEraSymbols_Handle = Selector.GetHandle("setLongEraSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMonthSymbols_ = "setMonthSymbols:";

	private static readonly IntPtr selSetMonthSymbols_Handle = Selector.GetHandle("setMonthSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPMSymbol_ = "setPMSymbol:";

	private static readonly IntPtr selSetPMSymbol_Handle = Selector.GetHandle("setPMSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQuarterSymbols_ = "setQuarterSymbols:";

	private static readonly IntPtr selSetQuarterSymbols_Handle = Selector.GetHandle("setQuarterSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShortMonthSymbols_ = "setShortMonthSymbols:";

	private static readonly IntPtr selSetShortMonthSymbols_Handle = Selector.GetHandle("setShortMonthSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShortQuarterSymbols_ = "setShortQuarterSymbols:";

	private static readonly IntPtr selSetShortQuarterSymbols_Handle = Selector.GetHandle("setShortQuarterSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShortStandaloneMonthSymbols_ = "setShortStandaloneMonthSymbols:";

	private static readonly IntPtr selSetShortStandaloneMonthSymbols_Handle = Selector.GetHandle("setShortStandaloneMonthSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShortStandaloneQuarterSymbols_ = "setShortStandaloneQuarterSymbols:";

	private static readonly IntPtr selSetShortStandaloneQuarterSymbols_Handle = Selector.GetHandle("setShortStandaloneQuarterSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShortStandaloneWeekdaySymbols_ = "setShortStandaloneWeekdaySymbols:";

	private static readonly IntPtr selSetShortStandaloneWeekdaySymbols_Handle = Selector.GetHandle("setShortStandaloneWeekdaySymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShortWeekdaySymbols_ = "setShortWeekdaySymbols:";

	private static readonly IntPtr selSetShortWeekdaySymbols_Handle = Selector.GetHandle("setShortWeekdaySymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandaloneMonthSymbols_ = "setStandaloneMonthSymbols:";

	private static readonly IntPtr selSetStandaloneMonthSymbols_Handle = Selector.GetHandle("setStandaloneMonthSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandaloneQuarterSymbols_ = "setStandaloneQuarterSymbols:";

	private static readonly IntPtr selSetStandaloneQuarterSymbols_Handle = Selector.GetHandle("setStandaloneQuarterSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandaloneWeekdaySymbols_ = "setStandaloneWeekdaySymbols:";

	private static readonly IntPtr selSetStandaloneWeekdaySymbols_Handle = Selector.GetHandle("setStandaloneWeekdaySymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeStyle_ = "setTimeStyle:";

	private static readonly IntPtr selSetTimeStyle_Handle = Selector.GetHandle("setTimeStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeZone_ = "setTimeZone:";

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTwoDigitStartDate_ = "setTwoDigitStartDate:";

	private static readonly IntPtr selSetTwoDigitStartDate_Handle = Selector.GetHandle("setTwoDigitStartDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVeryShortMonthSymbols_ = "setVeryShortMonthSymbols:";

	private static readonly IntPtr selSetVeryShortMonthSymbols_Handle = Selector.GetHandle("setVeryShortMonthSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVeryShortStandaloneMonthSymbols_ = "setVeryShortStandaloneMonthSymbols:";

	private static readonly IntPtr selSetVeryShortStandaloneMonthSymbols_Handle = Selector.GetHandle("setVeryShortStandaloneMonthSymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVeryShortStandaloneWeekdaySymbols_ = "setVeryShortStandaloneWeekdaySymbols:";

	private static readonly IntPtr selSetVeryShortStandaloneWeekdaySymbols_Handle = Selector.GetHandle("setVeryShortStandaloneWeekdaySymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVeryShortWeekdaySymbols_ = "setVeryShortWeekdaySymbols:";

	private static readonly IntPtr selSetVeryShortWeekdaySymbols_Handle = Selector.GetHandle("setVeryShortWeekdaySymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeekdaySymbols_ = "setWeekdaySymbols:";

	private static readonly IntPtr selSetWeekdaySymbols_Handle = Selector.GetHandle("setWeekdaySymbols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortMonthSymbols = "shortMonthSymbols";

	private static readonly IntPtr selShortMonthSymbolsHandle = Selector.GetHandle("shortMonthSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortQuarterSymbols = "shortQuarterSymbols";

	private static readonly IntPtr selShortQuarterSymbolsHandle = Selector.GetHandle("shortQuarterSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortStandaloneMonthSymbols = "shortStandaloneMonthSymbols";

	private static readonly IntPtr selShortStandaloneMonthSymbolsHandle = Selector.GetHandle("shortStandaloneMonthSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortStandaloneQuarterSymbols = "shortStandaloneQuarterSymbols";

	private static readonly IntPtr selShortStandaloneQuarterSymbolsHandle = Selector.GetHandle("shortStandaloneQuarterSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortStandaloneWeekdaySymbols = "shortStandaloneWeekdaySymbols";

	private static readonly IntPtr selShortStandaloneWeekdaySymbolsHandle = Selector.GetHandle("shortStandaloneWeekdaySymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortWeekdaySymbols = "shortWeekdaySymbols";

	private static readonly IntPtr selShortWeekdaySymbolsHandle = Selector.GetHandle("shortWeekdaySymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandaloneMonthSymbols = "standaloneMonthSymbols";

	private static readonly IntPtr selStandaloneMonthSymbolsHandle = Selector.GetHandle("standaloneMonthSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandaloneQuarterSymbols = "standaloneQuarterSymbols";

	private static readonly IntPtr selStandaloneQuarterSymbolsHandle = Selector.GetHandle("standaloneQuarterSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandaloneWeekdaySymbols = "standaloneWeekdaySymbols";

	private static readonly IntPtr selStandaloneWeekdaySymbolsHandle = Selector.GetHandle("standaloneWeekdaySymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromDate_ = "stringFromDate:";

	private static readonly IntPtr selStringFromDate_Handle = Selector.GetHandle("stringFromDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeStyle = "timeStyle";

	private static readonly IntPtr selTimeStyleHandle = Selector.GetHandle("timeStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTwoDigitStartDate = "twoDigitStartDate";

	private static readonly IntPtr selTwoDigitStartDateHandle = Selector.GetHandle("twoDigitStartDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVeryShortMonthSymbols = "veryShortMonthSymbols";

	private static readonly IntPtr selVeryShortMonthSymbolsHandle = Selector.GetHandle("veryShortMonthSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVeryShortStandaloneMonthSymbols = "veryShortStandaloneMonthSymbols";

	private static readonly IntPtr selVeryShortStandaloneMonthSymbolsHandle = Selector.GetHandle("veryShortStandaloneMonthSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVeryShortStandaloneWeekdaySymbols = "veryShortStandaloneWeekdaySymbols";

	private static readonly IntPtr selVeryShortStandaloneWeekdaySymbolsHandle = Selector.GetHandle("veryShortStandaloneWeekdaySymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVeryShortWeekdaySymbols = "veryShortWeekdaySymbols";

	private static readonly IntPtr selVeryShortWeekdaySymbolsHandle = Selector.GetHandle("veryShortWeekdaySymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeekdaySymbols = "weekdaySymbols";

	private static readonly IntPtr selWeekdaySymbolsHandle = Selector.GetHandle("weekdaySymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDateFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AMSymbol
	{
		[Export("AMSymbol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAMSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAMSymbolHandle));
		}
		[Export("setAMSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAMSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAMSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateFormatterBehavior Behavior
	{
		[Export("formatterBehavior")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDateFormatterBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selFormatterBehaviorHandle);
			}
			return (NSDateFormatterBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatterBehaviorHandle);
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
	public virtual NSCalendar Calendar
	{
		[Export("calendar", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCalendar>(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarHandle));
			}
			return Runtime.GetNSObject<NSCalendar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarHandle));
		}
		[Export("setCalendar:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalendar_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalendar_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DateFormat
	{
		[Export("dateFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDateFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateFormatHandle));
		}
		[Export("setDateFormat:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDateFormat_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDateFormat_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateFormatterStyle DateStyle
	{
		[Export("dateStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selDateStyleHandle);
			}
			return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDateStyleHandle);
		}
		[Export("setDateStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDateStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDateStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDateFormatterBehavior DefaultBehavior
	{
		[Export("defaultFormatterBehavior")]
		get
		{
			return (NSDateFormatterBehavior)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultFormatterBehaviorHandle);
		}
		[Export("setDefaultFormatterBehavior:")]
		set
		{
			Messaging.void_objc_msgSend_UInt64(class_ptr, selSetDefaultFormatterBehavior_Handle, (ulong)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? DefaultDate
	{
		[Export("defaultDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultDateHandle));
		}
		[Export("setDefaultDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DoesRelativeDateFormatting
	{
		[Export("doesRelativeDateFormatting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDoesRelativeDateFormattingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDoesRelativeDateFormattingHandle);
		}
		[Export("setDoesRelativeDateFormatting:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDoesRelativeDateFormatting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDoesRelativeDateFormatting_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] EraSymbols
	{
		[Export("eraSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEraSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEraSymbolsHandle));
		}
		[Export("setEraSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEraSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEraSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 2, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual NSFormattingContext FormattingContext
	{
		[Introduced(PlatformName.WatchOS, 2, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("formattingContext", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFormattingContext)Messaging.Int64_objc_msgSend(base.Handle, selFormattingContextHandle);
			}
			return (NSFormattingContext)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFormattingContextHandle);
		}
		[Introduced(PlatformName.WatchOS, 2, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setFormattingContext:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFormattingContext_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFormattingContext_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GeneratesCalendarDates
	{
		[Export("generatesCalendarDates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selGeneratesCalendarDatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGeneratesCalendarDatesHandle);
		}
		[Export("setGeneratesCalendarDates:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGeneratesCalendarDates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGeneratesCalendarDates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate GregorianStartDate
	{
		[Export("gregorianStartDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selGregorianStartDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGregorianStartDateHandle));
		}
		[Export("setGregorianStartDate:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGregorianStartDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGregorianStartDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLenient
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
	public virtual string[] LongEraSymbols
	{
		[Export("longEraSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLongEraSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLongEraSymbolsHandle));
		}
		[Export("setLongEraSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLongEraSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLongEraSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] MonthSymbols
	{
		[Export("monthSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMonthSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMonthSymbolsHandle));
		}
		[Export("setMonthSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMonthSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMonthSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PMSymbol
	{
		[Export("PMSymbol")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPMSymbolHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPMSymbolHandle));
		}
		[Export("setPMSymbol:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPMSymbol_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPMSymbol_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] QuarterSymbols
	{
		[Export("quarterSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selQuarterSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuarterSymbolsHandle));
		}
		[Export("setQuarterSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetQuarterSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetQuarterSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShortMonthSymbols
	{
		[Export("shortMonthSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selShortMonthSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShortMonthSymbolsHandle));
		}
		[Export("setShortMonthSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShortMonthSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShortMonthSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShortQuarterSymbols
	{
		[Export("shortQuarterSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selShortQuarterSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShortQuarterSymbolsHandle));
		}
		[Export("setShortQuarterSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShortQuarterSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShortQuarterSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShortStandaloneMonthSymbols
	{
		[Export("shortStandaloneMonthSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selShortStandaloneMonthSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShortStandaloneMonthSymbolsHandle));
		}
		[Export("setShortStandaloneMonthSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShortStandaloneMonthSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShortStandaloneMonthSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShortStandaloneQuarterSymbols
	{
		[Export("shortStandaloneQuarterSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selShortStandaloneQuarterSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShortStandaloneQuarterSymbolsHandle));
		}
		[Export("setShortStandaloneQuarterSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShortStandaloneQuarterSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShortStandaloneQuarterSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShortStandaloneWeekdaySymbols
	{
		[Export("shortStandaloneWeekdaySymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selShortStandaloneWeekdaySymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShortStandaloneWeekdaySymbolsHandle));
		}
		[Export("setShortStandaloneWeekdaySymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShortStandaloneWeekdaySymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShortStandaloneWeekdaySymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShortWeekdaySymbols
	{
		[Export("shortWeekdaySymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selShortWeekdaySymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShortWeekdaySymbolsHandle));
		}
		[Export("setShortWeekdaySymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShortWeekdaySymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShortWeekdaySymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] StandaloneMonthSymbols
	{
		[Export("standaloneMonthSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStandaloneMonthSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandaloneMonthSymbolsHandle));
		}
		[Export("setStandaloneMonthSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandaloneMonthSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandaloneMonthSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] StandaloneQuarterSymbols
	{
		[Export("standaloneQuarterSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStandaloneQuarterSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandaloneQuarterSymbolsHandle));
		}
		[Export("setStandaloneQuarterSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandaloneQuarterSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandaloneQuarterSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] StandaloneWeekdaySymbols
	{
		[Export("standaloneWeekdaySymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStandaloneWeekdaySymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandaloneWeekdaySymbolsHandle));
		}
		[Export("setStandaloneWeekdaySymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStandaloneWeekdaySymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStandaloneWeekdaySymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateFormatterStyle TimeStyle
	{
		[Export("timeStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selTimeStyleHandle);
			}
			return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTimeStyleHandle);
		}
		[Export("setTimeStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTimeStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTimeStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTimeZone TimeZone
	{
		[Export("timeZone", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeZoneHandle));
			}
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeZoneHandle));
		}
		[Export("setTimeZone:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimeZone_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimeZone_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate TwoDigitStartDate
	{
		[Export("twoDigitStartDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selTwoDigitStartDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTwoDigitStartDateHandle));
		}
		[Export("setTwoDigitStartDate:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTwoDigitStartDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTwoDigitStartDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] VeryShortMonthSymbols
	{
		[Export("veryShortMonthSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVeryShortMonthSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVeryShortMonthSymbolsHandle));
		}
		[Export("setVeryShortMonthSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVeryShortMonthSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVeryShortMonthSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] VeryShortStandaloneMonthSymbols
	{
		[Export("veryShortStandaloneMonthSymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVeryShortStandaloneMonthSymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVeryShortStandaloneMonthSymbolsHandle));
		}
		[Export("setVeryShortStandaloneMonthSymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVeryShortStandaloneMonthSymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVeryShortStandaloneMonthSymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] VeryShortStandaloneWeekdaySymbols
	{
		[Export("veryShortStandaloneWeekdaySymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVeryShortStandaloneWeekdaySymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVeryShortStandaloneWeekdaySymbolsHandle));
		}
		[Export("setVeryShortStandaloneWeekdaySymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVeryShortStandaloneWeekdaySymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVeryShortStandaloneWeekdaySymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] VeryShortWeekdaySymbols
	{
		[Export("veryShortWeekdaySymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVeryShortWeekdaySymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVeryShortWeekdaySymbolsHandle));
		}
		[Export("setVeryShortWeekdaySymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVeryShortWeekdaySymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVeryShortWeekdaySymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] WeekdaySymbols
	{
		[Export("weekdaySymbols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWeekdaySymbolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWeekdaySymbolsHandle));
		}
		[Export("setWeekdaySymbols:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWeekdaySymbols_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWeekdaySymbols_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDateFormatter()
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
	public NSDateFormatter(NSCoder coder)
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
	protected NSDateFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDateFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dateFormatFromTemplate:options:locale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetDateFormatFromTemplate(string template, nuint options, NSLocale locale)
	{
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		IntPtr arg = NSString.CreateNative(template);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(class_ptr, selDateFormatFromTemplate_Options_Locale_Handle, arg, options, locale.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dateFromString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate Parse(string date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		IntPtr arg = NSString.CreateNative(date);
		NSDate result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDateFromString_Handle, arg)) : Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDateFromString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setLocalizedDateFormatFromTemplate:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLocalizedDateFormatFromTemplate(string dateFormatTemplate)
	{
		if (dateFormatTemplate == null)
		{
			throw new ArgumentNullException("dateFormatTemplate");
		}
		IntPtr arg = NSString.CreateNative(dateFormatTemplate);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedDateFormatFromTemplate_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedDateFormatFromTemplate_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("localizedStringFromDate:dateStyle:timeStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string ToLocalizedString(NSDate date, NSDateFormatterStyle dateStyle, NSDateFormatterStyle timeStyle)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_UInt64(class_ptr, selLocalizedStringFromDate_DateStyle_TimeStyle_Handle, date.Handle, (ulong)dateStyle, (ulong)timeStyle));
	}

	[Export("stringFromDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ToString(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromDate_Handle, date.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromDate_Handle, date.Handle));
	}
}
