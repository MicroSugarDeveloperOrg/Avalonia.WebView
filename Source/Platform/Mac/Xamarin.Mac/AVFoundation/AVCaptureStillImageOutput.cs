using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureStillImageOutput", true)]
public class AVCaptureStillImageOutput : AVCaptureOutput
{
	private static readonly IntPtr selAvailableImageDataCVPixelFormatTypesHandle = Selector.GetHandle("availableImageDataCVPixelFormatTypes");

	private static readonly IntPtr selAvailableImageDataCodecTypesHandle = Selector.GetHandle("availableImageDataCodecTypes");

	private static readonly IntPtr selOutputSettingsHandle = Selector.GetHandle("outputSettings");

	private static readonly IntPtr selSetOutputSettings_Handle = Selector.GetHandle("setOutputSettings:");

	private static readonly IntPtr selIsCapturingStillImageHandle = Selector.GetHandle("isCapturingStillImage");

	private static readonly IntPtr selCaptureStillImageAsynchronouslyFromConnectionCompletionHandler_Handle = Selector.GetHandle("captureStillImageAsynchronouslyFromConnection:completionHandler:");

	private static readonly IntPtr selJpegStillImageNSDataRepresentation_Handle = Selector.GetHandle("jpegStillImageNSDataRepresentation:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureStillImageOutput");

	private object __mt_AvailableImageDataCVPixelFormatTypes_var;

	private object __mt_OutputSettings_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSNumber[] AvailableImageDataCVPixelFormatTypes
	{
		[Export("availableImageDataCVPixelFormatTypes")]
		get
		{
			return (NSNumber[])(__mt_AvailableImageDataCVPixelFormatTypes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableImageDataCVPixelFormatTypesHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableImageDataCVPixelFormatTypesHandle))));
		}
	}

	public virtual string[] AvailableImageDataCodecTypes
	{
		[Export("availableImageDataCodecTypes")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableImageDataCodecTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableImageDataCodecTypesHandle));
		}
	}

	public virtual NSDictionary OutputSettings
	{
		[Export("outputSettings", ArgumentSemantic.Copy)]
		get
		{
			return (NSDictionary)(__mt_OutputSettings_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputSettingsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputSettingsHandle)))));
		}
		[Export("setOutputSettings:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutputSettings_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutputSettings_Handle, value.Handle);
			}
			__mt_OutputSettings_var = value;
		}
	}

	public AVVideoSettingsUncompressed UncompressedVideoSetting
	{
		get
		{
			NSDictionary outputSettings = OutputSettings;
			if (outputSettings != null)
			{
				return new AVVideoSettingsUncompressed(outputSettings);
			}
			return null;
		}
		set
		{
			OutputSettings = value?.Dictionary;
		}
	}

	public AVVideoSettingsCompressed CompressedVideoSetting
	{
		get
		{
			NSDictionary outputSettings = OutputSettings;
			if (outputSettings != null)
			{
				return new AVVideoSettingsCompressed(outputSettings);
			}
			return null;
		}
		set
		{
			OutputSettings = value?.Dictionary;
		}
	}

	public virtual bool CapturingStillImage
	{
		[Export("isCapturingStillImage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCapturingStillImageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCapturingStillImageHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureStillImageOutput()
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
	public AVCaptureStillImageOutput(NSCoder coder)
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
	public AVCaptureStillImageOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureStillImageOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("captureStillImageAsynchronouslyFromConnection:completionHandler:")]
	public unsafe virtual void CaptureStillImageAsynchronously(AVCaptureConnection connection, AVCaptureCompletionHandler completionHandler)
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
		blockLiteral.SetupBlock(Trampolines.SDAVCaptureCompletionHandler.Handler, completionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selCaptureStillImageAsynchronouslyFromConnectionCompletionHandler_Handle, connection.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCaptureStillImageAsynchronouslyFromConnectionCompletionHandler_Handle, connection.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	public virtual Task<CMSampleBuffer> CaptureStillImageTaskAsync(AVCaptureConnection connection)
	{
		TaskCompletionSource<CMSampleBuffer> tcs = new TaskCompletionSource<CMSampleBuffer>();
		CaptureStillImageAsynchronously(connection, delegate(CMSampleBuffer imageDataSampleBuffer, NSError error)
		{
			if (error != null)
			{
				tcs.SetException(new NSErrorException(error));
			}
			else
			{
				tcs.SetResult(imageDataSampleBuffer);
			}
		});
		return tcs.Task;
	}

	[Export("jpegStillImageNSDataRepresentation:")]
	public static NSData JpegStillToNSData(CMSampleBuffer buffer)
	{
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selJpegStillImageNSDataRepresentation_Handle, buffer.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AvailableImageDataCVPixelFormatTypes_var = null;
			__mt_OutputSettings_var = null;
		}
	}
}
