using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDateComponents", true)]
public class NSDateComponents : NSObject
{
	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	private static readonly IntPtr selQuarterHandle = Selector.GetHandle("quarter");

	private static readonly IntPtr selSetQuarter_Handle = Selector.GetHandle("setQuarter:");

	private static readonly IntPtr selDateHandle = Selector.GetHandle("date");

	private static readonly IntPtr selEraHandle = Selector.GetHandle("era");

	private static readonly IntPtr selSetEra_Handle = Selector.GetHandle("setEra:");

	private static readonly IntPtr selYearHandle = Selector.GetHandle("year");

	private static readonly IntPtr selSetYear_Handle = Selector.GetHandle("setYear:");

	private static readonly IntPtr selMonthHandle = Selector.GetHandle("month");

	private static readonly IntPtr selSetMonth_Handle = Selector.GetHandle("setMonth:");

	private static readonly IntPtr selDayHandle = Selector.GetHandle("day");

	private static readonly IntPtr selSetDay_Handle = Selector.GetHandle("setDay:");

	private static readonly IntPtr selHourHandle = Selector.GetHandle("hour");

	private static readonly IntPtr selSetHour_Handle = Selector.GetHandle("setHour:");

	private static readonly IntPtr selMinuteHandle = Selector.GetHandle("minute");

	private static readonly IntPtr selSetMinute_Handle = Selector.GetHandle("setMinute:");

	private static readonly IntPtr selSecondHandle = Selector.GetHandle("second");

	private static readonly IntPtr selSetSecond_Handle = Selector.GetHandle("setSecond:");

	private static readonly IntPtr selWeekHandle = Selector.GetHandle("week");

	private static readonly IntPtr selSetWeek_Handle = Selector.GetHandle("setWeek:");

	private static readonly IntPtr selWeekdayHandle = Selector.GetHandle("weekday");

	private static readonly IntPtr selSetWeekday_Handle = Selector.GetHandle("setWeekday:");

	private static readonly IntPtr selWeekdayOrdinalHandle = Selector.GetHandle("weekdayOrdinal");

	private static readonly IntPtr selSetWeekdayOrdinal_Handle = Selector.GetHandle("setWeekdayOrdinal:");

	private static readonly IntPtr selWeekOfMonthHandle = Selector.GetHandle("weekOfMonth");

	private static readonly IntPtr selSetWeekOfMonth_Handle = Selector.GetHandle("setWeekOfMonth:");

	private static readonly IntPtr selWeekOfYearHandle = Selector.GetHandle("weekOfYear");

	private static readonly IntPtr selSetWeekOfYear_Handle = Selector.GetHandle("setWeekOfYear:");

	private static readonly IntPtr selYearForWeekOfYearHandle = Selector.GetHandle("yearForWeekOfYear");

	private static readonly IntPtr selSetYearForWeekOfYear_Handle = Selector.GetHandle("setYearForWeekOfYear:");

	private static readonly IntPtr selIsLeapMonthHandle = Selector.GetHandle("isLeapMonth");

	private static readonly IntPtr selSetLeapMonth_Handle = Selector.GetHandle("setLeapMonth:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDateComponents");

	private object __mt_TimeZone_var;

	private object __mt_Calendar_var;

	private object __mt_Date_var;

	public override IntPtr ClassHandle => class_ptr;

	[Since(4, 0)]
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

	[Since(4, 0)]
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

	[Since(4, 0)]
	public virtual long Quarter
	{
		[Export("quarter")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selQuarterHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selQuarterHandle);
		}
		[Export("setQuarter:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetQuarter_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetQuarter_Handle, value);
			}
		}
	}

	[Since(4, 0)]
	public virtual NSDate Date
	{
		[Export("date")]
		get
		{
			return (NSDate)(__mt_Date_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDateHandle)))));
		}
	}

	public virtual long Era
	{
		[Export("era")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selEraHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEraHandle);
		}
		[Export("setEra:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetEra_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetEra_Handle, value);
			}
		}
	}

	public virtual long Year
	{
		[Export("year")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selYearHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selYearHandle);
		}
		[Export("setYear:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetYear_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetYear_Handle, value);
			}
		}
	}

	public virtual long Month
	{
		[Export("month")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMonthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMonthHandle);
		}
		[Export("setMonth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMonth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMonth_Handle, value);
			}
		}
	}

	public virtual long Day
	{
		[Export("day")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selDayHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDayHandle);
		}
		[Export("setDay:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDay_Handle, value);
			}
		}
	}

	public virtual long Hour
	{
		[Export("hour")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selHourHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selHourHandle);
		}
		[Export("setHour:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetHour_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetHour_Handle, value);
			}
		}
	}

	public virtual long Minute
	{
		[Export("minute")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMinuteHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMinuteHandle);
		}
		[Export("setMinute:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMinute_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMinute_Handle, value);
			}
		}
	}

	public virtual long Second
	{
		[Export("second")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSecondHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSecondHandle);
		}
		[Export("setSecond:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSecond_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSecond_Handle, value);
			}
		}
	}

	public virtual long Week
	{
		[Export("week")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selWeekHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWeekHandle);
		}
		[Export("setWeek:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetWeek_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetWeek_Handle, value);
			}
		}
	}

	public virtual long Weekday
	{
		[Export("weekday")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selWeekdayHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWeekdayHandle);
		}
		[Export("setWeekday:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetWeekday_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetWeekday_Handle, value);
			}
		}
	}

	public virtual long WeekdayOrdinal
	{
		[Export("weekdayOrdinal")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selWeekdayOrdinalHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWeekdayOrdinalHandle);
		}
		[Export("setWeekdayOrdinal:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetWeekdayOrdinal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetWeekdayOrdinal_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual long WeekOfMonth
	{
		[Export("weekOfMonth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selWeekOfMonthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWeekOfMonthHandle);
		}
		[Export("setWeekOfMonth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetWeekOfMonth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetWeekOfMonth_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual long WeekOfYear
	{
		[Export("weekOfYear")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selWeekOfYearHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWeekOfYearHandle);
		}
		[Export("setWeekOfYear:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetWeekOfYear_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetWeekOfYear_Handle, value);
			}
		}
	}

	[Since(5, 0)]
	public virtual long YearForWeekOfYear
	{
		[Export("yearForWeekOfYear")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selYearForWeekOfYearHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selYearForWeekOfYearHandle);
		}
		[Export("setYearForWeekOfYear:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetYearForWeekOfYear_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetYearForWeekOfYear_Handle, value);
			}
		}
	}

	[Since(6, 0)]
	public virtual bool IsLeapMonth
	{
		[Export("isLeapMonth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLeapMonthHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLeapMonthHandle);
		}
		[Export("setLeapMonth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLeapMonth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLeapMonth_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDateComponents()
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
	public NSDateComponents(NSCoder coder)
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
	public NSDateComponents(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDateComponents(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TimeZone_var = null;
			__mt_Calendar_var = null;
			__mt_Date_var = null;
		}
	}
}
