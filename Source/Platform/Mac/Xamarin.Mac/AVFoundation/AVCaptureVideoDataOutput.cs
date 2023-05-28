using System;
using System.ComponentModel;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureVideoDataOutput", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVCaptureVideoDataOutput : AVCaptureOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlwaysDiscardsLateVideoFrames = "alwaysDiscardsLateVideoFrames";

	private static readonly IntPtr selAlwaysDiscardsLateVideoFramesHandle = Selector.GetHandle("alwaysDiscardsLateVideoFrames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableVideoCVPixelFormatTypes = "availableVideoCVPixelFormatTypes";

	private static readonly IntPtr selAvailableVideoCVPixelFormatTypesHandle = Selector.GetHandle("availableVideoCVPixelFormatTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableVideoCodecTypes = "availableVideoCodecTypes";

	private static readonly IntPtr selAvailableVideoCodecTypesHandle = Selector.GetHandle("availableVideoCodecTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_ = "availableVideoCodecTypesForAssetWriterWithOutputFileType:";

	private static readonly IntPtr selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_Handle = Selector.GetHandle("availableVideoCodecTypesForAssetWriterWithOutputFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFrameDuration = "minFrameDuration";

	private static readonly IntPtr selMinFrameDurationHandle = Selector.GetHandle("minFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecommendedVideoSettingsForAssetWriterWithOutputFileType_ = "recommendedVideoSettingsForAssetWriterWithOutputFileType:";

	private static readonly IntPtr selRecommendedVideoSettingsForAssetWriterWithOutputFileType_Handle = Selector.GetHandle("recommendedVideoSettingsForAssetWriterWithOutputFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_ = "recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:";

	private static readonly IntPtr selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_Handle = Selector.GetHandle("recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleBufferCallbackQueue = "sampleBufferCallbackQueue";

	private static readonly IntPtr selSampleBufferCallbackQueueHandle = Selector.GetHandle("sampleBufferCallbackQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleBufferDelegate = "sampleBufferDelegate";

	private static readonly IntPtr selSampleBufferDelegateHandle = Selector.GetHandle("sampleBufferDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlwaysDiscardsLateVideoFrames_ = "setAlwaysDiscardsLateVideoFrames:";

	private static readonly IntPtr selSetAlwaysDiscardsLateVideoFrames_Handle = Selector.GetHandle("setAlwaysDiscardsLateVideoFrames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinFrameDuration_ = "setMinFrameDuration:";

	private static readonly IntPtr selSetMinFrameDuration_Handle = Selector.GetHandle("setMinFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleBufferDelegate_Queue_ = "setSampleBufferDelegate:queue:";

	private static readonly IntPtr selSetSampleBufferDelegate_Queue_Handle = Selector.GetHandle("setSampleBufferDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoSettings_ = "setVideoSettings:";

	private static readonly IntPtr selSetVideoSettings_Handle = Selector.GetHandle("setVideoSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoSettings = "videoSettings";

	private static readonly IntPtr selVideoSettingsHandle = Selector.GetHandle("videoSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureVideoDataOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AlwaysDiscardsLateVideoFrames
	{
		[Export("alwaysDiscardsLateVideoFrames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysDiscardsLateVideoFramesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysDiscardsLateVideoFramesHandle);
		}
		[Export("setAlwaysDiscardsLateVideoFrames:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysDiscardsLateVideoFrames_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysDiscardsLateVideoFrames_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] AvailableVideoCVPixelFormatTypes
	{
		[Export("availableVideoCVPixelFormatTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableVideoCVPixelFormatTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableVideoCVPixelFormatTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] AvailableVideoCodecTypes
	{
		[Export("availableVideoCodecTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableVideoCodecTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableVideoCodecTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVVideoSettingsCompressed CompressedVideoSetting
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakVideoSettings != null) ? new NSMutableDictionary(WeakVideoSettings) : null);
			return (nSMutableDictionary == null) ? null : new AVVideoSettingsCompressed(nSMutableDictionary);
		}
		set
		{
			WeakVideoSettings = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 5, 0, PlatformArchitecture.All, "Use 'AVCaptureConnection.MinVideoFrameDuration' instead.")]
	public virtual CMTime MinFrameDuration
	{
		[Deprecated(PlatformName.iOS, 5, 0, PlatformArchitecture.All, "Use 'AVCaptureConnection.MinVideoFrameDuration' instead.")]
		[Export("minFrameDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMinFrameDurationHandle);
			}
			return retval;
		}
		[Deprecated(PlatformName.iOS, 5, 0, PlatformArchitecture.All, "Use 'AVCaptureConnection.MinVideoFrameDuration' instead.")]
		[Export("setMinFrameDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetMinFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetMinFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DispatchQueue? SampleBufferCallbackQueue
	{
		[Export("sampleBufferCallbackQueue")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferCallbackQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferCallbackQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IAVCaptureVideoDataOutputSampleBufferDelegate? SampleBufferDelegate
	{
		[Export("sampleBufferDelegate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IAVCaptureVideoDataOutputSampleBufferDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferDelegateHandle), owns: false);
			}
			return Runtime.GetINativeObject<IAVCaptureVideoDataOutputSampleBufferDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferDelegateHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVVideoSettingsUncompressed UncompressedVideoSetting
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakVideoSettings != null) ? new NSMutableDictionary(WeakVideoSettings) : null);
			return (nSMutableDictionary == null) ? null : new AVVideoSettingsUncompressed(nSMutableDictionary);
		}
		set
		{
			WeakVideoSettings = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? WeakVideoSettings
	{
		[Export("videoSettings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoSettingsHandle));
		}
		[Export("setVideoSettings:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoSettings_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoSettings_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureVideoDataOutput()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureVideoDataOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureVideoDataOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("availableVideoCodecTypesForAssetWriterWithOutputFileType:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetAvailableVideoCodecTypes(string outputFileType)
	{
		if (outputFileType == null)
		{
			throw new ArgumentNullException("outputFileType");
		}
		IntPtr arg = NSString.CreateNative(outputFileType);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAvailableVideoCodecTypesForAssetWriterWithOutputFileType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItemVideoOutputSettings? GetRecommendedVideoSettings(string videoCodecType, string outputFileType)
	{
		return new AVPlayerItemVideoOutputSettings(GetWeakRecommendedVideoSettings(videoCodecType, outputFileType));
	}

	[Export("recommendedVideoSettingsForAssetWriterWithOutputFileType:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? GetRecommendedVideoSettingsForAssetWriter(string outputFileType)
	{
		if (outputFileType == null)
		{
			throw new ArgumentNullException("outputFileType");
		}
		IntPtr arg = NSString.CreateNative(outputFileType);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecommendedVideoSettingsForAssetWriterWithOutputFileType_Handle, arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRecommendedVideoSettingsForAssetWriterWithOutputFileType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("recommendedVideoSettingsForVideoCodecType:assetWriterOutputFileType:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSDictionary? GetWeakRecommendedVideoSettings(string videoCodecType, string outputFileType)
	{
		if (videoCodecType == null)
		{
			throw new ArgumentNullException("videoCodecType");
		}
		if (outputFileType == null)
		{
			throw new ArgumentNullException("outputFileType");
		}
		IntPtr arg = NSString.CreateNative(videoCodecType);
		IntPtr arg2 = NSString.CreateNative(outputFileType);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_Handle, arg, arg2)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selRecommendedVideoSettingsForVideoCodecType_AssetWriterOutputFileType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setSampleBufferDelegate:queue:")]
	[Obsolete("Use overload accepting a 'IAVCaptureVideoDataOutputSampleBufferDelegate'.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSampleBufferDelegate(AVCaptureVideoDataOutputSampleBufferDelegate? sampleBufferDelegate, DispatchQueue? sampleBufferCallbackQueue)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSampleBufferDelegate_Queue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackQueue == null) ? IntPtr.Zero : sampleBufferCallbackQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetSampleBufferDelegate_Queue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackQueue == null) ? IntPtr.Zero : sampleBufferCallbackQueue.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSampleBufferDelegateQueue(IAVCaptureVideoDataOutputSampleBufferDelegate? sampleBufferDelegate, DispatchQueue? sampleBufferCallbackQueue)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSampleBufferDelegate_Queue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackQueue == null) ? IntPtr.Zero : sampleBufferCallbackQueue.Handle);
	}
}
