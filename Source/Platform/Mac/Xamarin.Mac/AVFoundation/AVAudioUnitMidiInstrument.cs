using System;
using System.ComponentModel;
using AudioUnit;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace AVFoundation;

[Register("AVAudioUnitMIDIInstrument", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class AVAudioUnitMidiInstrument : AVAudioUnit, IAVAudio3DMixing, INativeObject, IDisposable, IAVAudioMixing, IAVAudioStereoMixing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationForMixer_Bus_ = "destinationForMixer:bus:";

	private static readonly IntPtr selDestinationForMixer_Bus_Handle = Selector.GetHandle("destinationForMixer:bus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioComponentDescription_ = "initWithAudioComponentDescription:";

	private static readonly IntPtr selInitWithAudioComponentDescription_Handle = Selector.GetHandle("initWithAudioComponentDescription:");

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
	private const string selSendController_WithValue_OnChannel_ = "sendController:withValue:onChannel:";

	private static readonly IntPtr selSendController_WithValue_OnChannel_Handle = Selector.GetHandle("sendController:withValue:onChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendMIDIEvent_Data1_ = "sendMIDIEvent:data1:";

	private static readonly IntPtr selSendMIDIEvent_Data1_Handle = Selector.GetHandle("sendMIDIEvent:data1:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendMIDIEvent_Data1_Data2_ = "sendMIDIEvent:data1:data2:";

	private static readonly IntPtr selSendMIDIEvent_Data1_Data2_Handle = Selector.GetHandle("sendMIDIEvent:data1:data2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendMIDISysExEvent_ = "sendMIDISysExEvent:";

	private static readonly IntPtr selSendMIDISysExEvent_Handle = Selector.GetHandle("sendMIDISysExEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendPitchBend_OnChannel_ = "sendPitchBend:onChannel:";

	private static readonly IntPtr selSendPitchBend_OnChannel_Handle = Selector.GetHandle("sendPitchBend:onChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendPressure_OnChannel_ = "sendPressure:onChannel:";

	private static readonly IntPtr selSendPressure_OnChannel_Handle = Selector.GetHandle("sendPressure:onChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendPressureForKey_WithValue_OnChannel_ = "sendPressureForKey:withValue:onChannel:";

	private static readonly IntPtr selSendPressureForKey_WithValue_OnChannel_Handle = Selector.GetHandle("sendPressureForKey:withValue:onChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendProgramChange_BankMSB_BankLSB_OnChannel_ = "sendProgramChange:bankMSB:bankLSB:onChannel:";

	private static readonly IntPtr selSendProgramChange_BankMSB_BankLSB_OnChannel_Handle = Selector.GetHandle("sendProgramChange:bankMSB:bankLSB:onChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendProgramChange_OnChannel_ = "sendProgramChange:onChannel:";

	private static readonly IntPtr selSendProgramChange_OnChannel_Handle = Selector.GetHandle("sendProgramChange:onChannel:");

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
	private const string selStartNote_WithVelocity_OnChannel_ = "startNote:withVelocity:onChannel:";

	private static readonly IntPtr selStartNote_WithVelocity_OnChannel_Handle = Selector.GetHandle("startNote:withVelocity:onChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopNote_OnChannel_ = "stopNote:onChannel:";

	private static readonly IntPtr selStopNote_OnChannel_Handle = Selector.GetHandle("stopNote:onChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitMIDIInstrument");

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
	protected AVAudioUnitMidiInstrument(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitMidiInstrument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAudioComponentDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioUnitMidiInstrument(AudioComponentDescription audioComponentDescription)
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

	[Export("sendController:withValue:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendController(byte controller, byte value, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte_byte(base.Handle, selSendController_WithValue_OnChannel_Handle, controller, value, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte_byte(base.SuperHandle, selSendController_WithValue_OnChannel_Handle, controller, value, channel);
		}
	}

	[Export("sendMIDIEvent:data1:data2:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendMidiEvent(byte midiStatus, byte data1, byte data2)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte_byte(base.Handle, selSendMIDIEvent_Data1_Data2_Handle, midiStatus, data1, data2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte_byte(base.SuperHandle, selSendMIDIEvent_Data1_Data2_Handle, midiStatus, data1, data2);
		}
	}

	[Export("sendMIDIEvent:data1:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendMidiEvent(byte midiStatus, byte data1)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte(base.Handle, selSendMIDIEvent_Data1_Handle, midiStatus, data1);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte(base.SuperHandle, selSendMIDIEvent_Data1_Handle, midiStatus, data1);
		}
	}

	[Export("sendMIDISysExEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendMidiSysExEvent(NSData midiData)
	{
		if (midiData == null)
		{
			throw new ArgumentNullException("midiData");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSendMIDISysExEvent_Handle, midiData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSendMIDISysExEvent_Handle, midiData.Handle);
		}
	}

	[Export("sendPitchBend:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendPitchBend(ushort pitchbend, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt16_byte(base.Handle, selSendPitchBend_OnChannel_Handle, pitchbend, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt16_byte(base.SuperHandle, selSendPitchBend_OnChannel_Handle, pitchbend, channel);
		}
	}

	[Export("sendPressure:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendPressure(byte pressure, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte(base.Handle, selSendPressure_OnChannel_Handle, pressure, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte(base.SuperHandle, selSendPressure_OnChannel_Handle, pressure, channel);
		}
	}

	[Export("sendPressureForKey:withValue:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendPressureForKey(byte key, byte value, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte_byte(base.Handle, selSendPressureForKey_WithValue_OnChannel_Handle, key, value, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte_byte(base.SuperHandle, selSendPressureForKey_WithValue_OnChannel_Handle, key, value, channel);
		}
	}

	[Export("sendProgramChange:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendProgramChange(byte program, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte(base.Handle, selSendProgramChange_OnChannel_Handle, program, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte(base.SuperHandle, selSendProgramChange_OnChannel_Handle, program, channel);
		}
	}

	[Export("sendProgramChange:bankMSB:bankLSB:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SendProgramChange(byte program, byte bankMSB, byte bankLSB, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte_byte_byte(base.Handle, selSendProgramChange_BankMSB_BankLSB_OnChannel_Handle, program, bankMSB, bankLSB, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte_byte_byte(base.SuperHandle, selSendProgramChange_BankMSB_BankLSB_OnChannel_Handle, program, bankMSB, bankLSB, channel);
		}
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

	[Export("startNote:withVelocity:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartNote(byte note, byte velocity, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte_byte(base.Handle, selStartNote_WithVelocity_OnChannel_Handle, note, velocity, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte_byte(base.SuperHandle, selStartNote_WithVelocity_OnChannel_Handle, note, velocity, channel);
		}
	}

	[Export("stopNote:onChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopNote(byte note, byte channel)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_byte_byte(base.Handle, selStopNote_OnChannel_Handle, note, channel);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_byte_byte(base.SuperHandle, selStopNote_OnChannel_Handle, note, channel);
		}
	}
}
