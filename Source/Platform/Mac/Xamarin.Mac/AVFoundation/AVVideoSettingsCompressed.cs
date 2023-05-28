using System;
using Foundation;

namespace AVFoundation;

public class AVVideoSettingsCompressed : DictionaryContainer
{
	public AVVideoCodec? Codec
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(AVVideo.CodecKey);
			if (nSStringValue == AVVideo.CodecH264)
			{
				return AVVideoCodec.H264;
			}
			if (nSStringValue == AVVideo.CodecJPEG)
			{
				return AVVideoCodec.JPEG;
			}
			return null;
		}
		set
		{
			NSString nSString = value switch
			{
				AVVideoCodec.H264 => AVVideo.CodecH264, 
				AVVideoCodec.JPEG => AVVideo.CodecJPEG, 
				null => null, 
				_ => throw new ArgumentException("value"), 
			};
			if (nSString == null)
			{
				RemoveValue(AVVideo.CodecKey);
			}
			else
			{
				SetNativeValue(AVVideo.CodecKey, nSString);
			}
		}
	}

	public int? Width
	{
		get
		{
			return GetInt32Value(AVVideo.WidthKey);
		}
		set
		{
			SetNumberValue(AVVideo.WidthKey, value);
		}
	}

	public int? Height
	{
		get
		{
			return GetInt32Value(AVVideo.HeightKey);
		}
		set
		{
			SetNumberValue(AVVideo.HeightKey, value);
		}
	}

	[iOS(7, 0)]
	public double? MaxKeyFrameIntervalDuration
	{
		get
		{
			return GetDoubleValue(AVVideo.MaxKeyFrameIntervalDurationKey);
		}
		set
		{
			SetNumberValue(AVVideo.MaxKeyFrameIntervalDurationKey, value);
		}
	}

	public AVVideoScalingMode? ScalingMode
	{
		get
		{
			return AVVideoSettingsUncompressed.ScalingModeFromNSString(GetNSStringValue(AVVideo.ScalingModeKey));
		}
		set
		{
			NSString nSString = value switch
			{
				AVVideoScalingMode.Fit => AVVideoScalingModeKey.Fit, 
				AVVideoScalingMode.Resize => AVVideoScalingModeKey.Resize, 
				AVVideoScalingMode.ResizeAspect => AVVideoScalingModeKey.ResizeAspect, 
				AVVideoScalingMode.ResizeAspectFill => AVVideoScalingModeKey.ResizeAspectFill, 
				null => null, 
				_ => throw new ArgumentException("value"), 
			};
			if (nSString == null)
			{
				RemoveValue(AVVideo.ScalingModeKey);
			}
			else
			{
				SetNativeValue(AVVideo.ScalingModeKey, nSString);
			}
		}
	}

	public AVVideoCodecSettings CodecSettings
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(AVVideo.CompressionPropertiesKey);
			if (nSDictionary == null)
			{
				return null;
			}
			return new AVVideoCodecSettings(nSDictionary);
		}
		set
		{
			SetNativeValue(AVVideo.CompressionPropertiesKey, value?.Dictionary);
		}
	}

	public AVVideoSettingsCompressed()
		: base(new NSMutableDictionary())
	{
	}

	public AVVideoSettingsCompressed(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
