using Foundation;
using ImageIO;

namespace CoreGraphics;

public class CGImagePropertiesIptc : DictionaryContainer
{
	public string Byline
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCByline);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCByline, value);
		}
	}

	public string BylineTitle
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCBylineTitle);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCBylineTitle, value);
		}
	}

	public string CaptionAbstract
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCCaptionAbstract);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCCaptionAbstract, value);
		}
	}

	public string City
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCCity);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCCity, value);
		}
	}

	public string ContentLocationName
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCContentLocationName);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCContentLocationName, value);
		}
	}

	public string CountryPrimaryLocationName
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCCountryPrimaryLocationName);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCCountryPrimaryLocationName, value);
		}
	}

	public string CopyrightNotice
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCCopyrightNotice);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCCopyrightNotice, value);
		}
	}

	public string Credit
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCCredit);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCCredit, value);
		}
	}

	public string Source
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCSource);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCSource, value);
		}
	}

	public string WriterEditor
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.IPTCWriterEditor);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.IPTCWriterEditor, value);
		}
	}

	public CGImagePropertiesIptc()
		: base(new NSMutableDictionary())
	{
	}

	public CGImagePropertiesIptc(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
