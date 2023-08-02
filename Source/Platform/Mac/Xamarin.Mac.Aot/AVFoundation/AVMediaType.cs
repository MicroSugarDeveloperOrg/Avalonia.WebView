using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVMediaType
{
	private static NSString _Video;

	private static NSString _Audio;

	private static NSString _Text;

	private static NSString _ClosedCaption;

	private static NSString _Subtitle;

	private static NSString _Timecode;

	private static NSString _TimedMetadata;

	private static NSString _Muxed;

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
	public static NSString TimedMetadata
	{
		get
		{
			if (_TimedMetadata == null)
			{
				_TimedMetadata = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMediaTypeTimedMetadata");
			}
			return _TimedMetadata;
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
}
