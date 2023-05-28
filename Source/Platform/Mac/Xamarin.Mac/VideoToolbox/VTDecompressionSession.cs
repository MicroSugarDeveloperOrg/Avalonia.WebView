using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[iOS(8, 0)]
[TV(10, 2)]
public class VTDecompressionSession : VTSession
{
	private struct VTDecompressionOutputCallbackRecord
	{
		public DecompressionOutputCallback Proc;

		public IntPtr DecompressionOutputRefCon;
	}

	public delegate void VTDecompressionOutputCallback(IntPtr sourceFrame, VTStatus status, VTDecodeInfoFlags flags, CVImageBuffer buffer, CMTime presentationTimeStamp, CMTime presentationDuration);

	private delegate void DecompressionOutputCallback(IntPtr outputCallbackClosure, IntPtr sourceFrame, VTStatus status, VTDecodeInfoFlags infoFlags, IntPtr cmSampleBufferPtr, CMTime presentationTimeStamp, CMTime presentationDuration);

	private GCHandle callbackHandle;

	private static DecompressionOutputCallback _static_decompressionCallback;

	private static DecompressionOutputCallback _static_newDecompressionCallback;

	private static DecompressionOutputCallback static_DecompressionOutputCallback
	{
		get
		{
			if (_static_decompressionCallback == null)
			{
				_static_decompressionCallback = DecompressionCallback;
			}
			return _static_decompressionCallback;
		}
	}

	private static DecompressionOutputCallback static_newDecompressionOutputCallback
	{
		get
		{
			if (_static_newDecompressionCallback == null)
			{
				_static_newDecompressionCallback = NewDecompressionCallback;
			}
			return _static_newDecompressionCallback;
		}
	}

	protected internal VTDecompressionSession(IntPtr handle)
		: base(handle)
	{
	}

	[Preserve(Conditional = true)]
	internal VTDecompressionSession(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	~VTDecompressionSession()
	{
		Dispose(disposing: false);
	}

	public new void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (base.Handle != IntPtr.Zero)
		{
			VTDecompressionSessionInvalidate(base.Handle);
		}
		if (callbackHandle.IsAllocated)
		{
			callbackHandle.Free();
		}
		base.Dispose(disposing);
	}

	private static void DecompressionCallback(IntPtr outputCallbackClosure, IntPtr sourceFrame, VTStatus status, VTDecodeInfoFlags infoFlags, IntPtr imageBufferPtr, CMTime presentationTimeStamp, CMTime presentationDuration)
	{
		VTDecompressionOutputCallback vTDecompressionOutputCallback = (VTDecompressionOutputCallback)GCHandle.FromIntPtr(outputCallbackClosure).Target;
		using CVPixelBuffer buffer = new CVPixelBuffer(imageBufferPtr);
		vTDecompressionOutputCallback(sourceFrame, status, infoFlags, buffer, presentationTimeStamp, presentationDuration);
	}

	private static void NewDecompressionCallback(IntPtr outputCallbackClosure, IntPtr sourceFrame, VTStatus status, VTDecodeInfoFlags infoFlags, IntPtr imageBufferPtr, CMTime presentationTimeStamp, CMTime presentationDuration)
	{
		VTDecompressionOutputCallback vTDecompressionOutputCallback = (VTDecompressionOutputCallback)GCHandle.FromIntPtr(outputCallbackClosure).Target;
		using CVPixelBuffer buffer = new CVPixelBuffer(imageBufferPtr, owns: false);
		vTDecompressionOutputCallback(sourceFrame, status, infoFlags, buffer, presentationTimeStamp, presentationDuration);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTDecompressionSessionCreate(IntPtr allocator, IntPtr videoFormatDescription, IntPtr videoDecoderSpecification, IntPtr destinationImageBufferAttributes, ref VTDecompressionOutputCallbackRecord outputCallback, out IntPtr decompressionSessionOut);

	[Obsolete("This overload requires that the provided compressionOutputCallback manually CFRetain the passed CMSampleBuffer, use Create(VTDecompressionOutputCallback,CMVideoFormatDescription,VTVideoDecoderSpecification,CVPixelBufferAttributes) variant instead which does not have that requirement.")]
	public static VTDecompressionSession Create(VTDecompressionOutputCallback outputCallback, CMVideoFormatDescription formatDescription, VTVideoDecoderSpecification decoderSpecification = null, NSDictionary destinationImageBufferAttributes = null)
	{
		return Create(outputCallback, formatDescription, decoderSpecification, destinationImageBufferAttributes, static_DecompressionOutputCallback);
	}

	public static VTDecompressionSession Create(VTDecompressionOutputCallback outputCallback, CMVideoFormatDescription formatDescription, VTVideoDecoderSpecification decoderSpecification, CVPixelBufferAttributes destinationImageBufferAttributes)
	{
		return Create(outputCallback, formatDescription, decoderSpecification, destinationImageBufferAttributes?.Dictionary, static_newDecompressionOutputCallback);
	}

	private static VTDecompressionSession Create(VTDecompressionOutputCallback outputCallback, CMVideoFormatDescription formatDescription, VTVideoDecoderSpecification decoderSpecification, NSDictionary destinationImageBufferAttributes, DecompressionOutputCallback cback)
	{
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		GCHandle value = GCHandle.Alloc(outputCallback);
		VTDecompressionOutputCallbackRecord vTDecompressionOutputCallbackRecord = default(VTDecompressionOutputCallbackRecord);
		vTDecompressionOutputCallbackRecord.Proc = cback;
		vTDecompressionOutputCallbackRecord.DecompressionOutputRefCon = GCHandle.ToIntPtr(value);
		VTDecompressionOutputCallbackRecord outputCallback2 = vTDecompressionOutputCallbackRecord;
		if (VTDecompressionSessionCreate(IntPtr.Zero, formatDescription.Handle, decoderSpecification?.Dictionary.Handle ?? IntPtr.Zero, destinationImageBufferAttributes?.Handle ?? IntPtr.Zero, ref outputCallback2, out var decompressionSessionOut) == VTStatus.Ok && decompressionSessionOut != IntPtr.Zero)
		{
			return new VTDecompressionSession(decompressionSessionOut, owns: true)
			{
				callbackHandle = value
			};
		}
		value.Free();
		return null;
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern void VTDecompressionSessionInvalidate(IntPtr sesion);

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTDecompressionSessionDecodeFrame(IntPtr session, IntPtr sampleBuffer, VTDecodeFrameFlags decodeFlags, IntPtr sourceFrame, out VTDecodeInfoFlags infoFlagsOut);

	public VTStatus DecodeFrame(CMSampleBuffer sampleBuffer, VTDecodeFrameFlags decodeFlags, IntPtr sourceFrame, out VTDecodeInfoFlags infoFlags)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("DecompressionSession");
		}
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		return VTDecompressionSessionDecodeFrame(base.Handle, sampleBuffer.Handle, decodeFlags, sourceFrame, out infoFlags);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTDecompressionSessionFinishDelayedFrames(IntPtr sesion);

	public VTStatus FinishDelayedFrames()
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("DecompressionSession");
		}
		return VTDecompressionSessionFinishDelayedFrames(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTDecompressionSessionCanAcceptFormatDescription(IntPtr sesion, IntPtr newFormatDescriptor);

	public VTStatus CanAcceptFormatDescriptor(CMFormatDescription newDescriptor)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("DecompressionSession");
		}
		return VTDecompressionSessionCanAcceptFormatDescription(base.Handle, newDescriptor.Handle);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTDecompressionSessionWaitForAsynchronousFrames(IntPtr sesion);

	public VTStatus WaitForAsynchronousFrames()
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("DecompressionSession");
		}
		return VTDecompressionSessionWaitForAsynchronousFrames(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTDecompressionSessionCopyBlackPixelBuffer(IntPtr sesion, out IntPtr pixelBufferOut);

	public VTStatus CopyBlackPixelBuffer(out CVPixelBuffer pixelBuffer)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("DecompressionSession");
		}
		IntPtr pixelBufferOut;
		VTStatus result = VTDecompressionSessionCopyBlackPixelBuffer(base.Handle, out pixelBufferOut);
		pixelBuffer = Runtime.GetINativeObject<CVPixelBuffer>(pixelBufferOut, owns: true);
		CFObject.CFRelease(pixelBufferOut);
		return result;
	}

	public VTStatus SetDecompressionProperties(VTDecompressionProperties options)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("DecompressionSession");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return VTSession.VTSessionSetProperties(base.Handle, options.Dictionary.Handle);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	private static extern bool VTIsHardwareDecodeSupported(CMVideoCodecType codecType);

	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	public static bool IsHardwareDecodeSupported(CMVideoCodecType codecType)
	{
		return VTIsHardwareDecodeSupported(codecType);
	}
}
