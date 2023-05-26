using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreGraphics;

public class CGBitmapContext : CGContext
{
	public IntPtr Data => CGBitmapContextGetData(base.Handle);

	public int Width => (int)(uint)CGBitmapContextGetWidth(base.Handle);

	public int Height => (int)(uint)CGBitmapContextGetHeight(base.Handle);

	public int BitsPerComponent => (int)(uint)CGBitmapContextGetBitsPerComponent(base.Handle);

	public int BitsPerPixel => (int)(uint)CGBitmapContextGetBitsPerPixel(base.Handle);

	public int BytesPerRow => (int)(uint)CGBitmapContextGetBytesPerRow(base.Handle);

	public CGColorSpace ColorSpace => new CGColorSpace(CGBitmapContextGetColorSpace(base.Handle), owns: true);

	public CGImageAlphaInfo AlphaInfo => CGBitmapContextGetAlphaInfo(base.Handle);

	public uint BitmapInfo => CGBitmapContextGetBitmapInfo(base.Handle);

	[Preserve(Conditional = true)]
	internal CGBitmapContext(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextCreate(IntPtr data, UIntPtr width, UIntPtr height, UIntPtr bitsPerComponent, UIntPtr bytesPerRow, IntPtr colorSpace, uint bitmapInfo);

	public CGBitmapContext(IntPtr data, int width, int height, int bitsPerComponent, int bytesPerRow, CGColorSpace colorSpace, CGImageAlphaInfo bitmapInfo)
		: base(CGBitmapContextCreate(data, (UIntPtr)(ulong)width, (UIntPtr)(ulong)height, (UIntPtr)(ulong)bitsPerComponent, (UIntPtr)(ulong)bytesPerRow, colorSpace.handle, (uint)bitmapInfo), owns: true)
	{
	}

	public CGBitmapContext(IntPtr data, int width, int height, int bitsPerComponent, int bytesPerRow, CGColorSpace colorSpace, CGBitmapFlags bitmapInfo)
		: base(CGBitmapContextCreate(data, (UIntPtr)(ulong)width, (UIntPtr)(ulong)height, (UIntPtr)(ulong)bitsPerComponent, (UIntPtr)(ulong)bytesPerRow, colorSpace.handle, (uint)bitmapInfo), owns: true)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextCreate(byte[] data, UIntPtr width, UIntPtr height, UIntPtr bitsPerComponent, UIntPtr bytesPerRow, IntPtr colorSpace, uint bitmapInfo);

	public CGBitmapContext(byte[] data, int width, int height, int bitsPerComponent, int bytesPerRow, CGColorSpace colorSpace, CGImageAlphaInfo bitmapInfo)
		: base(CGBitmapContextCreate(data, (UIntPtr)(ulong)width, (UIntPtr)(ulong)height, (UIntPtr)(ulong)bitsPerComponent, (UIntPtr)(ulong)bytesPerRow, colorSpace.handle, (uint)bitmapInfo), owns: true)
	{
	}

	public CGBitmapContext(byte[] data, int width, int height, int bitsPerComponent, int bytesPerRow, CGColorSpace colorSpace, CGBitmapFlags bitmapInfo)
		: base(CGBitmapContextCreate(data, (UIntPtr)(ulong)width, (UIntPtr)(ulong)height, (UIntPtr)(ulong)bitsPerComponent, (UIntPtr)(ulong)bytesPerRow, colorSpace.handle, (uint)bitmapInfo), owns: true)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextGetData(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern UIntPtr CGBitmapContextGetWidth(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern UIntPtr CGBitmapContextGetHeight(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern UIntPtr CGBitmapContextGetBitsPerComponent(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern UIntPtr CGBitmapContextGetBitsPerPixel(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern UIntPtr CGBitmapContextGetBytesPerRow(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextGetColorSpace(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGImageAlphaInfo CGBitmapContextGetAlphaInfo(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern uint CGBitmapContextGetBitmapInfo(IntPtr cgContextRef);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGBitmapContextCreateImage(IntPtr c);

	public CGImage ToImage()
	{
		return new CGImage(CGBitmapContextCreateImage(base.Handle), owns: true);
	}
}
