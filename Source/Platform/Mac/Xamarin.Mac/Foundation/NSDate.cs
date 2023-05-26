using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDate", true)]
public class NSDate : NSObject
{
	private const long NSDATE_TICKS = 631139040000000000L;

	private static readonly IntPtr selTimeIntervalSinceReferenceDateHandle = Selector.GetHandle("timeIntervalSinceReferenceDate");

	private static readonly IntPtr selDateHandle = Selector.GetHandle("date");

	private static readonly IntPtr selDistantPastHandle = Selector.GetHandle("distantPast");

	private static readonly IntPtr selDistantFutureHandle = Selector.GetHandle("distantFuture");

	private static readonly IntPtr selDateWithTimeIntervalSinceReferenceDate_Handle = Selector.GetHandle("dateWithTimeIntervalSinceReferenceDate:");

	private static readonly IntPtr selDateWithTimeIntervalSince1970_Handle = Selector.GetHandle("dateWithTimeIntervalSince1970:");

	private static readonly IntPtr selDateByAddingTimeInterval_Handle = Selector.GetHandle("dateByAddingTimeInterval:");

	private static readonly IntPtr selDateWithTimeIntervalSinceNow_Handle = Selector.GetHandle("dateWithTimeIntervalSinceNow:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDate");

	private static object __mt_Now_var_static;

	private static object __mt_DistantPast_var_static;

	private static object __mt_DistantFuture_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public virtual double SecondsSinceReferenceDate
	{
		[Export("timeIntervalSinceReferenceDate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalSinceReferenceDateHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalSinceReferenceDateHandle);
		}
	}

	public static NSDate Now
	{
		[Export("date")]
		get
		{
			return (NSDate)(__mt_Now_var_static = (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDateHandle)));
		}
	}

	public static NSDate DistantPast
	{
		[Export("distantPast")]
		get
		{
			return (NSDate)(__mt_DistantPast_var_static = (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDistantPastHandle)));
		}
	}

	public static NSDate DistantFuture
	{
		[Export("distantFuture")]
		get
		{
			return (NSDate)(__mt_DistantFuture_var_static = (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDistantFutureHandle)));
		}
	}

	public static implicit operator DateTime(NSDate d)
	{
		double secondsSinceReferenceDate = d.SecondsSinceReferenceDate;
		if (secondsSinceReferenceDate < -63113904000.0)
		{
			return DateTime.MinValue;
		}
		if (secondsSinceReferenceDate > 252423993599.0)
		{
			return DateTime.MaxValue;
		}
		return new DateTime((long)(secondsSinceReferenceDate * 10000000.0 + 6.3113904E+17), DateTimeKind.Utc);
	}

	public static implicit operator NSDate(DateTime dt)
	{
		return FromTimeIntervalSinceReferenceDate((dt.ToUniversalTime().Ticks - 631139040000000000L) / 10000000);
	}

	public override string ToString()
	{
		return Description;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDate()
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
	public NSDate(NSCoder coder)
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
	public NSDate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dateWithTimeIntervalSinceReferenceDate:")]
	public static NSDate FromTimeIntervalSinceReferenceDate(double secs)
	{
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDateWithTimeIntervalSinceReferenceDate_Handle, secs));
	}

	[Export("dateWithTimeIntervalSince1970:")]
	public static NSDate FromTimeIntervalSince1970(double secs)
	{
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDateWithTimeIntervalSince1970_Handle, secs));
	}

	[Export("dateByAddingTimeInterval:")]
	public virtual NSDate AddSeconds(double seconds)
	{
		if (IsDirectBinding)
		{
			return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selDateByAddingTimeInterval_Handle, seconds));
		}
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selDateByAddingTimeInterval_Handle, seconds));
	}

	[Export("dateWithTimeIntervalSinceNow:")]
	public static NSDate FromTimeIntervalSinceNow(double secs)
	{
		return (NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDateWithTimeIntervalSinceNow_Handle, secs));
	}
}
