using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItem", true)]
public class AVPlayerItem : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidPlayToEndTime(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidPlayToEndTimeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveItemFailedToPlayToEndTime(EventHandler<AVPlayerItemErrorEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ItemFailedToPlayToEndTimeNotification, delegate(NSNotification notification)
			{
				handler(null, new AVPlayerItemErrorEventArgs(notification));
			});
		}

		public static NSObject ObserveTimeJumped(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeJumpedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	private static readonly IntPtr selPresentationSizeHandle = Selector.GetHandle("presentationSize");

	private static readonly IntPtr selForwardPlaybackEndTimeHandle = Selector.GetHandle("forwardPlaybackEndTime");

	private static readonly IntPtr selSetForwardPlaybackEndTime_Handle = Selector.GetHandle("setForwardPlaybackEndTime:");

	private static readonly IntPtr selReversePlaybackEndTimeHandle = Selector.GetHandle("reversePlaybackEndTime");

	private static readonly IntPtr selSetReversePlaybackEndTime_Handle = Selector.GetHandle("setReversePlaybackEndTime:");

	private static readonly IntPtr selAudioMixHandle = Selector.GetHandle("audioMix");

	private static readonly IntPtr selSetAudioMix_Handle = Selector.GetHandle("setAudioMix:");

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	private static readonly IntPtr selIsPlaybackLikelyToKeepUpHandle = Selector.GetHandle("isPlaybackLikelyToKeepUp");

	private static readonly IntPtr selIsPlaybackBufferFullHandle = Selector.GetHandle("isPlaybackBufferFull");

	private static readonly IntPtr selIsPlaybackBufferEmptyHandle = Selector.GetHandle("isPlaybackBufferEmpty");

	private static readonly IntPtr selSeekableTimeRangesHandle = Selector.GetHandle("seekableTimeRanges");

	private static readonly IntPtr selLoadedTimeRangesHandle = Selector.GetHandle("loadedTimeRanges");

	private static readonly IntPtr selTimedMetadataHandle = Selector.GetHandle("timedMetadata");

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	private static readonly IntPtr selAccessLogHandle = Selector.GetHandle("accessLog");

	private static readonly IntPtr selErrorLogHandle = Selector.GetHandle("errorLog");

	private static readonly IntPtr selCurrentDateHandle = Selector.GetHandle("currentDate");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selCanPlayFastReverseHandle = Selector.GetHandle("canPlayFastReverse");

	private static readonly IntPtr selCanPlayFastForwardHandle = Selector.GetHandle("canPlayFastForward");

	private static readonly IntPtr selCanPlaySlowForwardHandle = Selector.GetHandle("canPlaySlowForward");

	private static readonly IntPtr selCanPlayReverseHandle = Selector.GetHandle("canPlayReverse");

	private static readonly IntPtr selCanPlaySlowReverseHandle = Selector.GetHandle("canPlaySlowReverse");

	private static readonly IntPtr selCanStepForwardHandle = Selector.GetHandle("canStepForward");

	private static readonly IntPtr selCanStepBackwardHandle = Selector.GetHandle("canStepBackward");

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	private static readonly IntPtr selTimebaseHandle = Selector.GetHandle("timebase");

	private static readonly IntPtr selPlayerItemWithURL_Handle = Selector.GetHandle("playerItemWithURL:");

	private static readonly IntPtr selPlayerItemWithAsset_Handle = Selector.GetHandle("playerItemWithAsset:");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selInitWithAsset_Handle = Selector.GetHandle("initWithAsset:");

	private static readonly IntPtr selStepByCount_Handle = Selector.GetHandle("stepByCount:");

	private static readonly IntPtr selSeekToDate_Handle = Selector.GetHandle("seekToDate:");

	private static readonly IntPtr selSeekToTime_Handle = Selector.GetHandle("seekToTime:");

	private static readonly IntPtr selSeekToTimeToleranceBeforeToleranceAfter_Handle = Selector.GetHandle("seekToTime:toleranceBefore:toleranceAfter:");

	private static readonly IntPtr selSeekToTimeCompletionHandler_Handle = Selector.GetHandle("seekToTime:completionHandler:");

	private static readonly IntPtr selCancelPendingSeeksHandle = Selector.GetHandle("cancelPendingSeeks");

	private static readonly IntPtr selSeekToTimeToleranceBeforeToleranceAfterCompletionHandler_Handle = Selector.GetHandle("seekToTime:toleranceBefore:toleranceAfter:completionHandler:");

	private static readonly IntPtr selAddOutput_Handle = Selector.GetHandle("addOutput:");

	private static readonly IntPtr selRemoveOutput_Handle = Selector.GetHandle("removeOutput:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerItem");

	private object __mt_Asset_var;

	private object __mt_Tracks_var;

	private object __mt_AudioMix_var;

	private object __mt_VideoComposition_var;

	private object __mt_SeekableTimeRanges_var;

	private object __mt_LoadedTimeRanges_var;

	private object __mt_TimedMetadata_var;

	private object __mt_Error_var;

	private object __mt_AccessLog_var;

	private object __mt_ErrorLog_var;

	private object __mt_CurrentDate_var;

	private object __mt_Outputs_var;

	private static NSString _DidPlayToEndTimeNotification;

	private static NSString _ItemFailedToPlayToEndTimeNotification;

	private static NSString _ItemFailedToPlayToEndTimeErrorKey;

	private static NSString _TimeJumpedNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVPlayerItemStatus Status
	{
		[Export("status")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVPlayerItemStatus)Messaging.int_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVPlayerItemStatus)Messaging.int_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	public virtual AVAsset Asset
	{
		[Export("asset")]
		get
		{
			return (AVAsset)(__mt_Asset_var = ((!IsDirectBinding) ? ((AVAsset)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle))) : ((AVAsset)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle)))));
		}
	}

	public virtual AVPlayerItemTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			return (AVPlayerItemTrack[])(__mt_Tracks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVPlayerItemTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle)) : NSArray.ArrayFromHandle<AVPlayerItemTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle))));
		}
	}

	public virtual CGSize PresentationSize
	{
		[Export("presentationSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPresentationSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPresentationSizeHandle);
		}
	}

	public virtual CMTime ForwardPlaybackEndTime
	{
		[Export("forwardPlaybackEndTime")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetForwardPlaybackEndTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetForwardPlaybackEndTime_Handle, value);
			}
		}
	}

	public virtual CMTime ReversePlaybackEndTime
	{
		[Export("reversePlaybackEndTime")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetReversePlaybackEndTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetReversePlaybackEndTime_Handle, value);
			}
		}
	}

	public virtual AVAudioMix AudioMix
	{
		[Export("audioMix", ArgumentSemantic.Copy)]
		get
		{
			return (AVAudioMix)(__mt_AudioMix_var = ((!IsDirectBinding) ? ((AVAudioMix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioMixHandle))) : ((AVAudioMix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioMixHandle)))));
		}
		[Export("setAudioMix:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioMix_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioMix_Handle, value.Handle);
			}
			__mt_AudioMix_var = value;
		}
	}

	public virtual AVVideoComposition VideoComposition
	{
		[Export("videoComposition", ArgumentSemantic.Copy)]
		get
		{
			return (AVVideoComposition)(__mt_VideoComposition_var = ((!IsDirectBinding) ? ((AVVideoComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionHandle))) : ((AVVideoComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionHandle)))));
		}
		[Export("setVideoComposition:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoComposition_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoComposition_Handle, value.Handle);
			}
			__mt_VideoComposition_var = value;
		}
	}

	public virtual CMTime CurrentTime
	{
		[Export("currentTime")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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

	public virtual bool PlaybackLikelyToKeepUp
	{
		[Export("isPlaybackLikelyToKeepUp")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlaybackLikelyToKeepUpHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlaybackLikelyToKeepUpHandle);
		}
	}

	public virtual bool PlaybackBufferFull
	{
		[Export("isPlaybackBufferFull")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlaybackBufferFullHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlaybackBufferFullHandle);
		}
	}

	public virtual bool PlaybackBufferEmpty
	{
		[Export("isPlaybackBufferEmpty")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlaybackBufferEmptyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlaybackBufferEmptyHandle);
		}
	}

	public virtual NSValue[] SeekableTimeRanges
	{
		[Export("seekableTimeRanges")]
		get
		{
			return (NSValue[])(__mt_SeekableTimeRanges_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSeekableTimeRangesHandle)) : NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selSeekableTimeRangesHandle))));
		}
	}

	public virtual NSValue[] LoadedTimeRanges
	{
		[Export("loadedTimeRanges")]
		get
		{
			return (NSValue[])(__mt_LoadedTimeRanges_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLoadedTimeRangesHandle)) : NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selLoadedTimeRangesHandle))));
		}
	}

	public virtual NSObject[] TimedMetadata
	{
		[Export("timedMetadata")]
		get
		{
			return (NSObject[])(__mt_TimedMetadata_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimedMetadataHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimedMetadataHandle))));
		}
	}

	public virtual NSError Error
	{
		[Export("error")]
		get
		{
			return (NSError)(__mt_Error_var = ((!IsDirectBinding) ? ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle))) : ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle)))));
		}
	}

	[Since(4, 3)]
	public virtual AVPlayerItemAccessLog AccessLog
	{
		[Export("accessLog")]
		get
		{
			return (AVPlayerItemAccessLog)(__mt_AccessLog_var = ((!IsDirectBinding) ? ((AVPlayerItemAccessLog)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessLogHandle))) : ((AVPlayerItemAccessLog)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessLogHandle)))));
		}
	}

	[Since(4, 3)]
	public virtual AVPlayerItemErrorLog ErrorLog
	{
		[Export("errorLog")]
		get
		{
			return (AVPlayerItemErrorLog)(__mt_ErrorLog_var = ((!IsDirectBinding) ? ((AVPlayerItemErrorLog)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorLogHandle))) : ((AVPlayerItemErrorLog)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorLogHandle)))));
		}
	}

	[Since(4, 3)]
	public virtual NSDate CurrentDate
	{
		[Export("currentDate")]
		get
		{
			return (NSDate)(__mt_CurrentDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDateHandle)))));
		}
	}

	[Since(4, 3)]
	public virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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

	[Since(5, 0)]
	public virtual bool CanPlayFastReverse
	{
		[Export("canPlayFastReverse")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlayFastReverseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlayFastReverseHandle);
		}
	}

	[Since(5, 0)]
	public virtual bool CanPlayFastForward
	{
		[Export("canPlayFastForward")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlayFastForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlayFastForwardHandle);
		}
	}

	[Since(6, 0)]
	public virtual bool CanPlaySlowForward
	{
		[Export("canPlaySlowForward")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlaySlowForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlaySlowForwardHandle);
		}
	}

	[Since(6, 0)]
	public virtual bool CanPlayReverse
	{
		[Export("canPlayReverse")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlayReverseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlayReverseHandle);
		}
	}

	[Since(6, 0)]
	public virtual bool CanPlaySlowReverse
	{
		[Export("canPlaySlowReverse")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPlaySlowReverseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPlaySlowReverseHandle);
		}
	}

	[Since(6, 0)]
	public virtual bool CanStepForward
	{
		[Export("canStepForward")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanStepForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanStepForwardHandle);
		}
	}

	[Since(6, 0)]
	public virtual bool CanStepBackward
	{
		[Export("canStepBackward")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanStepBackwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanStepBackwardHandle);
		}
	}

	[Since(6, 0)]
	public virtual AVPlayerItemOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			return (AVPlayerItemOutput[])(__mt_Outputs_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVPlayerItemOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle)) : NSArray.ArrayFromHandle<AVPlayerItemOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle))));
		}
	}

	[Since(6, 0)]
	public virtual CMTimebase Timebase
	{
		[Export("timebase")]
		get
		{
			if (IsDirectBinding)
			{
				return new CMTimebase(Messaging.IntPtr_objc_msgSend(base.Handle, selTimebaseHandle));
			}
			return new CMTimebase(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimebaseHandle));
		}
	}

	[Field("AVPlayerItemDidPlayToEndTimeNotification", "AVFoundation")]
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

	[Field("AVPlayerItemFailedToPlayToEndTimeNotification", "AVFoundation")]
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

	[Field("AVPlayerItemTimeJumpedNotification", "AVFoundation")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVPlayerItem(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("playerItemWithURL:")]
	public static AVPlayerItem FromUrl(NSUrl URL)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		return (AVPlayerItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerItemWithURL_Handle, URL.Handle));
	}

	[Export("playerItemWithAsset:")]
	public static AVPlayerItem FromAsset(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return (AVPlayerItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerItemWithAsset_Handle, asset.Handle));
	}

	[Export("initWithURL:")]
	public AVPlayerItem(NSUrl URL)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, URL.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, URL.Handle);
		}
	}

	[Export("initWithAsset:")]
	public AVPlayerItem(AVAsset asset)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAsset_Handle, asset.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAsset_Handle, asset.Handle);
		}
	}

	[Export("stepByCount:")]
	public virtual void StepByCount(int stepCount)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selStepByCount_Handle, stepCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selStepByCount_Handle, stepCount);
		}
	}

	[Export("seekToDate:")]
	public virtual bool Seek(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSeekToDate_Handle, date.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSeekToDate_Handle, date.Handle);
	}

	[Export("seekToTime:")]
	public virtual void Seek(CMTime time)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selSeekToTime_Handle, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSeekToTime_Handle, time);
		}
	}

	[Export("seekToTime:toleranceBefore:toleranceAfter:")]
	public virtual void Seek(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_CMTime_CMTime(base.Handle, selSeekToTimeToleranceBeforeToleranceAfter_Handle, time, toleranceBefore, toleranceAfter);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime(base.SuperHandle, selSeekToTimeToleranceBeforeToleranceAfter_Handle, time, toleranceBefore, toleranceAfter);
		}
	}

	[Export("seekToTime:completionHandler:")]
	public unsafe virtual void Seek(CMTime time, AVCompletion completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDAVCompletion.Handler, completion);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_IntPtr(base.Handle, selSeekToTimeCompletionHandler_Handle, time, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_IntPtr(base.SuperHandle, selSeekToTimeCompletionHandler_Handle, time, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	public virtual Task<bool> SeekAsync(CMTime time)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Seek(time, delegate(bool finished)
		{
			tcs.SetResult(finished);
		});
		return tcs.Task;
	}

	[Export("cancelPendingSeeks")]
	public virtual void CancelPendingSeeks()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelPendingSeeksHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelPendingSeeksHandle);
		}
	}

	[Export("seekToTime:toleranceBefore:toleranceAfter:completionHandler:")]
	public unsafe virtual void Seek(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter, AVCompletion completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDAVCompletion.Handler, completion);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_CMTime_CMTime_IntPtr(base.Handle, selSeekToTimeToleranceBeforeToleranceAfterCompletionHandler_Handle, time, toleranceBefore, toleranceAfter, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime_IntPtr(base.SuperHandle, selSeekToTimeToleranceBeforeToleranceAfterCompletionHandler_Handle, time, toleranceBefore, toleranceAfter, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	public virtual Task<bool> SeekAsync(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Seek(time, toleranceBefore, toleranceAfter, delegate(bool finished)
		{
			tcs.SetResult(finished);
		});
		return tcs.Task;
	}

	[Export("addOutput:")]
	public virtual void AddOutput(AVPlayerItemOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOutput_Handle, output.Handle);
		}
		_ = Outputs;
	}

	[Export("removeOutput:")]
	public virtual void RemoveOutput(AVPlayerItemOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveOutput_Handle, output.Handle);
		}
		_ = Outputs;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Asset_var = null;
			__mt_Tracks_var = null;
			__mt_AudioMix_var = null;
			__mt_VideoComposition_var = null;
			__mt_SeekableTimeRanges_var = null;
			__mt_LoadedTimeRanges_var = null;
			__mt_TimedMetadata_var = null;
			__mt_Error_var = null;
			__mt_AccessLog_var = null;
			__mt_ErrorLog_var = null;
			__mt_CurrentDate_var = null;
			__mt_Outputs_var = null;
		}
	}
}
