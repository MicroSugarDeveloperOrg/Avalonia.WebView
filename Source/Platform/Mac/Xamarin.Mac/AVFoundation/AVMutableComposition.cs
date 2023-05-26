using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableComposition", true)]
public class AVMutableComposition : AVComposition
{
	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	private static readonly IntPtr selSetNaturalSize_Handle = Selector.GetHandle("setNaturalSize:");

	private static readonly IntPtr selCompositionHandle = Selector.GetHandle("composition");

	private static readonly IntPtr selInsertTimeRangeOfAssetAtTimeError_Handle = Selector.GetHandle("insertTimeRange:ofAsset:atTime:error:");

	private static readonly IntPtr selInsertEmptyTimeRange_Handle = Selector.GetHandle("insertEmptyTimeRange:");

	private static readonly IntPtr selRemoveTimeRange_Handle = Selector.GetHandle("removeTimeRange:");

	private static readonly IntPtr selScaleTimeRangeToDuration_Handle = Selector.GetHandle("scaleTimeRange:toDuration:");

	private static readonly IntPtr selAddMutableTrackWithMediaTypePreferredTrackID_Handle = Selector.GetHandle("addMutableTrackWithMediaType:preferredTrackID:");

	private static readonly IntPtr selRemoveTrack_Handle = Selector.GetHandle("removeTrack:");

	private static readonly IntPtr selMutableTrackCompatibleWithTrack_Handle = Selector.GetHandle("mutableTrackCompatibleWithTrack:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableComposition");

	public override IntPtr ClassHandle => class_ptr;

	[Obsolete("Deprecated in iOS 5.0 and OSX 10.8", false)]
	public override CGSize NaturalSize
	{
		[Export("naturalSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selNaturalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selNaturalSizeHandle);
		}
		[Export("setNaturalSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetNaturalSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetNaturalSize_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableComposition()
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
	public AVMutableComposition(NSCoder coder)
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
	public AVMutableComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMutableComposition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("composition")]
	public static AVMutableComposition Create()
	{
		return (AVMutableComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCompositionHandle));
	}

	[Export("insertTimeRange:ofAsset:atTime:error:")]
	public virtual bool Insert(CMTimeRange insertTimeRange, AVAsset sourceAsset, CMTime atTime, out NSError error)
	{
		if (sourceAsset == null)
		{
			throw new ArgumentNullException("sourceAsset");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_IntPtr(base.SuperHandle, selInsertTimeRangeOfAssetAtTimeError_Handle, insertTimeRange, sourceAsset.Handle, atTime, intPtr) : Messaging.bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_IntPtr(base.Handle, selInsertTimeRangeOfAssetAtTimeError_Handle, insertTimeRange, sourceAsset.Handle, atTime, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("insertEmptyTimeRange:")]
	public virtual void InserEmptyTimeRange(CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selInsertEmptyTimeRange_Handle, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selInsertEmptyTimeRange_Handle, timeRange);
		}
	}

	[Export("removeTimeRange:")]
	public virtual void RemoveTimeRange(CMTimeRange timeRange)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selRemoveTimeRange_Handle, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selRemoveTimeRange_Handle, timeRange);
		}
	}

	[Export("scaleTimeRange:toDuration:")]
	public virtual void ScaleTimeRange(CMTimeRange timeRange, CMTime duration)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange_CMTime(base.Handle, selScaleTimeRangeToDuration_Handle, timeRange, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange_CMTime(base.SuperHandle, selScaleTimeRangeToDuration_Handle, timeRange, duration);
		}
	}

	[Export("addMutableTrackWithMediaType:preferredTrackID:")]
	public virtual AVMutableCompositionTrack AddMutableTrack(string mediaType, int preferredTrackId)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVMutableCompositionTrack result = ((!IsDirectBinding) ? ((AVMutableCompositionTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selAddMutableTrackWithMediaTypePreferredTrackID_Handle, arg, preferredTrackId))) : ((AVMutableCompositionTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_int(base.Handle, selAddMutableTrackWithMediaTypePreferredTrackID_Handle, arg, preferredTrackId))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeTrack:")]
	public virtual void RemoveTrack(AVCompositionTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTrack_Handle, track.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTrack_Handle, track.Handle);
		}
	}

	[Export("mutableTrackCompatibleWithTrack:")]
	public virtual AVMutableCompositionTrack CreateMutableTrack(AVAssetTrack referenceTrack)
	{
		if (referenceTrack == null)
		{
			throw new ArgumentNullException("referenceTrack");
		}
		if (IsDirectBinding)
		{
			return (AVMutableCompositionTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableTrackCompatibleWithTrack_Handle, referenceTrack.Handle));
		}
		return (AVMutableCompositionTrack)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableTrackCompatibleWithTrack_Handle, referenceTrack.Handle));
	}
}
