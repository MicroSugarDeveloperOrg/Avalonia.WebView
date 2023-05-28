using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitDelay", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class AVAudioUnitDelay : AVAudioUnitEffect
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelayTime = "delayTime";

	private static readonly IntPtr selDelayTimeHandle = Selector.GetHandle("delayTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeedback = "feedback";

	private static readonly IntPtr selFeedbackHandle = Selector.GetHandle("feedback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLowPassCutoff = "lowPassCutoff";

	private static readonly IntPtr selLowPassCutoffHandle = Selector.GetHandle("lowPassCutoff");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelayTime_ = "setDelayTime:";

	private static readonly IntPtr selSetDelayTime_Handle = Selector.GetHandle("setDelayTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFeedback_ = "setFeedback:";

	private static readonly IntPtr selSetFeedback_Handle = Selector.GetHandle("setFeedback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLowPassCutoff_ = "setLowPassCutoff:";

	private static readonly IntPtr selSetLowPassCutoff_Handle = Selector.GetHandle("setLowPassCutoff:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWetDryMix_ = "setWetDryMix:";

	private static readonly IntPtr selSetWetDryMix_Handle = Selector.GetHandle("setWetDryMix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWetDryMix = "wetDryMix";

	private static readonly IntPtr selWetDryMixHandle = Selector.GetHandle("wetDryMix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitDelay");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DelayTime
	{
		[Export("delayTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDelayTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDelayTimeHandle);
		}
		[Export("setDelayTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDelayTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDelayTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Feedback
	{
		[Export("feedback")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFeedbackHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFeedbackHandle);
		}
		[Export("setFeedback:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFeedback_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFeedback_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LowPassCutoff
	{
		[Export("lowPassCutoff")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLowPassCutoffHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLowPassCutoffHandle);
		}
		[Export("setLowPassCutoff:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLowPassCutoff_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLowPassCutoff_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float WetDryMix
	{
		[Export("wetDryMix")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selWetDryMixHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selWetDryMixHandle);
		}
		[Export("setWetDryMix:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetWetDryMix_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetWetDryMix_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioUnitDelay()
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
	protected AVAudioUnitDelay(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitDelay(IntPtr handle)
		: base(handle)
	{
	}
}
