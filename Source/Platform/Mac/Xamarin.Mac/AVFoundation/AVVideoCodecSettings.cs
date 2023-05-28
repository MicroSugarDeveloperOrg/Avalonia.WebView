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
		get
		{
			NSString nSStringValue = GetNSStringValue(AVVideo.ProfileLevelKey);
			if (nSStringValue == AVVideo.ProfileLevelH264Baseline30)
			{
				return AVVideoProfileLevelH264.Baseline30;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264Baseline31)
			{
				return AVVideoProfileLevelH264.Baseline31;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264Baseline41)
			{
				return AVVideoProfileLevelH264.Baseline41;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264Main30)
			{
				return AVVideoProfileLevelH264.Main30;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264Main31)
			{
				return AVVideoProfileLevelH264.Main31;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264Main32)
			{
				return AVVideoProfileLevelH264.Main32;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264Main41)
			{
				return AVVideoProfileLevelH264.Main41;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264High40)
			{
				return AVVideoProfileLevelH264.High40;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264High41)
			{
				return AVVideoProfileLevelH264.High41;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264BaselineAutoLevel)
			{
				return AVVideoProfileLevelH264.BaselineAutoLevel;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264MainAutoLevel)
			{
				return AVVideoProfileLevelH264.MainAutoLevel;
			}
			if (nSStringValue == AVVideo.ProfileLevelH264HighAutoLevel)
			{
				return AVVideoProfileLevelH264.HighAutoLevel;
			}
			return null;
		}
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
				AVVideoProfileLevelH264.High40 => AVVideo.ProfileLevelH264High40, 
				AVVideoProfileLevelH264.High41 => AVVideo.ProfileLevelH264High41, 
				AVVideoProfileLevelH264.BaselineAutoLevel => AVVideo.ProfileLevelH264BaselineAutoLevel, 
				AVVideoProfileLevelH264.MainAutoLevel => AVVideo.ProfileLevelH264MainAutoLevel, 
				AVVideoProfileLevelH264.HighAutoLevel => AVVideo.ProfileLevelH264HighAutoLevel, 
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
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(AVVideo.PixelAspectRatioKey);
			if (nSDictionary == null)
			{
				return null;
			}
			return new AVVideoPixelAspectRatioSettings(nSDictionary);
		}
		set
		{
			SetNativeValue(AVVideo.PixelAspectRatioKey, value?.Dictionary);
		}
	}

	public AVVideoCleanApertureSettings VideoCleanAperture
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(AVVideo.CleanApertureKey);
			if (nSDictionary == null)
			{
				return null;
			}
			return new AVVideoCleanApertureSettings(nSDictionary);
		}
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
