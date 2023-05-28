using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class AVCompressionPropertiesKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioKey;

	[Field("AVVideoCleanApertureKey", "AVFoundation")]
	public static NSString CleanApertureKey
	{
		get
		{
			if (_CleanApertureKey == null)
			{
				_CleanApertureKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureKey");
			}
			return _CleanApertureKey;
		}
	}

	[Field("AVVideoPixelAspectRatioKey", "AVFoundation")]
	public static NSString PixelAspectRatioKey
	{
		get
		{
			if (_PixelAspectRatioKey == null)
			{
				_PixelAspectRatioKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioKey");
			}
			return _PixelAspectRatioKey;
		}
	}
}
