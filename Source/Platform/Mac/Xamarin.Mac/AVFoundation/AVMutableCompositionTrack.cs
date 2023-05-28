using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableCompositionTrack", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMutableCompositionTrack : AVCompositionTrack
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTrackAssociationToTrack_Type_ = "addTrackAssociationToTrack:type:";

	private static readonly IntPtr selAddTrackAssociationToTrack_Type_Handle = Selector.GetHandle("addTrackAssociationToTrack:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedLanguageTag = "extendedLanguageTag";

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertEmptyTimeRange_ = "insertEmptyTimeRange:";

	private static readonly IntPtr selInsertEmptyTimeRange_Handle = Selector.GetHandle("insertEmptyTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTimeRange_OfTrack_AtTime_Error_ = "insertTimeRange:ofTrack:atTime:error:";

	private static readonly IntPtr selInsertTimeRange_OfTrack_AtTime_Error_Handle = Selector.GetHandle("insertTimeRange:ofTrack:atTime:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertTimeRanges_OfTracks_AtTime_Error_ = "insertTimeRanges:ofTracks:atTime:error:";

	private static readonly IntPtr selInsertTimeRanges_OfTracks_AtTime_Error_Handle = Selector.GetHandle("insertTimeRanges:ofTracks:atTime:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageCode = "languageCode";

	private static readonly IntPtr selLanguageCodeHandle = Selector.GetHandle("languageCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalTimeScale = "naturalTimeScale";

	private static readonly IntPtr selNaturalTimeScaleHandle = Selector.GetHandle("naturalTimeScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredTransform = "preferredTransform";

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredVolume = "preferredVolume";

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTimeRange_ = "removeTimeRange:";

	private static readonly IntPtr selRemoveTimeRange_Handle = Selector.GetHandle("removeTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTrackAssociationToTrack_Type_ = "removeTrackAssociationToTrack:type:";

	private static readonly IntPtr selRemoveTrackAssociationToTrack_Type_Handle = Selector.GetHandle("removeTrackAssociationToTrack:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceFormatDescription_WithFormatDescription_ = "replaceFormatDescription:withFormatDescription:";

	private static readonly IntPtr selReplaceFormatDescription_WithFormatDescription_Handle = Selector.GetHandle("replaceFormatDescription:withFormatDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleTimeRange_ToDuration_ = "scaleTimeRange:toDuration:";

	private static readonly IntPtr selScaleTimeRange_ToDuration_Handle = Selector.GetHandle("scaleTimeRange:toDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegments = "segments";

	private static readonly IntPtr selSegmentsHandle = Selector.GetHandle("segments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExtendedLanguageTag_ = "setExtendedLanguageTag:";

	private static readonly IntPtr selSetExtendedLanguageTag_Handle = Selector.GetHandle("setExtendedLanguageTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguageCode_ = "setLanguageCode:";

	private static readonly IntPtr selSetLanguageCode_Handle = Selector.GetHandle("setLanguageCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNaturalTimeScale_ = "setNaturalTimeScale:";

	private static readonly IntPtr selSetNaturalTimeScale_Handle = Selector.GetHandle("setNaturalTimeScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredTransform_ = "setPreferredTransform:";

	private static readonly IntPtr selSetPreferredTransform_Handle = Selector.GetHandle("setPreferredTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredVolume_ = "setPreferredVolume:";

	private static readonly IntPtr selSetPreferredVolume_Handle = Selector.GetHandle("setPreferredVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSegments_ = "setSegments:";

	private static readonly IntPtr selSetSegments_Handle = Selector.GetHandle("setSegments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateTrackSegments_Error_ = "validateTrackSegments:error:";

	private static readonly IntPtr selValidateTrackSegments_Error_Handle = Selector.GetHandle("validateTrackSegments:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableCompositionTrack");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public new virtual bool Enabled
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string? ExtendedLanguageTag
	{
		[Export("extendedLanguageTag", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLanguageTagHandle));
		}
		[Export("setExtendedLanguageTag:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string? LanguageCode
	{
		[Export("languageCode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageCodeHandle));
		}
		[Export("setLanguageCode:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual int NaturalTimeScale
	{
		[Export("naturalTimeScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNaturalTimeScaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNaturalTimeScaleHandle);
		}
		[Export("setNaturalTimeScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetNaturalTimeScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetNaturalTimeScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGAffineTransform PreferredTransform
	{
		[Export("preferredTransform")]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetPreferredTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetPreferredTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual float PreferredVolume
	{
		[Export("preferredVolume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredVolumeHandle);
		}
		[Export("setPreferredVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPreferredVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPreferredVolume_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVCompositionTrackSegment[]? Segments
	{
		[Export("segments", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSend(base.Handle, selSegmentsHandle));
			}
			return NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSegmentsHandle));
		}
		[Export("setSegments:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSegments_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSegments_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[Obsolete("Use 'InsertTimeRanges' overload accepting an 'NSValue' array.")]
	public virtual bool InsertTimeRanges(NSValue cmTimeRanges, AVAssetTrack[] tracks, CMTime startTime, out NSError error)
	{
		return InsertTimeRanges(new NSValue[1] { cmTimeRanges }, tracks, startTime, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableCompositionTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableCompositionTrack(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addTrackAssociationToTrack:type:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTrackAssociation(AVCompositionTrack compositionTrack, string trackAssociationType)
	{
		if (compositionTrack == null)
		{
			throw new ArgumentNullException("compositionTrack");
		}
		if (trackAssociationType == null)
		{
			throw new ArgumentNullException("trackAssociationType");
		}
		IntPtr arg = NSString.CreateNative(trackAssociationType);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddTrackAssociationToTrack_Type_Handle, compositionTrack.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddTrackAssociationToTrack_Type_Handle, compositionTrack.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("insertEmptyTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertEmptyTimeRange(CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selInsertEmptyTimeRange_Handle, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selInsertEmptyTimeRange_Handle, timeRange);
		}
	}

	[Export("insertTimeRange:ofTrack:atTime:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InsertTimeRange(CMTimeRange timeRange, AVAssetTrack ofTrack, CMTime atTime, out NSError error)
	{
		if (ofTrack == null)
		{
			throw new ArgumentNullException("ofTrack");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_ref_IntPtr(base.SuperHandle, selInsertTimeRange_OfTrack_AtTime_Error_Handle, timeRange, ofTrack.Handle, atTime, ref arg) : Messaging.bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_ref_IntPtr(base.Handle, selInsertTimeRange_OfTrack_AtTime_Error_Handle, timeRange, ofTrack.Handle, atTime, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("insertTimeRanges:ofTracks:atTime:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InsertTimeRanges(NSValue[] cmTimeRanges, AVAssetTrack[] tracks, CMTime startTime, out NSError error)
	{
		if (cmTimeRanges == null)
		{
			throw new ArgumentNullException("cmTimeRanges");
		}
		if (tracks == null)
		{
			throw new ArgumentNullException("tracks");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(cmTimeRanges);
		NSArray nSArray2 = NSArray.FromNSObjects(tracks);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_CMTime_ref_IntPtr(base.SuperHandle, selInsertTimeRanges_OfTracks_AtTime_Error_Handle, nSArray.Handle, nSArray2.Handle, startTime, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_CMTime_ref_IntPtr(base.Handle, selInsertTimeRanges_OfTracks_AtTime_Error_Handle, nSArray.Handle, nSArray2.Handle, startTime, ref arg));
		nSArray.Dispose();
		nSArray2.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("removeTimeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTimeRange(CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selRemoveTimeRange_Handle, timeRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selRemoveTimeRange_Handle, timeRange);
		}
	}

	[Export("removeTrackAssociationToTrack:type:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTrackAssociation(AVCompositionTrack compositionTrack, string trackAssociationType)
	{
		if (compositionTrack == null)
		{
			throw new ArgumentNullException("compositionTrack");
		}
		if (trackAssociationType == null)
		{
			throw new ArgumentNullException("trackAssociationType");
		}
		IntPtr arg = NSString.CreateNative(trackAssociationType);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveTrackAssociationToTrack_Type_Handle, compositionTrack.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveTrackAssociationToTrack_Type_Handle, compositionTrack.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceFormatDescription:withFormatDescription:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceFormatDescription(CMFormatDescription originalFormatDescription, CMFormatDescription? replacementFormatDescription)
	{
		if (originalFormatDescription == null)
		{
			throw new ArgumentNullException("originalFormatDescription");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceFormatDescription_WithFormatDescription_Handle, originalFormatDescription.Handle, replacementFormatDescription?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceFormatDescription_WithFormatDescription_Handle, originalFormatDescription.Handle, replacementFormatDescription?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("scaleTimeRange:toDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScaleTimeRange(CMTimeRange timeRange, CMTime duration)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTimeRange_CMTime(base.Handle, selScaleTimeRange_ToDuration_Handle, timeRange, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTimeRange_CMTime(base.SuperHandle, selScaleTimeRange_ToDuration_Handle, timeRange, duration);
		}
	}

	[Export("validateTrackSegments:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateTrackSegments(AVCompositionTrackSegment[] trackSegments, out NSError error)
	{
		if (trackSegments == null)
		{
			throw new ArgumentNullException("trackSegments");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(trackSegments);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selValidateTrackSegments_Error_Handle, nSArray.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selValidateTrackSegments_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
