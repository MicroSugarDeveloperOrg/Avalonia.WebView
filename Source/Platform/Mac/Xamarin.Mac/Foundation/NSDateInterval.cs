using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDateInterval", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSDateInterval : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompare_ = "compare:";

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsDate_ = "containsDate:";

	private static readonly IntPtr selContainsDate_Handle = Selector.GetHandle("containsDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDate = "endDate";

	private static readonly IntPtr selEndDateHandle = Selector.GetHandle("endDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStartDate_Duration_ = "initWithStartDate:duration:";

	private static readonly IntPtr selInitWithStartDate_Duration_Handle = Selector.GetHandle("initWithStartDate:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStartDate_EndDate_ = "initWithStartDate:endDate:";

	private static readonly IntPtr selInitWithStartDate_EndDate_Handle = Selector.GetHandle("initWithStartDate:endDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectionWithDateInterval_ = "intersectionWithDateInterval:";

	private static readonly IntPtr selIntersectionWithDateInterval_Handle = Selector.GetHandle("intersectionWithDateInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsDateInterval_ = "intersectsDateInterval:";

	private static readonly IntPtr selIntersectsDateInterval_Handle = Selector.GetHandle("intersectsDateInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToDateInterval_ = "isEqualToDateInterval:";

	private static readonly IntPtr selIsEqualToDateInterval_Handle = Selector.GetHandle("isEqualToDateInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDate = "startDate";

	private static readonly IntPtr selStartDateHandle = Selector.GetHandle("startDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDateInterval");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDateInterval()
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
	public NSDateInterval(NSCoder coder)
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
	protected NSDateInterval(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDateInterval(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithStartDate:duration:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDateInterval(NSDate startDate, double duration)
		: base(NSObjectFlag.Empty)
	{
		if (startDate == null)
		{
			throw new ArgumentNullException("startDate");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double(base.Handle, selInitWithStartDate_Duration_Handle, startDate.Handle, duration), "initWithStartDate:duration:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selInitWithStartDate_Duration_Handle, startDate.Handle, duration), "initWithStartDate:duration:");
		}
	}

	[Export("initWithStartDate:endDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDateInterval(NSDate startDate, NSDate endDate)
		: base(NSObjectFlag.Empty)
	{
		if (startDate == null)
		{
			throw new ArgumentNullException("startDate");
		}
		if (endDate == null)
		{
			throw new ArgumentNullException("endDate");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStartDate_EndDate_Handle, startDate.Handle, endDate.Handle), "initWithStartDate:endDate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStartDate_EndDate_Handle, startDate.Handle, endDate.Handle), "initWithStartDate:endDate:");
		}
	}

	[Export("compare:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonResult Compare(NSDateInterval dateInterval)
	{
		if (dateInterval == null)
		{
			throw new ArgumentNullException("dateInterval");
		}
		if (base.IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, dateInterval.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, dateInterval.Handle);
	}

	[Export("containsDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsDate(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsDate_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsDate_Handle, date.Handle);
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("intersectionWithDateInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateInterval? GetIntersection(NSDateInterval dateInterval)
	{
		if (dateInterval == null)
		{
			throw new ArgumentNullException("dateInterval");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDateInterval>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIntersectionWithDateInterval_Handle, dateInterval.Handle));
		}
		return Runtime.GetNSObject<NSDateInterval>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectionWithDateInterval_Handle, dateInterval.Handle));
	}

	[Export("intersectsDateInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Intersects(NSDateInterval dateInterval)
	{
		if (dateInterval == null)
		{
			throw new ArgumentNullException("dateInterval");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsDateInterval_Handle, dateInterval.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsDateInterval_Handle, dateInterval.Handle);
	}

	[Export("isEqualToDateInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualTo(NSDateInterval dateInterval)
	{
		if (dateInterval == null)
		{
			throw new ArgumentNullException("dateInterval");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToDateInterval_Handle, dateInterval.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToDateInterval_Handle, dateInterval.Handle);
	}
}
