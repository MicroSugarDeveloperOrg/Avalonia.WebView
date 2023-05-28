using System.ComponentModel;
using AudioToolbox;
using AudioUnit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioEngine", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioEngine : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveConfigurationChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ConfigurationChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveConfigurationChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ConfigurationChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachNode_ = "attachNode:";

	private static readonly IntPtr selAttachNode_Handle = Selector.GetHandle("attachNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachedNodes = "attachedNodes";

	private static readonly IntPtr selAttachedNodesHandle = Selector.GetHandle("attachedNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnect_To_Format_ = "connect:to:format:";

	private static readonly IntPtr selConnect_To_Format_Handle = Selector.GetHandle("connect:to:format:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnect_To_FromBus_ToBus_Format_ = "connect:to:fromBus:toBus:format:";

	private static readonly IntPtr selConnect_To_FromBus_ToBus_Format_Handle = Selector.GetHandle("connect:to:fromBus:toBus:format:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnect_ToConnectionPoints_FromBus_Format_ = "connect:toConnectionPoints:fromBus:format:";

	private static readonly IntPtr selConnect_ToConnectionPoints_FromBus_Format_Handle = Selector.GetHandle("connect:toConnectionPoints:fromBus:format:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectMIDI_To_Format_Block_ = "connectMIDI:to:format:block:";

	private static readonly IntPtr selConnectMIDI_To_Format_Block_Handle = Selector.GetHandle("connectMIDI:to:format:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectMIDI_ToNodes_Format_Block_ = "connectMIDI:toNodes:format:block:";

	private static readonly IntPtr selConnectMIDI_ToNodes_Format_Block_Handle = Selector.GetHandle("connectMIDI:toNodes:format:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetachNode_ = "detachNode:";

	private static readonly IntPtr selDetachNode_Handle = Selector.GetHandle("detachNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableManualRenderingMode = "disableManualRenderingMode";

	private static readonly IntPtr selDisableManualRenderingModeHandle = Selector.GetHandle("disableManualRenderingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectMIDI_From_ = "disconnectMIDI:from:";

	private static readonly IntPtr selDisconnectMIDI_From_Handle = Selector.GetHandle("disconnectMIDI:from:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectMIDI_FromNodes_ = "disconnectMIDI:fromNodes:";

	private static readonly IntPtr selDisconnectMIDI_FromNodes_Handle = Selector.GetHandle("disconnectMIDI:fromNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectMIDIInput_ = "disconnectMIDIInput:";

	private static readonly IntPtr selDisconnectMIDIInput_Handle = Selector.GetHandle("disconnectMIDIInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectMIDIOutput_ = "disconnectMIDIOutput:";

	private static readonly IntPtr selDisconnectMIDIOutput_Handle = Selector.GetHandle("disconnectMIDIOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectNodeInput_ = "disconnectNodeInput:";

	private static readonly IntPtr selDisconnectNodeInput_Handle = Selector.GetHandle("disconnectNodeInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectNodeInput_Bus_ = "disconnectNodeInput:bus:";

	private static readonly IntPtr selDisconnectNodeInput_Bus_Handle = Selector.GetHandle("disconnectNodeInput:bus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectNodeOutput_ = "disconnectNodeOutput:";

	private static readonly IntPtr selDisconnectNodeOutput_Handle = Selector.GetHandle("disconnectNodeOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectNodeOutput_Bus_ = "disconnectNodeOutput:bus:";

	private static readonly IntPtr selDisconnectNodeOutput_Bus_Handle = Selector.GetHandle("disconnectNodeOutput:bus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableManualRenderingMode_Format_MaximumFrameCount_Error_ = "enableManualRenderingMode:format:maximumFrameCount:error:";

	private static readonly IntPtr selEnableManualRenderingMode_Format_MaximumFrameCount_Error_Handle = Selector.GetHandle("enableManualRenderingMode:format:maximumFrameCount:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputConnectionPointForNode_InputBus_ = "inputConnectionPointForNode:inputBus:";

	private static readonly IntPtr selInputConnectionPointForNode_InputBus_Handle = Selector.GetHandle("inputConnectionPointForNode:inputBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputNode = "inputNode";

	private static readonly IntPtr selInputNodeHandle = Selector.GetHandle("inputNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutoShutdownEnabled = "isAutoShutdownEnabled";

	private static readonly IntPtr selIsAutoShutdownEnabledHandle = Selector.GetHandle("isAutoShutdownEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInManualRenderingMode = "isInManualRenderingMode";

	private static readonly IntPtr selIsInManualRenderingModeHandle = Selector.GetHandle("isInManualRenderingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRunning = "isRunning";

	private static readonly IntPtr selIsRunningHandle = Selector.GetHandle("isRunning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainMixerNode = "mainMixerNode";

	private static readonly IntPtr selMainMixerNodeHandle = Selector.GetHandle("mainMixerNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManualRenderingBlock = "manualRenderingBlock";

	private static readonly IntPtr selManualRenderingBlockHandle = Selector.GetHandle("manualRenderingBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManualRenderingFormat = "manualRenderingFormat";

	private static readonly IntPtr selManualRenderingFormatHandle = Selector.GetHandle("manualRenderingFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManualRenderingMaximumFrameCount = "manualRenderingMaximumFrameCount";

	private static readonly IntPtr selManualRenderingMaximumFrameCountHandle = Selector.GetHandle("manualRenderingMaximumFrameCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManualRenderingMode = "manualRenderingMode";

	private static readonly IntPtr selManualRenderingModeHandle = Selector.GetHandle("manualRenderingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManualRenderingSampleTime = "manualRenderingSampleTime";

	private static readonly IntPtr selManualRenderingSampleTimeHandle = Selector.GetHandle("manualRenderingSampleTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMusicSequence = "musicSequence";

	private static readonly IntPtr selMusicSequenceHandle = Selector.GetHandle("musicSequence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputConnectionPointsForNode_OutputBus_ = "outputConnectionPointsForNode:outputBus:";

	private static readonly IntPtr selOutputConnectionPointsForNode_OutputBus_Handle = Selector.GetHandle("outputConnectionPointsForNode:outputBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputNode = "outputNode";

	private static readonly IntPtr selOutputNodeHandle = Selector.GetHandle("outputNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepare = "prepare";

	private static readonly IntPtr selPrepareHandle = Selector.GetHandle("prepare");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderOffline_ToBuffer_Error_ = "renderOffline:toBuffer:error:";

	private static readonly IntPtr selRenderOffline_ToBuffer_Error_Handle = Selector.GetHandle("renderOffline:toBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoShutdownEnabled_ = "setAutoShutdownEnabled:";

	private static readonly IntPtr selSetAutoShutdownEnabled_Handle = Selector.GetHandle("setAutoShutdownEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMusicSequence_ = "setMusicSequence:";

	private static readonly IntPtr selSetMusicSequence_Handle = Selector.GetHandle("setMusicSequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartAndReturnError_ = "startAndReturnError:";

	private static readonly IntPtr selStartAndReturnError_Handle = Selector.GetHandle("startAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioEngine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConfigurationChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual NSSet<AVAudioNode> AttachedNodes
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("attachedNodes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet<AVAudioNode>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachedNodesHandle));
			}
			return Runtime.GetNSObject<NSSet<AVAudioNode>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachedNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool AutoShutdownEnabled
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isAutoShutdownEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutoShutdownEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutoShutdownEnabledHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setAutoShutdownEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoShutdownEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoShutdownEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool InManualRenderingMode
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isInManualRenderingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInManualRenderingModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInManualRenderingModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public virtual AVAudioInputNode InputNode
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Export("inputNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioInputNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputNodeHandle));
			}
			return Runtime.GetNSObject<AVAudioInputNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioMixerNode MainMixerNode
	{
		[Export("mainMixerNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioMixerNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selMainMixerNodeHandle));
			}
			return Runtime.GetNSObject<AVAudioMixerNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMainMixerNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual AVAudioEngineManualRenderingBlock ManualRenderingBlock
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("manualRenderingBlock")]
		[return: DelegateProxy(typeof(Trampolines.SDAVAudioEngineManualRenderingBlock))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManualRenderingBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selManualRenderingBlockHandle));
			return Trampolines.NIDAVAudioEngineManualRenderingBlock.Create(block);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual AVAudioFormat ManualRenderingFormat
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("manualRenderingFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selManualRenderingFormatHandle));
			}
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManualRenderingFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual uint ManualRenderingMaximumFrameCount
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("manualRenderingMaximumFrameCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selManualRenderingMaximumFrameCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selManualRenderingMaximumFrameCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual AVAudioEngineManualRenderingMode ManualRenderingMode
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("manualRenderingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAudioEngineManualRenderingMode)Messaging.Int64_objc_msgSend(base.Handle, selManualRenderingModeHandle);
			}
			return (AVAudioEngineManualRenderingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selManualRenderingModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual long ManualRenderingSampleTime
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("manualRenderingSampleTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selManualRenderingSampleTimeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selManualRenderingSampleTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual MusicSequence? MusicSequence
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("musicSequence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return AudioToolbox.MusicSequence.Lookup(Messaging.IntPtr_objc_msgSend(base.Handle, selMusicSequenceHandle));
			}
			return AudioToolbox.MusicSequence.Lookup(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMusicSequenceHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setMusicSequence:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMusicSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMusicSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioOutputNode OutputNode
	{
		[Export("outputNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioOutputNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputNodeHandle));
			}
			return Runtime.GetNSObject<AVAudioOutputNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Running
	{
		[Export("isRunning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRunningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRunningHandle);
		}
	}

	[Field("AVAudioEngineConfigurationChangeNotification", "AVFoundation")]
	[Advice("Use AVAudioEngine.Notifications.ObserveConfigurationChange helper method instead.")]
	public static NSString ConfigurationChangeNotification
	{
		get
		{
			if (_ConfigurationChangeNotification == null)
			{
				_ConfigurationChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioEngineConfigurationChangeNotification");
			}
			return _ConfigurationChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioEngine()
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
	protected AVAudioEngine(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioEngine(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attachNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AttachNode(AVAudioNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAttachNode_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttachNode_Handle, node.Handle);
		}
	}

	[Export("connect:to:fromBus:toBus:format:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Connect(AVAudioNode sourceNode, AVAudioNode targetNode, nuint sourceBus, nuint targetBus, AVAudioFormat? format)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (targetNode == null)
		{
			throw new ArgumentNullException("targetNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_nuint_IntPtr(base.Handle, selConnect_To_FromBus_ToBus_Format_Handle, sourceNode.Handle, targetNode.Handle, sourceBus, targetBus, (format == null) ? IntPtr.Zero : format.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_nuint_IntPtr(base.SuperHandle, selConnect_To_FromBus_ToBus_Format_Handle, sourceNode.Handle, targetNode.Handle, sourceBus, targetBus, (format == null) ? IntPtr.Zero : format.Handle);
		}
	}

	[Export("connect:to:format:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Connect(AVAudioNode sourceNode, AVAudioNode targetNode, AVAudioFormat? format)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (targetNode == null)
		{
			throw new ArgumentNullException("targetNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selConnect_To_Format_Handle, sourceNode.Handle, targetNode.Handle, (format == null) ? IntPtr.Zero : format.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selConnect_To_Format_Handle, sourceNode.Handle, targetNode.Handle, (format == null) ? IntPtr.Zero : format.Handle);
		}
	}

	[Export("connect:toConnectionPoints:fromBus:format:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Connect(AVAudioNode sourceNode, AVAudioConnectionPoint[] destNodes, nuint sourceBus, AVAudioFormat? format)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (destNodes == null)
		{
			throw new ArgumentNullException("destNodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(destNodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr(base.Handle, selConnect_ToConnectionPoints_FromBus_Format_Handle, sourceNode.Handle, nSArray.Handle, sourceBus, (format == null) ? IntPtr.Zero : format.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr(base.SuperHandle, selConnect_ToConnectionPoints_FromBus_Format_Handle, sourceNode.Handle, nSArray.Handle, sourceBus, (format == null) ? IntPtr.Zero : format.Handle);
		}
		nSArray.Dispose();
	}

	[Export("connectMIDI:to:format:block:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ConnectMidi(AVAudioNode sourceNode, AVAudioNode destinationNode, AVAudioFormat? format, [BlockProxy(typeof(Trampolines.NIDAUMidiOutputEventBlock))] AUMidiOutputEventBlock? tapHandler)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (destinationNode == null)
		{
			throw new ArgumentNullException("destinationNode");
		}
		BlockLiteral* ptr;
		if (tapHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUMidiOutputEventBlock.Handler, tapHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selConnectMIDI_To_Format_Block_Handle, sourceNode.Handle, destinationNode.Handle, (format == null) ? IntPtr.Zero : format.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selConnectMIDI_To_Format_Block_Handle, sourceNode.Handle, destinationNode.Handle, (format == null) ? IntPtr.Zero : format.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("connectMIDI:toNodes:format:block:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ConnectMidi(AVAudioNode sourceNode, AVAudioNode[] destinationNodes, AVAudioFormat? format, [BlockProxy(typeof(Trampolines.NIDAUMidiOutputEventBlock))] AUMidiOutputEventBlock? tapHandler)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (destinationNodes == null)
		{
			throw new ArgumentNullException("destinationNodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(destinationNodes);
		BlockLiteral* ptr;
		if (tapHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUMidiOutputEventBlock.Handler, tapHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selConnectMIDI_ToNodes_Format_Block_Handle, sourceNode.Handle, nSArray.Handle, (format == null) ? IntPtr.Zero : format.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selConnectMIDI_ToNodes_Format_Block_Handle, sourceNode.Handle, nSArray.Handle, (format == null) ? IntPtr.Zero : format.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("detachNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DetachNode(AVAudioNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetachNode_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetachNode_Handle, node.Handle);
		}
	}

	[Export("disableManualRenderingMode")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableManualRenderingMode()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableManualRenderingModeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableManualRenderingModeHandle);
		}
	}

	[Export("disconnectMIDI:from:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectMidi(AVAudioNode sourceNode, AVAudioNode destinationNode)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (destinationNode == null)
		{
			throw new ArgumentNullException("destinationNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDisconnectMIDI_From_Handle, sourceNode.Handle, destinationNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDisconnectMIDI_From_Handle, sourceNode.Handle, destinationNode.Handle);
		}
	}

	[Export("disconnectMIDI:fromNodes:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectMidi(AVAudioNode sourceNode, AVAudioNode[] destinationNodes)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (destinationNodes == null)
		{
			throw new ArgumentNullException("destinationNodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(destinationNodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDisconnectMIDI_FromNodes_Handle, sourceNode.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDisconnectMIDI_FromNodes_Handle, sourceNode.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("disconnectMIDIInput:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectMidiInput(AVAudioNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisconnectMIDIInput_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisconnectMIDIInput_Handle, node.Handle);
		}
	}

	[Export("disconnectMIDIOutput:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectMidiOutput(AVAudioNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisconnectMIDIOutput_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisconnectMIDIOutput_Handle, node.Handle);
		}
	}

	[Export("disconnectNodeInput:bus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectNodeInput(AVAudioNode node, nuint bus)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selDisconnectNodeInput_Bus_Handle, node.Handle, bus);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selDisconnectNodeInput_Bus_Handle, node.Handle, bus);
		}
	}

	[Export("disconnectNodeInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectNodeInput(AVAudioNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisconnectNodeInput_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisconnectNodeInput_Handle, node.Handle);
		}
	}

	[Export("disconnectNodeOutput:bus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectNodeOutput(AVAudioNode node, nuint bus)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selDisconnectNodeOutput_Bus_Handle, node.Handle, bus);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selDisconnectNodeOutput_Bus_Handle, node.Handle, bus);
		}
	}

	[Export("disconnectNodeOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectNodeOutput(AVAudioNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisconnectNodeOutput_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisconnectNodeOutput_Handle, node.Handle);
		}
	}

	[Export("enableManualRenderingMode:format:maximumFrameCount:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnableManualRenderingMode(AVAudioEngineManualRenderingMode mode, AVAudioFormat pcmFormat, uint maximumFrameCount, out NSError outError)
	{
		if (pcmFormat == null)
		{
			throw new ArgumentNullException("pcmFormat");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_Int64_IntPtr_UInt32_ref_IntPtr(base.SuperHandle, selEnableManualRenderingMode_Format_MaximumFrameCount_Error_Handle, (long)mode, pcmFormat.Handle, maximumFrameCount, ref arg) : Messaging.bool_objc_msgSend_Int64_IntPtr_UInt32_ref_IntPtr(base.Handle, selEnableManualRenderingMode_Format_MaximumFrameCount_Error_Handle, (long)mode, pcmFormat.Handle, maximumFrameCount, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("inputConnectionPointForNode:inputBus:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioConnectionPoint? InputConnectionPoint(AVAudioNode node, nuint bus)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAudioConnectionPoint>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInputConnectionPointForNode_InputBus_Handle, node.Handle, bus));
		}
		return Runtime.GetNSObject<AVAudioConnectionPoint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInputConnectionPointForNode_InputBus_Handle, node.Handle, bus));
	}

	[Export("outputConnectionPointsForNode:outputBus:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioConnectionPoint[] OutputConnectionPoints(AVAudioNode node, nuint bus)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<AVAudioConnectionPoint>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selOutputConnectionPointsForNode_OutputBus_Handle, node.Handle, bus));
		}
		return NSArray.ArrayFromHandle<AVAudioConnectionPoint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selOutputConnectionPointsForNode_OutputBus_Handle, node.Handle, bus));
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

	[Export("prepare")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Prepare()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareHandle);
		}
	}

	[Export("renderOffline:toBuffer:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioEngineManualRenderingStatus RenderOffline(uint numberOfFrames, AVAudioPcmBuffer buffer, out NSError? outError)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		IntPtr arg = IntPtr.Zero;
		AVAudioEngineManualRenderingStatus result = (AVAudioEngineManualRenderingStatus)((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_UInt32_IntPtr_ref_IntPtr(base.SuperHandle, selRenderOffline_ToBuffer_Error_Handle, numberOfFrames, buffer.Handle, ref arg) : Messaging.Int64_objc_msgSend_UInt32_IntPtr_ref_IntPtr(base.Handle, selRenderOffline_ToBuffer_Error_Handle, numberOfFrames, buffer.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("startAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartAndReturnError(out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selStartAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selStartAndReturnError_Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
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
