using System;
using CoreVideo;
using Foundation;

namespace AVFoundation;

public class AVVideoSettingsUncompressed : CVPixelBufferAttributes
{
	public AVVideoScalingMode? ScalingMode
	{
		get
		{
			return ScalingModeFromNSString(GetNSStringValue(AVVideo.ScalingModeKey));
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

	public AVVideoSettingsUncompressed()
	{
	}

	public AVVideoSettingsUncompressed(NSDictionary dictionary)
		: base(dictionary)
	{
	}

	internal static AVVideoScalingMode? ScalingModeFromNSString(NSString k)
	{
		if (k == null)
		{
			return null;
		}
		if (k == AVVideoScalingModeKey.Fit)
		{
			return AVVideoScalingMode.Fit;
		}
		if (k == AVVideoScalingModeKey.Resize)
		{
			return AVVideoScalingMode.Resize;
		}
		if (k == AVVideoScalingModeKey.ResizeAspect)
		{
			return AVVideoScalingMode.ResizeAspect;
		}
		if (k == AVVideoScalingModeKey.ResizeAspectFill)
		{
			return AVVideoScalingMode.ResizeAspectFill;
		}
		return null;
	}
}
