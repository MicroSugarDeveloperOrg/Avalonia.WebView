using Foundation;

namespace AVFoundation;

public class AVVideoCleanApertureSettings : DictionaryContainer
{
	public int? Width
	{
		get
		{
			return GetInt32Value(AVVideo.CleanApertureWidthKey);
		}
		set
		{
			SetNumberValue(AVVideo.CleanApertureWidthKey, value);
		}
	}

	public int? Height
	{
		get
		{
			return GetInt32Value(AVVideo.CleanApertureHeightKey);
		}
		set
		{
			SetNumberValue(AVVideo.CleanApertureHeightKey, value);
		}
	}

	public int? HorizontalOffset
	{
		get
		{
			return GetInt32Value(AVVideo.CleanApertureHorizontalOffsetKey);
		}
		set
		{
			SetNumberValue(AVVideo.CleanApertureHorizontalOffsetKey, value);
		}
	}

	public int? VerticalOffset
	{
		get
		{
			return GetInt32Value(AVVideo.CleanApertureVerticalOffsetKey);
		}
		set
		{
			SetNumberValue(AVVideo.CleanApertureVerticalOffsetKey, value);
		}
	}

	public AVVideoCleanApertureSettings()
		: base(new NSMutableDictionary())
	{
	}

	public AVVideoCleanApertureSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
