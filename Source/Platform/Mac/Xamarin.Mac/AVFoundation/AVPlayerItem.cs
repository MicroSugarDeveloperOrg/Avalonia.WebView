using System.ComponentModel;
using System.Threading.Tasks;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVPlayerItem", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVPlayerItem : NSObject, INSCopying, INativeObject, IDisposable
{
	public static class Notifications
	{
		public static NSObject ObserveDidPlayToEndTime(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidPlayToEndTimeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidPlayToEndTime(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidPlayToEndTimeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveItemFailedToPlayToEndTime(EventHandler<AVPlayerItemErrorEventArgs> handler)
		{
			EventHandler<AVPlayerItemErrorEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemFailedToPlayToEndTimeNotification, delegate(NSNotification notification)
			{
				handler2(null, new AVPlayerItemErrorEventArgs(notification));
			});
		}

		public static NSObject ObserveItemFailedToPlayToEndTime(NSObject objectToObserve, EventHandler<AVPlayerItemErrorEventArgs> handler)
		{
			EventHandler<AVPlayerItemErrorEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemFailedToPlayToEndTimeNotification, delegate(NSNotification notification)
			{
				handler2(null, new AVPlayerItemErrorEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveMediaSelectionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MediaSelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMediaSelectionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MediaSelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveNewAccessLogEntry(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NewAccessLogEntryNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveNewAccessLogEntry(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NewAccessLogEntryNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveNewErrorLogEntry(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NewErrorLogEntryNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveNewErrorLogEntry(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(NewErrorLogEntryNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObservePlaybackStalled(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PlaybackStalledNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObservePlaybackStalled(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PlaybackStalledNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveRecommendedTimeOffsetFromLiveDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RecommendedTimeOffsetFromLiveDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRecommendedTimeOffsetFromLiveDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RecommendedTimeOffsetFromLiveDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTimeJumped(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeJumpedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveTimeJumped(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeJumpedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessLog = "accessLog";

	private static readonly IntPtr selAccessLogHandle = Selector.GetHandle("accessLog");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMediaDataCollector_ = "addMediaDataCollector:";

	private static readonly IntPtr selAddMediaDataCollector_Handle = Selector.GetHandle("addMediaDataCollector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOutput_ = "addOutput:";

	private static readonly IntPtr selAddOutput_Handle = Selector.GetHandle("addOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAsset = "asset";

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioMix = "audioMix";

	private static readonly IntPtr selAudioMixHandle = Selector.GetHandle("audioMix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTimePitchAlgorithm = "audioTimePitchAlgorithm";

	private static readonly IntPtr selAudioTimePitchAlgorithmHandle = Selector.GetHandle("audioTimePitchAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyLoadedAssetKeys = "automaticallyLoadedAssetKeys";

	private static readonly IntPtr selAutomaticallyLoadedAssetKeysHandle = Selector.GetHandle("automaticallyLoadedAssetKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyPreservesTimeOffsetFromLive = "automaticallyPreservesTimeOffsetFromLive";

	private static readonly IntPtr selAutomaticallyPreservesTimeOffsetFromLiveHandle = Selector.GetHandle("automaticallyPreservesTimeOffsetFromLive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPlayFastForward = "canPlayFastForward";

	private static readonly IntPtr selCanPlayFastForwardHandle = Selector.GetHandle("canPlayFastForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPlayFastReverse = "canPlayFastReverse";

	private static readonly IntPtr selCanPlayFastReverseHandle = Selector.GetHandle("canPlayFastReverse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPlayReverse = "canPlayReverse";

	private static readonly IntPtr selCanPlayReverseHandle = Selector.GetHandle("canPlayReverse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPlaySlowForward = "canPlaySlowForward";

	private static readonly IntPtr selCanPlaySlowForwardHandle = Selector.GetHandle("canPlaySlowForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPlaySlowReverse = "canPlaySlowReverse";

	private static readonly IntPtr selCanPlaySlowReverseHandle = Selector.GetHandle("canPlaySlowReverse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanStepBackward = "canStepBackward";

	private static readonly IntPtr selCanStepBackwardHandle = Selector.GetHandle("canStepBackward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanStepForward = "canStepForward";

	private static readonly IntPtr selCanStepForwardHandle = Selector.GetHandle("canStepForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanUseNetworkResourcesForLiveStreamingWhilePaused = "canUseNetworkResourcesForLiveStreamingWhilePaused";

	private static readonly IntPtr selCanUseNetworkResourcesForLiveStreamingWhilePausedHandle = Selector.GetHandle("canUseNetworkResourcesForLiveStreamingWhilePaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelPendingSeeks = "cancelPendingSeeks";

	private static readonly IntPtr selCancelPendingSeeksHandle = Selector.GetHandle("cancelPendingSeeks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguredTimeOffsetFromLive = "configuredTimeOffsetFromLive";

	private static readonly IntPtr selConfiguredTimeOffsetFromLiveHandle = Selector.GetHandle("configuredTimeOffsetFromLive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDate = "currentDate";

	private static readonly IntPtr selCurrentDateHandle = Selector.GetHandle("currentDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentMediaSelection = "currentMediaSelection";

	private static readonly IntPtr selCurrentMediaSelectionHandle = Selector.GetHandle("currentMediaSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomVideoCompositor = "customVideoCompositor";

	private static readonly IntPtr selCustomVideoCompositorHandle = Selector.GetHandle("customVideoCompositor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selErrorLog = "errorLog";

	private static readonly IntPtr selErrorLogHandle = Selector.GetHandle("errorLog");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForwardPlaybackEndTime = "forwardPlaybackEndTime";

	private static readonly IntPtr selForwardPlaybackEndTimeHandle = Selector.GetHandle("forwardPlaybackEndTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_ = "initWithAsset:";

	private static readonly IntPtr selInitWithAsset_Handle = Selector.GetHandle("initWithAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_AutomaticallyLoadedAssetKeys_ = "initWithAsset:automaticallyLoadedAssetKeys:";

	private static readonly IntPtr selInitWithAsset_AutomaticallyLoadedAssetKeys_Handle = Selector.GetHandle("initWithAsset:automaticallyLoadedAssetKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAudioSpatializationAllowed = "isAudioSpatializationAllowed";

	private static readonly IntPtr selIsAudioSpatializationAllowedHandle = Selector.GetHandle("isAudioSpatializationAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaybackBufferEmpty = "isPlaybackBufferEmpty";

	private static readonly IntPtr selIsPlaybackBufferEmptyHandle = Selector.GetHandle("isPlaybackBufferEmpty");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaybackBufferFull = "isPlaybackBufferFull";

	private static readonly IntPtr selIsPlaybackBufferFullHandle = Selector.GetHandle("isPlaybackBufferFull");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaybackLikelyToKeepUp = "isPlaybackLikelyToKeepUp";

	private static readonly IntPtr selIsPlaybackLikelyToKeepUpHandle = Selector.GetHandle("isPlaybackLikelyToKeepUp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadedTimeRanges = "loadedTimeRanges";

	private static readonly IntPtr selLoadedTimeRangesHandle = Selector.GetHandle("loadedTimeRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaDataCollectors = "mediaDataCollectors";

	private static readonly IntPtr selMediaDataCollectorsHandle = Selector.GetHandle("mediaDataCollectors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputs = "outputs";

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerItemWithAsset_ = "playerItemWithAsset:";

	private static readonly IntPtr selPlayerItemWithAsset_Handle = Selector.GetHandle("playerItemWithAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerItemWithAsset_AutomaticallyLoadedAssetKeys_ = "playerItemWithAsset:automaticallyLoadedAssetKeys:";

	private static readonly IntPtr selPlayerItemWithAsset_AutomaticallyLoadedAssetKeys_Handle = Selector.GetHandle("playerItemWithAsset:automaticallyLoadedAssetKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerItemWithURL_ = "playerItemWithURL:";

	private static readonly IntPtr selPlayerItemWithURL_Handle = Selector.GetHandle("playerItemWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredForwardBufferDuration = "preferredForwardBufferDuration";

	private static readonly IntPtr selPreferredForwardBufferDurationHandle = Selector.GetHandle("preferredForwardBufferDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMaximumResolution = "preferredMaximumResolution";

	private static readonly IntPtr selPreferredMaximumResolutionHandle = Selector.GetHandle("preferredMaximumResolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredPeakBitRate = "preferredPeakBitRate";

	private static readonly IntPtr selPreferredPeakBitRateHandle = Selector.GetHandle("preferredPeakBitRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationSize = "presentationSize";

	private static readonly IntPtr selPresentationSizeHandle = Selector.GetHandle("presentationSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecommendedTimeOffsetFromLive = "recommendedTimeOffsetFromLive";

	private static readonly IntPtr selRecommendedTimeOffsetFromLiveHandle = Selector.GetHandle("recommendedTimeOffsetFromLive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveMediaDataCollector_ = "removeMediaDataCollector:";

	private static readonly IntPtr selRemoveMediaDataCollector_Handle = Selector.GetHandle("removeMediaDataCollector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveOutput_ = "removeOutput:";

	private static readonly IntPtr selRemoveOutput_Handle = Selector.GetHandle("removeOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReversePlaybackEndTime = "reversePlaybackEndTime";

	private static readonly IntPtr selReversePlaybackEndTimeHandle = Selector.GetHandle("reversePlaybackEndTime");

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
	private const string selSeekableTimeRanges = "seekableTimeRanges";

	private static readonly IntPtr selSeekableTimeRangesHandle = Selector.GetHandle("seekableTimeRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekingWaitsForVideoCompositionRendering = "seekingWaitsForVideoCompositionRendering";

	private static readonly IntPtr selSeekingWaitsForVideoCompositionRenderingHandle = Selector.GetHandle("seekingWaitsForVideoCompositionRendering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectMediaOption_InMediaSelectionGroup_ = "selectMediaOption:inMediaSelectionGroup:";

	private static readonly IntPtr selSelectMediaOption_InMediaSelectionGroup_Handle = Selector.GetHandle("selectMediaOption:inMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectMediaOptionAutomaticallyInMediaSelectionGroup_ = "selectMediaOptionAutomaticallyInMediaSelectionGroup:";

	private static readonly IntPtr selSelectMediaOptionAutomaticallyInMediaSelectionGroup_Handle = Selector.GetHandle("selectMediaOptionAutomaticallyInMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedMediaOptionInMediaSelectionGroup_ = "selectedMediaOptionInMediaSelectionGroup:";

	private static readonly IntPtr selSelectedMediaOptionInMediaSelectionGroup_Handle = Selector.GetHandle("selectedMediaOptionInMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioMix_ = "setAudioMix:";

	private static readonly IntPtr selSetAudioMix_Handle = Selector.GetHandle("setAudioMix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioSpatializationAllowed_ = "setAudioSpatializationAllowed:";

	private static readonly IntPtr selSetAudioSpatializationAllowed_Handle = Selector.GetHandle("setAudioSpatializationAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioTimePitchAlgorithm_ = "setAudioTimePitchAlgorithm:";

	private static readonly IntPtr selSetAudioTimePitchAlgorithm_Handle = Selector.GetHandle("setAudioTimePitchAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyPreservesTimeOffsetFromLive_ = "setAutomaticallyPreservesTimeOffsetFromLive:";

	private static readonly IntPtr selSetAutomaticallyPreservesTimeOffsetFromLive_Handle = Selector.GetHandle("setAutomaticallyPreservesTimeOffsetFromLive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_ = "setCanUseNetworkResourcesForLiveStreamingWhilePaused:";

	private static readonly IntPtr selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_Handle = Selector.GetHandle("setCanUseNetworkResourcesForLiveStreamingWhilePaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConfiguredTimeOffsetFromLive_ = "setConfiguredTimeOffsetFromLive:";

	private static readonly IntPtr selSetConfiguredTimeOffsetFromLive_Handle = Selector.GetHandle("setConfiguredTimeOffsetFromLive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForwardPlaybackEndTime_ = "setForwardPlaybackEndTime:";

	private static readonly IntPtr selSetForwardPlaybackEndTime_Handle = Selector.GetHandle("setForwardPlaybackEndTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredForwardBufferDuration_ = "setPreferredForwardBufferDuration:";

	private static readonly IntPtr selSetPreferredForwardBufferDuration_Handle = Selector.GetHandle("setPreferredForwardBufferDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMaximumResolution_ = "setPreferredMaximumResolution:";

	private static readonly IntPtr selSetPreferredMaximumResolution_Handle = Selector.GetHandle("setPreferredMaximumResolution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredPeakBitRate_ = "setPreferredPeakBitRate:";

	private static readonly IntPtr selSetPreferredPeakBitRate_Handle = Selector.GetHandle("setPreferredPeakBitRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReversePlaybackEndTime_ = "setReversePlaybackEndTime:";

	private static readonly IntPtr selSetReversePlaybackEndTime_Handle = Selector.GetHandle("setReversePlaybackEndTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSeekingWaitsForVideoCompositionRendering_ = "setSeekingWaitsForVideoCompositionRendering:";

	private static readonly IntPtr selSetSeekingWaitsForVideoCompositionRendering_Handle = Selector.GetHandle("setSeekingWaitsForVideoCompositionRendering:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextStyleRules_ = "setTextStyleRules:";

	private static readonly IntPtr selSetTextStyleRules_Handle = Selector.GetHandle("setTextStyleRules:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoApertureMode_ = "setVideoApertureMode:";

	private static readonly IntPtr selSetVideoApertureMode_Handle = Selector.GetHandle("setVideoApertureMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoComposition_ = "setVideoComposition:";

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepByCount_ = "stepByCount:";

	private static readonly IntPtr selStepByCount_Handle = Selector.GetHandle("stepByCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStyleRules = "textStyleRules";

	private static readonly IntPtr selTextStyleRulesHandle = Selector.GetHandle("textStyleRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimebase = "timebase";

	private static readonly IntPtr selTimebaseHandle = Selector.GetHandle("timebase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimedMetadata = "timedMetadata";

	private static readonly IntPtr selTimedMetadataHandle = Selector.GetHandle("timedMetadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoApertureMode = "videoApertureMode";

	private static readonly IntPtr selVideoApertureModeHandle = Selector.GetHandle("videoApertureMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoComposition = "videoComposition";

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidPlayToEndTimeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemFailedToPlayToEndTimeErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemFailedToPlayToEndTimeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSelectionDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NewAccessLogEntryNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NewErrorLogEntryNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaybackStalledNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RecommendedTimeOffsetFromLiveDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeJumpedNotification;

	[TV(11, 0)]
	[NoWatch]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public AVVideoApertureMode VideoApertureMode
	{
		get
		{
			return AVVideoApertureModeExtensions.GetValue(_VideoApertureMode);
		}
		set
		{
			_VideoApertureMode = value.GetConstant();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItemAccessLog? AccessLog
	{
		[Export("accessLog")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVPlayerItemAccessLog>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessLogHandle));
			}
			return Runtime.GetNSObject<AVPlayerItemAccessLog>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessLogHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAsset Asset
	{
		[Export("asset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle));
			}
			return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioMix? AudioMix
	{
		[Export("audioMix", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioMix>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioMixHandle));
			}
			return Runtime.GetNSObject<AVAudioMix>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioMixHandle));
		}
		[Export("setAudioMix:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioMix_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioMix_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool AudioSpatializationAllowed
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isAudioSpatializationAllowed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAudioSpatializationAllowedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAudioSpatializationAllowedHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setAudioSpatializationAllowed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAudioSpatializationAllowed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAudioSpatializationAllowed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSString AudioTimePitchAlgorithm
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("audioTimePitchAlgorithm", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioTimePitchAlgorithmHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioTimePitchAlgorithmHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAudioTimePitchAlgorithm:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioTimePitchAlgorithm_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioTimePitchAlgorithm_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSString[] AutomaticallyLoadedAssetKeys
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("automaticallyLoadedAssetKeys", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAutomaticallyLoadedAssetKeysHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutomaticallyLoadedAssetKeysHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool AutomaticallyPreservesTimeOffsetFromLive
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("automaticallyPreservesTimeOffsetFromLive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyPreservesTimeOffsetFromLiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyPreservesTimeOffsetFromLiveHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setAutomaticallyPreservesTimeOffsetFromLive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyPreservesTimeOffsetFromLive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyPreservesTimeOffsetFromLive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPlayFastForward
	{
		[Export("canPlayFastForward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlayFastForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlayFastForwardHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPlayFastReverse
	{
		[Export("canPlayFastReverse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlayFastReverseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlayFastReverseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPlayReverse
	{
		[Export("canPlayReverse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlayReverseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlayReverseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPlaySlowForward
	{
		[Export("canPlaySlowForward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlaySlowForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlaySlowForwardHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPlaySlowReverse
	{
		[Export("canPlaySlowReverse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlaySlowReverseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlaySlowReverseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanStepBackward
	{
		[Export("canStepBackward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanStepBackwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanStepBackwardHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanStepForward
	{
		[Export("canStepForward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanStepForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanStepForwardHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool CanUseNetworkResourcesForLiveStreamingWhilePaused
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("canUseNetworkResourcesForLiveStreamingWhilePaused")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanUseNetworkResourcesForLiveStreamingWhilePausedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanUseNetworkResourcesForLiveStreamingWhilePausedHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setCanUseNetworkResourcesForLiveStreamingWhilePaused:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanUseNetworkResourcesForLiveStreamingWhilePaused_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual CMTime ConfiguredTimeOffsetFromLive
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("configuredTimeOffsetFromLive", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selConfiguredTimeOffsetFromLiveHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selConfiguredTimeOffsetFromLiveHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setConfiguredTimeOffsetFromLive:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetConfiguredTimeOffsetFromLive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetConfiguredTimeOffsetFromLive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? CurrentDate
	{
		[Export("currentDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual AVMediaSelection CurrentMediaSelection
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("currentMediaSelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMediaSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentMediaSelectionHandle));
			}
			return Runtime.GetNSObject<AVMediaSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentMediaSelectionHandle));
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual IAVVideoCompositing? CustomVideoCompositor
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("customVideoCompositor", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IAVVideoCompositing>(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomVideoCompositorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IAVVideoCompositing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomVideoCompositorHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
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
	public virtual AVPlayerItemErrorLog? ErrorLog
	{
		[Export("errorLog")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVPlayerItemErrorLog>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorLogHandle));
			}
			return Runtime.GetNSObject<AVPlayerItemErrorLog>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorLogHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime ForwardPlaybackEndTime
	{
		[Export("forwardPlaybackEndTime")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selForwardPlaybackEndTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selForwardPlaybackEndTimeHandle);
			}
			return retval;
		}
		[Export("setForwardPlaybackEndTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetForwardPlaybackEndTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetForwardPlaybackEndTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSValue[] LoadedTimeRanges
	{
		[Export("loadedTimeRanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selLoadedTimeRangesHandle));
			}
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLoadedTimeRangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	public virtual AVPlayerItemMediaDataCollector[] MediaDataCollectors
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Export("mediaDataCollectors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVPlayerItemMediaDataCollector>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaDataCollectorsHandle));
			}
			return NSArray.ArrayFromHandle<AVPlayerItemMediaDataCollector>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaDataCollectorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItemOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVPlayerItemOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle));
			}
			return NSArray.ArrayFromHandle<AVPlayerItemOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PlaybackBufferEmpty
	{
		[Export("isPlaybackBufferEmpty")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlaybackBufferEmptyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlaybackBufferEmptyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PlaybackBufferFull
	{
		[Export("isPlaybackBufferFull")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlaybackBufferFullHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlaybackBufferFullHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PlaybackLikelyToKeepUp
	{
		[Export("isPlaybackLikelyToKeepUp")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlaybackLikelyToKeepUpHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlaybackLikelyToKeepUpHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual double PreferredForwardBufferDuration
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("preferredForwardBufferDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPreferredForwardBufferDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPreferredForwardBufferDurationHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setPreferredForwardBufferDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPreferredForwardBufferDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPreferredForwardBufferDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual CGSize PreferredMaximumResolution
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("preferredMaximumResolution", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredMaximumResolutionHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredMaximumResolutionHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setPreferredMaximumResolution:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetPreferredMaximumResolution_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetPreferredMaximumResolution_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual double PreferredPeakBitRate
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredPeakBitRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPreferredPeakBitRateHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPreferredPeakBitRateHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setPreferredPeakBitRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPreferredPeakBitRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPreferredPeakBitRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize PresentationSize
	{
		[Export("presentationSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPresentationSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPresentationSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual CMTime RecommendedTimeOffsetFromLive
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("recommendedTimeOffsetFromLive")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selRecommendedTimeOffsetFromLiveHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRecommendedTimeOffsetFromLiveHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime ReversePlaybackEndTime
	{
		[Export("reversePlaybackEndTime")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selReversePlaybackEndTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selReversePlaybackEndTimeHandle);
			}
			return retval;
		}
		[Export("setReversePlaybackEndTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetReversePlaybackEndTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetReversePlaybackEndTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSValue[] SeekableTimeRanges
	{
		[Export("seekableTimeRanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selSeekableTimeRangesHandle));
			}
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSeekableTimeRangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool SeekingWaitsForVideoCompositionRendering
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("seekingWaitsForVideoCompositionRendering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSeekingWaitsForVideoCompositionRenderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSeekingWaitsForVideoCompositionRenderingHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setSeekingWaitsForVideoCompositionRendering:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSeekingWaitsForVideoCompositionRendering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSeekingWaitsForVideoCompositionRendering_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItemStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVPlayerItemStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVPlayerItemStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVTextStyleRule[]? TextStyleRules
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("textStyleRules", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVTextStyleRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextStyleRulesHandle));
			}
			return NSArray.ArrayFromHandle<AVTextStyleRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextStyleRulesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setTextStyleRules:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextStyleRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextStyleRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTimebase? Timebase
	{
		[Export("timebase")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimebaseHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selTimebaseHandle));
			return (intPtr == IntPtr.Zero) ? null : new CMTimebase(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
	public virtual NSObject[]? TimedMetadata
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the class 'AVPlayerItemMetadataOutput' instead to get the time metadata info.")]
		[Export("timedMetadata")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimedMetadataHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimedMetadataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItemTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVPlayerItemTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVPlayerItemTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVVideoComposition? VideoComposition
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("videoComposition", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionHandle));
			}
			return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setVideoComposition:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoComposition_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoComposition_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	internal virtual NSString _VideoApertureMode
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("videoApertureMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoApertureModeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoApertureModeHandle));
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setVideoApertureMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoApertureMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoApertureMode_Handle, value.Handle);
			}
		}
	}

	[Field("AVPlayerItemDidPlayToEndTimeNotification", "AVFoundation")]
	[Advice("Use AVPlayerItem.Notifications.ObserveDidPlayToEndTime helper method instead.")]
	public static NSString DidPlayToEndTimeNotification
	{
		get
		{
			if (_DidPlayToEndTimeNotification == null)
			{
				_DidPlayToEndTimeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemDidPlayToEndTimeNotification");
			}
			return _DidPlayToEndTimeNotification;
		}
	}

	[Field("AVPlayerItemFailedToPlayToEndTimeErrorKey", "AVFoundation")]
	public static NSString ItemFailedToPlayToEndTimeErrorKey
	{
		get
		{
			if (_ItemFailedToPlayToEndTimeErrorKey == null)
			{
				_ItemFailedToPlayToEndTimeErrorKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemFailedToPlayToEndTimeErrorKey");
			}
			return _ItemFailedToPlayToEndTimeErrorKey;
		}
	}

	[Field("AVPlayerItemFailedToPlayToEndTimeNotification", "AVFoundation")]
	[Advice("Use AVPlayerItem.Notifications.ObserveItemFailedToPlayToEndTime helper method instead.")]
	public static NSString ItemFailedToPlayToEndTimeNotification
	{
		get
		{
			if (_ItemFailedToPlayToEndTimeNotification == null)
			{
				_ItemFailedToPlayToEndTimeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemFailedToPlayToEndTimeNotification");
			}
			return _ItemFailedToPlayToEndTimeNotification;
		}
	}

	[Field("AVPlayerItemMediaSelectionDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVPlayerItem.Notifications.ObserveMediaSelectionDidChange helper method instead.")]
	public static NSString MediaSelectionDidChangeNotification
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MediaSelectionDidChangeNotification == null)
			{
				_MediaSelectionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemMediaSelectionDidChangeNotification");
			}
			return _MediaSelectionDidChangeNotification;
		}
	}

	[Field("AVPlayerItemNewAccessLogEntryNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use AVPlayerItem.Notifications.ObserveNewAccessLogEntry helper method instead.")]
	public static NSString NewAccessLogEntryNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_NewAccessLogEntryNotification == null)
			{
				_NewAccessLogEntryNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemNewAccessLogEntryNotification");
			}
			return _NewAccessLogEntryNotification;
		}
	}

	[Field("AVPlayerItemNewErrorLogEntryNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use AVPlayerItem.Notifications.ObserveNewErrorLogEntry helper method instead.")]
	public static NSString NewErrorLogEntryNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_NewErrorLogEntryNotification == null)
			{
				_NewErrorLogEntryNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemNewErrorLogEntryNotification");
			}
			return _NewErrorLogEntryNotification;
		}
	}

	[Field("AVPlayerItemPlaybackStalledNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Advice("Use AVPlayerItem.Notifications.ObservePlaybackStalled helper method instead.")]
	public static NSString PlaybackStalledNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_PlaybackStalledNotification == null)
			{
				_PlaybackStalledNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemPlaybackStalledNotification");
			}
			return _PlaybackStalledNotification;
		}
	}

	[Field("AVPlayerItemRecommendedTimeOffsetFromLiveDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVPlayerItem.Notifications.ObserveRecommendedTimeOffsetFromLiveDidChange helper method instead.")]
	public static NSString RecommendedTimeOffsetFromLiveDidChangeNotification
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RecommendedTimeOffsetFromLiveDidChangeNotification == null)
			{
				_RecommendedTimeOffsetFromLiveDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemRecommendedTimeOffsetFromLiveDidChangeNotification");
			}
			return _RecommendedTimeOffsetFromLiveDidChangeNotification;
		}
	}

	[Field("AVPlayerItemTimeJumpedNotification", "AVFoundation")]
	[Advice("Use AVPlayerItem.Notifications.ObserveTimeJumped helper method instead.")]
	public static NSString TimeJumpedNotification
	{
		get
		{
			if (_TimeJumpedNotification == null)
			{
				_TimeJumpedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVPlayerItemTimeJumpedNotification");
			}
			return _TimeJumpedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPlayerItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItem(NSUrl URL)
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

	[Export("initWithAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItem(AVAsset asset)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAsset_Handle, asset.Handle), "initWithAsset:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAsset_Handle, asset.Handle), "initWithAsset:");
		}
	}

	[Export("initWithAsset:automaticallyLoadedAssetKeys:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItem(AVAsset asset, params NSString[]? automaticallyLoadedAssetKeys)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		NSArray nSArray = ((automaticallyLoadedAssetKeys == null) ? null : NSArray.FromNSObjects(automaticallyLoadedAssetKeys));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAsset_AutomaticallyLoadedAssetKeys_Handle, asset.Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithAsset:automaticallyLoadedAssetKeys:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAsset_AutomaticallyLoadedAssetKeys_Handle, asset.Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithAsset:automaticallyLoadedAssetKeys:");
		}
		nSArray?.Dispose();
	}

	[Export("addMediaDataCollector:")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddMediaDataCollector(AVPlayerItemMediaDataCollector collector)
	{
		if (collector == null)
		{
			throw new ArgumentNullException("collector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddMediaDataCollector_Handle, collector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddMediaDataCollector_Handle, collector.Handle);
		}
	}

	[Export("addOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOutput(AVPlayerItemOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOutput_Handle, output.Handle);
		}
	}

	[Export("cancelPendingSeeks")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelPendingSeeks()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelPendingSeeksHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelPendingSeeksHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("playerItemWithAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayerItem FromAsset(AVAsset? asset)
	{
		return Runtime.GetNSObject<AVPlayerItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerItemWithAsset_Handle, asset?.Handle ?? IntPtr.Zero));
	}

	[Export("playerItemWithAsset:automaticallyLoadedAssetKeys:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayerItem FromAsset(AVAsset? asset, NSString[]? automaticallyLoadedAssetKeys)
	{
		NSArray nSArray = ((automaticallyLoadedAssetKeys == null) ? null : NSArray.FromNSObjects(automaticallyLoadedAssetKeys));
		AVPlayerItem nSObject = Runtime.GetNSObject<AVPlayerItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPlayerItemWithAsset_AutomaticallyLoadedAssetKeys_Handle, asset?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return nSObject;
	}

	[Export("playerItemWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayerItem FromUrl(NSUrl URL)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		return Runtime.GetNSObject<AVPlayerItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerItemWithURL_Handle, URL.Handle));
	}

	[Export("removeMediaDataCollector:")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveMediaDataCollector(AVPlayerItemMediaDataCollector collector)
	{
		if (collector == null)
		{
			throw new ArgumentNullException("collector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveMediaDataCollector_Handle, collector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveMediaDataCollector_Handle, collector.Handle);
		}
	}

	[Export("removeOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveOutput(AVPlayerItemOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveOutput_Handle, output.Handle);
		}
	}

	[Export("seekToDate:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'Seek (NSDate, AVCompletion)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'Seek (NSDate, AVCompletion)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Seek(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSeekToDate_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSeekToDate_Handle, date.Handle);
	}

	[Export("seekToTime:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'Seek (CMTime, AVCompletion)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'Seek (CMTime, AVCompletion)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Seek(CMTime time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selSeekToTime_Handle, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSeekToTime_Handle, time);
		}
	}

	[Export("seekToTime:toleranceBefore:toleranceAfter:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'Seek (CMTime, CMTime, CMTime, AVCompletion)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'Seek (CMTime, CMTime, CMTime, AVCompletion)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Seek(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_CMTime_CMTime(base.Handle, selSeekToTime_ToleranceBefore_ToleranceAfter_Handle, time, toleranceBefore, toleranceAfter);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime(base.SuperHandle, selSeekToTime_ToleranceBefore_ToleranceAfter_Handle, time, toleranceBefore, toleranceAfter);
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

	[Export("seekToDate:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool Seek(NSDate date, [BlockProxy(typeof(Trampolines.NIDAVCompletion))] AVCompletion completion)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVCompletion.Handler, completion);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSeekToDate_CompletionHandler_Handle, date.Handle, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSeekToDate_CompletionHandler_Handle, date.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
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

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> SeekAsync(NSDate date, out bool result)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		result = Seek(date, delegate(bool finished_)
		{
			tcs.SetResult(finished_);
		});
		return tcs.Task;
	}

	[Export("selectMediaOption:inMediaSelectionGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectMediaOption(AVMediaSelectionOption? mediaSelectionOption, AVMediaSelectionGroup mediaSelectionGroup)
	{
		if (mediaSelectionGroup == null)
		{
			throw new ArgumentNullException("mediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSelectMediaOption_InMediaSelectionGroup_Handle, mediaSelectionOption?.Handle ?? IntPtr.Zero, mediaSelectionGroup.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSelectMediaOption_InMediaSelectionGroup_Handle, mediaSelectionOption?.Handle ?? IntPtr.Zero, mediaSelectionGroup.Handle);
		}
	}

	[Export("selectMediaOptionAutomaticallyInMediaSelectionGroup:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectMediaOptionAutomaticallyInMediaSelectionGroup(AVMediaSelectionGroup mediaSelectionGroup)
	{
		if (mediaSelectionGroup == null)
		{
			throw new ArgumentNullException("mediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectMediaOptionAutomaticallyInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectMediaOptionAutomaticallyInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle);
		}
	}

	[Export("selectedMediaOptionInMediaSelectionGroup:")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CurrentMediaSelection' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CurrentMediaSelection' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMediaSelectionOption? SelectedMediaOption(AVMediaSelectionGroup inMediaSelectionGroup)
	{
		if (inMediaSelectionGroup == null)
		{
			throw new ArgumentNullException("inMediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSelectedMediaOptionInMediaSelectionGroup_Handle, inMediaSelectionGroup.Handle));
		}
		return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectedMediaOptionInMediaSelectionGroup_Handle, inMediaSelectionGroup.Handle));
	}

	[Export("stepByCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StepByCount(nint stepCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selStepByCount_Handle, stepCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selStepByCount_Handle, stepCount);
		}
	}
}
