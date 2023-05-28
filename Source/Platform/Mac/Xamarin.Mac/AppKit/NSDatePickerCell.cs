using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDatePickerCell", true)]
public class NSDatePickerCell : NSActionCell
{
	[Register]
	internal class _NSDatePickerCellDelegate : NSObject, INSDatePickerCellDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSDatePickerValidatorEventArgs>? validateProposedDateValue;

		public _NSDatePickerCellDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("datePickerCell:validateProposedDateValue:timeInterval:")]
		public void ValidateProposedDateValue(NSDatePickerCell aDatePickerCell, ref NSDate proposedDateValue, double proposedTimeInterval)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendar = "calendar";

	private static readonly IntPtr selCalendarHandle = Selector.GetHandle("calendar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDatePickerElements = "datePickerElements";

	private static readonly IntPtr selDatePickerElementsHandle = Selector.GetHandle("datePickerElements");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDatePickerMode = "datePickerMode";

	private static readonly IntPtr selDatePickerModeHandle = Selector.GetHandle("datePickerMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDatePickerStyle = "datePickerStyle";

	private static readonly IntPtr selDatePickerStyleHandle = Selector.GetHandle("datePickerStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateValue = "dateValue";

	private static readonly IntPtr selDateValueHandle = Selector.GetHandle("dateValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawsBackground = "drawsBackground";

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitImageCell_ = "initImageCell:";

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxDate = "maxDate";

	private static readonly IntPtr selMaxDateHandle = Selector.GetHandle("maxDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinDate = "minDate";

	private static readonly IntPtr selMinDateHandle = Selector.GetHandle("minDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendar_ = "setCalendar:";

	private static readonly IntPtr selSetCalendar_Handle = Selector.GetHandle("setCalendar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDatePickerElements_ = "setDatePickerElements:";

	private static readonly IntPtr selSetDatePickerElements_Handle = Selector.GetHandle("setDatePickerElements:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDatePickerMode_ = "setDatePickerMode:";

	private static readonly IntPtr selSetDatePickerMode_Handle = Selector.GetHandle("setDatePickerMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDatePickerStyle_ = "setDatePickerStyle:";

	private static readonly IntPtr selSetDatePickerStyle_Handle = Selector.GetHandle("setDatePickerStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDateValue_ = "setDateValue:";

	private static readonly IntPtr selSetDateValue_Handle = Selector.GetHandle("setDateValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawsBackground_ = "setDrawsBackground:";

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocale_ = "setLocale:";

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxDate_ = "setMaxDate:";

	private static readonly IntPtr selSetMaxDate_Handle = Selector.GetHandle("setMaxDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinDate_ = "setMinDate:";

	private static readonly IntPtr selSetMinDate_Handle = Selector.GetHandle("setMinDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextColor_ = "setTextColor:";

	private static readonly IntPtr selSetTextColor_Handle = Selector.GetHandle("setTextColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeInterval_ = "setTimeInterval:";

	private static readonly IntPtr selSetTimeInterval_Handle = Selector.GetHandle("setTimeInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeZone_ = "setTimeZone:";

	private static readonly IntPtr selSetTimeZone_Handle = Selector.GetHandle("setTimeZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextColor = "textColor";

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeInterval = "timeInterval";

	private static readonly IntPtr selTimeIntervalHandle = Selector.GetHandle("timeInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDatePickerCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCalendar Calendar
	{
		[Export("calendar", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCalendar>(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarHandle));
			}
			return Runtime.GetNSObject<NSCalendar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarHandle));
		}
		[Export("setCalendar:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
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
	public virtual NSDatePickerElementFlags DatePickerElements
	{
		[Export("datePickerElements")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSDatePickerElementFlags)Messaging.UInt64_objc_msgSend(base.Handle, selDatePickerElementsHandle);
			}
			return (NSDatePickerElementFlags)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDatePickerElementsHandle);
		}
		[Export("setDatePickerElements:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDatePickerElements_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDatePickerElements_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDatePickerMode DatePickerMode
	{
		[Export("datePickerMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSDatePickerMode)Messaging.UInt64_objc_msgSend(base.Handle, selDatePickerModeHandle);
			}
			return (NSDatePickerMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDatePickerModeHandle);
		}
		[Export("setDatePickerMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDatePickerMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDatePickerMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDatePickerStyle DatePickerStyle
	{
		[Export("datePickerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSDatePickerStyle)Messaging.UInt64_objc_msgSend(base.Handle, selDatePickerStyleHandle);
			}
			return (NSDatePickerStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDatePickerStyleHandle);
		}
		[Export("setDatePickerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDatePickerStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDatePickerStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate DateValue
	{
		[Export("dateValue", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateValueHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateValueHandle));
		}
		[Export("setDateValue:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDateValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDateValue_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSDatePickerCellDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSDatePickerCellDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale Locale
	{
		[Export("locale", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle));
			}
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle));
		}
		[Export("setLocale:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
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
	public virtual NSDate MaxDate
	{
		[Export("maxDate", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selMaxDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaxDateHandle));
		}
		[Export("setMaxDate:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMaxDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMaxDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate MinDate
	{
		[Export("minDate", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selMinDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMinDateHandle));
		}
		[Export("setMinDate:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMinDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMinDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor TextColor
	{
		[Export("textColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextColorHandle));
		}
		[Export("setTextColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeInterval
	{
		[Export("timeInterval")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalHandle);
		}
		[Export("setTimeInterval:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTimeZone TimeZone
	{
		[Export("timeZone", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeZoneHandle));
			}
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeZoneHandle));
		}
		[Export("setTimeZone:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
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
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSDatePickerCellDelegate);

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDatePickerCell()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSDatePickerCell(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSDatePickerCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDatePickerCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDatePickerCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDatePickerCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
	}

	internal virtual _NSDatePickerCellDelegate CreateInternalEventDelegateType()
	{
		return new _NSDatePickerCellDelegate();
	}

	internal _NSDatePickerCellDelegate EnsureNSDatePickerCellDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSDatePickerCellDelegate nSDatePickerCellDelegate = Delegate as _NSDatePickerCellDelegate;
		if (nSDatePickerCellDelegate == null)
		{
			nSDatePickerCellDelegate = (_NSDatePickerCellDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSDatePickerCellDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
