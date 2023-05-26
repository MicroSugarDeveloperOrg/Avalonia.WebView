using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreVideo;
using ObjCRuntime;

namespace CoreMedia;

[Since(4, 0)]
public class CMVideoFormatDescription : CMFormatDescription
{
	public CMVideoDimensions Dimensions => CMFormatDescription.CMVideoFormatDescriptionGetDimensions(handle);

	internal CMVideoFormatDescription(IntPtr handle)
		: base(handle)
	{
	}

	internal CMVideoFormatDescription(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionCreate(IntPtr allocator, CMVideoCodecType codecType, int width, int height, IntPtr extensions, out IntPtr outDesc);

	public CMVideoFormatDescription(CMVideoCodecType codecType, CMVideoDimensions size)
		: base(IntPtr.Zero)
	{
		CMFormatDescriptionError cMFormatDescriptionError = CMVideoFormatDescriptionCreate(IntPtr.Zero, codecType, size.Width, size.Height, IntPtr.Zero, out handle);
		if (cMFormatDescriptionError != 0)
		{
			throw new ArgumentException(cMFormatDescriptionError.ToString());
		}
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionCreateForImageBuffer(IntPtr allocator, IntPtr imageBuffer, out IntPtr outDesc);

	public static CMVideoFormatDescription CreateForImageBuffer(CVImageBuffer imageBuffer, out CMFormatDescriptionError error)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		error = CMVideoFormatDescriptionCreateForImageBuffer(IntPtr.Zero, imageBuffer.handle, out var outDesc);
		if (error != 0)
		{
			return null;
		}
		return new CMVideoFormatDescription(outDesc, owns: true);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private new static extern CGRect CMVideoFormatDescriptionGetCleanAperture(IntPtr handle, bool originIsAtTopLeft);

	public CGRect GetCleanAperture(bool originIsAtTopLeft)
	{
		return CMVideoFormatDescriptionGetCleanAperture(handle, originIsAtTopLeft);
	}

	public CGSize GetPresentationDimensions(bool usePixelAspectRatio, bool useCleanAperture)
	{
		return CMFormatDescription.CMVideoFormatDescriptionGetPresentationDimensions(handle, usePixelAspectRatio, useCleanAperture);
	}
}
