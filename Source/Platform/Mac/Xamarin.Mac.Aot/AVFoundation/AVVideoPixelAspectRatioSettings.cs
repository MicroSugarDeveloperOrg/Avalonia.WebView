using Foundation;

namespace AVFoundation;

public class AVVideoPixelAspectRatioSettings : DictionaryContainer
{
	public int? HorizontalSpacing
	{
		get
		{
			return GetInt32Value(AVVideo.PixelAspectRatioHorizontalSpacingKey);
		}
		set
		{
			SetNumberValue(AVVideo.PixelAspectRatioHorizontalSpacingKey, value);
		}
	}

	public int? VerticalSpacing
	{
		get
		{
			return GetInt32Value(AVVideo.PixelAspectRatioVerticalSpacingKey);
		}
		set
		{
			SetNumberValue(AVVideo.PixelAspectRatioVerticalSpacingKey, value);
		}
	}

	public AVVideoPixelAspectRatioSettings()
		: base(new NSMutableDictionary())
	{
	}

	public AVVideoPixelAspectRatioSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
