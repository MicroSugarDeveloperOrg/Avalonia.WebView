using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVVideoTransferFunction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVVideoTransferFunction_Itu_R_709_2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVVideoTransferFunction_Smpte_240M_1995;

	[Field("AVVideoTransferFunction_ITU_R_709_2", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString AVVideoTransferFunction_Itu_R_709_2
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AVVideoTransferFunction_Itu_R_709_2 == null)
			{
				_AVVideoTransferFunction_Itu_R_709_2 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoTransferFunction_ITU_R_709_2");
			}
			return _AVVideoTransferFunction_Itu_R_709_2;
		}
	}

	[Field("AVVideoTransferFunction_SMPTE_240M_1995", "AVFoundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString AVVideoTransferFunction_Smpte_240M_1995
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_AVVideoTransferFunction_Smpte_240M_1995 == null)
			{
				_AVVideoTransferFunction_Smpte_240M_1995 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoTransferFunction_SMPTE_240M_1995");
			}
			return _AVVideoTransferFunction_Smpte_240M_1995;
		}
	}
}
