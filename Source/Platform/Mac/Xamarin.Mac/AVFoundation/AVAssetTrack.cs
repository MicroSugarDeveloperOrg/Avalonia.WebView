using System;
using System.ComponentModel;
using System.Linq;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetTrack", true)]
public class AVAssetTrack : NSObject
{
	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	private static readonly IntPtr selFormatDescriptionsHandle = Selector.GetHandle("formatDescriptions");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selIsSelfContainedHandle = Selector.GetHandle("isSelfContained");

	private static readonly IntPtr selTotalSampleDataLengthHandle = Selector.GetHandle("totalSampleDataLength");

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	private static readonly IntPtr selNaturalTimeScaleHandle = Selector.GetHandle("naturalTimeScale");

	private static readonly IntPtr selEstimatedDataRateHandle = Selector.GetHandle("estimatedDataRate");

	private static readonly IntPtr selLanguageCodeHandle = Selector.GetHandle("languageCode");

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	private static readonly IntPtr selNominalFrameRateHandle = Selector.GetHandle("nominalFrameRate");

	private static readonly IntPtr selSegmentsHandle = Selector.GetHandle("segments");

	private static readonly IntPtr selAvailableMetadataFormatsHandle = Selector.GetHandle("availableMetadataFormats");

	private static readonly IntPtr selCommonMetadataHandle = Selector.GetHandle("commonMetadata");

	private static readonly IntPtr selIsPlayableHandle = Selector.GetHandle("isPlayable");

	private static readonly IntPtr selHasMediaCharacteristic_Handle = Selector.GetHandle("hasMediaCharacteristic:");

	private static readonly IntPtr selSegmentForTrackTime_Handle = Selector.GetHandle("segmentForTrackTime:");

	private static readonly IntPtr selSamplePresentationTimeForTrackTime_Handle = Selector.GetHandle("samplePresentationTimeForTrackTime:");

	private static readonly IntPtr selMetadataForFormat_Handle = Selector.GetHandle("metadataForFormat:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetTrack");

	private object __mt_Asset_var;

	private object __mt_FormatDescriptionsAsObjects_var;

	private object __mt_Segments_var;

	private object __mt_CommonMetadata_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual int TrackID
	{
		[Export("trackID")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackIDHandle);
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

	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	public virtual NSObject[] FormatDescriptionsAsObjects
	{
		[Export("formatDescriptions")]
		get
		{
			return (NSObject[])(__mt_FormatDescriptionsAsObjects_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionsHandle))));
		}
	}

	public CMFormatDescription[] FormatDescriptions => FormatDescriptionsAsObjects.Select((NSObject l) => CMFormatDescription.Create(l.Handle, owns: false)).ToArray();

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
	}

	public virtual bool SelfContained
	{
		[Export("isSelfContained")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelfContainedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelfContainedHandle);
		}
	}

	public virtual long TotalSampleDataLength
	{
		[Export("totalSampleDataLength")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selTotalSampleDataLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTotalSampleDataLengthHandle);
		}
	}

	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange")]
		get
		{
			CMTimeRange retval;
			if (IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
	}

	public virtual int NaturalTimeScale
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
	}

	public virtual float EstimatedDataRate
	{
		[Export("estimatedDataRate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEstimatedDataRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEstimatedDataRateHandle);
		}
	}

	public virtual string LanguageCode
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
	}

	public virtual string ExtendedLanguageTag
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
	}

	public virtual CGSize NaturalSize
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
	}

	public virtual float PreferredVolume
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
	}

	public virtual CGAffineTransform PreferredTransform
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
	}

	public virtual float NominalFrameRate
	{
		[Export("nominalFrameRate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNominalFrameRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNominalFrameRateHandle);
		}
	}

	public virtual AVAssetTrackSegment[] Segments
	{
		[Export("segments", ArgumentSemantic.Copy)]
		get
		{
			return (AVAssetTrackSegment[])(__mt_Segments_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrackSegment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSegmentsHandle)) : NSArray.ArrayFromHandle<AVAssetTrackSegment>(Messaging.IntPtr_objc_msgSend(base.Handle, selSegmentsHandle))));
		}
	}

	public virtual string[] AvailableMetadataFormats
	{
		[Export("availableMetadataFormats")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableMetadataFormatsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableMetadataFormatsHandle));
		}
	}

	public virtual AVMetadataItem[] CommonMetadata
	{
		[Export("commonMetadata")]
		get
		{
			return (AVMetadataItem[])(__mt_CommonMetadata_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonMetadataHandle)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonMetadataHandle))));
		}
	}

	public virtual bool Playable
	{
		[Export("isPlayable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayableHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetTrack(NSCoder coder)
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
	public AVAssetTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetTrack(IntPtr handle)
		: base(handle)
	{
	}

	[Export("hasMediaCharacteristic:")]
	public virtual bool HasMediaCharacteristic(string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr arg = NSString.CreateNative(mediaCharacteristic);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasMediaCharacteristic_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasMediaCharacteristic_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("segmentForTrackTime:")]
	public virtual AVAssetTrackSegment SegmentForTrackTime(CMTime trackTime)
	{
		if (IsDirectBinding)
		{
			return (AVAssetTrackSegment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CMTime(base.Handle, selSegmentForTrackTime_Handle, trackTime));
		}
		return (AVAssetTrackSegment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CMTime(base.SuperHandle, selSegmentForTrackTime_Handle, trackTime));
	}

	[Export("samplePresentationTimeForTrackTime:")]
	public virtual CMTime SamplePresentationTimeForTrackTime(CMTime trackTime)
	{
		CMTime retval;
		if (IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_CMTime(out retval, base.Handle, selSamplePresentationTimeForTrackTime_Handle, trackTime);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_CMTime(out retval, base.SuperHandle, selSamplePresentationTimeForTrackTime_Handle, trackTime);
		}
		return retval;
	}

	[Export("metadataForFormat:")]
	public virtual AVMetadataItem[] MetadataForFormat(string format)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		IntPtr arg = NSString.CreateNative(format);
		AVMetadataItem[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMetadataForFormat_Handle, arg)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMetadataForFormat_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Asset_var = null;
			__mt_FormatDescriptionsAsObjects_var = null;
			__mt_Segments_var = null;
			__mt_CommonMetadata_var = null;
		}
	}
}
