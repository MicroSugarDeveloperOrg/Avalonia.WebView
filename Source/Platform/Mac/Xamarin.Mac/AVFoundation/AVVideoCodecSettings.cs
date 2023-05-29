using System;
using Foundation;

namespace AVFoundation;

public class AVVideoCodecSettings : DictionaryContainer
{
	public int? AverageBitRate
	{
		get
		{
			return GetInt32Value(AVVideo.AverageBitRateKey);
		}
		set
		{
			SetNumberValue(AVVideo.AverageBitRateKey, value);
		}
	}

	public float? JPEGQuality
	{
		get
		{
			return GetFloatValue(AVVideo.QualityKey);
		}
		set
		{
			SetNumberValue(AVVideo.QualityKey, value);
		}
	}

	public int? MaxKeyFrameInterval
	{
		get
		{
			return GetInt32Value(AVVideo.MaxKeyFrameIntervalKey);
		}
		set
		{
			SetNumberValue(AVVideo.MaxKeyFrameIntervalKey, value);
		}
	}

	public AVVideoProfileLevelH264? ProfileLevelH264
	{
		set
		{
			NSString nSString = value switch
			{
				AVVideoProfileLevelH264.Baseline30 => AVVideo.ProfileLevelH264Baseline30, 
				AVVideoProfileLevelH264.Baseline31 => AVVideo.ProfileLevelH264Baseline31, 
				AVVideoProfileLevelH264.Baseline41 => AVVideo.ProfileLevelH264Baseline41, 
				AVVideoProfileLevelH264.Main30 => AVVideo.ProfileLevelH264Main30, 
				AVVideoProfileLevelH264.Main31 => AVVideo.ProfileLevelH264Main31, 
				AVVideoProfileLevelH264.Main32 => AVVideo.ProfileLevelH264Main32, 
				AVVideoProfileLevelH264.Main41 => AVVideo.ProfileLevelH264Main41, 
				null => null, 
				_ => throw new ArgumentException("value"), 
			};
			if (nSString == null)
			{
				RemoveValue(AVVideo.ProfileLevelKey);
			}
			else
			{
				SetNativeValue(AVVideo.ProfileLevelKey, nSString);
			}
		}
	}

	public AVVideoPixelAspectRatioSettings PixelAspectRatio
	{
		set
		{
			SetNativeValue(AVVideo.PixelAspectRatioKey, value?.Dictionary);
		}
	}

	public AVVideoCleanApertureSettings VideoCleanAperture
	{
		set
		{
			SetNativeValue(AVVideo.CleanApertureKey, value?.Dictionary);
		}
	}

	public AVVideoCodecSettings()
		: base(new NSMutableDictionary())
	{
	}

	public AVVideoCodecSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
