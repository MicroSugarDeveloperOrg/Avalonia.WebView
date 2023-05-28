using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioEnvironmentReverbParameters", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioEnvironmentReverbParameters : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnable = "enable";

	private static readonly IntPtr selEnableHandle = Selector.GetHandle("enable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterParameters = "filterParameters";

	private static readonly IntPtr selFilterParametersHandle = Selector.GetHandle("filterParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevel = "level";

	private static readonly IntPtr selLevelHandle = Selector.GetHandle("level");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFactoryReverbPreset_ = "loadFactoryReverbPreset:";

	private static readonly IntPtr selLoadFactoryReverbPreset_Handle = Selector.GetHandle("loadFactoryReverbPreset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnable_ = "setEnable:";

	private static readonly IntPtr selSetEnable_Handle = Selector.GetHandle("setEnable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLevel_ = "setLevel:";

	private static readonly IntPtr selSetLevel_Handle = Selector.GetHandle("setLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioEnvironmentReverbParameters");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enable
	{
		[Export("enable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableHandle);
		}
		[Export("setEnable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioUnitEQFilterParameters FilterParameters
	{
		[Export("filterParameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioUnitEQFilterParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterParametersHandle));
			}
			return Runtime.GetNSObject<AVAudioUnitEQFilterParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterParametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Level
	{
		[Export("level")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLevelHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLevelHandle);
		}
		[Export("setLevel:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioEnvironmentReverbParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioEnvironmentReverbParameters(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadFactoryReverbPreset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadFactoryReverbPreset(AVAudioUnitReverbPreset preset)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selLoadFactoryReverbPreset_Handle, (long)preset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selLoadFactoryReverbPreset_Handle, (long)preset);
		}
	}
}
