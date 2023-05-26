using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace EventKit;

[Register("EKEvent", true)]
public class EKEvent : EKCalendarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailability = "availability";

	private static readonly IntPtr selAvailabilityHandle = Selector.GetHandle("availability");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthdayContactIdentifier = "birthdayContactIdentifier";

	private static readonly IntPtr selBirthdayContactIdentifierHandle = Selector.GetHandle("birthdayContactIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthdayPersonUniqueID = "birthdayPersonUniqueID";

	private static readonly IntPtr selBirthdayPersonUniqueIDHandle = Selector.GetHandle("birthdayPersonUniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompareStartDateWithEvent_ = "compareStartDateWithEvent:";

	private static readonly IntPtr selCompareStartDateWithEvent_Handle = Selector.GetHandle("compareStartDateWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDate = "endDate";

	private static readonly IntPtr selEndDateHandle = Selector.GetHandle("endDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventIdentifier = "eventIdentifier";

	private static readonly IntPtr selEventIdentifierHandle = Selector.GetHandle("eventIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventWithEventStore_ = "eventWithEventStore:";

	private static readonly IntPtr selEventWithEventStore_Handle = Selector.GetHandle("eventWithEventStore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAllDay = "isAllDay";

	private static readonly IntPtr selIsAllDayHandle = Selector.GetHandle("isAllDay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDetached = "isDetached";

	private static readonly IntPtr selIsDetachedHandle = Selector.GetHandle("isDetached");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOccurrenceDate = "occurrenceDate";

	private static readonly IntPtr selOccurrenceDateHandle = Selector.GetHandle("occurrenceDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrganizer = "organizer";

	private static readonly IntPtr selOrganizerHandle = Selector.GetHandle("organizer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRefresh = "refresh";

	private static readonly IntPtr selRefreshHandle = Selector.GetHandle("refresh");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllDay_ = "setAllDay:";

	private static readonly IntPtr selSetAllDay_Handle = Selector.GetHandle("setAllDay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAvailability_ = "setAvailability:";

	private static readonly IntPtr selSetAvailability_Handle = Selector.GetHandle("setAvailability:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEndDate_ = "setEndDate:";

	private static readonly IntPtr selSetEndDate_Handle = Selector.GetHandle("setEndDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartDate_ = "setStartDate:";

	private static readonly IntPtr selSetStartDate_Handle = Selector.GetHandle("setStartDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStructuredLocation_ = "setStructuredLocation:";

	private static readonly IntPtr selSetStructuredLocation_Handle = Selector.GetHandle("setStructuredLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDate = "startDate";

	private static readonly IntPtr selStartDateHandle = Selector.GetHandle("startDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStructuredLocation = "structuredLocation";

	private static readonly IntPtr selStructuredLocationHandle = Selector.GetHandle("structuredLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("EKEvent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllDay
	{
		[Export("isAllDay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAllDayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAllDayHandle);
		}
		[Export("setAllDay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllDay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllDay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKEventAvailability Availability
	{
		[Export("availability")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKEventAvailability)Messaging.Int64_objc_msgSend(base.Handle, selAvailabilityHandle);
			}
			return (EKEventAvailability)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAvailabilityHandle);
		}
		[Export("setAvailability:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAvailability_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAvailability_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string? BirthdayContactIdentifier
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("birthdayContactIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBirthdayContactIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBirthdayContactIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Replaced by 'BirthdayContactIdentifier'.")]
	public virtual string? BirthdayPersonUniqueID
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Replaced by 'BirthdayContactIdentifier'.")]
		[Export("birthdayPersonUniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBirthdayPersonUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBirthdayPersonUniqueIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate EndDate
	{
		[Export("endDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndDateHandle));
		}
		[Export("setEndDate:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEndDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEndDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string EventIdentifier
	{
		[Export("eventIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEventIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEventIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDetached
	{
		[Export("isDetached")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDetachedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDetachedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual NSDate OccurrenceDate
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("occurrenceDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selOccurrenceDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOccurrenceDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKParticipant? Organizer
	{
		[Export("organizer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selOrganizerHandle));
			}
			return Runtime.GetNSObject<EKParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOrganizerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate StartDate
	{
		[Export("startDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selStartDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartDateHandle));
		}
		[Export("setStartDate:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStartDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStartDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual EKEventStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (EKEventStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (EKEventStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual EKStructuredLocation? StructuredLocation
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("structuredLocation", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<EKStructuredLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selStructuredLocationHandle));
			}
			return Runtime.GetNSObject<EKStructuredLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStructuredLocationHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setStructuredLocation:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStructuredLocation_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStructuredLocation_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected EKEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal EKEvent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compareStartDateWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonResult CompareStartDateWithEvent(EKEvent other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompareStartDateWithEvent_Handle, other.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompareStartDateWithEvent_Handle, other.Handle);
	}

	[Export("eventWithEventStore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static EKEvent FromStore(EKEventStore eventStore)
	{
		if (eventStore == null)
		{
			throw new ArgumentNullException("eventStore");
		}
		return Runtime.GetNSObject<EKEvent>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEventWithEventStore_Handle, eventStore.Handle));
	}

	[Export("refresh")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool Refresh()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRefreshHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRefreshHandle);
	}
}
