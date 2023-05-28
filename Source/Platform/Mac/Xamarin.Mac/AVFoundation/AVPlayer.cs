using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayer", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVPlayer : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveEligibleForHdrPlaybackDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EligibleForHdrPlaybackDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveEligibleForHdrPlaybackDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(EligibleForHdrPlaybackDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionAtItemEnd = "actionAtItemEnd";

	private static readonly IntPtr selActionAtItemEndHandle = Selector.GetHandle("actionAtItemEnd");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_ = "addBoundaryTimeObserverForTimes:queue:usingBlock:";

	private static readonly IntPtr selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_Handle = Selector.GetHandle("addBoundaryTimeObserverForTimes:queue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_ = "addPeriodicTimeObserverForInterval:queue:usingBlock:";

	private static readonly IntPtr selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_Handle = Selector.GetHandle("addPeriodicTimeObserverForInterval:queue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsExternalPlayback = "allowsExternalPlayback";

	private static readonly IntPtr selAllowsExternalPlaybackHandle = Selector.GetHandle("allowsExternalPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppliesMediaSelectionCriteriaAutomatically = "appliesMediaSelectionCriteriaAutomatically";

	private static readonly IntPtr selAppliesMediaSelectionCriteriaAutomaticallyHandle = Selector.GetHandle("appliesMediaSelectionCriteriaAutomatically");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioOutputDeviceUniqueID = "audioOutputDeviceUniqueID";

	private static readonly IntPtr selAudioOutputDeviceUniqueIDHandle = Selector.GetHandle("audioOutputDeviceUniqueID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyWaitsToMinimizeStalling = "automaticallyWaitsToMinimizeStalling";

	private static readonly IntPtr selAutomaticallyWaitsToMinimizeStallingHandle = Selector.GetHandle("automaticallyWaitsToMinimizeStalling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelPendingPrerolls = "cancelPendingPrerolls";

	private static readonly IntPtr selCancelPendingPrerollsHandle = Selector.GetHandle("cancelPendingPrerolls");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentItem = "currentItem";

	private static readonly IntPtr selCurrentItemHandle = Selector.GetHandle("currentItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEligibleForHDRPlayback = "eligibleForHDRPlayback";

	private static readonly IntPtr selEligibleForHDRPlaybackHandle = Selector.GetHandle("eligibleForHDRPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExternalPlaybackVideoGravity = "externalPlaybackVideoGravity";

	private static readonly IntPtr selExternalPlaybackVideoGravityHandle = Selector.GetHandle("externalPlaybackVideoGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPlayerItem_ = "initWithPlayerItem:";

	private static readonly IntPtr selInitWithPlayerItem_Handle = Selector.GetHandle("initWithPlayerItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsClosedCaptionDisplayEnabled = "isClosedCaptionDisplayEnabled";

	private static readonly IntPtr selIsClosedCaptionDisplayEnabledHandle = Selector.GetHandle("isClosedCaptionDisplayEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExternalPlaybackActive = "isExternalPlaybackActive";

	private static readonly IntPtr selIsExternalPlaybackActiveHandle = Selector.GetHandle("isExternalPlaybackActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMuted = "isMuted";

	private static readonly IntPtr selIsMutedHandle = Selector.GetHandle("isMuted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMasterClock = "masterClock";

	private static readonly IntPtr selMasterClockHandle = Selector.GetHandle("masterClock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionCriteriaForMediaCharacteristic_ = "mediaSelectionCriteriaForMediaCharacteristic:";

	private static readonly IntPtr selMediaSelectionCriteriaForMediaCharacteristic_Handle = Selector.GetHandle("mediaSelectionCriteriaForMediaCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputObscuredDueToInsufficientExternalProtection = "outputObscuredDueToInsufficientExternalProtection";

	private static readonly IntPtr selOutputObscuredDueToInsufficientExternalProtectionHandle = Selector.GetHandle("outputObscuredDueToInsufficientExternalProtection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay = "play";

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayImmediatelyAtRate_ = "playImmediatelyAtRate:";

	private static readonly IntPtr selPlayImmediatelyAtRate_Handle = Selector.GetHandle("playImmediatelyAtRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerWithPlayerItem_ = "playerWithPlayerItem:";

	private static readonly IntPtr selPlayerWithPlayerItem_Handle = Selector.GetHandle("playerWithPlayerItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerWithURL_ = "playerWithURL:";

	private static readonly IntPtr selPlayerWithURL_Handle = Selector.GetHandle("playerWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredVideoDecoderGPURegistryID = "preferredVideoDecoderGPURegistryID";

	private static readonly IntPtr selPreferredVideoDecoderGPURegistryIDHandle = Selector.GetHandle("preferredVideoDecoderGPURegistryID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrerollAtRate_CompletionHandler_ = "prerollAtRate:completionHandler:";

	private static readonly IntPtr selPrerollAtRate_CompletionHandler_Handle = Selector.GetHandle("prerollAtRate:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreventsDisplaySleepDuringVideoPlayback = "preventsDisplaySleepDuringVideoPlayback";

	private static readonly IntPtr selPreventsDisplaySleepDuringVideoPlaybackHandle = Selector.GetHandle("preventsDisplaySleepDuringVideoPlayback");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRate = "rate";

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReasonForWaitingToPlay = "reasonForWaitingToPlay";

	private static readonly IntPtr selReasonForWaitingToPlayHandle = Selector.GetHandle("reasonForWaitingToPlay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTimeObserver_ = "removeTimeObserver:";

	private static readonly IntPtr selRemoveTimeObserver_Handle = Selector.GetHandle("removeTimeObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCurrentItemWithPlayerItem_ = "replaceCurrentItemWithPlayerItem:";

	private static readonly IntPtr selReplaceCurrentItemWithPlayerItem_Handle = Selector.GetHandle("replaceCurrentItemWithPlayerItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToDate_ = "seekToDate:";

	private static readonly IntPtr selSeekToDate_Handle = Selector.GetHandle("seekToDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToDate_CompletionHandler_ = "seekToDate:completionHandler:";

	private static readonly IntPtr selSeekToDate_CompletionHandler_Handle = Selector.GetHandle("seekToDate:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToTime_ = "seekToTime:";

	private static readonly IntPtr selSeekToTime_Handle = Selector.GetHandle("seekToTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToTime_CompletionHandler_ = "seekToTime:completionHandler:";

	private static readonly IntPtr selSeekToTime_CompletionHandler_Handle = Selector.GetHandle("seekToTime:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToTime_ToleranceBefore_ToleranceAfter_ = "seekToTime:toleranceBefore:toleranceAfter:";

	private static readonly IntPtr selSeekToTime_ToleranceBefore_ToleranceAfter_Handle = Selector.GetHandle("seekToTime:toleranceBefore:toleranceAfter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_ = "seekToTime:toleranceBefore:toleranceAfter:completionHandler:";

	private static readonly IntPtr selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_Handle = Selector.GetHandle("seekToTime:toleranceBefore:toleranceAfter:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActionAtItemEnd_ = "setActionAtItemEnd:";

	private static readonly IntPtr selSetActionAtItemEnd_Handle = Selector.GetHandle("setActionAtItemEnd:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsExternalPlayback_ = "setAllowsExternalPlayback:";

	private static readonly IntPtr selSetAllowsExternalPlayback_Handle = Selector.GetHandle("setAllowsExternalPlayback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppliesMediaSelectionCriteriaAutomatically_ = "setAppliesMediaSelectionCriteriaAutomatically:";

	private static readonly IntPtr selSetAppliesMediaSelectionCriteriaAutomatically_Handle = Selector.GetHandle("setAppliesMediaSelectionCriteriaAutomatically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioOutputDeviceUniqueID_ = "setAudioOutputDeviceUniqueID:";

	private static readonly IntPtr selSetAudioOutputDeviceUniqueID_Handle = Selector.GetHandle("setAudioOutputDeviceUniqueID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyWaitsToMinimizeStalling_ = "setAutomaticallyWaitsToMinimizeStalling:";

	private static readonly IntPtr selSetAutomaticallyWaitsToMinimizeStalling_Handle = Selector.GetHandle("setAutomaticallyWaitsToMinimizeStalling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClosedCaptionDisplayEnabled_ = "setClosedCaptionDisplayEnabled:";

	private static readonly IntPtr selSetClosedCaptionDisplayEnabled_Handle = Selector.GetHandle("setClosedCaptionDisplayEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExternalPlaybackVideoGravity_ = "setExternalPlaybackVideoGravity:";

	private static readonly IntPtr selSetExternalPlaybackVideoGravity_Handle = Selector.GetHandle("setExternalPlaybackVideoGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMasterClock_ = "setMasterClock:";

	private static readonly IntPtr selSetMasterClock_Handle = Selector.GetHandle("setMasterClock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaSelectionCriteria_ForMediaCharacteristic_ = "setMediaSelectionCriteria:forMediaCharacteristic:";

	private static readonly IntPtr selSetMediaSelectionCriteria_ForMediaCharacteristic_Handle = Selector.GetHandle("setMediaSelectionCriteria:forMediaCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMuted_ = "setMuted:";

	private static readonly IntPtr selSetMuted_Handle = Selector.GetHandle("setMuted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredVideoDecoderGPURegistryID_ = "setPreferredVideoDecoderGPURegistryID:";

	private static readonly IntPtr selSetPreferredVideoDecoderGPURegistryID_Handle = Selector.GetHandle("setPreferredVideoDecoderGPURegistryID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreventsDisplaySleepDuringVideoPlayback_ = "setPreventsDisplaySleepDuringVideoPlayback:";

	private static readonly IntPtr selSetPreventsDisplaySleepDuringVideoPlayback_Handle = Selector.GetHandle("setPreventsDisplaySleepDuringVideoPlayback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_ = "setRate:";

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRate_Time_AtHostTime_ = "setRate:time:atHostTime:";

	private static readonly IntPtr selSetRate_Time_AtHostTime_Handle = Selector.GetHandle("setRate:time:atHostTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeControlStatus = "timeControlStatus";

	private static readonly IntPtr selTimeControlStatusHandle = Selector.GetHandle("timeControlStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EligibleForHdrPlaybackDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WaitingToMinimizeStallsReason;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WaitingWhileEvaluatingBufferingRateReason;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WaitingWithNoItemToPlayReason;

	public AVLayerVideoGravity? ExternalPlaybackVideoGravity
	{
		get
		{
			AVLayerVideoGravity aVLayerVideoGravity = AVPlayerLayer.KeyToEnum(WeakExternalPlaybackVideoGravity, clamp: false);
			if (aVLayerVideoGravity == (AVLayerVideoGravity)(-1))
			{
				return null;
			}
			return aVLayerVideoGravity;
		}
		set
		{
			WeakExternalPlaybackVideoGravity = (value.HasValue ? AVPlayerLayer.EnumToKey(value.Value) : null);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerActionAtItemEnd ActionAtItemEnd
	{
		[Export("actionAtItemEnd")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVPlayerActionAtItemEnd)Messaging.Int64_objc_msgSend(base.Handle, selActionAtItemEndHandle);
			}
			return (AVPlayerActionAtItemEnd)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selActionAtItemEndHandle);
		}
		[Export("setActionAtItemEnd:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetActionAtItemEnd_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetActionAtItemEnd_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool AllowsExternalPlayback
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("allowsExternalPlayback")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsExternalPlaybackHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsExternalPlaybackHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAllowsExternalPlayback:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsExternalPlayback_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsExternalPlayback_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool AppliesMediaSelectionCriteriaAutomatically
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("appliesMediaSelectionCriteriaAutomatically")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAppliesMediaSelectionCriteriaAutomaticallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAppliesMediaSelectionCriteriaAutomaticallyHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAppliesMediaSelectionCriteriaAutomatically:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAppliesMediaSelectionCriteriaAutomatically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAppliesMediaSelectionCriteriaAutomatically_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string? AudioOutputDeviceUniqueID
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("audioOutputDeviceUniqueID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioOutputDeviceUniqueIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioOutputDeviceUniqueIDHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAudioOutputDeviceUniqueID:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioOutputDeviceUniqueID_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioOutputDeviceUniqueID_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool AutomaticallyWaitsToMinimizeStalling
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("automaticallyWaitsToMinimizeStalling")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyWaitsToMinimizeStallingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyWaitsToMinimizeStallingHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setAutomaticallyWaitsToMinimizeStalling:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyWaitsToMinimizeStalling_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyWaitsToMinimizeStalling_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	public virtual bool ClosedCaptionDisplayEnabled
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
		[Export("isClosedCaptionDisplayEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsClosedCaptionDisplayEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsClosedCaptionDisplayEnabledHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
		[Export("setClosedCaptionDisplayEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetClosedCaptionDisplayEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetClosedCaptionDisplayEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItem? CurrentItem
	{
		[Export("currentItem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVPlayerItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentItemHandle));
			}
			return Runtime.GetNSObject<AVPlayerItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime CurrentTime
	{
		[Export("currentTime")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selCurrentTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCurrentTimeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	public static bool EligibleForHdrPlayback
	{
		[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
		[Export("eligibleForHDRPlayback")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selEligibleForHDRPlaybackHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool ExternalPlaybackActive
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("isExternalPlaybackActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExternalPlaybackActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExternalPlaybackActiveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMClock? MasterClock
	{
		[Export("masterClock")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMasterClockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selMasterClockHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMClock(intPtr);
		}
		[Export("setMasterClock:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMasterClock_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMasterClock_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual bool Muted
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("isMuted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMutedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMutedHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool OutputObscuredDueToInsufficientExternalProtection
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("outputObscuredDueToInsufficientExternalProtection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selOutputObscuredDueToInsufficientExternalProtectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selOutputObscuredDueToInsufficientExternalProtectionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	public virtual ulong PreferredVideoDecoderGpuRegistryId
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Export("preferredVideoDecoderGPURegistryID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selPreferredVideoDecoderGPURegistryIDHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPreferredVideoDecoderGPURegistryIDHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Export("setPreferredVideoDecoderGPURegistryID:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPreferredVideoDecoderGPURegistryID_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPreferredVideoDecoderGPURegistryID_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual bool PreventsDisplaySleepDuringVideoPlayback
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("preventsDisplaySleepDuringVideoPlayback")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreventsDisplaySleepDuringVideoPlaybackHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreventsDisplaySleepDuringVideoPlaybackHandle);
		}
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setPreventsDisplaySleepDuringVideoPlayback:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreventsDisplaySleepDuringVideoPlayback_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreventsDisplaySleepDuringVideoPlayback_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string? ReasonForWaitingToPlay
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("reasonForWaitingToPlay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReasonForWaitingToPlayHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReasonForWaitingToPlayHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVPlayerStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVPlayerStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual AVPlayerTimeControlStatus TimeControlStatus
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("timeControlStatus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVPlayerTimeControlStatus)Messaging.Int64_objc_msgSend(base.Handle, selTimeControlStatusHandle);
			}
			return (AVPlayerTimeControlStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTimeControlStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual float Volume
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("volume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	protected virtual NSString WeakExternalPlaybackVideoGravity
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("externalPlaybackVideoGravity", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selExternalPlaybackVideoGravityHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExternalPlaybackVideoGravityHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setExternalPlaybackVideoGravity:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExternalPlaybackVideoGravity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExternalPlaybackVideoGravity_Handle, value.Handle);
			}
		}
	}

	[Field("AVPlayerEligibleForHDRPlaybackDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	[Advice("Use AVPlayer.Notifications.ObserveEligibleForHdrPlaybackDidChange helper method instead.")]
	public static NSString EligibleForHdrPlaybackDidChangeNotification
	{
		[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
		get
		{
			if (_EligibleForHdrPlaybackDidChangeNotification == null)
			{
				_EligibleForHdrPlaybackDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerEligibleForHDRPlaybackDidChangeNotification");
			}
			return _EligibleForHdrPlaybackDidChangeNotification;
		}
	}

	[Field("AVPlayerWaitingToMinimizeStallsReason", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString WaitingToMinimizeStallsReason
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_WaitingToMinimizeStallsReason == null)
			{
				_WaitingToMinimizeStallsReason = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerWaitingToMinimizeStallsReason");
			}
			return _WaitingToMinimizeStallsReason;
		}
	}

	[Field("AVPlayerWaitingWhileEvaluatingBufferingRateReason", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString WaitingWhileEvaluatingBufferingRateReason
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_WaitingWhileEvaluatingBufferingRateReason == null)
			{
				_WaitingWhileEvaluatingBufferingRateReason = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerWaitingWhileEvaluatingBufferingRateReason");
			}
			return _WaitingWhileEvaluatingBufferingRateReason;
		}
	}

	[Field("AVPlayerWaitingWithNoItemToPlayReason", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString WaitingWithNoItemToPlayReason
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_WaitingWithNoItemToPlayReason == null)
			{
				_WaitingWithNoItemToPlayReason = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerWaitingWithNoItemToPlayReason");
			}
			return _WaitingWithNoItemToPlayReason;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayer()
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
	protected AVPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayer(NSUrl URL)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, URL.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, URL.Handle), "initWithURL:");
		}
	}

	[Export("initWithPlayerItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayer(AVPlayerItem? item)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPlayerItem_Handle, item?.Handle ?? IntPtr.Zero), "initWithPlayerItem:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPlayerItem_Handle, item?.Handle ?? IntPtr.Zero), "initWithPlayerItem:");
		}
	}

	[Export("addBoundaryTimeObserverForTimes:queue:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSObject AddBoundaryTimeObserver(NSValue[] times, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects(times);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_Handle, nSArray.Handle, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddBoundaryTimeObserverForTimes_Queue_UsingBlock_Handle, nSArray.Handle, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)));
		nSArray.Dispose();
		ptr->CleanupBlock();
		return result;
	}

	[Export("addPeriodicTimeObserverForInterval:queue:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSObject AddPeriodicTimeObserver(CMTime interval, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDActionArity1V5))] Action<CMTime> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V5.Handler, handler);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr(base.SuperHandle, selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_Handle, interval, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr(base.Handle, selAddPeriodicTimeObserverForInterval_Queue_UsingBlock_Handle, interval, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Export("cancelPendingPrerolls")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelPendingPrerolls()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelPendingPrerollsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelPendingPrerollsHandle);
		}
	}

	[Export("playerWithPlayerItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayer FromPlayerItem(AVPlayerItem? item)
	{
		return Runtime.GetNSObject<AVPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerWithPlayerItem_Handle, item?.Handle ?? IntPtr.Zero));
	}

	[Export("playerWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayer FromUrl(NSUrl URL)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		return Runtime.GetNSObject<AVPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerWithURL_Handle, URL.Handle));
	}

	[Export("mediaSelectionCriteriaForMediaCharacteristic:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerMediaSelectionCriteria? MediaSelectionCriteriaForMediaCharacteristic(NSString avMediaCharacteristic)
	{
		if (avMediaCharacteristic == null)
		{
			throw new ArgumentNullException("avMediaCharacteristic");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVPlayerMediaSelectionCriteria>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaSelectionCriteriaForMediaCharacteristic_Handle, avMediaCharacteristic.Handle));
		}
		return Runtime.GetNSObject<AVPlayerMediaSelectionCriteria>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaSelectionCriteriaForMediaCharacteristic_Handle, avMediaCharacteristic.Handle));
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

	[Export("playImmediatelyAtRate:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PlayImmediatelyAtRate(float rate)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float(base.Handle, selPlayImmediatelyAtRate_Handle, rate);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selPlayImmediatelyAtRate_Handle, rate);
		}
	}

	[Export("prerollAtRate:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Preroll(float rate, [BlockProxy(typeof(Trampolines.NIDAVCompletion))] AVCompletion onComplete)
	{
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVCompletion.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selPrerollAtRate_CompletionHandler_Handle, rate, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selPrerollAtRate_CompletionHandler_Handle, rate, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> PrerollAsync(float rate)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Preroll(rate, delegate(bool finished_)
		{
			tcs.SetResult(finished_);
		});
		return tcs.Task;
	}

	[Export("removeTimeObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTimeObserver(NSObject observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTimeObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTimeObserver_Handle, observer.Handle);
		}
	}

	[Export("replaceCurrentItemWithPlayerItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceCurrentItemWithPlayerItem(AVPlayerItem? item)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceCurrentItemWithPlayerItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceCurrentItemWithPlayerItem_Handle, item?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("seekToTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Seek(CMTime toTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selSeekToTime_Handle, toTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSeekToTime_Handle, toTime);
		}
	}

	[Export("seekToTime:toleranceBefore:toleranceAfter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Seek(CMTime toTime, CMTime toleranceBefore, CMTime toleranceAfter)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_CMTime_CMTime(base.Handle, selSeekToTime_ToleranceBefore_ToleranceAfter_Handle, toTime, toleranceBefore, toleranceAfter);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime(base.SuperHandle, selSeekToTime_ToleranceBefore_ToleranceAfter_Handle, toTime, toleranceBefore, toleranceAfter);
		}
	}

	[Export("seekToTime:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Seek(CMTime time, [BlockProxy(typeof(Trampolines.NIDAVCompletion))] AVCompletion completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVCompletion.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_IntPtr(base.Handle, selSeekToTime_CompletionHandler_Handle, time, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_IntPtr(base.SuperHandle, selSeekToTime_CompletionHandler_Handle, time, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> SeekAsync(CMTime time)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Seek(time, delegate(bool finished_)
		{
			tcs.SetResult(finished_);
		});
		return tcs.Task;
	}

	[Export("seekToTime:toleranceBefore:toleranceAfter:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Seek(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter, [BlockProxy(typeof(Trampolines.NIDAVCompletion))] AVCompletion completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVCompletion.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_CMTime_CMTime_IntPtr(base.Handle, selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_Handle, time, toleranceBefore, toleranceAfter, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime_IntPtr(base.SuperHandle, selSeekToTime_ToleranceBefore_ToleranceAfter_CompletionHandler_Handle, time, toleranceBefore, toleranceAfter, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> SeekAsync(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Seek(time, toleranceBefore, toleranceAfter, delegate(bool finished_)
		{
			tcs.SetResult(finished_);
		});
		return tcs.Task;
	}

	[Export("seekToDate:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Seek(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSeekToDate_Handle, date.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSeekToDate_Handle, date.Handle);
		}
	}

	[Export("seekToDate:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Seek(NSDate date, [BlockProxy(typeof(Trampolines.NIDAVCompletion))] AVCompletion onComplete)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVCompletion.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSeekToDate_CompletionHandler_Handle, date.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSeekToDate_CompletionHandler_Handle, date.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> SeekAsync(NSDate date)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Seek(date, delegate(bool finished_)
		{
			tcs.SetResult(finished_);
		});
		return tcs.Task;
	}

	[Export("setMediaSelectionCriteria:forMediaCharacteristic:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMediaSelectionCriteria(AVPlayerMediaSelectionCriteria? criteria, NSString avMediaCharacteristic)
	{
		if (avMediaCharacteristic == null)
		{
			throw new ArgumentNullException("avMediaCharacteristic");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetMediaSelectionCriteria_ForMediaCharacteristic_Handle, criteria?.Handle ?? IntPtr.Zero, avMediaCharacteristic.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetMediaSelectionCriteria_ForMediaCharacteristic_Handle, criteria?.Handle ?? IntPtr.Zero, avMediaCharacteristic.Handle);
		}
	}

	[Export("setRate:time:atHostTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRate(float rate, CMTime itemTime, CMTime hostClockTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CMTime_CMTime(base.Handle, selSetRate_Time_AtHostTime_Handle, rate, itemTime, hostClockTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CMTime_CMTime(base.SuperHandle, selSetRate_Time_AtHostTime_Handle, rate, itemTime, hostClockTime);
		}
	}
}
