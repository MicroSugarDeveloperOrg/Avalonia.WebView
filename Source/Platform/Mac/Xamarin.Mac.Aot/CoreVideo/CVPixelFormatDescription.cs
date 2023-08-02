using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Since(4, 0)]
public static class CVPixelFormatDescription
{
	public static readonly NSString NameKey;

	public static readonly NSString ConstantKey;

	public static readonly NSString CodecTypeKey;

	public static readonly NSString FourCCKey;

	public static readonly NSString PlanesKey;

	public static readonly NSString BlockWidthKey;

	public static readonly NSString BlockHeightKey;

	public static readonly NSString BitsPerBlockKey;

	public static readonly NSString BlockHorizontalAlignmentKey;

	public static readonly NSString BlockVerticalAlignmentKey;

	public static readonly NSString BlackBlockKey;

	public static readonly NSString HorizontalSubsamplingKey;

	public static readonly NSString VerticalSubsamplingKey;

	public static readonly NSString OpenGLFormatKey;

	public static readonly NSString OpenGLTypeKey;

	public static readonly NSString OpenGLInternalFormatKey;

	public static readonly NSString CGBitmapInfoKey;

	public static readonly NSString QDCompatibilityKey;

	public static readonly NSString CGBitmapContextCompatibilityKey;

	public static readonly NSString CGImageCompatibilityKey;

	public static readonly NSString OpenGLCompatibilityKey;

	public static readonly NSString FillExtendedPixelsCallbackKey;

	public static NSDictionary[] AllTypes => NSArray.ArrayFromHandle<NSDictionary>(CVPixelFormatDescriptionArrayCreateWithAllPixelFormatTypes(IntPtr.Zero));

	static CVPixelFormatDescription()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			NameKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatName");
			ConstantKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatConstant");
			CodecTypeKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatCodecType");
			FourCCKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatFourCC");
			PlanesKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatPlanes");
			BlockWidthKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatBlockWidth");
			BlockHeightKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatBlockHeight");
			BitsPerBlockKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatBitsPerBlock");
			BlockHorizontalAlignmentKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatBlockHorizontalAlignment");
			BlockVerticalAlignmentKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatBlockVerticalAlignment");
			BlackBlockKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatBlackBlock");
			HorizontalSubsamplingKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatHorizontalSubsampling");
			VerticalSubsamplingKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatVerticalSubsampling");
			OpenGLFormatKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatOpenGLFormat");
			OpenGLTypeKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatOpenGLType");
			OpenGLInternalFormatKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatOpenGLInternalFormat");
			CGBitmapInfoKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatCGBitmapInfo");
			QDCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatQDCompatibility");
			CGBitmapContextCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatCGBitmapContextCompatibility");
			CGImageCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatCGImageCompatibility");
			OpenGLCompatibilityKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatOpenGLCompatibility");
			FillExtendedPixelsCallbackKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelFormatFillExtendedPixelsCallback");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelFormatDescriptionArrayCreateWithAllPixelFormatTypes(IntPtr allocator);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelFormatDescriptionCreateWithPixelFormatType(IntPtr allocator, int pixelFormat);

	public static NSDictionary Create(int pixelFormat)
	{
		return (NSDictionary)Runtime.GetNSObject(CVPixelFormatDescriptionCreateWithPixelFormatType(IntPtr.Zero, pixelFormat));
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVPixelFormatDescriptionRegisterDescriptionWithPixelFormatType(IntPtr description, int pixelFormat);

	public static void Register(NSDictionary description, int pixelFormat)
	{
		CVPixelFormatDescriptionRegisterDescriptionWithPixelFormatType(description.Handle, pixelFormat);
	}
}
