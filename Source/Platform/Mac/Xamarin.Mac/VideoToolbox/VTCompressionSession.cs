using System;
using System.Runtime.InteropServices;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[iOS(8, 0)]
[TV(10, 2)]
public class VTCompressionSession : VTSession
{
	public delegate void VTCompressionOutputCallback(IntPtr sourceFrame, VTStatus status, VTEncodeInfoFlags flags, CMSampleBuffer buffer);

	private delegate void CompressionOutputCallback(IntPtr outputCallbackClosure, IntPtr sourceFrame, VTStatus status, VTEncodeInfoFlags infoFlags, IntPtr cmSampleBufferPtr);

	private GCHandle callbackHandle;

	private static CompressionOutputCallback _static_CompressionOutputCallback;

	private static CompressionOutputCallback _static_newCompressionOutputCallback;

	private static CompressionOutputCallback static_CompressionOutputCallback
	{
		get
		{
			if (_static_CompressionOutputCallback == null)
			{
				_static_CompressionOutputCallback = CompressionCallback;
			}
			return _static_CompressionOutputCallback;
		}
	}

	private static CompressionOutputCallback static_newCompressionOutputCallback
	{
		get
		{
			if (_static_newCompressionOutputCallback == null)
			{
				_static_newCompressionOutputCallback = NewCompressionCallback;
			}
			return _static_newCompressionOutputCallback;
		}
	}

	protected internal VTCompressionSession(IntPtr handle)
		: base(handle)
	{
	}

	[Preserve(Conditional = true)]
	internal VTCompressionSession(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	~VTCompressionSession()
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
			VTCompressionSessionInvalidate(base.Handle);
		}
		if (callbackHandle.IsAllocated)
		{
			callbackHandle.Free();
		}
		base.Dispose(disposing);
	}

	private static void CompressionCallback(IntPtr outputCallbackClosure, IntPtr sourceFrame, VTStatus status, VTEncodeInfoFlags infoFlags, IntPtr cmSampleBufferPtr, bool owns)
	{
		VTCompressionOutputCallback vTCompressionOutputCallback = (VTCompressionOutputCallback)GCHandle.FromIntPtr(outputCallbackClosure).Target;
		if (cmSampleBufferPtr == IntPtr.Zero)
		{
			vTCompressionOutputCallback(sourceFrame, status, infoFlags, null);
			return;
		}
		using CMSampleBuffer buffer = new CMSampleBuffer(cmSampleBufferPtr, owns);
		vTCompressionOutputCallback(sourceFrame, status, infoFlags, buffer);
	}

	private static void CompressionCallback(IntPtr outputCallbackClosure, IntPtr sourceFrame, VTStatus status, VTEncodeInfoFlags infoFlags, IntPtr cmSampleBufferPtr)
	{
		CompressionCallback(outputCallbackClosure, sourceFrame, status, infoFlags, cmSampleBufferPtr, owns: true);
	}

	[Obsolete("This overload requires that the provided compressionOutputCallback manually CFRetain the passed CMSampleBuffer, use Create(int,int,CMVideoCodecType,VTCompressionOutputCallback,VTVideoEncoderSpecification,CVPixelBufferAttributes) variant instead which does not have that requirement.")]
	public static VTCompressionSession Create(int width, int height, CMVideoCodecType codecType, VTCompressionOutputCallback compressionOutputCallback, VTVideoEncoderSpecification encoderSpecification = null, NSDictionary sourceImageBufferAttributes = null)
	{
		return Create(width, height, codecType, compressionOutputCallback, encoderSpecification, sourceImageBufferAttributes, static_newCompressionOutputCallback);
	}

	private static void NewCompressionCallback(IntPtr outputCallbackClosure, IntPtr sourceFrame, VTStatus status, VTEncodeInfoFlags infoFlags, IntPtr cmSampleBufferPtr)
	{
		CompressionCallback(outputCallbackClosure, sourceFrame, status, infoFlags, cmSampleBufferPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTCompressionSessionCreate(IntPtr allocator, int width, int height, CMVideoCodecType codecType, IntPtr dictionaryEncoderSpecification, IntPtr dictionarySourceImageBufferAttributes, IntPtr compressedDataAllocator, CompressionOutputCallback outputCallback, IntPtr outputCallbackClosure, out IntPtr compressionSessionOut);

	public static VTCompressionSession Create(int width, int height, CMVideoCodecType codecType, VTCompressionOutputCallback compressionOutputCallback, VTVideoEncoderSpecification encoderSpecification, CVPixelBufferAttributes sourceImageBufferAttributes)
	{
		return Create(width, height, codecType, compressionOutputCallback, encoderSpecification, sourceImageBufferAttributes?.Dictionary, static_CompressionOutputCallback);
	}

	private static VTCompressionSession Create(int width, int height, CMVideoCodecType codecType, VTCompressionOutputCallback compressionOutputCallback, VTVideoEncoderSpecification encoderSpecification, NSDictionary sourceImageBufferAttributes, CompressionOutputCallback staticCback)
	{
		GCHandle value = default(GCHandle);
		if (compressionOutputCallback != null)
		{
			value = GCHandle.Alloc(compressionOutputCallback);
		}
		if (VTCompressionSessionCreate(IntPtr.Zero, width, height, codecType, encoderSpecification?.Dictionary.Handle ?? IntPtr.Zero, sourceImageBufferAttributes?.Handle ?? IntPtr.Zero, IntPtr.Zero, value.IsAllocated ? staticCback : null, GCHandle.ToIntPtr(value), out var compressionSessionOut) == VTStatus.Ok && compressionSessionOut != IntPtr.Zero)
		{
			return new VTCompressionSession(compressionSessionOut, owns: true)
			{
				callbackHandle = value
			};
		}
		if (value.IsAllocated)
		{
			value.Free();
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern void VTCompressionSessionInvalidate(IntPtr handle);

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern IntPtr VTCompressionSessionGetPixelBufferPool(IntPtr handle);

	public CVPixelBufferPool GetPixelBufferPool()
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		IntPtr intPtr = VTCompressionSessionGetPixelBufferPool(base.Handle);
		if (intPtr != IntPtr.Zero)
		{
			return new CVPixelBufferPool(intPtr, owns: false);
		}
		return null;
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	[Mac(10, 9)]
	[iOS(8, 0)]
	private static extern VTStatus VTCompressionSessionPrepareToEncodeFrames(IntPtr handle);

	[Mac(10, 9)]
	[iOS(8, 0)]
	public VTStatus PrepareToEncodeFrames()
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		return VTCompressionSessionPrepareToEncodeFrames(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTCompressionSessionEncodeFrame(IntPtr session, IntPtr imageBuffer, CMTime presentation, CMTime duration, IntPtr dict, IntPtr sourceFrame, out VTEncodeInfoFlags flags);

	public VTStatus EncodeFrame(CVImageBuffer imageBuffer, CMTime presentationTimestampe, CMTime duration, NSDictionary frameProperties, IntPtr sourceFrame, out VTEncodeInfoFlags infoFlags)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		return VTCompressionSessionEncodeFrame(base.Handle, imageBuffer.Handle, presentationTimestampe, duration, frameProperties?.Handle ?? IntPtr.Zero, sourceFrame, out infoFlags);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTCompressionSessionCompleteFrames(IntPtr session, CMTime completeUntilPresentationTimeStamp);

	public VTStatus CompleteFrames(CMTime completeUntilPresentationTimeStamp)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		return VTCompressionSessionCompleteFrames(base.Handle, completeUntilPresentationTimeStamp);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	[Mac(10, 10)]
	[iOS(8, 0)]
	private static extern VTStatus VTCompressionSessionBeginPass(IntPtr session, VTCompressionSessionOptionFlags flags, IntPtr reserved);

	[Mac(10, 10)]
	[iOS(8, 0)]
	public VTStatus BeginPass(VTCompressionSessionOptionFlags flags)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		return VTCompressionSessionBeginPass(base.Handle, flags, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	[Mac(10, 10)]
	[iOS(8, 0)]
	private static extern VTStatus VTCompressionSessionEndPass(IntPtr session, out byte furtherPassesRequestedOut, IntPtr reserved);

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	[Mac(10, 10)]
	[iOS(8, 0)]
	private static extern VTStatus VTCompressionSessionEndPass(IntPtr session, IntPtr ptrByte, IntPtr reserved);

	[Mac(10, 10)]
	[iOS(8, 0)]
	public VTStatus EndPass(out bool furtherPassesRequested)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		byte furtherPassesRequestedOut;
		VTStatus result = VTCompressionSessionEndPass(base.Handle, out furtherPassesRequestedOut, IntPtr.Zero);
		furtherPassesRequested = furtherPassesRequestedOut != 0;
		return result;
	}

	public VTStatus EndPassAsFinal()
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		return VTCompressionSessionEndPass(base.Handle, IntPtr.Zero, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	[Mac(10, 10)]
	[iOS(8, 0)]
	private static extern VTStatus VTCompressionSessionGetTimeRangesForNextPass(IntPtr session, out int itemCount, out IntPtr target);

	[Mac(10, 10)]
	[iOS(8, 0)]
	public unsafe VTStatus GetTimeRangesForNextPass(out CMTimeRange[] timeRanges)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		int itemCount;
		IntPtr target;
		VTStatus vTStatus = VTCompressionSessionGetTimeRangesForNextPass(base.Handle, out itemCount, out target);
		if (vTStatus != 0)
		{
			timeRanges = null;
			return vTStatus;
		}
		timeRanges = new CMTimeRange[itemCount];
		CMTimeRange* ptr = (CMTimeRange*)(void*)target;
		for (int i = 0; i < itemCount; i++)
		{
			timeRanges[i] = ptr[i];
		}
		return VTStatus.Ok;
	}

	public VTStatus SetCompressionProperties(VTCompressionProperties options)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CompressionSession");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return VTSession.VTSessionSetProperties(base.Handle, options.Dictionary.Handle);
	}
}
