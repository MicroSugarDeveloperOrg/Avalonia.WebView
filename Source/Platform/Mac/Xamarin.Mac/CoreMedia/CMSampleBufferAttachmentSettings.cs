using System;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

public class CMSampleBufferAttachmentSettings : DictionaryContainer
{
	private static class Selectors
	{
		public static readonly NSString NotSync;

		public static readonly NSString PartialSync;

		public static readonly NSString HasRedundantCoding;

		public static readonly NSString IsDependedOnByOthers;

		public static readonly NSString DependsOnOthers;

		public static readonly NSString EarlierDisplayTimesAllowed;

		public static readonly NSString DisplayImmediately;

		public static readonly NSString DoNotDisplay;

		public static readonly NSString ResetDecoderBeforeDecoding;

		public static readonly NSString DrainAfterDecoding;

		public static readonly NSString PostNotificationWhenConsumed;

		public static readonly NSString ResumeOutput;

		public static readonly NSString TransitionID;

		public static readonly NSString TrimDurationAtStart;

		public static readonly NSString TrimDurationAtEnd;

		public static readonly NSString SpeedMultiplier;

		public static readonly NSString Reverse;

		public static readonly NSString FillDiscontinuitiesWithSilence;

		public static readonly NSString EmptyMedia;

		public static readonly NSString PermanentEmptyMedia;

		public static readonly NSString DisplayEmptyMediaImmediately;

		public static readonly NSString EndsPreviousSampleDuration;

		public static readonly NSString SampleReferenceURL;

		public static readonly NSString SampleReferenceByteOffset;

		public static readonly NSString GradualDecoderRefresh;

		static Selectors()
		{
			IntPtr intPtr = Dlfcn.dlopen("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia", 0);
			if (intPtr == IntPtr.Zero)
			{
				return;
			}
			try
			{
				NotSync = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_NotSync");
				PartialSync = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_PartialSync");
				HasRedundantCoding = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_HasRedundantCoding");
				IsDependedOnByOthers = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_IsDependedOnByOthers");
				DependsOnOthers = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_DependsOnOthers");
				EarlierDisplayTimesAllowed = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_EarlierDisplayTimesAllowed");
				DisplayImmediately = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_DisplayImmediately");
				DoNotDisplay = Dlfcn.GetStringConstant(intPtr, "kCMSampleAttachmentKey_DoNotDisplay");
				ResetDecoderBeforeDecoding = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding");
				DrainAfterDecoding = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_DrainAfterDecoding");
				PostNotificationWhenConsumed = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed");
				ResumeOutput = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_ResumeOutput");
				TransitionID = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_TransitionID");
				TrimDurationAtStart = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_TrimDurationAtStart");
				TrimDurationAtEnd = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_TrimDurationAtEnd");
				SpeedMultiplier = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_SpeedMultiplier");
				Reverse = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_Reverse");
				FillDiscontinuitiesWithSilence = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence");
				EmptyMedia = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_EmptyMedia");
				PermanentEmptyMedia = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_PermanentEmptyMedia");
				DisplayEmptyMediaImmediately = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately");
				EndsPreviousSampleDuration = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration");
				SampleReferenceURL = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_SampleReferenceURL");
				SampleReferenceByteOffset = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_SampleReferenceByteOffset");
				GradualDecoderRefresh = Dlfcn.GetStringConstant(intPtr, "kCMSampleBufferAttachmentKey_GradualDecoderRefresh");
			}
			finally
			{
				Dlfcn.dlclose(intPtr);
			}
		}
	}

	public bool? NotSync
	{
		get
		{
			return GetBoolValue(Selectors.NotSync);
		}
		set
		{
			SetBooleanValue(Selectors.NotSync, value);
		}
	}

	public bool? PartialSync
	{
		get
		{
			return GetBoolValue(Selectors.PartialSync);
		}
		set
		{
			SetBooleanValue(Selectors.PartialSync, value);
		}
	}

	public bool? RedundantCoding
	{
		get
		{
			return GetBoolValue(Selectors.HasRedundantCoding);
		}
		set
		{
			SetBooleanValue(Selectors.HasRedundantCoding, value);
		}
	}

	public bool? DependedOnByOthers
	{
		get
		{
			return GetBoolValue(Selectors.IsDependedOnByOthers);
		}
		set
		{
			SetBooleanValue(Selectors.IsDependedOnByOthers, value);
		}
	}

	public bool? DependsOnOthers
	{
		get
		{
			return GetBoolValue(Selectors.DependsOnOthers);
		}
		set
		{
			SetBooleanValue(Selectors.DependsOnOthers, value);
		}
	}

	public bool? EarlierDisplayTimesAllowed
	{
		get
		{
			return GetBoolValue(Selectors.EarlierDisplayTimesAllowed);
		}
		set
		{
			SetBooleanValue(Selectors.EarlierDisplayTimesAllowed, value);
		}
	}

	public bool? DisplayImmediately
	{
		get
		{
			return GetBoolValue(Selectors.DisplayImmediately);
		}
		set
		{
			SetBooleanValue(Selectors.DisplayImmediately, value);
		}
	}

	public bool? DoNotDisplay
	{
		get
		{
			return GetBoolValue(Selectors.DoNotDisplay);
		}
		set
		{
			SetBooleanValue(Selectors.DoNotDisplay, value);
		}
	}

	public bool? ResetDecoderBeforeDecoding
	{
		get
		{
			return GetBoolValue(Selectors.ResetDecoderBeforeDecoding);
		}
		set
		{
			SetBooleanValue(Selectors.ResetDecoderBeforeDecoding, value);
		}
	}

	public bool? DrainAfterDecoding
	{
		get
		{
			return GetBoolValue(Selectors.DrainAfterDecoding);
		}
		set
		{
			SetBooleanValue(Selectors.DrainAfterDecoding, value);
		}
	}

	public bool? Reverse
	{
		get
		{
			return GetBoolValue(Selectors.Reverse);
		}
		set
		{
			SetBooleanValue(Selectors.Reverse, value);
		}
	}

	public bool? FillDiscontinuitiesWithSilence
	{
		get
		{
			return GetBoolValue(Selectors.FillDiscontinuitiesWithSilence);
		}
		set
		{
			SetBooleanValue(Selectors.FillDiscontinuitiesWithSilence, value);
		}
	}

	public bool? EmptyMedia
	{
		get
		{
			return GetBoolValue(Selectors.EmptyMedia);
		}
		set
		{
			SetBooleanValue(Selectors.EmptyMedia, value);
		}
	}

	public bool? PermanentEmptyMedia
	{
		get
		{
			return GetBoolValue(Selectors.PermanentEmptyMedia);
		}
		set
		{
			SetBooleanValue(Selectors.PermanentEmptyMedia, value);
		}
	}

	public bool? DisplayEmptyMediaImmediately
	{
		get
		{
			return GetBoolValue(Selectors.DisplayEmptyMediaImmediately);
		}
		set
		{
			SetBooleanValue(Selectors.DisplayEmptyMediaImmediately, value);
		}
	}

	public bool? EndsPreviousSampleDuration
	{
		get
		{
			return GetBoolValue(Selectors.EndsPreviousSampleDuration);
		}
		set
		{
			SetBooleanValue(Selectors.EndsPreviousSampleDuration, value);
		}
	}

	internal CMSampleBufferAttachmentSettings(NSMutableDictionary dictionary)
		: base(dictionary)
	{
	}
}
