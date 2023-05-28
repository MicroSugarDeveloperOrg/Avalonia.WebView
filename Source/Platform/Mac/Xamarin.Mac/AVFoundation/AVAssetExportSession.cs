using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetExportSession", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetExportSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllExportPresets = "allExportPresets";

	private static readonly IntPtr selAllExportPresetsHandle = Selector.GetHandle("allExportPresets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAsset = "asset";

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioMix = "audioMix";

	private static readonly IntPtr selAudioMixHandle = Selector.GetHandle("audioMix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioTimePitchAlgorithm = "audioTimePitchAlgorithm";

	private static readonly IntPtr selAudioTimePitchAlgorithmHandle = Selector.GetHandle("audioTimePitchAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformMultiplePassesOverSourceMediaData = "canPerformMultiplePassesOverSourceMediaData";

	private static readonly IntPtr selCanPerformMultiplePassesOverSourceMediaDataHandle = Selector.GetHandle("canPerformMultiplePassesOverSourceMediaData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelExport = "cancelExport";

	private static readonly IntPtr selCancelExportHandle = Selector.GetHandle("cancelExport");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomVideoCompositor = "customVideoCompositor";

	private static readonly IntPtr selCustomVideoCompositorHandle = Selector.GetHandle("customVideoCompositor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetermineCompatibilityOfExportPreset_WithAsset_OutputFileType_CompletionHandler_ = "determineCompatibilityOfExportPreset:withAsset:outputFileType:completionHandler:";

	private static readonly IntPtr selDetermineCompatibilityOfExportPreset_WithAsset_OutputFileType_CompletionHandler_Handle = Selector.GetHandle("determineCompatibilityOfExportPreset:withAsset:outputFileType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetermineCompatibleFileTypesWithCompletionHandler_ = "determineCompatibleFileTypesWithCompletionHandler:";

	private static readonly IntPtr selDetermineCompatibleFileTypesWithCompletionHandler_Handle = Selector.GetHandle("determineCompatibleFileTypesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirectoryForTemporaryFiles = "directoryForTemporaryFiles";

	private static readonly IntPtr selDirectoryForTemporaryFilesHandle = Selector.GetHandle("directoryForTemporaryFiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimateMaximumDurationWithCompletionHandler_ = "estimateMaximumDurationWithCompletionHandler:";

	private static readonly IntPtr selEstimateMaximumDurationWithCompletionHandler_Handle = Selector.GetHandle("estimateMaximumDurationWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimateOutputFileLengthWithCompletionHandler_ = "estimateOutputFileLengthWithCompletionHandler:";

	private static readonly IntPtr selEstimateOutputFileLengthWithCompletionHandler_Handle = Selector.GetHandle("estimateOutputFileLengthWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedOutputFileLength = "estimatedOutputFileLength";

	private static readonly IntPtr selEstimatedOutputFileLengthHandle = Selector.GetHandle("estimatedOutputFileLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportAsynchronouslyWithCompletionHandler_ = "exportAsynchronouslyWithCompletionHandler:";

	private static readonly IntPtr selExportAsynchronouslyWithCompletionHandler_Handle = Selector.GetHandle("exportAsynchronouslyWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportPresetsCompatibleWithAsset_ = "exportPresetsCompatibleWithAsset:";

	private static readonly IntPtr selExportPresetsCompatibleWithAsset_Handle = Selector.GetHandle("exportPresetsCompatibleWithAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportSessionWithAsset_PresetName_ = "exportSessionWithAsset:presetName:";

	private static readonly IntPtr selExportSessionWithAsset_PresetName_Handle = Selector.GetHandle("exportSessionWithAsset:presetName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileLengthLimit = "fileLengthLimit";

	private static readonly IntPtr selFileLengthLimitHandle = Selector.GetHandle("fileLengthLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_PresetName_ = "initWithAsset:presetName:";

	private static readonly IntPtr selInitWithAsset_PresetName_Handle = Selector.GetHandle("initWithAsset:presetName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxDuration = "maxDuration";

	private static readonly IntPtr selMaxDurationHandle = Selector.GetHandle("maxDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemFilter = "metadataItemFilter";

	private static readonly IntPtr selMetadataItemFilterHandle = Selector.GetHandle("metadataItemFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFileType = "outputFileType";

	private static readonly IntPtr selOutputFileTypeHandle = Selector.GetHandle("outputFileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputURL = "outputURL";

	private static readonly IntPtr selOutputURLHandle = Selector.GetHandle("outputURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresetName = "presetName";

	private static readonly IntPtr selPresetNameHandle = Selector.GetHandle("presetName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgress = "progress";

	private static readonly IntPtr selProgressHandle = Selector.GetHandle("progress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioMix_ = "setAudioMix:";

	private static readonly IntPtr selSetAudioMix_Handle = Selector.GetHandle("setAudioMix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioTimePitchAlgorithm_ = "setAudioTimePitchAlgorithm:";

	private static readonly IntPtr selSetAudioTimePitchAlgorithm_Handle = Selector.GetHandle("setAudioTimePitchAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanPerformMultiplePassesOverSourceMediaData_ = "setCanPerformMultiplePassesOverSourceMediaData:";

	private static readonly IntPtr selSetCanPerformMultiplePassesOverSourceMediaData_Handle = Selector.GetHandle("setCanPerformMultiplePassesOverSourceMediaData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirectoryForTemporaryFiles_ = "setDirectoryForTemporaryFiles:";

	private static readonly IntPtr selSetDirectoryForTemporaryFiles_Handle = Selector.GetHandle("setDirectoryForTemporaryFiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileLengthLimit_ = "setFileLengthLimit:";

	private static readonly IntPtr selSetFileLengthLimit_Handle = Selector.GetHandle("setFileLengthLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadataItemFilter_ = "setMetadataItemFilter:";

	private static readonly IntPtr selSetMetadataItemFilter_Handle = Selector.GetHandle("setMetadataItemFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputFileType_ = "setOutputFileType:";

	private static readonly IntPtr selSetOutputFileType_Handle = Selector.GetHandle("setOutputFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputURL_ = "setOutputURL:";

	private static readonly IntPtr selSetOutputURL_Handle = Selector.GetHandle("setOutputURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldOptimizeForNetworkUse_ = "setShouldOptimizeForNetworkUse:";

	private static readonly IntPtr selSetShouldOptimizeForNetworkUse_Handle = Selector.GetHandle("setShouldOptimizeForNetworkUse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeRange_ = "setTimeRange:";

	private static readonly IntPtr selSetTimeRange_Handle = Selector.GetHandle("setTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoComposition_ = "setVideoComposition:";

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldOptimizeForNetworkUse = "shouldOptimizeForNetworkUse";

	private static readonly IntPtr selShouldOptimizeForNetworkUseHandle = Selector.GetHandle("shouldOptimizeForNetworkUse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedFileTypes = "supportedFileTypes";

	private static readonly IntPtr selSupportedFileTypesHandle = Selector.GetHandle("supportedFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeRange = "timeRange";

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoComposition = "videoComposition";

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetExportSession");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset1280x720;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset1920x1080;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset3840x2160;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset640x480;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preset960x540;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetAppleM4A;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetAppleProRes4444Lpcm;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHevc1920x1080;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHevc1920x1080WithAlpha;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHevc3840x2160;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHevc3840x2160WithAlpha;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHevcHighestQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHevcHighestQualityWithAlpha;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetHighestQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetLowQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetMediumQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PresetPassthrough;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] AllExportPresets
	{
		[Export("allExportPresets")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAllExportPresetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAsset Asset
	{
		[Export("asset", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle));
			}
			return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioMix? AudioMix
	{
		[Export("audioMix", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioMix>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioMixHandle));
			}
			return Runtime.GetNSObject<AVAudioMix>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioMixHandle));
		}
		[Export("setAudioMix:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioMix_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioMix_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual NSString AudioTimePitchAlgorithm
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("audioTimePitchAlgorithm", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioTimePitchAlgorithmHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioTimePitchAlgorithmHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("setAudioTimePitchAlgorithm:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioTimePitchAlgorithm_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioTimePitchAlgorithm_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Advice("This property cannot be set after the export has started.")]
	public virtual bool CanPerformMultiplePassesOverSourceMediaData
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("canPerformMultiplePassesOverSourceMediaData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanPerformMultiplePassesOverSourceMediaDataHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanPerformMultiplePassesOverSourceMediaDataHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setCanPerformMultiplePassesOverSourceMediaData:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanPerformMultiplePassesOverSourceMediaData_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanPerformMultiplePassesOverSourceMediaData_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public virtual IAVVideoCompositing? CustomVideoCompositor
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("customVideoCompositor", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IAVVideoCompositing>(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomVideoCompositorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IAVVideoCompositing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomVideoCompositorHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Advice("This property cannot be set after the export has started.")]
	public virtual NSUrl? DirectoryForTemporaryFiles
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("directoryForTemporaryFiles", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryForTemporaryFilesHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryForTemporaryFilesHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setDirectoryForTemporaryFiles:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDirectoryForTemporaryFiles_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDirectoryForTemporaryFiles_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateOutputFileLength' for more precise results.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateOutputFileLength' for more precise results.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'EstimateOutputFileLength' for more precise results.")]
	public virtual long EstimatedOutputFileLength
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateOutputFileLength' for more precise results.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateOutputFileLength' for more precise results.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'EstimateOutputFileLength' for more precise results.")]
		[Export("estimatedOutputFileLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selEstimatedOutputFileLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEstimatedOutputFileLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long FileLengthLimit
	{
		[Export("fileLengthLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFileLengthLimitHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFileLengthLimitHandle);
		}
		[Export("setFileLengthLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFileLengthLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFileLengthLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateMaximumDuration' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateMaximumDuration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'EstimateMaximumDuration' instead.")]
	public virtual CMTime MaxDuration
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateMaximumDuration' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'EstimateMaximumDuration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'EstimateMaximumDuration' instead.")]
		[Export("maxDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMaxDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMaxDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[]? Metadata
	{
		[Export("metadata", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle));
		}
		[Export("setMetadata:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual AVMetadataItemFilter? MetadataItemFilter
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("metadataItemFilter", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMetadataItemFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataItemFilterHandle));
			}
			return Runtime.GetNSObject<AVMetadataItemFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataItemFilterHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setMetadataItemFilter:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadataItemFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadataItemFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? OutputFileType
	{
		[Export("outputFileType", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFileTypeHandle));
		}
		[Export("setOutputFileType:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputFileType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputFileType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? OutputUrl
	{
		[Export("outputURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputURLHandle));
		}
		[Export("setOutputURL:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PresetName
	{
		[Export("presetName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPresetNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresetNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Progress
	{
		[Export("progress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selProgressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldOptimizeForNetworkUse
	{
		[Export("shouldOptimizeForNetworkUse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldOptimizeForNetworkUseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldOptimizeForNetworkUseHandle);
		}
		[Export("setShouldOptimizeForNetworkUse:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldOptimizeForNetworkUse_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldOptimizeForNetworkUse_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetExportSessionStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAssetExportSessionStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVAssetExportSessionStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] SupportedFileTypes
	{
		[Export("supportedFileTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedFileTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedFileTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange", ArgumentSemantic.Assign)]
		get
		{
			CMTimeRange retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
		[Export("setTimeRange:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selSetTimeRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selSetTimeRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVVideoComposition? VideoComposition
	{
		[Export("videoComposition", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionHandle));
			}
			return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionHandle));
		}
		[Export("setVideoComposition:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoComposition_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoComposition_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Field("AVAssetExportPreset1280x720", "AVFoundation")]
	public static NSString Preset1280x720
	{
		get
		{
			if (_Preset1280x720 == null)
			{
				_Preset1280x720 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPreset1280x720");
			}
			return _Preset1280x720;
		}
	}

	[Field("AVAssetExportPreset1920x1080", "AVFoundation")]
	public static NSString Preset1920x1080
	{
		get
		{
			if (_Preset1920x1080 == null)
			{
				_Preset1920x1080 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPreset1920x1080");
			}
			return _Preset1920x1080;
		}
	}

	[Field("AVAssetExportPreset3840x2160", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString Preset3840x2160
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_Preset3840x2160 == null)
			{
				_Preset3840x2160 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPreset3840x2160");
			}
			return _Preset3840x2160;
		}
	}

	[Field("AVAssetExportPreset640x480", "AVFoundation")]
	public static NSString Preset640x480
	{
		get
		{
			if (_Preset640x480 == null)
			{
				_Preset640x480 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPreset640x480");
			}
			return _Preset640x480;
		}
	}

	[Field("AVAssetExportPreset960x540", "AVFoundation")]
	public static NSString Preset960x540
	{
		get
		{
			if (_Preset960x540 == null)
			{
				_Preset960x540 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPreset960x540");
			}
			return _Preset960x540;
		}
	}

	[Field("AVAssetExportPresetAppleM4A", "AVFoundation")]
	public static NSString PresetAppleM4A
	{
		get
		{
			if (_PresetAppleM4A == null)
			{
				_PresetAppleM4A = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4A");
			}
			return _PresetAppleM4A;
		}
	}

	[Field("AVAssetExportPresetAppleProRes4444LPCM", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString PresetAppleProRes4444Lpcm
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetAppleProRes4444Lpcm == null)
			{
				_PresetAppleProRes4444Lpcm = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleProRes4444LPCM");
			}
			return _PresetAppleProRes4444Lpcm;
		}
	}

	[Field("AVAssetExportPresetHEVC1920x1080", "AVFoundation")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString PresetHevc1920x1080
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetHevc1920x1080 == null)
			{
				_PresetHevc1920x1080 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC1920x1080");
			}
			return _PresetHevc1920x1080;
		}
	}

	[Field("AVAssetExportPresetHEVC1920x1080WithAlpha", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString PresetHevc1920x1080WithAlpha
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetHevc1920x1080WithAlpha == null)
			{
				_PresetHevc1920x1080WithAlpha = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC1920x1080WithAlpha");
			}
			return _PresetHevc1920x1080WithAlpha;
		}
	}

	[Field("AVAssetExportPresetHEVC3840x2160", "AVFoundation")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString PresetHevc3840x2160
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetHevc3840x2160 == null)
			{
				_PresetHevc3840x2160 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC3840x2160");
			}
			return _PresetHevc3840x2160;
		}
	}

	[Field("AVAssetExportPresetHEVC3840x2160WithAlpha", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString PresetHevc3840x2160WithAlpha
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetHevc3840x2160WithAlpha == null)
			{
				_PresetHevc3840x2160WithAlpha = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVC3840x2160WithAlpha");
			}
			return _PresetHevc3840x2160WithAlpha;
		}
	}

	[Field("AVAssetExportPresetHEVCHighestQuality", "AVFoundation")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString PresetHevcHighestQuality
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetHevcHighestQuality == null)
			{
				_PresetHevcHighestQuality = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVCHighestQuality");
			}
			return _PresetHevcHighestQuality;
		}
	}

	[Field("AVAssetExportPresetHEVCHighestQualityWithAlpha", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString PresetHevcHighestQualityWithAlpha
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetHevcHighestQualityWithAlpha == null)
			{
				_PresetHevcHighestQualityWithAlpha = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetHEVCHighestQualityWithAlpha");
			}
			return _PresetHevcHighestQualityWithAlpha;
		}
	}

	[Field("AVAssetExportPresetHighestQuality", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString PresetHighestQuality
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetHighestQuality == null)
			{
				_PresetHighestQuality = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetHighestQuality");
			}
			return _PresetHighestQuality;
		}
	}

	[Field("AVAssetExportPresetLowQuality", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString PresetLowQuality
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetLowQuality == null)
			{
				_PresetLowQuality = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetLowQuality");
			}
			return _PresetLowQuality;
		}
	}

	[Field("AVAssetExportPresetMediumQuality", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString PresetMediumQuality
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_PresetMediumQuality == null)
			{
				_PresetMediumQuality = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetMediumQuality");
			}
			return _PresetMediumQuality;
		}
	}

	[Field("AVAssetExportPresetPassthrough", "AVFoundation")]
	public static NSString PresetPassthrough
	{
		get
		{
			if (_PresetPassthrough == null)
			{
				_PresetPassthrough = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetPassthrough");
			}
			return _PresetPassthrough;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetExportSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetExportSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAsset:presetName:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetExportSession(AVAsset asset, string presetName)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (presetName == null)
		{
			throw new ArgumentNullException("presetName");
		}
		IntPtr arg = NSString.CreateNative(presetName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAsset_PresetName_Handle, asset.Handle, arg), "initWithAsset:presetName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAsset_PresetName_Handle, asset.Handle, arg), "initWithAsset:presetName:");
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetExportSession(AVAsset asset, AVAssetExportSessionPreset preset)
		: this(asset, preset.GetConstant())
	{
	}

	[Export("cancelExport")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelExport()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelExportHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelExportHandle);
		}
	}

	[Export("determineCompatibilityOfExportPreset:withAsset:outputFileType:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DetermineCompatibilityOfExportPreset(string presetName, AVAsset asset, string? outputFileType, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> isCompatibleResult)
	{
		if (presetName == null)
		{
			throw new ArgumentNullException("presetName");
		}
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (isCompatibleResult == null)
		{
			throw new ArgumentNullException("isCompatibleResult");
		}
		IntPtr arg = NSString.CreateNative(presetName);
		IntPtr arg2 = NSString.CreateNative(outputFileType);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, isCompatibleResult);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selDetermineCompatibilityOfExportPreset_WithAsset_OutputFileType_CompletionHandler_Handle, arg, asset.Handle, arg2, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<bool> DetermineCompatibilityOfExportPresetAsync(string presetName, AVAsset asset, string? outputFileType)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DetermineCompatibilityOfExportPreset(presetName, asset, outputFileType, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DetermineCompatibilityOfExportPreset(string presetName, AVAsset asset, AVFileTypes outputFileType, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> isCompatibleResult)
	{
		DetermineCompatibilityOfExportPreset(presetName, asset, outputFileType.GetConstant(), isCompatibleResult);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<bool> DetermineCompatibilityOfExportPresetAsync(string presetName, AVAsset asset, AVFileTypes outputFileType)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DetermineCompatibilityOfExportPreset(presetName, asset, outputFileType, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("determineCompatibleFileTypesWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DetermineCompatibleFileTypes([BlockProxy(typeof(Trampolines.NIDActionArity1V1))] Action<string[]> compatibleFileTypesHandler)
	{
		if (compatibleFileTypesHandler == null)
		{
			throw new ArgumentNullException("compatibleFileTypesHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V1.Handler, compatibleFileTypesHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetermineCompatibleFileTypesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetermineCompatibleFileTypesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string[]> DetermineCompatibleFileTypesAsync()
	{
		TaskCompletionSource<string[]> tcs = new TaskCompletionSource<string[]>();
		DetermineCompatibleFileTypes(delegate(string[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("estimateMaximumDurationWithCompletionHandler:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EstimateMaximumDuration([BlockProxy(typeof(Trampolines.NIDActionArity2V0))] Action<CMTime, NSError> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V0.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEstimateMaximumDurationWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEstimateMaximumDurationWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CMTime> EstimateMaximumDurationAsync()
	{
		TaskCompletionSource<CMTime> tcs = new TaskCompletionSource<CMTime>();
		EstimateMaximumDuration(delegate(CMTime arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("estimateOutputFileLengthWithCompletionHandler:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EstimateOutputFileLength([BlockProxy(typeof(Trampolines.NIDActionArity2V1))] Action<long, NSError> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V1.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEstimateOutputFileLengthWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEstimateOutputFileLengthWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<long> EstimateOutputFileLengthAsync()
	{
		TaskCompletionSource<long> tcs = new TaskCompletionSource<long>();
		EstimateOutputFileLength(delegate(long arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("exportAsynchronouslyWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ExportAsynchronously([BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selExportAsynchronouslyWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selExportAsynchronouslyWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ExportTaskAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ExportAsynchronously(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("exportPresetsCompatibleWithAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ExportPresetsCompatibleWithAsset(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExportPresetsCompatibleWithAsset_Handle, asset.Handle));
	}

	[Export("exportSessionWithAsset:presetName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetExportSession? FromAsset(AVAsset asset, string presetName)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (presetName == null)
		{
			throw new ArgumentNullException("presetName");
		}
		IntPtr arg = NSString.CreateNative(presetName);
		AVAssetExportSession nSObject = Runtime.GetNSObject<AVAssetExportSession>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExportSessionWithAsset_PresetName_Handle, asset.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
