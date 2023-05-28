using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreGraphics;

public class CGBitmapContext : CGContext
{
	private GCHandle buffer;

	public IntPtr Data => CGBitmapContextGetData(base.Handle);

	public nint Width => CGBitmapContextGetWidth(base.Handle);

	public nint Height => CGBitmapContextGetHeight(base.Handle);

	public nint BitsPerComponent => CGBitmapContextGetBitsPerComponent(base.Handle);

	public nint BitsPerPixel => CGBitmapContextGetBitsPerPixel(base.Handle);

	public nint BytesPerRow => CGBitmapContextGetBytesPerRow(base.Handle);

	public CGColorSpace ColorSpace
	{
		get
		{
			IntPtr intPtr = CGBitmapContextGetColorSpace(base.Handle);
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr, owns: false);
		}
	}

	public CGImageAlphaInfo AlphaInfo => CGBitmapContextGetAlphaInfo(base.Handle);

	public CGBitmapFlags BitmapInfo => (CGBitmapFlags)CGBitmapContextGetBitmapInfo(base.Handle);

	[Preserve(Conditional = true)]
	internal CGBitmapContext(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextCreate(IntPtr data, nint width, nint height, nint bitsPerComponent, nint bytesPerRow, IntPtr colorSpace, uint bitmapInfo);

	private static IntPtr GetHandle(CGColorSpace colorSpace)
	{
		return colorSpace?.Handle ?? IntPtr.Zero;
	}

	public CGBitmapContext(IntPtr data, nint width, nint height, nint bitsPerComponent, nint bytesPerRow, CGColorSpace colorSpace, CGImageAlphaInfo bitmapInfo)
		: base(CGBitmapContextCreate(data, width, height, bitsPerComponent, bytesPerRow, GetHandle(colorSpace), (uint)bitmapInfo), owns: true)
	{
	}

	public CGBitmapContext(IntPtr data, nint width, nint height, nint bitsPerComponent, nint bytesPerRow, CGColorSpace colorSpace, CGBitmapFlags bitmapInfo)
		: base(CGBitmapContextCreate(data, width, height, bitsPerComponent, bytesPerRow, GetHandle(colorSpace), (uint)bitmapInfo), owns: true)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextCreate(byte[] data, nint width, nint height, nint bitsPerComponent, nint bytesPerRow, IntPtr colorSpace, uint bitmapInfo);

	public CGBitmapContext(byte[] data, nint width, nint height, nint bitsPerComponent, nint bytesPerRow, CGColorSpace colorSpace, CGImageAlphaInfo bitmapInfo)
	{
		if (data != null)
		{
			buffer = GCHandle.Alloc(data, GCHandleType.Pinned);
		}
		base.Handle = CGBitmapContextCreate(data, width, height, bitsPerComponent, bytesPerRow, GetHandle(colorSpace), (uint)bitmapInfo);
	}

	public CGBitmapContext(byte[] data, nint width, nint height, nint bitsPerComponent, nint bytesPerRow, CGColorSpace colorSpace, CGBitmapFlags bitmapInfo)
	{
		if (data != null)
		{
			buffer = GCHandle.Alloc(data, GCHandleType.Pinned);
		}
		base.Handle = CGBitmapContextCreate(data, width, height, bitsPerComponent, bytesPerRow, GetHandle(colorSpace), (uint)bitmapInfo);
	}

	protected override void Dispose(bool disposing)
	{
		if (buffer.IsAllocated)
		{
			buffer.Free();
		}
		base.Dispose(disposing);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextGetData(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGBitmapContextGetWidth(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGBitmapContextGetHeight(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGBitmapContextGetBitsPerComponent(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGBitmapContextGetBitsPerPixel(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGBitmapContextGetBytesPerRow(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextGetColorSpace(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGImageAlphaInfo CGBitmapContextGetAlphaInfo(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern uint CGBitmapContextGetBitmapInfo(IntPtr context);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextCreateImage(IntPtr context);

	public CGImage ToImage()
	{
		IntPtr intPtr = CGBitmapContextCreateImage(base.Handle);
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr, owns: true);
	}
}
