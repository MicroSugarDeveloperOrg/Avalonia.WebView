using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageOptions
{
	public string BestGuessTypeIdentifier { get; set; }

	public bool ShouldCache { get; set; }

	[iOS(7, 0)]
	[Mac(10, 9)]
	public bool ShouldCacheImmediately { get; set; }

	public bool ShouldAllowFloat { get; set; }

	[Field("kCGImageSourceShouldAllowFloat", "ImageIO")]
	internal static IntPtr kShouldAllowFloat => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceShouldAllowFloat");

	[Field("kCGImageSourceShouldCache", "ImageIO")]
	internal static IntPtr kShouldCache => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceShouldCache");

	[Field("kCGImageSourceShouldCacheImmediately", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	internal static IntPtr kShouldCacheImmediately
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceShouldCacheImmediately");
		}
	}

	[Field("kCGImageSourceTypeIdentifierHint", "ImageIO")]
	internal static IntPtr kTypeIdentifierHint => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageSourceTypeIdentifierHint");

	public CGImageOptions()
	{
		ShouldCache = true;
	}

	internal virtual NSMutableDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (BestGuessTypeIdentifier != null)
		{
			nSMutableDictionary.LowlevelSetObject(new NSString(BestGuessTypeIdentifier), kTypeIdentifierHint);
		}
		if (!ShouldCache)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.FalseHandle, kShouldCache);
		}
		if (ShouldAllowFloat)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, kShouldAllowFloat);
		}
		if (kShouldCacheImmediately != IntPtr.Zero && ShouldCacheImmediately)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, kShouldCacheImmediately);
		}
		return nSMutableDictionary;
	}
}
