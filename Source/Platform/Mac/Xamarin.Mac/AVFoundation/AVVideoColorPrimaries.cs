using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVVideoColorPrimaries
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Ebu_3213;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itu_R_2020;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itu_R_709_2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _P3_D65;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Smpte_C;

	[Field("AVVideoColorPrimaries_EBU_3213", "AVFoundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString Ebu_3213
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_Ebu_3213 == null)
			{
				_Ebu_3213 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_EBU_3213");
			}
			return _Ebu_3213;
		}
	}

	[Field("AVVideoColorPrimaries_ITU_R_2020", "AVFoundation")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString Itu_R_2020
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Itu_R_2020 == null)
			{
				_Itu_R_2020 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_ITU_R_2020");
			}
			return _Itu_R_2020;
		}
	}

	[Field("AVVideoColorPrimaries_ITU_R_709_2", "AVFoundation")]
	public static NSString Itu_R_709_2
	{
		get
		{
			if (_Itu_R_709_2 == null)
			{
				_Itu_R_709_2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_ITU_R_709_2");
			}
			return _Itu_R_709_2;
		}
	}

	[Field("AVVideoColorPrimaries_P3_D65", "AVFoundation")]
	public static NSString P3_D65
	{
		get
		{
			if (_P3_D65 == null)
			{
				_P3_D65 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_P3_D65");
			}
			return _P3_D65;
		}
	}

	[Field("AVVideoColorPrimaries_SMPTE_C", "AVFoundation")]
	public static NSString Smpte_C
	{
		get
		{
			if (_Smpte_C == null)
			{
				_Smpte_C = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoColorPrimaries_SMPTE_C");
			}
			return _Smpte_C;
		}
	}
}
