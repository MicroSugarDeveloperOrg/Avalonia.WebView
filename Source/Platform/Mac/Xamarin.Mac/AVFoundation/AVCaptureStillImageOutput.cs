using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureStillImageOutput", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'AVCapturePhotoOutput' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AVCapturePhotoOutput' instead.")]
public class AVCaptureStillImageOutput : AVCaptureOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableImageDataCVPixelFormatTypes = "availableImageDataCVPixelFormatTypes";

	private static readonly IntPtr selAvailableImageDataCVPixelFormatTypesHandle = Selector.GetHandle("availableImageDataCVPixelFormatTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableImageDataCodecTypes = "availableImageDataCodecTypes";

	private static readonly IntPtr selAvailableImageDataCodecTypesHandle = Selector.GetHandle("availableImageDataCodecTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCaptureStillImageAsynchronouslyFromConnection_CompletionHandler_ = "captureStillImageAsynchronouslyFromConnection:completionHandler:";

	private static readonly IntPtr selCaptureStillImageAsynchronouslyFromConnection_CompletionHandler_Handle = Selector.GetHandle("captureStillImageAsynchronouslyFromConnection:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCapturingStillImage = "isCapturingStillImage";

	private static readonly IntPtr selIsCapturingStillImageHandle = Selector.GetHandle("isCapturingStillImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJpegStillImageNSDataRepresentation_ = "jpegStillImageNSDataRepresentation:";

	private static readonly IntPtr selJpegStillImageNSDataRepresentation_Handle = Selector.GetHandle("jpegStillImageNSDataRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputSettings = "outputSettings";

	private static readonly IntPtr selOutputSettingsHandle = Selector.GetHandle("outputSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputSettings_ = "setOutputSettings:";

	private static readonly IntPtr selSetOutputSettings_Handle = Selector.GetHandle("setOutputSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureStillImageOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] AvailableImageDataCVPixelFormatTypes
	{
		[Export("availableImageDataCVPixelFormatTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableImageDataCVPixelFormatTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableImageDataCVPixelFormatTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableImageDataCodecTypes
	{
		[Export("availableImageDataCodecTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableImageDataCodecTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableImageDataCodecTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CapturingStillImage
	{
		[Export("isCapturingStillImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCapturingStillImageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCapturingStillImageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVVideoSettingsCompressed CompressedVideoSetting
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((OutputSettings != null) ? new NSMutableDictionary(OutputSettings) : null);
			return (nSMutableDictionary == null) ? null : new AVVideoSettingsCompressed(nSMutableDictionary);
		}
		set
		{
			OutputSettings = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary OutputSettings
	{
		[Export("outputSettings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputSettingsHandle));
		}
		[Export("setOutputSettings:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputSettings_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputSettings_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVVideoSettingsUncompressed UncompressedVideoSetting
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((OutputSettings != null) ? new NSMutableDictionary(OutputSettings) : null);
			return (nSMutableDictionary == null) ? null : new AVVideoSettingsUncompressed(nSMutableDictionary);
		}
		set
		{
			OutputSettings = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureStillImageOutput()
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
	protected AVCaptureStillImageOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureStillImageOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("captureStillImageAsynchronouslyFromConnection:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CaptureStillImageAsynchronously(AVCaptureConnection connection, [BlockProxy(typeof(Trampolines.NIDAVCaptureCompletionHandler))] AVCaptureCompletionHandler completionHandler)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVCaptureCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selCaptureStillImageAsynchronouslyFromConnection_CompletionHandler_Handle, connection.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCaptureStillImageAsynchronouslyFromConnection_CompletionHandler_Handle, connection.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<CMSampleBuffer> CaptureStillImageTaskAsync(AVCaptureConnection connection)
	{
		TaskCompletionSource<CMSampleBuffer> tcs = new TaskCompletionSource<CMSampleBuffer>();
		CaptureStillImageAsynchronously(connection, delegate(CMSampleBuffer imageDataSampleBuffer_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(imageDataSampleBuffer_);
			}
		});
		return tcs.Task;
	}

	[Export("jpegStillImageNSDataRepresentation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? JpegStillToNSData(CMSampleBuffer buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selJpegStillImageNSDataRepresentation_Handle, buffer.Handle));
	}
}
