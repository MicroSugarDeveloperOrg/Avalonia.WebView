using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioPlayerNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioPlayerNode : AVAudioNode, IAVAudio3DMixing, INativeObject, IDisposable, IAVAudioMixing, IAVAudioStereoMixing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationForMixer_Bus_ = "destinationForMixer:bus:";

	private static readonly IntPtr selDestinationForMixer_Bus_Handle = Selector.GetHandle("destinationForMixer:bus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaying = "isPlaying";

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeTimeForPlayerTime_ = "nodeTimeForPlayerTime:";

	private static readonly IntPtr selNodeTimeForPlayerTime_Handle = Selector.GetHandle("nodeTimeForPlayerTime:");

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
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay = "play";

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayAtTime_ = "playAtTime:";

	private static readonly IntPtr selPlayAtTime_Handle = Selector.GetHandle("playAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerTimeForNodeTime_ = "playerTimeForNodeTime:";

	private static readonly IntPtr selPlayerTimeForNodeTime_Handle = Selector.GetHandle("playerTimeForNodeTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointSourceInHeadMode = "pointSourceInHeadMode";

	private static readonly IntPtr selPointSourceInHeadModeHandle = Selector.GetHandle("pointSourceInHeadMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareWithFrameCount_ = "prepareWithFrameCount:";

	private static readonly IntPtr selPrepareWithFrameCount_Handle = Selector.GetHandle("prepareWithFrameCount:");

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
	private const string selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_ = "scheduleBuffer:atTime:options:completionCallbackType:completionHandler:";

	private static readonly IntPtr selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_Handle = Selector.GetHandle("scheduleBuffer:atTime:options:completionCallbackType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleBuffer_AtTime_Options_CompletionHandler_ = "scheduleBuffer:atTime:options:completionHandler:";

	private static readonly IntPtr selScheduleBuffer_AtTime_Options_CompletionHandler_Handle = Selector.GetHandle("scheduleBuffer:atTime:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleBuffer_CompletionCallbackType_CompletionHandler_ = "scheduleBuffer:completionCallbackType:completionHandler:";

	private static readonly IntPtr selScheduleBuffer_CompletionCallbackType_CompletionHandler_Handle = Selector.GetHandle("scheduleBuffer:completionCallbackType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleBuffer_CompletionHandler_ = "scheduleBuffer:completionHandler:";

	private static readonly IntPtr selScheduleBuffer_CompletionHandler_Handle = Selector.GetHandle("scheduleBuffer:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_ = "scheduleFile:atTime:completionCallbackType:completionHandler:";

	private static readonly IntPtr selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_Handle = Selector.GetHandle("scheduleFile:atTime:completionCallbackType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleFile_AtTime_CompletionHandler_ = "scheduleFile:atTime:completionHandler:";

	private static readonly IntPtr selScheduleFile_AtTime_CompletionHandler_Handle = Selector.GetHandle("scheduleFile:atTime:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_ = "scheduleSegment:startingFrame:frameCount:atTime:completionCallbackType:completionHandler:";

	private static readonly IntPtr selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_Handle = Selector.GetHandle("scheduleSegment:startingFrame:frameCount:atTime:completionCallbackType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_ = "scheduleSegment:startingFrame:frameCount:atTime:completionHandler:";

	private static readonly IntPtr selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_Handle = Selector.GetHandle("scheduleSegment:startingFrame:frameCount:atTime:completionHandler:");

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
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceMode = "sourceMode";

	private static readonly IntPtr selSourceModeHandle = Selector.GetHandle("sourceMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioPlayerNode");

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
	public virtual bool Playing
	{
		[Export("isPlaying")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayingHandle);
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
	protected AVAudioPlayerNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioPlayerNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioPlayerNode()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
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

	[Export("nodeTimeForPlayerTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioTime? GetNodeTimeFromPlayerTime(AVAudioTime playerTime)
	{
		if (playerTime == null)
		{
			throw new ArgumentNullException("playerTime");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNodeTimeForPlayerTime_Handle, playerTime.Handle));
		}
		return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNodeTimeForPlayerTime_Handle, playerTime.Handle));
	}

	[Export("playerTimeForNodeTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioTime? GetPlayerTimeFromNodeTime(AVAudioTime nodeTime)
	{
		if (nodeTime == null)
		{
			throw new ArgumentNullException("nodeTime");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPlayerTimeForNodeTime_Handle, nodeTime.Handle));
		}
		return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPlayerTimeForNodeTime_Handle, nodeTime.Handle));
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

	[Export("pause")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Pause()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
		}
	}

	[Export("play")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Play()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPlayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
		}
	}

	[Export("playAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PlayAtTime(AVAudioTime? when)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPlayAtTime_Handle, when?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPlayAtTime_Handle, when?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("prepareWithFrameCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareWithFrameCount(uint frameCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selPrepareWithFrameCount_Handle, frameCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selPrepareWithFrameCount_Handle, frameCount);
		}
	}

	[Export("scheduleBuffer:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleBuffer(AVAudioPcmBuffer buffer, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selScheduleBuffer_CompletionHandler_Handle, buffer.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selScheduleBuffer_CompletionHandler_Handle, buffer.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ScheduleBufferAsync(AVAudioPcmBuffer buffer)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ScheduleBuffer(buffer, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("scheduleBuffer:atTime:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleBuffer(AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selScheduleBuffer_AtTime_Options_CompletionHandler_Handle, buffer.Handle, when?.Handle ?? IntPtr.Zero, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selScheduleBuffer_AtTime_Options_CompletionHandler_Handle, buffer.Handle, when?.Handle ?? IntPtr.Zero, (ulong)options, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ScheduleBufferAsync(AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ScheduleBuffer(buffer, when, options, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("scheduleBuffer:completionCallbackType:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleBuffer(AVAudioPcmBuffer buffer, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy(typeof(Trampolines.NIDActionArity1V2))] Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V2.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selScheduleBuffer_CompletionCallbackType_CompletionHandler_Handle, buffer.Handle, (long)callbackType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selScheduleBuffer_CompletionCallbackType_CompletionHandler_Handle, buffer.Handle, (long)callbackType, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleBufferAsync(AVAudioPcmBuffer buffer, AVAudioPlayerNodeCompletionCallbackType callbackType)
	{
		TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType>();
		ScheduleBuffer(buffer, callbackType, delegate(AVAudioPlayerNodeCompletionCallbackType obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("scheduleBuffer:atTime:options:completionCallbackType:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleBuffer(AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy(typeof(Trampolines.NIDActionArity1V2))] Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V2.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_Int64_IntPtr(base.Handle, selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_Handle, buffer.Handle, when?.Handle ?? IntPtr.Zero, (ulong)options, (long)callbackType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_Int64_IntPtr(base.SuperHandle, selScheduleBuffer_AtTime_Options_CompletionCallbackType_CompletionHandler_Handle, buffer.Handle, when?.Handle ?? IntPtr.Zero, (ulong)options, (long)callbackType, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleBufferAsync(AVAudioPcmBuffer buffer, AVAudioTime? when, AVAudioPlayerNodeBufferOptions options, AVAudioPlayerNodeCompletionCallbackType callbackType)
	{
		TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType>();
		ScheduleBuffer(buffer, when, options, callbackType, delegate(AVAudioPlayerNodeCompletionCallbackType obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("scheduleFile:atTime:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleFile(AVAudioFile file, AVAudioTime? when, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selScheduleFile_AtTime_CompletionHandler_Handle, file.Handle, when?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selScheduleFile_AtTime_CompletionHandler_Handle, file.Handle, when?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ScheduleFileAsync(AVAudioFile file, AVAudioTime? when)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ScheduleFile(file, when, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("scheduleFile:atTime:completionCallbackType:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleFile(AVAudioFile file, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy(typeof(Trampolines.NIDActionArity1V2))] Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V2.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr(base.Handle, selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_Handle, file.Handle, when?.Handle ?? IntPtr.Zero, (long)callbackType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr(base.SuperHandle, selScheduleFile_AtTime_CompletionCallbackType_CompletionHandler_Handle, file.Handle, when?.Handle ?? IntPtr.Zero, (long)callbackType, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleFileAsync(AVAudioFile file, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType)
	{
		TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType>();
		ScheduleFile(file, when, callbackType, delegate(AVAudioPlayerNodeCompletionCallbackType obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("scheduleSegment:startingFrame:frameCount:atTime:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleSegment(AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_UInt32_IntPtr_IntPtr(base.Handle, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_Handle, file.Handle, startFrame, numberFrames, when?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_UInt32_IntPtr_IntPtr(base.SuperHandle, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionHandler_Handle, file.Handle, startFrame, numberFrames, when?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ScheduleSegmentAsync(AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ScheduleSegment(file, startFrame, numberFrames, when, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("scheduleSegment:startingFrame:frameCount:atTime:completionCallbackType:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ScheduleSegment(AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType, [BlockProxy(typeof(Trampolines.NIDActionArity1V2))] Action<AVAudioPlayerNodeCompletionCallbackType>? completionHandler)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V2.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_UInt32_IntPtr_Int64_IntPtr(base.Handle, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_Handle, file.Handle, startFrame, numberFrames, when?.Handle ?? IntPtr.Zero, (long)callbackType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_UInt32_IntPtr_Int64_IntPtr(base.SuperHandle, selScheduleSegment_StartingFrame_FrameCount_AtTime_CompletionCallbackType_CompletionHandler_Handle, file.Handle, startFrame, numberFrames, when?.Handle ?? IntPtr.Zero, (long)callbackType, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<AVAudioPlayerNodeCompletionCallbackType> ScheduleSegmentAsync(AVAudioFile file, long startFrame, uint numberFrames, AVAudioTime? when, AVAudioPlayerNodeCompletionCallbackType callbackType)
	{
		TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType> tcs = new TaskCompletionSource<AVAudioPlayerNodeCompletionCallbackType>();
		ScheduleSegment(file, startFrame, numberFrames, when, callbackType, delegate(AVAudioPlayerNodeCompletionCallbackType obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
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

	[Export("stop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stop()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}
}
