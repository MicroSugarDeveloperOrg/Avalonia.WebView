using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageThumbnailOptions : CGImageOptions
{
	public bool CreateThumbnailFromImageIfAbsent { get; set; }

	public bool CreateThumbnailFromImageAlways { get; set; }

	public int? MaxPixelSize { get; set; }

	public bool CreateThumbnailWithTransform { get; set; }

	[iOS(9, 0)]
	[Mac(10, 11)]
	public int? SubsampleFactor { get; set; }

	[Field("kCGImageSourceSubsampleFactor", "ImageIO")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	internal static IntPtr kCGImageSourceSubsampleFactor
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceSubsampleFactor");
		}
	}

	[Field("kCGImageSourceCreateThumbnailFromImageAlways", "ImageIO")]
	internal static IntPtr kCreateThumbnailFromImageAlways => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceCreateThumbnailFromImageAlways");

	[Field("kCGImageSourceCreateThumbnailFromImageIfAbsent", "ImageIO")]
	internal static IntPtr kCreateThumbnailFromImageIfAbsent => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceCreateThumbnailFromImageIfAbsent");

	[Field("kCGImageSourceCreateThumbnailWithTransform", "ImageIO")]
	internal static IntPtr kCreateThumbnailWithTransform => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceCreateThumbnailWithTransform");

	[Field("kCGImageSourceThumbnailMaxPixelSize", "ImageIO")]
	internal static IntPtr kThumbnailMaxPixelSize => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceThumbnailMaxPixelSize");

	internal override NSMutableDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = base.ToDictionary();
		IntPtr trueHandle = CFBoolean.TrueHandle;
		if (CreateThumbnailFromImageIfAbsent)
		{
			nSMutableDictionary.LowlevelSetObject(trueHandle, kCreateThumbnailFromImageIfAbsent);
		}
		if (CreateThumbnailFromImageAlways)
		{
			nSMutableDictionary.LowlevelSetObject(trueHandle, kCreateThumbnailFromImageAlways);
		}
		if (MaxPixelSize.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(new NSNumber(MaxPixelSize.Value), kThumbnailMaxPixelSize);
		}
		if (CreateThumbnailWithTransform)
		{
			nSMutableDictionary.LowlevelSetObject(trueHandle, kCreateThumbnailWithTransform);
		}
		if (SubsampleFactor.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(new NSNumber(SubsampleFactor.Value), kCGImageSourceSubsampleFactor);
		}
		return nSMutableDictionary;
	}
}
