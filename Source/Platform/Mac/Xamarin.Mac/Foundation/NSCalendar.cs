using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCalendar", true)]
public class NSCalendar : NSObject
{
	private static readonly IntPtr selCalendarIdentifierHandle = Selector.GetHandle("calendarIdentifier");

	private static readonly IntPtr selCurrentCalendarHandle = Selector.GetHandle("currentCalendar");

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	private static readonly IntPtr selFirstWeekdayHandle = Selector.GetHandle("firstWeekday");

	private static readonly IntPtr selSetFirstWeekday_Handle = Selector.GetHandle("setFirstWeekday:");

	private static readonly IntPtr selMinimumDaysInFirstWeekHandle = Selector.GetHandle("minimumDaysInFirstWeek");

	private static readonly IntPtr selSetMinimumDaysInFirstWeek_Handle = Selector.GetHandle("setMinimumDaysInFirstWeek:");

	private static readonly IntPtr selInitWithCalendarIdentifier_Handle = Selector.GetHandle("initWithCalendarIdentifier:");

	private static readonly IntPtr selComponentsFromDate_Handle = Selector.GetHandle("components:fromDate:");

	private static readonly IntPtr selComponentsFromDateToDateOptions_Handle = Selector.GetHandle("components:fromDate:toDate:options:");

	private static readonly IntPtr selDateByAddingComponentsToDateOptions_Handle = Selector.GetHandle("dateByAddingComponents:toDate:options:");

	private static readonly IntPtr selDateFromComponents_Handle = Selector.GetHandle("dateFromComponents:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCalendar");

	private static object __mt_CurrentCalendar_var_static;

	private object __mt_Locale_var;

	private object __mt_TimeZone_var;

	private static NSString _NSGregorianCalendar;

	private static NSString _NSBuddhistCalendar;

	private static NSString _NSChineseCalendar;

	private static NSString _NSHebrewCalendar;

	private static NSString _NSIslamicCalendar;

	private static NSString _NSIslamicCivilCalendar;

	private static NSString _NSJapaneseCalendar;

	private static NSString _NSRepublicOfChinaCalendar;

	private static NSString _NSPersianCalendar;

	private static NSString _NSIndianCalendar;

	private static NSString _NSISO8601Calendar;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Identifier
	{
		[Export("calendarIdentifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarIdentifierHandle));
		}
	}

	public static NSCalendar CurrentCalendar
	{
		[Export("currentCalendar")]
		get
		{
			return (NSCalendar)(__mt_CurrentCalendar_var_static = (NSCalendar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentCalendarHandle)));
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

	public virtual ulong FirstWeekDay
	{
		[Export("firstWeekday")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selFirstWeekdayHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFirstWeekdayHandle);
		}
		[Export("setFirstWeekday:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFirstWeekday_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFirstWeekday_Handle, value);
			}
		}
	}

	public virtual ulong MinimumDaysInFirstWeek
	{
		[Export("minimumDaysInFirstWeek")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selMinimumDaysInFirstWeekHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMinimumDaysInFirstWeekHandle);
		}
		[Export("setMinimumDaysInFirstWeek:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMinimumDaysInFirstWeek_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMinimumDaysInFirstWeek_Handle, value);
			}
		}
	}

	[Field("NSGregorianCalendar", "Foundation")]
	internal static NSString NSGregorianCalendar
	{
		get
		{
			if (_NSGregorianCalendar == null)
			{
				_NSGregorianCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSGregorianCalendar");
			}
			return _NSGregorianCalendar;
		}
	}

	[Field("NSBuddhistCalendar", "Foundation")]
	internal static NSString NSBuddhistCalendar
	{
		get
		{
			if (_NSBuddhistCalendar == null)
			{
				_NSBuddhistCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSBuddhistCalendar");
			}
			return _NSBuddhistCalendar;
		}
	}

	[Field("NSChineseCalendar", "Foundation")]
	internal static NSString NSChineseCalendar
	{
		get
		{
			if (_NSChineseCalendar == null)
			{
				_NSChineseCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSChineseCalendar");
			}
			return _NSChineseCalendar;
		}
	}

	[Field("NSHebrewCalendar", "Foundation")]
	internal static NSString NSHebrewCalendar
	{
		get
		{
			if (_NSHebrewCalendar == null)
			{
				_NSHebrewCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHebrewCalendar");
			}
			return _NSHebrewCalendar;
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

	[Field("NSIslamicCivilCalendar", "Foundation")]
	internal static NSString NSIslamicCivilCalendar
	{
		get
		{
			if (_NSIslamicCivilCalendar == null)
			{
				_NSIslamicCivilCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSIslamicCivilCalendar");
			}
			return _NSIslamicCivilCalendar;
		}
	}

	[Field("NSJapaneseCalendar", "Foundation")]
	internal static NSString NSJapaneseCalendar
	{
		get
		{
			if (_NSJapaneseCalendar == null)
			{
				_NSJapaneseCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSJapaneseCalendar");
			}
			return _NSJapaneseCalendar;
		}
	}

	[Field("NSRepublicOfChinaCalendar", "Foundation")]
	internal static NSString NSRepublicOfChinaCalendar
	{
		get
		{
			if (_NSRepublicOfChinaCalendar == null)
			{
				_NSRepublicOfChinaCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSRepublicOfChinaCalendar");
			}
			return _NSRepublicOfChinaCalendar;
		}
	}

	[Field("NSPersianCalendar", "Foundation")]
	internal static NSString NSPersianCalendar
	{
		get
		{
			if (_NSPersianCalendar == null)
			{
				_NSPersianCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPersianCalendar");
			}
			return _NSPersianCalendar;
		}
	}

	[Field("NSIndianCalendar", "Foundation")]
	internal static NSString NSIndianCalendar
	{
		get
		{
			if (_NSIndianCalendar == null)
			{
				_NSIndianCalendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSIndianCalendar");
			}
			return _NSIndianCalendar;
		}
	}

	[Field("NSISO8601Calendar", "Foundation")]
	internal static NSString NSISO8601Calendar
	{
		get
		{
			if (_NSISO8601Calendar == null)
			{
				_NSISO8601Calendar = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSISO8601Calendar");
			}
			return _NSISO8601Calendar;
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
			_ => throw new ArgumentException("Unknown NSCalendarType value"), 
		};
	}

	public NSCalendar(NSCalendarType calendarType)
		: this(GetCalendarIdentifier(calendarType))
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCalendar(NSCoder coder)
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
	public NSCalendar(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCalendar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCalendarIdentifier:")]
	public NSCalendar(NSString identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCalendarIdentifier_Handle, identifier.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCalendarIdentifier_Handle, identifier.Handle);
		}
	}

	[Export("components:fromDate:")]
	public virtual NSDateComponents Components(NSCalendarUnit unitFlags, NSDate fromDate)
	{
		if (fromDate == null)
		{
			throw new ArgumentNullException("fromDate");
		}
		if (IsDirectBinding)
		{
			return (NSDateComponents)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selComponentsFromDate_Handle, (ulong)unitFlags, fromDate.Handle));
		}
		return (NSDateComponents)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selComponentsFromDate_Handle, (ulong)unitFlags, fromDate.Handle));
	}

	[Export("components:fromDate:toDate:options:")]
	public virtual NSDateComponents Components(NSCalendarUnit unitFlags, NSDate fromDate, NSDate toDate, NSDateComponentsWrappingBehavior opts)
	{
		if (fromDate == null)
		{
			throw new ArgumentNullException("fromDate");
		}
		if (toDate == null)
		{
			throw new ArgumentNullException("toDate");
		}
		if (IsDirectBinding)
		{
			return (NSDateComponents)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_UInt64(base.Handle, selComponentsFromDateToDateOptions_Handle, (ulong)unitFlags, fromDate.Handle, toDate.Handle, (ulong)opts));
		}
		return (NSDateComponents)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_UInt64(base.SuperHandle, selComponentsFromDateToDateOptions_Handle, (ulong)unitFlags, fromDate.Handle, toDate.Handle, (ulong)opts));
	}

	[Export("dateByAddingComponents:toDate:options:")]
	public virtual NSDate DateByAddingComponents(NSDateComponents comps, NSDate date, NSDateComponentsWrappingBehavior opts)
	{
		if (comps == null)
		{
			throw new ArgumentNullException("comps");
		}
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selDateByAddingComponentsToDateOptions_Handle, comps.Handle, date.Handle, (ulong)opts));
		}
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selDateByAddingComponentsToDateOptions_Handle, comps.Handle, date.Handle, (ulong)opts));
	}

	[Export("dateFromComponents:")]
	public virtual NSDate DateFromComponents(NSDateComponents comps)
	{
		if (comps == null)
		{
			throw new ArgumentNullException("comps");
		}
		if (IsDirectBinding)
		{
			return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDateFromComponents_Handle, comps.Handle));
		}
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDateFromComponents_Handle, comps.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Locale_var = null;
			__mt_TimeZone_var = null;
		}
	}
}
