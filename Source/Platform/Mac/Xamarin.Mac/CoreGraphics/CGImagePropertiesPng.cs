using Foundation;
using ImageIO;

namespace CoreGraphics;

public class CGImagePropertiesPng : DictionaryContainer
{
	public string Author
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.PNGAuthor);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.PNGAuthor, value);
		}
	}

	public string Description
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.PNGDescription);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.PNGDescription, value);
		}
	}

	public float? Gamma
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.PNGGamma);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.PNGGamma, value);
		}
	}

	public string Software
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.PNGSoftware);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.PNGSoftware, value);
		}
	}

	public int? XPixelsPerMeter
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.PNGXPixelsPerMeter);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.PNGXPixelsPerMeter, value);
		}
	}

	public int? YPixelsPerMeter
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.PNGYPixelsPerMeter);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.PNGYPixelsPerMeter, value);
		}
	}

	public string Title
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.PNGTitle);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.PNGTitle, value);
		}
	}

	public CGImagePropertiesPng()
		: base(new NSMutableDictionary())
	{
	}

	public CGImagePropertiesPng(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
