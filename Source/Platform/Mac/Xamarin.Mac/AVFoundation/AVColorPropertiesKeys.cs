using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class AVColorPropertiesKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVVideoColorPrimariesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVVideoTransferFunctionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVVideoYCbCrMatrixKey;

	[Field("AVVideoColorPrimariesKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString AVVideoColorPrimariesKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AVVideoColorPrimariesKey == null)
			{
				_AVVideoColorPrimariesKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoColorPrimariesKey");
			}
			return _AVVideoColorPrimariesKey;
		}
	}

	[Field("AVVideoTransferFunctionKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString AVVideoTransferFunctionKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AVVideoTransferFunctionKey == null)
			{
				_AVVideoTransferFunctionKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoTransferFunctionKey");
			}
			return _AVVideoTransferFunctionKey;
		}
	}

	[Field("AVVideoYCbCrMatrixKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString AVVideoYCbCrMatrixKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AVVideoYCbCrMatrixKey == null)
			{
				_AVVideoYCbCrMatrixKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoYCbCrMatrixKey");
			}
			return _AVVideoYCbCrMatrixKey;
		}
	}
}
