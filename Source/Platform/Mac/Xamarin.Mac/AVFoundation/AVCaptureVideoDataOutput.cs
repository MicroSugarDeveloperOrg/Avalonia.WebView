using System;
using System.ComponentModel;
using CoreFoundation;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureVideoDataOutput", true)]
public class AVCaptureVideoDataOutput : AVCaptureOutput
{
	private static readonly IntPtr selSampleBufferDelegateHandle = Selector.GetHandle("sampleBufferDelegate");

	private static readonly IntPtr selSampleBufferCallbackQueueHandle = Selector.GetHandle("sampleBufferCallbackQueue");

	private static readonly IntPtr selVideoSettingsHandle = Selector.GetHandle("videoSettings");

	private static readonly IntPtr selSetVideoSettings_Handle = Selector.GetHandle("setVideoSettings:");

	private static readonly IntPtr selMinFrameDurationHandle = Selector.GetHandle("minFrameDuration");

	private static readonly IntPtr selSetMinFrameDuration_Handle = Selector.GetHandle("setMinFrameDuration:");

	private static readonly IntPtr selAlwaysDiscardsLateVideoFramesHandle = Selector.GetHandle("alwaysDiscardsLateVideoFrames");

	private static readonly IntPtr selSetAlwaysDiscardsLateVideoFrames_Handle = Selector.GetHandle("setAlwaysDiscardsLateVideoFrames:");

	private static readonly IntPtr selAvailableVideoCVPixelFormatTypesHandle = Selector.GetHandle("availableVideoCVPixelFormatTypes");

	private static readonly IntPtr selAvailableVideoCodecTypesHandle = Selector.GetHandle("availableVideoCodecTypes");

	private static readonly IntPtr selSetSampleBufferDelegateQueue_Handle = Selector.GetHandle("setSampleBufferDelegate:queue:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureVideoDataOutput");

	private object __mt_SampleBufferDelegate_var;

	private object __mt_WeakVideoSettings_var;

	private object __mt_AvailableVideoCVPixelFormatTypes_var;

	private object __mt_AvailableVideoCodecTypes_var;

	[Advice("Use Compressed or Uncompressed property")]
	public AVVideoSettings VideoSettings
	{
		get
		{
			if (WeakVideoSettings.TryGetValue(CVPixelBuffer.PixelFormatTypeKey, out var value) && value is NSNumber)
			{
				return new AVVideoSettings((CVPixelFormatType)(value as NSNumber).Int32Value);
			}
			return new AVVideoSettings();
		}
		set
		{
			WeakVideoSettings = value?.ToDictionary();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVCaptureVideoDataOutputSampleBufferDelegate SampleBufferDelegate
	{
		[Export("sampleBufferDelegate")]
		get
		{
			return (AVCaptureVideoDataOutputSampleBufferDelegate)(__mt_SampleBufferDelegate_var = ((!IsDirectBinding) ? ((AVCaptureVideoDataOutputSampleBufferDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferDelegateHandle))) : ((AVCaptureVideoDataOutputSampleBufferDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferDelegateHandle)))));
		}
	}

	public virtual DispatchQueue SampleBufferCallbackQueue
	{
		[Export("sampleBufferCallbackQueue")]
		get
		{
			if (IsDirectBinding)
			{
				return new DispatchQueue(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferCallbackQueueHandle));
			}
			return new DispatchQueue(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferCallbackQueueHandle));
		}
	}

	public virtual NSDictionary WeakVideoSettings
	{
		[Export("videoSettings", ArgumentSemantic.Copy)]
		get
		{
			return (NSDictionary)(__mt_WeakVideoSettings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoSettingsHandle)))));
		}
		[Export("setVideoSettings:", ArgumentSemantic.Copy)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoSettings_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoSettings_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakVideoSettings_var = value;
		}
	}

	public AVVideoSettingsUncompressed UncompressedVideoSetting
	{
		get
		{
			NSDictionary weakVideoSettings = WeakVideoSettings;
			if (weakVideoSettings != null)
			{
				return new AVVideoSettingsUncompressed(weakVideoSettings);
			}
			return null;
		}
		set
		{
			WeakVideoSettings = value?.Dictionary;
		}
	}

	public AVVideoSettingsCompressed CompressedVideoSetting
	{
		get
		{
			NSDictionary weakVideoSettings = WeakVideoSettings;
			if (weakVideoSettings != null)
			{
				return new AVVideoSettingsCompressed(weakVideoSettings);
			}
			return null;
		}
		set
		{
			WeakVideoSettings = value?.Dictionary;
		}
	}

	[Obsolete("Deprecated in iOS 5.0. Use AVCaptureConnection's MinVideoFrameDuration", false)]
	public virtual CMTime MinFrameDuration
	{
		[Export("minFrameDuration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMinFrameDurationHandle);
			}
			return retval;
		}
		[Export("setMinFrameDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMinFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMinFrameDuration_Handle, value);
			}
		}
	}

	public virtual bool AlwaysDiscardsLateVideoFrames
	{
		[Export("alwaysDiscardsLateVideoFrames")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysDiscardsLateVideoFramesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysDiscardsLateVideoFramesHandle);
		}
		[Export("setAlwaysDiscardsLateVideoFrames:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysDiscardsLateVideoFrames_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysDiscardsLateVideoFrames_Handle, value);
			}
		}
	}

	public virtual NSNumber[] AvailableVideoCVPixelFormatTypes
	{
		[Export("availableVideoCVPixelFormatTypes")]
		get
		{
			return (NSNumber[])(__mt_AvailableVideoCVPixelFormatTypes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableVideoCVPixelFormatTypesHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableVideoCVPixelFormatTypesHandle))));
		}
	}

	public virtual NSString[] AvailableVideoCodecTypes
	{
		[Export("availableVideoCodecTypes")]
		get
		{
			return (NSString[])(__mt_AvailableVideoCodecTypes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableVideoCodecTypesHandle)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableVideoCodecTypesHandle))));
		}
	}

	[Advice("Use SetSampleBufferDelegate")]
	public void SetSampleBufferDelegateAndQueue(AVCaptureVideoDataOutputSampleBufferDelegate sampleBufferDelegate, DispatchQueue queue)
	{
		SetSampleBufferDelegate(sampleBufferDelegate, queue);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureVideoDataOutput()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVCaptureVideoDataOutput(NSCoder coder)
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
	public AVCaptureVideoDataOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureVideoDataOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setSampleBufferDelegate:queue:")]
	public virtual void SetSampleBufferDelegate(AVCaptureVideoDataOutputSampleBufferDelegate sampleBufferDelegate, DispatchQueue sampleBufferCallbackQueue)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSampleBufferDelegateQueue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackQueue == null) ? IntPtr.Zero : sampleBufferCallbackQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetSampleBufferDelegateQueue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackQueue == null) ? IntPtr.Zero : sampleBufferCallbackQueue.Handle);
		}
		_ = SampleBufferDelegate;
		_ = SampleBufferCallbackQueue;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SampleBufferDelegate_var = null;
			__mt_WeakVideoSettings_var = null;
			__mt_AvailableVideoCVPixelFormatTypes_var = null;
			__mt_AvailableVideoCodecTypes_var = null;
		}
	}
}
