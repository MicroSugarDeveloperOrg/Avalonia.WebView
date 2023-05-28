using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSRelativeDateTimeFormatter", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSRelativeDateTimeFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendar = "calendar";

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateTimeStyle = "dateTimeStyle";

	private static readonly IntPtr selDateTimeStyleHandle = Selector.GetHandle("dateTimeStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormattingContext = "formattingContext";

	private static readonly IntPtr selFormattingContextHandle = Selector.GetHandle("formattingContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForDate_RelativeToDate_ = "localizedStringForDate:relativeToDate:";

	private static readonly IntPtr selLocalizedStringForDate_RelativeToDate_Handle = Selector.GetHandle("localizedStringForDate:relativeToDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringFromDateComponents_ = "localizedStringFromDateComponents:";

	private static readonly IntPtr selLocalizedStringFromDateComponents_Handle = Selector.GetHandle("localizedStringFromDateComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringFromTimeInterval_ = "localizedStringFromTimeInterval:";

	private static readonly IntPtr selLocalizedStringFromTimeInterval_Handle = Selector.GetHandle("localizedStringFromTimeInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendar_ = "setCalendar:";

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDateTimeStyle_ = "setDateTimeStyle:";

	private static readonly IntPtr selSetDateTimeStyle_Handle = Selector.GetHandle("setDateTimeStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormattingContext_ = "setFormattingContext:";

	private static readonly IntPtr selSetFormattingContext_Handle = Selector.GetHandle("setFormattingContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocale_ = "setLocale:";

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnitsStyle_ = "setUnitsStyle:";

	private static readonly IntPtr selSetUnitsStyle_Handle = Selector.GetHandle("setUnitsStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForObjectValue_ = "stringForObjectValue:";

	private static readonly IntPtr selStringForObjectValue_Handle = Selector.GetHandle("stringForObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnitsStyle = "unitsStyle";

	private static readonly IntPtr selUnitsStyleHandle = Selector.GetHandle("unitsStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRelativeDateTimeFormatter");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual NSRelativeDateTimeFormatterStyle DateTimeStyle
	{
		[Export("dateTimeStyle", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSRelativeDateTimeFormatterStyle)Messaging.Int64_objc_msgSend(base.Handle, selDateTimeStyleHandle);
			}
			return (NSRelativeDateTimeFormatterStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDateTimeStyleHandle);
		}
		[Export("setDateTimeStyle:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDateTimeStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDateTimeStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFormattingContext FormattingContext
	{
		[Export("formattingContext", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFormattingContext)Messaging.Int64_objc_msgSend(base.Handle, selFormattingContextHandle);
			}
			return (NSFormattingContext)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFormattingContextHandle);
		}
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
	public virtual NSRelativeDateTimeFormatterUnitsStyle UnitsStyle
	{
		[Export("unitsStyle", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSRelativeDateTimeFormatterUnitsStyle)Messaging.Int64_objc_msgSend(base.Handle, selUnitsStyleHandle);
			}
			return (NSRelativeDateTimeFormatterUnitsStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUnitsStyleHandle);
		}
		[Export("setUnitsStyle:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetUnitsStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetUnitsStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRelativeDateTimeFormatter()
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
	public NSRelativeDateTimeFormatter(NSCoder coder)
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
	protected NSRelativeDateTimeFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRelativeDateTimeFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("localizedStringFromDateComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLocalizedString(NSDateComponents dateComponents)
	{
		if (dateComponents == null)
		{
			throw new ArgumentNullException("dateComponents");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLocalizedStringFromDateComponents_Handle, dateComponents.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocalizedStringFromDateComponents_Handle, dateComponents.Handle));
	}

	[Export("localizedStringFromTimeInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLocalizedString(double timeInterval)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selLocalizedStringFromTimeInterval_Handle, timeInterval));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selLocalizedStringFromTimeInterval_Handle, timeInterval));
	}

	[Export("localizedStringForDate:relativeToDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLocalizedString(NSDate date, NSDate referenceDate)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (referenceDate == null)
		{
			throw new ArgumentNullException("referenceDate");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLocalizedStringForDate_RelativeToDate_Handle, date.Handle, referenceDate.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLocalizedStringForDate_RelativeToDate_Handle, date.Handle, referenceDate.Handle));
	}

	[Export("stringForObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetString(NSObject? obj)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForObjectValue_Handle, obj?.Handle ?? IntPtr.Zero));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForObjectValue_Handle, obj?.Handle ?? IntPtr.Zero));
	}
}
