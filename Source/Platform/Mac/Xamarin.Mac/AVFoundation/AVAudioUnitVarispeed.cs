using System;
using System.ComponentModel;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitVarispeed", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class AVAudioUnitVarispeed : AVAudioUnitTimeEffect
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioComponentDescription_ = "initWithAudioComponentDescription:";

	private static readonly IntPtr selInitWithAudioComponentDescription_Handle = Selector.GetHandle("initWithAudioComponentDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitVarispeed");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioUnitVarispeed()
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
	protected AVAudioUnitVarispeed(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitVarispeed(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAudioComponentDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioUnitVarispeed(AudioComponentDescription audioComponentDescription)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_AudioComponentDescription(base.Handle, selInitWithAudioComponentDescription_Handle, audioComponentDescription), "initWithAudioComponentDescription:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_AudioComponentDescription(base.SuperHandle, selInitWithAudioComponentDescription_Handle, audioComponentDescription), "initWithAudioComponentDescription:");
		}
	}
}
