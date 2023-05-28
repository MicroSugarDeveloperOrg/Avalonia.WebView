using System;
using System.ComponentModel;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioIONode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioIONode : AVAudioNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioUnit = "audioUnit";

	private static readonly IntPtr selAudioUnitHandle = Selector.GetHandle("audioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVoiceProcessingEnabled = "isVoiceProcessingEnabled";

	private static readonly IntPtr selIsVoiceProcessingEnabledHandle = Selector.GetHandle("isVoiceProcessingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationLatency = "presentationLatency";

	private static readonly IntPtr selPresentationLatencyHandle = Selector.GetHandle("presentationLatency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoiceProcessingEnabled_Error_ = "setVoiceProcessingEnabled:error:";

	private static readonly IntPtr selSetVoiceProcessingEnabled_Error_Handle = Selector.GetHandle("setVoiceProcessingEnabled:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioIONode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual global::AudioUnit.AudioUnit? AudioUnit
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("audioUnit")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioUnitHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAudioUnitHandle));
			return (intPtr == IntPtr.Zero) ? null : new global::AudioUnit.AudioUnit(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double PresentationLatency
	{
		[Export("presentationLatency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPresentationLatencyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPresentationLatencyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool VoiceProcessingEnabled
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isVoiceProcessingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVoiceProcessingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVoiceProcessingEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioIONode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioIONode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setVoiceProcessingEnabled:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetVoiceProcessingEnabled(bool enabled, out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_bool_ref_IntPtr(base.SuperHandle, selSetVoiceProcessingEnabled_Error_Handle, enabled, ref arg) : Messaging.bool_objc_msgSend_bool_ref_IntPtr(base.Handle, selSetVoiceProcessingEnabled_Error_Handle, enabled, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
