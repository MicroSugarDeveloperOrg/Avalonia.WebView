using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageDestinationOptions : DictionaryContainer
{
	private CGColor destinationBackgroundColor;

	public CGColor DestinationBackgroundColor
	{
		get
		{
			return destinationBackgroundColor;
		}
		set
		{
			destinationBackgroundColor = value;
			(base.Dictionary as NSMutableDictionary).LowlevelSetObject(destinationBackgroundColor.Handle, CGImageDestinationOptionsKeys.BackgroundColor.Handle);
		}
	}

	public float? LossyCompressionQuality
	{
		get
		{
			return GetFloatValue(CGImageDestinationOptionsKeys.LossyCompressionQuality);
		}
		set
		{
			SetNumberValue(CGImageDestinationOptionsKeys.LossyCompressionQuality, value);
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public int? ImageMaxPixelSize
	{
		get
		{
			return GetInt32Value(CGImageDestinationOptionsKeys.ImageMaxPixelSize);
		}
		set
		{
			SetNumberValue(CGImageDestinationOptionsKeys.ImageMaxPixelSize, value);
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool? EmbedThumbnail
	{
		get
		{
			return GetBoolValue(CGImageDestinationOptionsKeys.EmbedThumbnail);
		}
		set
		{
			SetBooleanValue(CGImageDestinationOptionsKeys.EmbedThumbnail, value);
		}
	}

	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 2, 3, PlatformArchitecture.All, null)]
	public bool? OptimizeColorForSharing
	{
		get
		{
			return GetBoolValue(CGImageDestinationOptionsKeys.OptimizeColorForSharing);
		}
		set
		{
			SetBooleanValue(CGImageDestinationOptionsKeys.OptimizeColorForSharing, value);
		}
	}

	public CGImagePropertiesTiff? TiffDictionary
	{
		get
		{
			return GetStrongDictionary<CGImagePropertiesTiff>(CGImageDestinationOptionsKeys.TIFFDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.TIFFDictionary, value.GetDictionary());
		}
	}

	public NSDictionary? GifDictionary
	{
		get
		{
			return GetNSDictionary(CGImageDestinationOptionsKeys.GIFDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.GIFDictionary, value);
		}
	}

	public CGImagePropertiesJfif? JfifDictionary
	{
		get
		{
			return GetStrongDictionary<CGImagePropertiesJfif>(CGImageDestinationOptionsKeys.JFIFDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.JFIFDictionary, value.GetDictionary());
		}
	}

	public CGImagePropertiesExif? ExifDictionary
	{
		get
		{
			return GetStrongDictionary<CGImagePropertiesExif>(CGImageDestinationOptionsKeys.ExifDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.ExifDictionary, value.GetDictionary());
		}
	}

	public CGImagePropertiesPng? PngDictionary
	{
		get
		{
			return GetStrongDictionary<CGImagePropertiesPng>(CGImageDestinationOptionsKeys.PNGDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.PNGDictionary, value.GetDictionary());
		}
	}

	public CGImagePropertiesIptc? IptcDictionary
	{
		get
		{
			return GetStrongDictionary<CGImagePropertiesIptc>(CGImageDestinationOptionsKeys.IPTCDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.IPTCDictionary, value.GetDictionary());
		}
	}

	public CGImagePropertiesGps? GpsDictionary
	{
		get
		{
			return GetStrongDictionary<CGImagePropertiesGps>(CGImageDestinationOptionsKeys.GPSDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.GPSDictionary, value.GetDictionary());
		}
	}

	public NSDictionary? RawDictionary
	{
		get
		{
			return GetNSDictionary(CGImageDestinationOptionsKeys.RawDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.RawDictionary, value);
		}
	}

	public NSDictionary? CiffDictionary
	{
		get
		{
			return GetNSDictionary(CGImageDestinationOptionsKeys.CIFFDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.CIFFDictionary, value);
		}
	}

	public NSDictionary? EightBimDictionary
	{
		get
		{
			return GetNSDictionary(CGImageDestinationOptionsKeys.EightBIMDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.EightBIMDictionary, value);
		}
	}

	public NSDictionary? DngDictionary
	{
		get
		{
			return GetNSDictionary(CGImageDestinationOptionsKeys.DNGDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.DNGDictionary, value);
		}
	}

	public NSDictionary? ExifAuxDictionary
	{
		get
		{
			return GetNSDictionary(CGImageDestinationOptionsKeys.ExifAuxDictionary);
		}
		set
		{
			SetNativeValue(CGImageDestinationOptionsKeys.ExifAuxDictionary, value);
		}
	}

	internal NSMutableDictionary ToDictionary()
	{
		return (NSMutableDictionary)base.Dictionary;
	}

	[Preserve(Conditional = true)]
	public CGImageDestinationOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CGImageDestinationOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
