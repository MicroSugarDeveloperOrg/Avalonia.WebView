using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitDistortion", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class AVAudioUnitDistortion : AVAudioUnitEffect
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFactoryPreset_ = "loadFactoryPreset:";

	private static readonly IntPtr selLoadFactoryPreset_Handle = Selector.GetHandle("loadFactoryPreset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreGain = "preGain";

	private static readonly IntPtr selPreGainHandle = Selector.GetHandle("preGain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreGain_ = "setPreGain:";

	private static readonly IntPtr selSetPreGain_Handle = Selector.GetHandle("setPreGain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWetDryMix_ = "setWetDryMix:";

	private static readonly IntPtr selSetWetDryMix_Handle = Selector.GetHandle("setWetDryMix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWetDryMix = "wetDryMix";

	private static readonly IntPtr selWetDryMixHandle = Selector.GetHandle("wetDryMix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitDistortion");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PreGain
	{
		[Export("preGain")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreGainHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreGainHandle);
		}
		[Export("setPreGain:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPreGain_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPreGain_Handle, value);
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
	public AVAudioUnitDistortion()
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
	protected AVAudioUnitDistortion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitDistortion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadFactoryPreset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadFactoryPreset(AVAudioUnitDistortionPreset preset)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selLoadFactoryPreset_Handle, (long)preset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selLoadFactoryPreset_Handle, (long)preset);
		}
	}
}
