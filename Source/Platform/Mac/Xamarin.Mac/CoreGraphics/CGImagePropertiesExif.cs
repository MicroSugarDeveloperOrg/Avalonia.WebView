using System;
using Foundation;
using ImageIO;

namespace CoreGraphics;

public class CGImagePropertiesExif : DictionaryContainer
{
	public float? Aperture
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifApertureValue);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifApertureValue, value);
		}
	}

	public float? Brightness
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifBrightnessValue);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifBrightnessValue, value);
		}
	}

	public float? CompressedBitsPerPixel
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifCompressedBitsPerPixel);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifCompressedBitsPerPixel, value);
		}
	}

	public float? DigitalZoomRatio
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifDigitalZoomRatio);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifDigitalZoomRatio, value);
		}
	}

	public float? ExposureBias
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifExposureBiasValue);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifExposureBiasValue, value);
		}
	}

	public float? ExposureIndex
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifExposureIndex);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifExposureIndex, value);
		}
	}

	public float? ExposureTime
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifExposureTime);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifExposureTime, value);
		}
	}

	public int? ExposureProgram
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.ExifExposureProgram);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifExposureProgram, value);
		}
	}

	public bool? Flash
	{
		get
		{
			return GetBoolValue(ImageIO.CGImageProperties.ExifFlash);
		}
		set
		{
			SetBooleanValue(ImageIO.CGImageProperties.ExifFlash, value);
		}
	}

	public float? FlashEnergy
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifFlashEnergy);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifFlashEnergy, value);
		}
	}

	public float? FocalPlaneXResolution
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifFocalPlaneXResolution);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifFocalPlaneXResolution, value);
		}
	}

	public float? FocalPlaneYResolution
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifFocalPlaneYResolution);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifFocalPlaneYResolution, value);
		}
	}

	public float? GainControl
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifGainControl);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifGainControl, value);
		}
	}

	public int[] ISOSpeedRatings => GetArray(ImageIO.CGImageProperties.ExifISOSpeedRatings, (IntPtr l) => new NSNumber(l).Int32Value);

	public float? MaximumLensAperture
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifMaxApertureValue);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifMaxApertureValue, value);
		}
	}

	public int? PixelXDimension
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.ExifPixelXDimension);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifPixelXDimension, value);
		}
	}

	public int? PixelYDimension
	{
		get
		{
			return GetInt32Value(ImageIO.CGImageProperties.ExifPixelYDimension);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifPixelYDimension, value);
		}
	}

	public float? SubjectDistance
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifSubjectDistance);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifSubjectDistance, value);
		}
	}

	public float? ShutterSpeed
	{
		get
		{
			return GetFloatValue(ImageIO.CGImageProperties.ExifShutterSpeedValue);
		}
		set
		{
			SetNumberValue(ImageIO.CGImageProperties.ExifShutterSpeedValue, value);
		}
	}

	public CGImagePropertiesExif()
		: base(new NSMutableDictionary())
	{
	}

	public CGImagePropertiesExif(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
