using Foundation;
using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public static class CGImageMetadataTagPrefixes
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DublinCore;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Exif;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAux;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifEx;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCore;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtension;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Photoshop;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _XMPBasic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _XMPRights;

	[Field("kCGImageMetadataPrefixDublinCore", "ImageIO")]
	public static NSString DublinCore
	{
		get
		{
			if (_DublinCore == null)
			{
				_DublinCore = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixDublinCore");
			}
			return _DublinCore;
		}
	}

	[Field("kCGImageMetadataPrefixExif", "ImageIO")]
	public static NSString Exif
	{
		get
		{
			if (_Exif == null)
			{
				_Exif = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixExif");
			}
			return _Exif;
		}
	}

	[Field("kCGImageMetadataPrefixExifAux", "ImageIO")]
	public static NSString ExifAux
	{
		get
		{
			if (_ExifAux == null)
			{
				_ExifAux = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixExifAux");
			}
			return _ExifAux;
		}
	}

	[Field("kCGImageMetadataPrefixExifEX", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifEx
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifEx == null)
			{
				_ExifEx = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixExifEX");
			}
			return _ExifEx;
		}
	}

	[Field("kCGImageMetadataPrefixIPTCCore", "ImageIO")]
	public static NSString IPTCCore
	{
		get
		{
			if (_IPTCCore == null)
			{
				_IPTCCore = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixIPTCCore");
			}
			return _IPTCCore;
		}
	}

	[Field("kCGImageMetadataPrefixIPTCExtension", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtension
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtension == null)
			{
				_IPTCExtension = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixIPTCExtension");
			}
			return _IPTCExtension;
		}
	}

	[Field("kCGImageMetadataPrefixPhotoshop", "ImageIO")]
	public static NSString Photoshop
	{
		get
		{
			if (_Photoshop == null)
			{
				_Photoshop = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixPhotoshop");
			}
			return _Photoshop;
		}
	}

	[Field("kCGImageMetadataPrefixTIFF", "ImageIO")]
	public static NSString TIFF
	{
		get
		{
			if (_TIFF == null)
			{
				_TIFF = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixTIFF");
			}
			return _TIFF;
		}
	}

	[Field("kCGImageMetadataPrefixXMPBasic", "ImageIO")]
	public static NSString XMPBasic
	{
		get
		{
			if (_XMPBasic == null)
			{
				_XMPBasic = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixXMPBasic");
			}
			return _XMPBasic;
		}
	}

	[Field("kCGImageMetadataPrefixXMPRights", "ImageIO")]
	public static NSString XMPRights
	{
		get
		{
			if (_XMPRights == null)
			{
				_XMPRights = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataPrefixXMPRights");
			}
			return _XMPRights;
		}
	}
}
