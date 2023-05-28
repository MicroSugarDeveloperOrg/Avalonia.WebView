using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
internal static class AVCapturePhotoSettingsThumbnailFormatKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WidthKey;

	[Field("AVVideoCodecKey", "AVFoundation")]
	public static NSString CodecKey
	{
		get
		{
			if (_CodecKey == null)
			{
				_CodecKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCodecKey");
			}
			return _CodecKey;
		}
	}

	[Field("AVVideoHeightKey", "AVFoundation")]
	public static NSString HeightKey
	{
		get
		{
			if (_HeightKey == null)
			{
				_HeightKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoHeightKey");
			}
			return _HeightKey;
		}
	}

	[Field("AVVideoWidthKey", "AVFoundation")]
	public static NSString WidthKey
	{
		get
		{
			if (_WidthKey == null)
			{
				_WidthKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoWidthKey");
			}
			return _WidthKey;
		}
	}
}
