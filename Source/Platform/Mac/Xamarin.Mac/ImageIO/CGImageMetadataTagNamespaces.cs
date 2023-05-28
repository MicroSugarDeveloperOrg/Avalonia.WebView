using Foundation;
using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public static class CGImageMetadataTagNamespaces
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

	[Field("kCGImageMetadataNamespaceDublinCore", "ImageIO")]
	public static NSString DublinCore
	{
		get
		{
			if (_DublinCore == null)
			{
				_DublinCore = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceDublinCore");
			}
			return _DublinCore;
		}
	}

	[Field("kCGImageMetadataNamespaceExif", "ImageIO")]
	public static NSString Exif
	{
		get
		{
			if (_Exif == null)
			{
				_Exif = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceExif");
			}
			return _Exif;
		}
	}

	[Field("kCGImageMetadataNamespaceExifAux", "ImageIO")]
	public static NSString ExifAux
	{
		get
		{
			if (_ExifAux == null)
			{
				_ExifAux = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceExifAux");
			}
			return _ExifAux;
		}
	}

	[Field("kCGImageMetadataNamespaceExifEX", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifEx
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifEx == null)
			{
				_ExifEx = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceExifEX");
			}
			return _ExifEx;
		}
	}

	[Field("kCGImageMetadataNamespaceIPTCCore", "ImageIO")]
	public static NSString IPTCCore
	{
		get
		{
			if (_IPTCCore == null)
			{
				_IPTCCore = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceIPTCCore");
			}
			return _IPTCCore;
		}
	}

	[Field("kCGImageMetadataNamespaceIPTCExtension", "ImageIO")]
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
				_IPTCExtension = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceIPTCExtension");
			}
			return _IPTCExtension;
		}
	}

	[Field("kCGImageMetadataNamespacePhotoshop", "ImageIO")]
	public static NSString Photoshop
	{
		get
		{
			if (_Photoshop == null)
			{
				_Photoshop = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespacePhotoshop");
			}
			return _Photoshop;
		}
	}

	[Field("kCGImageMetadataNamespaceTIFF", "ImageIO")]
	public static NSString TIFF
	{
		get
		{
			if (_TIFF == null)
			{
				_TIFF = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceTIFF");
			}
			return _TIFF;
		}
	}

	[Field("kCGImageMetadataNamespaceXMPBasic", "ImageIO")]
	public static NSString XMPBasic
	{
		get
		{
			if (_XMPBasic == null)
			{
				_XMPBasic = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceXMPBasic");
			}
			return _XMPBasic;
		}
	}

	[Field("kCGImageMetadataNamespaceXMPRights", "ImageIO")]
	public static NSString XMPRights
	{
		get
		{
			if (_XMPRights == null)
			{
				_XMPRights = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageMetadataNamespaceXMPRights");
			}
			return _XMPRights;
		}
	}
}
