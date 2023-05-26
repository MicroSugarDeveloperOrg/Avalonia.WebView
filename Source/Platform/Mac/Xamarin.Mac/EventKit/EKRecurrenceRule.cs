using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace EventKit;

[Register("EKRecurrenceRule", true)]
public class EKRecurrenceRule : EKObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarIdentifier = "calendarIdentifier";

	private static readonly IntPtr selCalendarIdentifierHandle = Selector.GetHandle("calendarIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDaysOfTheMonth = "daysOfTheMonth";

	private static readonly IntPtr selDaysOfTheMonthHandle = Selector.GetHandle("daysOfTheMonth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDaysOfTheWeek = "daysOfTheWeek";

	private static readonly IntPtr selDaysOfTheWeekHandle = Selector.GetHandle("daysOfTheWeek");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDaysOfTheYear = "daysOfTheYear";

	private static readonly IntPtr selDaysOfTheYearHandle = Selector.GetHandle("daysOfTheYear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstDayOfTheWeek = "firstDayOfTheWeek";

	private static readonly IntPtr selFirstDayOfTheWeekHandle = Selector.GetHandle("firstDayOfTheWeek");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrequency = "frequency";

	private static readonly IntPtr selFrequencyHandle = Selector.GetHandle("frequency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitRecurrenceWithFrequency_Interval_DaysOfTheWeek_DaysOfTheMonth_MonthsOfTheYear_WeeksOfTheYear_DaysOfTheYear_SetPositions_End_ = "initRecurrenceWithFrequency:interval:daysOfTheWeek:daysOfTheMonth:monthsOfTheYear:weeksOfTheYear:daysOfTheYear:setPositions:end:";

	private static readonly IntPtr selInitRecurrenceWithFrequency_Interval_DaysOfTheWeek_DaysOfTheMonth_MonthsOfTheYear_WeeksOfTheYear_DaysOfTheYear_SetPositions_End_Handle = Selector.GetHandle("initRecurrenceWithFrequency:interval:daysOfTheWeek:daysOfTheMonth:monthsOfTheYear:weeksOfTheYear:daysOfTheYear:setPositions:end:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitRecurrenceWithFrequency_Interval_End_ = "initRecurrenceWithFrequency:interval:end:";

	private static readonly IntPtr selInitRecurrenceWithFrequency_Interval_End_Handle = Selector.GetHandle("initRecurrenceWithFrequency:interval:end:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterval = "interval";

	private static readonly IntPtr selIntervalHandle = Selector.GetHandle("interval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonthsOfTheYear = "monthsOfTheYear";

	private static readonly IntPtr selMonthsOfTheYearHandle = Selector.GetHandle("monthsOfTheYear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecurrenceEnd = "recurrenceEnd";

	private static readonly IntPtr selRecurrenceEndHandle = Selector.GetHandle("recurrenceEnd");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPositions = "setPositions";

	private static readonly IntPtr selSetPositionsHandle = Selector.GetHandle("setPositions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecurrenceEnd_ = "setRecurrenceEnd:";

	private static readonly IntPtr selSetRecurrenceEnd_Handle = Selector.GetHandle("setRecurrenceEnd:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeeksOfTheYear = "weeksOfTheYear";

	private static readonly IntPtr selWeeksOfTheYearHandle = Selector.GetHandle("weeksOfTheYear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKRecurrenceRule");

	public EKDay FirstDayOfTheWeek => (EKDay)(int)_FirstDayOfTheWeek;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CalendarIdentifier
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
	public virtual NSNumber[]? DaysOfTheMonth
	{
		[Export("daysOfTheMonth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selDaysOfTheMonthHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDaysOfTheMonthHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKRecurrenceDayOfWeek[]? DaysOfTheWeek
	{
		[Export("daysOfTheWeek")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<EKRecurrenceDayOfWeek>(Messaging.IntPtr_objc_msgSend(base.Handle, selDaysOfTheWeekHandle));
			}
			return NSArray.ArrayFromHandle<EKRecurrenceDayOfWeek>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDaysOfTheWeekHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? DaysOfTheYear
	{
		[Export("daysOfTheYear")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selDaysOfTheYearHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDaysOfTheYearHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKRecurrenceFrequency Frequency
	{
		[Export("frequency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKRecurrenceFrequency)Messaging.Int64_objc_msgSend(base.Handle, selFrequencyHandle);
			}
			return (EKRecurrenceFrequency)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFrequencyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Interval
	{
		[Export("interval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIntervalHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIntervalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? MonthsOfTheYear
	{
		[Export("monthsOfTheYear")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selMonthsOfTheYearHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMonthsOfTheYearHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKRecurrenceEnd? RecurrenceEnd
	{
		[Export("recurrenceEnd", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKRecurrenceEnd>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecurrenceEndHandle));
			}
			return Runtime.GetNSObject<EKRecurrenceEnd>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecurrenceEndHandle));
		}
		[Export("setRecurrenceEnd:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecurrenceEnd_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecurrenceEnd_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? SetPositions
	{
		[Export("setPositions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSetPositionsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSetPositionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? WeeksOfTheYear
	{
		[Export("weeksOfTheYear")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selWeeksOfTheYearHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWeeksOfTheYearHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nint _FirstDayOfTheWeek
	{
		[Export("firstDayOfTheWeek")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFirstDayOfTheWeekHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFirstDayOfTheWeekHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public EKRecurrenceRule()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EKRecurrenceRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKRecurrenceRule(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initRecurrenceWithFrequency:interval:end:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EKRecurrenceRule(EKRecurrenceFrequency type, nint interval, EKRecurrenceEnd? end)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_nint_IntPtr(base.Handle, selInitRecurrenceWithFrequency_Interval_End_Handle, (long)type, interval, end?.Handle ?? IntPtr.Zero), "initRecurrenceWithFrequency:interval:end:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_nint_IntPtr(base.SuperHandle, selInitRecurrenceWithFrequency_Interval_End_Handle, (long)type, interval, end?.Handle ?? IntPtr.Zero), "initRecurrenceWithFrequency:interval:end:");
		}
	}

	[Export("initRecurrenceWithFrequency:interval:daysOfTheWeek:daysOfTheMonth:monthsOfTheYear:weeksOfTheYear:daysOfTheYear:setPositions:end:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EKRecurrenceRule(EKRecurrenceFrequency type, nint interval, EKRecurrenceDayOfWeek[]? days, NSNumber[]? monthDays, NSNumber[]? months, NSNumber[]? weeksOfTheYear, NSNumber[]? daysOfTheYear, NSNumber[]? setPositions, EKRecurrenceEnd? end)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((days == null) ? null : NSArray.FromNSObjects(days));
		NSArray nSArray2 = ((monthDays == null) ? null : NSArray.FromNSObjects(monthDays));
		NSArray nSArray3 = ((months == null) ? null : NSArray.FromNSObjects(months));
		NSArray nSArray4 = ((weeksOfTheYear == null) ? null : NSArray.FromNSObjects(weeksOfTheYear));
		NSArray nSArray5 = ((daysOfTheYear == null) ? null : NSArray.FromNSObjects(daysOfTheYear));
		NSArray nSArray6 = ((setPositions == null) ? null : NSArray.FromNSObjects(setPositions));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitRecurrenceWithFrequency_Interval_DaysOfTheWeek_DaysOfTheMonth_MonthsOfTheYear_WeeksOfTheYear_DaysOfTheYear_SetPositions_End_Handle, (long)type, interval, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero, end?.Handle ?? IntPtr.Zero), "initRecurrenceWithFrequency:interval:daysOfTheWeek:daysOfTheMonth:monthsOfTheYear:weeksOfTheYear:daysOfTheYear:setPositions:end:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitRecurrenceWithFrequency_Interval_DaysOfTheWeek_DaysOfTheMonth_MonthsOfTheYear_WeeksOfTheYear_DaysOfTheYear_SetPositions_End_Handle, (long)type, interval, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero, end?.Handle ?? IntPtr.Zero), "initRecurrenceWithFrequency:interval:daysOfTheWeek:daysOfTheMonth:monthsOfTheYear:weeksOfTheYear:daysOfTheYear:setPositions:end:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
		nSArray3?.Dispose();
		nSArray4?.Dispose();
		nSArray5?.Dispose();
		nSArray6?.Dispose();
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
}
