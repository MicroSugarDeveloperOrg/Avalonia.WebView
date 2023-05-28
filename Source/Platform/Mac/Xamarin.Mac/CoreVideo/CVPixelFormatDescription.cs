using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
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

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static readonly NSString ContainsRgb;

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static readonly NSString ContainsYCbCr;

	[iOS(9, 0)]
	[Mac(10, 10)]
	public static readonly NSString ComponentRangeKey;

	[iOS(9, 0)]
	[Mac(10, 10)]
	public static readonly NSString ComponentRangeFullRangeKey;

	[iOS(9, 0)]
	[Mac(10, 10)]
	public static readonly NSString ComponentRangeVideoRangeKey;

	[iOS(9, 0)]
	[Mac(10, 10)]
	public static readonly NSString ComponentRangeWideRangeKey;

	[iOS(12, 0)]
	[TV(12, 0)]
	[Watch(5, 0)]
	[Mac(10, 14)]
	public static readonly NSString ContainsGrayscaleKey;

	public static NSNumber[] AllTypes => NSArray.ArrayFromHandle<NSNumber>(CVPixelFormatDescriptionArrayCreateWithAllPixelFormatTypes(IntPtr.Zero));

	static CVPixelFormatDescription()
	{
		IntPtr handle = Libraries.CoreVideo.Handle;
		NameKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatName");
		ConstantKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatConstant");
		CodecTypeKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatCodecType");
		FourCCKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatFourCC");
		PlanesKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatPlanes");
		BlockWidthKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatBlockWidth");
		BlockHeightKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatBlockHeight");
		BitsPerBlockKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatBitsPerBlock");
		BlockHorizontalAlignmentKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatBlockHorizontalAlignment");
		BlockVerticalAlignmentKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatBlockVerticalAlignment");
		BlackBlockKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatBlackBlock");
		HorizontalSubsamplingKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatHorizontalSubsampling");
		VerticalSubsamplingKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatVerticalSubsampling");
		OpenGLFormatKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatOpenGLFormat");
		OpenGLTypeKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatOpenGLType");
		OpenGLInternalFormatKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatOpenGLInternalFormat");
		CGBitmapInfoKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatCGBitmapInfo");
		QDCompatibilityKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatQDCompatibility");
		CGBitmapContextCompatibilityKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatCGBitmapContextCompatibility");
		CGImageCompatibilityKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatCGImageCompatibility");
		OpenGLCompatibilityKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatOpenGLCompatibility");
		FillExtendedPixelsCallbackKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatFillExtendedPixelsCallback");
		ContainsRgb = Dlfcn.GetStringConstant(handle, "kCVPixelFormatContainsRGB");
		ContainsYCbCr = Dlfcn.GetStringConstant(handle, "kCVPixelFormatContainsYCbCr");
		ComponentRangeKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatComponentRange");
		ComponentRangeFullRangeKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatComponentRange_FullRange");
		ComponentRangeVideoRangeKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatComponentRange_VideoRange");
		ComponentRangeWideRangeKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatComponentRange_WideRange");
		ContainsGrayscaleKey = Dlfcn.GetStringConstant(handle, "kCVPixelFormatContainsGrayscale");
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelFormatDescriptionArrayCreateWithAllPixelFormatTypes(IntPtr allocator);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelFormatDescriptionCreateWithPixelFormatType(IntPtr allocator, int pixelFormat);

	public static NSDictionary Create(int pixelFormat)
	{
		return Runtime.GetNSObject<NSDictionary>(CVPixelFormatDescriptionCreateWithPixelFormatType(IntPtr.Zero, pixelFormat));
	}

	public static NSDictionary Create(CVPixelFormatType pixelFormat)
	{
		return Runtime.GetNSObject<NSDictionary>(CVPixelFormatDescriptionCreateWithPixelFormatType(IntPtr.Zero, (int)pixelFormat));
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVPixelFormatDescriptionRegisterDescriptionWithPixelFormatType(IntPtr description, int pixelFormat);

	public static void Register(NSDictionary description, int pixelFormat)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		CVPixelFormatDescriptionRegisterDescriptionWithPixelFormatType(description.Handle, pixelFormat);
	}

	public static void Register(NSDictionary description, CVPixelFormatType pixelFormat)
	{
		if (description == null)
		{
			throw new ArgumentNullException("description");
		}
		CVPixelFormatDescriptionRegisterDescriptionWithPixelFormatType(description.Handle, (int)pixelFormat);
	}
}
