using System;
using System.ComponentModel;
using CloudKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSDate", true)]
public class NSDate : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding, ICKRecordValue
{
    private const long NSDATE_TICKS = 631139040000000000L;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCompare_ = "compare:";

    private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCopyWithZone_ = "copyWithZone:";

    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDate = "date";

    private static readonly IntPtr selDateHandle = Selector.GetHandle("date");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDateByAddingTimeInterval_ = "dateByAddingTimeInterval:";

    private static readonly IntPtr selDateByAddingTimeInterval_Handle = Selector.GetHandle("dateByAddingTimeInterval:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDateWithTimeIntervalSince1970_ = "dateWithTimeIntervalSince1970:";

    private static readonly IntPtr selDateWithTimeIntervalSince1970_Handle = Selector.GetHandle("dateWithTimeIntervalSince1970:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDateWithTimeIntervalSinceNow_ = "dateWithTimeIntervalSinceNow:";

    private static readonly IntPtr selDateWithTimeIntervalSinceNow_Handle = Selector.GetHandle("dateWithTimeIntervalSinceNow:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDateWithTimeIntervalSinceReferenceDate_ = "dateWithTimeIntervalSinceReferenceDate:";

    private static readonly IntPtr selDateWithTimeIntervalSinceReferenceDate_Handle = Selector.GetHandle("dateWithTimeIntervalSinceReferenceDate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDescriptionWithLocale_ = "descriptionWithLocale:";

    private static readonly IntPtr selDescriptionWithLocale_Handle = Selector.GetHandle("descriptionWithLocale:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDistantFuture = "distantFuture";

    private static readonly IntPtr selDistantFutureHandle = Selector.GetHandle("distantFuture");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDistantPast = "distantPast";

    private static readonly IntPtr selDistantPastHandle = Selector.GetHandle("distantPast");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEarlierDate_ = "earlierDate:";

    private static readonly IntPtr selEarlierDate_Handle = Selector.GetHandle("earlierDate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEncodeWithCoder_ = "encodeWithCoder:";

    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithCoder_ = "initWithCoder:";

    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsEqualToDate_ = "isEqualToDate:";

    private static readonly IntPtr selIsEqualToDate_Handle = Selector.GetHandle("isEqualToDate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLaterDate_ = "laterDate:";

    private static readonly IntPtr selLaterDate_Handle = Selector.GetHandle("laterDate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeIntervalSince1970 = "timeIntervalSince1970";

    private static readonly IntPtr selTimeIntervalSince1970Handle = Selector.GetHandle("timeIntervalSince1970");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeIntervalSinceDate_ = "timeIntervalSinceDate:";

    private static readonly IntPtr selTimeIntervalSinceDate_Handle = Selector.GetHandle("timeIntervalSinceDate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeIntervalSinceNow = "timeIntervalSinceNow";

    private static readonly IntPtr selTimeIntervalSinceNowHandle = Selector.GetHandle("timeIntervalSinceNow");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeIntervalSinceReferenceDate = "timeIntervalSinceReferenceDate";

    private static readonly IntPtr selTimeIntervalSinceReferenceDateHandle = Selector.GetHandle("timeIntervalSinceReferenceDate");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDate");

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDate DistantFuture
    {
        [Export("distantFuture")]
        get
        {
            return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(class_ptr, selDistantFutureHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDate DistantPast
    {
        [Export("distantPast")]
        get
        {
            return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(class_ptr, selDistantPastHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDate Now
    {
        [Export("date")]
        get
        {
            return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(class_ptr, selDateHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual double SecondsSince1970
    {
        [Export("timeIntervalSince1970")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalSince1970Handle);
            }
            return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalSince1970Handle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual double SecondsSinceNow
    {
        [Export("timeIntervalSinceNow")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalSinceNowHandle);
            }
            return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalSinceNowHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual double SecondsSinceReferenceDate
    {
        [Export("timeIntervalSinceReferenceDate")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.Double_objc_msgSend(base.Handle, selTimeIntervalSinceReferenceDateHandle);
            }
            return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeIntervalSinceReferenceDateHandle);
        }
    }

    public static explicit operator DateTime(NSDate d)
    {
        double secondsSinceReferenceDate = d.SecondsSinceReferenceDate;
        if (secondsSinceReferenceDate < -63113904000.0 || secondsSinceReferenceDate > 252423993599.0)
        {
            throw new ArgumentOutOfRangeException("Value is outside the range of NSDate");
        }
        return new DateTime((long)(secondsSinceReferenceDate * 10000000.0 + 6.3113904E+17), DateTimeKind.Utc);
    }

    public static explicit operator NSDate(DateTime dt)
    {
        if (dt.Kind == DateTimeKind.Unspecified)
        {
            throw new ArgumentException("DateTimeKind.Unspecified cannot be safely converted");
        }
        return FromTimeIntervalSinceReferenceDate((double)(dt.ToUniversalTime().Ticks - 631139040000000000L) / 10000000.0);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DesignatedInitializer]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSDate()
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
    public NSDate(NSCoder coder)
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
    protected NSDate(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSDate(IntPtr handle)
        : base(handle)
    {
    }

    [Export("dateByAddingTimeInterval:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSDate AddSeconds(double seconds)
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selDateByAddingTimeInterval_Handle, seconds));
        }
        return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selDateByAddingTimeInterval_Handle, seconds));
    }

    [Export("compare:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSComparisonResult Compare(NSDate other)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, other.Handle);
        }
        return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, other.Handle);
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

    [Export("descriptionWithLocale:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string DescriptionWithLocale(NSLocale locale)
    {
        if (locale == null)
        {
            throw new ArgumentNullException("locale");
        }
        if (base.IsDirectBinding)
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescriptionWithLocale_Handle, locale.Handle));
        }
        return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescriptionWithLocale_Handle, locale.Handle));
    }

    [Export("earlierDate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSDate EarlierDate(NSDate anotherDate)
    {
        if (anotherDate == null)
        {
            throw new ArgumentNullException("anotherDate");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEarlierDate_Handle, anotherDate.Handle));
        }
        return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEarlierDate_Handle, anotherDate.Handle));
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

    [Export("dateWithTimeIntervalSince1970:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDate FromTimeIntervalSince1970(double secs)
    {
        return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDateWithTimeIntervalSince1970_Handle, secs));
    }

    [Export("dateWithTimeIntervalSinceNow:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDate FromTimeIntervalSinceNow(double secs)
    {
        return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDateWithTimeIntervalSinceNow_Handle, secs));
    }

    [Export("dateWithTimeIntervalSinceReferenceDate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSDate FromTimeIntervalSinceReferenceDate(double secs)
    {
        return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDateWithTimeIntervalSinceReferenceDate_Handle, secs));
    }

    [Export("timeIntervalSinceDate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual double GetSecondsSince(NSDate anotherDate)
    {
        if (anotherDate == null)
        {
            throw new ArgumentNullException("anotherDate");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selTimeIntervalSinceDate_Handle, anotherDate.Handle);
        }
        return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selTimeIntervalSinceDate_Handle, anotherDate.Handle);
    }

    [Export("isEqualToDate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool IsEqualToDate(NSDate other)
    {
        if (other == null)
        {
            throw new ArgumentNullException("other");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToDate_Handle, other.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToDate_Handle, other.Handle);
    }

    [Export("laterDate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSDate LaterDate(NSDate anotherDate)
    {
        if (anotherDate == null)
        {
            throw new ArgumentNullException("anotherDate");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLaterDate_Handle, anotherDate.Handle));
        }
        return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLaterDate_Handle, anotherDate.Handle));
    }
}
