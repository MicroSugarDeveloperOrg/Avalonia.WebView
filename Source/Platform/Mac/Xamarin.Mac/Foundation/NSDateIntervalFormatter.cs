using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDateIntervalFormatter", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSDateIntervalFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendar = "calendar";

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateStyle = "dateStyle";

	private static readonly IntPtr selDateStyleHandle = Selector.GetHandle("dateStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateTemplate = "dateTemplate";

	private static readonly IntPtr selDateTemplateHandle = Selector.GetHandle("dateTemplate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendar_ = "setCalendar:";

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDateStyle_ = "setDateStyle:";

	private static readonly IntPtr selSetDateStyle_Handle = Selector.GetHandle("setDateStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDateTemplate_ = "setDateTemplate:";

	private static readonly IntPtr selSetDateTemplate_Handle = Selector.GetHandle("setDateTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocale_ = "setLocale:";

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeStyle_ = "setTimeStyle:";

	private static readonly IntPtr selSetTimeStyle_Handle = Selector.GetHandle("setTimeStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeZone_ = "setTimeZone:";

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromDate_ToDate_ = "stringFromDate:toDate:";

	private static readonly IntPtr selStringFromDate_ToDate_Handle = Selector.GetHandle("stringFromDate:toDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromDateInterval_ = "stringFromDateInterval:";

	private static readonly IntPtr selStringFromDateInterval_Handle = Selector.GetHandle("stringFromDateInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeStyle = "timeStyle";

	private static readonly IntPtr selTimeStyleHandle = Selector.GetHandle("timeStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDateIntervalFormatter");

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
	public virtual NSDateIntervalFormatterStyle DateStyle
	{
		[Export("dateStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDateIntervalFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selDateStyleHandle);
			}
			return (NSDateIntervalFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDateStyleHandle);
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
	public virtual string DateTemplate
	{
		[Export("dateTemplate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDateTemplateHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateTemplateHandle));
		}
		[Export("setDateTemplate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDateTemplate_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDateTemplate_Handle, arg);
			}
			NSString.ReleaseNative(arg);
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
	public virtual NSDateIntervalFormatterStyle TimeStyle
	{
		[Export("timeStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDateIntervalFormatterStyle)Messaging.UInt64_objc_msgSend(base.Handle, selTimeStyleHandle);
			}
			return (NSDateIntervalFormatterStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTimeStyleHandle);
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDateIntervalFormatter()
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
	public NSDateIntervalFormatter(NSCoder coder)
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
	protected NSDateIntervalFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDateIntervalFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("stringFromDate:toDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromDate(NSDate fromDate, NSDate toDate)
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
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selStringFromDate_ToDate_Handle, fromDate.Handle, toDate.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStringFromDate_ToDate_Handle, fromDate.Handle, toDate.Handle));
	}

	[Export("stringFromDateInterval:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ToString(NSDateInterval dateInterval)
	{
		if (dateInterval == null)
		{
			throw new ArgumentNullException("dateInterval");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromDateInterval_Handle, dateInterval.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromDateInterval_Handle, dateInterval.Handle));
	}
}
