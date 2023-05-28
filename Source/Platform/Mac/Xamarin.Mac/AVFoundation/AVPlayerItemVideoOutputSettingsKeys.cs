using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class AVPlayerItemVideoOutputSettingsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowWideColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorPropertiesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CompressionPropertiesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalingModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WidthKey;

	[Field("AVVideoAllowWideColorKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString AllowWideColorKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowWideColorKey == null)
			{
				_AllowWideColorKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoAllowWideColorKey");
			}
			return _AllowWideColorKey;
		}
	}

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

	[Field("AVVideoColorPropertiesKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ColorPropertiesKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ColorPropertiesKey == null)
			{
				_ColorPropertiesKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoColorPropertiesKey");
			}
			return _ColorPropertiesKey;
		}
	}

	[Field("AVVideoCompressionPropertiesKey", "AVFoundation")]
	public static NSString CompressionPropertiesKey
	{
		get
		{
			if (_CompressionPropertiesKey == null)
			{
				_CompressionPropertiesKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCompressionPropertiesKey");
			}
			return _CompressionPropertiesKey;
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

	[Field("AVVideoScalingModeKey", "AVFoundation")]
	public static NSString ScalingModeKey
	{
		get
		{
			if (_ScalingModeKey == null)
			{
				_ScalingModeKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoScalingModeKey");
			}
			return _ScalingModeKey;
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
