using Foundation;
using ImageIO;

namespace CoreGraphics;

public class CGImagePropertiesGps : DictionaryContainer
{
	public int? Altitude
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.GPSAltitude);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.GPSAltitude, value);
		}
	}

	public float? Latitude
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.GPSLatitude);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.GPSLatitude, value);
		}
	}

	public float? Longitude
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.GPSLongitude);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.GPSLongitude, value);
		}
	}

	public CGImagePropertiesGps()
		: base(new NSMutableDictionary())
	{
	}

	public CGImagePropertiesGps(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
