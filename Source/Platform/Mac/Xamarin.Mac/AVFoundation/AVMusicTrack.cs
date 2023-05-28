using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVMusicTrack", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AVMusicTrack : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationAudioUnit = "destinationAudioUnit";

	private static readonly IntPtr selDestinationAudioUnitHandle = Selector.GetHandle("destinationAudioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationMIDIEndpoint = "destinationMIDIEndpoint";

	private static readonly IntPtr selDestinationMIDIEndpointHandle = Selector.GetHandle("destinationMIDIEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoopingEnabled = "isLoopingEnabled";

	private static readonly IntPtr selIsLoopingEnabledHandle = Selector.GetHandle("isLoopingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMuted = "isMuted";

	private static readonly IntPtr selIsMutedHandle = Selector.GetHandle("isMuted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSoloed = "isSoloed";

	private static readonly IntPtr selIsSoloedHandle = Selector.GetHandle("isSoloed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLengthInBeats = "lengthInBeats";

	private static readonly IntPtr selLengthInBeatsHandle = Selector.GetHandle("lengthInBeats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLengthInSeconds = "lengthInSeconds";

	private static readonly IntPtr selLengthInSecondsHandle = Selector.GetHandle("lengthInSeconds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoopRange = "loopRange";

	private static readonly IntPtr selLoopRangeHandle = Selector.GetHandle("loopRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfLoops = "numberOfLoops";

	private static readonly IntPtr selNumberOfLoopsHandle = Selector.GetHandle("numberOfLoops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetTime = "offsetTime";

	private static readonly IntPtr selOffsetTimeHandle = Selector.GetHandle("offsetTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationAudioUnit_ = "setDestinationAudioUnit:";

	private static readonly IntPtr selSetDestinationAudioUnit_Handle = Selector.GetHandle("setDestinationAudioUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationMIDIEndpoint_ = "setDestinationMIDIEndpoint:";

	private static readonly IntPtr selSetDestinationMIDIEndpoint_Handle = Selector.GetHandle("setDestinationMIDIEndpoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLengthInBeats_ = "setLengthInBeats:";

	private static readonly IntPtr selSetLengthInBeats_Handle = Selector.GetHandle("setLengthInBeats:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLengthInSeconds_ = "setLengthInSeconds:";

	private static readonly IntPtr selSetLengthInSeconds_Handle = Selector.GetHandle("setLengthInSeconds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoopRange_ = "setLoopRange:";

	private static readonly IntPtr selSetLoopRange_Handle = Selector.GetHandle("setLoopRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoopingEnabled_ = "setLoopingEnabled:";

	private static readonly IntPtr selSetLoopingEnabled_Handle = Selector.GetHandle("setLoopingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMuted_ = "setMuted:";

	private static readonly IntPtr selSetMuted_Handle = Selector.GetHandle("setMuted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfLoops_ = "setNumberOfLoops:";

	private static readonly IntPtr selSetNumberOfLoops_Handle = Selector.GetHandle("setNumberOfLoops:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOffsetTime_ = "setOffsetTime:";

	private static readonly IntPtr selSetOffsetTime_Handle = Selector.GetHandle("setOffsetTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSoloed_ = "setSoloed:";

	private static readonly IntPtr selSetSoloed_Handle = Selector.GetHandle("setSoloed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeResolution = "timeResolution";

	private static readonly IntPtr selTimeResolutionHandle = Selector.GetHandle("timeResolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMusicTrack");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioUnit? DestinationAudioUnit
	{
		[Export("destinationAudioUnit", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioUnit>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationAudioUnitHandle));
			}
			return Runtime.GetNSObject<AVAudioUnit>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationAudioUnitHandle));
		}
		[Export("setDestinationAudioUnit:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestinationAudioUnit_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestinationAudioUnit_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual uint DestinationMidiEndpoint
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("destinationMIDIEndpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selDestinationMIDIEndpointHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selDestinationMIDIEndpointHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setDestinationMIDIEndpoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetDestinationMIDIEndpoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetDestinationMIDIEndpoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double LengthInBeats
	{
		[Export("lengthInBeats")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLengthInBeatsHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLengthInBeatsHandle);
		}
		[Export("setLengthInBeats:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLengthInBeats_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLengthInBeats_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double LengthInSeconds
	{
		[Export("lengthInSeconds")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLengthInSecondsHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLengthInSecondsHandle);
		}
		[Export("setLengthInSeconds:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLengthInSeconds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLengthInSeconds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVBeatRange LoopRange
	{
		[Export("loopRange", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVBeatRange_objc_msgSend(base.Handle, selLoopRangeHandle);
			}
			return Messaging.AVBeatRange_objc_msgSendSuper(base.SuperHandle, selLoopRangeHandle);
		}
		[Export("setLoopRange:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_AVBeatRange(base.Handle, selSetLoopRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_AVBeatRange(base.SuperHandle, selSetLoopRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LoopingEnabled
	{
		[Export("isLoopingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoopingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoopingEnabledHandle);
		}
		[Export("setLoopingEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLoopingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLoopingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Muted
	{
		[Export("isMuted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMutedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMutedHandle);
		}
		[Export("setMuted:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMuted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMuted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfLoops
	{
		[Export("numberOfLoops", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfLoopsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfLoopsHandle);
		}
		[Export("setNumberOfLoops:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfLoops_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfLoops_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double OffsetTime
	{
		[Export("offsetTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selOffsetTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selOffsetTimeHandle);
		}
		[Export("setOffsetTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetOffsetTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetOffsetTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Soloed
	{
		[Export("isSoloed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSoloedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSoloedHandle);
		}
		[Export("setSoloed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSoloed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSoloed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint TimeResolution
	{
		[Export("timeResolution")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selTimeResolutionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTimeResolutionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMusicTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMusicTrack(IntPtr handle)
		: base(handle)
	{
	}
}
