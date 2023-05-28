using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class AVPixelAspectRatioPropertiesKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioHorizontalSpacingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioVerticalSpacingKey;

	[Field("AVVideoPixelAspectRatioHorizontalSpacingKey", "AVFoundation")]
	public static NSString PixelAspectRatioHorizontalSpacingKey
	{
		get
		{
			if (_PixelAspectRatioHorizontalSpacingKey == null)
			{
				_PixelAspectRatioHorizontalSpacingKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioHorizontalSpacingKey");
			}
			return _PixelAspectRatioHorizontalSpacingKey;
		}
	}

	[Field("AVVideoPixelAspectRatioVerticalSpacingKey", "AVFoundation")]
	public static NSString PixelAspectRatioVerticalSpacingKey
	{
		get
		{
			if (_PixelAspectRatioVerticalSpacingKey == null)
			{
				_PixelAspectRatioVerticalSpacingKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioVerticalSpacingKey");
			}
			return _PixelAspectRatioVerticalSpacingKey;
		}
	}
}
