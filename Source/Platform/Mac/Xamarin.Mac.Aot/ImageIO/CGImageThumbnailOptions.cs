using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageThumbnailOptions : CGImageOptions
{
	private static IntPtr kCreateThumbnailFromImageIfAbsent;

	private static IntPtr kCreateThumbnailFromImageAlways;

	private static IntPtr kThumbnailMaxPixelSize;

	private static IntPtr kCreateThumbnailWithTransform;

	public bool CreateThumbnailFromImageIfAbsent { get; set; }

	public bool CreateThumbnailFromImageAlways { get; set; }

	public int? MaxPixelSize { get; set; }

	public bool CreateThumbnailWithTransform { get; set; }

	private static void Init()
	{
		if (!(kCreateThumbnailWithTransform != IntPtr.Zero))
		{
			IntPtr handle = Libraries.ImageIO.Handle;
			kCreateThumbnailFromImageIfAbsent = Dlfcn.GetIntPtr(handle, "kCGImageSourceCreateThumbnailFromImageIfAbsent");
			kCreateThumbnailFromImageAlways = Dlfcn.GetIntPtr(handle, "kCGImageSourceCreateThumbnailFromImageAlways");
			kThumbnailMaxPixelSize = Dlfcn.GetIntPtr(handle, "kCGImageSourceThumbnailMaxPixelSize");
			kCreateThumbnailWithTransform = Dlfcn.GetIntPtr(handle, "kCGImageSourceCreateThumbnailWithTransform");
		}
	}

	internal override NSMutableDictionary ToDictionary()
	{
		Init();
		NSMutableDictionary nSMutableDictionary = base.ToDictionary();
		IntPtr handle = CFBoolean.True.Handle;
		if (CreateThumbnailFromImageIfAbsent)
		{
			nSMutableDictionary.LowlevelSetObject(handle, kCreateThumbnailFromImageIfAbsent);
		}
		if (CreateThumbnailFromImageAlways)
		{
			nSMutableDictionary.LowlevelSetObject(handle, kCreateThumbnailFromImageAlways);
		}
		if (MaxPixelSize.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(new NSNumber(MaxPixelSize.Value), kThumbnailMaxPixelSize);
		}
		if (CreateThumbnailWithTransform)
		{
			nSMutableDictionary.LowlevelSetObject(handle, kCreateThumbnailWithTransform);
		}
		return nSMutableDictionary;
	}
}
