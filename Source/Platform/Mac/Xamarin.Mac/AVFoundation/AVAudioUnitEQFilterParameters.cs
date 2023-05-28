using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitEQFilterParameters", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioUnitEQFilterParameters : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBandwidth = "bandwidth";

	private static readonly IntPtr selBandwidthHandle = Selector.GetHandle("bandwidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBypass = "bypass";

	private static readonly IntPtr selBypassHandle = Selector.GetHandle("bypass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterType = "filterType";

	private static readonly IntPtr selFilterTypeHandle = Selector.GetHandle("filterType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrequency = "frequency";

	private static readonly IntPtr selFrequencyHandle = Selector.GetHandle("frequency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGain = "gain";

	private static readonly IntPtr selGainHandle = Selector.GetHandle("gain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBandwidth_ = "setBandwidth:";

	private static readonly IntPtr selSetBandwidth_Handle = Selector.GetHandle("setBandwidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBypass_ = "setBypass:";

	private static readonly IntPtr selSetBypass_Handle = Selector.GetHandle("setBypass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFilterType_ = "setFilterType:";

	private static readonly IntPtr selSetFilterType_Handle = Selector.GetHandle("setFilterType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrequency_ = "setFrequency:";

	private static readonly IntPtr selSetFrequency_Handle = Selector.GetHandle("setFrequency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGain_ = "setGain:";

	private static readonly IntPtr selSetGain_Handle = Selector.GetHandle("setGain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitEQFilterParameters");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Bandwidth
	{
		[Export("bandwidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBandwidthHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBandwidthHandle);
		}
		[Export("setBandwidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBandwidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBandwidth_Handle, value);
			}
		}
	}

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
	public virtual AVAudioUnitEQFilterType FilterType
	{
		[Export("filterType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAudioUnitEQFilterType)Messaging.Int64_objc_msgSend(base.Handle, selFilterTypeHandle);
			}
			return (AVAudioUnitEQFilterType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFilterTypeHandle);
		}
		[Export("setFilterType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFilterType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFilterType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Frequency
	{
		[Export("frequency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFrequencyHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFrequencyHandle);
		}
		[Export("setFrequency:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFrequency_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFrequency_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Gain
	{
		[Export("gain")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGainHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGainHandle);
		}
		[Export("setGain:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGain_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGain_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioUnitEQFilterParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitEQFilterParameters(IntPtr handle)
		: base(handle)
	{
	}
}
