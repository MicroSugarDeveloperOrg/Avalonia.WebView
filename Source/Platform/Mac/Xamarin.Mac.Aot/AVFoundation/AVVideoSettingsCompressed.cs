using System;
using Foundation;

namespace AVFoundation;

public class AVVideoSettingsCompressed : DictionaryContainer
{
	public AVVideoCodec? Codec
	{
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

	public AVVideoScalingMode? ScalingMode
	{
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
