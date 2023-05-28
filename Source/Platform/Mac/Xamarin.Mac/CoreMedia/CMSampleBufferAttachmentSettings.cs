using System;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class CMSampleBufferAttachmentSettings : DictionaryContainer
{
	public bool? NotSync
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.NotSync);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.NotSync, value);
		}
	}

	public bool? PartialSync
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.PartialSync);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.PartialSync, value);
		}
	}

	public bool? RedundantCoding
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.HasRedundantCoding);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.HasRedundantCoding, value);
		}
	}

	public bool? DependedOnByOthers
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.IsDependedOnByOthers);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.IsDependedOnByOthers, value);
		}
	}

	public bool? DependsOnOthers
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.DependsOnOthers);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.DependsOnOthers, value);
		}
	}

	public bool? EarlierDisplayTimesAllowed
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.EarlierDisplayTimesAllowed);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.EarlierDisplayTimesAllowed, value);
		}
	}

	public bool? DisplayImmediately
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.DisplayImmediately);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.DisplayImmediately, value);
		}
	}

	public bool? DoNotDisplay
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.DoNotDisplay);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.DoNotDisplay, value);
		}
	}

	public bool? ResetDecoderBeforeDecoding
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.ResetDecoderBeforeDecoding);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.ResetDecoderBeforeDecoding, value);
		}
	}

	public bool? DrainAfterDecoding
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.DrainAfterDecoding);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.DrainAfterDecoding, value);
		}
	}

	public bool? Reverse
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.Reverse);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.Reverse, value);
		}
	}

	public bool? FillDiscontinuitiesWithSilence
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.FillDiscontinuitiesWithSilence);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.FillDiscontinuitiesWithSilence, value);
		}
	}

	public bool? EmptyMedia
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.EmptyMedia);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.EmptyMedia, value);
		}
	}

	public bool? PermanentEmptyMedia
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.PermanentEmptyMedia);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.PermanentEmptyMedia, value);
		}
	}

	public bool? DisplayEmptyMediaImmediately
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.DisplayEmptyMediaImmediately);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.DisplayEmptyMediaImmediately, value);
		}
	}

	public bool? EndsPreviousSampleDuration
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.EndsPreviousSampleDuration);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.EndsPreviousSampleDuration, value);
		}
	}

	public NSDictionary? PostNotificationWhenConsumed
	{
		get
		{
			return GetNSDictionary(CMSampleAttachmentKey.PostNotificationWhenConsumedKey);
		}
		set
		{
			SetNativeValue(CMSampleAttachmentKey.PostNotificationWhenConsumedKey, value);
		}
	}

	public bool? ResumeOutput
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.ResumeOutputKey);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.ResumeOutputKey, value);
		}
	}

	public int? TransitionId
	{
		get
		{
			return GetInt32Value(CMSampleAttachmentKey.TransitionIdKey);
		}
		set
		{
			SetNumberValue(CMSampleAttachmentKey.TransitionIdKey, value);
		}
	}

	public NSDictionary? TrimDurationAtStart
	{
		get
		{
			return GetNSDictionary(CMSampleAttachmentKey.TrimDurationAtStartKey);
		}
		set
		{
			SetNativeValue(CMSampleAttachmentKey.TrimDurationAtStartKey, value);
		}
	}

	public NSDictionary? TrimDurationAtEnd
	{
		get
		{
			return GetNSDictionary(CMSampleAttachmentKey.TrimDurationAtEndKey);
		}
		set
		{
			SetNativeValue(CMSampleAttachmentKey.TrimDurationAtEndKey, value);
		}
	}

	public float? SpeedMultiplier
	{
		get
		{
			return GetFloatValue(CMSampleAttachmentKey.SpeedMultiplierKey);
		}
		set
		{
			SetNumberValue(CMSampleAttachmentKey.SpeedMultiplierKey, value);
		}
	}

	public NSUrl? SampleReferenceUrl
	{
		get
		{
			return base.Dictionary[CMSampleAttachmentKey.SampleReferenceUrlKey] as NSUrl;
		}
		set
		{
			SetNativeValue(CMSampleAttachmentKey.SampleReferenceUrlKey, value);
		}
	}

	public int? SampleReferenceByteOffset
	{
		get
		{
			return GetInt32Value(CMSampleAttachmentKey.SampleReferenceByteOffsetKey);
		}
		set
		{
			SetNumberValue(CMSampleAttachmentKey.SampleReferenceByteOffsetKey, value);
		}
	}

	public NSNumber? GradualDecoderRefresh
	{
		get
		{
			return base.Dictionary[CMSampleAttachmentKey.GradualDecoderRefreshKey] as NSNumber;
		}
		set
		{
			SetNativeValue(CMSampleAttachmentKey.GradualDecoderRefreshKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public CMHevcTemporalLevelInfoSettings? HevcTemporalLevelInfo
	{
		get
		{
			return GetStrongDictionary<CMHevcTemporalLevelInfoSettings>(CMSampleAttachmentKey.HevcTemporalLevelInfoKey);
		}
		set
		{
			SetNativeValue(CMSampleAttachmentKey.HevcTemporalLevelInfoKey, value.GetDictionary());
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public bool? HevcTemporalSubLayerAccess
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.HevcTemporalSubLayerAccessKey);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.HevcTemporalSubLayerAccessKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public bool? HevcStepwiseTemporalSubLayerAccess
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.HevcStepwiseTemporalSubLayerAccessKey);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.HevcStepwiseTemporalSubLayerAccessKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public int? HevcSyncSampleNalUnitType
	{
		get
		{
			return GetInt32Value(CMSampleAttachmentKey.HevcSyncSampleNalUnitTypeKey);
		}
		set
		{
			SetNumberValue(CMSampleAttachmentKey.HevcSyncSampleNalUnitTypeKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public NSData? CameraIntrinsicMatrix
	{
		get
		{
			return base.Dictionary[CMSampleAttachmentKey.CameraIntrinsicMatrixKey] as NSData;
		}
		set
		{
			SetNativeValue(CMSampleAttachmentKey.CameraIntrinsicMatrixKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public nint? AudioIndependentSampleDecoderRefreshCount
	{
		get
		{
			return GetNIntValue(CMSampleAttachmentKey.AudioIndependentSampleDecoderRefreshCountKey);
		}
		set
		{
			SetNumberValue(CMSampleAttachmentKey.AudioIndependentSampleDecoderRefreshCountKey, value);
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public bool? ForceKeyFrame
	{
		get
		{
			return GetBoolValue(CMSampleAttachmentKey.ForceKeyFrameKey);
		}
		set
		{
			SetBooleanValue(CMSampleAttachmentKey.ForceKeyFrameKey, value);
		}
	}

	internal CMSampleBufferAttachmentSettings(NSMutableDictionary dictionary)
		: base(dictionary)
	{
	}

	[Preserve(Conditional = true)]
	public CMSampleBufferAttachmentSettings()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CMSampleBufferAttachmentSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
