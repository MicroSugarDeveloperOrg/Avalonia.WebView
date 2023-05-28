using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public static class CGColorSpaceNames
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AcesCGLinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AdobeRGB1998;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AdobeRgb1998;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Dcip3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayP3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayP3_Hlg;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayP3_PQ;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayP3_PQ_Eotf;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedGray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedLinearDisplayP3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedLinearGray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedLinearItur_2020;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedLinearSrgb;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedSrgb;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericCMYK;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericCmyk;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericGray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericGrayGamma2_2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericLab;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericRGB;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericRGBLinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericRgb;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericRgbLinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenericXyz;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItuR_2020;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItuR_709;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itur_2020_Hlg;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itur_2020_PQ;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itur_2020_PQ_Eotf;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinearGray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinearSrgb;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RommRgb;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SRGB;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Srgb;

	[Field("kCGColorSpaceACESCGLinear", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString AcesCGLinear
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_AcesCGLinear == null)
			{
				_AcesCGLinear = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceACESCGLinear");
			}
			return _AcesCGLinear;
		}
	}

	[Field("kCGColorSpaceAdobeRGB1998", "CoreGraphics")]
	public static NSString AdobeRGB1998
	{
		get
		{
			if (_AdobeRGB1998 == null)
			{
				_AdobeRGB1998 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceAdobeRGB1998");
			}
			return _AdobeRGB1998;
		}
	}

	[Field("kCGColorSpaceAdobeRGB1998", "CoreGraphics")]
	public static NSString AdobeRgb1998
	{
		get
		{
			if (_AdobeRgb1998 == null)
			{
				_AdobeRgb1998 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceAdobeRGB1998");
			}
			return _AdobeRgb1998;
		}
	}

	[Field("kCGColorSpaceDCIP3", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	public static NSString Dcip3
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_Dcip3 == null)
			{
				_Dcip3 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceDCIP3");
			}
			return _Dcip3;
		}
	}

	[Field("kCGColorSpaceDisplayP3", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	public static NSString DisplayP3
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_DisplayP3 == null)
			{
				_DisplayP3 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3");
			}
			return _DisplayP3;
		}
	}

	[Field("kCGColorSpaceDisplayP3_HLG", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static NSString DisplayP3_Hlg
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DisplayP3_Hlg == null)
			{
				_DisplayP3_Hlg = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3_HLG");
			}
			return _DisplayP3_Hlg;
		}
	}

	[Field("kCGColorSpaceDisplayP3_PQ", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
	public static NSString DisplayP3_PQ
	{
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_DisplayP3_PQ == null)
			{
				_DisplayP3_PQ = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3_PQ");
			}
			return _DisplayP3_PQ;
		}
	}

	[Field("kCGColorSpaceDisplayP3_PQ_EOTF", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, null)]
	public static NSString DisplayP3_PQ_Eotf
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, null)]
		get
		{
			if (_DisplayP3_PQ_Eotf == null)
			{
				_DisplayP3_PQ_Eotf = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3_PQ_EOTF");
			}
			return _DisplayP3_PQ_Eotf;
		}
	}

	[Field("kCGColorSpaceExtendedGray", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ExtendedGray
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ExtendedGray == null)
			{
				_ExtendedGray = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedGray");
			}
			return _ExtendedGray;
		}
	}

	[Field("kCGColorSpaceExtendedLinearDisplayP3", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 14, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 3, PlatformArchitecture.All, null)]
	public static NSString ExtendedLinearDisplayP3
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 5, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_ExtendedLinearDisplayP3 == null)
			{
				_ExtendedLinearDisplayP3 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearDisplayP3");
			}
			return _ExtendedLinearDisplayP3;
		}
	}

	[Field("kCGColorSpaceExtendedLinearGray", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ExtendedLinearGray
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ExtendedLinearGray == null)
			{
				_ExtendedLinearGray = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearGray");
			}
			return _ExtendedLinearGray;
		}
	}

	[Field("kCGColorSpaceExtendedLinearITUR_2020", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 14, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 3, PlatformArchitecture.All, null)]
	public static NSString ExtendedLinearItur_2020
	{
		[Introduced(PlatformName.MacOSX, 10, 14, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 5, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_ExtendedLinearItur_2020 == null)
			{
				_ExtendedLinearItur_2020 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearITUR_2020");
			}
			return _ExtendedLinearItur_2020;
		}
	}

	[Field("kCGColorSpaceExtendedLinearSRGB", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ExtendedLinearSrgb
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ExtendedLinearSrgb == null)
			{
				_ExtendedLinearSrgb = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearSRGB");
			}
			return _ExtendedLinearSrgb;
		}
	}

	[Field("kCGColorSpaceExtendedSRGB", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ExtendedSrgb
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ExtendedSrgb == null)
			{
				_ExtendedSrgb = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedSRGB");
			}
			return _ExtendedSrgb;
		}
	}

	[Field("kCGColorSpaceGenericCMYK", "CoreGraphics")]
	public static NSString GenericCMYK
	{
		get
		{
			if (_GenericCMYK == null)
			{
				_GenericCMYK = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericCMYK");
			}
			return _GenericCMYK;
		}
	}

	[Field("kCGColorSpaceGenericCMYK", "CoreGraphics")]
	public static NSString GenericCmyk
	{
		get
		{
			if (_GenericCmyk == null)
			{
				_GenericCmyk = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericCMYK");
			}
			return _GenericCmyk;
		}
	}

	[Field("kCGColorSpaceGenericGray", "CoreGraphics")]
	public static NSString GenericGray
	{
		get
		{
			if (_GenericGray == null)
			{
				_GenericGray = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericGray");
			}
			return _GenericGray;
		}
	}

	[Field("kCGColorSpaceGenericGrayGamma2_2", "CoreGraphics")]
	public static NSString GenericGrayGamma2_2
	{
		get
		{
			if (_GenericGrayGamma2_2 == null)
			{
				_GenericGrayGamma2_2 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericGrayGamma2_2");
			}
			return _GenericGrayGamma2_2;
		}
	}

	[Field("kCGColorSpaceGenericLab", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString GenericLab
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_GenericLab == null)
			{
				_GenericLab = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericLab");
			}
			return _GenericLab;
		}
	}

	[Field("kCGColorSpaceGenericRGB", "CoreGraphics")]
	public static NSString GenericRGB
	{
		get
		{
			if (_GenericRGB == null)
			{
				_GenericRGB = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGB");
			}
			return _GenericRGB;
		}
	}

	[Field("kCGColorSpaceGenericRGBLinear", "CoreGraphics")]
	public static NSString GenericRGBLinear
	{
		get
		{
			if (_GenericRGBLinear == null)
			{
				_GenericRGBLinear = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGBLinear");
			}
			return _GenericRGBLinear;
		}
	}

	[Field("kCGColorSpaceGenericRGB", "CoreGraphics")]
	public static NSString GenericRgb
	{
		get
		{
			if (_GenericRgb == null)
			{
				_GenericRgb = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGB");
			}
			return _GenericRgb;
		}
	}

	[Field("kCGColorSpaceGenericRGBLinear", "CoreGraphics")]
	public static NSString GenericRgbLinear
	{
		get
		{
			if (_GenericRgbLinear == null)
			{
				_GenericRgbLinear = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGBLinear");
			}
			return _GenericRgbLinear;
		}
	}

	[Field("kCGColorSpaceGenericXYZ", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString GenericXyz
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_GenericXyz == null)
			{
				_GenericXyz = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericXYZ");
			}
			return _GenericXyz;
		}
	}

	[Field("kCGColorSpaceITUR_2020", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ItuR_2020
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ItuR_2020 == null)
			{
				_ItuR_2020 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020");
			}
			return _ItuR_2020;
		}
	}

	[Field("kCGColorSpaceITUR_709", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ItuR_709
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ItuR_709 == null)
			{
				_ItuR_709 = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_709");
			}
			return _ItuR_709;
		}
	}

	[Field("kCGColorSpaceITUR_2020_HLG", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static NSString Itur_2020_Hlg
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Itur_2020_Hlg == null)
			{
				_Itur_2020_Hlg = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020_HLG");
			}
			return _Itur_2020_Hlg;
		}
	}

	[Field("kCGColorSpaceITUR_2020_PQ", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
	public static NSString Itur_2020_PQ
	{
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_Itur_2020_PQ == null)
			{
				_Itur_2020_PQ = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020_PQ");
			}
			return _Itur_2020_PQ;
		}
	}

	[Field("kCGColorSpaceITUR_2020_PQ_EOTF", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, null)]
	public static NSString Itur_2020_PQ_Eotf
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, null)]
		get
		{
			if (_Itur_2020_PQ_Eotf == null)
			{
				_Itur_2020_PQ_Eotf = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020_PQ_EOTF");
			}
			return _Itur_2020_PQ_Eotf;
		}
	}

	[Field("kCGColorSpaceLinearGray", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString LinearGray
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_LinearGray == null)
			{
				_LinearGray = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceLinearGray");
			}
			return _LinearGray;
		}
	}

	[Field("kCGColorSpaceLinearSRGB", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString LinearSrgb
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_LinearSrgb == null)
			{
				_LinearSrgb = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceLinearSRGB");
			}
			return _LinearSrgb;
		}
	}

	[Field("kCGColorSpaceROMMRGB", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	public static NSString RommRgb
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_RommRgb == null)
			{
				_RommRgb = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceROMMRGB");
			}
			return _RommRgb;
		}
	}

	[Field("kCGColorSpaceSRGB", "CoreGraphics")]
	public static NSString SRGB
	{
		get
		{
			if (_SRGB == null)
			{
				_SRGB = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceSRGB");
			}
			return _SRGB;
		}
	}

	[Field("kCGColorSpaceSRGB", "CoreGraphics")]
	public static NSString Srgb
	{
		get
		{
			if (_Srgb == null)
			{
				_Srgb = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorSpaceSRGB");
			}
			return _Srgb;
		}
	}
}
