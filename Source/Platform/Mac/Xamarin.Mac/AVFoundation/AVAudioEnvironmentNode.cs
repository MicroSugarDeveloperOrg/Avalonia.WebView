using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace AVFoundation;

[Register("AVAudioEnvironmentNode", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioEnvironmentNode : AVAudioNode, IAVAudio3DMixing, INativeObject, IDisposable, IAVAudioMixing, IAVAudioStereoMixing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicableRenderingAlgorithms = "applicableRenderingAlgorithms";

	private static readonly IntPtr selApplicableRenderingAlgorithmsHandle = Selector.GetHandle("applicableRenderingAlgorithms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationForMixer_Bus_ = "destinationForMixer:bus:";

	private static readonly IntPtr selDestinationForMixer_Bus_Handle = Selector.GetHandle("destinationForMixer:bus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistanceAttenuationParameters = "distanceAttenuationParameters";

	private static readonly IntPtr selDistanceAttenuationParametersHandle = Selector.GetHandle("distanceAttenuationParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selListenerAngularOrientation = "listenerAngularOrientation";

	private static readonly IntPtr selListenerAngularOrientationHandle = Selector.GetHandle("listenerAngularOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selListenerPosition = "listenerPosition";

	private static readonly IntPtr selListenerPositionHandle = Selector.GetHandle("listenerPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selListenerVectorOrientation = "listenerVectorOrientation";

	private static readonly IntPtr selListenerVectorOrientationHandle = Selector.GetHandle("listenerVectorOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextAvailableInputBus = "nextAvailableInputBus";

	private static readonly IntPtr selNextAvailableInputBusHandle = Selector.GetHandle("nextAvailableInputBus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstruction = "obstruction";

	private static readonly IntPtr selObstructionHandle = Selector.GetHandle("obstruction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOcclusion = "occlusion";

	private static readonly IntPtr selOcclusionHandle = Selector.GetHandle("occlusion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputType = "outputType";

	private static readonly IntPtr selOutputTypeHandle = Selector.GetHandle("outputType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputVolume = "outputVolume";

	private static readonly IntPtr selOutputVolumeHandle = Selector.GetHandle("outputVolume");

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
	private const string selReverbParameters = "reverbParameters";

	private static readonly IntPtr selReverbParametersHandle = Selector.GetHandle("reverbParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetListenerAngularOrientation_ = "setListenerAngularOrientation:";

	private static readonly IntPtr selSetListenerAngularOrientation_Handle = Selector.GetHandle("setListenerAngularOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetListenerPosition_ = "setListenerPosition:";

	private static readonly IntPtr selSetListenerPosition_Handle = Selector.GetHandle("setListenerPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetListenerVectorOrientation_ = "setListenerVectorOrientation:";

	private static readonly IntPtr selSetListenerVectorOrientation_Handle = Selector.GetHandle("setListenerVectorOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObstruction_ = "setObstruction:";

	private static readonly IntPtr selSetObstruction_Handle = Selector.GetHandle("setObstruction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOcclusion_ = "setOcclusion:";

	private static readonly IntPtr selSetOcclusion_Handle = Selector.GetHandle("setOcclusion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputType_ = "setOutputType:";

	private static readonly IntPtr selSetOutputType_Handle = Selector.GetHandle("setOutputType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputVolume_ = "setOutputVolume:";

	private static readonly IntPtr selSetOutputVolume_Handle = Selector.GetHandle("setOutputVolume:");

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
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioEnvironmentNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioEnvironmentDistanceAttenuationParameters DistanceAttenuationParameters
	{
		[Export("distanceAttenuationParameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioEnvironmentDistanceAttenuationParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selDistanceAttenuationParametersHandle));
			}
			return Runtime.GetNSObject<AVAudioEnvironmentDistanceAttenuationParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDistanceAttenuationParametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudio3DAngularOrientation ListenerAngularOrientation
	{
		[Export("listenerAngularOrientation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVAudio3DAngularOrientation_objc_msgSend(base.Handle, selListenerAngularOrientationHandle);
			}
			return Messaging.AVAudio3DAngularOrientation_objc_msgSendSuper(base.SuperHandle, selListenerAngularOrientationHandle);
		}
		[Export("setListenerAngularOrientation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_AVAudio3DAngularOrientation(base.Handle, selSetListenerAngularOrientation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_AVAudio3DAngularOrientation(base.SuperHandle, selSetListenerAngularOrientation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 ListenerPosition
	{
		[Export("listenerPosition", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Vector3_objc_msgSend(base.Handle, selListenerPositionHandle);
			}
			return Messaging.Vector3_objc_msgSendSuper(base.SuperHandle, selListenerPositionHandle);
		}
		[Export("setListenerPosition:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector3(base.Handle, selSetListenerPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetListenerPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudio3DVectorOrientation ListenerVectorOrientation
	{
		[Export("listenerVectorOrientation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVAudio3DVectorOrientation_objc_msgSend(base.Handle, selListenerVectorOrientationHandle);
			}
			return Messaging.AVAudio3DVectorOrientation_objc_msgSendSuper(base.SuperHandle, selListenerVectorOrientationHandle);
		}
		[Export("setListenerVectorOrientation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_AVAudio3DVectorOrientation(base.Handle, selSetListenerVectorOrientation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_AVAudio3DVectorOrientation(base.SuperHandle, selSetListenerVectorOrientation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NextAvailableInputBus
	{
		[Export("nextAvailableInputBus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNextAvailableInputBusHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNextAvailableInputBusHandle);
		}
	}

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
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual AVAudioEnvironmentOutputType OutputType
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("outputType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAudioEnvironmentOutputType)Messaging.Int64_objc_msgSend(base.Handle, selOutputTypeHandle);
			}
			return (AVAudioEnvironmentOutputType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selOutputTypeHandle);
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setOutputType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetOutputType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetOutputType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float OutputVolume
	{
		[Export("outputVolume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selOutputVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selOutputVolumeHandle);
		}
		[Export("setOutputVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetOutputVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetOutputVolume_Handle, value);
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
	public virtual AVAudioEnvironmentReverbParameters ReverbParameters
	{
		[Export("reverbParameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioEnvironmentReverbParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selReverbParametersHandle));
			}
			return Runtime.GetNSObject<AVAudioEnvironmentReverbParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReverbParametersHandle));
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
	protected AVAudioEnvironmentNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioEnvironmentNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioEnvironmentNode()
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

	[Export("applicableRenderingAlgorithms")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ApplicableRenderingAlgorithms()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selApplicableRenderingAlgorithmsHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApplicableRenderingAlgorithmsHandle));
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
