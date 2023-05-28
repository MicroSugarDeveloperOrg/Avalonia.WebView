using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVFileType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AC3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Aifc;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Aiff;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Amr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleM4A;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleM4V;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CoreAudioFormat;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnhancedAC3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Mpeg4;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MpegLayer3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QuickTimeMovie;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SunAU;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThreeGpp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThreeGpp2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Wave;

	[Field("AVFileTypeAC3", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString AC3
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_AC3 == null)
			{
				_AC3 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAC3");
			}
			return _AC3;
		}
	}

	[Field("AVFileTypeAIFC", "AVFoundation")]
	public static NSString Aifc
	{
		get
		{
			if (_Aifc == null)
			{
				_Aifc = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAIFC");
			}
			return _Aifc;
		}
	}

	[Field("AVFileTypeAIFF", "AVFoundation")]
	public static NSString Aiff
	{
		get
		{
			if (_Aiff == null)
			{
				_Aiff = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAIFF");
			}
			return _Aiff;
		}
	}

	[Field("AVFileTypeAMR", "AVFoundation")]
	public static NSString Amr
	{
		get
		{
			if (_Amr == null)
			{
				_Amr = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAMR");
			}
			return _Amr;
		}
	}

	[Field("AVFileTypeAppleM4A", "AVFoundation")]
	public static NSString AppleM4A
	{
		get
		{
			if (_AppleM4A == null)
			{
				_AppleM4A = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAppleM4A");
			}
			return _AppleM4A;
		}
	}

	[Field("AVFileTypeAppleM4V", "AVFoundation")]
	public static NSString AppleM4V
	{
		get
		{
			if (_AppleM4V == null)
			{
				_AppleM4V = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeAppleM4V");
			}
			return _AppleM4V;
		}
	}

	[Field("AVFileTypeCoreAudioFormat", "AVFoundation")]
	public static NSString CoreAudioFormat
	{
		get
		{
			if (_CoreAudioFormat == null)
			{
				_CoreAudioFormat = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeCoreAudioFormat");
			}
			return _CoreAudioFormat;
		}
	}

	[Field("AVFileTypeEnhancedAC3", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString EnhancedAC3
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_EnhancedAC3 == null)
			{
				_EnhancedAC3 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeEnhancedAC3");
			}
			return _EnhancedAC3;
		}
	}

	[Field("AVFileTypeMPEG4", "AVFoundation")]
	public static NSString Mpeg4
	{
		get
		{
			if (_Mpeg4 == null)
			{
				_Mpeg4 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeMPEG4");
			}
			return _Mpeg4;
		}
	}

	[Field("AVFileTypeMPEGLayer3", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MpegLayer3
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MpegLayer3 == null)
			{
				_MpegLayer3 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeMPEGLayer3");
			}
			return _MpegLayer3;
		}
	}

	[Field("AVFileTypeQuickTimeMovie", "AVFoundation")]
	public static NSString QuickTimeMovie
	{
		get
		{
			if (_QuickTimeMovie == null)
			{
				_QuickTimeMovie = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeQuickTimeMovie");
			}
			return _QuickTimeMovie;
		}
	}

	[Field("AVFileTypeSunAU", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString SunAU
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_SunAU == null)
			{
				_SunAU = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeSunAU");
			}
			return _SunAU;
		}
	}

	[Field("AVFileType3GPP", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ThreeGpp
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ThreeGpp == null)
			{
				_ThreeGpp = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileType3GPP");
			}
			return _ThreeGpp;
		}
	}

	[Field("AVFileType3GPP2", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString ThreeGpp2
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ThreeGpp2 == null)
			{
				_ThreeGpp2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileType3GPP2");
			}
			return _ThreeGpp2;
		}
	}

	[Field("AVFileTypeWAVE", "AVFoundation")]
	public static NSString Wave
	{
		get
		{
			if (_Wave == null)
			{
				_Wave = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFileTypeWAVE");
			}
			return _Wave;
		}
	}
}
