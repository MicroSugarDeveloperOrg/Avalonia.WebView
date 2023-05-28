using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVVideoYCbCrMatrix
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itu_R_2020;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itu_R_601_4;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Itu_R_709_2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Smpte_240M_1995;

	[Field("AVVideoYCbCrMatrix_ITU_R_2020", "AVFoundation")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString Itu_R_2020
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_Itu_R_2020 == null)
			{
				_Itu_R_2020 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoYCbCrMatrix_ITU_R_2020");
			}
			return _Itu_R_2020;
		}
	}

	[Field("AVVideoYCbCrMatrix_ITU_R_601_4", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString Itu_R_601_4
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Itu_R_601_4 == null)
			{
				_Itu_R_601_4 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoYCbCrMatrix_ITU_R_601_4");
			}
			return _Itu_R_601_4;
		}
	}

	[Field("AVVideoYCbCrMatrix_ITU_R_709_2", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString Itu_R_709_2
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Itu_R_709_2 == null)
			{
				_Itu_R_709_2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoYCbCrMatrix_ITU_R_709_2");
			}
			return _Itu_R_709_2;
		}
	}

	[Field("AVVideoYCbCrMatrix_SMPTE_240M_1995", "AVFoundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString Smpte_240M_1995
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_Smpte_240M_1995 == null)
			{
				_Smpte_240M_1995 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoYCbCrMatrix_SMPTE_240M_1995");
			}
			return _Smpte_240M_1995;
		}
	}
}
