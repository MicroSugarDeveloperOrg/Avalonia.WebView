using System;
using CoreVideo;
using Foundation;

namespace AVFoundation;

public class AVVideoSettingsUncompressed : CVPixelBufferAttributes
{
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

	public AVVideoSettingsUncompressed()
	{
	}

	public AVVideoSettingsUncompressed(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
