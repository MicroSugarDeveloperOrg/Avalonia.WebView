using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGImage : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public bool IsMask => CGImageIsMask(handle);

	public nint Width => CGImageGetWidth(handle);

	public nint Height => CGImageGetHeight(handle);

	public nint BitsPerComponent => CGImageGetBitsPerComponent(handle);

	public nint BitsPerPixel => CGImageGetBitsPerPixel(handle);

	public nint BytesPerRow => CGImageGetBytesPerRow(handle);

	public CGColorSpace ColorSpace
	{
		get
		{
			IntPtr intPtr = CGImageGetColorSpace(handle);
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr);
		}
	}

	public CGImageAlphaInfo AlphaInfo => CGImageGetAlphaInfo(handle);

	public CGDataProvider DataProvider => new CGDataProvider(CGImageGetDataProvider(handle));

	public unsafe nfloat* Decode => CGImageGetDecode(handle);

	public bool ShouldInterpolate => CGImageGetShouldInterpolate(handle);

	public CGColorRenderingIntent RenderingIntent => CGImageGetRenderingIntent(handle);

	public CGBitmapFlags BitmapInfo => CGImageGetBitmapInfo(handle);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public NSString UTType
	{
		get
		{
			IntPtr intPtr = CGImageGetUTType(handle);
			return (intPtr == IntPtr.Zero) ? null : Runtime.GetNSObject<NSString>(intPtr);
		}
	}

	[iOS(12, 0)]
	[Mac(10, 14)]
	[TV(12, 0)]
	[Watch(5, 0)]
	public CGImagePixelFormatInfo PixelFormatInfo => CGImageGetPixelFormatInfo(handle);

	[iOS(12, 0)]
	[Mac(10, 14)]
	[TV(12, 0)]
	[Watch(5, 0)]
	public CGImageByteOrderInfo ByteOrderInfo => CGImageGetByteOrderInfo(handle);

	public CGImage(IntPtr handle)
		: this(handle, owns: false)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGImage(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CGImageRetain(handle);
		}
	}

	~CGImage()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGImageRelease(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageRetain(IntPtr image);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGImageRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreate(nint width, nint height, nint bitsPerComponent, nint bitsPerPixel, nint bytesPerRow, IntPtr space, CGBitmapFlags bitmapInfo, IntPtr provider, nfloat[] decode, bool shouldInterpolate, CGColorRenderingIntent intent);

	public CGImage(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, CGColorSpace colorSpace, CGBitmapFlags bitmapFlags, CGDataProvider provider, nfloat[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		if (width < 0)
		{
			throw new ArgumentException("width");
		}
		if (height < 0)
		{
			throw new ArgumentException("height");
		}
		if (bitsPerPixel < 0)
		{
			throw new ArgumentException("bitsPerPixel");
		}
		if (bitsPerComponent < 0)
		{
			throw new ArgumentException("bitsPerComponent");
		}
		if (bytesPerRow < 0)
		{
			throw new ArgumentException("bytesPerRow");
		}
		handle = CGImageCreate(width, height, bitsPerComponent, bitsPerPixel, bytesPerRow, colorSpace?.Handle ?? IntPtr.Zero, bitmapFlags, provider?.Handle ?? IntPtr.Zero, decode, shouldInterpolate, intent);
	}

	public CGImage(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, CGColorSpace colorSpace, CGImageAlphaInfo alphaInfo, CGDataProvider provider, nfloat[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		if (width < 0)
		{
			throw new ArgumentException("width");
		}
		if (height < 0)
		{
			throw new ArgumentException("height");
		}
		if (bitsPerPixel < 0)
		{
			throw new ArgumentException("bitsPerPixel");
		}
		if (bitsPerComponent < 0)
		{
			throw new ArgumentException("bitsPerComponent");
		}
		if (bytesPerRow < 0)
		{
			throw new ArgumentException("bytesPerRow");
		}
		handle = CGImageCreate(width, height, bitsPerComponent, bitsPerPixel, bytesPerRow, colorSpace?.Handle ?? IntPtr.Zero, (CGBitmapFlags)alphaInfo, provider?.Handle ?? IntPtr.Zero, decode, shouldInterpolate, intent);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGWindowListCreateImage(CGRect screenBounds, CGWindowListOption windowOption, uint windowID, CGWindowImageOption imageOption);

	public static CGImage ScreenImage(int windownumber, CGRect bounds)
	{
		return ScreenImage(windownumber, bounds, CGWindowListOption.IncludingWindow, CGWindowImageOption.Default);
	}

	public static CGImage ScreenImage(int windownumber, CGRect bounds, CGWindowListOption windowOption, CGWindowImageOption imageOption)
	{
		IntPtr intPtr = CGWindowListCreateImage(bounds, windowOption, (uint)windownumber, imageOption);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithJPEGDataProvider(IntPtr source, nfloat[] decode, bool shouldInterpolate, CGColorRenderingIntent intent);

	public static CGImage FromJPEG(CGDataProvider provider, nfloat[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		IntPtr intPtr = CGImageCreateWithJPEGDataProvider(provider?.Handle ?? IntPtr.Zero, decode, shouldInterpolate, intent);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithPNGDataProvider(IntPtr source, nfloat[] decode, bool shouldInterpolate, CGColorRenderingIntent intent);

	public static CGImage FromPNG(CGDataProvider provider, nfloat[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		IntPtr intPtr = CGImageCreateWithPNGDataProvider(provider?.Handle ?? IntPtr.Zero, decode, shouldInterpolate, intent);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageMaskCreate(nint width, nint height, nint bitsPerComponent, nint bitsPerPixel, nint bytesPerRow, IntPtr provider, nfloat[] decode, bool shouldInterpolate);

	public static CGImage CreateMask(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, CGDataProvider provider, nfloat[] decode, bool shouldInterpolate)
	{
		if (width < 0)
		{
			throw new ArgumentException("width");
		}
		if (height < 0)
		{
			throw new ArgumentException("height");
		}
		if (bitsPerPixel < 0)
		{
			throw new ArgumentException("bitsPerPixel");
		}
		if (bytesPerRow < 0)
		{
			throw new ArgumentException("bytesPerRow");
		}
		IntPtr intPtr = CGImageMaskCreate(width, height, bitsPerComponent, bitsPerPixel, bytesPerRow, provider?.Handle ?? IntPtr.Zero, decode, shouldInterpolate);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithMaskingColors(IntPtr image, nfloat[] components);

	public CGImage WithMaskingColors(nfloat[] components)
	{
		nint nint = 2 * ColorSpace.Components;
		if (components != null && components.Length != nint)
		{
			throw new ArgumentException("The argument 'components' must have 2N values, where N is the number of components in the color space of the image.", "components");
		}
		return new CGImage(CGImageCreateWithMaskingColors(Handle, components), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateCopy(IntPtr image);

	public CGImage Clone()
	{
		return new CGImage(CGImageCreateCopy(handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateCopyWithColorSpace(IntPtr image, IntPtr space);

	public CGImage WithColorSpace(CGColorSpace cs)
	{
		IntPtr intPtr = CGImageCreateCopyWithColorSpace(handle, cs?.handle ?? IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithImageInRect(IntPtr image, CGRect rect);

	public CGImage WithImageInRect(CGRect rect)
	{
		IntPtr intPtr = CGImageCreateWithImageInRect(handle, rect);
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithMask(IntPtr image, IntPtr mask);

	public CGImage WithMask(CGImage mask)
	{
		if (mask == null)
		{
			throw new ArgumentNullException("mask");
		}
		return new CGImage(CGImageCreateWithMask(handle, mask.handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGImageIsMask(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGImageGetWidth(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGImageGetHeight(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGImageGetBitsPerComponent(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGImageGetBitsPerPixel(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGImageGetBytesPerRow(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetColorSpace(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGImageAlphaInfo CGImageGetAlphaInfo(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetDataProvider(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern nfloat* CGImageGetDecode(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGImageGetShouldInterpolate(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGColorRenderingIntent CGImageGetRenderingIntent(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGBitmapFlags CGImageGetBitmapInfo(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern IntPtr CGImageGetUTType(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(12, 0)]
	[Mac(10, 14)]
	[TV(12, 0)]
	[Watch(5, 0)]
	private static extern CGImagePixelFormatInfo CGImageGetPixelFormatInfo(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(12, 0)]
	[Mac(10, 14)]
	[TV(12, 0)]
	[Watch(5, 0)]
	private static extern CGImageByteOrderInfo CGImageGetByteOrderInfo(IntPtr handle);
}
