using AudioToolbox;
using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace AVFoundation;

[Register("AVAudioTime", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioTime : NSObject
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAudioTimeStamp = "audioTimeStamp";

    private static readonly IntPtr selAudioTimeStampHandle = Selector.GetHandle("audioTimeStamp");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selExtrapolateTimeFromAnchor_ = "extrapolateTimeFromAnchor:";

    private static readonly IntPtr selExtrapolateTimeFromAnchor_Handle = Selector.GetHandle("extrapolateTimeFromAnchor:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHostTime = "hostTime";

    private static readonly IntPtr selHostTimeHandle = Selector.GetHandle("hostTime");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHostTimeForSeconds_ = "hostTimeForSeconds:";

    private static readonly IntPtr selHostTimeForSeconds_Handle = Selector.GetHandle("hostTimeForSeconds:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithAudioTimeStamp_SampleRate_ = "initWithAudioTimeStamp:sampleRate:";

    private static readonly IntPtr selInitWithAudioTimeStamp_SampleRate_Handle = Selector.GetHandle("initWithAudioTimeStamp:sampleRate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithHostTime_ = "initWithHostTime:";

    private static readonly IntPtr selInitWithHostTime_Handle = Selector.GetHandle("initWithHostTime:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithHostTime_SampleTime_AtRate_ = "initWithHostTime:sampleTime:atRate:";

    private static readonly IntPtr selInitWithHostTime_SampleTime_AtRate_Handle = Selector.GetHandle("initWithHostTime:sampleTime:atRate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithSampleTime_AtRate_ = "initWithSampleTime:atRate:";

    private static readonly IntPtr selInitWithSampleTime_AtRate_Handle = Selector.GetHandle("initWithSampleTime:atRate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsHostTimeValid = "isHostTimeValid";

    private static readonly IntPtr selIsHostTimeValidHandle = Selector.GetHandle("isHostTimeValid");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsSampleTimeValid = "isSampleTimeValid";

    private static readonly IntPtr selIsSampleTimeValidHandle = Selector.GetHandle("isSampleTimeValid");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSampleRate = "sampleRate";

    private static readonly IntPtr selSampleRateHandle = Selector.GetHandle("sampleRate");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSampleTime = "sampleTime";

    private static readonly IntPtr selSampleTimeHandle = Selector.GetHandle("sampleTime");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSecondsForHostTime_ = "secondsForHostTime:";

    private static readonly IntPtr selSecondsForHostTime_Handle = Selector.GetHandle("secondsForHostTime:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeWithAudioTimeStamp_SampleRate_ = "timeWithAudioTimeStamp:sampleRate:";

    private static readonly IntPtr selTimeWithAudioTimeStamp_SampleRate_Handle = Selector.GetHandle("timeWithAudioTimeStamp:sampleRate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeWithHostTime_ = "timeWithHostTime:";

    private static readonly IntPtr selTimeWithHostTime_Handle = Selector.GetHandle("timeWithHostTime:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeWithHostTime_SampleTime_AtRate_ = "timeWithHostTime:sampleTime:atRate:";

    private static readonly IntPtr selTimeWithHostTime_SampleTime_AtRate_Handle = Selector.GetHandle("timeWithHostTime:sampleTime:atRate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimeWithSampleTime_AtRate_ = "timeWithSampleTime:atRate:";

    private static readonly IntPtr selTimeWithSampleTime_AtRate_Handle = Selector.GetHandle("timeWithSampleTime:atRate:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioTime");

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual AudioTimeStamp AudioTimeStamp
    {
        [Export("audioTimeStamp")]
        get
        {
            AudioTimeStamp retval;
            if (base.IsDirectBinding)
            {
                Messaging.AudioTimeStamp_objc_msgSend_stret(out retval, base.Handle, selAudioTimeStampHandle);
            }
            else
            {
                Messaging.AudioTimeStamp_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAudioTimeStampHandle);
            }
            return retval;
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual ulong HostTime
    {
        [Export("hostTime")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.UInt64_objc_msgSend(base.Handle, selHostTimeHandle);
            }
            return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHostTimeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool HostTimeValid
    {
        [Export("isHostTimeValid")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsHostTimeValidHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHostTimeValidHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual double SampleRate
    {
        [Export("sampleRate")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.Double_objc_msgSend(base.Handle, selSampleRateHandle);
            }
            return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSampleRateHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual long SampleTime
    {
        [Export("sampleTime")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.Int64_objc_msgSend(base.Handle, selSampleTimeHandle);
            }
            return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSampleTimeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool SampleTimeValid
    {
        [Export("isSampleTimeValid")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsSampleTimeValidHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSampleTimeValidHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public AVAudioTime()
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
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected AVAudioTime(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal AVAudioTime(IntPtr handle)
        : base(handle)
    {
    }

    [Export("initWithAudioTimeStamp:sampleRate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public AVAudioTime(ref AudioTimeStamp timestamp, double sampleRate)
        : base(NSObjectFlag.Empty)
    {
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_ref_AudioTimeStamp_Double(base.Handle, selInitWithAudioTimeStamp_SampleRate_Handle, ref timestamp, sampleRate), "initWithAudioTimeStamp:sampleRate:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_ref_AudioTimeStamp_Double(base.SuperHandle, selInitWithAudioTimeStamp_SampleRate_Handle, ref timestamp, sampleRate), "initWithAudioTimeStamp:sampleRate:");
        }
    }

    [Export("initWithHostTime:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public AVAudioTime(ulong hostTime)
        : base(NSObjectFlag.Empty)
    {
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithHostTime_Handle, hostTime), "initWithHostTime:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithHostTime_Handle, hostTime), "initWithHostTime:");
        }
    }

    [Export("initWithSampleTime:atRate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public AVAudioTime(long sampleTime, double sampleRate)
        : base(NSObjectFlag.Empty)
    {
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_Double(base.Handle, selInitWithSampleTime_AtRate_Handle, sampleTime, sampleRate), "initWithSampleTime:atRate:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_Double(base.SuperHandle, selInitWithSampleTime_AtRate_Handle, sampleTime, sampleRate), "initWithSampleTime:atRate:");
        }
    }

    [Export("initWithHostTime:sampleTime:atRate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public AVAudioTime(ulong hostTime, long sampleTime, double sampleRate)
        : base(NSObjectFlag.Empty)
    {
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_Int64_Double(base.Handle, selInitWithHostTime_SampleTime_AtRate_Handle, hostTime, sampleTime, sampleRate), "initWithHostTime:sampleTime:atRate:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_Int64_Double(base.SuperHandle, selInitWithHostTime_SampleTime_AtRate_Handle, hostTime, sampleTime, sampleRate), "initWithHostTime:sampleTime:atRate:");
        }
    }

    [Export("extrapolateTimeFromAnchor:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual AVAudioTime? ExtrapolateTimeFromAnchor(AVAudioTime anchorTime)
    {
        if (anchorTime == null)
        {
            throw new ArgumentNullException("anchorTime");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selExtrapolateTimeFromAnchor_Handle, anchorTime.Handle));
        }
        return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selExtrapolateTimeFromAnchor_Handle, anchorTime.Handle));
    }

    [Export("timeWithAudioTimeStamp:sampleRate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static AVAudioTime FromAudioTimeStamp(ref AudioTimeStamp timestamp, double sampleRate)
    {
        return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend_ref_AudioTimeStamp_Double(class_ptr, selTimeWithAudioTimeStamp_SampleRate_Handle, ref timestamp, sampleRate));
    }

    [Export("timeWithHostTime:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static AVAudioTime FromHostTime(ulong hostTime)
    {
        return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selTimeWithHostTime_Handle, hostTime));
    }

    [Export("timeWithHostTime:sampleTime:atRate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static AVAudioTime FromHostTime(ulong hostTime, long sampleTime, double sampleRate)
    {
        return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend_UInt64_Int64_Double(class_ptr, selTimeWithHostTime_SampleTime_AtRate_Handle, hostTime, sampleTime, sampleRate));
    }

    [Export("timeWithSampleTime:atRate:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static AVAudioTime FromSampleTime(long sampleTime, double sampleRate)
    {
        return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend_Int64_Double(class_ptr, selTimeWithSampleTime_AtRate_Handle, sampleTime, sampleRate));
    }

    [Export("hostTimeForSeconds:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static ulong HostTimeForSeconds(double seconds)
    {
        return Messaging.UInt64_objc_msgSend_Double(class_ptr, selHostTimeForSeconds_Handle, seconds);
    }

    [Export("secondsForHostTime:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static double SecondsForHostTime(ulong hostTime)
    {
        return Messaging.Double_objc_msgSend_UInt64(class_ptr, selSecondsForHostTime_Handle, hostTime);
    }
}