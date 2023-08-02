using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDatePickerCell", true)]
public class NSDatePickerCell : NSActionCell
{
	[Register]
	private sealed class _NSDatePickerCellDelegate : NSDatePickerCellDelegate
	{
		internal EventHandler<NSDatePickerValidatorEventArgs> validateProposedDateValue;

		[Preserve(Conditional = true)]
		public override void ValidateProposedDateValue(NSDatePickerCell aDatePickerCell, ref NSDate proposedDateValue, double proposedTimeInterval)
		{
			EventHandler<NSDatePickerValidatorEventArgs> eventHandler = validateProposedDateValue;
			if (eventHandler != null)
			{
				NSDatePickerValidatorEventArgs nSDatePickerValidatorEventArgs = new NSDatePickerValidatorEventArgs(proposedDateValue, proposedTimeInterval);
				eventHandler(aDatePickerCell, nSDatePickerValidatorEventArgs);
				proposedDateValue = nSDatePickerValidatorEventArgs.ProposedDateValue;
			}
		}
	}

	private static readonly IntPtr selDatePickerStyleHandle = Selector.GetHandle("datePickerStyle");

	private static readonly IntPtr selSetDatePickerStyle_Handle = Selector.GetHandle("setDatePickerStyle:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	private static readonly IntPtr selSetTextColor_Handle = Selector.GetHandle("setTextColor:");

	private static readonly IntPtr selDatePickerModeHandle = Selector.GetHandle("datePickerMode");

	private static readonly IntPtr selSetDatePickerMode_Handle = Selector.GetHandle("setDatePickerMode:");

	private static readonly IntPtr selDatePickerElementsHandle = Selector.GetHandle("datePickerElements");

	private static readonly IntPtr selSetDatePickerElements_Handle = Selector.GetHandle("setDatePickerElements:");

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	private static readonly IntPtr selDateValueHandle = Selector.GetHandle("dateValue");

	private static readonly IntPtr selSetDateValue_Handle = Selector.GetHandle("setDateValue:");

	private static readonly IntPtr selTimeIntervalHandle = Selector.GetHandle("timeInterval");

	private static readonly IntPtr selSetTimeInterval_Handle = Selector.GetHandle("setTimeInterval:");

	private static readonly IntPtr selMinDateHandle = Selector.GetHandle("minDate");

	private static readonly IntPtr selSetMinDate_Handle = Selector.GetHandle("setMinDate:");

	private static readonly IntPtr selMaxDateHandle = Selector.GetHandle("maxDate");

	private static readonly IntPtr selSetMaxDate_Handle = Selector.GetHandle("setMaxDate:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDatePickerCell");

	private object __mt_BackgroundColor_var;

	private object __mt_TextColor_var;

	private object __mt_Calendar_var;

	private object __mt_Locale_var;

	private object __mt_TimeZone_var;

	private object __mt_DateValue_var;

	private object __mt_MinDate_var;

	private object __mt_MaxDate_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDatePickerStyle DatePickerStyle
	{
		[Export("datePickerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSDatePickerStyle)Messaging.UInt64_objc_msgSend(base.Handle, selDatePickerStyleHandle);
			}
			return (NSDatePickerStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDatePickerStyleHandle);
		}
		[Export("setDatePickerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDatePickerStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDatePickerStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual NSColor TextColor
	{
		[Export("textColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_TextColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextColorHandle)))));
		}
		[Export("setTextColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextColor_Handle, value.Handle);
			}
			__mt_TextColor_var = value;
		}
	}

	public virtual NSDatePickerMode DatePickerMode
	{
		[Export("datePickerMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSDatePickerMode)Messaging.UInt64_objc_msgSend(base.Handle, selDatePickerModeHandle);
			}
			return (NSDatePickerMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDatePickerModeHandle);
		}
		[Export("setDatePickerMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDatePickerMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDatePickerMode_Handle, (ulong)value);
			}
		}
	}

	public virtual NSDatePickerElementFlags DatePickerElements
	{
		[Export("datePickerElements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSDatePickerElementFlags)Messaging.UInt64_objc_msgSend(base.Handle, selDatePickerElementsHandle);
			}
			return (NSDatePickerElementFlags)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDatePickerElementsHandle);
		}
		[Export("setDatePickerElements:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDatePickerElements_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDatePickerElements_Handle, (ulong)value);
			}
		}
	}

	public virtual NSCalendar Calendar
	{
		[Export("calendar")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCalendar)(__mt_Calendar_var = ((!IsDirectBinding) ? ((NSCalendar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarHandle))) : ((NSCalendar)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarHandle)))));
		}
		[Export("setCalendar:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual NSLocale Locale
	{
		[Export("locale")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSLocale)(__mt_Locale_var = ((!IsDirectBinding) ? ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle))) : ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle)))));
		}
		[Export("setLocale:")]
		set
		{
			NSApplication.EnsureUIThread();
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
			NSApplication.EnsureUIThread();
			return (NSTimeZone)(__mt_TimeZone_var = ((!IsDirectBinding) ? ((NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeZoneHandle))) : ((NSTimeZone)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeZoneHandle)))));
		}
		[Export("setTimeZone:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual NSDate DateValue
	{
		[Export("dateValue")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDate)(__mt_DateValue_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateValueHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDateValueHandle)))));
		}
		[Export("setDateValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDateValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDateValue_Handle, value.Handle);
			}
			__mt_DateValue_var = value;
		}
	}

	public virtual double TimeInterval
	{
		[Export("timeInterval")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalHandle);
		}
		[Export("setTimeInterval:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeInterval_Handle, value);
			}
		}
	}

	public virtual NSDate MinDate
	{
		[Export("minDate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDate)(__mt_MinDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMinDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMinDateHandle)))));
		}
		[Export("setMinDate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMinDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMinDate_Handle, value.Handle);
			}
			__mt_MinDate_var = value;
		}
	}

	public virtual NSDate MaxDate
	{
		[Export("maxDate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDate)(__mt_MaxDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaxDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMaxDateHandle)))));
		}
		[Export("setMaxDate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMaxDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMaxDate_Handle, value.Handle);
			}
			__mt_MaxDate_var = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSDatePickerCellDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSDatePickerCellDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public event EventHandler<NSDatePickerValidatorEventArgs> ValidateProposedDateValue
	{
		add
		{
			_NSDatePickerCellDelegate nSDatePickerCellDelegate = EnsureNSDatePickerCellDelegate();
			nSDatePickerCellDelegate.validateProposedDateValue = (EventHandler<NSDatePickerValidatorEventArgs>)System.Delegate.Combine(nSDatePickerCellDelegate.validateProposedDateValue, value);
		}
		remove
		{
			_NSDatePickerCellDelegate nSDatePickerCellDelegate = EnsureNSDatePickerCellDelegate();
			nSDatePickerCellDelegate.validateProposedDateValue = (EventHandler<NSDatePickerValidatorEventArgs>)System.Delegate.Remove(nSDatePickerCellDelegate.validateProposedDateValue, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDatePickerCell()
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
	public NSDatePickerCell(NSCoder coder)
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
	public NSDatePickerCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDatePickerCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSDatePickerCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	public NSDatePickerCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
		}
	}

	private _NSDatePickerCellDelegate EnsureNSDatePickerCellDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSDatePickerCellDelegate))
		{
			nSObject = (WeakDelegate = new _NSDatePickerCellDelegate());
		}
		return (_NSDatePickerCellDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BackgroundColor_var = null;
			__mt_TextColor_var = null;
			__mt_Calendar_var = null;
			__mt_Locale_var = null;
			__mt_TimeZone_var = null;
			__mt_DateValue_var = null;
			__mt_MinDate_var = null;
			__mt_MaxDate_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
