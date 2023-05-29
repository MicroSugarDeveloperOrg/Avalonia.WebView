using System;
using CoreImage;
using Foundation;
using ImageIO;

namespace CoreGraphics;

public class CGImageProperties : DictionaryContainer
{
	public bool? Alpha
	{
		get
		{
			return GetBoolValue(ImageIO.CGImageProperties.HasAlpha);
		}
		set
		{
			SetBooleanValue(ImageIO.CGImageProperties.HasAlpha, value);
		}
	}

	public CGImageColorModel? ColorModel
	{
		get
		{
			string nSStringValue = GetNSStringValue(ImageIO.CGImageProperties.ColorModel);
			if (nSStringValue == ImageIO.CGImageProperties.ColorModelRGB)
			{
				return CGImageColorModel.RGB;
			}
			if (nSStringValue == ImageIO.CGImageProperties.ColorModelGray)
			{
				return CGImageColorModel.Gray;
			}
			if (nSStringValue == ImageIO.CGImageProperties.ColorModelCMYK)
			{
				return CGImageColorModel.CMYK;
			}
			if (nSStringValue == ImageIO.CGImageProperties.ColorModelLab)
			{
				return CGImageColorModel.Lab;
			}
			return null;
		}
		set
		{
			SetNativeValue(value: value switch
			{
				CGImageColorModel.RGB => ImageIO.CGImageProperties.ColorModelRGB, 
				CGImageColorModel.Gray => ImageIO.CGImageProperties.ColorModelGray, 
				CGImageColorModel.CMYK => ImageIO.CGImageProperties.ColorModelCMYK, 
				CGImageColorModel.Lab => ImageIO.CGImageProperties.ColorModelLab, 
				_ => throw new ArgumentOutOfRangeException("value"), 
			}, key: ImageIO.CGImageProperties.ColorModel);
		}
	}

	public int? Depth
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.Depth);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.Depth, value);
		}
	}

	[Obsolete("Use the DPIHeightF property")]
	public int? DPIHeight
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.DPIHeight);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.DPIHeight, value);
		}
	}

	[Obsolete("Use the DPIWidthF property")]
	public int? DPIWidth
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.DPIWidth);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.DPIWidth, value);
		}
	}

	public float? DPIHeightF
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.DPIHeight);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.DPIHeight, value);
		}
	}

	public float? DPIWidthF
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.DPIWidth);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.DPIWidth, value);
		}
	}

	public int? FileSize
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.FileSize);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.FileSize, value);
		}
	}

	public bool? IsFloat
	{
		get
		{
			return GetBoolValue(ImageIO.CGImageProperties.IsFloat);
		}
		set
		{
			SetBooleanValue(ImageIO.CGImageProperties.IsFloat, value);
		}
	}

	public bool? IsIndexed
	{
		get
		{
			return GetBoolValue(ImageIO.CGImageProperties.IsIndexed);
		}
		set
		{
			SetBooleanValue(ImageIO.CGImageProperties.IsIndexed, value);
		}
	}

	public CIImageOrientation? Orientation
	{
		get
		{
			return (CIImageOrientation?)GetInt32Value(ImageIO.CGImageProperties.Orientation);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.Orientation, (int?)value);
		}
	}

	public int? PixelHeight
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.PixelHeight);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.PixelHeight, value);
		}
	}

	public int? PixelWidth
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.PixelWidth);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.PixelWidth, value);
		}
	}

	public string ProfileName
	{
		get
		{
			return GetStringValue(ImageIO.CGImageProperties.ProfileName);
		}
		set
		{
			SetStringValue(ImageIO.CGImageProperties.ProfileName, value);
		}
	}

	public CGImagePropertiesExif Exif
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(ImageIO.CGImageProperties.ExifDictionary);
			if (nSDictionary != null)
			{
				return new CGImagePropertiesExif(nSDictionary);
			}
			return null;
		}
	}

	public CGImagePropertiesGps Gps
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(ImageIO.CGImageProperties.GPSDictionary);
			if (nSDictionary != null)
			{
				return new CGImagePropertiesGps(nSDictionary);
			}
			return null;
		}
	}

	public CGImagePropertiesIptc Iptc
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(ImageIO.CGImageProperties.IPTCDictionary);
			if (nSDictionary != null)
			{
				return new CGImagePropertiesIptc(nSDictionary);
			}
			return null;
		}
	}

	public CGImagePropertiesPng Png
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(ImageIO.CGImageProperties.PNGDictionary);
			if (nSDictionary != null)
			{
				return new CGImagePropertiesPng(nSDictionary);
			}
			return null;
		}
	}

	public CGImagePropertiesJfif Jfif
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(ImageIO.CGImageProperties.JFIFDictionary);
			if (nSDictionary != null)
			{
				return new CGImagePropertiesJfif(nSDictionary);
			}
			return null;
		}
	}

	public CGImagePropertiesTiff Tiff
	{
		get
		{
			NSDictionary nSDictionary = GetNSDictionary(ImageIO.CGImageProperties.TIFFDictionary);
			if (nSDictionary != null)
			{
				return new CGImagePropertiesTiff(nSDictionary);
			}
			return null;
		}
	}

	public CGImageProperties()
		: base(new NSMutableDictionary())
	{
	}

	public CGImageProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
