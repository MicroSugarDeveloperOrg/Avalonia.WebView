using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVMediaType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Audio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ClosedCaption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Metadata;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Muxed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Subtitle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Text;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Timecode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimedMetadata;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Video;

	[Field("AVMediaTypeAudio", "AVFoundation")]
	public static NSString Audio
	{
		get
		{
			if (_Audio == null)
			{
				_Audio = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeAudio");
			}
			return _Audio;
		}
	}

	[Field("AVMediaTypeClosedCaption", "AVFoundation")]
	public static NSString ClosedCaption
	{
		get
		{
			if (_ClosedCaption == null)
			{
				_ClosedCaption = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeClosedCaption");
			}
			return _ClosedCaption;
		}
	}

	[Field("AVMediaTypeMetadata", "AVFoundation")]
	public static NSString Metadata
	{
		get
		{
			if (_Metadata == null)
			{
				_Metadata = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeMetadata");
			}
			return _Metadata;
		}
	}

	[Field("AVMediaTypeMuxed", "AVFoundation")]
	public static NSString Muxed
	{
		get
		{
			if (_Muxed == null)
			{
				_Muxed = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeMuxed");
			}
			return _Muxed;
		}
	}

	[Field("AVMediaTypeSubtitle", "AVFoundation")]
	public static NSString Subtitle
	{
		get
		{
			if (_Subtitle == null)
			{
				_Subtitle = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeSubtitle");
			}
			return _Subtitle;
		}
	}

	[Field("AVMediaTypeText", "AVFoundation")]
	public static NSString Text
	{
		get
		{
			if (_Text == null)
			{
				_Text = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeText");
			}
			return _Text;
		}
	}

	[Field("AVMediaTypeTimecode", "AVFoundation")]
	public static NSString Timecode
	{
		get
		{
			if (_Timecode == null)
			{
				_Timecode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeTimecode");
			}
			return _Timecode;
		}
	}

	[Field("AVMediaTypeTimedMetadata", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, null)]
	public static NSString TimedMetadata
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, null)]
		get
		{
			if (_TimedMetadata == null)
			{
				_TimedMetadata = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeTimedMetadata");
			}
			return _TimedMetadata;
		}
	}

	[Field("AVMediaTypeVideo", "AVFoundation")]
	public static NSString Video
	{
		get
		{
			if (_Video == null)
			{
				_Video = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeVideo");
			}
			return _Video;
		}
	}
}
