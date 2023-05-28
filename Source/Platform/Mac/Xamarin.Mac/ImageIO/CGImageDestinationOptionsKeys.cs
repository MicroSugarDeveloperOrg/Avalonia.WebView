using Foundation;
using ObjCRuntime;

namespace ImageIO;

public static class CGImageDestinationOptionsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackgroundColor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EmbedThumbnail;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageMaxPixelSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LossyCompressionQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptimizeColorForSharing;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString CIFFDictionary => CGImageProperties.CIFFDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString DNGDictionary => CGImageProperties.DNGDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString EightBIMDictionary => CGImageProperties.EightBIMDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString ExifAuxDictionary => CGImageProperties.ExifAuxDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString ExifDictionary => CGImageProperties.ExifDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString GIFDictionary => CGImageProperties.GIFDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString GPSDictionary => CGImageProperties.GPSDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString IPTCDictionary => CGImageProperties.IPTCDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString JFIFDictionary => CGImageProperties.JFIFDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString PNGDictionary => CGImageProperties.PNGDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString RawDictionary => CGImageProperties.RawDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString TIFFDictionary => CGImageProperties.TIFFDictionary;

	[Field("kCGImageDestinationBackgroundColor", "ImageIO")]
	public static NSString BackgroundColor
	{
		get
		{
			if (_BackgroundColor == null)
			{
				_BackgroundColor = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageDestinationBackgroundColor");
			}
			return _BackgroundColor;
		}
	}

	[Field("kCGImageDestinationEmbedThumbnail", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString EmbedThumbnail
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_EmbedThumbnail == null)
			{
				_EmbedThumbnail = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageDestinationEmbedThumbnail");
			}
			return _EmbedThumbnail;
		}
	}

	[Field("kCGImageDestinationImageMaxPixelSize", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString ImageMaxPixelSize
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_ImageMaxPixelSize == null)
			{
				_ImageMaxPixelSize = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageDestinationImageMaxPixelSize");
			}
			return _ImageMaxPixelSize;
		}
	}

	[Field("kCGImageDestinationLossyCompressionQuality", "ImageIO")]
	public static NSString LossyCompressionQuality
	{
		get
		{
			if (_LossyCompressionQuality == null)
			{
				_LossyCompressionQuality = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageDestinationLossyCompressionQuality");
			}
			return _LossyCompressionQuality;
		}
	}

	[Field("kCGImageDestinationOptimizeColorForSharing", "ImageIO")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 2, 3, PlatformArchitecture.All, null)]
	public static NSString OptimizeColorForSharing
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 2, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_OptimizeColorForSharing == null)
			{
				_OptimizeColorForSharing = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageDestinationOptimizeColorForSharing");
			}
			return _OptimizeColorForSharing;
		}
	}
}
