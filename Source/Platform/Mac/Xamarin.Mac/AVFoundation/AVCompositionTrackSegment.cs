using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCompositionTrackSegment", true)]
public class AVCompositionTrackSegment : AVAssetTrackSegment
{
	private static readonly IntPtr selSourceURLHandle = Selector.GetHandle("sourceURL");

	private static readonly IntPtr selSourceTrackIDHandle = Selector.GetHandle("sourceTrackID");

	private static readonly IntPtr selCompositionTrackSegmentWithURLTrackIDSourceTimeRangeTargetTimeRange_Handle = Selector.GetHandle("compositionTrackSegmentWithURL:trackID:sourceTimeRange:targetTimeRange:");

	private static readonly IntPtr selCompositionTrackSegmentWithTimeRange_Handle = Selector.GetHandle("compositionTrackSegmentWithTimeRange:");

	private static readonly IntPtr selInitWithURLTrackIDSourceTimeRangeTargetTimeRange_Handle = Selector.GetHandle("initWithURL:trackID:sourceTimeRange:targetTimeRange:");

	private static readonly IntPtr selInitWithTimeRange_Handle = Selector.GetHandle("initWithTimeRange:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCompositionTrackSegment");

	private object __mt_SourceUrl_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl SourceUrl
	{
		[Export("sourceURL")]
		get
		{
			return (NSUrl)(__mt_SourceUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceURLHandle)))));
		}
	}

	public virtual int SourceTrackID
	{
		[Export("sourceTrackID")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSourceTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSourceTrackIDHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCompositionTrackSegment()
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
	public AVCompositionTrackSegment(NSCoder coder)
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
	public AVCompositionTrackSegment(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCompositionTrackSegment(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compositionTrackSegmentWithURL:trackID:sourceTimeRange:targetTimeRange:")]
	public static IntPtr FromUrl(NSUrl url, int trackID, CMTimeRange sourceTimeRange, CMTimeRange targetTimeRange)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange(class_ptr, selCompositionTrackSegmentWithURLTrackIDSourceTimeRangeTargetTimeRange_Handle, url.Handle, trackID, sourceTimeRange, targetTimeRange);
	}

	[Export("compositionTrackSegmentWithTimeRange:")]
	public static IntPtr FromTimeRange(CMTimeRange timeRange)
	{
		return Messaging.IntPtr_objc_msgSend_CMTimeRange(class_ptr, selCompositionTrackSegmentWithTimeRange_Handle, timeRange);
	}

	[Export("initWithURL:trackID:sourceTimeRange:targetTimeRange:")]
	public AVCompositionTrackSegment(NSUrl URL, int trackID, CMTimeRange sourceTimeRange, CMTimeRange targetTimeRange)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange(base.Handle, selInitWithURLTrackIDSourceTimeRangeTargetTimeRange_Handle, URL.Handle, trackID, sourceTimeRange, targetTimeRange);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_CMTimeRange_CMTimeRange(base.SuperHandle, selInitWithURLTrackIDSourceTimeRangeTargetTimeRange_Handle, URL.Handle, trackID, sourceTimeRange, targetTimeRange);
		}
	}

	[Export("initWithTimeRange:")]
	public AVCompositionTrackSegment(CMTimeRange timeRange)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CMTimeRange(base.Handle, selInitWithTimeRange_Handle, timeRange);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selInitWithTimeRange_Handle, timeRange);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SourceUrl_var = null;
		}
	}
}
