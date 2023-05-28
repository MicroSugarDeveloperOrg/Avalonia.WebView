using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCompositionTrackSegment", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVCompositionTrackSegment : AVAssetTrackSegment
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionTrackSegmentWithTimeRange_ = "compositionTrackSegmentWithTimeRange:";

	private static readonly IntPtr selCompositionTrackSegmentWithTimeRange_Handle = Selector.GetHandle("compositionTrackSegmentWithTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionTrackSegmentWithURL_TrackID_SourceTimeRange_TargetTimeRange_ = "compositionTrackSegmentWithURL:trackID:sourceTimeRange:targetTimeRange:";

	private static readonly IntPtr selCompositionTrackSegmentWithURL_TrackID_SourceTimeRange_TargetTimeRange_Handle = Selector.GetHandle("compositionTrackSegmentWithURL:trackID:sourceTimeRange:targetTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTimeRange_ = "initWithTimeRange:";

	private static readonly IntPtr selInitWithTimeRange_Handle = Selector.GetHandle("initWithTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_TrackID_SourceTimeRange_TargetTimeRange_ = "initWithURL:trackID:sourceTimeRange:targetTimeRange:";

	private static readonly IntPtr selInitWithURL_TrackID_SourceTimeRange_TargetTimeRange_Handle = Selector.GetHandle("initWithURL:trackID:sourceTimeRange:targetTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEmpty = "isEmpty";

	private static readonly IntPtr selIsEmptyHandle = Selector.GetHandle("isEmpty");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceTrackID = "sourceTrackID";

	private static readonly IntPtr selSourceTrackIDHandle = Selector.GetHandle("sourceTrackID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceURL = "sourceURL";

	private static readonly IntPtr selSourceURLHandle = Selector.GetHandle("sourceURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCompositionTrackSegment");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool Empty
	{
		[Export("isEmpty")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmptyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmptyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int SourceTrackID
	{
		[Export("sourceTrackID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSourceTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSourceTrackIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? SourceUrl
	{
		[Export("sourceURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCompositionTrackSegment()
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
	protected AVCompositionTrackSegment(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCompositionTrackSegment(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:trackID:sourceTimeRange:targetTimeRange:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCompositionTrackSegment(NSUrl URL, int trackID, CMTimeRange sourceTimeRange, CMTimeRange targetTimeRange)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange(base.Handle, selInitWithURL_TrackID_SourceTimeRange_TargetTimeRange_Handle, URL.Handle, trackID, sourceTimeRange, targetTimeRange), "initWithURL:trackID:sourceTimeRange:targetTimeRange:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_CMTimeRange_CMTimeRange(base.SuperHandle, selInitWithURL_TrackID_SourceTimeRange_TargetTimeRange_Handle, URL.Handle, trackID, sourceTimeRange, targetTimeRange), "initWithURL:trackID:sourceTimeRange:targetTimeRange:");
		}
	}

	[Export("initWithTimeRange:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCompositionTrackSegment(CMTimeRange timeRange)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CMTimeRange(base.Handle, selInitWithTimeRange_Handle, timeRange), "initWithTimeRange:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selInitWithTimeRange_Handle, timeRange), "initWithTimeRange:");
		}
	}

	[Export("compositionTrackSegmentWithTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IntPtr FromTimeRange(CMTimeRange timeRange)
	{
		return Messaging.IntPtr_objc_msgSend_CMTimeRange(class_ptr, selCompositionTrackSegmentWithTimeRange_Handle, timeRange);
	}

	[Export("compositionTrackSegmentWithURL:trackID:sourceTimeRange:targetTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IntPtr FromUrl(NSUrl url, int trackID, CMTimeRange sourceTimeRange, CMTimeRange targetTimeRange)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange(class_ptr, selCompositionTrackSegmentWithURL_TrackID_SourceTimeRange_TargetTimeRange_Handle, url.Handle, trackID, sourceTimeRange, targetTimeRange);
	}
}
