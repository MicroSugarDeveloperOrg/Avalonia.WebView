using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableCompositionTrack", true)]
public class AVMutableCompositionTrack : AVCompositionTrack
{
	private static readonly IntPtr selSegmentsHandle = Selector.GetHandle("segments");

	private static readonly IntPtr selSetSegments_Handle = Selector.GetHandle("setSegments:");

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	private static readonly IntPtr selSetExtendedLanguageTag_Handle = Selector.GetHandle("setExtendedLanguageTag:");

	private static readonly IntPtr selLanguageCodeHandle = Selector.GetHandle("languageCode");

	private static readonly IntPtr selSetLanguageCode_Handle = Selector.GetHandle("setLanguageCode:");

	private static readonly IntPtr selNaturalTimeScaleHandle = Selector.GetHandle("naturalTimeScale");

	private static readonly IntPtr selSetNaturalTimeScale_Handle = Selector.GetHandle("setNaturalTimeScale:");

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	private static readonly IntPtr selSetPreferredTransform_Handle = Selector.GetHandle("setPreferredTransform:");

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	private static readonly IntPtr selSetPreferredVolume_Handle = Selector.GetHandle("setPreferredVolume:");

	private static readonly IntPtr selInsertTimeRangeOfTrackAtTimeError_Handle = Selector.GetHandle("insertTimeRange:ofTrack:atTime:error:");

	private static readonly IntPtr selInsertEmptyTimeRange_Handle = Selector.GetHandle("insertEmptyTimeRange:");

	private static readonly IntPtr selRemoveTimeRange_Handle = Selector.GetHandle("removeTimeRange:");

	private static readonly IntPtr selScaleTimeRangeToDuration_Handle = Selector.GetHandle("scaleTimeRange:toDuration:");

	private static readonly IntPtr selValidateTrackSegmentsError_Handle = Selector.GetHandle("validateTrackSegments:error:");

	private static readonly IntPtr selInsertTimeRangesOfTracksAtTimeError_Handle = Selector.GetHandle("insertTimeRanges:ofTracks:atTime:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableCompositionTrack");

	private object __mt_Segments_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual AVCompositionTrackSegment[] Segments
	{
		[Export("segments", ArgumentSemantic.Copy)]
		get
		{
			return (AVCompositionTrackSegment[])(__mt_Segments_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSegmentsHandle)) : NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSend(base.Handle, selSegmentsHandle))));
		}
		[Export("setSegments:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSegments_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSegments_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Segments_var = value;
		}
	}

	public new virtual string ExtendedLanguageTag
	{
		[Export("extendedLanguageTag")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLanguageTagHandle));
		}
		[Export("setExtendedLanguageTag:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExtendedLanguageTag_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExtendedLanguageTag_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public new virtual string LanguageCode
	{
		[Export("languageCode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageCodeHandle));
		}
		[Export("setLanguageCode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLanguageCode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLanguageCode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public new virtual int NaturalTimeScale
	{
		[Export("naturalTimeScale")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNaturalTimeScaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNaturalTimeScaleHandle);
		}
		[Export("setNaturalTimeScale:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetNaturalTimeScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetNaturalTimeScale_Handle, value);
			}
		}
	}

	public new virtual CGAffineTransform PreferredTransform
	{
		[Export("preferredTransform")]
		get
		{
			CGAffineTransform retval;
			if (IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selPreferredTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreferredTransformHandle);
			}
			return retval;
		}
		[Export("setPreferredTransform:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetPreferredTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetPreferredTransform_Handle, value);
			}
		}
	}

	public new virtual float PreferredVolume
	{
		[Export("preferredVolume")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredVolumeHandle);
		}
		[Export("setPreferredVolume:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPreferredVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPreferredVolume_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVMutableCompositionTrack(NSCoder coder)
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
	public AVMutableCompositionTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMutableCompositionTrack(IntPtr handle)
		: base(handle)
	{
	}

	[Export("insertTimeRange:ofTrack:atTime:error:")]
	public virtual bool InsertTimeRange(CMTimeRange timeRange, AVAssetTrack ofTrack, CMTime atTime, out NSError error)
	{
		if (ofTrack == null)
		{
			throw new ArgumentNullException("ofTrack");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_IntPtr(base.SuperHandle, selInsertTimeRangeOfTrackAtTimeError_Handle, timeRange, ofTrack.Handle, atTime, intPtr) : Messaging.bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_IntPtr(base.Handle, selInsertTimeRangeOfTrackAtTimeError_Handle, timeRange, ofTrack.Handle, atTime, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("insertEmptyTimeRange:")]
	public virtual void InsertEmptyTimeRange(CMTimeRange timeRange)
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

	[Export("validateTrackSegments:error:")]
	public virtual bool ValidateTrackSegments(AVCompositionTrackSegment[] trackSegments, out NSError error)
	{
		if (trackSegments == null)
		{
			throw new ArgumentNullException("trackSegments");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSArray nSArray = NSArray.FromNSObjects(trackSegments);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidateTrackSegmentsError_Handle, nSArray.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidateTrackSegmentsError_Handle, nSArray.Handle, intPtr));
		nSArray.Dispose();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("insertTimeRanges:ofTracks:atTime:error:")]
	public virtual bool InsertTimeRanges(NSValue cmTimeRanges, AVAssetTrack[] tracks, CMTime startTime, out NSError error)
	{
		if (cmTimeRanges == null)
		{
			throw new ArgumentNullException("cmTimeRanges");
		}
		if (tracks == null)
		{
			throw new ArgumentNullException("tracks");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSArray nSArray = NSArray.FromNSObjects(tracks);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_CMTime_IntPtr(base.SuperHandle, selInsertTimeRangesOfTracksAtTimeError_Handle, cmTimeRanges.Handle, nSArray.Handle, startTime, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_CMTime_IntPtr(base.Handle, selInsertTimeRangesOfTracksAtTimeError_Handle, cmTimeRanges.Handle, nSArray.Handle, startTime, intPtr));
		nSArray.Dispose();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Segments_var = null;
		}
	}
}
