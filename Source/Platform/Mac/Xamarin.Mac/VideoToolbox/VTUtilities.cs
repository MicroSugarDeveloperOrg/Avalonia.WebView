using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreVideo;
using ObjCRuntime;

namespace VideoToolbox;

[Mac(10, 11)]
[iOS(9, 0)]
[TV(10, 2)]
public static class VTUtilities
{
	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTCreateCGImageFromCVPixelBuffer(IntPtr pixelBuffer, IntPtr options, out IntPtr imageOut);

	public static VTStatus ToCGImage(this CVPixelBuffer pixelBuffer, out CGImage image)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (pixelBuffer.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CVPixelBuffer");
		}
		image = null;
		IntPtr imageOut;
		VTStatus result = VTCreateCGImageFromCVPixelBuffer(pixelBuffer.Handle, IntPtr.Zero, out imageOut);
		if (imageOut != IntPtr.Zero)
		{
			image = Runtime.GetINativeObject<CGImage>(imageOut, owns: true);
		}
		return result;
	}
}
