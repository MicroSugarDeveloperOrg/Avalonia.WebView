using System;
using System.ComponentModel;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitEffect", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class AVAudioUnitEffect : AVAudioUnit
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBypass = "bypass";

	private static readonly IntPtr selBypassHandle = Selector.GetHandle("bypass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioComponentDescription_ = "initWithAudioComponentDescription:";

	private static readonly IntPtr selInitWithAudioComponentDescription_Handle = Selector.GetHandle("initWithAudioComponentDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBypass_ = "setBypass:";

	private static readonly IntPtr selSetBypass_Handle = Selector.GetHandle("setBypass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitEffect");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Bypass
	{
		[Export("bypass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBypassHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBypassHandle);
		}
		[Export("setBypass:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBypass_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBypass_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioUnitEffect(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitEffect(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAudioComponentDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioUnitEffect(AudioComponentDescription audioComponentDescription)
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
