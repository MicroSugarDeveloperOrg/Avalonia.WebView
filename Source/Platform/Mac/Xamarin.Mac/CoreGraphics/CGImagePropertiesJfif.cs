using Foundation;
using ImageIO;

namespace CoreGraphics;

public class CGImagePropertiesJfif : DictionaryContainer
{
	public int? XDensity
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.JFIFXDensity);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.JFIFXDensity, value);
		}
	}

	public int? YDensity
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.JFIFYDensity);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.JFIFYDensity, value);
		}
	}

	public CGImagePropertiesJfif()
		: base(new NSMutableDictionary())
	{
	}

	public CGImagePropertiesJfif(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
