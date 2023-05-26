using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriter", true)]
public class AVAssetWriter : NSObject
{
	private static readonly IntPtr selOutputURLHandle = Selector.GetHandle("outputURL");

	private static readonly IntPtr selOutputFileTypeHandle = Selector.GetHandle("outputFileType");

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	private static readonly IntPtr selMovieFragmentIntervalHandle = Selector.GetHandle("movieFragmentInterval");

	private static readonly IntPtr selSetMovieFragmentInterval_Handle = Selector.GetHandle("setMovieFragmentInterval:");

	private static readonly IntPtr selShouldOptimizeForNetworkUseHandle = Selector.GetHandle("shouldOptimizeForNetworkUse");

	private static readonly IntPtr selSetShouldOptimizeForNetworkUse_Handle = Selector.GetHandle("setShouldOptimizeForNetworkUse:");

	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	private static readonly IntPtr selMovieTimeScaleHandle = Selector.GetHandle("movieTimeScale");

	private static readonly IntPtr selSetMovieTimeScale_Handle = Selector.GetHandle("setMovieTimeScale:");

	private static readonly IntPtr selAssetWriterWithURLFileTypeError_Handle = Selector.GetHandle("assetWriterWithURL:fileType:error:");

	private static readonly IntPtr selInitWithURLFileTypeError_Handle = Selector.GetHandle("initWithURL:fileType:error:");

	private static readonly IntPtr selCanApplyOutputSettingsForMediaType_Handle = Selector.GetHandle("canApplyOutputSettings:forMediaType:");

	private static readonly IntPtr selCanAddInput_Handle = Selector.GetHandle("canAddInput:");

	private static readonly IntPtr selAddInput_Handle = Selector.GetHandle("addInput:");

	private static readonly IntPtr selStartWritingHandle = Selector.GetHandle("startWriting");

	private static readonly IntPtr selStartSessionAtSourceTime_Handle = Selector.GetHandle("startSessionAtSourceTime:");

	private static readonly IntPtr selEndSessionAtSourceTime_Handle = Selector.GetHandle("endSessionAtSourceTime:");

	private static readonly IntPtr selCancelWritingHandle = Selector.GetHandle("cancelWriting");

	private static readonly IntPtr selFinishWritingHandle = Selector.GetHandle("finishWriting");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetWriter");

	private object __mt_OutputURL_var;

	private object __mt_Error_var;

	private object __mt_inputs_var;

	private object __mt_Metadata_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl OutputURL
	{
		[Export("outputURL", ArgumentSemantic.Copy)]
		get
		{
			return (NSUrl)(__mt_OutputURL_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputURLHandle)))));
		}
	}

	public virtual string OutputFileType
	{
		[Export("outputFileType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFileTypeHandle));
		}
	}

	public virtual AVAssetWriterStatus Status
	{
		[Export("status")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVAssetWriterStatus)Messaging.int_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVAssetWriterStatus)Messaging.int_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
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

	public virtual CMTime MovieFragmentInterval
	{
		[Export("movieFragmentInterval")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMovieFragmentIntervalHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMovieFragmentIntervalHandle);
			}
			return retval;
		}
		[Export("setMovieFragmentInterval:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMovieFragmentInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMovieFragmentInterval_Handle, value);
			}
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

	public virtual AVAssetWriterInput[] inputs
	{
		[Export("inputs")]
		get
		{
			return (AVAssetWriterInput[])(__mt_inputs_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle)) : NSArray.ArrayFromHandle<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle))));
		}
	}

	public virtual AVMetadataItem[] Metadata
	{
		[Export("metadata")]
		get
		{
			return (AVMetadataItem[])(__mt_Metadata_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle))));
		}
		[Export("setMetadata:")]
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

	public virtual int MovieTimeScale
	{
		[Export("movieTimeScale")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMovieTimeScaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMovieTimeScaleHandle);
		}
		[Export("setMovieTimeScale:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMovieTimeScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMovieTimeScale_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetWriter(NSCoder coder)
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
	public AVAssetWriter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetWriter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetWriterWithURL:fileType:error:")]
	public static AVAssetWriter FromUrl(NSUrl outputUrl, string outputFileType, out NSError error)
	{
		if (outputUrl == null)
		{
			throw new ArgumentNullException("outputUrl");
		}
		if (outputFileType == null)
		{
			throw new ArgumentNullException("outputFileType");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(outputFileType);
		AVAssetWriter result = (AVAssetWriter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selAssetWriterWithURLFileTypeError_Handle, outputUrl.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("initWithURL:fileType:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(outputFileType);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithURLFileTypeError_Handle, outputUrl.Handle, arg, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithURLFileTypeError_Handle, outputUrl.Handle, arg, intPtr);
		}
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("canApplyOutputSettings:forMediaType:")]
	public virtual bool CanApplyOutputSettings(NSDictionary outputSettings, string mediaType)
	{
		if (outputSettings == null)
		{
			throw new ArgumentNullException("outputSettings");
		}
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCanApplyOutputSettingsForMediaType_Handle, outputSettings.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCanApplyOutputSettingsForMediaType_Handle, outputSettings.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	public bool CanApplyOutputSettings(AudioSettings outputSettings, string mediaType)
	{
		return CanApplyOutputSettings(outputSettings?.Dictionary, mediaType);
	}

	public bool CanApplyOutputSettings(AVVideoSettingsCompressed outputSettings, string mediaType)
	{
		return CanApplyOutputSettings(outputSettings?.Dictionary, mediaType);
	}

	[Export("canAddInput:")]
	public virtual bool CanAddInput(AVAssetWriterInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddInput_Handle, input.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddInput_Handle, input.Handle);
	}

	[Export("addInput:")]
	public virtual void AddInput(AVAssetWriterInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddInput_Handle, input.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddInput_Handle, input.Handle);
		}
	}

	[Export("startWriting")]
	public virtual bool StartWriting()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartWritingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartWritingHandle);
	}

	[Export("startSessionAtSourceTime:")]
	public virtual void StartSessionAtSourceTime(CMTime startTime)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selStartSessionAtSourceTime_Handle, startTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selStartSessionAtSourceTime_Handle, startTime);
		}
	}

	[Export("endSessionAtSourceTime:")]
	public virtual void EndSessionAtSourceTime(CMTime endTime)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selEndSessionAtSourceTime_Handle, endTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selEndSessionAtSourceTime_Handle, endTime);
		}
	}

	[Export("cancelWriting")]
	public virtual void CancelWriting()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelWritingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelWritingHandle);
		}
	}

	[Export("finishWriting")]
	[Obsolete("Deprecated in iOS 6.0. Use the asynchronous FinishWriting(NSAction completionHandler) instead", false)]
	public virtual bool FinishWriting()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selFinishWritingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFinishWritingHandle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OutputURL_var = null;
			__mt_Error_var = null;
			__mt_inputs_var = null;
			__mt_Metadata_var = null;
		}
	}
}
