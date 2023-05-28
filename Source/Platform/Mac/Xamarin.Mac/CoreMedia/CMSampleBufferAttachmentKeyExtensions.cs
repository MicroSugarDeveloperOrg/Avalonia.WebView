using System;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CMSampleBufferAttachmentKeyExtensions
{
	private static IntPtr[] values = new IntPtr[34];

	[Field("kCMSampleAttachmentKey_NotSync", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_NotSync
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_NotSync", storage);
			}
		}
	}

	[Field("kCMSampleAttachmentKey_PartialSync", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_PartialSync
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_PartialSync", storage);
			}
		}
	}

	[Field("kCMSampleAttachmentKey_HasRedundantCoding", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_HasRedundantCoding
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HasRedundantCoding", storage);
			}
		}
	}

	[Field("kCMSampleAttachmentKey_IsDependedOnByOthers", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_IsDependedOnByOthers
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_IsDependedOnByOthers", storage);
			}
		}
	}

	[Field("kCMSampleAttachmentKey_DependsOnOthers", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_DependsOnOthers
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DependsOnOthers", storage);
			}
		}
	}

	[Field("kCMSampleAttachmentKey_EarlierDisplayTimesAllowed", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_EarlierDisplayTimesAllowed
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_EarlierDisplayTimesAllowed", storage);
			}
		}
	}

	[Field("kCMSampleAttachmentKey_DisplayImmediately", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_DisplayImmediately
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DisplayImmediately", storage);
			}
		}
	}

	[Field("kCMSampleAttachmentKey_DoNotDisplay", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_DoNotDisplay
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DoNotDisplay", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCMSampleAttachmentKey_HEVCTemporalLevelInfo", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCTemporalLevelInfo
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalLevelInfo", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_DrainAfterDecoding", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DrainAfterDecoding
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DrainAfterDecoding", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_ResumeOutput", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_ResumeOutput
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResumeOutput", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_TransitionID", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_TransitionID
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TransitionID", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_TrimDurationAtStart", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_TrimDurationAtStart
	{
		get
		{
			fixed (IntPtr* storage = &values[17])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtStart", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_TrimDurationAtEnd", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_TrimDurationAtEnd
	{
		get
		{
			fixed (IntPtr* storage = &values[18])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtEnd", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_SpeedMultiplier", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_SpeedMultiplier
	{
		get
		{
			fixed (IntPtr* storage = &values[19])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SpeedMultiplier", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_Reverse", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_Reverse
	{
		get
		{
			fixed (IntPtr* storage = &values[20])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_Reverse", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence
	{
		get
		{
			fixed (IntPtr* storage = &values[21])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_EmptyMedia", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_EmptyMedia
	{
		get
		{
			fixed (IntPtr* storage = &values[22])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EmptyMedia", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_PermanentEmptyMedia", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_PermanentEmptyMedia
	{
		get
		{
			fixed (IntPtr* storage = &values[23])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PermanentEmptyMedia", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately
	{
		get
		{
			fixed (IntPtr* storage = &values[24])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration
	{
		get
		{
			fixed (IntPtr* storage = &values[25])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_SampleReferenceURL", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_SampleReferenceURL
	{
		get
		{
			fixed (IntPtr* storage = &values[26])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceURL", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_SampleReferenceByteOffset", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_SampleReferenceByteOffset
	{
		get
		{
			fixed (IntPtr* storage = &values[27])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceByteOffset", storage);
			}
		}
	}

	[Field("kCMSampleBufferAttachmentKey_GradualDecoderRefresh", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_GradualDecoderRefresh
	{
		get
		{
			fixed (IntPtr* storage = &values[28])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_GradualDecoderRefresh", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Field("kCMSampleBufferAttachmentKey_DroppedFrameReason", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DroppedFrameReason
	{
		get
		{
			fixed (IntPtr* storage = &values[29])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DroppedFrameReason", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Field("kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo
	{
		get
		{
			fixed (IntPtr* storage = &values[30])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Field("kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix
	{
		get
		{
			fixed (IntPtr* storage = &values[31])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Field("kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo
	{
		get
		{
			fixed (IntPtr* storage = &values[32])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo", storage);
			}
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Field("kCMSampleBufferAttachmentKey_ForceKeyFrame", "CoreMedia")]
	internal unsafe static IntPtr kCMSampleBufferAttachmentKey_ForceKeyFrame
	{
		get
		{
			fixed (IntPtr* storage = &values[33])
			{
				return Dlfcn.CachePointer(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ForceKeyFrame", storage);
			}
		}
	}

	public static NSString? GetConstant(this CMSampleBufferAttachmentKey self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kCMSampleAttachmentKey_NotSync;
			break;
		case 1:
			zero = kCMSampleAttachmentKey_PartialSync;
			break;
		case 2:
			zero = kCMSampleAttachmentKey_HasRedundantCoding;
			break;
		case 3:
			zero = kCMSampleAttachmentKey_IsDependedOnByOthers;
			break;
		case 4:
			zero = kCMSampleAttachmentKey_DependsOnOthers;
			break;
		case 5:
			zero = kCMSampleAttachmentKey_EarlierDisplayTimesAllowed;
			break;
		case 6:
			zero = kCMSampleAttachmentKey_DisplayImmediately;
			break;
		case 7:
			zero = kCMSampleAttachmentKey_DoNotDisplay;
			break;
		case 8:
			zero = kCMSampleAttachmentKey_HEVCTemporalLevelInfo;
			break;
		case 9:
			zero = kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess;
			break;
		case 10:
			zero = kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess;
			break;
		case 11:
			zero = kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType;
			break;
		case 12:
			zero = kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding;
			break;
		case 13:
			zero = kCMSampleBufferAttachmentKey_DrainAfterDecoding;
			break;
		case 14:
			zero = kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed;
			break;
		case 15:
			zero = kCMSampleBufferAttachmentKey_ResumeOutput;
			break;
		case 16:
			zero = kCMSampleBufferAttachmentKey_TransitionID;
			break;
		case 17:
			zero = kCMSampleBufferAttachmentKey_TrimDurationAtStart;
			break;
		case 18:
			zero = kCMSampleBufferAttachmentKey_TrimDurationAtEnd;
			break;
		case 19:
			zero = kCMSampleBufferAttachmentKey_SpeedMultiplier;
			break;
		case 20:
			zero = kCMSampleBufferAttachmentKey_Reverse;
			break;
		case 21:
			zero = kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence;
			break;
		case 22:
			zero = kCMSampleBufferAttachmentKey_EmptyMedia;
			break;
		case 23:
			zero = kCMSampleBufferAttachmentKey_PermanentEmptyMedia;
			break;
		case 24:
			zero = kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately;
			break;
		case 25:
			zero = kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration;
			break;
		case 26:
			zero = kCMSampleBufferAttachmentKey_SampleReferenceURL;
			break;
		case 27:
			zero = kCMSampleBufferAttachmentKey_SampleReferenceByteOffset;
			break;
		case 28:
			zero = kCMSampleBufferAttachmentKey_GradualDecoderRefresh;
			break;
		case 29:
			zero = kCMSampleBufferAttachmentKey_DroppedFrameReason;
			break;
		case 30:
			zero = kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo;
			break;
		case 31:
			zero = kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix;
			break;
		case 32:
			zero = kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo;
			break;
		case 33:
			zero = kCMSampleBufferAttachmentKey_ForceKeyFrame;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static CMSampleBufferAttachmentKey GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_NotSync))
		{
			return CMSampleBufferAttachmentKey.NotSync;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_PartialSync))
		{
			return CMSampleBufferAttachmentKey.PartialSync;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_HasRedundantCoding))
		{
			return CMSampleBufferAttachmentKey.HasRedundantCoding;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_IsDependedOnByOthers))
		{
			return CMSampleBufferAttachmentKey.IsDependedOnByOthers;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_DependsOnOthers))
		{
			return CMSampleBufferAttachmentKey.DependsOnOthers;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_EarlierDisplayTimesAllowed))
		{
			return CMSampleBufferAttachmentKey.EarlierDisplayTimesAllowed;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_DisplayImmediately))
		{
			return CMSampleBufferAttachmentKey.DisplayImmediately;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_DoNotDisplay))
		{
			return CMSampleBufferAttachmentKey.DoNotDisplay;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_HEVCTemporalLevelInfo))
		{
			return CMSampleBufferAttachmentKey.HevcTemporalLevelInfo;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess))
		{
			return CMSampleBufferAttachmentKey.HevcTemporalSubLayerAccess;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess))
		{
			return CMSampleBufferAttachmentKey.HevcStepwiseTemporalSubLayerAccess;
		}
		if (constant.IsEqualTo(kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType))
		{
			return CMSampleBufferAttachmentKey.HevcSyncSampleNalUnitType;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding))
		{
			return CMSampleBufferAttachmentKey.ResetDecoderBeforeDecoding;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_DrainAfterDecoding))
		{
			return CMSampleBufferAttachmentKey.DrainAfterDecoding;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed))
		{
			return CMSampleBufferAttachmentKey.PostNotificationWhenConsumed;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_ResumeOutput))
		{
			return CMSampleBufferAttachmentKey.ResumeOutput;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_TransitionID))
		{
			return CMSampleBufferAttachmentKey.TransitionId;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_TrimDurationAtStart))
		{
			return CMSampleBufferAttachmentKey.TrimDurationAtStart;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_TrimDurationAtEnd))
		{
			return CMSampleBufferAttachmentKey.TrimDurationAtEnd;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_SpeedMultiplier))
		{
			return CMSampleBufferAttachmentKey.SpeedMultiplier;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_Reverse))
		{
			return CMSampleBufferAttachmentKey.Reverse;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence))
		{
			return CMSampleBufferAttachmentKey.FillDiscontinuitiesWithSilence;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_EmptyMedia))
		{
			return CMSampleBufferAttachmentKey.EmptyMedia;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_PermanentEmptyMedia))
		{
			return CMSampleBufferAttachmentKey.PermanentEmptyMedia;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately))
		{
			return CMSampleBufferAttachmentKey.DisplayEmptyMediaImmediately;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration))
		{
			return CMSampleBufferAttachmentKey.EndsPreviousSampleDuration;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_SampleReferenceURL))
		{
			return CMSampleBufferAttachmentKey.SampleReferenceUrl;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_SampleReferenceByteOffset))
		{
			return CMSampleBufferAttachmentKey.SampleReferenceByteOffset;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_GradualDecoderRefresh))
		{
			return CMSampleBufferAttachmentKey.GradualDecoderRefresh;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_DroppedFrameReason))
		{
			return CMSampleBufferAttachmentKey.DroppedFrameReason;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_StillImageLensStabilizationInfo))
		{
			return CMSampleBufferAttachmentKey.StillImageLensStabilizationInfo;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix))
		{
			return CMSampleBufferAttachmentKey.CameraIntrinsicMatrix;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_DroppedFrameReasonInfo))
		{
			return CMSampleBufferAttachmentKey.DroppedFrameReasonInfo;
		}
		if (constant.IsEqualTo(kCMSampleBufferAttachmentKey_ForceKeyFrame))
		{
			return CMSampleBufferAttachmentKey.ForceKeyFrame;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
