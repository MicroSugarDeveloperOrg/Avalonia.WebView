using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSCalendar", true)]
public class NSCalendar : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveDayChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DayChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDayChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DayChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAMSymbol = "AMSymbol";

	private static readonly IntPtr selAMSymbolHandle = Selector.GetHandle("AMSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPMSymbol = "PMSymbol";

	private static readonly IntPtr selPMSymbolHandle = Selector.GetHandle("PMSymbol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarIdentifier = "calendarIdentifier";

	private static readonly IntPtr selCalendarIdentifierHandle = Selector.GetHandle("calendarIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompareDate_ToDate_ToUnitGranularity_ = "compareDate:toDate:toUnitGranularity:";

	private static readonly IntPtr selCompareDate_ToDate_ToUnitGranularity_Handle = Selector.GetHandle("compareDate:toDate:toUnitGranularity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponent_FromDate_ = "component:fromDate:";

	private static readonly IntPtr selComponent_FromDate_Handle = Selector.GetHandle("component:fromDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents_FromDate_ = "components:fromDate:";

	private static readonly IntPtr selComponents_FromDate_Handle = Selector.GetHandle("components:fromDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents_FromDate_ToDate_Options_ = "components:fromDate:toDate:options:";

	private static readonly IntPtr selComponents_FromDate_ToDate_Options_Handle = Selector.GetHandle("components:fromDate:toDate:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents_FromDateComponents_ToDateComponents_Options_ = "components:fromDateComponents:toDateComponents:options:";

	private static readonly IntPtr selComponents_FromDateComponents_ToDateComponents_Options_Handle = Selector.GetHandle("components:fromDateComponents:toDateComponents:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentsInTimeZone_FromDate_ = "componentsInTimeZone:fromDate:";

	private static readonly IntPtr selComponentsInTimeZone_FromDate_Handle = Selector.GetHandle("componentsInTimeZone:fromDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentCalendar = "currentCalendar";

	private static readonly IntPtr selCurrentCalendarHandle = Selector.GetHandle("currentCalendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDate_MatchesComponents_ = "date:matchesComponents:";

	private static readonly IntPtr selDate_MatchesComponents_Handle = Selector.GetHandle("date:matchesComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateByAddingComponents_ToDate_Options_ = "dateByAddingComponents:toDate:options:";

	private static readonly IntPtr selDateByAddingComponents_ToDate_Options_Handle = Selector.GetHandle("dateByAddingComponents:toDate:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateByAddingUnit_Value_ToDate_Options_ = "dateByAddingUnit:value:toDate:options:";

	private static readonly IntPtr selDateByAddingUnit_Value_ToDate_Options_Handle = Selector.GetHandle("dateByAddingUnit:value:toDate:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateBySettingHour_Minute_Second_OfDate_Options_ = "dateBySettingHour:minute:second:ofDate:options:";

	private static readonly IntPtr selDateBySettingHour_Minute_Second_OfDate_Options_Handle = Selector.GetHandle("dateBySettingHour:minute:second:ofDate:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateBySettingUnit_Value_OfDate_Options_ = "dateBySettingUnit:value:ofDate:options:";

	private static readonly IntPtr selDateBySettingUnit_Value_OfDate_Options_Handle = Selector.GetHandle("dateBySettingUnit:value:ofDate:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateFromComponents_ = "dateFromComponents:";

	private static readonly IntPtr selDateFromComponents_Handle = Selector.GetHandle("dateFromComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_ = "dateWithEra:year:month:day:hour:minute:second:nanosecond:";

	private static readonly IntPtr selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_Handle = Selector.GetHandle("dateWithEra:year:month:day:hour:minute:second:nanosecond:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_ = "dateWithEra:yearForWeekOfYear:weekOfYear:weekday:hour:minute:second:nanosecond:";

	private static readonly IntPtr selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_Handle = Selector.GetHandle("dateWithEra:yearForWeekOfYear:weekOfYear:weekday:hour:minute:second:nanosecond:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_ = "enumerateDatesStartingAfterDate:matchingComponents:options:usingBlock:";

	private static readonly IntPtr selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_Handle = Selector.GetHandle("enumerateDatesStartingAfterDate:matchingComponents:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEraSymbols = "eraSymbols";

	private static readonly IntPtr selEraSymbolsHandle = Selector.GetHandle("eraSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstWeekday = "firstWeekday";

	private static readonly IntPtr selFirstWeekdayHandle = Selector.GetHandle("firstWeekday");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetEra_Year_Month_Day_FromDate_ = "getEra:year:month:day:fromDate:";

	private static readonly IntPtr selGetEra_Year_Month_Day_FromDate_Handle = Selector.GetHandle("getEra:year:month:day:fromDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_ = "getEra:yearForWeekOfYear:weekOfYear:weekday:fromDate:";

	private static readonly IntPtr selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_Handle = Selector.GetHandle("getEra:yearForWeekOfYear:weekOfYear:weekday:fromDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetHour_Minute_Second_Nanosecond_FromDate_ = "getHour:minute:second:nanosecond:fromDate:";

	private static readonly IntPtr selGetHour_Minute_Second_Nanosecond_FromDate_Handle = Selector.GetHandle("getHour:minute:second:nanosecond:fromDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCalendarIdentifier_ = "initWithCalendarIdentifier:";

	private static readonly IntPtr selInitWithCalendarIdentifier_Handle = Selector.GetHandle("initWithCalendarIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDate_EqualToDate_ToUnitGranularity_ = "isDate:equalToDate:toUnitGranularity:";

	private static readonly IntPtr selIsDate_EqualToDate_ToUnitGranularity_Handle = Selector.GetHandle("isDate:equalToDate:toUnitGranularity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDate_InSameDayAsDate_ = "isDate:inSameDayAsDate:";

	private static readonly IntPtr selIsDate_InSameDayAsDate_Handle = Selector.GetHandle("isDate:inSameDayAsDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDateInToday_ = "isDateInToday:";

	private static readonly IntPtr selIsDateInToday_Handle = Selector.GetHandle("isDateInToday:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDateInTomorrow_ = "isDateInTomorrow:";

	private static readonly IntPtr selIsDateInTomorrow_Handle = Selector.GetHandle("isDateInTomorrow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDateInWeekend_ = "isDateInWeekend:";

	private static readonly IntPtr selIsDateInWeekend_Handle = Selector.GetHandle("isDateInWeekend:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDateInYesterday_ = "isDateInYesterday:";

	private static readonly IntPtr selIsDateInYesterday_Handle = Selector.GetHandle("isDateInYesterday:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongEraSymbols = "longEraSymbols";

	private static readonly IntPtr selLongEraSymbolsHandle = Selector.GetHandle("longEraSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumRangeOfUnit_ = "maximumRangeOfUnit:";

	private static readonly IntPtr selMaximumRangeOfUnit_Handle = Selector.GetHandle("maximumRangeOfUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumDaysInFirstWeek = "minimumDaysInFirstWeek";

	private static readonly IntPtr selMinimumDaysInFirstWeekHandle = Selector.GetHandle("minimumDaysInFirstWeek");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumRangeOfUnit_ = "minimumRangeOfUnit:";

	private static readonly IntPtr selMinimumRangeOfUnit_Handle = Selector.GetHandle("minimumRangeOfUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonthSymbols = "monthSymbols";

	private static readonly IntPtr selMonthSymbolsHandle = Selector.GetHandle("monthSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextDateAfterDate_MatchingComponents_Options_ = "nextDateAfterDate:matchingComponents:options:";

	private static readonly IntPtr selNextDateAfterDate_MatchingComponents_Options_Handle = Selector.GetHandle("nextDateAfterDate:matchingComponents:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextDateAfterDate_MatchingHour_Minute_Second_Options_ = "nextDateAfterDate:matchingHour:minute:second:options:";

	private static readonly IntPtr selNextDateAfterDate_MatchingHour_Minute_Second_Options_Handle = Selector.GetHandle("nextDateAfterDate:matchingHour:minute:second:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextDateAfterDate_MatchingUnit_Value_Options_ = "nextDateAfterDate:matchingUnit:value:options:";

	private static readonly IntPtr selNextDateAfterDate_MatchingUnit_Value_Options_Handle = Selector.GetHandle("nextDateAfterDate:matchingUnit:value:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextWeekendStartDate_Interval_Options_AfterDate_ = "nextWeekendStartDate:interval:options:afterDate:";

	private static readonly IntPtr selNextWeekendStartDate_Interval_Options_AfterDate_Handle = Selector.GetHandle("nextWeekendStartDate:interval:options:afterDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrdinalityOfUnit_InUnit_ForDate_ = "ordinalityOfUnit:inUnit:forDate:";

	private static readonly IntPtr selOrdinalityOfUnit_InUnit_ForDate_Handle = Selector.GetHandle("ordinalityOfUnit:inUnit:forDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuarterSymbols = "quarterSymbols";

	private static readonly IntPtr selQuarterSymbolsHandle = Selector.GetHandle("quarterSymbols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfUnit_InUnit_ForDate_ = "rangeOfUnit:inUnit:forDate:";

	private static readonly IntPtr selRangeOfUnit_InUnit_ForDate_Handle = Selector.GetHandle("rangeOfUnit:inUnit:forDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfUnit_StartDate_Interval_ForDate_ = "rangeOfUnit:startDate:interval:forDate:";

	private static readonly IntPtr selRangeOfUnit_StartDate_Interval_ForDate_Handle = Selector.GetHandle("rangeOfUnit:startDate:interval:forDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfWeekendStartDate_Interval_ContainingDate_ = "rangeOfWeekendStartDate:interval:containingDate:";

	private static readonly IntPtr selRangeOfWeekendStartDate_Interval_ContainingDate_Handle = Selector.GetHandle("rangeOfWeekendStartDate:interval:containingDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFirstWeekday_ = "setFirstWeekday:";

	private static readonly IntPtr selSetFirstWeekday_Handle = Selector.GetHandle("setFirstWeekday:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocale_ = "setLocale:";

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumDaysInFirstWeek_ = "setMinimumDaysInFirstWeek:";

	private static readonly IntPtr selSetMinimumDaysInFirstWeek_Handle = Selector.GetHandle("setMinimumDaysInFirstWeek:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeZone_ = "setTimeZone:";

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

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
	private const string selStartOfDayForDate_ = "startOfDayForDate:";

	private static readonly IntPtr selStartOfDayForDate_Handle = Selector.GetHandle("startOfDayForDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCalendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CopticCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DayChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EthiopicAmeteAlemCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EthiopicAmeteMihretCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IslamicTabularCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IslamicUmmAlQuraCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSBuddhistCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSChineseCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSGregorianCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSHebrewCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSISO8601Calendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSIndianCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSIslamicCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSIslamicCivilCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSJapaneseCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPersianCalendar;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRepublicOfChinaCalendar;

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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCalendar CurrentCalendar
	{
		[Export("currentCalendar")]
		get
		{
			return Runtime.GetNSObject<NSCalendar>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentCalendarHandle));
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FirstWeekDay
	{
		[Export("firstWeekday")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFirstWeekdayHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFirstWeekdayHandle);
		}
		[Export("setFirstWeekday:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetFirstWeekday_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetFirstWeekday_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MinimumDaysInFirstWeek
	{
		[Export("minimumDaysInFirstWeek")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMinimumDaysInFirstWeekHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMinimumDaysInFirstWeekHandle);
		}
		[Export("setMinimumDaysInFirstWeek:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMinimumDaysInFirstWeek_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMinimumDaysInFirstWeek_Handle, value);
			}
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
	}

	[Field("NSCalendarIdentifierCoptic", "Foundation")]
	internal static NSString CopticCalendar
	{
		get
		{
			if (_CopticCalendar == null)
			{
				_CopticCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierCoptic");
			}
			return _CopticCalendar;
		}
	}

	[Field("NSCalendarDayChangedNotification", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Advice("Use NSCalendar.Notifications.ObserveDayChanged helper method instead.")]
	public static NSString DayChangedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DayChangedNotification == null)
			{
				_DayChangedNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarDayChangedNotification");
			}
			return _DayChangedNotification;
		}
	}

	[Field("NSCalendarIdentifierEthiopicAmeteAlem", "Foundation")]
	internal static NSString EthiopicAmeteAlemCalendar
	{
		get
		{
			if (_EthiopicAmeteAlemCalendar == null)
			{
				_EthiopicAmeteAlemCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierEthiopicAmeteAlem");
			}
			return _EthiopicAmeteAlemCalendar;
		}
	}

	[Field("NSCalendarIdentifierEthiopicAmeteMihret", "Foundation")]
	internal static NSString EthiopicAmeteMihretCalendar
	{
		get
		{
			if (_EthiopicAmeteMihretCalendar == null)
			{
				_EthiopicAmeteMihretCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierEthiopicAmeteMihret");
			}
			return _EthiopicAmeteMihretCalendar;
		}
	}

	[Field("NSCalendarIdentifierIslamicTabular", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	internal static NSString IslamicTabularCalendar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IslamicTabularCalendar == null)
			{
				_IslamicTabularCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierIslamicTabular");
			}
			return _IslamicTabularCalendar;
		}
	}

	[Field("NSCalendarIdentifierIslamicUmmAlQura", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	internal static NSString IslamicUmmAlQuraCalendar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IslamicUmmAlQuraCalendar == null)
			{
				_IslamicUmmAlQuraCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierIslamicUmmAlQura");
			}
			return _IslamicUmmAlQuraCalendar;
		}
	}

	[Field("NSCalendarIdentifierBuddhist", "Foundation")]
	internal static NSString NSBuddhistCalendar
	{
		get
		{
			if (_NSBuddhistCalendar == null)
			{
				_NSBuddhistCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierBuddhist");
			}
			return _NSBuddhistCalendar;
		}
	}

	[Field("NSCalendarIdentifierChinese", "Foundation")]
	internal static NSString NSChineseCalendar
	{
		get
		{
			if (_NSChineseCalendar == null)
			{
				_NSChineseCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierChinese");
			}
			return _NSChineseCalendar;
		}
	}

	[Field("NSCalendarIdentifierGregorian", "Foundation")]
	internal static NSString NSGregorianCalendar
	{
		get
		{
			if (_NSGregorianCalendar == null)
			{
				_NSGregorianCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierGregorian");
			}
			return _NSGregorianCalendar;
		}
	}

	[Field("NSCalendarIdentifierHebrew", "Foundation")]
	internal static NSString NSHebrewCalendar
	{
		get
		{
			if (_NSHebrewCalendar == null)
			{
				_NSHebrewCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierHebrew");
			}
			return _NSHebrewCalendar;
		}
	}

	[Field("NSCalendarIdentifierISO8601", "Foundation")]
	internal static NSString NSISO8601Calendar
	{
		get
		{
			if (_NSISO8601Calendar == null)
			{
				_NSISO8601Calendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierISO8601");
			}
			return _NSISO8601Calendar;
		}
	}

	[Field("NSCalendarIdentifierIndian", "Foundation")]
	internal static NSString NSIndianCalendar
	{
		get
		{
			if (_NSIndianCalendar == null)
			{
				_NSIndianCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierIndian");
			}
			return _NSIndianCalendar;
		}
	}

	[Field("NSIslamicCalendar", "Foundation")]
	internal static NSString NSIslamicCalendar
	{
		get
		{
			if (_NSIslamicCalendar == null)
			{
				_NSIslamicCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSIslamicCalendar");
			}
			return _NSIslamicCalendar;
		}
	}

	[Field("NSCalendarIdentifierIslamicCivil", "Foundation")]
	internal static NSString NSIslamicCivilCalendar
	{
		get
		{
			if (_NSIslamicCivilCalendar == null)
			{
				_NSIslamicCivilCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierIslamicCivil");
			}
			return _NSIslamicCivilCalendar;
		}
	}

	[Field("NSCalendarIdentifierJapanese", "Foundation")]
	internal static NSString NSJapaneseCalendar
	{
		get
		{
			if (_NSJapaneseCalendar == null)
			{
				_NSJapaneseCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierJapanese");
			}
			return _NSJapaneseCalendar;
		}
	}

	[Field("NSCalendarIdentifierPersian", "Foundation")]
	internal static NSString NSPersianCalendar
	{
		get
		{
			if (_NSPersianCalendar == null)
			{
				_NSPersianCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierPersian");
			}
			return _NSPersianCalendar;
		}
	}

	[Field("NSCalendarIdentifierRepublicOfChina", "Foundation")]
	internal static NSString NSRepublicOfChinaCalendar
	{
		get
		{
			if (_NSRepublicOfChinaCalendar == null)
			{
				_NSRepublicOfChinaCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCalendarIdentifierRepublicOfChina");
			}
			return _NSRepublicOfChinaCalendar;
		}
	}

	private static NSString GetCalendarIdentifier(NSCalendarType type)
	{
		return type switch
		{
			NSCalendarType.Gregorian => NSGregorianCalendar, 
			NSCalendarType.Buddhist => NSBuddhistCalendar, 
			NSCalendarType.Chinese => NSChineseCalendar, 
			NSCalendarType.Hebrew => NSHebrewCalendar, 
			NSCalendarType.Islamic => NSIslamicCalendar, 
			NSCalendarType.IslamicCivil => NSIslamicCivilCalendar, 
			NSCalendarType.Japanese => NSJapaneseCalendar, 
			NSCalendarType.RepublicOfChina => NSRepublicOfChinaCalendar, 
			NSCalendarType.Persian => NSPersianCalendar, 
			NSCalendarType.Indian => NSIndianCalendar, 
			NSCalendarType.ISO8601 => NSISO8601Calendar, 
			NSCalendarType.Coptic => CopticCalendar, 
			NSCalendarType.EthiopicAmeteAlem => EthiopicAmeteAlemCalendar, 
			NSCalendarType.EthiopicAmeteMihret => EthiopicAmeteMihretCalendar, 
			NSCalendarType.IslamicTabular => IslamicTabularCalendar, 
			NSCalendarType.IslamicUmmAlQura => IslamicUmmAlQuraCalendar, 
			_ => throw new ArgumentException("Unknown NSCalendarType value"), 
		};
	}

	public NSCalendar(NSCalendarType calendarType)
		: this(GetCalendarIdentifier(calendarType))
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCalendar(NSCoder coder)
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
	protected NSCalendar(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCalendar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCalendarIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCalendar(NSString identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCalendarIdentifier_Handle, identifier.Handle), "initWithCalendarIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCalendarIdentifier_Handle, identifier.Handle), "initWithCalendarIdentifier:");
		}
	}

	[Export("compareDate:toDate:toUnitGranularity:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonResult CompareDate(NSDate date1, NSDate date2, NSCalendarUnit granularity)
	{
		if (date1 == null)
		{
			throw new ArgumentNullException("date1");
		}
		if (date2 == null)
		{
			throw new ArgumentNullException("date2");
		}
		if (base.IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selCompareDate_ToDate_ToUnitGranularity_Handle, date1.Handle, date2.Handle, (ulong)granularity);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selCompareDate_ToDate_ToUnitGranularity_Handle, date1.Handle, date2.Handle, (ulong)granularity);
	}

	[Export("components:fromDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents Components(NSCalendarUnit unitFlags, NSDate fromDate)
	{
		if (fromDate == null)
		{
			throw new ArgumentNullException("fromDate");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selComponents_FromDate_Handle, (ulong)unitFlags, fromDate.Handle));
		}
		return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selComponents_FromDate_Handle, (ulong)unitFlags, fromDate.Handle));
	}

	[Export("components:fromDate:toDate:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents Components(NSCalendarUnit unitFlags, NSDate fromDate, NSDate toDate, NSCalendarOptions opts)
	{
		if (fromDate == null)
		{
			throw new ArgumentNullException("fromDate");
		}
		if (toDate == null)
		{
			throw new ArgumentNullException("toDate");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_UInt64(base.Handle, selComponents_FromDate_ToDate_Options_Handle, (ulong)unitFlags, fromDate.Handle, toDate.Handle, (ulong)opts));
		}
		return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_UInt64(base.SuperHandle, selComponents_FromDate_ToDate_Options_Handle, (ulong)unitFlags, fromDate.Handle, toDate.Handle, (ulong)opts));
	}

	[Obsolete("Use the overload with a 'NSCalendarOptions' parameter.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDateComponents Components(NSCalendarUnit unitFlags, NSDate fromDate, NSDate toDate, NSDateComponentsWrappingBehavior opts)
	{
		return Components(unitFlags, fromDate, toDate, (NSCalendarOptions)opts);
	}

	[Export("components:fromDateComponents:toDateComponents:options:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents ComponentsFromDateToDate(NSCalendarUnit unitFlags, NSDateComponents startingDate, NSDateComponents resultDate, NSCalendarOptions options)
	{
		if (startingDate == null)
		{
			throw new ArgumentNullException("startingDate");
		}
		if (resultDate == null)
		{
			throw new ArgumentNullException("resultDate");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_UInt64(base.Handle, selComponents_FromDateComponents_ToDateComponents_Options_Handle, (ulong)unitFlags, startingDate.Handle, resultDate.Handle, (ulong)options));
		}
		return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_UInt64(base.SuperHandle, selComponents_FromDateComponents_ToDateComponents_Options_Handle, (ulong)unitFlags, startingDate.Handle, resultDate.Handle, (ulong)options));
	}

	[Export("componentsInTimeZone:fromDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateComponents ComponentsInTimeZone(NSTimeZone timezone, NSDate date)
	{
		if (timezone == null)
		{
			throw new ArgumentNullException("timezone");
		}
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selComponentsInTimeZone_FromDate_Handle, timezone.Handle, date.Handle));
		}
		return Runtime.GetNSObject<NSDateComponents>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selComponentsInTimeZone_FromDate_Handle, timezone.Handle, date.Handle));
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

	[Export("dateWithEra:year:month:day:hour:minute:second:nanosecond:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate Date(nint era, nint year, nint month, nint date, nint hour, nint minute, nint second, nint nanosecond)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_nint_nint_nint_nint_nint_nint_nint_nint(base.Handle, selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_Handle, era, year, month, date, hour, minute, second, nanosecond));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_nint_nint_nint_nint_nint_nint_nint_nint(base.SuperHandle, selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_Handle, era, year, month, date, hour, minute, second, nanosecond));
	}

	[Export("dateByAddingComponents:toDate:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate DateByAddingComponents(NSDateComponents comps, NSDate date, NSCalendarOptions opts)
	{
		if (comps == null)
		{
			throw new ArgumentNullException("comps");
		}
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selDateByAddingComponents_ToDate_Options_Handle, comps.Handle, date.Handle, (ulong)opts));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selDateByAddingComponents_ToDate_Options_Handle, comps.Handle, date.Handle, (ulong)opts));
	}

	[Obsolete("Use the overload with a 'NSCalendarOptions' parameter.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDate DateByAddingComponents(NSDateComponents comps, NSDate date, NSDateComponentsWrappingBehavior opts)
	{
		return DateByAddingComponents(comps, date, (NSCalendarOptions)opts);
	}

	[Export("dateByAddingUnit:value:toDate:options:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate DateByAddingUnit(NSCalendarUnit unit, nint value, NSDate date, NSCalendarOptions options)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_UInt64_nint_IntPtr_UInt64(base.Handle, selDateByAddingUnit_Value_ToDate_Options_Handle, (ulong)unit, value, date.Handle, (ulong)options));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_UInt64_nint_IntPtr_UInt64(base.SuperHandle, selDateByAddingUnit_Value_ToDate_Options_Handle, (ulong)unit, value, date.Handle, (ulong)options));
	}

	[Export("dateBySettingUnit:value:ofDate:options:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate DateBySettingUnit(NSCalendarUnit unit, nint value, NSDate date, NSCalendarOptions options)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_UInt64_nint_IntPtr_UInt64(base.Handle, selDateBySettingUnit_Value_OfDate_Options_Handle, (ulong)unit, value, date.Handle, (ulong)options));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_UInt64_nint_IntPtr_UInt64(base.SuperHandle, selDateBySettingUnit_Value_OfDate_Options_Handle, (ulong)unit, value, date.Handle, (ulong)options));
	}

	[Export("dateBySettingHour:minute:second:ofDate:options:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate DateBySettingsHour(nint hour, nint minute, nint second, NSDate date, NSCalendarOptions options)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_nint_nint_nint_IntPtr_UInt64(base.Handle, selDateBySettingHour_Minute_Second_OfDate_Options_Handle, hour, minute, second, date.Handle, (ulong)options));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_nint_nint_nint_IntPtr_UInt64(base.SuperHandle, selDateBySettingHour_Minute_Second_OfDate_Options_Handle, hour, minute, second, date.Handle, (ulong)options));
	}

	[Export("dateWithEra:yearForWeekOfYear:weekOfYear:weekday:hour:minute:second:nanosecond:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate DateForWeekOfYear(nint era, nint year, nint week, nint weekday, nint hour, nint minute, nint second, nint nanosecond)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_nint_nint_nint_nint_nint_nint_nint_nint(base.Handle, selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_Handle, era, year, week, weekday, hour, minute, second, nanosecond));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_nint_nint_nint_nint_nint_nint_nint_nint(base.SuperHandle, selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_Handle, era, year, week, weekday, hour, minute, second, nanosecond));
	}

	[Export("dateFromComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate DateFromComponents(NSDateComponents comps)
	{
		if (comps == null)
		{
			throw new ArgumentNullException("comps");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDateFromComponents_Handle, comps.Handle));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDateFromComponents_Handle, comps.Handle));
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

	[Export("enumerateDatesStartingAfterDate:matchingComponents:options:usingBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateDatesStartingAfterDate(NSDate start, NSDateComponents matchingComponents, NSCalendarOptions options, [BlockProxy(typeof(Trampolines.NIDEnumerateDatesCallback))] EnumerateDatesCallback callback)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		if (matchingComponents == null)
		{
			throw new ArgumentNullException("matchingComponents");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDEnumerateDatesCallback.Handler, callback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_Handle, start.Handle, matchingComponents.Handle, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_Handle, start.Handle, matchingComponents.Handle, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("nextDateAfterDate:matchingComponents:options:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate FindNextDateAfterDateMatching(NSDate date, NSDateComponents components, NSCalendarOptions options)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selNextDateAfterDate_MatchingComponents_Options_Handle, date.Handle, components.Handle, (ulong)options));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.xamarin_IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selNextDateAfterDate_MatchingComponents_Options_Handle, date.Handle, components.Handle, (ulong)options));
	}

	[Export("nextDateAfterDate:matchingHour:minute:second:options:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate FindNextDateAfterDateMatching(NSDate date, nint hour, nint minute, nint second, NSCalendarOptions options)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr_nint_nint_nint_UInt64(base.Handle, selNextDateAfterDate_MatchingHour_Minute_Second_Options_Handle, date.Handle, hour, minute, second, (ulong)options));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.xamarin_IntPtr_objc_msgSendSuper_IntPtr_nint_nint_nint_UInt64(base.SuperHandle, selNextDateAfterDate_MatchingHour_Minute_Second_Options_Handle, date.Handle, hour, minute, second, (ulong)options));
	}

	[Export("nextDateAfterDate:matchingUnit:value:options:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate FindNextDateAfterDateMatching(NSDate date, NSCalendarUnit unit, nint value, NSCalendarOptions options)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr_UInt64_nint_UInt64(base.Handle, selNextDateAfterDate_MatchingUnit_Value_Options_Handle, date.Handle, (ulong)unit, value, (ulong)options));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.xamarin_IntPtr_objc_msgSendSuper_IntPtr_UInt64_nint_UInt64(base.SuperHandle, selNextDateAfterDate_MatchingUnit_Value_Options_Handle, date.Handle, (ulong)unit, value, (ulong)options));
	}

	[Export("nextWeekendStartDate:interval:options:afterDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FindNextWeekend(out NSDate date, out double interval, NSCalendarOptions options, NSDate afterDate)
	{
		if (afterDate == null)
		{
			throw new ArgumentNullException("afterDate");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_out_Double_UInt64_IntPtr(base.SuperHandle, selNextWeekendStartDate_Interval_Options_AfterDate_Handle, ref arg, out interval, (ulong)options, afterDate.Handle) : Messaging.bool_objc_msgSend_ref_IntPtr_out_Double_UInt64_IntPtr(base.Handle, selNextWeekendStartDate_Interval_Options_AfterDate_Handle, ref arg, out interval, (ulong)options, afterDate.Handle));
		date = Runtime.GetNSObject<NSDate>(arg);
		return result;
	}

	[Export("component:fromDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetComponentFromDate(NSCalendarUnit unit, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_UInt64_IntPtr(base.Handle, selComponent_FromDate_Handle, (ulong)unit, date.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selComponent_FromDate_Handle, (ulong)unit, date.Handle);
	}

	[Export("getEra:year:month:day:fromDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetComponentsFromDate(out nint era, out nint year, out nint month, out nint day, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nint_out_nint_out_nint_out_nint_IntPtr(base.Handle, selGetEra_Year_Month_Day_FromDate_Handle, out era, out year, out month, out day, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nint_out_nint_out_nint_out_nint_IntPtr(base.SuperHandle, selGetEra_Year_Month_Day_FromDate_Handle, out era, out year, out month, out day, date.Handle);
		}
	}

	[Export("getEra:yearForWeekOfYear:weekOfYear:weekday:fromDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetComponentsFromDateForWeekOfYear(out nint era, out nint year, out nint weekOfYear, out nint weekday, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nint_out_nint_out_nint_out_nint_IntPtr(base.Handle, selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_Handle, out era, out year, out weekOfYear, out weekday, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nint_out_nint_out_nint_out_nint_IntPtr(base.SuperHandle, selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_Handle, out era, out year, out weekOfYear, out weekday, date.Handle);
		}
	}

	[Export("getHour:minute:second:nanosecond:fromDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetHourComponentsFromDate(out nint hour, out nint minute, out nint second, out nint nanosecond, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nint_out_nint_out_nint_out_nint_IntPtr(base.Handle, selGetHour_Minute_Second_Nanosecond_FromDate_Handle, out hour, out minute, out second, out nanosecond, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nint_out_nint_out_nint_out_nint_IntPtr(base.SuperHandle, selGetHour_Minute_Second_Nanosecond_FromDate_Handle, out hour, out minute, out second, out nanosecond, date.Handle);
		}
	}

	[Export("isDateInToday:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDateInToday(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDateInToday_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDateInToday_Handle, date.Handle);
	}

	[Export("isDateInTomorrow:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDateInTomorrow(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDateInTomorrow_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDateInTomorrow_Handle, date.Handle);
	}

	[Export("isDateInWeekend:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDateInWeekend(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDateInWeekend_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDateInWeekend_Handle, date.Handle);
	}

	[Export("isDateInYesterday:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDateInYesterday(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDateInYesterday_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDateInYesterday_Handle, date.Handle);
	}

	[Export("isDate:equalToDate:toUnitGranularity:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToUnitGranularity(NSDate date1, NSDate date2, NSCalendarUnit unit)
	{
		if (date1 == null)
		{
			throw new ArgumentNullException("date1");
		}
		if (date2 == null)
		{
			throw new ArgumentNullException("date2");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selIsDate_EqualToDate_ToUnitGranularity_Handle, date1.Handle, date2.Handle, (ulong)unit);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selIsDate_EqualToDate_ToUnitGranularity_Handle, date1.Handle, date2.Handle, (ulong)unit);
	}

	[Export("isDate:inSameDayAsDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsInSameDay(NSDate date1, NSDate date2)
	{
		if (date1 == null)
		{
			throw new ArgumentNullException("date1");
		}
		if (date2 == null)
		{
			throw new ArgumentNullException("date2");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsDate_InSameDayAsDate_Handle, date1.Handle, date2.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsDate_InSameDayAsDate_Handle, date1.Handle, date2.Handle);
	}

	[Export("date:matchesComponents:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Matches(NSDate date, NSDateComponents components)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selDate_MatchesComponents_Handle, date.Handle, components.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDate_MatchesComponents_Handle, date.Handle, components.Handle);
	}

	[Export("maximumRangeOfUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange MaximumRange(NSCalendarUnit unit)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_UInt64(base.Handle, selMaximumRangeOfUnit_Handle, (ulong)unit);
		}
		return Messaging.NSRange_objc_msgSendSuper_UInt64(base.SuperHandle, selMaximumRangeOfUnit_Handle, (ulong)unit);
	}

	[Export("minimumRangeOfUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange MinimumRange(NSCalendarUnit unit)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_UInt64(base.Handle, selMinimumRangeOfUnit_Handle, (ulong)unit);
		}
		return Messaging.NSRange_objc_msgSendSuper_UInt64(base.SuperHandle, selMinimumRangeOfUnit_Handle, (ulong)unit);
	}

	[Export("ordinalityOfUnit:inUnit:forDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Ordinality(NSCalendarUnit smaller, NSCalendarUnit larger, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_UInt64_UInt64_IntPtr(base.Handle, selOrdinalityOfUnit_InUnit_ForDate_Handle, (ulong)smaller, (ulong)larger, date.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_UInt64_UInt64_IntPtr(base.SuperHandle, selOrdinalityOfUnit_InUnit_ForDate_Handle, (ulong)smaller, (ulong)larger, date.Handle);
	}

	[Export("rangeOfUnit:inUnit:forDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange Range(NSCalendarUnit smaller, NSCalendarUnit larger, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_UInt64_UInt64_IntPtr(base.Handle, selRangeOfUnit_InUnit_ForDate_Handle, (ulong)smaller, (ulong)larger, date.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_UInt64_UInt64_IntPtr(base.SuperHandle, selRangeOfUnit_InUnit_ForDate_Handle, (ulong)smaller, (ulong)larger, date.Handle);
	}

	[Export("rangeOfUnit:startDate:interval:forDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Range(NSCalendarUnit unit, out NSDate? datep, out double interval, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_UInt64_ref_IntPtr_out_Double_IntPtr(base.SuperHandle, selRangeOfUnit_StartDate_Interval_ForDate_Handle, (ulong)unit, ref arg, out interval, date.Handle) : Messaging.bool_objc_msgSend_UInt64_ref_IntPtr_out_Double_IntPtr(base.Handle, selRangeOfUnit_StartDate_Interval_ForDate_Handle, (ulong)unit, ref arg, out interval, date.Handle));
		datep = Runtime.GetNSObject<NSDate>(arg);
		return result;
	}

	[Export("rangeOfWeekendStartDate:interval:containingDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RangeOfWeekendContainingDate(out NSDate weekendStartDate, out double interval, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_out_Double_IntPtr(base.SuperHandle, selRangeOfWeekendStartDate_Interval_ContainingDate_Handle, ref arg, out interval, date.Handle) : Messaging.bool_objc_msgSend_ref_IntPtr_out_Double_IntPtr(base.Handle, selRangeOfWeekendStartDate_Interval_ContainingDate_Handle, ref arg, out interval, date.Handle));
		weekendStartDate = Runtime.GetNSObject<NSDate>(arg);
		return result;
	}

	[Export("startOfDayForDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate StartOfDayForDate(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStartOfDayForDate_Handle, date.Handle));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartOfDayForDate_Handle, date.Handle));
	}
}
