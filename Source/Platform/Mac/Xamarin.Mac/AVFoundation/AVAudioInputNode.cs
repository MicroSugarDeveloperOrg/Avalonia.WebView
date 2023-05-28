using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace AVFoundation;

[Register("AVAudioInputNode", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class AVAudioInputNode : AVAudioIONode, IAVAudio3DMixing, INativeObject, IDisposable, IAVAudioMixing, IAVAudioStereoMixing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationForMixer_Bus_ = "destinationForMixer:bus:";

	private static readonly IntPtr selDestinationForMixer_Bus_Handle = Selector.GetHandle("destinationForMixer:bus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVoiceProcessingAGCEnabled = "isVoiceProcessingAGCEnabled";

	private static readonly IntPtr selIsVoiceProcessingAGCEnabledHandle = Selector.GetHandle("isVoiceProcessingAGCEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVoiceProcessingBypassed = "isVoiceProcessingBypassed";

	private static readonly IntPtr selIsVoiceProcessingBypassedHandle = Selector.GetHandle("isVoiceProcessingBypassed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVoiceProcessingInputMuted = "isVoiceProcessingInputMuted";

	private static readonly IntPtr selIsVoiceProcessingInputMutedHandle = Selector.GetHandle("isVoiceProcessingInputMuted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstruction = "obstruction";

	private static readonly IntPtr selObstructionHandle = Selector.GetHandle("obstruction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOcclusion = "occlusion";

	private static readonly IntPtr selOcclusionHandle = Selector.GetHandle("occlusion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPan = "pan";

	private static readonly IntPtr selPanHandle = Selector.GetHandle("pan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointSourceInHeadMode = "pointSourceInHeadMode";

	private static readonly IntPtr selPointSourceInHeadModeHandle = Selector.GetHandle("pointSourceInHeadMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderingAlgorithm = "renderingAlgorithm";

	private static readonly IntPtr selRenderingAlgorithmHandle = Selector.GetHandle("renderingAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReverbBlend = "reverbBlend";

	private static readonly IntPtr selReverbBlendHandle = Selector.GetHandle("reverbBlend");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetManualRenderingInputPCMFormat_InputBlock_ = "setManualRenderingInputPCMFormat:inputBlock:";

	private static readonly IntPtr selSetManualRenderingInputPCMFormat_InputBlock_Handle = Selector.GetHandle("setManualRenderingInputPCMFormat:inputBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObstruction_ = "setObstruction:";

	private static readonly IntPtr selSetObstruction_Handle = Selector.GetHandle("setObstruction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOcclusion_ = "setOcclusion:";

	private static readonly IntPtr selSetOcclusion_Handle = Selector.GetHandle("setOcclusion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPan_ = "setPan:";

	private static readonly IntPtr selSetPan_Handle = Selector.GetHandle("setPan:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointSourceInHeadMode_ = "setPointSourceInHeadMode:";

	private static readonly IntPtr selSetPointSourceInHeadMode_Handle = Selector.GetHandle("setPointSourceInHeadMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_ = "setPosition:";

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderingAlgorithm_ = "setRenderingAlgorithm:";

	private static readonly IntPtr selSetRenderingAlgorithm_Handle = Selector.GetHandle("setRenderingAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReverbBlend_ = "setReverbBlend:";

	private static readonly IntPtr selSetReverbBlend_Handle = Selector.GetHandle("setReverbBlend:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceMode_ = "setSourceMode:";

	private static readonly IntPtr selSetSourceMode_Handle = Selector.GetHandle("setSourceMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoiceProcessingAGCEnabled_ = "setVoiceProcessingAGCEnabled:";

	private static readonly IntPtr selSetVoiceProcessingAGCEnabled_Handle = Selector.GetHandle("setVoiceProcessingAGCEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoiceProcessingBypassed_ = "setVoiceProcessingBypassed:";

	private static readonly IntPtr selSetVoiceProcessingBypassed_Handle = Selector.GetHandle("setVoiceProcessingBypassed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoiceProcessingInputMuted_ = "setVoiceProcessingInputMuted:";

	private static readonly IntPtr selSetVoiceProcessingInputMuted_Handle = Selector.GetHandle("setVoiceProcessingInputMuted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceMode = "sourceMode";

	private static readonly IntPtr selSourceModeHandle = Selector.GetHandle("sourceMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioInputNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual float Obstruction
	{
		[Export("obstruction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selObstructionHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selObstructionHandle);
		}
		[Export("setObstruction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetObstruction_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetObstruction_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual float Occlusion
	{
		[Export("occlusion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selOcclusionHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selOcclusionHandle);
		}
		[Export("setOcclusion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetOcclusion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetOcclusion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual float Pan
	{
		[Export("pan")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPanHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPanHandle);
		}
		[Export("setPan:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPan_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPan_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual Vector3 Position
	{
		[Export("position")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Vector3_objc_msgSend(base.Handle, selPositionHandle);
			}
			return Messaging.Vector3_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
		[Export("setPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector3(base.Handle, selSetPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
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
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVAudio3DMixingRenderingAlgorithm RenderingAlgorithm
	{
		[Export("renderingAlgorithm")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAudio3DMixingRenderingAlgorithm)Messaging.Int64_objc_msgSend(base.Handle, selRenderingAlgorithmHandle);
			}
			return (AVAudio3DMixingRenderingAlgorithm)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRenderingAlgorithmHandle);
		}
		[Export("setRenderingAlgorithm:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRenderingAlgorithm_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRenderingAlgorithm_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual float ReverbBlend
	{
		[Export("reverbBlend")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selReverbBlendHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selReverbBlendHandle);
		}
		[Export("setReverbBlend:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetReverbBlend_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetReverbBlend_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool VoiceProcessingAgcEnabled
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isVoiceProcessingAGCEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVoiceProcessingAGCEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVoiceProcessingAGCEnabledHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setVoiceProcessingAGCEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVoiceProcessingAGCEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVoiceProcessingAGCEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool VoiceProcessingBypassed
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isVoiceProcessingBypassed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVoiceProcessingBypassedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVoiceProcessingBypassedHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setVoiceProcessingBypassed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVoiceProcessingBypassed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVoiceProcessingBypassed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool VoiceProcessingInputMuted
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isVoiceProcessingInputMuted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVoiceProcessingInputMutedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVoiceProcessingInputMutedHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setVoiceProcessingInputMuted:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetVoiceProcessingInputMuted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetVoiceProcessingInputMuted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioInputNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioInputNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("destinationForMixer:bus:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioMixingDestination? DestinationForMixer(AVAudioNode mixer, nuint bus)
	{
		if (mixer == null)
		{
			throw new ArgumentNullException("mixer");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAudioMixingDestination>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selDestinationForMixer_Bus_Handle, mixer.Handle, bus));
		}
		return Runtime.GetNSObject<AVAudioMixingDestination>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selDestinationForMixer_Bus_Handle, mixer.Handle, bus));
	}

	[Export("pointSourceInHeadMode")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudio3DMixingPointSourceInHeadMode GetPointSourceInHeadMode()
	{
		if (base.IsDirectBinding)
		{
			return (AVAudio3DMixingPointSourceInHeadMode)Messaging.Int64_objc_msgSend(base.Handle, selPointSourceInHeadModeHandle);
		}
		return (AVAudio3DMixingPointSourceInHeadMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPointSourceInHeadModeHandle);
	}

	[Export("sourceMode")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudio3DMixingSourceMode GetSourceMode()
	{
		if (base.IsDirectBinding)
		{
			return (AVAudio3DMixingSourceMode)Messaging.Int64_objc_msgSend(base.Handle, selSourceModeHandle);
		}
		return (AVAudio3DMixingSourceMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSourceModeHandle);
	}

	[Export("setManualRenderingInputPCMFormat:inputBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool SetManualRenderingInputPcmFormat(AVAudioFormat format, [BlockProxy(typeof(Trampolines.NIDAVAudioIONodeInputBlock))] AVAudioIONodeInputBlock block)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVAudioIONodeInputBlock.Handler, block);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetManualRenderingInputPCMFormat_InputBlock_Handle, format.Handle, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetManualRenderingInputPCMFormat_InputBlock_Handle, format.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("setPointSourceInHeadMode:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPointSourceInHeadMode(AVAudio3DMixingPointSourceInHeadMode pointSourceInHeadMode)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetPointSourceInHeadMode_Handle, (long)pointSourceInHeadMode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPointSourceInHeadMode_Handle, (long)pointSourceInHeadMode);
		}
	}

	[Export("setSourceMode:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSourceMode(AVAudio3DMixingSourceMode sourceMode)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetSourceMode_Handle, (long)sourceMode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSourceMode_Handle, (long)sourceMode);
		}
	}
}
