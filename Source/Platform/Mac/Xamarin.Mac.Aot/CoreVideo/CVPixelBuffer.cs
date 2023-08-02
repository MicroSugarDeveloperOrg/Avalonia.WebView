using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Since(4, 0)]
public class CVPixelBuffer : CVImageBuffer
{
	public static readonly NSString PixelFormatTypeKey;

	public static readonly NSString MemoryAllocatorKey;

	public static readonly NSString WidthKey;

	public static readonly NSString HeightKey;

	public static readonly NSString ExtendedPixelsLeftKey;

	public static readonly NSString ExtendedPixelsTopKey;

	public static readonly NSString ExtendedPixelsRightKey;

	public static readonly NSString ExtendedPixelsBottomKey;

	public static readonly NSString BytesPerRowAlignmentKey;

	public static readonly NSString CGBitmapContextCompatibilityKey;

	public static readonly NSString CGImageCompatibilityKey;

	public static readonly NSString OpenGLCompatibilityKey;

	public static readonly NSString IOSurfacePropertiesKey;

	public static readonly NSString PlaneAlignmentKey;

	public static readonly NSString OpenGLESCompatibilityKey;

	public static readonly int CVImageBufferType;

	public IntPtr BaseAddress => CVPixelBufferGetBaseAddress(handle);

	public int BytesPerRow => (int)CVPixelBufferGetBytesPerRow(handle);

	public int DataSize => (int)CVPixelBufferGetDataSize(handle);

	public int Height => (int)CVPixelBufferGetHeight(handle);

	public int Width => (int)CVPixelBufferGetWidth(handle);

	public int PlaneCount => (int)CVPixelBufferGetPlaneCount(handle);

	public bool IsPlanar => CVPixelBufferIsPlanar(handle);

	public CVPixelFormatType PixelFormatType => CVPixelBufferGetPixelFormatType(handle);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern int CVPixelBufferGetTypeID();

	static CVPixelBuffer()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			PixelFormatTypeKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferPixelFormatTypeKey");
			MemoryAllocatorKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferMemoryAllocatorKey");
			WidthKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferWidthKey");
			HeightKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferHeightKey");
			ExtendedPixelsLeftKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferExtendedPixelsLeftKey");
			ExtendedPixelsTopKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferExtendedPixelsTopKey");
			ExtendedPixelsRightKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferExtendedPixelsRightKey");
			ExtendedPixelsBottomKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferExtendedPixelsBottomKey");
			BytesPerRowAlignmentKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferBytesPerRowAlignmentKey");
			CGBitmapContextCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferCGBitmapContextCompatibilityKey");
			CGImageCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferCGImageCompatibilityKey");
			OpenGLCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferOpenGLCompatibilityKey");
			IOSurfacePropertiesKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferIOSurfacePropertiesKey");
			PlaneAlignmentKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferPlaneAlignmentKey");
			CVImageBufferType = CVPixelBufferGetTypeID();
			OpenGLESCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferOpenGLESCompatibilityKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	internal CVPixelBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Preserve(Conditional = true)]
	internal CVPixelBuffer(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferCreate(IntPtr allocator, IntPtr width, IntPtr height, CVPixelFormatType pixelFormatType, IntPtr pixelBufferAttributes, IntPtr pixelBufferOut);

	public CVPixelBuffer(int width, int height, CVPixelFormatType pixelFormatType, CVPixelBufferAttributes attributes)
		: this(width, height, pixelFormatType, attributes?.Dictionary)
	{
	}

	[Advice("Use constructor with CVPixelBufferAttributes")]
	public CVPixelBuffer(int width, int height, CVPixelFormatType pixelFormatType, NSDictionary pixelBufferAttributes)
	{
		if (width <= 0)
		{
			throw new ArgumentOutOfRangeException("width");
		}
		if (height <= 0)
		{
			throw new ArgumentOutOfRangeException("height");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
		CVReturn cVReturn = CVPixelBufferCreate(IntPtr.Zero, (IntPtr)width, (IntPtr)height, pixelFormatType, pixelBufferAttributes?.Handle ?? IntPtr.Zero, intPtr);
		if (cVReturn != 0)
		{
			Marshal.FreeHGlobal(intPtr);
			throw new ArgumentException(cVReturn.ToString());
		}
		handle = Marshal.ReadIntPtr(intPtr);
		Marshal.FreeHGlobal(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferCreateResolvedAttributesDictionary(IntPtr allocator, IntPtr attributes, IntPtr resolvedDictionaryOut);

	public NSDictionary GetAttributes(NSDictionary[] attributes)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
		NSArray nSArray = NSArray.FromNSObjects(attributes);
		CVReturn cVReturn = CVPixelBufferCreateResolvedAttributesDictionary(IntPtr.Zero, nSArray.Handle, intPtr);
		if (cVReturn != 0)
		{
			Marshal.FreeHGlobal(intPtr);
			throw new Exception("CVPixelBufferCreate returned: " + cVReturn);
		}
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Marshal.ReadIntPtr(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferFillExtendedPixels(IntPtr pixelBuffer);

	public CVReturn FillExtendedPixels()
	{
		return CVPixelBufferFillExtendedPixels(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetBaseAddress(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetBytesPerRow(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetDataSize(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetHeight(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetWidth(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetPlaneCount(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern bool CVPixelBufferIsPlanar(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVPixelFormatType CVPixelBufferGetPixelFormatType(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetBaseAddressOfPlane(IntPtr pixelBuffer, IntPtr planeIndex);

	public IntPtr GetBaseAddress(int planeIndex)
	{
		return CVPixelBufferGetBaseAddressOfPlane(handle, (IntPtr)planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetBytesPerRowOfPlane(IntPtr pixelBuffer, IntPtr planeIndex);

	public int GetBytesPerRowOfPlane(int planeIndex)
	{
		return (int)CVPixelBufferGetBytesPerRowOfPlane(handle, (IntPtr)planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetHeightOfPlane(IntPtr pixelBuffer, IntPtr planeIndex);

	public int GetHeightOfPlane(int planeIndex)
	{
		return (int)CVPixelBufferGetHeightOfPlane(handle, (IntPtr)planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetWidthtOfPlane(IntPtr pixelBuffer, IntPtr planeIndex);

	public int GetWidthtOfPlane(int planeIndex)
	{
		return (int)CVPixelBufferGetWidthtOfPlane(handle, (IntPtr)planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferLockBaseAddress(IntPtr pixelBuffer, CVOptionFlags lockFlags);

	public CVReturn Lock(CVOptionFlags lockFlags)
	{
		return CVPixelBufferLockBaseAddress(handle, lockFlags);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferUnlockBaseAddress(IntPtr pixelBuffer, CVOptionFlags unlockFlags);

	public CVReturn Unlock(CVOptionFlags unlockFlags)
	{
		return CVPixelBufferUnlockBaseAddress(handle, unlockFlags);
	}
}
