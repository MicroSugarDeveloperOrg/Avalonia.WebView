using Foundation;
using ObjCRuntime;

namespace ImageIO;

public static class CGImageProperties
{
	private static NSString _TIFFDictionary;

	private static NSString _GIFDictionary;

	private static NSString _JFIFDictionary;

	private static NSString _ExifDictionary;

	private static NSString _PNGDictionary;

	private static NSString _IPTCDictionary;

	private static NSString _GPSDictionary;

	private static NSString _RawDictionary;

	private static NSString _CIFFDictionary;

	private static NSString _EightBIMDictionary;

	private static NSString _DNGDictionary;

	private static NSString _ExifAuxDictionary;

	private static NSString _MakerCanonDictionary;

	private static NSString _MakerNikonDictionary;

	private static NSString _MakerMinoltaDictionary;

	private static NSString _MakerFujiDictionary;

	private static NSString _MakerOlympusDictionary;

	private static NSString _MakerPentaxDictionary;

	private static NSString _FileSize;

	private static NSString _DPIHeight;

	private static NSString _DPIWidth;

	private static NSString _PixelWidth;

	private static NSString _PixelHeight;

	private static NSString _Depth;

	private static NSString _Orientation;

	private static NSString _IsFloat;

	private static NSString _IsIndexed;

	private static NSString _HasAlpha;

	private static NSString _ColorModel;

	private static NSString _ProfileName;

	private static NSString _ColorModelRGB;

	private static NSString _ColorModelGray;

	private static NSString _ColorModelCMYK;

	private static NSString _ColorModelLab;

	private static NSString _ExifExposureTime;

	private static NSString _ExifFNumber;

	private static NSString _ExifExposureProgram;

	private static NSString _ExifSpectralSensitivity;

	private static NSString _ExifISOSpeedRatings;

	private static NSString _ExifOECF;

	private static NSString _ExifVersion;

	private static NSString _ExifDateTimeOriginal;

	private static NSString _ExifDateTimeDigitized;

	private static NSString _ExifComponentsConfiguration;

	private static NSString _ExifCompressedBitsPerPixel;

	private static NSString _ExifShutterSpeedValue;

	private static NSString _ExifApertureValue;

	private static NSString _ExifBrightnessValue;

	private static NSString _ExifExposureBiasValue;

	private static NSString _ExifMaxApertureValue;

	private static NSString _ExifSubjectDistance;

	private static NSString _ExifMeteringMode;

	private static NSString _ExifLightSource;

	private static NSString _ExifFlash;

	private static NSString _ExifFocalLength;

	private static NSString _ExifSubjectArea;

	private static NSString _ExifMakerNote;

	private static NSString _ExifUserComment;

	private static NSString _ExifSubsecTime;

	private static NSString _ExifSubsecTimeOrginal;

	private static NSString _ExifSubsecTimeDigitized;

	private static NSString _ExifFlashPixVersion;

	private static NSString _ExifColorSpace;

	private static NSString _ExifPixelXDimension;

	private static NSString _ExifPixelYDimension;

	private static NSString _ExifRelatedSoundFile;

	private static NSString _ExifFlashEnergy;

	private static NSString _ExifSpatialFrequencyResponse;

	private static NSString _ExifFocalPlaneXResolution;

	private static NSString _ExifFocalPlaneYResolution;

	private static NSString _ExifFocalPlaneResolutionUnit;

	private static NSString _ExifSubjectLocation;

	private static NSString _ExifExposureIndex;

	private static NSString _ExifSensingMethod;

	private static NSString _ExifFileSource;

	private static NSString _ExifSceneType;

	private static NSString _ExifCFAPattern;

	private static NSString _ExifCustomRendered;

	private static NSString _ExifExposureMode;

	private static NSString _ExifWhiteBalance;

	private static NSString _ExifDigitalZoomRatio;

	private static NSString _ExifFocalLenIn35mmFilm;

	private static NSString _ExifSceneCaptureType;

	private static NSString _ExifGainControl;

	private static NSString _ExifContrast;

	private static NSString _ExifSaturation;

	private static NSString _ExifSharpness;

	private static NSString _ExifDeviceSettingDescription;

	private static NSString _ExifSubjectDistRange;

	private static NSString _ExifImageUniqueID;

	private static NSString _ExifGamma;

	private static NSString _ExifCameraOwnerName;

	private static NSString _ExifBodySerialNumber;

	private static NSString _ExifLensSpecification;

	private static NSString _ExifLensMake;

	private static NSString _ExifLensModel;

	private static NSString _ExifLensSerialNumber;

	private static NSString _ExifAuxLensInfo;

	private static NSString _ExifAuxLensModel;

	private static NSString _ExifAuxSerialNumber;

	private static NSString _ExifAuxLensID;

	private static NSString _ExifAuxLensSerialNumber;

	private static NSString _ExifAuxImageNumber;

	private static NSString _ExifAuxFlashCompensation;

	private static NSString _ExifAuxOwnerName;

	private static NSString _ExifAuxFirmware;

	private static NSString _GIFLoopCount;

	private static NSString _GIFDelayTime;

	private static NSString _GIFImageColorMap;

	private static NSString _GIFHasGlobalColorMap;

	private static NSString _GIFUnclampedDelayTime;

	private static NSString _GPSVersion;

	private static NSString _GPSLatitudeRef;

	private static NSString _GPSLatitude;

	private static NSString _GPSLongitudeRef;

	private static NSString _GPSLongitude;

	private static NSString _GPSAltitudeRef;

	private static NSString _GPSAltitude;

	private static NSString _GPSTimeStamp;

	private static NSString _GPSSatellites;

	private static NSString _GPSStatus;

	private static NSString _GPSMeasureMode;

	private static NSString _GPSDOP;

	private static NSString _GPSSpeedRef;

	private static NSString _GPSSpeed;

	private static NSString _GPSTrackRef;

	private static NSString _GPSTrack;

	private static NSString _GPSImgDirectionRef;

	private static NSString _GPSImgDirection;

	private static NSString _GPSMapDatum;

	private static NSString _GPSDestLatitudeRef;

	private static NSString _GPSDestLatitude;

	private static NSString _GPSDestLongitudeRef;

	private static NSString _GPSDestLongitude;

	private static NSString _GPSDestBearingRef;

	private static NSString _GPSDestBearing;

	private static NSString _GPSDestDistanceRef;

	private static NSString _GPSDestDistance;

	private static NSString _GPSAreaInformation;

	private static NSString _GPSDateStamp;

	private static NSString _GPSDifferental;

	private static NSString _IPTCObjectTypeReference;

	private static NSString _IPTCObjectAttributeReference;

	private static NSString _IPTCObjectName;

	private static NSString _IPTCEditStatus;

	private static NSString _IPTCEditorialUpdate;

	private static NSString _IPTCUrgency;

	private static NSString _IPTCSubjectReference;

	private static NSString _IPTCCategory;

	private static NSString _IPTCSupplementalCategory;

	private static NSString _IPTCFixtureIdentifier;

	private static NSString _IPTCKeywords;

	private static NSString _IPTCContentLocationCode;

	private static NSString _IPTCContentLocationName;

	private static NSString _IPTCReleaseDate;

	private static NSString _IPTCReleaseTime;

	private static NSString _IPTCExpirationDate;

	private static NSString _IPTCExpirationTime;

	private static NSString _IPTCSpecialInstructions;

	private static NSString _IPTCActionAdvised;

	private static NSString _IPTCReferenceService;

	private static NSString _IPTCReferenceDate;

	private static NSString _IPTCReferenceNumber;

	private static NSString _IPTCDateCreated;

	private static NSString _IPTCTimeCreated;

	private static NSString _IPTCDigitalCreationDate;

	private static NSString _IPTCDigitalCreationTime;

	private static NSString _IPTCOriginatingProgram;

	private static NSString _IPTCProgramVersion;

	private static NSString _IPTCObjectCycle;

	private static NSString _IPTCByline;

	private static NSString _IPTCBylineTitle;

	private static NSString _IPTCCity;

	private static NSString _IPTCSubLocation;

	private static NSString _IPTCProvinceState;

	private static NSString _IPTCCountryPrimaryLocationCode;

	private static NSString _IPTCCountryPrimaryLocationName;

	private static NSString _IPTCOriginalTransmissionReference;

	private static NSString _IPTCHeadline;

	private static NSString _IPTCCredit;

	private static NSString _IPTCSource;

	private static NSString _IPTCCopyrightNotice;

	private static NSString _IPTCContact;

	private static NSString _IPTCCaptionAbstract;

	private static NSString _IPTCWriterEditor;

	private static NSString _IPTCImageType;

	private static NSString _IPTCImageOrientation;

	private static NSString _IPTCLanguageIdentifier;

	private static NSString _IPTCStarRating;

	private static NSString _IPTCCreatorContactInfo;

	private static NSString _IPTCRightsUsageTerms;

	private static NSString _IPTCScene;

	private static NSString _IPTCContactInfoCity;

	private static NSString _IPTCContactInfoCountry;

	private static NSString _IPTCContactInfoAddress;

	private static NSString _IPTCContactInfoPostalCode;

	private static NSString _IPTCContactInfoStateProvince;

	private static NSString _IPTCContactInfoEmails;

	private static NSString _IPTCContactInfoPhones;

	private static NSString _IPTCContactInfoWebURLs;

	private static NSString _JFIFVersion;

	private static NSString _JFIFXDensity;

	private static NSString _JFIFYDensity;

	private static NSString _JFIFDensityUnit;

	private static NSString _JFIFIsProgressive;

	private static NSString _PNGGamma;

	private static NSString _PNGInterlaceType;

	private static NSString _PNGXPixelsPerMeter;

	private static NSString _PNGYPixelsPerMeter;

	private static NSString _PNGsRGBIntent;

	private static NSString _PNGChromaticities;

	private static NSString _PNGAuthor;

	private static NSString _PNGCopyright;

	private static NSString _PNGCreationTime;

	private static NSString _PNGDescription;

	private static NSString _PNGModificationTime;

	private static NSString _PNGSoftware;

	private static NSString _PNGTitle;

	private static NSString _TIFFCompression;

	private static NSString _TIFFPhotometricInterpretation;

	private static NSString _TIFFDocumentName;

	private static NSString _TIFFImageDescription;

	private static NSString _TIFFMake;

	private static NSString _TIFFModel;

	private static NSString _TIFFOrientation;

	private static NSString _TIFFXResolution;

	private static NSString _TIFFYResolution;

	private static NSString _TIFFResolutionUnit;

	private static NSString _TIFFSoftware;

	private static NSString _TIFFTransferFunction;

	private static NSString _TIFFDateTime;

	private static NSString _TIFFArtist;

	private static NSString _TIFFHostComputer;

	private static NSString _TIFFWhitePoint;

	private static NSString _TIFFPrimaryChromaticities;

	private static NSString _DNGVersion;

	private static NSString _DNGBackwardVersion;

	private static NSString _DNGUniqueCameraModel;

	private static NSString _DNGLocalizedCameraModel;

	private static NSString _DNGCameraSerialNumber;

	private static NSString _DNGLensInfo;

	private static NSString _EightBIMLayerNames;

	private static NSString _CIFFDescription;

	private static NSString _CIFFFirmware;

	private static NSString _CIFFOwnerName;

	private static NSString _CIFFImageName;

	private static NSString _CIFFImageFileName;

	private static NSString _CIFFReleaseMethod;

	private static NSString _CIFFReleaseTiming;

	private static NSString _CIFFRecordID;

	private static NSString _CIFFSelfTimingTime;

	private static NSString _CIFFCameraSerialNumber;

	private static NSString _CIFFImageSerialNumber;

	private static NSString _CIFFContinuousDrive;

	private static NSString _CIFFFocusMode;

	private static NSString _CIFFMeteringMode;

	private static NSString _CIFFShootingMode;

	private static NSString _CIFFLensMaxMM;

	private static NSString _CIFFLensMinMM;

	private static NSString _CIFFLensModel;

	private static NSString _CIFFWhiteBalanceIndex;

	private static NSString _CIFFFlashExposureComp;

	private static NSString _CIFFMeasuredEV;

	private static NSString _MakerNikonISOSetting;

	private static NSString _MakerNikonColorMode;

	private static NSString _MakerNikonQuality;

	private static NSString _MakerNikonWhiteBalanceMode;

	private static NSString _MakerNikonSharpenMode;

	private static NSString _MakerNikonFocusMode;

	private static NSString _MakerNikonFlashSetting;

	private static NSString _MakerNikonISOSelection;

	private static NSString _MakerNikonFlashExposureComp;

	private static NSString _MakerNikonImageAdjustment;

	private static NSString _MakerNikonLensAdapter;

	private static NSString _MakerNikonLensType;

	private static NSString _MakerNikonLensInfo;

	private static NSString _MakerNikonFocusDistance;

	private static NSString _MakerNikonDigitalZoom;

	private static NSString _MakerNikonShootingMode;

	private static NSString _MakerNikonShutterCount;

	private static NSString _MakerNikonCameraSerialNumber;

	private static NSString _MakerCanonOwnerName;

	private static NSString _MakerCanonCameraSerialNumber;

	private static NSString _MakerCanonImageSerialNumber;

	private static NSString _MakerCanonFlashExposureComp;

	private static NSString _MakerCanonContinuousDrive;

	private static NSString _MakerCanonLensModel;

	private static NSString _MakerCanonFirmware;

	private static NSString _MakerCanonAspectRatioInfo;

	[Field("kCGImagePropertyTIFFDictionary", "ImageIO")]
	public static NSString TIFFDictionary
	{
		get
		{
			if (_TIFFDictionary == null)
			{
				_TIFFDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFDictionary");
			}
			return _TIFFDictionary;
		}
	}

	[Field("kCGImagePropertyGIFDictionary", "ImageIO")]
	public static NSString GIFDictionary
	{
		get
		{
			if (_GIFDictionary == null)
			{
				_GIFDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFDictionary");
			}
			return _GIFDictionary;
		}
	}

	[Field("kCGImagePropertyJFIFDictionary", "ImageIO")]
	public static NSString JFIFDictionary
	{
		get
		{
			if (_JFIFDictionary == null)
			{
				_JFIFDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyJFIFDictionary");
			}
			return _JFIFDictionary;
		}
	}

	[Field("kCGImagePropertyExifDictionary", "ImageIO")]
	public static NSString ExifDictionary
	{
		get
		{
			if (_ExifDictionary == null)
			{
				_ExifDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifDictionary");
			}
			return _ExifDictionary;
		}
	}

	[Field("kCGImagePropertyPNGDictionary", "ImageIO")]
	public static NSString PNGDictionary
	{
		get
		{
			if (_PNGDictionary == null)
			{
				_PNGDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGDictionary");
			}
			return _PNGDictionary;
		}
	}

	[Field("kCGImagePropertyIPTCDictionary", "ImageIO")]
	public static NSString IPTCDictionary
	{
		get
		{
			if (_IPTCDictionary == null)
			{
				_IPTCDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDictionary");
			}
			return _IPTCDictionary;
		}
	}

	[Field("kCGImagePropertyGPSDictionary", "ImageIO")]
	public static NSString GPSDictionary
	{
		get
		{
			if (_GPSDictionary == null)
			{
				_GPSDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDictionary");
			}
			return _GPSDictionary;
		}
	}

	[Field("kCGImagePropertyRawDictionary", "ImageIO")]
	public static NSString RawDictionary
	{
		get
		{
			if (_RawDictionary == null)
			{
				_RawDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyRawDictionary");
			}
			return _RawDictionary;
		}
	}

	[Field("kCGImagePropertyCIFFDictionary", "ImageIO")]
	public static NSString CIFFDictionary
	{
		get
		{
			if (_CIFFDictionary == null)
			{
				_CIFFDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFDictionary");
			}
			return _CIFFDictionary;
		}
	}

	[Field("kCGImageProperty8BIMDictionary", "ImageIO")]
	public static NSString EightBIMDictionary
	{
		get
		{
			if (_EightBIMDictionary == null)
			{
				_EightBIMDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageProperty8BIMDictionary");
			}
			return _EightBIMDictionary;
		}
	}

	[Field("kCGImagePropertyDNGDictionary", "ImageIO")]
	public static NSString DNGDictionary
	{
		get
		{
			if (_DNGDictionary == null)
			{
				_DNGDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGDictionary");
			}
			return _DNGDictionary;
		}
	}

	[Field("kCGImagePropertyExifAuxDictionary", "ImageIO")]
	public static NSString ExifAuxDictionary
	{
		get
		{
			if (_ExifAuxDictionary == null)
			{
				_ExifAuxDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxDictionary");
			}
			return _ExifAuxDictionary;
		}
	}

	[Field("kCGImagePropertyMakerCanonDictionary", "ImageIO")]
	public static NSString MakerCanonDictionary
	{
		get
		{
			if (_MakerCanonDictionary == null)
			{
				_MakerCanonDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonDictionary");
			}
			return _MakerCanonDictionary;
		}
	}

	[Field("kCGImagePropertyMakerNikonDictionary", "ImageIO")]
	public static NSString MakerNikonDictionary
	{
		get
		{
			if (_MakerNikonDictionary == null)
			{
				_MakerNikonDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonDictionary");
			}
			return _MakerNikonDictionary;
		}
	}

	[Field("kCGImagePropertyMakerMinoltaDictionary", "ImageIO")]
	public static NSString MakerMinoltaDictionary
	{
		get
		{
			if (_MakerMinoltaDictionary == null)
			{
				_MakerMinoltaDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerMinoltaDictionary");
			}
			return _MakerMinoltaDictionary;
		}
	}

	[Field("kCGImagePropertyMakerFujiDictionary", "ImageIO")]
	public static NSString MakerFujiDictionary
	{
		get
		{
			if (_MakerFujiDictionary == null)
			{
				_MakerFujiDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerFujiDictionary");
			}
			return _MakerFujiDictionary;
		}
	}

	[Field("kCGImagePropertyMakerOlympusDictionary", "ImageIO")]
	public static NSString MakerOlympusDictionary
	{
		get
		{
			if (_MakerOlympusDictionary == null)
			{
				_MakerOlympusDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerOlympusDictionary");
			}
			return _MakerOlympusDictionary;
		}
	}

	[Field("kCGImagePropertyMakerPentaxDictionary", "ImageIO")]
	public static NSString MakerPentaxDictionary
	{
		get
		{
			if (_MakerPentaxDictionary == null)
			{
				_MakerPentaxDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerPentaxDictionary");
			}
			return _MakerPentaxDictionary;
		}
	}

	[Field("kCGImagePropertyFileSize", "ImageIO")]
	public static NSString FileSize
	{
		get
		{
			if (_FileSize == null)
			{
				_FileSize = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyFileSize");
			}
			return _FileSize;
		}
	}

	[Field("kCGImagePropertyDPIHeight", "ImageIO")]
	public static NSString DPIHeight
	{
		get
		{
			if (_DPIHeight == null)
			{
				_DPIHeight = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDPIHeight");
			}
			return _DPIHeight;
		}
	}

	[Field("kCGImagePropertyDPIWidth", "ImageIO")]
	public static NSString DPIWidth
	{
		get
		{
			if (_DPIWidth == null)
			{
				_DPIWidth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDPIWidth");
			}
			return _DPIWidth;
		}
	}

	[Field("kCGImagePropertyPixelWidth", "ImageIO")]
	public static NSString PixelWidth
	{
		get
		{
			if (_PixelWidth == null)
			{
				_PixelWidth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPixelWidth");
			}
			return _PixelWidth;
		}
	}

	[Field("kCGImagePropertyPixelHeight", "ImageIO")]
	public static NSString PixelHeight
	{
		get
		{
			if (_PixelHeight == null)
			{
				_PixelHeight = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPixelHeight");
			}
			return _PixelHeight;
		}
	}

	[Field("kCGImagePropertyDepth", "ImageIO")]
	public static NSString Depth
	{
		get
		{
			if (_Depth == null)
			{
				_Depth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDepth");
			}
			return _Depth;
		}
	}

	[Field("kCGImagePropertyOrientation", "ImageIO")]
	public static NSString Orientation
	{
		get
		{
			if (_Orientation == null)
			{
				_Orientation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyOrientation");
			}
			return _Orientation;
		}
	}

	[Field("kCGImagePropertyIsFloat", "ImageIO")]
	public static NSString IsFloat
	{
		get
		{
			if (_IsFloat == null)
			{
				_IsFloat = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIsFloat");
			}
			return _IsFloat;
		}
	}

	[Field("kCGImagePropertyIsIndexed", "ImageIO")]
	public static NSString IsIndexed
	{
		get
		{
			if (_IsIndexed == null)
			{
				_IsIndexed = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIsIndexed");
			}
			return _IsIndexed;
		}
	}

	[Field("kCGImagePropertyHasAlpha", "ImageIO")]
	public static NSString HasAlpha
	{
		get
		{
			if (_HasAlpha == null)
			{
				_HasAlpha = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHasAlpha");
			}
			return _HasAlpha;
		}
	}

	[Field("kCGImagePropertyColorModel", "ImageIO")]
	public static NSString ColorModel
	{
		get
		{
			if (_ColorModel == null)
			{
				_ColorModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyColorModel");
			}
			return _ColorModel;
		}
	}

	[Field("kCGImagePropertyProfileName", "ImageIO")]
	public static NSString ProfileName
	{
		get
		{
			if (_ProfileName == null)
			{
				_ProfileName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyProfileName");
			}
			return _ProfileName;
		}
	}

	[Field("kCGImagePropertyColorModelRGB", "ImageIO")]
	public static NSString ColorModelRGB
	{
		get
		{
			if (_ColorModelRGB == null)
			{
				_ColorModelRGB = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyColorModelRGB");
			}
			return _ColorModelRGB;
		}
	}

	[Field("kCGImagePropertyColorModelGray", "ImageIO")]
	public static NSString ColorModelGray
	{
		get
		{
			if (_ColorModelGray == null)
			{
				_ColorModelGray = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyColorModelGray");
			}
			return _ColorModelGray;
		}
	}

	[Field("kCGImagePropertyColorModelCMYK", "ImageIO")]
	public static NSString ColorModelCMYK
	{
		get
		{
			if (_ColorModelCMYK == null)
			{
				_ColorModelCMYK = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyColorModelCMYK");
			}
			return _ColorModelCMYK;
		}
	}

	[Field("kCGImagePropertyColorModelLab", "ImageIO")]
	public static NSString ColorModelLab
	{
		get
		{
			if (_ColorModelLab == null)
			{
				_ColorModelLab = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyColorModelLab");
			}
			return _ColorModelLab;
		}
	}

	[Field("kCGImagePropertyExifExposureTime", "ImageIO")]
	public static NSString ExifExposureTime
	{
		get
		{
			if (_ExifExposureTime == null)
			{
				_ExifExposureTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureTime");
			}
			return _ExifExposureTime;
		}
	}

	[Field("kCGImagePropertyExifFNumber", "ImageIO")]
	public static NSString ExifFNumber
	{
		get
		{
			if (_ExifFNumber == null)
			{
				_ExifFNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFNumber");
			}
			return _ExifFNumber;
		}
	}

	[Field("kCGImagePropertyExifExposureProgram", "ImageIO")]
	public static NSString ExifExposureProgram
	{
		get
		{
			if (_ExifExposureProgram == null)
			{
				_ExifExposureProgram = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureProgram");
			}
			return _ExifExposureProgram;
		}
	}

	[Field("kCGImagePropertyExifSpectralSensitivity", "ImageIO")]
	public static NSString ExifSpectralSensitivity
	{
		get
		{
			if (_ExifSpectralSensitivity == null)
			{
				_ExifSpectralSensitivity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSpectralSensitivity");
			}
			return _ExifSpectralSensitivity;
		}
	}

	[Field("kCGImagePropertyExifISOSpeedRatings", "ImageIO")]
	public static NSString ExifISOSpeedRatings
	{
		get
		{
			if (_ExifISOSpeedRatings == null)
			{
				_ExifISOSpeedRatings = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeedRatings");
			}
			return _ExifISOSpeedRatings;
		}
	}

	[Field("kCGImagePropertyExifOECF", "ImageIO")]
	public static NSString ExifOECF
	{
		get
		{
			if (_ExifOECF == null)
			{
				_ExifOECF = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifOECF");
			}
			return _ExifOECF;
		}
	}

	[Field("kCGImagePropertyExifVersion", "ImageIO")]
	public static NSString ExifVersion
	{
		get
		{
			if (_ExifVersion == null)
			{
				_ExifVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifVersion");
			}
			return _ExifVersion;
		}
	}

	[Field("kCGImagePropertyExifDateTimeOriginal", "ImageIO")]
	public static NSString ExifDateTimeOriginal
	{
		get
		{
			if (_ExifDateTimeOriginal == null)
			{
				_ExifDateTimeOriginal = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifDateTimeOriginal");
			}
			return _ExifDateTimeOriginal;
		}
	}

	[Field("kCGImagePropertyExifDateTimeDigitized", "ImageIO")]
	public static NSString ExifDateTimeDigitized
	{
		get
		{
			if (_ExifDateTimeDigitized == null)
			{
				_ExifDateTimeDigitized = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifDateTimeDigitized");
			}
			return _ExifDateTimeDigitized;
		}
	}

	[Field("kCGImagePropertyExifComponentsConfiguration", "ImageIO")]
	public static NSString ExifComponentsConfiguration
	{
		get
		{
			if (_ExifComponentsConfiguration == null)
			{
				_ExifComponentsConfiguration = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifComponentsConfiguration");
			}
			return _ExifComponentsConfiguration;
		}
	}

	[Field("kCGImagePropertyExifCompressedBitsPerPixel", "ImageIO")]
	public static NSString ExifCompressedBitsPerPixel
	{
		get
		{
			if (_ExifCompressedBitsPerPixel == null)
			{
				_ExifCompressedBitsPerPixel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifCompressedBitsPerPixel");
			}
			return _ExifCompressedBitsPerPixel;
		}
	}

	[Field("kCGImagePropertyExifShutterSpeedValue", "ImageIO")]
	public static NSString ExifShutterSpeedValue
	{
		get
		{
			if (_ExifShutterSpeedValue == null)
			{
				_ExifShutterSpeedValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifShutterSpeedValue");
			}
			return _ExifShutterSpeedValue;
		}
	}

	[Field("kCGImagePropertyExifApertureValue", "ImageIO")]
	public static NSString ExifApertureValue
	{
		get
		{
			if (_ExifApertureValue == null)
			{
				_ExifApertureValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifApertureValue");
			}
			return _ExifApertureValue;
		}
	}

	[Field("kCGImagePropertyExifBrightnessValue", "ImageIO")]
	public static NSString ExifBrightnessValue
	{
		get
		{
			if (_ExifBrightnessValue == null)
			{
				_ExifBrightnessValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifBrightnessValue");
			}
			return _ExifBrightnessValue;
		}
	}

	[Field("kCGImagePropertyExifExposureBiasValue", "ImageIO")]
	public static NSString ExifExposureBiasValue
	{
		get
		{
			if (_ExifExposureBiasValue == null)
			{
				_ExifExposureBiasValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureBiasValue");
			}
			return _ExifExposureBiasValue;
		}
	}

	[Field("kCGImagePropertyExifMaxApertureValue", "ImageIO")]
	public static NSString ExifMaxApertureValue
	{
		get
		{
			if (_ExifMaxApertureValue == null)
			{
				_ExifMaxApertureValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifMaxApertureValue");
			}
			return _ExifMaxApertureValue;
		}
	}

	[Field("kCGImagePropertyExifSubjectDistance", "ImageIO")]
	public static NSString ExifSubjectDistance
	{
		get
		{
			if (_ExifSubjectDistance == null)
			{
				_ExifSubjectDistance = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectDistance");
			}
			return _ExifSubjectDistance;
		}
	}

	[Field("kCGImagePropertyExifMeteringMode", "ImageIO")]
	public static NSString ExifMeteringMode
	{
		get
		{
			if (_ExifMeteringMode == null)
			{
				_ExifMeteringMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifMeteringMode");
			}
			return _ExifMeteringMode;
		}
	}

	[Field("kCGImagePropertyExifLightSource", "ImageIO")]
	public static NSString ExifLightSource
	{
		get
		{
			if (_ExifLightSource == null)
			{
				_ExifLightSource = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifLightSource");
			}
			return _ExifLightSource;
		}
	}

	[Field("kCGImagePropertyExifFlash", "ImageIO")]
	public static NSString ExifFlash
	{
		get
		{
			if (_ExifFlash == null)
			{
				_ExifFlash = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFlash");
			}
			return _ExifFlash;
		}
	}

	[Field("kCGImagePropertyExifFocalLength", "ImageIO")]
	public static NSString ExifFocalLength
	{
		get
		{
			if (_ExifFocalLength == null)
			{
				_ExifFocalLength = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalLength");
			}
			return _ExifFocalLength;
		}
	}

	[Field("kCGImagePropertyExifSubjectArea", "ImageIO")]
	public static NSString ExifSubjectArea
	{
		get
		{
			if (_ExifSubjectArea == null)
			{
				_ExifSubjectArea = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectArea");
			}
			return _ExifSubjectArea;
		}
	}

	[Field("kCGImagePropertyExifMakerNote", "ImageIO")]
	public static NSString ExifMakerNote
	{
		get
		{
			if (_ExifMakerNote == null)
			{
				_ExifMakerNote = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifMakerNote");
			}
			return _ExifMakerNote;
		}
	}

	[Field("kCGImagePropertyExifUserComment", "ImageIO")]
	public static NSString ExifUserComment
	{
		get
		{
			if (_ExifUserComment == null)
			{
				_ExifUserComment = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifUserComment");
			}
			return _ExifUserComment;
		}
	}

	[Field("kCGImagePropertyExifSubsecTime", "ImageIO")]
	public static NSString ExifSubsecTime
	{
		get
		{
			if (_ExifSubsecTime == null)
			{
				_ExifSubsecTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTime");
			}
			return _ExifSubsecTime;
		}
	}

	[Field("kCGImagePropertyExifSubsecTimeOrginal", "ImageIO")]
	public static NSString ExifSubsecTimeOrginal
	{
		get
		{
			if (_ExifSubsecTimeOrginal == null)
			{
				_ExifSubsecTimeOrginal = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTimeOrginal");
			}
			return _ExifSubsecTimeOrginal;
		}
	}

	[Field("kCGImagePropertyExifSubsecTimeDigitized", "ImageIO")]
	public static NSString ExifSubsecTimeDigitized
	{
		get
		{
			if (_ExifSubsecTimeDigitized == null)
			{
				_ExifSubsecTimeDigitized = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTimeDigitized");
			}
			return _ExifSubsecTimeDigitized;
		}
	}

	[Field("kCGImagePropertyExifFlashPixVersion", "ImageIO")]
	public static NSString ExifFlashPixVersion
	{
		get
		{
			if (_ExifFlashPixVersion == null)
			{
				_ExifFlashPixVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFlashPixVersion");
			}
			return _ExifFlashPixVersion;
		}
	}

	[Field("kCGImagePropertyExifColorSpace", "ImageIO")]
	public static NSString ExifColorSpace
	{
		get
		{
			if (_ExifColorSpace == null)
			{
				_ExifColorSpace = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifColorSpace");
			}
			return _ExifColorSpace;
		}
	}

	[Field("kCGImagePropertyExifPixelXDimension", "ImageIO")]
	public static NSString ExifPixelXDimension
	{
		get
		{
			if (_ExifPixelXDimension == null)
			{
				_ExifPixelXDimension = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifPixelXDimension");
			}
			return _ExifPixelXDimension;
		}
	}

	[Field("kCGImagePropertyExifPixelYDimension", "ImageIO")]
	public static NSString ExifPixelYDimension
	{
		get
		{
			if (_ExifPixelYDimension == null)
			{
				_ExifPixelYDimension = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifPixelYDimension");
			}
			return _ExifPixelYDimension;
		}
	}

	[Field("kCGImagePropertyExifRelatedSoundFile", "ImageIO")]
	public static NSString ExifRelatedSoundFile
	{
		get
		{
			if (_ExifRelatedSoundFile == null)
			{
				_ExifRelatedSoundFile = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifRelatedSoundFile");
			}
			return _ExifRelatedSoundFile;
		}
	}

	[Field("kCGImagePropertyExifFlashEnergy", "ImageIO")]
	public static NSString ExifFlashEnergy
	{
		get
		{
			if (_ExifFlashEnergy == null)
			{
				_ExifFlashEnergy = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFlashEnergy");
			}
			return _ExifFlashEnergy;
		}
	}

	[Field("kCGImagePropertyExifSpatialFrequencyResponse", "ImageIO")]
	public static NSString ExifSpatialFrequencyResponse
	{
		get
		{
			if (_ExifSpatialFrequencyResponse == null)
			{
				_ExifSpatialFrequencyResponse = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSpatialFrequencyResponse");
			}
			return _ExifSpatialFrequencyResponse;
		}
	}

	[Field("kCGImagePropertyExifFocalPlaneXResolution", "ImageIO")]
	public static NSString ExifFocalPlaneXResolution
	{
		get
		{
			if (_ExifFocalPlaneXResolution == null)
			{
				_ExifFocalPlaneXResolution = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalPlaneXResolution");
			}
			return _ExifFocalPlaneXResolution;
		}
	}

	[Field("kCGImagePropertyExifFocalPlaneYResolution", "ImageIO")]
	public static NSString ExifFocalPlaneYResolution
	{
		get
		{
			if (_ExifFocalPlaneYResolution == null)
			{
				_ExifFocalPlaneYResolution = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalPlaneYResolution");
			}
			return _ExifFocalPlaneYResolution;
		}
	}

	[Field("kCGImagePropertyExifFocalPlaneResolutionUnit", "ImageIO")]
	public static NSString ExifFocalPlaneResolutionUnit
	{
		get
		{
			if (_ExifFocalPlaneResolutionUnit == null)
			{
				_ExifFocalPlaneResolutionUnit = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalPlaneResolutionUnit");
			}
			return _ExifFocalPlaneResolutionUnit;
		}
	}

	[Field("kCGImagePropertyExifSubjectLocation", "ImageIO")]
	public static NSString ExifSubjectLocation
	{
		get
		{
			if (_ExifSubjectLocation == null)
			{
				_ExifSubjectLocation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectLocation");
			}
			return _ExifSubjectLocation;
		}
	}

	[Field("kCGImagePropertyExifExposureIndex", "ImageIO")]
	public static NSString ExifExposureIndex
	{
		get
		{
			if (_ExifExposureIndex == null)
			{
				_ExifExposureIndex = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureIndex");
			}
			return _ExifExposureIndex;
		}
	}

	[Field("kCGImagePropertyExifSensingMethod", "ImageIO")]
	public static NSString ExifSensingMethod
	{
		get
		{
			if (_ExifSensingMethod == null)
			{
				_ExifSensingMethod = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSensingMethod");
			}
			return _ExifSensingMethod;
		}
	}

	[Field("kCGImagePropertyExifFileSource", "ImageIO")]
	public static NSString ExifFileSource
	{
		get
		{
			if (_ExifFileSource == null)
			{
				_ExifFileSource = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFileSource");
			}
			return _ExifFileSource;
		}
	}

	[Field("kCGImagePropertyExifSceneType", "ImageIO")]
	public static NSString ExifSceneType
	{
		get
		{
			if (_ExifSceneType == null)
			{
				_ExifSceneType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSceneType");
			}
			return _ExifSceneType;
		}
	}

	[Field("kCGImagePropertyExifCFAPattern", "ImageIO")]
	public static NSString ExifCFAPattern
	{
		get
		{
			if (_ExifCFAPattern == null)
			{
				_ExifCFAPattern = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifCFAPattern");
			}
			return _ExifCFAPattern;
		}
	}

	[Field("kCGImagePropertyExifCustomRendered", "ImageIO")]
	public static NSString ExifCustomRendered
	{
		get
		{
			if (_ExifCustomRendered == null)
			{
				_ExifCustomRendered = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifCustomRendered");
			}
			return _ExifCustomRendered;
		}
	}

	[Field("kCGImagePropertyExifExposureMode", "ImageIO")]
	public static NSString ExifExposureMode
	{
		get
		{
			if (_ExifExposureMode == null)
			{
				_ExifExposureMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifExposureMode");
			}
			return _ExifExposureMode;
		}
	}

	[Field("kCGImagePropertyExifWhiteBalance", "ImageIO")]
	public static NSString ExifWhiteBalance
	{
		get
		{
			if (_ExifWhiteBalance == null)
			{
				_ExifWhiteBalance = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifWhiteBalance");
			}
			return _ExifWhiteBalance;
		}
	}

	[Field("kCGImagePropertyExifDigitalZoomRatio", "ImageIO")]
	public static NSString ExifDigitalZoomRatio
	{
		get
		{
			if (_ExifDigitalZoomRatio == null)
			{
				_ExifDigitalZoomRatio = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifDigitalZoomRatio");
			}
			return _ExifDigitalZoomRatio;
		}
	}

	[Field("kCGImagePropertyExifFocalLenIn35mmFilm", "ImageIO")]
	public static NSString ExifFocalLenIn35mmFilm
	{
		get
		{
			if (_ExifFocalLenIn35mmFilm == null)
			{
				_ExifFocalLenIn35mmFilm = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifFocalLenIn35mmFilm");
			}
			return _ExifFocalLenIn35mmFilm;
		}
	}

	[Field("kCGImagePropertyExifSceneCaptureType", "ImageIO")]
	public static NSString ExifSceneCaptureType
	{
		get
		{
			if (_ExifSceneCaptureType == null)
			{
				_ExifSceneCaptureType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSceneCaptureType");
			}
			return _ExifSceneCaptureType;
		}
	}

	[Field("kCGImagePropertyExifGainControl", "ImageIO")]
	public static NSString ExifGainControl
	{
		get
		{
			if (_ExifGainControl == null)
			{
				_ExifGainControl = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifGainControl");
			}
			return _ExifGainControl;
		}
	}

	[Field("kCGImagePropertyExifContrast", "ImageIO")]
	public static NSString ExifContrast
	{
		get
		{
			if (_ExifContrast == null)
			{
				_ExifContrast = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifContrast");
			}
			return _ExifContrast;
		}
	}

	[Field("kCGImagePropertyExifSaturation", "ImageIO")]
	public static NSString ExifSaturation
	{
		get
		{
			if (_ExifSaturation == null)
			{
				_ExifSaturation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSaturation");
			}
			return _ExifSaturation;
		}
	}

	[Field("kCGImagePropertyExifSharpness", "ImageIO")]
	public static NSString ExifSharpness
	{
		get
		{
			if (_ExifSharpness == null)
			{
				_ExifSharpness = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSharpness");
			}
			return _ExifSharpness;
		}
	}

	[Field("kCGImagePropertyExifDeviceSettingDescription", "ImageIO")]
	public static NSString ExifDeviceSettingDescription
	{
		get
		{
			if (_ExifDeviceSettingDescription == null)
			{
				_ExifDeviceSettingDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifDeviceSettingDescription");
			}
			return _ExifDeviceSettingDescription;
		}
	}

	[Field("kCGImagePropertyExifSubjectDistRange", "ImageIO")]
	public static NSString ExifSubjectDistRange
	{
		get
		{
			if (_ExifSubjectDistRange == null)
			{
				_ExifSubjectDistRange = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubjectDistRange");
			}
			return _ExifSubjectDistRange;
		}
	}

	[Field("kCGImagePropertyExifImageUniqueID", "ImageIO")]
	public static NSString ExifImageUniqueID
	{
		get
		{
			if (_ExifImageUniqueID == null)
			{
				_ExifImageUniqueID = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifImageUniqueID");
			}
			return _ExifImageUniqueID;
		}
	}

	[Field("kCGImagePropertyExifGamma", "ImageIO")]
	public static NSString ExifGamma
	{
		get
		{
			if (_ExifGamma == null)
			{
				_ExifGamma = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifGamma");
			}
			return _ExifGamma;
		}
	}

	[Field("kCGImagePropertyExifCameraOwnerName", "ImageIO")]
	public static NSString ExifCameraOwnerName
	{
		get
		{
			if (_ExifCameraOwnerName == null)
			{
				_ExifCameraOwnerName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifCameraOwnerName");
			}
			return _ExifCameraOwnerName;
		}
	}

	[Field("kCGImagePropertyExifBodySerialNumber", "ImageIO")]
	public static NSString ExifBodySerialNumber
	{
		get
		{
			if (_ExifBodySerialNumber == null)
			{
				_ExifBodySerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifBodySerialNumber");
			}
			return _ExifBodySerialNumber;
		}
	}

	[Field("kCGImagePropertyExifLensSpecification", "ImageIO")]
	public static NSString ExifLensSpecification
	{
		get
		{
			if (_ExifLensSpecification == null)
			{
				_ExifLensSpecification = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifLensSpecification");
			}
			return _ExifLensSpecification;
		}
	}

	[Field("kCGImagePropertyExifLensMake", "ImageIO")]
	public static NSString ExifLensMake
	{
		get
		{
			if (_ExifLensMake == null)
			{
				_ExifLensMake = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifLensMake");
			}
			return _ExifLensMake;
		}
	}

	[Field("kCGImagePropertyExifLensModel", "ImageIO")]
	public static NSString ExifLensModel
	{
		get
		{
			if (_ExifLensModel == null)
			{
				_ExifLensModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifLensModel");
			}
			return _ExifLensModel;
		}
	}

	[Field("kCGImagePropertyExifLensSerialNumber", "ImageIO")]
	public static NSString ExifLensSerialNumber
	{
		get
		{
			if (_ExifLensSerialNumber == null)
			{
				_ExifLensSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifLensSerialNumber");
			}
			return _ExifLensSerialNumber;
		}
	}

	[Field("kCGImagePropertyExifAuxLensInfo", "ImageIO")]
	public static NSString ExifAuxLensInfo
	{
		get
		{
			if (_ExifAuxLensInfo == null)
			{
				_ExifAuxLensInfo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensInfo");
			}
			return _ExifAuxLensInfo;
		}
	}

	[Field("kCGImagePropertyExifAuxLensModel", "ImageIO")]
	public static NSString ExifAuxLensModel
	{
		get
		{
			if (_ExifAuxLensModel == null)
			{
				_ExifAuxLensModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensModel");
			}
			return _ExifAuxLensModel;
		}
	}

	[Field("kCGImagePropertyExifAuxSerialNumber", "ImageIO")]
	public static NSString ExifAuxSerialNumber
	{
		get
		{
			if (_ExifAuxSerialNumber == null)
			{
				_ExifAuxSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxSerialNumber");
			}
			return _ExifAuxSerialNumber;
		}
	}

	[Field("kCGImagePropertyExifAuxLensID", "ImageIO")]
	public static NSString ExifAuxLensID
	{
		get
		{
			if (_ExifAuxLensID == null)
			{
				_ExifAuxLensID = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensID");
			}
			return _ExifAuxLensID;
		}
	}

	[Field("kCGImagePropertyExifAuxLensSerialNumber", "ImageIO")]
	public static NSString ExifAuxLensSerialNumber
	{
		get
		{
			if (_ExifAuxLensSerialNumber == null)
			{
				_ExifAuxLensSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxLensSerialNumber");
			}
			return _ExifAuxLensSerialNumber;
		}
	}

	[Field("kCGImagePropertyExifAuxImageNumber", "ImageIO")]
	public static NSString ExifAuxImageNumber
	{
		get
		{
			if (_ExifAuxImageNumber == null)
			{
				_ExifAuxImageNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxImageNumber");
			}
			return _ExifAuxImageNumber;
		}
	}

	[Field("kCGImagePropertyExifAuxFlashCompensation", "ImageIO")]
	public static NSString ExifAuxFlashCompensation
	{
		get
		{
			if (_ExifAuxFlashCompensation == null)
			{
				_ExifAuxFlashCompensation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxFlashCompensation");
			}
			return _ExifAuxFlashCompensation;
		}
	}

	[Field("kCGImagePropertyExifAuxOwnerName", "ImageIO")]
	public static NSString ExifAuxOwnerName
	{
		get
		{
			if (_ExifAuxOwnerName == null)
			{
				_ExifAuxOwnerName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxOwnerName");
			}
			return _ExifAuxOwnerName;
		}
	}

	[Field("kCGImagePropertyExifAuxFirmware", "ImageIO")]
	public static NSString ExifAuxFirmware
	{
		get
		{
			if (_ExifAuxFirmware == null)
			{
				_ExifAuxFirmware = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifAuxFirmware");
			}
			return _ExifAuxFirmware;
		}
	}

	[Field("kCGImagePropertyGIFLoopCount", "ImageIO")]
	public static NSString GIFLoopCount
	{
		get
		{
			if (_GIFLoopCount == null)
			{
				_GIFLoopCount = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFLoopCount");
			}
			return _GIFLoopCount;
		}
	}

	[Field("kCGImagePropertyGIFDelayTime", "ImageIO")]
	public static NSString GIFDelayTime
	{
		get
		{
			if (_GIFDelayTime == null)
			{
				_GIFDelayTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFDelayTime");
			}
			return _GIFDelayTime;
		}
	}

	[Field("kCGImagePropertyGIFImageColorMap", "ImageIO")]
	public static NSString GIFImageColorMap
	{
		get
		{
			if (_GIFImageColorMap == null)
			{
				_GIFImageColorMap = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFImageColorMap");
			}
			return _GIFImageColorMap;
		}
	}

	[Field("kCGImagePropertyGIFHasGlobalColorMap", "ImageIO")]
	public static NSString GIFHasGlobalColorMap
	{
		get
		{
			if (_GIFHasGlobalColorMap == null)
			{
				_GIFHasGlobalColorMap = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFHasGlobalColorMap");
			}
			return _GIFHasGlobalColorMap;
		}
	}

	[Field("kCGImagePropertyGIFUnclampedDelayTime", "ImageIO")]
	public static NSString GIFUnclampedDelayTime
	{
		get
		{
			if (_GIFUnclampedDelayTime == null)
			{
				_GIFUnclampedDelayTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFUnclampedDelayTime");
			}
			return _GIFUnclampedDelayTime;
		}
	}

	[Field("kCGImagePropertyGPSVersion", "ImageIO")]
	public static NSString GPSVersion
	{
		get
		{
			if (_GPSVersion == null)
			{
				_GPSVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSVersion");
			}
			return _GPSVersion;
		}
	}

	[Field("kCGImagePropertyGPSLatitudeRef", "ImageIO")]
	public static NSString GPSLatitudeRef
	{
		get
		{
			if (_GPSLatitudeRef == null)
			{
				_GPSLatitudeRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSLatitudeRef");
			}
			return _GPSLatitudeRef;
		}
	}

	[Field("kCGImagePropertyGPSLatitude", "ImageIO")]
	public static NSString GPSLatitude
	{
		get
		{
			if (_GPSLatitude == null)
			{
				_GPSLatitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSLatitude");
			}
			return _GPSLatitude;
		}
	}

	[Field("kCGImagePropertyGPSLongitudeRef", "ImageIO")]
	public static NSString GPSLongitudeRef
	{
		get
		{
			if (_GPSLongitudeRef == null)
			{
				_GPSLongitudeRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSLongitudeRef");
			}
			return _GPSLongitudeRef;
		}
	}

	[Field("kCGImagePropertyGPSLongitude", "ImageIO")]
	public static NSString GPSLongitude
	{
		get
		{
			if (_GPSLongitude == null)
			{
				_GPSLongitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSLongitude");
			}
			return _GPSLongitude;
		}
	}

	[Field("kCGImagePropertyGPSAltitudeRef", "ImageIO")]
	public static NSString GPSAltitudeRef
	{
		get
		{
			if (_GPSAltitudeRef == null)
			{
				_GPSAltitudeRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSAltitudeRef");
			}
			return _GPSAltitudeRef;
		}
	}

	[Field("kCGImagePropertyGPSAltitude", "ImageIO")]
	public static NSString GPSAltitude
	{
		get
		{
			if (_GPSAltitude == null)
			{
				_GPSAltitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSAltitude");
			}
			return _GPSAltitude;
		}
	}

	[Field("kCGImagePropertyGPSTimeStamp", "ImageIO")]
	public static NSString GPSTimeStamp
	{
		get
		{
			if (_GPSTimeStamp == null)
			{
				_GPSTimeStamp = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSTimeStamp");
			}
			return _GPSTimeStamp;
		}
	}

	[Field("kCGImagePropertyGPSSatellites", "ImageIO")]
	public static NSString GPSSatellites
	{
		get
		{
			if (_GPSSatellites == null)
			{
				_GPSSatellites = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSSatellites");
			}
			return _GPSSatellites;
		}
	}

	[Field("kCGImagePropertyGPSStatus", "ImageIO")]
	public static NSString GPSStatus
	{
		get
		{
			if (_GPSStatus == null)
			{
				_GPSStatus = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSStatus");
			}
			return _GPSStatus;
		}
	}

	[Field("kCGImagePropertyGPSMeasureMode", "ImageIO")]
	public static NSString GPSMeasureMode
	{
		get
		{
			if (_GPSMeasureMode == null)
			{
				_GPSMeasureMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSMeasureMode");
			}
			return _GPSMeasureMode;
		}
	}

	[Field("kCGImagePropertyGPSDOP", "ImageIO")]
	public static NSString GPSDOP
	{
		get
		{
			if (_GPSDOP == null)
			{
				_GPSDOP = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDOP");
			}
			return _GPSDOP;
		}
	}

	[Field("kCGImagePropertyGPSSpeedRef", "ImageIO")]
	public static NSString GPSSpeedRef
	{
		get
		{
			if (_GPSSpeedRef == null)
			{
				_GPSSpeedRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSSpeedRef");
			}
			return _GPSSpeedRef;
		}
	}

	[Field("kCGImagePropertyGPSSpeed", "ImageIO")]
	public static NSString GPSSpeed
	{
		get
		{
			if (_GPSSpeed == null)
			{
				_GPSSpeed = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSSpeed");
			}
			return _GPSSpeed;
		}
	}

	[Field("kCGImagePropertyGPSTrackRef", "ImageIO")]
	public static NSString GPSTrackRef
	{
		get
		{
			if (_GPSTrackRef == null)
			{
				_GPSTrackRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSTrackRef");
			}
			return _GPSTrackRef;
		}
	}

	[Field("kCGImagePropertyGPSTrack", "ImageIO")]
	public static NSString GPSTrack
	{
		get
		{
			if (_GPSTrack == null)
			{
				_GPSTrack = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSTrack");
			}
			return _GPSTrack;
		}
	}

	[Field("kCGImagePropertyGPSImgDirectionRef", "ImageIO")]
	public static NSString GPSImgDirectionRef
	{
		get
		{
			if (_GPSImgDirectionRef == null)
			{
				_GPSImgDirectionRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSImgDirectionRef");
			}
			return _GPSImgDirectionRef;
		}
	}

	[Field("kCGImagePropertyGPSImgDirection", "ImageIO")]
	public static NSString GPSImgDirection
	{
		get
		{
			if (_GPSImgDirection == null)
			{
				_GPSImgDirection = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSImgDirection");
			}
			return _GPSImgDirection;
		}
	}

	[Field("kCGImagePropertyGPSMapDatum", "ImageIO")]
	public static NSString GPSMapDatum
	{
		get
		{
			if (_GPSMapDatum == null)
			{
				_GPSMapDatum = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSMapDatum");
			}
			return _GPSMapDatum;
		}
	}

	[Field("kCGImagePropertyGPSDestLatitudeRef", "ImageIO")]
	public static NSString GPSDestLatitudeRef
	{
		get
		{
			if (_GPSDestLatitudeRef == null)
			{
				_GPSDestLatitudeRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLatitudeRef");
			}
			return _GPSDestLatitudeRef;
		}
	}

	[Field("kCGImagePropertyGPSDestLatitude", "ImageIO")]
	public static NSString GPSDestLatitude
	{
		get
		{
			if (_GPSDestLatitude == null)
			{
				_GPSDestLatitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLatitude");
			}
			return _GPSDestLatitude;
		}
	}

	[Field("kCGImagePropertyGPSDestLongitudeRef", "ImageIO")]
	public static NSString GPSDestLongitudeRef
	{
		get
		{
			if (_GPSDestLongitudeRef == null)
			{
				_GPSDestLongitudeRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLongitudeRef");
			}
			return _GPSDestLongitudeRef;
		}
	}

	[Field("kCGImagePropertyGPSDestLongitude", "ImageIO")]
	public static NSString GPSDestLongitude
	{
		get
		{
			if (_GPSDestLongitude == null)
			{
				_GPSDestLongitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestLongitude");
			}
			return _GPSDestLongitude;
		}
	}

	[Field("kCGImagePropertyGPSDestBearingRef", "ImageIO")]
	public static NSString GPSDestBearingRef
	{
		get
		{
			if (_GPSDestBearingRef == null)
			{
				_GPSDestBearingRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestBearingRef");
			}
			return _GPSDestBearingRef;
		}
	}

	[Field("kCGImagePropertyGPSDestBearing", "ImageIO")]
	public static NSString GPSDestBearing
	{
		get
		{
			if (_GPSDestBearing == null)
			{
				_GPSDestBearing = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestBearing");
			}
			return _GPSDestBearing;
		}
	}

	[Field("kCGImagePropertyGPSDestDistanceRef", "ImageIO")]
	public static NSString GPSDestDistanceRef
	{
		get
		{
			if (_GPSDestDistanceRef == null)
			{
				_GPSDestDistanceRef = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestDistanceRef");
			}
			return _GPSDestDistanceRef;
		}
	}

	[Field("kCGImagePropertyGPSDestDistance", "ImageIO")]
	public static NSString GPSDestDistance
	{
		get
		{
			if (_GPSDestDistance == null)
			{
				_GPSDestDistance = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDestDistance");
			}
			return _GPSDestDistance;
		}
	}

	[Field("kCGImagePropertyGPSAreaInformation", "ImageIO")]
	public static NSString GPSAreaInformation
	{
		get
		{
			if (_GPSAreaInformation == null)
			{
				_GPSAreaInformation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSAreaInformation");
			}
			return _GPSAreaInformation;
		}
	}

	[Field("kCGImagePropertyGPSDateStamp", "ImageIO")]
	public static NSString GPSDateStamp
	{
		get
		{
			if (_GPSDateStamp == null)
			{
				_GPSDateStamp = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDateStamp");
			}
			return _GPSDateStamp;
		}
	}

	[Field("kCGImagePropertyGPSDifferental", "ImageIO")]
	public static NSString GPSDifferental
	{
		get
		{
			if (_GPSDifferental == null)
			{
				_GPSDifferental = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSDifferental");
			}
			return _GPSDifferental;
		}
	}

	[Field("kCGImagePropertyIPTCObjectTypeReference", "ImageIO")]
	public static NSString IPTCObjectTypeReference
	{
		get
		{
			if (_IPTCObjectTypeReference == null)
			{
				_IPTCObjectTypeReference = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectTypeReference");
			}
			return _IPTCObjectTypeReference;
		}
	}

	[Field("kCGImagePropertyIPTCObjectAttributeReference", "ImageIO")]
	public static NSString IPTCObjectAttributeReference
	{
		get
		{
			if (_IPTCObjectAttributeReference == null)
			{
				_IPTCObjectAttributeReference = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectAttributeReference");
			}
			return _IPTCObjectAttributeReference;
		}
	}

	[Field("kCGImagePropertyIPTCObjectName", "ImageIO")]
	public static NSString IPTCObjectName
	{
		get
		{
			if (_IPTCObjectName == null)
			{
				_IPTCObjectName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectName");
			}
			return _IPTCObjectName;
		}
	}

	[Field("kCGImagePropertyIPTCEditStatus", "ImageIO")]
	public static NSString IPTCEditStatus
	{
		get
		{
			if (_IPTCEditStatus == null)
			{
				_IPTCEditStatus = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCEditStatus");
			}
			return _IPTCEditStatus;
		}
	}

	[Field("kCGImagePropertyIPTCEditorialUpdate", "ImageIO")]
	public static NSString IPTCEditorialUpdate
	{
		get
		{
			if (_IPTCEditorialUpdate == null)
			{
				_IPTCEditorialUpdate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCEditorialUpdate");
			}
			return _IPTCEditorialUpdate;
		}
	}

	[Field("kCGImagePropertyIPTCUrgency", "ImageIO")]
	public static NSString IPTCUrgency
	{
		get
		{
			if (_IPTCUrgency == null)
			{
				_IPTCUrgency = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCUrgency");
			}
			return _IPTCUrgency;
		}
	}

	[Field("kCGImagePropertyIPTCSubjectReference", "ImageIO")]
	public static NSString IPTCSubjectReference
	{
		get
		{
			if (_IPTCSubjectReference == null)
			{
				_IPTCSubjectReference = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSubjectReference");
			}
			return _IPTCSubjectReference;
		}
	}

	[Field("kCGImagePropertyIPTCCategory", "ImageIO")]
	public static NSString IPTCCategory
	{
		get
		{
			if (_IPTCCategory == null)
			{
				_IPTCCategory = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCategory");
			}
			return _IPTCCategory;
		}
	}

	[Field("kCGImagePropertyIPTCSupplementalCategory", "ImageIO")]
	public static NSString IPTCSupplementalCategory
	{
		get
		{
			if (_IPTCSupplementalCategory == null)
			{
				_IPTCSupplementalCategory = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSupplementalCategory");
			}
			return _IPTCSupplementalCategory;
		}
	}

	[Field("kCGImagePropertyIPTCFixtureIdentifier", "ImageIO")]
	public static NSString IPTCFixtureIdentifier
	{
		get
		{
			if (_IPTCFixtureIdentifier == null)
			{
				_IPTCFixtureIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCFixtureIdentifier");
			}
			return _IPTCFixtureIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCKeywords", "ImageIO")]
	public static NSString IPTCKeywords
	{
		get
		{
			if (_IPTCKeywords == null)
			{
				_IPTCKeywords = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCKeywords");
			}
			return _IPTCKeywords;
		}
	}

	[Field("kCGImagePropertyIPTCContentLocationCode", "ImageIO")]
	public static NSString IPTCContentLocationCode
	{
		get
		{
			if (_IPTCContentLocationCode == null)
			{
				_IPTCContentLocationCode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContentLocationCode");
			}
			return _IPTCContentLocationCode;
		}
	}

	[Field("kCGImagePropertyIPTCContentLocationName", "ImageIO")]
	public static NSString IPTCContentLocationName
	{
		get
		{
			if (_IPTCContentLocationName == null)
			{
				_IPTCContentLocationName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContentLocationName");
			}
			return _IPTCContentLocationName;
		}
	}

	[Field("kCGImagePropertyIPTCReleaseDate", "ImageIO")]
	public static NSString IPTCReleaseDate
	{
		get
		{
			if (_IPTCReleaseDate == null)
			{
				_IPTCReleaseDate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReleaseDate");
			}
			return _IPTCReleaseDate;
		}
	}

	[Field("kCGImagePropertyIPTCReleaseTime", "ImageIO")]
	public static NSString IPTCReleaseTime
	{
		get
		{
			if (_IPTCReleaseTime == null)
			{
				_IPTCReleaseTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReleaseTime");
			}
			return _IPTCReleaseTime;
		}
	}

	[Field("kCGImagePropertyIPTCExpirationDate", "ImageIO")]
	public static NSString IPTCExpirationDate
	{
		get
		{
			if (_IPTCExpirationDate == null)
			{
				_IPTCExpirationDate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExpirationDate");
			}
			return _IPTCExpirationDate;
		}
	}

	[Field("kCGImagePropertyIPTCExpirationTime", "ImageIO")]
	public static NSString IPTCExpirationTime
	{
		get
		{
			if (_IPTCExpirationTime == null)
			{
				_IPTCExpirationTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExpirationTime");
			}
			return _IPTCExpirationTime;
		}
	}

	[Field("kCGImagePropertyIPTCSpecialInstructions", "ImageIO")]
	public static NSString IPTCSpecialInstructions
	{
		get
		{
			if (_IPTCSpecialInstructions == null)
			{
				_IPTCSpecialInstructions = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSpecialInstructions");
			}
			return _IPTCSpecialInstructions;
		}
	}

	[Field("kCGImagePropertyIPTCActionAdvised", "ImageIO")]
	public static NSString IPTCActionAdvised
	{
		get
		{
			if (_IPTCActionAdvised == null)
			{
				_IPTCActionAdvised = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCActionAdvised");
			}
			return _IPTCActionAdvised;
		}
	}

	[Field("kCGImagePropertyIPTCReferenceService", "ImageIO")]
	public static NSString IPTCReferenceService
	{
		get
		{
			if (_IPTCReferenceService == null)
			{
				_IPTCReferenceService = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReferenceService");
			}
			return _IPTCReferenceService;
		}
	}

	[Field("kCGImagePropertyIPTCReferenceDate", "ImageIO")]
	public static NSString IPTCReferenceDate
	{
		get
		{
			if (_IPTCReferenceDate == null)
			{
				_IPTCReferenceDate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReferenceDate");
			}
			return _IPTCReferenceDate;
		}
	}

	[Field("kCGImagePropertyIPTCReferenceNumber", "ImageIO")]
	public static NSString IPTCReferenceNumber
	{
		get
		{
			if (_IPTCReferenceNumber == null)
			{
				_IPTCReferenceNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCReferenceNumber");
			}
			return _IPTCReferenceNumber;
		}
	}

	[Field("kCGImagePropertyIPTCDateCreated", "ImageIO")]
	public static NSString IPTCDateCreated
	{
		get
		{
			if (_IPTCDateCreated == null)
			{
				_IPTCDateCreated = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDateCreated");
			}
			return _IPTCDateCreated;
		}
	}

	[Field("kCGImagePropertyIPTCTimeCreated", "ImageIO")]
	public static NSString IPTCTimeCreated
	{
		get
		{
			if (_IPTCTimeCreated == null)
			{
				_IPTCTimeCreated = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCTimeCreated");
			}
			return _IPTCTimeCreated;
		}
	}

	[Field("kCGImagePropertyIPTCDigitalCreationDate", "ImageIO")]
	public static NSString IPTCDigitalCreationDate
	{
		get
		{
			if (_IPTCDigitalCreationDate == null)
			{
				_IPTCDigitalCreationDate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDigitalCreationDate");
			}
			return _IPTCDigitalCreationDate;
		}
	}

	[Field("kCGImagePropertyIPTCDigitalCreationTime", "ImageIO")]
	public static NSString IPTCDigitalCreationTime
	{
		get
		{
			if (_IPTCDigitalCreationTime == null)
			{
				_IPTCDigitalCreationTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCDigitalCreationTime");
			}
			return _IPTCDigitalCreationTime;
		}
	}

	[Field("kCGImagePropertyIPTCOriginatingProgram", "ImageIO")]
	public static NSString IPTCOriginatingProgram
	{
		get
		{
			if (_IPTCOriginatingProgram == null)
			{
				_IPTCOriginatingProgram = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCOriginatingProgram");
			}
			return _IPTCOriginatingProgram;
		}
	}

	[Field("kCGImagePropertyIPTCProgramVersion", "ImageIO")]
	public static NSString IPTCProgramVersion
	{
		get
		{
			if (_IPTCProgramVersion == null)
			{
				_IPTCProgramVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCProgramVersion");
			}
			return _IPTCProgramVersion;
		}
	}

	[Field("kCGImagePropertyIPTCObjectCycle", "ImageIO")]
	public static NSString IPTCObjectCycle
	{
		get
		{
			if (_IPTCObjectCycle == null)
			{
				_IPTCObjectCycle = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCObjectCycle");
			}
			return _IPTCObjectCycle;
		}
	}

	[Field("kCGImagePropertyIPTCByline", "ImageIO")]
	public static NSString IPTCByline
	{
		get
		{
			if (_IPTCByline == null)
			{
				_IPTCByline = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCByline");
			}
			return _IPTCByline;
		}
	}

	[Field("kCGImagePropertyIPTCBylineTitle", "ImageIO")]
	public static NSString IPTCBylineTitle
	{
		get
		{
			if (_IPTCBylineTitle == null)
			{
				_IPTCBylineTitle = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCBylineTitle");
			}
			return _IPTCBylineTitle;
		}
	}

	[Field("kCGImagePropertyIPTCCity", "ImageIO")]
	public static NSString IPTCCity
	{
		get
		{
			if (_IPTCCity == null)
			{
				_IPTCCity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCity");
			}
			return _IPTCCity;
		}
	}

	[Field("kCGImagePropertyIPTCSubLocation", "ImageIO")]
	public static NSString IPTCSubLocation
	{
		get
		{
			if (_IPTCSubLocation == null)
			{
				_IPTCSubLocation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSubLocation");
			}
			return _IPTCSubLocation;
		}
	}

	[Field("kCGImagePropertyIPTCProvinceState", "ImageIO")]
	public static NSString IPTCProvinceState
	{
		get
		{
			if (_IPTCProvinceState == null)
			{
				_IPTCProvinceState = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCProvinceState");
			}
			return _IPTCProvinceState;
		}
	}

	[Field("kCGImagePropertyIPTCCountryPrimaryLocationCode", "ImageIO")]
	public static NSString IPTCCountryPrimaryLocationCode
	{
		get
		{
			if (_IPTCCountryPrimaryLocationCode == null)
			{
				_IPTCCountryPrimaryLocationCode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCountryPrimaryLocationCode");
			}
			return _IPTCCountryPrimaryLocationCode;
		}
	}

	[Field("kCGImagePropertyIPTCCountryPrimaryLocationName", "ImageIO")]
	public static NSString IPTCCountryPrimaryLocationName
	{
		get
		{
			if (_IPTCCountryPrimaryLocationName == null)
			{
				_IPTCCountryPrimaryLocationName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCountryPrimaryLocationName");
			}
			return _IPTCCountryPrimaryLocationName;
		}
	}

	[Field("kCGImagePropertyIPTCOriginalTransmissionReference", "ImageIO")]
	public static NSString IPTCOriginalTransmissionReference
	{
		get
		{
			if (_IPTCOriginalTransmissionReference == null)
			{
				_IPTCOriginalTransmissionReference = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCOriginalTransmissionReference");
			}
			return _IPTCOriginalTransmissionReference;
		}
	}

	[Field("kCGImagePropertyIPTCHeadline", "ImageIO")]
	public static NSString IPTCHeadline
	{
		get
		{
			if (_IPTCHeadline == null)
			{
				_IPTCHeadline = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCHeadline");
			}
			return _IPTCHeadline;
		}
	}

	[Field("kCGImagePropertyIPTCCredit", "ImageIO")]
	public static NSString IPTCCredit
	{
		get
		{
			if (_IPTCCredit == null)
			{
				_IPTCCredit = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCredit");
			}
			return _IPTCCredit;
		}
	}

	[Field("kCGImagePropertyIPTCSource", "ImageIO")]
	public static NSString IPTCSource
	{
		get
		{
			if (_IPTCSource == null)
			{
				_IPTCSource = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCSource");
			}
			return _IPTCSource;
		}
	}

	[Field("kCGImagePropertyIPTCCopyrightNotice", "ImageIO")]
	public static NSString IPTCCopyrightNotice
	{
		get
		{
			if (_IPTCCopyrightNotice == null)
			{
				_IPTCCopyrightNotice = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCopyrightNotice");
			}
			return _IPTCCopyrightNotice;
		}
	}

	[Field("kCGImagePropertyIPTCContact", "ImageIO")]
	public static NSString IPTCContact
	{
		get
		{
			if (_IPTCContact == null)
			{
				_IPTCContact = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContact");
			}
			return _IPTCContact;
		}
	}

	[Field("kCGImagePropertyIPTCCaptionAbstract", "ImageIO")]
	public static NSString IPTCCaptionAbstract
	{
		get
		{
			if (_IPTCCaptionAbstract == null)
			{
				_IPTCCaptionAbstract = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCaptionAbstract");
			}
			return _IPTCCaptionAbstract;
		}
	}

	[Field("kCGImagePropertyIPTCWriterEditor", "ImageIO")]
	public static NSString IPTCWriterEditor
	{
		get
		{
			if (_IPTCWriterEditor == null)
			{
				_IPTCWriterEditor = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCWriterEditor");
			}
			return _IPTCWriterEditor;
		}
	}

	[Field("kCGImagePropertyIPTCImageType", "ImageIO")]
	public static NSString IPTCImageType
	{
		get
		{
			if (_IPTCImageType == null)
			{
				_IPTCImageType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCImageType");
			}
			return _IPTCImageType;
		}
	}

	[Field("kCGImagePropertyIPTCImageOrientation", "ImageIO")]
	public static NSString IPTCImageOrientation
	{
		get
		{
			if (_IPTCImageOrientation == null)
			{
				_IPTCImageOrientation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCImageOrientation");
			}
			return _IPTCImageOrientation;
		}
	}

	[Field("kCGImagePropertyIPTCLanguageIdentifier", "ImageIO")]
	public static NSString IPTCLanguageIdentifier
	{
		get
		{
			if (_IPTCLanguageIdentifier == null)
			{
				_IPTCLanguageIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCLanguageIdentifier");
			}
			return _IPTCLanguageIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCStarRating", "ImageIO")]
	public static NSString IPTCStarRating
	{
		get
		{
			if (_IPTCStarRating == null)
			{
				_IPTCStarRating = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCStarRating");
			}
			return _IPTCStarRating;
		}
	}

	[Field("kCGImagePropertyIPTCCreatorContactInfo", "ImageIO")]
	public static NSString IPTCCreatorContactInfo
	{
		get
		{
			if (_IPTCCreatorContactInfo == null)
			{
				_IPTCCreatorContactInfo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCCreatorContactInfo");
			}
			return _IPTCCreatorContactInfo;
		}
	}

	[Field("kCGImagePropertyIPTCRightsUsageTerms", "ImageIO")]
	public static NSString IPTCRightsUsageTerms
	{
		get
		{
			if (_IPTCRightsUsageTerms == null)
			{
				_IPTCRightsUsageTerms = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCRightsUsageTerms");
			}
			return _IPTCRightsUsageTerms;
		}
	}

	[Field("kCGImagePropertyIPTCScene", "ImageIO")]
	public static NSString IPTCScene
	{
		get
		{
			if (_IPTCScene == null)
			{
				_IPTCScene = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCScene");
			}
			return _IPTCScene;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoCity", "ImageIO")]
	public static NSString IPTCContactInfoCity
	{
		get
		{
			if (_IPTCContactInfoCity == null)
			{
				_IPTCContactInfoCity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoCity");
			}
			return _IPTCContactInfoCity;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoCountry", "ImageIO")]
	public static NSString IPTCContactInfoCountry
	{
		get
		{
			if (_IPTCContactInfoCountry == null)
			{
				_IPTCContactInfoCountry = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoCountry");
			}
			return _IPTCContactInfoCountry;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoAddress", "ImageIO")]
	public static NSString IPTCContactInfoAddress
	{
		get
		{
			if (_IPTCContactInfoAddress == null)
			{
				_IPTCContactInfoAddress = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoAddress");
			}
			return _IPTCContactInfoAddress;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoPostalCode", "ImageIO")]
	public static NSString IPTCContactInfoPostalCode
	{
		get
		{
			if (_IPTCContactInfoPostalCode == null)
			{
				_IPTCContactInfoPostalCode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoPostalCode");
			}
			return _IPTCContactInfoPostalCode;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoStateProvince", "ImageIO")]
	public static NSString IPTCContactInfoStateProvince
	{
		get
		{
			if (_IPTCContactInfoStateProvince == null)
			{
				_IPTCContactInfoStateProvince = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoStateProvince");
			}
			return _IPTCContactInfoStateProvince;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoEmails", "ImageIO")]
	public static NSString IPTCContactInfoEmails
	{
		get
		{
			if (_IPTCContactInfoEmails == null)
			{
				_IPTCContactInfoEmails = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoEmails");
			}
			return _IPTCContactInfoEmails;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoPhones", "ImageIO")]
	public static NSString IPTCContactInfoPhones
	{
		get
		{
			if (_IPTCContactInfoPhones == null)
			{
				_IPTCContactInfoPhones = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoPhones");
			}
			return _IPTCContactInfoPhones;
		}
	}

	[Field("kCGImagePropertyIPTCContactInfoWebURLs", "ImageIO")]
	public static NSString IPTCContactInfoWebURLs
	{
		get
		{
			if (_IPTCContactInfoWebURLs == null)
			{
				_IPTCContactInfoWebURLs = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCContactInfoWebURLs");
			}
			return _IPTCContactInfoWebURLs;
		}
	}

	[Field("kCGImagePropertyJFIFVersion", "ImageIO")]
	public static NSString JFIFVersion
	{
		get
		{
			if (_JFIFVersion == null)
			{
				_JFIFVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyJFIFVersion");
			}
			return _JFIFVersion;
		}
	}

	[Field("kCGImagePropertyJFIFXDensity", "ImageIO")]
	public static NSString JFIFXDensity
	{
		get
		{
			if (_JFIFXDensity == null)
			{
				_JFIFXDensity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyJFIFXDensity");
			}
			return _JFIFXDensity;
		}
	}

	[Field("kCGImagePropertyJFIFYDensity", "ImageIO")]
	public static NSString JFIFYDensity
	{
		get
		{
			if (_JFIFYDensity == null)
			{
				_JFIFYDensity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyJFIFYDensity");
			}
			return _JFIFYDensity;
		}
	}

	[Field("kCGImagePropertyJFIFDensityUnit", "ImageIO")]
	public static NSString JFIFDensityUnit
	{
		get
		{
			if (_JFIFDensityUnit == null)
			{
				_JFIFDensityUnit = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyJFIFDensityUnit");
			}
			return _JFIFDensityUnit;
		}
	}

	[Field("kCGImagePropertyJFIFIsProgressive", "ImageIO")]
	public static NSString JFIFIsProgressive
	{
		get
		{
			if (_JFIFIsProgressive == null)
			{
				_JFIFIsProgressive = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyJFIFIsProgressive");
			}
			return _JFIFIsProgressive;
		}
	}

	[Field("kCGImagePropertyPNGGamma", "ImageIO")]
	public static NSString PNGGamma
	{
		get
		{
			if (_PNGGamma == null)
			{
				_PNGGamma = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGGamma");
			}
			return _PNGGamma;
		}
	}

	[Field("kCGImagePropertyPNGInterlaceType", "ImageIO")]
	public static NSString PNGInterlaceType
	{
		get
		{
			if (_PNGInterlaceType == null)
			{
				_PNGInterlaceType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGInterlaceType");
			}
			return _PNGInterlaceType;
		}
	}

	[Field("kCGImagePropertyPNGXPixelsPerMeter", "ImageIO")]
	public static NSString PNGXPixelsPerMeter
	{
		get
		{
			if (_PNGXPixelsPerMeter == null)
			{
				_PNGXPixelsPerMeter = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGXPixelsPerMeter");
			}
			return _PNGXPixelsPerMeter;
		}
	}

	[Field("kCGImagePropertyPNGYPixelsPerMeter", "ImageIO")]
	public static NSString PNGYPixelsPerMeter
	{
		get
		{
			if (_PNGYPixelsPerMeter == null)
			{
				_PNGYPixelsPerMeter = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGYPixelsPerMeter");
			}
			return _PNGYPixelsPerMeter;
		}
	}

	[Field("kCGImagePropertyPNGsRGBIntent", "ImageIO")]
	public static NSString PNGsRGBIntent
	{
		get
		{
			if (_PNGsRGBIntent == null)
			{
				_PNGsRGBIntent = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGsRGBIntent");
			}
			return _PNGsRGBIntent;
		}
	}

	[Field("kCGImagePropertyPNGChromaticities", "ImageIO")]
	public static NSString PNGChromaticities
	{
		get
		{
			if (_PNGChromaticities == null)
			{
				_PNGChromaticities = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGChromaticities");
			}
			return _PNGChromaticities;
		}
	}

	[Field("kCGImagePropertyPNGAuthor", "ImageIO")]
	public static NSString PNGAuthor
	{
		get
		{
			if (_PNGAuthor == null)
			{
				_PNGAuthor = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGAuthor");
			}
			return _PNGAuthor;
		}
	}

	[Field("kCGImagePropertyPNGCopyright", "ImageIO")]
	public static NSString PNGCopyright
	{
		get
		{
			if (_PNGCopyright == null)
			{
				_PNGCopyright = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGCopyright");
			}
			return _PNGCopyright;
		}
	}

	[Field("kCGImagePropertyPNGCreationTime", "ImageIO")]
	public static NSString PNGCreationTime
	{
		get
		{
			if (_PNGCreationTime == null)
			{
				_PNGCreationTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGCreationTime");
			}
			return _PNGCreationTime;
		}
	}

	[Field("kCGImagePropertyPNGDescription", "ImageIO")]
	public static NSString PNGDescription
	{
		get
		{
			if (_PNGDescription == null)
			{
				_PNGDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGDescription");
			}
			return _PNGDescription;
		}
	}

	[Field("kCGImagePropertyPNGModificationTime", "ImageIO")]
	public static NSString PNGModificationTime
	{
		get
		{
			if (_PNGModificationTime == null)
			{
				_PNGModificationTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGModificationTime");
			}
			return _PNGModificationTime;
		}
	}

	[Field("kCGImagePropertyPNGSoftware", "ImageIO")]
	public static NSString PNGSoftware
	{
		get
		{
			if (_PNGSoftware == null)
			{
				_PNGSoftware = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGSoftware");
			}
			return _PNGSoftware;
		}
	}

	[Field("kCGImagePropertyPNGTitle", "ImageIO")]
	public static NSString PNGTitle
	{
		get
		{
			if (_PNGTitle == null)
			{
				_PNGTitle = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGTitle");
			}
			return _PNGTitle;
		}
	}

	[Field("kCGImagePropertyTIFFCompression", "ImageIO")]
	public static NSString TIFFCompression
	{
		get
		{
			if (_TIFFCompression == null)
			{
				_TIFFCompression = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFCompression");
			}
			return _TIFFCompression;
		}
	}

	[Field("kCGImagePropertyTIFFPhotometricInterpretation", "ImageIO")]
	public static NSString TIFFPhotometricInterpretation
	{
		get
		{
			if (_TIFFPhotometricInterpretation == null)
			{
				_TIFFPhotometricInterpretation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFPhotometricInterpretation");
			}
			return _TIFFPhotometricInterpretation;
		}
	}

	[Field("kCGImagePropertyTIFFDocumentName", "ImageIO")]
	public static NSString TIFFDocumentName
	{
		get
		{
			if (_TIFFDocumentName == null)
			{
				_TIFFDocumentName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFDocumentName");
			}
			return _TIFFDocumentName;
		}
	}

	[Field("kCGImagePropertyTIFFImageDescription", "ImageIO")]
	public static NSString TIFFImageDescription
	{
		get
		{
			if (_TIFFImageDescription == null)
			{
				_TIFFImageDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFImageDescription");
			}
			return _TIFFImageDescription;
		}
	}

	[Field("kCGImagePropertyTIFFMake", "ImageIO")]
	public static NSString TIFFMake
	{
		get
		{
			if (_TIFFMake == null)
			{
				_TIFFMake = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFMake");
			}
			return _TIFFMake;
		}
	}

	[Field("kCGImagePropertyTIFFModel", "ImageIO")]
	public static NSString TIFFModel
	{
		get
		{
			if (_TIFFModel == null)
			{
				_TIFFModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFModel");
			}
			return _TIFFModel;
		}
	}

	[Field("kCGImagePropertyTIFFOrientation", "ImageIO")]
	public static NSString TIFFOrientation
	{
		get
		{
			if (_TIFFOrientation == null)
			{
				_TIFFOrientation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFOrientation");
			}
			return _TIFFOrientation;
		}
	}

	[Field("kCGImagePropertyTIFFXResolution", "ImageIO")]
	public static NSString TIFFXResolution
	{
		get
		{
			if (_TIFFXResolution == null)
			{
				_TIFFXResolution = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFXResolution");
			}
			return _TIFFXResolution;
		}
	}

	[Field("kCGImagePropertyTIFFYResolution", "ImageIO")]
	public static NSString TIFFYResolution
	{
		get
		{
			if (_TIFFYResolution == null)
			{
				_TIFFYResolution = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFYResolution");
			}
			return _TIFFYResolution;
		}
	}

	[Field("kCGImagePropertyTIFFResolutionUnit", "ImageIO")]
	public static NSString TIFFResolutionUnit
	{
		get
		{
			if (_TIFFResolutionUnit == null)
			{
				_TIFFResolutionUnit = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFResolutionUnit");
			}
			return _TIFFResolutionUnit;
		}
	}

	[Field("kCGImagePropertyTIFFSoftware", "ImageIO")]
	public static NSString TIFFSoftware
	{
		get
		{
			if (_TIFFSoftware == null)
			{
				_TIFFSoftware = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFSoftware");
			}
			return _TIFFSoftware;
		}
	}

	[Field("kCGImagePropertyTIFFTransferFunction", "ImageIO")]
	public static NSString TIFFTransferFunction
	{
		get
		{
			if (_TIFFTransferFunction == null)
			{
				_TIFFTransferFunction = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFTransferFunction");
			}
			return _TIFFTransferFunction;
		}
	}

	[Field("kCGImagePropertyTIFFDateTime", "ImageIO")]
	public static NSString TIFFDateTime
	{
		get
		{
			if (_TIFFDateTime == null)
			{
				_TIFFDateTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFDateTime");
			}
			return _TIFFDateTime;
		}
	}

	[Field("kCGImagePropertyTIFFArtist", "ImageIO")]
	public static NSString TIFFArtist
	{
		get
		{
			if (_TIFFArtist == null)
			{
				_TIFFArtist = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFArtist");
			}
			return _TIFFArtist;
		}
	}

	[Field("kCGImagePropertyTIFFHostComputer", "ImageIO")]
	public static NSString TIFFHostComputer
	{
		get
		{
			if (_TIFFHostComputer == null)
			{
				_TIFFHostComputer = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFHostComputer");
			}
			return _TIFFHostComputer;
		}
	}

	[Field("kCGImagePropertyTIFFWhitePoint", "ImageIO")]
	public static NSString TIFFWhitePoint
	{
		get
		{
			if (_TIFFWhitePoint == null)
			{
				_TIFFWhitePoint = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFWhitePoint");
			}
			return _TIFFWhitePoint;
		}
	}

	[Field("kCGImagePropertyTIFFPrimaryChromaticities", "ImageIO")]
	public static NSString TIFFPrimaryChromaticities
	{
		get
		{
			if (_TIFFPrimaryChromaticities == null)
			{
				_TIFFPrimaryChromaticities = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFPrimaryChromaticities");
			}
			return _TIFFPrimaryChromaticities;
		}
	}

	[Field("kCGImagePropertyDNGVersion", "ImageIO")]
	public static NSString DNGVersion
	{
		get
		{
			if (_DNGVersion == null)
			{
				_DNGVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGVersion");
			}
			return _DNGVersion;
		}
	}

	[Field("kCGImagePropertyDNGBackwardVersion", "ImageIO")]
	public static NSString DNGBackwardVersion
	{
		get
		{
			if (_DNGBackwardVersion == null)
			{
				_DNGBackwardVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBackwardVersion");
			}
			return _DNGBackwardVersion;
		}
	}

	[Field("kCGImagePropertyDNGUniqueCameraModel", "ImageIO")]
	public static NSString DNGUniqueCameraModel
	{
		get
		{
			if (_DNGUniqueCameraModel == null)
			{
				_DNGUniqueCameraModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGUniqueCameraModel");
			}
			return _DNGUniqueCameraModel;
		}
	}

	[Field("kCGImagePropertyDNGLocalizedCameraModel", "ImageIO")]
	public static NSString DNGLocalizedCameraModel
	{
		get
		{
			if (_DNGLocalizedCameraModel == null)
			{
				_DNGLocalizedCameraModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGLocalizedCameraModel");
			}
			return _DNGLocalizedCameraModel;
		}
	}

	[Field("kCGImagePropertyDNGCameraSerialNumber", "ImageIO")]
	public static NSString DNGCameraSerialNumber
	{
		get
		{
			if (_DNGCameraSerialNumber == null)
			{
				_DNGCameraSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraSerialNumber");
			}
			return _DNGCameraSerialNumber;
		}
	}

	[Field("kCGImagePropertyDNGLensInfo", "ImageIO")]
	public static NSString DNGLensInfo
	{
		get
		{
			if (_DNGLensInfo == null)
			{
				_DNGLensInfo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGLensInfo");
			}
			return _DNGLensInfo;
		}
	}

	[Field("kCGImageProperty8BIMLayerNames", "ImageIO")]
	public static NSString EightBIMLayerNames
	{
		get
		{
			if (_EightBIMLayerNames == null)
			{
				_EightBIMLayerNames = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageProperty8BIMLayerNames");
			}
			return _EightBIMLayerNames;
		}
	}

	[Field("kCGImagePropertyCIFFDescription", "ImageIO")]
	public static NSString CIFFDescription
	{
		get
		{
			if (_CIFFDescription == null)
			{
				_CIFFDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFDescription");
			}
			return _CIFFDescription;
		}
	}

	[Field("kCGImagePropertyCIFFFirmware", "ImageIO")]
	public static NSString CIFFFirmware
	{
		get
		{
			if (_CIFFFirmware == null)
			{
				_CIFFFirmware = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFFirmware");
			}
			return _CIFFFirmware;
		}
	}

	[Field("kCGImagePropertyCIFFOwnerName", "ImageIO")]
	public static NSString CIFFOwnerName
	{
		get
		{
			if (_CIFFOwnerName == null)
			{
				_CIFFOwnerName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFOwnerName");
			}
			return _CIFFOwnerName;
		}
	}

	[Field("kCGImagePropertyCIFFImageName", "ImageIO")]
	public static NSString CIFFImageName
	{
		get
		{
			if (_CIFFImageName == null)
			{
				_CIFFImageName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFImageName");
			}
			return _CIFFImageName;
		}
	}

	[Field("kCGImagePropertyCIFFImageFileName", "ImageIO")]
	public static NSString CIFFImageFileName
	{
		get
		{
			if (_CIFFImageFileName == null)
			{
				_CIFFImageFileName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFImageFileName");
			}
			return _CIFFImageFileName;
		}
	}

	[Field("kCGImagePropertyCIFFReleaseMethod", "ImageIO")]
	public static NSString CIFFReleaseMethod
	{
		get
		{
			if (_CIFFReleaseMethod == null)
			{
				_CIFFReleaseMethod = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFReleaseMethod");
			}
			return _CIFFReleaseMethod;
		}
	}

	[Field("kCGImagePropertyCIFFReleaseTiming", "ImageIO")]
	public static NSString CIFFReleaseTiming
	{
		get
		{
			if (_CIFFReleaseTiming == null)
			{
				_CIFFReleaseTiming = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFReleaseTiming");
			}
			return _CIFFReleaseTiming;
		}
	}

	[Field("kCGImagePropertyCIFFRecordID", "ImageIO")]
	public static NSString CIFFRecordID
	{
		get
		{
			if (_CIFFRecordID == null)
			{
				_CIFFRecordID = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFRecordID");
			}
			return _CIFFRecordID;
		}
	}

	[Field("kCGImagePropertyCIFFSelfTimingTime", "ImageIO")]
	public static NSString CIFFSelfTimingTime
	{
		get
		{
			if (_CIFFSelfTimingTime == null)
			{
				_CIFFSelfTimingTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFSelfTimingTime");
			}
			return _CIFFSelfTimingTime;
		}
	}

	[Field("kCGImagePropertyCIFFCameraSerialNumber", "ImageIO")]
	public static NSString CIFFCameraSerialNumber
	{
		get
		{
			if (_CIFFCameraSerialNumber == null)
			{
				_CIFFCameraSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFCameraSerialNumber");
			}
			return _CIFFCameraSerialNumber;
		}
	}

	[Field("kCGImagePropertyCIFFImageSerialNumber", "ImageIO")]
	public static NSString CIFFImageSerialNumber
	{
		get
		{
			if (_CIFFImageSerialNumber == null)
			{
				_CIFFImageSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFImageSerialNumber");
			}
			return _CIFFImageSerialNumber;
		}
	}

	[Field("kCGImagePropertyCIFFContinuousDrive", "ImageIO")]
	public static NSString CIFFContinuousDrive
	{
		get
		{
			if (_CIFFContinuousDrive == null)
			{
				_CIFFContinuousDrive = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFContinuousDrive");
			}
			return _CIFFContinuousDrive;
		}
	}

	[Field("kCGImagePropertyCIFFFocusMode", "ImageIO")]
	public static NSString CIFFFocusMode
	{
		get
		{
			if (_CIFFFocusMode == null)
			{
				_CIFFFocusMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFFocusMode");
			}
			return _CIFFFocusMode;
		}
	}

	[Field("kCGImagePropertyCIFFMeteringMode", "ImageIO")]
	public static NSString CIFFMeteringMode
	{
		get
		{
			if (_CIFFMeteringMode == null)
			{
				_CIFFMeteringMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFMeteringMode");
			}
			return _CIFFMeteringMode;
		}
	}

	[Field("kCGImagePropertyCIFFShootingMode", "ImageIO")]
	public static NSString CIFFShootingMode
	{
		get
		{
			if (_CIFFShootingMode == null)
			{
				_CIFFShootingMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFShootingMode");
			}
			return _CIFFShootingMode;
		}
	}

	[Field("kCGImagePropertyCIFFLensMaxMM", "ImageIO")]
	public static NSString CIFFLensMaxMM
	{
		get
		{
			if (_CIFFLensMaxMM == null)
			{
				_CIFFLensMaxMM = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFLensMaxMM");
			}
			return _CIFFLensMaxMM;
		}
	}

	[Field("kCGImagePropertyCIFFLensMinMM", "ImageIO")]
	public static NSString CIFFLensMinMM
	{
		get
		{
			if (_CIFFLensMinMM == null)
			{
				_CIFFLensMinMM = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFLensMinMM");
			}
			return _CIFFLensMinMM;
		}
	}

	[Field("kCGImagePropertyCIFFLensModel", "ImageIO")]
	public static NSString CIFFLensModel
	{
		get
		{
			if (_CIFFLensModel == null)
			{
				_CIFFLensModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFLensModel");
			}
			return _CIFFLensModel;
		}
	}

	[Field("kCGImagePropertyCIFFWhiteBalanceIndex", "ImageIO")]
	public static NSString CIFFWhiteBalanceIndex
	{
		get
		{
			if (_CIFFWhiteBalanceIndex == null)
			{
				_CIFFWhiteBalanceIndex = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFWhiteBalanceIndex");
			}
			return _CIFFWhiteBalanceIndex;
		}
	}

	[Field("kCGImagePropertyCIFFFlashExposureComp", "ImageIO")]
	public static NSString CIFFFlashExposureComp
	{
		get
		{
			if (_CIFFFlashExposureComp == null)
			{
				_CIFFFlashExposureComp = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFFlashExposureComp");
			}
			return _CIFFFlashExposureComp;
		}
	}

	[Field("kCGImagePropertyCIFFMeasuredEV", "ImageIO")]
	public static NSString CIFFMeasuredEV
	{
		get
		{
			if (_CIFFMeasuredEV == null)
			{
				_CIFFMeasuredEV = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyCIFFMeasuredEV");
			}
			return _CIFFMeasuredEV;
		}
	}

	[Field("kCGImagePropertyMakerNikonISOSetting", "ImageIO")]
	public static NSString MakerNikonISOSetting
	{
		get
		{
			if (_MakerNikonISOSetting == null)
			{
				_MakerNikonISOSetting = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonISOSetting");
			}
			return _MakerNikonISOSetting;
		}
	}

	[Field("kCGImagePropertyMakerNikonColorMode", "ImageIO")]
	public static NSString MakerNikonColorMode
	{
		get
		{
			if (_MakerNikonColorMode == null)
			{
				_MakerNikonColorMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonColorMode");
			}
			return _MakerNikonColorMode;
		}
	}

	[Field("kCGImagePropertyMakerNikonQuality", "ImageIO")]
	public static NSString MakerNikonQuality
	{
		get
		{
			if (_MakerNikonQuality == null)
			{
				_MakerNikonQuality = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonQuality");
			}
			return _MakerNikonQuality;
		}
	}

	[Field("kCGImagePropertyMakerNikonWhiteBalanceMode", "ImageIO")]
	public static NSString MakerNikonWhiteBalanceMode
	{
		get
		{
			if (_MakerNikonWhiteBalanceMode == null)
			{
				_MakerNikonWhiteBalanceMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonWhiteBalanceMode");
			}
			return _MakerNikonWhiteBalanceMode;
		}
	}

	[Field("kCGImagePropertyMakerNikonSharpenMode", "ImageIO")]
	public static NSString MakerNikonSharpenMode
	{
		get
		{
			if (_MakerNikonSharpenMode == null)
			{
				_MakerNikonSharpenMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonSharpenMode");
			}
			return _MakerNikonSharpenMode;
		}
	}

	[Field("kCGImagePropertyMakerNikonFocusMode", "ImageIO")]
	public static NSString MakerNikonFocusMode
	{
		get
		{
			if (_MakerNikonFocusMode == null)
			{
				_MakerNikonFocusMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFocusMode");
			}
			return _MakerNikonFocusMode;
		}
	}

	[Field("kCGImagePropertyMakerNikonFlashSetting", "ImageIO")]
	public static NSString MakerNikonFlashSetting
	{
		get
		{
			if (_MakerNikonFlashSetting == null)
			{
				_MakerNikonFlashSetting = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFlashSetting");
			}
			return _MakerNikonFlashSetting;
		}
	}

	[Field("kCGImagePropertyMakerNikonISOSelection", "ImageIO")]
	public static NSString MakerNikonISOSelection
	{
		get
		{
			if (_MakerNikonISOSelection == null)
			{
				_MakerNikonISOSelection = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonISOSelection");
			}
			return _MakerNikonISOSelection;
		}
	}

	[Field("kCGImagePropertyMakerNikonFlashExposureComp", "ImageIO")]
	public static NSString MakerNikonFlashExposureComp
	{
		get
		{
			if (_MakerNikonFlashExposureComp == null)
			{
				_MakerNikonFlashExposureComp = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFlashExposureComp");
			}
			return _MakerNikonFlashExposureComp;
		}
	}

	[Field("kCGImagePropertyMakerNikonImageAdjustment", "ImageIO")]
	public static NSString MakerNikonImageAdjustment
	{
		get
		{
			if (_MakerNikonImageAdjustment == null)
			{
				_MakerNikonImageAdjustment = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonImageAdjustment");
			}
			return _MakerNikonImageAdjustment;
		}
	}

	[Field("kCGImagePropertyMakerNikonLensAdapter", "ImageIO")]
	public static NSString MakerNikonLensAdapter
	{
		get
		{
			if (_MakerNikonLensAdapter == null)
			{
				_MakerNikonLensAdapter = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonLensAdapter");
			}
			return _MakerNikonLensAdapter;
		}
	}

	[Field("kCGImagePropertyMakerNikonLensType", "ImageIO")]
	public static NSString MakerNikonLensType
	{
		get
		{
			if (_MakerNikonLensType == null)
			{
				_MakerNikonLensType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonLensType");
			}
			return _MakerNikonLensType;
		}
	}

	[Field("kCGImagePropertyMakerNikonLensInfo", "ImageIO")]
	public static NSString MakerNikonLensInfo
	{
		get
		{
			if (_MakerNikonLensInfo == null)
			{
				_MakerNikonLensInfo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonLensInfo");
			}
			return _MakerNikonLensInfo;
		}
	}

	[Field("kCGImagePropertyMakerNikonFocusDistance", "ImageIO")]
	public static NSString MakerNikonFocusDistance
	{
		get
		{
			if (_MakerNikonFocusDistance == null)
			{
				_MakerNikonFocusDistance = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonFocusDistance");
			}
			return _MakerNikonFocusDistance;
		}
	}

	[Field("kCGImagePropertyMakerNikonDigitalZoom", "ImageIO")]
	public static NSString MakerNikonDigitalZoom
	{
		get
		{
			if (_MakerNikonDigitalZoom == null)
			{
				_MakerNikonDigitalZoom = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonDigitalZoom");
			}
			return _MakerNikonDigitalZoom;
		}
	}

	[Field("kCGImagePropertyMakerNikonShootingMode", "ImageIO")]
	public static NSString MakerNikonShootingMode
	{
		get
		{
			if (_MakerNikonShootingMode == null)
			{
				_MakerNikonShootingMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonShootingMode");
			}
			return _MakerNikonShootingMode;
		}
	}

	[Field("kCGImagePropertyMakerNikonShutterCount", "ImageIO")]
	public static NSString MakerNikonShutterCount
	{
		get
		{
			if (_MakerNikonShutterCount == null)
			{
				_MakerNikonShutterCount = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonShutterCount");
			}
			return _MakerNikonShutterCount;
		}
	}

	[Field("kCGImagePropertyMakerNikonCameraSerialNumber", "ImageIO")]
	public static NSString MakerNikonCameraSerialNumber
	{
		get
		{
			if (_MakerNikonCameraSerialNumber == null)
			{
				_MakerNikonCameraSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerNikonCameraSerialNumber");
			}
			return _MakerNikonCameraSerialNumber;
		}
	}

	[Field("kCGImagePropertyMakerCanonOwnerName", "ImageIO")]
	public static NSString MakerCanonOwnerName
	{
		get
		{
			if (_MakerCanonOwnerName == null)
			{
				_MakerCanonOwnerName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonOwnerName");
			}
			return _MakerCanonOwnerName;
		}
	}

	[Field("kCGImagePropertyMakerCanonCameraSerialNumber", "ImageIO")]
	public static NSString MakerCanonCameraSerialNumber
	{
		get
		{
			if (_MakerCanonCameraSerialNumber == null)
			{
				_MakerCanonCameraSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonCameraSerialNumber");
			}
			return _MakerCanonCameraSerialNumber;
		}
	}

	[Field("kCGImagePropertyMakerCanonImageSerialNumber", "ImageIO")]
	public static NSString MakerCanonImageSerialNumber
	{
		get
		{
			if (_MakerCanonImageSerialNumber == null)
			{
				_MakerCanonImageSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonImageSerialNumber");
			}
			return _MakerCanonImageSerialNumber;
		}
	}

	[Field("kCGImagePropertyMakerCanonFlashExposureComp", "ImageIO")]
	public static NSString MakerCanonFlashExposureComp
	{
		get
		{
			if (_MakerCanonFlashExposureComp == null)
			{
				_MakerCanonFlashExposureComp = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonFlashExposureComp");
			}
			return _MakerCanonFlashExposureComp;
		}
	}

	[Field("kCGImagePropertyMakerCanonContinuousDrive", "ImageIO")]
	public static NSString MakerCanonContinuousDrive
	{
		get
		{
			if (_MakerCanonContinuousDrive == null)
			{
				_MakerCanonContinuousDrive = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonContinuousDrive");
			}
			return _MakerCanonContinuousDrive;
		}
	}

	[Field("kCGImagePropertyMakerCanonLensModel", "ImageIO")]
	public static NSString MakerCanonLensModel
	{
		get
		{
			if (_MakerCanonLensModel == null)
			{
				_MakerCanonLensModel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonLensModel");
			}
			return _MakerCanonLensModel;
		}
	}

	[Field("kCGImagePropertyMakerCanonFirmware", "ImageIO")]
	public static NSString MakerCanonFirmware
	{
		get
		{
			if (_MakerCanonFirmware == null)
			{
				_MakerCanonFirmware = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonFirmware");
			}
			return _MakerCanonFirmware;
		}
	}

	[Field("kCGImagePropertyMakerCanonAspectRatioInfo", "ImageIO")]
	public static NSString MakerCanonAspectRatioInfo
	{
		get
		{
			if (_MakerCanonAspectRatioInfo == null)
			{
				_MakerCanonAspectRatioInfo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerCanonAspectRatioInfo");
			}
			return _MakerCanonAspectRatioInfo;
		}
	}
}
