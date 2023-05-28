using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCalendarDate", true)]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use NSCalendar and NSDateComponents.")]
public class NSCalendarDate : NSDate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarFormat = "calendarFormat";

	private static readonly IntPtr selCalendarFormatHandle = Selector.GetHandle("calendarFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateByAddingYears_Months_Days_Hours_Minutes_Seconds_ = "dateByAddingYears:months:days:hours:minutes:seconds:";

	private static readonly IntPtr selDateByAddingYears_Months_Days_Hours_Minutes_Seconds_Handle = Selector.GetHandle("dateByAddingYears:months:days:hours:minutes:seconds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDayOfCommonEra = "dayOfCommonEra";

	private static readonly IntPtr selDayOfCommonEraHandle = Selector.GetHandle("dayOfCommonEra");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDayOfMonth = "dayOfMonth";

	private static readonly IntPtr selDayOfMonthHandle = Selector.GetHandle("dayOfMonth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDayOfWeek = "dayOfWeek";

	private static readonly IntPtr selDayOfWeekHandle = Selector.GetHandle("dayOfWeek");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDayOfYear = "dayOfYear";

	private static readonly IntPtr selDayOfYearHandle = Selector.GetHandle("dayOfYear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptionWithCalendarFormat_ = "descriptionWithCalendarFormat:";

	private static readonly IntPtr selDescriptionWithCalendarFormat_Handle = Selector.GetHandle("descriptionWithCalendarFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptionWithCalendarFormat_Locale_ = "descriptionWithCalendarFormat:locale:";

	private static readonly IntPtr selDescriptionWithCalendarFormat_Locale_Handle = Selector.GetHandle("descriptionWithCalendarFormat:locale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptionWithLocale_ = "descriptionWithLocale:";

	private static readonly IntPtr selDescriptionWithLocale_Handle = Selector.GetHandle("descriptionWithLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHourOfDay = "hourOfDay";

	private static readonly IntPtr selHourOfDayHandle = Selector.GetHandle("hourOfDay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_CalendarFormat_ = "initWithString:calendarFormat:";

	private static readonly IntPtr selInitWithString_CalendarFormat_Handle = Selector.GetHandle("initWithString:calendarFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_CalendarFormat_Locale_ = "initWithString:calendarFormat:locale:";

	private static readonly IntPtr selInitWithString_CalendarFormat_Locale_Handle = Selector.GetHandle("initWithString:calendarFormat:locale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithYear_Month_Day_Hour_Minute_Second_TimeZone_ = "initWithYear:month:day:hour:minute:second:timeZone:";

	private static readonly IntPtr selInitWithYear_Month_Day_Hour_Minute_Second_TimeZone_Handle = Selector.GetHandle("initWithYear:month:day:hour:minute:second:timeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinuteOfHour = "minuteOfHour";

	private static readonly IntPtr selMinuteOfHourHandle = Selector.GetHandle("minuteOfHour");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonthOfYear = "monthOfYear";

	private static readonly IntPtr selMonthOfYearHandle = Selector.GetHandle("monthOfYear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondOfMinute = "secondOfMinute";

	private static readonly IntPtr selSecondOfMinuteHandle = Selector.GetHandle("secondOfMinute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendarFormat_ = "setCalendarFormat:";

	private static readonly IntPtr selSetCalendarFormat_Handle = Selector.GetHandle("setCalendarFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeZone_ = "setTimeZone:";

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYearOfCommonEra = "yearOfCommonEra";

	private static readonly IntPtr selYearOfCommonEraHandle = Selector.GetHandle("yearOfCommonEra");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCalendarDate");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string CalendarFormat
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("calendarFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarFormatHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setCalendarFormat:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalendarFormat_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalendarFormat_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint DayOfCommonEra
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("dayOfCommonEra")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDayOfCommonEraHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDayOfCommonEraHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint DayOfMonth
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("dayOfMonth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDayOfMonthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDayOfMonthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint DayOfWeek
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("dayOfWeek")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDayOfWeekHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDayOfWeekHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint DayOfYear
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("dayOfYear")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDayOfYearHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDayOfYearHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint HourOfDay
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("hourOfDay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHourOfDayHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHourOfDayHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint MinuteOfHour
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("minuteOfHour")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMinuteOfHourHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMinuteOfHourHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint MonthOfYear
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("monthOfYear")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMonthOfYearHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMonthOfYearHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint SecondOfMinute
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("secondOfMinute")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSecondOfMinuteHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSecondOfMinuteHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSTimeZone TimeZone
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("timeZone")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeZoneHandle));
			}
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeZoneHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setTimeZone:")]
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
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nint YearOfCommonEra
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("yearOfCommonEra")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selYearOfCommonEraHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selYearOfCommonEraHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCalendarDate()
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
	public NSCalendarDate(NSCoder coder)
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
	protected NSCalendarDate(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCalendarDate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithString:calendarFormat:locale:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCalendarDate(string description, string calendarFormat, NSObject locale)
		: base(NSObjectFlag.Empty)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		if (calendarFormat == null)
		{
			throw new ArgumentNullException("calendarFormat");
		}
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		IntPtr arg = NSString.CreateNative(description);
		IntPtr arg2 = NSString.CreateNative(calendarFormat);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithString_CalendarFormat_Locale_Handle, arg, arg2, locale.Handle), "initWithString:calendarFormat:locale:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithString_CalendarFormat_Locale_Handle, arg, arg2, locale.Handle), "initWithString:calendarFormat:locale:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithString:calendarFormat:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCalendarDate(string description, string calendarFormat)
		: base(NSObjectFlag.Empty)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		if (calendarFormat == null)
		{
			throw new ArgumentNullException("calendarFormat");
		}
		IntPtr arg = NSString.CreateNative(description);
		IntPtr arg2 = NSString.CreateNative(calendarFormat);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithString_CalendarFormat_Handle, arg, arg2), "initWithString:calendarFormat:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithString_CalendarFormat_Handle, arg, arg2), "initWithString:calendarFormat:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithString:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCalendarDate(string description)
		: base(NSObjectFlag.Empty)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		IntPtr arg = NSString.CreateNative(description);
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

	[Export("initWithYear:month:day:hour:minute:second:timeZone:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCalendarDate(nint year, nuint month, nuint day, nuint hour, nuint minute, nuint second, NSTimeZone aTimeZone)
		: base(NSObjectFlag.Empty)
	{
		if (aTimeZone == null)
		{
			throw new ArgumentNullException("aTimeZone");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint_nuint_nuint_nuint_nuint_nuint_IntPtr(base.Handle, selInitWithYear_Month_Day_Hour_Minute_Second_TimeZone_Handle, year, month, day, hour, minute, second, aTimeZone.Handle), "initWithYear:month:day:hour:minute:second:timeZone:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint_nuint_nuint_nuint_nuint_nuint_IntPtr(base.SuperHandle, selInitWithYear_Month_Day_Hour_Minute_Second_TimeZone_Handle, year, month, day, hour, minute, second, aTimeZone.Handle), "initWithYear:month:day:hour:minute:second:timeZone:");
		}
	}

	[Export("dateByAddingYears:months:days:hours:minutes:seconds:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCalendarDate DateByAddingYears(nint year, nint month, nint day, nint hour, nint minute, nint second)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCalendarDate>(Messaging.IntPtr_objc_msgSend_nint_nint_nint_nint_nint_nint(base.Handle, selDateByAddingYears_Months_Days_Hours_Minutes_Seconds_Handle, year, month, day, hour, minute, second));
		}
		return Runtime.GetNSObject<NSCalendarDate>(Messaging.IntPtr_objc_msgSendSuper_nint_nint_nint_nint_nint_nint(base.SuperHandle, selDateByAddingYears_Months_Days_Hours_Minutes_Seconds_Handle, year, month, day, hour, minute, second));
	}

	[Export("descriptionWithCalendarFormat:locale:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetDescription(string calendarFormat, NSObject locale)
	{
		if (calendarFormat == null)
		{
			throw new ArgumentNullException("calendarFormat");
		}
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		IntPtr arg = NSString.CreateNative(calendarFormat);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDescriptionWithCalendarFormat_Locale_Handle, arg, locale.Handle)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDescriptionWithCalendarFormat_Locale_Handle, arg, locale.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("descriptionWithCalendarFormat:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetDescription(string calendarFormat)
	{
		if (calendarFormat == null)
		{
			throw new ArgumentNullException("calendarFormat");
		}
		IntPtr arg = NSString.CreateNative(calendarFormat);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescriptionWithCalendarFormat_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescriptionWithCalendarFormat_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("descriptionWithLocale:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetDescription(NSLocale locale)
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
}
