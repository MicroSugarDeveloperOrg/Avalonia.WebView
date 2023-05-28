using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSDateComponents", true)]
public class NSDateComponents : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	public static readonly nint Undefined = nint.MaxValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendar = "calendar";

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDate = "date";

	private static readonly IntPtr selDateHandle = Selector.GetHandle("date");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDay = "day";

	private static readonly IntPtr selDayHandle = Selector.GetHandle("day");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEra = "era";

	private static readonly IntPtr selEraHandle = Selector.GetHandle("era");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHour = "hour";

	private static readonly IntPtr selHourHandle = Selector.GetHandle("hour");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLeapMonth = "isLeapMonth";

	private static readonly IntPtr selIsLeapMonthHandle = Selector.GetHandle("isLeapMonth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValidDate = "isValidDate";

	private static readonly IntPtr selIsValidDateHandle = Selector.GetHandle("isValidDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValidDateInCalendar_ = "isValidDateInCalendar:";

	private static readonly IntPtr selIsValidDateInCalendar_Handle = Selector.GetHandle("isValidDateInCalendar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinute = "minute";

	private static readonly IntPtr selMinuteHandle = Selector.GetHandle("minute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonth = "month";

	private static readonly IntPtr selMonthHandle = Selector.GetHandle("month");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNanosecond = "nanosecond";

	private static readonly IntPtr selNanosecondHandle = Selector.GetHandle("nanosecond");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuarter = "quarter";

	private static readonly IntPtr selQuarterHandle = Selector.GetHandle("quarter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecond = "second";

	private static readonly IntPtr selSecondHandle = Selector.GetHandle("second");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendar_ = "setCalendar:";

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDay_ = "setDay:";

	private static readonly IntPtr selSetDay_Handle = Selector.GetHandle("setDay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEra_ = "setEra:";

	private static readonly IntPtr selSetEra_Handle = Selector.GetHandle("setEra:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHour_ = "setHour:";

	private static readonly IntPtr selSetHour_Handle = Selector.GetHandle("setHour:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeapMonth_ = "setLeapMonth:";

	private static readonly IntPtr selSetLeapMonth_Handle = Selector.GetHandle("setLeapMonth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinute_ = "setMinute:";

	private static readonly IntPtr selSetMinute_Handle = Selector.GetHandle("setMinute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMonth_ = "setMonth:";

	private static readonly IntPtr selSetMonth_Handle = Selector.GetHandle("setMonth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNanosecond_ = "setNanosecond:";

	private static readonly IntPtr selSetNanosecond_Handle = Selector.GetHandle("setNanosecond:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQuarter_ = "setQuarter:";

	private static readonly IntPtr selSetQuarter_Handle = Selector.GetHandle("setQuarter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecond_ = "setSecond:";

	private static readonly IntPtr selSetSecond_Handle = Selector.GetHandle("setSecond:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeZone_ = "setTimeZone:";

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForComponent_ = "setValue:forComponent:";

	private static readonly IntPtr selSetValue_ForComponent_Handle = Selector.GetHandle("setValue:forComponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeek_ = "setWeek:";

	private static readonly IntPtr selSetWeek_Handle = Selector.GetHandle("setWeek:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeekOfMonth_ = "setWeekOfMonth:";

	private static readonly IntPtr selSetWeekOfMonth_Handle = Selector.GetHandle("setWeekOfMonth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeekOfYear_ = "setWeekOfYear:";

	private static readonly IntPtr selSetWeekOfYear_Handle = Selector.GetHandle("setWeekOfYear:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeekday_ = "setWeekday:";

	private static readonly IntPtr selSetWeekday_Handle = Selector.GetHandle("setWeekday:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeekdayOrdinal_ = "setWeekdayOrdinal:";

	private static readonly IntPtr selSetWeekdayOrdinal_Handle = Selector.GetHandle("setWeekdayOrdinal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetYear_ = "setYear:";

	private static readonly IntPtr selSetYear_Handle = Selector.GetHandle("setYear:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetYearForWeekOfYear_ = "setYearForWeekOfYear:";

	private static readonly IntPtr selSetYearForWeekOfYear_Handle = Selector.GetHandle("setYearForWeekOfYear:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForComponent_ = "valueForComponent:";

	private static readonly IntPtr selValueForComponent_Handle = Selector.GetHandle("valueForComponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeek = "week";

	private static readonly IntPtr selWeekHandle = Selector.GetHandle("week");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeekOfMonth = "weekOfMonth";

	private static readonly IntPtr selWeekOfMonthHandle = Selector.GetHandle("weekOfMonth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeekOfYear = "weekOfYear";

	private static readonly IntPtr selWeekOfYearHandle = Selector.GetHandle("weekOfYear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeekday = "weekday";

	private static readonly IntPtr selWeekdayHandle = Selector.GetHandle("weekday");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeekdayOrdinal = "weekdayOrdinal";

	private static readonly IntPtr selWeekdayOrdinalHandle = Selector.GetHandle("weekdayOrdinal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYear = "year";

	private static readonly IntPtr selYearHandle = Selector.GetHandle("year");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYearForWeekOfYear = "yearForWeekOfYear";

	private static readonly IntPtr selYearForWeekOfYearHandle = Selector.GetHandle("yearForWeekOfYear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDateComponents");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCalendar? Calendar
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalendar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalendar_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate Date
	{
		[Export("date")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Day
	{
		[Export("day")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDayHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDayHandle);
		}
		[Export("setDay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetDay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetDay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Era
	{
		[Export("era")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selEraHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selEraHandle);
		}
		[Export("setEra:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetEra_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetEra_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Hour
	{
		[Export("hour")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHourHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHourHandle);
		}
		[Export("setHour:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetHour_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetHour_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLeapMonth
	{
		[Export("isLeapMonth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLeapMonthHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLeapMonthHandle);
		}
		[Export("setLeapMonth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLeapMonth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLeapMonth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool IsValidDate
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("isValidDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidDateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidDateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Minute
	{
		[Export("minute")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMinuteHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMinuteHandle);
		}
		[Export("setMinute:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMinute_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMinute_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Month
	{
		[Export("month")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMonthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMonthHandle);
		}
		[Export("setMonth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMonth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMonth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Nanosecond
	{
		[Export("nanosecond")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNanosecondHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNanosecondHandle);
		}
		[Export("setNanosecond:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNanosecond_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNanosecond_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Quarter
	{
		[Export("quarter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selQuarterHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selQuarterHandle);
		}
		[Export("setQuarter:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetQuarter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetQuarter_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Second
	{
		[Export("second")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSecondHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSecondHandle);
		}
		[Export("setSecond:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSecond_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSecond_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTimeZone? TimeZone
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimeZone_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimeZone_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'WeekOfMonth' or 'WeekOfYear' instead.")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'WeekOfMonth' or 'WeekOfYear' instead.")]
	public virtual nint Week
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'WeekOfMonth' or 'WeekOfYear' instead.")]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'WeekOfMonth' or 'WeekOfYear' instead.")]
		[Export("week")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWeekHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWeekHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'WeekOfMonth' or 'WeekOfYear' instead.")]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'WeekOfMonth' or 'WeekOfYear' instead.")]
		[Export("setWeek:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetWeek_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetWeek_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint WeekOfMonth
	{
		[Export("weekOfMonth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWeekOfMonthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWeekOfMonthHandle);
		}
		[Export("setWeekOfMonth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetWeekOfMonth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetWeekOfMonth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint WeekOfYear
	{
		[Export("weekOfYear")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWeekOfYearHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWeekOfYearHandle);
		}
		[Export("setWeekOfYear:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetWeekOfYear_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetWeekOfYear_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Weekday
	{
		[Export("weekday")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWeekdayHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWeekdayHandle);
		}
		[Export("setWeekday:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetWeekday_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetWeekday_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint WeekdayOrdinal
	{
		[Export("weekdayOrdinal")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWeekdayOrdinalHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWeekdayOrdinalHandle);
		}
		[Export("setWeekdayOrdinal:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetWeekdayOrdinal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetWeekdayOrdinal_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Year
	{
		[Export("year")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selYearHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selYearHandle);
		}
		[Export("setYear:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetYear_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetYear_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint YearForWeekOfYear
	{
		[Export("yearForWeekOfYear")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selYearForWeekOfYearHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selYearForWeekOfYearHandle);
		}
		[Export("setYearForWeekOfYear:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetYearForWeekOfYear_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetYearForWeekOfYear_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDateComponents()
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
	public NSDateComponents(NSCoder coder)
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
	protected NSDateComponents(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDateComponents(IntPtr handle)
		: base(handle)
	{
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

	[Export("valueForComponent:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetValueForComponent(NSCalendarUnit unit)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_UInt64(base.Handle, selValueForComponent_Handle, (ulong)unit);
		}
		return Messaging.nint_objc_msgSendSuper_UInt64(base.SuperHandle, selValueForComponent_Handle, (ulong)unit);
	}

	[Export("isValidDateInCalendar:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValidDateInCalendar(NSCalendar calendar)
	{
		if (calendar == null)
		{
			throw new ArgumentNullException("calendar");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsValidDateInCalendar_Handle, calendar.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsValidDateInCalendar_Handle, calendar.Handle);
	}

	[Export("setValue:forComponent:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValueForComponent(nint value, NSCalendarUnit unit)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_UInt64(base.Handle, selSetValue_ForComponent_Handle, value, (ulong)unit);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_UInt64(base.SuperHandle, selSetValue_ForComponent_Handle, value, (ulong)unit);
		}
	}
}
