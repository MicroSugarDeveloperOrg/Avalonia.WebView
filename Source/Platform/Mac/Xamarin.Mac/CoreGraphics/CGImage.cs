using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGImage : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public bool IsMask => CGImageIsMask(handle) != 0;

	public int Width => CGImageGetWidth(handle).ToInt32();

	public int Height => CGImageGetHeight(handle).ToInt32();

	public int BitsPerComponent => CGImageGetBitsPerComponent(handle).ToInt32();

	public int BitsPerPixel => CGImageGetBitsPerPixel(handle).ToInt32();

	public int BytesPerRow => CGImageGetBytesPerRow(handle).ToInt32();

	public CGColorSpace ColorSpace => new CGColorSpace(CGImageGetColorSpace(handle));

	public CGImageAlphaInfo AlphaInfo => CGImageGetAlphaInfo(handle);

	public CGDataProvider DataProvider => new CGDataProvider(CGImageGetDataProvider(handle));

	public unsafe double* Decode => CGImageGetDecode(handle);

	public bool ShouldInterpolate => CGImageGetShouldInterpolate(handle) != 0;

	public CGColorRenderingIntent RenderingIntent => CGImageGetRenderingIntent(handle);

	public CGBitmapFlags BitmapInfo => CGImageGetBitmapInfo(handle);

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
	private static extern void CGImageRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGImageRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGImageRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreate(IntPtr size_t_width, IntPtr size_t_height, IntPtr size_t_bitsPerComponent, IntPtr size_t_bitsPerPixel, IntPtr size_t_bytesPerRow, IntPtr space, CGBitmapFlags bitmapInfo, IntPtr provider, double[] decode, bool shouldInterpolate, CGColorRenderingIntent intent);

	public CGImage(long width, long height, long bitsPerComponent, long bitsPerPixel, long bytesPerRow, CGColorSpace colorSpace, CGBitmapFlags bitmapFlags, CGDataProvider provider, double[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
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
		handle = CGImageCreate(new IntPtr(width), new IntPtr(height), new IntPtr(bitsPerComponent), new IntPtr(bitsPerPixel), new IntPtr(bytesPerRow), colorSpace.Handle, bitmapFlags, provider?.Handle ?? IntPtr.Zero, decode, shouldInterpolate, intent);
	}

	public CGImage(long width, long height, long bitsPerComponent, long bitsPerPixel, long bytesPerRow, CGColorSpace colorSpace, CGImageAlphaInfo alphaInfo, CGDataProvider provider, double[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
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
		handle = CGImageCreate(new IntPtr(width), new IntPtr(height), new IntPtr(bitsPerComponent), new IntPtr(bitsPerPixel), new IntPtr(bytesPerRow), colorSpace.Handle, (CGBitmapFlags)alphaInfo, provider?.Handle ?? IntPtr.Zero, decode, shouldInterpolate, intent);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGWindowListCreateImage(CGRect screenBounds, CGWindowListOption windowOption, uint windowID, CGWindowImageOption imageOption);

	public static CGImage ScreenImage(int windownumber, CGRect bounds)
	{
		return new CGImage(CGWindowListCreateImage(bounds, CGWindowListOption.IncludingWindow, (uint)windownumber, CGWindowImageOption.Default), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithJPEGDataProvider(IntPtr source, double[] decode, bool shouldInterpolate, CGColorRenderingIntent intent);

	public static CGImage FromJPEG(CGDataProvider provider, double[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		IntPtr intPtr = CGImageCreateWithJPEGDataProvider(provider.Handle, decode, shouldInterpolate, intent);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithPNGDataProvider(IntPtr source, double[] decode, bool shouldInterpolate, CGColorRenderingIntent intent);

	public static CGImage FromPNG(CGDataProvider provider, double[] decode, bool shouldInterpolate, CGColorRenderingIntent intent)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		IntPtr intPtr = CGImageCreateWithPNGDataProvider(provider.Handle, decode, shouldInterpolate, intent);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageMaskCreate(IntPtr size_t_width, IntPtr size_t_height, IntPtr size_t_bitsPerComponent, IntPtr size_t_bitsPerPixel, IntPtr size_t_bytesPerRow, IntPtr provider, double[] decode, bool shouldInterpolate);

	public static CGImage CreateMask(long width, long height, long bitsPerComponent, long bitsPerPixel, long bytesPerRow, CGDataProvider provider, double[] decode, bool shouldInterpolate)
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
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		IntPtr intPtr = CGImageMaskCreate(new IntPtr(width), new IntPtr(height), new IntPtr(bitsPerComponent), new IntPtr(bitsPerPixel), new IntPtr(bytesPerRow), provider.Handle, decode, shouldInterpolate);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CGImage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithMaskingColors(IntPtr image, double[] components);

	public CGImage WithMaskingColors(double[] components)
	{
		int num = 2 * ColorSpace.Components;
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (components.Length != num)
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
		return new CGImage(CGImageCreateCopyWithColorSpace(handle, cs.handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithImageInRect(IntPtr image, CGRect rect);

	public CGImage WithImageInRect(CGRect rect)
	{
		return new CGImage(CGImageCreateWithImageInRect(handle, rect), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageCreateWithMask(IntPtr image, IntPtr mask);

	public CGImage WithMask(CGImage mask)
	{
		return new CGImage(CGImageCreateWithMask(handle, mask.handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGImageIsMask(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetWidth(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetHeight(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetBitsPerComponent(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetBitsPerPixel(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetBytesPerRow(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetColorSpace(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGImageAlphaInfo CGImageGetAlphaInfo(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGImageGetDataProvider(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private unsafe static extern double* CGImageGetDecode(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGImageGetShouldInterpolate(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGColorRenderingIntent CGImageGetRenderingIntent(IntPtr image);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGBitmapFlags CGImageGetBitmapInfo(IntPtr image);
}
