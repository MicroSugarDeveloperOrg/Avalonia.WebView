using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriter", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetWriter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddInput_ = "addInput:";

	private static readonly IntPtr selAddInput_Handle = Selector.GetHandle("addInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddInputGroup_ = "addInputGroup:";

	private static readonly IntPtr selAddInputGroup_Handle = Selector.GetHandle("addInputGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterWithURL_FileType_Error_ = "assetWriterWithURL:fileType:error:";

	private static readonly IntPtr selAssetWriterWithURL_FileType_Error_Handle = Selector.GetHandle("assetWriterWithURL:fileType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableMediaTypes = "availableMediaTypes";

	private static readonly IntPtr selAvailableMediaTypesHandle = Selector.GetHandle("availableMediaTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddInput_ = "canAddInput:";

	private static readonly IntPtr selCanAddInput_Handle = Selector.GetHandle("canAddInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddInputGroup_ = "canAddInputGroup:";

	private static readonly IntPtr selCanAddInputGroup_Handle = Selector.GetHandle("canAddInputGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanApplyOutputSettings_ForMediaType_ = "canApplyOutputSettings:forMediaType:";

	private static readonly IntPtr selCanApplyOutputSettings_ForMediaType_Handle = Selector.GetHandle("canApplyOutputSettings:forMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelWriting = "cancelWriting";

	private static readonly IntPtr selCancelWritingHandle = Selector.GetHandle("cancelWriting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirectoryForTemporaryFiles = "directoryForTemporaryFiles";

	private static readonly IntPtr selDirectoryForTemporaryFilesHandle = Selector.GetHandle("directoryForTemporaryFiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndSessionAtSourceTime_ = "endSessionAtSourceTime:";

	private static readonly IntPtr selEndSessionAtSourceTime_Handle = Selector.GetHandle("endSessionAtSourceTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishWriting = "finishWriting";

	private static readonly IntPtr selFinishWritingHandle = Selector.GetHandle("finishWriting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishWritingWithCompletionHandler_ = "finishWritingWithCompletionHandler:";

	private static readonly IntPtr selFinishWritingWithCompletionHandler_Handle = Selector.GetHandle("finishWritingWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_FileType_Error_ = "initWithURL:fileType:error:";

	private static readonly IntPtr selInitWithURL_FileType_Error_Handle = Selector.GetHandle("initWithURL:fileType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputGroups = "inputGroups";

	private static readonly IntPtr selInputGroupsHandle = Selector.GetHandle("inputGroups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputs = "inputs";

	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieFragmentInterval = "movieFragmentInterval";

	private static readonly IntPtr selMovieFragmentIntervalHandle = Selector.GetHandle("movieFragmentInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovieTimeScale = "movieTimeScale";

	private static readonly IntPtr selMovieTimeScaleHandle = Selector.GetHandle("movieTimeScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFileType = "outputFileType";

	private static readonly IntPtr selOutputFileTypeHandle = Selector.GetHandle("outputFileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputURL = "outputURL";

	private static readonly IntPtr selOutputURLHandle = Selector.GetHandle("outputURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverallDurationHint = "overallDurationHint";

	private static readonly IntPtr selOverallDurationHintHandle = Selector.GetHandle("overallDurationHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirectoryForTemporaryFiles_ = "setDirectoryForTemporaryFiles:";

	private static readonly IntPtr selSetDirectoryForTemporaryFiles_Handle = Selector.GetHandle("setDirectoryForTemporaryFiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovieFragmentInterval_ = "setMovieFragmentInterval:";

	private static readonly IntPtr selSetMovieFragmentInterval_Handle = Selector.GetHandle("setMovieFragmentInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovieTimeScale_ = "setMovieTimeScale:";

	private static readonly IntPtr selSetMovieTimeScale_Handle = Selector.GetHandle("setMovieTimeScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverallDurationHint_ = "setOverallDurationHint:";

	private static readonly IntPtr selSetOverallDurationHint_Handle = Selector.GetHandle("setOverallDurationHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldOptimizeForNetworkUse_ = "setShouldOptimizeForNetworkUse:";

	private static readonly IntPtr selSetShouldOptimizeForNetworkUse_Handle = Selector.GetHandle("setShouldOptimizeForNetworkUse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldOptimizeForNetworkUse = "shouldOptimizeForNetworkUse";

	private static readonly IntPtr selShouldOptimizeForNetworkUseHandle = Selector.GetHandle("shouldOptimizeForNetworkUse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartSessionAtSourceTime_ = "startSessionAtSourceTime:";

	private static readonly IntPtr selStartSessionAtSourceTime_Handle = Selector.GetHandle("startSessionAtSourceTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartWriting = "startWriting";

	private static readonly IntPtr selStartWritingHandle = Selector.GetHandle("startWriting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetWriter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] AvailableMediaTypes
	{
		[Export("availableMediaTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableMediaTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableMediaTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual AVAssetWriterInputGroup[] InputGroups
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("inputGroups")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetWriterInputGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputGroupsHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetWriterInputGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputGroupsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] Metadata
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
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime MovieFragmentInterval
	{
		[Export("movieFragmentInterval", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMovieFragmentIntervalHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMovieFragmentIntervalHandle);
			}
			return retval;
		}
		[Export("setMovieFragmentInterval:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMovieFragmentInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMovieFragmentInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int MovieTimeScale
	{
		[Export("movieTimeScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMovieTimeScaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMovieTimeScaleHandle);
		}
		[Export("setMovieTimeScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMovieTimeScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMovieTimeScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string OutputFileType
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl OutputURL
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual CMTime OverallDurationHint
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("overallDurationHint", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selOverallDurationHintHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOverallDurationHintHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setOverallDurationHint:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetOverallDurationHint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetOverallDurationHint_Handle, value);
			}
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
	public virtual AVAssetWriterStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAssetWriterStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVAssetWriterStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetWriterInput[] inputs
	{
		[Export("inputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetWriter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetWriter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:fileType:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriter(NSUrl outputUrl, string outputFileType, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (outputUrl == null)
		{
			throw new ArgumentNullException("outputUrl");
		}
		if (outputFileType == null)
		{
			throw new ArgumentNullException("outputFileType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(outputFileType);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_FileType_Error_Handle, outputUrl.Handle, arg2, ref arg), "initWithURL:fileType:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_FileType_Error_Handle, outputUrl.Handle, arg2, ref arg), "initWithURL:fileType:error:");
		}
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("addInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddInput(AVAssetWriterInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddInput_Handle, input.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddInput_Handle, input.Handle);
		}
	}

	[Export("addInputGroup:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddInputGroup(AVAssetWriterInputGroup inputGroup)
	{
		if (inputGroup == null)
		{
			throw new ArgumentNullException("inputGroup");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddInputGroup_Handle, inputGroup.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddInputGroup_Handle, inputGroup.Handle);
		}
	}

	[Export("canAddInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddInput(AVAssetWriterInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddInput_Handle, input.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddInput_Handle, input.Handle);
	}

	[Export("canAddInputGroup:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddInputGroup(AVAssetWriterInputGroup inputGroup)
	{
		if (inputGroup == null)
		{
			throw new ArgumentNullException("inputGroup");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddInputGroup_Handle, inputGroup.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddInputGroup_Handle, inputGroup.Handle);
	}

	[Export("canApplyOutputSettings:forMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanApplyOutputSettings(NSDictionary? outputSettings, string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCanApplyOutputSettings_ForMediaType_Handle, outputSettings?.Handle ?? IntPtr.Zero, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCanApplyOutputSettings_ForMediaType_Handle, outputSettings?.Handle ?? IntPtr.Zero, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CanApplyOutputSettings(AudioSettings outputSettings, string mediaType)
	{
		return CanApplyOutputSettings(outputSettings.GetDictionary(), mediaType);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CanApplyOutputSettings(AVVideoSettingsCompressed outputSettings, string mediaType)
	{
		return CanApplyOutputSettings(outputSettings.GetDictionary(), mediaType);
	}

	[Export("cancelWriting")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelWriting()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelWritingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelWritingHandle);
		}
	}

	[Export("endSessionAtSourceTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndSessionAtSourceTime(CMTime endTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selEndSessionAtSourceTime_Handle, endTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selEndSessionAtSourceTime_Handle, endTime);
		}
	}

	[Export("finishWriting")]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use the asynchronous 'FinishWriting (NSAction completionHandler)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use the asynchronous 'FinishWriting (NSAction completionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FinishWriting()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selFinishWritingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFinishWritingHandle);
	}

	[Export("finishWritingWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FinishWriting([BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinishWritingWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinishWritingWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task FinishWritingAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		FinishWriting(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("assetWriterWithURL:fileType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriter? FromUrl(NSUrl outputUrl, string outputFileType, out NSError error)
	{
		if (outputUrl == null)
		{
			throw new ArgumentNullException("outputUrl");
		}
		if (outputFileType == null)
		{
			throw new ArgumentNullException("outputFileType");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(outputFileType);
		AVAssetWriter nSObject = Runtime.GetNSObject<AVAssetWriter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selAssetWriterWithURL_FileType_Error_Handle, outputUrl.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("startSessionAtSourceTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartSessionAtSourceTime(CMTime startTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selStartSessionAtSourceTime_Handle, startTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selStartSessionAtSourceTime_Handle, startTime);
		}
	}

	[Export("startWriting")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartWriting()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartWritingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartWritingHandle);
	}
}
