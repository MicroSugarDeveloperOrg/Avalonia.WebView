using CoreImage;
using Foundation;
using ImageIO;

namespace CoreGraphics;

public class CGImagePropertiesTiff : DictionaryContainer
{
	public CIImageOrientation? Orientation
	{
		get
		{
			return (CIImageOrientation?)GetInt32Value(ImageIO.CGImageProperties.TIFFOrientation);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.TIFFOrientation, (int?)value);
		}
	}

	public int? XResolution
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.TIFFXResolution);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.TIFFXResolution, value);
		}
	}

	public int? YResolution
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.TIFFYResolution);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.TIFFYResolution, value);
		}
	}

	public string Software
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.TIFFSoftware);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.TIFFSoftware, value);
		}
	}

	public CGImagePropertiesTiff()
		: base(new NSMutableDictionary())
	{
	}

	public CGImagePropertiesTiff(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
