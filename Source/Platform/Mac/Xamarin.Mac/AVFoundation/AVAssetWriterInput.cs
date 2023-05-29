using System;
using System.ComponentModel;
using CoreFoundation;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriterInput", true)]
public class AVAssetWriterInput : NSObject
{
	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	private static readonly IntPtr selOutputSettingsHandle = Selector.GetHandle("outputSettings");

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	private static readonly IntPtr selSetTransform_Handle = Selector.GetHandle("setTransform:");

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	private static readonly IntPtr selIsReadyForMoreMediaDataHandle = Selector.GetHandle("isReadyForMoreMediaData");

	private static readonly IntPtr selExpectsMediaDataInRealTimeHandle = Selector.GetHandle("expectsMediaDataInRealTime");

	private static readonly IntPtr selSetExpectsMediaDataInRealTime_Handle = Selector.GetHandle("setExpectsMediaDataInRealTime:");

	private static readonly IntPtr selMediaTimeScaleHandle = Selector.GetHandle("mediaTimeScale");

	private static readonly IntPtr selSetMediaTimeScale_Handle = Selector.GetHandle("setMediaTimeScale:");

	private static readonly IntPtr selAssetWriterInputWithMediaTypeOutputSettings_Handle = Selector.GetHandle("assetWriterInputWithMediaType:outputSettings:");

	private static readonly IntPtr selInitWithMediaTypeOutputSettings_Handle = Selector.GetHandle("initWithMediaType:outputSettings:");

	private static readonly IntPtr selRequestMediaDataWhenReadyOnQueueUsingBlock_Handle = Selector.GetHandle("requestMediaDataWhenReadyOnQueue:usingBlock:");

	private static readonly IntPtr selAppendSampleBuffer_Handle = Selector.GetHandle("appendSampleBuffer:");

	private static readonly IntPtr selMarkAsFinishedHandle = Selector.GetHandle("markAsFinished");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetWriterInput");

	private object __mt_OutputSettings_var;

	private object __mt_Metadata_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual NSDictionary OutputSettings
	{
		[Export("outputSettings")]
		get
		{
			return (NSDictionary)(__mt_OutputSettings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputSettingsHandle)))));
		}
	}

	public virtual CGAffineTransform Transform
	{
		[Export("transform")]
		get
		{
			CGAffineTransform retval;
			if (IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTransformHandle);
			}
			return retval;
		}
		[Export("setTransform:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetTransform_Handle, value);
			}
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

	public virtual bool ReadyForMoreMediaData
	{
		[Export("isReadyForMoreMediaData")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadyForMoreMediaDataHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadyForMoreMediaDataHandle);
		}
	}

	public virtual bool ExpectsMediaDataInRealTime
	{
		[Export("expectsMediaDataInRealTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selExpectsMediaDataInRealTimeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selExpectsMediaDataInRealTimeHandle);
		}
		[Export("setExpectsMediaDataInRealTime:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExpectsMediaDataInRealTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExpectsMediaDataInRealTime_Handle, value);
			}
		}
	}

	public virtual int MediaTimeScale
	{
		[Export("mediaTimeScale")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMediaTimeScaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMediaTimeScaleHandle);
		}
		[Export("setMediaTimeScale:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMediaTimeScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMediaTimeScale_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetWriterInput(NSCoder coder)
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
	public AVAssetWriterInput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetWriterInput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetWriterInputWithMediaType:outputSettings:")]
	public static AVAssetWriterInput FromType(string mediaType, NSDictionary outputSettings)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVAssetWriterInput result = (AVAssetWriterInput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetWriterInputWithMediaTypeOutputSettings_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return result;
	}

	public static AVAssetWriterInput Create(string mediaType, AudioSettings outputSettings)
	{
		return FromType(mediaType, outputSettings?.Dictionary);
	}

	public static AVAssetWriterInput Create(string mediaType, AVVideoSettingsCompressed outputSettings)
	{
		return FromType(mediaType, outputSettings?.Dictionary);
	}

	[Export("initWithMediaType:outputSettings:")]
	public AVAssetWriterInput(string mediaType, NSDictionary outputSettings)
		: base(NSObjectFlag.Empty)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithMediaTypeOutputSettings_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithMediaTypeOutputSettings_Handle, arg, outputSettings?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	public AVAssetWriterInput(string mediaType, AudioSettings outputSettings)
		: this(mediaType, outputSettings?.Dictionary)
	{
	}

	public AVAssetWriterInput(string mediaType, AVVideoSettingsCompressed outputSettings)
		: this(mediaType, outputSettings?.Dictionary)
	{
	}

	[Export("requestMediaDataWhenReadyOnQueue:usingBlock:")]
	public unsafe virtual void RequestMediaData(DispatchQueue queue, NSAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, action);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRequestMediaDataWhenReadyOnQueueUsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRequestMediaDataWhenReadyOnQueueUsingBlock_Handle, queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("appendSampleBuffer:")]
	public virtual bool AppendSampleBuffer(CMSampleBuffer sampleBuffer)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAppendSampleBuffer_Handle, sampleBuffer.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendSampleBuffer_Handle, sampleBuffer.Handle);
	}

	[Export("markAsFinished")]
	public virtual void MarkAsFinished()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMarkAsFinishedHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMarkAsFinishedHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OutputSettings_var = null;
			__mt_Metadata_var = null;
		}
	}
}
