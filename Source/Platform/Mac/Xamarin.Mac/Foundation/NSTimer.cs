using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSTimer", true)]
public class NSTimer : NSObject
{
	private static readonly IntPtr selFireDateHandle = Selector.GetHandle("fireDate");

	private static readonly IntPtr selSetFireDate_Handle = Selector.GetHandle("setFireDate:");

	private static readonly IntPtr selIsValidHandle = Selector.GetHandle("isValid");

	private static readonly IntPtr selTimeIntervalHandle = Selector.GetHandle("timeInterval");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selScheduledTimerWithTimeIntervalTargetSelectorUserInfoRepeats_Handle = Selector.GetHandle("scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:");

	private static readonly IntPtr selTimerWithTimeIntervalTargetSelectorUserInfoRepeats_Handle = Selector.GetHandle("timerWithTimeInterval:target:selector:userInfo:repeats:");

	private static readonly IntPtr selInitWithFireDateIntervalTargetSelectorUserInfoRepeats_Handle = Selector.GetHandle("initWithFireDate:interval:target:selector:userInfo:repeats:");

	private static readonly IntPtr selFireHandle = Selector.GetHandle("fire");

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTimer");

	private object __mt_FireDate_var;

	private object __mt_UserInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDate FireDate
	{
		[Export("fireDate")]
		get
		{
			return (NSDate)(__mt_FireDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFireDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFireDateHandle)))));
		}
		[Export("setFireDate:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFireDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFireDate_Handle, value.Handle);
			}
			__mt_FireDate_var = value;
		}
	}

	public virtual bool IsValid
	{
		[Export("isValid")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidHandle);
		}
	}

	public virtual double TimeInterval
	{
		[Export("timeInterval")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalHandle);
		}
	}

	public virtual NSObject UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSObject)(__mt_UserInfo_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle))));
		}
	}

	public static NSTimer CreateRepeatingScheduledTimer(TimeSpan when, NSAction action)
	{
		return CreateScheduledTimer(when.TotalSeconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateRepeatingScheduledTimer(double seconds, NSAction action)
	{
		return CreateScheduledTimer(seconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateScheduledTimer(TimeSpan when, NSAction action)
	{
		return CreateScheduledTimer(when.TotalSeconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: false);
	}

	public static NSTimer CreateScheduledTimer(double seconds, NSAction action)
	{
		return CreateScheduledTimer(seconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: false);
	}

	public static NSTimer CreateRepeatingTimer(TimeSpan when, NSAction action)
	{
		return CreateTimer(when.TotalSeconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateRepeatingTimer(double seconds, NSAction action)
	{
		return CreateTimer(seconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: true);
	}

	public static NSTimer CreateTimer(TimeSpan when, NSAction action)
	{
		return CreateTimer(when.TotalSeconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: false);
	}

	public static NSTimer CreateTimer(double seconds, NSAction action)
	{
		return CreateTimer(seconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats: false);
	}

	public NSTimer(NSDate date, TimeSpan when, NSAction action, bool repeats)
		: this(date, when.TotalSeconds, new NSActionDispatcher(action), NSActionDispatcher.Selector, null, repeats)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTimer(NSCoder coder)
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
	public NSTimer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTimer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:")]
	public static NSTimer CreateScheduledTimer(double seconds, NSObject target, Selector selector, NSObject userInfo, bool repeats)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return (NSTimer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool(class_ptr, selScheduledTimerWithTimeIntervalTargetSelectorUserInfoRepeats_Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats));
	}

	[Export("timerWithTimeInterval:target:selector:userInfo:repeats:")]
	public static NSTimer CreateTimer(double seconds, NSObject target, Selector selector, NSObject userInfo, bool repeats)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return (NSTimer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool(class_ptr, selTimerWithTimeIntervalTargetSelectorUserInfoRepeats_Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats));
	}

	[Export("initWithFireDate:interval:target:selector:userInfo:repeats:")]
	public NSTimer(NSDate date, double seconds, NSObject target, Selector selector, NSObject userInfo, bool repeats)
		: base(NSObjectFlag.Empty)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithFireDateIntervalTargetSelectorUserInfoRepeats_Handle, date.Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithFireDateIntervalTargetSelectorUserInfoRepeats_Handle, date.Handle, seconds, target.Handle, selector.Handle, userInfo?.Handle ?? IntPtr.Zero, repeats);
		}
	}

	[Export("fire")]
	public virtual void Fire()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFireHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFireHandle);
		}
	}

	[Export("invalidate")]
	public virtual void Invalidate()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Invalidate();
		}
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FireDate_var = null;
			__mt_UserInfo_var = null;
		}
	}
}
