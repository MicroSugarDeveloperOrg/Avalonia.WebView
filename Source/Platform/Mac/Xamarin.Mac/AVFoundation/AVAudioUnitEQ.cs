using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitEQ", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioUnitEQ : AVAudioUnitEffect
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBands = "bands";

	private static readonly IntPtr selBandsHandle = Selector.GetHandle("bands");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlobalGain = "globalGain";

	private static readonly IntPtr selGlobalGainHandle = Selector.GetHandle("globalGain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNumberOfBands_ = "initWithNumberOfBands:";

	private static readonly IntPtr selInitWithNumberOfBands_Handle = Selector.GetHandle("initWithNumberOfBands:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGlobalGain_ = "setGlobalGain:";

	private static readonly IntPtr selSetGlobalGain_Handle = Selector.GetHandle("setGlobalGain:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitEQ");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioUnitEQFilterParameters[] Bands
	{
		[Export("bands")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAudioUnitEQFilterParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selBandsHandle));
			}
			return NSArray.ArrayFromHandle<AVAudioUnitEQFilterParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBandsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GlobalGain
	{
		[Export("globalGain")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGlobalGainHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGlobalGainHandle);
		}
		[Export("setGlobalGain:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetGlobalGain_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetGlobalGain_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioUnitEQ()
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
	protected AVAudioUnitEQ(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitEQ(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNumberOfBands:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioUnitEQ(nuint numberOfBands)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithNumberOfBands_Handle, numberOfBands), "initWithNumberOfBands:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithNumberOfBands_Handle, numberOfBands), "initWithNumberOfBands:");
		}
	}
}
