using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemAccessLogEvent", true)]
public class AVPlayerItemAccessLogEvent : NSObject
{
	private static readonly IntPtr selNumberOfSegmentsDownloadedHandle = Selector.GetHandle("numberOfSegmentsDownloaded");

	private static readonly IntPtr selPlaybackStartDateHandle = Selector.GetHandle("playbackStartDate");

	private static readonly IntPtr selURIHandle = Selector.GetHandle("URI");

	private static readonly IntPtr selServerAddressHandle = Selector.GetHandle("serverAddress");

	private static readonly IntPtr selNumberOfServerAddressChangesHandle = Selector.GetHandle("numberOfServerAddressChanges");

	private static readonly IntPtr selPlaybackSessionIDHandle = Selector.GetHandle("playbackSessionID");

	private static readonly IntPtr selPlaybackStartOffsetHandle = Selector.GetHandle("playbackStartOffset");

	private static readonly IntPtr selSegmentsDownloadedDurationHandle = Selector.GetHandle("segmentsDownloadedDuration");

	private static readonly IntPtr selDurationWatchedHandle = Selector.GetHandle("durationWatched");

	private static readonly IntPtr selNumberOfStallsHandle = Selector.GetHandle("numberOfStalls");

	private static readonly IntPtr selNumberOfBytesTransferredHandle = Selector.GetHandle("numberOfBytesTransferred");

	private static readonly IntPtr selObservedBitrateHandle = Selector.GetHandle("observedBitrate");

	private static readonly IntPtr selIndicatedBitrateHandle = Selector.GetHandle("indicatedBitrate");

	private static readonly IntPtr selNumberOfDroppedVideoFramesHandle = Selector.GetHandle("numberOfDroppedVideoFrames");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerItemAccessLogEvent");

	private object __mt_PlaybackStartDate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual int SegmentedDownloadedCount
	{
		[Export("numberOfSegmentsDownloaded")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfSegmentsDownloadedHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfSegmentsDownloadedHandle);
		}
	}

	public virtual NSData PlaybackStartDate
	{
		[Export("playbackStartDate")]
		get
		{
			return (NSData)(__mt_PlaybackStartDate_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaybackStartDateHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaybackStartDateHandle)))));
		}
	}

	public virtual string Uri
	{
		[Export("URI")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURIHandle));
		}
	}

	public virtual string ServerAddress
	{
		[Export("serverAddress")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServerAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServerAddressHandle));
		}
	}

	public virtual int ServerAddressChangeCount
	{
		[Export("numberOfServerAddressChanges")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfServerAddressChangesHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfServerAddressChangesHandle);
		}
	}

	public virtual string PlaybackSessionID
	{
		[Export("playbackSessionID")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaybackSessionIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaybackSessionIDHandle));
		}
	}

	public virtual double PlaybackStartOffset
	{
		[Export("playbackStartOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPlaybackStartOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPlaybackStartOffsetHandle);
		}
	}

	public virtual double SegmentsDownloadedDuration
	{
		[Export("segmentsDownloadedDuration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSegmentsDownloadedDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSegmentsDownloadedDurationHandle);
		}
	}

	public virtual double DurationWatched
	{
		[Export("durationWatched")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationWatchedHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationWatchedHandle);
		}
	}

	public virtual int StallCount
	{
		[Export("numberOfStalls")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfStallsHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfStallsHandle);
		}
	}

	public virtual long BytesTransferred
	{
		[Export("numberOfBytesTransferred")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfBytesTransferredHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfBytesTransferredHandle);
		}
	}

	public virtual double ObservedBitrate
	{
		[Export("observedBitrate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selObservedBitrateHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selObservedBitrateHandle);
		}
	}

	public virtual double IndicatedBitrate
	{
		[Export("indicatedBitrate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selIndicatedBitrateHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selIndicatedBitrateHandle);
		}
	}

	public virtual int DroppedVideoFrameCount
	{
		[Export("numberOfDroppedVideoFrames")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfDroppedVideoFramesHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfDroppedVideoFramesHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemAccessLogEvent()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVPlayerItemAccessLogEvent(NSCoder coder)
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
	public AVPlayerItemAccessLogEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItemAccessLogEvent(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PlaybackStartDate_var = null;
		}
	}
}
