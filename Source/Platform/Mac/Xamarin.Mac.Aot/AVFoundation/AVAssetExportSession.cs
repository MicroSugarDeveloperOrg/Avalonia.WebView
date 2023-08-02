using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetExportSession", true)]
public class AVAssetExportSession : NSObject
{
	private static readonly IntPtr selPresetNameHandle = Selector.GetHandle("presetName");

	private static readonly IntPtr selSupportedFileTypesHandle = Selector.GetHandle("supportedFileTypes");

	private static readonly IntPtr selOutputFileTypeHandle = Selector.GetHandle("outputFileType");

	private static readonly IntPtr selSetOutputFileType_Handle = Selector.GetHandle("setOutputFileType:");

	private static readonly IntPtr selOutputURLHandle = Selector.GetHandle("outputURL");

	private static readonly IntPtr selSetOutputURL_Handle = Selector.GetHandle("setOutputURL:");

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	private static readonly IntPtr selProgressHandle = Selector.GetHandle("progress");

	private static readonly IntPtr selMaxDurationHandle = Selector.GetHandle("maxDuration");

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	private static readonly IntPtr selSetTimeRange_Handle = Selector.GetHandle("setTimeRange:");

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	private static readonly IntPtr selFileLengthLimitHandle = Selector.GetHandle("fileLengthLimit");

	private static readonly IntPtr selSetFileLengthLimit_Handle = Selector.GetHandle("setFileLengthLimit:");

	private static readonly IntPtr selAudioMixHandle = Selector.GetHandle("audioMix");

	private static readonly IntPtr selSetAudioMix_Handle = Selector.GetHandle("setAudioMix:");

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	private static readonly IntPtr selSetVideoComposition_Handle = Selector.GetHandle("setVideoComposition:");

	private static readonly IntPtr selShouldOptimizeForNetworkUseHandle = Selector.GetHandle("shouldOptimizeForNetworkUse");

	private static readonly IntPtr selSetShouldOptimizeForNetworkUse_Handle = Selector.GetHandle("setShouldOptimizeForNetworkUse:");

	private static readonly IntPtr selAllExportPresetsHandle = Selector.GetHandle("allExportPresets");

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	private static readonly IntPtr selEstimatedOutputFileLengthHandle = Selector.GetHandle("estimatedOutputFileLength");

	private static readonly IntPtr selExportSessionWithAssetPresetName_Handle = Selector.GetHandle("exportSessionWithAsset:presetName:");

	private static readonly IntPtr selExportPresetsCompatibleWithAsset_Handle = Selector.GetHandle("exportPresetsCompatibleWithAsset:");

	private static readonly IntPtr selInitWithAssetPresetName_Handle = Selector.GetHandle("initWithAsset:presetName:");

	private static readonly IntPtr selExportAsynchronouslyWithCompletionHandler_Handle = Selector.GetHandle("exportAsynchronouslyWithCompletionHandler:");

	private static readonly IntPtr selCancelExportHandle = Selector.GetHandle("cancelExport");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetExportSession");

	private object __mt_SupportedFileTypes_var;

	private object __mt_OutputUrl_var;

	private object __mt_Metadata_var;

	private object __mt_AudioMix_var;

	private object __mt_VideoComposition_var;

	private object __mt_Error_var;

	private object __mt_Asset_var;

	private static NSString _Preset640x480;

	private static NSString _Preset960x540;

	private static NSString _Preset1280x720;

	private static NSString _PresetAppleM4A;

	private static NSString _PresetPassthrough;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string PresetName
	{
		[Export("presetName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPresetNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresetNameHandle));
		}
	}

	public virtual NSObject[] SupportedFileTypes
	{
		[Export("supportedFileTypes")]
		get
		{
			return (NSObject[])(__mt_SupportedFileTypes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedFileTypesHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedFileTypesHandle))));
		}
	}

	public virtual string OutputFileType
	{
		[Export("outputFileType", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFileTypeHandle));
		}
		[Export("setOutputFileType:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual NSUrl OutputUrl
	{
		[Export("outputURL", ArgumentSemantic.Copy)]
		get
		{
			return (NSUrl)(__mt_OutputUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputURLHandle)))));
		}
		[Export("setOutputURL:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputURL_Handle, value.Handle);
			}
			__mt_OutputUrl_var = value;
		}
	}

	public virtual AVAssetExportSessionStatus Status
	{
		[Export("status")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVAssetExportSessionStatus)Messaging.int_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVAssetExportSessionStatus)Messaging.int_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	public virtual float Progress
	{
		[Export("progress")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selProgressHandle);
		}
	}

	public virtual CMTime MaxDuration
	{
		[Export("maxDuration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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
		[Export("setTimeRange:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selSetTimeRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selSetTimeRange_Handle, value);
			}
		}
	}

	public virtual AVMetadataItem[] Metadata
	{
		[Export("metadata", ArgumentSemantic.Copy)]
		get
		{
			return (AVMetadataItem[])(__mt_Metadata_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle))));
		}
		[Export("setMetadata:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Metadata_var = value;
		}
	}

	public virtual long FileLengthLimit
	{
		[Export("fileLengthLimit")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFileLengthLimitHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFileLengthLimitHandle);
		}
		[Export("setFileLengthLimit:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFileLengthLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFileLengthLimit_Handle, value);
			}
		}
	}

	public virtual AVAudioMix AudioMix
	{
		[Export("audioMix", ArgumentSemantic.Copy)]
		get
		{
			return (AVAudioMix)(__mt_AudioMix_var = ((!IsDirectBinding) ? ((AVAudioMix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioMixHandle))) : ((AVAudioMix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioMixHandle)))));
		}
		[Export("setAudioMix:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioMix_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioMix_Handle, value.Handle);
			}
			__mt_AudioMix_var = value;
		}
	}

	public virtual AVVideoComposition VideoComposition
	{
		[Export("videoComposition", ArgumentSemantic.Copy)]
		get
		{
			return (AVVideoComposition)(__mt_VideoComposition_var = ((!IsDirectBinding) ? ((AVVideoComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionHandle))) : ((AVVideoComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionHandle)))));
		}
		[Export("setVideoComposition:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoComposition_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoComposition_Handle, value.Handle);
			}
			__mt_VideoComposition_var = value;
		}
	}

	public virtual bool ShouldOptimizeForNetworkUse
	{
		[Export("shouldOptimizeForNetworkUse")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldOptimizeForNetworkUseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldOptimizeForNetworkUseHandle);
		}
		[Export("setShouldOptimizeForNetworkUse:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldOptimizeForNetworkUse_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldOptimizeForNetworkUse_Handle, value);
			}
		}
	}

	public static string[] AllExportPresets
	{
		[Export("allExportPresets")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAllExportPresetsHandle));
		}
	}

	public virtual NSError Error
	{
		[Export("error")]
		get
		{
			return (NSError)(__mt_Error_var = ((!IsDirectBinding) ? ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle))) : ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle)))));
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

	public virtual long EstimatedOutputFileLength
	{
		[Export("estimatedOutputFileLength")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selEstimatedOutputFileLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEstimatedOutputFileLengthHandle);
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetExportSession(NSCoder coder)
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
	public AVAssetExportSession(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetExportSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("exportSessionWithAsset:presetName:")]
	public static AVAssetExportSession FromAsset(AVAsset asset, string presetName)
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
		AVAssetExportSession result = (AVAssetExportSession)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selExportSessionWithAssetPresetName_Handle, asset.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("exportPresetsCompatibleWithAsset:")]
	public static string[] ExportPresetsCompatibleWithAsset(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExportPresetsCompatibleWithAsset_Handle, asset.Handle));
	}

	[Export("initWithAsset:presetName:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAssetPresetName_Handle, asset.Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAssetPresetName_Handle, asset.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("exportAsynchronouslyWithCompletionHandler:")]
	public unsafe virtual void ExportAsynchronously(AVCompletionHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDAVCompletionHandler.Handler, handler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selExportAsynchronouslyWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selExportAsynchronouslyWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	public virtual Task ExportTaskAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ExportAsynchronously(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("cancelExport")]
	public virtual void CancelExport()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelExportHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelExportHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SupportedFileTypes_var = null;
			__mt_OutputUrl_var = null;
			__mt_Metadata_var = null;
			__mt_AudioMix_var = null;
			__mt_VideoComposition_var = null;
			__mt_Error_var = null;
			__mt_Asset_var = null;
		}
	}
}
