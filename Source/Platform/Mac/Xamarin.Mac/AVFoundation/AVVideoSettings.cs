using CoreVideo;
using Foundation;

namespace AVFoundation;

public class AVVideoSettings
{
	[Advice("Use PixelBufferAttributes")]
	public CVPixelFormatType? PixelFormat { get; set; }

	public AVVideoSettings()
	{
	}

	[Advice("Use PixelBufferAttributes")]
	public AVVideoSettings(CVPixelFormatType formatType)
	{
		PixelFormat = formatType;
	}

	[Advice("Use PixelBufferAttributes")]
	public NSDictionary ToDictionary()
	{
		if (!PixelFormat.HasValue)
		{
			return null;
		}
		return NSDictionary.FromObjectAndKey(new NSNumber((int)PixelFormat.Value), CVPixelBuffer.PixelFormatTypeKey);
	}
}
