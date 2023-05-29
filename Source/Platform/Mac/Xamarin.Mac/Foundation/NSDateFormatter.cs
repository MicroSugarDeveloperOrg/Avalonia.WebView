using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDateFormatter", true)]
public class NSDateFormatter : NSFormatter
{
	private static readonly IntPtr selDateFormatHandle = Selector.GetHandle("dateFormat");

	private static readonly IntPtr selSetDateFormat_Handle = Selector.GetHandle("setDateFormat:");

	private static readonly IntPtr selDateStyleHandle = Selector.GetHandle("dateStyle");

	private static readonly IntPtr selSetDateStyle_Handle = Selector.GetHandle("setDateStyle:");

	private static readonly IntPtr selTimeStyleHandle = Selector.GetHandle("timeStyle");

	private static readonly IntPtr selSetTimeStyle_Handle = Selector.GetHandle("setTimeStyle:");

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	private static readonly IntPtr selGeneratesCalendarDatesHandle = Selector.GetHandle("generatesCalendarDates");

	private static readonly IntPtr selSetGeneratesCalendarDates_Handle = Selector.GetHandle("setGeneratesCalendarDates:");

	private static readonly IntPtr selFormatterBehaviorHandle = Selector.GetHandle("formatterBehavior");

	private static readonly IntPtr selSetFormatterBehavior_Handle = Selector.GetHandle("setFormatterBehavior:");

	private static readonly IntPtr selDefaultFormatterBehaviorHandle = Selector.GetHandle("defaultFormatterBehavior");

	private static readonly IntPtr selSetDefaultFormatterBehavior_Handle = Selector.GetHandle("setDefaultFormatterBehavior:");

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	private static readonly IntPtr selIsLenientHandle = Selector.GetHandle("isLenient");

	private static readonly IntPtr selSetLenient_Handle = Selector.GetHandle("setLenient:");

	private static readonly IntPtr selTwoDigitStartDateHandle = Selector.GetHandle("twoDigitStartDate");

	private static readonly IntPtr selSetTwoDigitStartDate_Handle = Selector.GetHandle("setTwoDigitStartDate:");

	private static readonly IntPtr selDefaultDateHandle = Selector.GetHandle("defaultDate");

	private static readonly IntPtr selSetDefaultDate_Handle = Selector.GetHandle("setDefaultDate:");

	private static readonly IntPtr selEraSymbolsHandle = Selector.GetHandle("eraSymbols");

	private static readonly IntPtr selSetEraSymbols_Handle = Selector.GetHandle("setEraSymbols:");

	private static readonly IntPtr selMonthSymbolsHandle = Selector.GetHandle("monthSymbols");

	private static readonly IntPtr selSetMonthSymbols_Handle = Selector.GetHandle("setMonthSymbols:");

	private static readonly IntPtr selShortMonthSymbolsHandle = Selector.GetHandle("shortMonthSymbols");

	private static readonly IntPtr selSetShortMonthSymbols_Handle = Selector.GetHandle("setShortMonthSymbols:");

	private static readonly IntPtr selWeekdaySymbolsHandle = Selector.GetHandle("weekdaySymbols");

	private static readonly IntPtr selSetWeekdaySymbols_Handle = Selector.GetHandle("setWeekdaySymbols:");

	private static readonly IntPtr selShortWeekdaySymbolsHandle = Selector.GetHandle("shortWeekdaySymbols");

	private static readonly IntPtr selSetShortWeekdaySymbols_Handle = Selector.GetHandle("setShortWeekdaySymbols:");

	private static readonly IntPtr selAMSymbolHandle = Selector.GetHandle("AMSymbol");

	private static readonly IntPtr selSetAMSymbol_Handle = Selector.GetHandle("setAMSymbol:");

	private static readonly IntPtr selPMSymbolHandle = Selector.GetHandle("PMSymbol");

	private static readonly IntPtr selSetPMSymbol_Handle = Selector.GetHandle("setPMSymbol:");

	private static readonly IntPtr selLongEraSymbolsHandle = Selector.GetHandle("longEraSymbols");

	private static readonly IntPtr selSetLongEraSymbols_Handle = Selector.GetHandle("setLongEraSymbols:");

	private static readonly IntPtr selVeryShortMonthSymbolsHandle = Selector.GetHandle("veryShortMonthSymbols");

	private static readonly IntPtr selSetVeryShortMonthSymbols_Handle = Selector.GetHandle("setVeryShortMonthSymbols:");

	private static readonly IntPtr selStandaloneMonthSymbolsHandle = Selector.GetHandle("standaloneMonthSymbols");

	private static readonly IntPtr selSetStandaloneMonthSymbols_Handle = Selector.GetHandle("setStandaloneMonthSymbols:");

	private static readonly IntPtr selShortStandaloneMonthSymbolsHandle = Selector.GetHandle("shortStandaloneMonthSymbols");

	private static readonly IntPtr selSetShortStandaloneMonthSymbols_Handle = Selector.GetHandle("setShortStandaloneMonthSymbols:");

	private static readonly IntPtr selVeryShortStandaloneMonthSymbolsHandle = Selector.GetHandle("veryShortStandaloneMonthSymbols");

	private static readonly IntPtr selSetVeryShortStandaloneMonthSymbols_Handle = Selector.GetHandle("setVeryShortStandaloneMonthSymbols:");

	private static readonly IntPtr selVeryShortWeekdaySymbolsHandle = Selector.GetHandle("veryShortWeekdaySymbols");

	private static readonly IntPtr selSetVeryShortWeekdaySymbols_Handle = Selector.GetHandle("setVeryShortWeekdaySymbols:");

	private static readonly IntPtr selStandaloneWeekdaySymbolsHandle = Selector.GetHandle("standaloneWeekdaySymbols");

	private static readonly IntPtr selSetStandaloneWeekdaySymbols_Handle = Selector.GetHandle("setStandaloneWeekdaySymbols:");

	private static readonly IntPtr selShortStandaloneWeekdaySymbolsHandle = Selector.GetHandle("shortStandaloneWeekdaySymbols");

	private static readonly IntPtr selSetShortStandaloneWeekdaySymbols_Handle = Selector.GetHandle("setShortStandaloneWeekdaySymbols:");

	private static readonly IntPtr selVeryShortStandaloneWeekdaySymbolsHandle = Selector.GetHandle("veryShortStandaloneWeekdaySymbols");

	private static readonly IntPtr selSetVeryShortStandaloneWeekdaySymbols_Handle = Selector.GetHandle("setVeryShortStandaloneWeekdaySymbols:");

	private static readonly IntPtr selQuarterSymbolsHandle = Selector.GetHandle("quarterSymbols");

	private static readonly IntPtr selSetQuarterSymbols_Handle = Selector.GetHandle("setQuarterSymbols:");

	private static readonly IntPtr selShortQuarterSymbolsHandle = Selector.GetHandle("shortQuarterSymbols");

	private static readonly IntPtr selSetShortQuarterSymbols_Handle = Selector.GetHandle("setShortQuarterSymbols:");

	private static readonly IntPtr selStandaloneQuarterSymbolsHandle = Selector.GetHandle("standaloneQuarterSymbols");

	private static readonly IntPtr selSetStandaloneQuarterSymbols_Handle = Selector.GetHandle("setStandaloneQuarterSymbols:");

	private static readonly IntPtr selShortStandaloneQuarterSymbolsHandle = Selector.GetHandle("shortStandaloneQuarterSymbols");

	private static readonly IntPtr selSetShortStandaloneQuarterSymbols_Handle = Selector.GetHandle("setShortStandaloneQuarterSymbols:");

	private static readonly IntPtr selGregorianStartDateHandle = Selector.GetHandle("gregorianStartDate");

	private static readonly IntPtr selSetGregorianStartDate_Handle = Selector.GetHandle("setGregorianStartDate:");

	private static readonly IntPtr selStringFromDate_Handle = Selector.GetHandle("stringFromDate:");

	private static readonly IntPtr selDateFromString_Handle = Selector.GetHandle("dateFromString:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDateFormatter");

	private object __mt_Locale_var;

	private object __mt_TimeZone_var;

	private object __mt_Calendar_var;

	private object __mt_TwoDigitStartDate_var;

	private object __mt_DefaultDate_var;

	private object __mt_GregorianStartDate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string DateFormat
	{
		[Export("dateFormat")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual NSDateFormatterStyle DateStyle
	{
		[Export("dateStyle")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selDateStyleHandle);
			}
			return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDateStyleHandle);
		}
		[Export("setDateStyle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDateStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDateStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual NSDateFormatterStyle TimeStyle
	{
		[Export("timeStyle")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selTimeStyleHandle);
			}
			return (NSDateFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTimeStyleHandle);
		}
		[Export("setTimeStyle:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTimeStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTimeStyle_Handle, (ulong)value);
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

	public virtual bool GeneratesCalendarDates
	{
		[Export("generatesCalendarDates")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selGeneratesCalendarDatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGeneratesCalendarDatesHandle);
		}
		[Export("setGeneratesCalendarDates:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGeneratesCalendarDates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGeneratesCalendarDates_Handle, value);
			}
		}
	}

	public virtual NSDateFormatterBehavior Behavior
	{
		[Export("formatterBehavior")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSDateFormatterBehavior)Messaging.UInt64_objc_msgSend(base.Handle, selFormatterBehaviorHandle);
			}
			return (NSDateFormatterBehavior)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatterBehaviorHandle);
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

	public virtual NSTimeZone TimeZone
	{
		[Export("timeZone")]
		get
		{
			return (NSTimeZone)(__mt_TimeZone_var = ((!IsDirectBinding) ? ((NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeZoneHandle))) : ((NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeZoneHandle)))));
		}
		[Export("setTimeZone:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimeZone_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimeZone_Handle, value.Handle);
			}
			__mt_TimeZone_var = value;
		}
	}

	public virtual NSCalendar Calendar
	{
		[Export("calendar")]
		get
		{
			return (NSCalendar)(__mt_Calendar_var = ((!IsDirectBinding) ? ((NSCalendar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarHandle))) : ((NSCalendar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarHandle)))));
		}
		[Export("setCalendar:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalendar_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalendar_Handle, value.Handle);
			}
			__mt_Calendar_var = value;
		}
	}

	public virtual bool IsLenient
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

	public virtual NSDate TwoDigitStartDate
	{
		[Export("twoDigitStartDate")]
		get
		{
			return (NSDate)(__mt_TwoDigitStartDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTwoDigitStartDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTwoDigitStartDateHandle)))));
		}
		[Export("setTwoDigitStartDate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTwoDigitStartDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTwoDigitStartDate_Handle, value.Handle);
			}
			__mt_TwoDigitStartDate_var = value;
		}
	}

	public virtual NSDate DefaultDate
	{
		[Export("defaultDate")]
		get
		{
			return (NSDate)(__mt_DefaultDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultDateHandle)))));
		}
		[Export("setDefaultDate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultDate_Handle, value.Handle);
			}
			__mt_DefaultDate_var = value;
		}
	}

	public virtual string[] EraSymbols
	{
		[Export("eraSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] MonthSymbols
	{
		[Export("monthSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] ShortMonthSymbols
	{
		[Export("shortMonthSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] WeekdaySymbols
	{
		[Export("weekdaySymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] ShortWeekdaySymbols
	{
		[Export("shortWeekdaySymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string AMSymbol
	{
		[Export("AMSymbol")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string PMSymbol
	{
		[Export("PMSymbol")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] LongEraSymbols
	{
		[Export("longEraSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] VeryShortMonthSymbols
	{
		[Export("veryShortMonthSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] StandaloneMonthSymbols
	{
		[Export("standaloneMonthSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] ShortStandaloneMonthSymbols
	{
		[Export("shortStandaloneMonthSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] VeryShortStandaloneMonthSymbols
	{
		[Export("veryShortStandaloneMonthSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] VeryShortWeekdaySymbols
	{
		[Export("veryShortWeekdaySymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] StandaloneWeekdaySymbols
	{
		[Export("standaloneWeekdaySymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] ShortStandaloneWeekdaySymbols
	{
		[Export("shortStandaloneWeekdaySymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] VeryShortStandaloneWeekdaySymbols
	{
		[Export("veryShortStandaloneWeekdaySymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] QuarterSymbols
	{
		[Export("quarterSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] ShortQuarterSymbols
	{
		[Export("shortQuarterSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] StandaloneQuarterSymbols
	{
		[Export("standaloneQuarterSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string[] ShortStandaloneQuarterSymbols
	{
		[Export("shortStandaloneQuarterSymbols")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual NSDate GregorianStartDate
	{
		[Export("gregorianStartDate")]
		get
		{
			return (NSDate)(__mt_GregorianStartDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGregorianStartDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selGregorianStartDateHandle)))));
		}
		[Export("setGregorianStartDate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGregorianStartDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGregorianStartDate_Handle, value.Handle);
			}
			__mt_GregorianStartDate_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDateFormatter()
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
	public NSDateFormatter(NSCoder coder)
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
	public NSDateFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDateFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("stringFromDate:")]
	public virtual string ToString(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromDate_Handle, date.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromDate_Handle, date.Handle));
	}

	[Export("dateFromString:")]
	public virtual NSDate Parse(string date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		IntPtr arg = NSString.CreateNative(date);
		NSDate result = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDateFromString_Handle, arg))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDateFromString_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Locale_var = null;
			__mt_TimeZone_var = null;
			__mt_Calendar_var = null;
			__mt_TwoDigitStartDate_var = null;
			__mt_DefaultDate_var = null;
			__mt_GregorianStartDate_var = null;
		}
	}
}
