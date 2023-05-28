using Foundation;
using ObjCRuntime;

namespace ImageIO;

public static class CGImageProperties
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApngCanvasPixelHeight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApngCanvasPixelWidth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApngFrameInfoArray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliaryData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliaryDataType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BytesPerRow;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFCameraSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFContinuousDrive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFFirmware;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFFlashExposureComp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFFocusMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFImageFileName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFImageName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFImageSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFLensMaxMM;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFLensMinMM;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFLensModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFMeasuredEV;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFMeteringMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFOwnerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFRecordID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFReleaseMethod;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFReleaseTiming;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFSelfTimingTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFShootingMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CIFFWhiteBalanceIndex;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorModelCMYK;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorModelGray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorModelLab;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorModelRGB;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGActiveArea;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGAnalogBalance;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGAntiAliasStrength;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGAsShotICCProfile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGAsShotNeutral;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGAsShotPreProfileMatrix;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGAsShotProfileName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGAsShotWhiteXY;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBackwardVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBaselineExposure;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBaselineExposureOffset;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBaselineNoise;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBaselineSharpness;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBayerGreenSplit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBestQualityScale;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBlackLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBlackLevelDeltaHorizontal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBlackLevelDeltaVertical;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGBlackLevelRepeatDim;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCalibrationIlluminant1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCalibrationIlluminant2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCameraCalibration1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCameraCalibration2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCameraCalibrationSignature;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCameraSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCfaLayout;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCfaPlaneColor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGChromaBlurRadius;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGColorMatrix1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGColorMatrix2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGColorimetricReference;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCurrentICCProfile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGCurrentPreProfileMatrix;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGDefaultBlackRender;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGDefaultCropOrigin;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGDefaultCropSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGDefaultScale;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGDefaultUserCrop;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGExtraCameraProfiles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGFixVignetteRadial;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGForwardMatrix1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGForwardMatrix2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGLensInfo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGLinearResponseLimit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGLinearizationTable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGLocalizedCameraModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGMakerNoteSafety;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGMaskedAreas;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGNewRawImageDigest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGNoiseProfile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGNoiseReductionApplied;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOpcodeList1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOpcodeList2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOpcodeList3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOriginalBestQualityFinalSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOriginalDefaultCropSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOriginalDefaultFinalSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOriginalRawFileData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOriginalRawFileDigest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGOriginalRawFileName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGPreviewApplicationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGPreviewApplicationVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGPreviewColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGPreviewDateTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGPreviewSettingsDigest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGPreviewSettingsName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGPrivateData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileCalibrationSignature;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileCopyright;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileEmbedPolicy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileHueSatMapData1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileHueSatMapData2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileHueSatMapDims;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileHueSatMapEncoding;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileLookTableData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileLookTableDims;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileLookTableEncoding;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGProfileToneCurve;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGRawDataUniqueId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGRawImageDigest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGRawToPreviewGain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGReductionMatrix1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGReductionMatrix2;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGRowInterleaveFactor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGShadowScale;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGSubTileBlockSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGUniqueCameraModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGWarpFisheye;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGWarpRectilinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DNGWhiteLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DPIHeight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DPIWidth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Depth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EightBIMDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EightBIMLayerNames;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifApertureValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxFirmware;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxFlashCompensation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxImageNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxLensID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxLensInfo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxLensModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxLensSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxOwnerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifAuxSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifBodySerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifBrightnessValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifCFAPattern;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifCameraOwnerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifComponentsConfiguration;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifCompressedBitsPerPixel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifContrast;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifCustomRendered;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifDateTimeDigitized;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifDateTimeOriginal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifDeviceSettingDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifDigitalZoomRatio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifExposureBiasValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifExposureIndex;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifExposureMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifExposureProgram;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifExposureTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFileSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFlash;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFlashEnergy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFlashPixVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFocalLenIn35mmFilm;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFocalLength;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFocalPlaneResolutionUnit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFocalPlaneXResolution;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifFocalPlaneYResolution;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifGainControl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifGamma;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifISOSpeed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifISOSpeedLatitudeYyy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifISOSpeedLatitudeZzz;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifISOSpeedRatings;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifImageUniqueID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifLensMake;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifLensModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifLensSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifLensSpecification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifLightSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifMakerNote;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifMaxApertureValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifMeteringMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifOECF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifOffsetTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifOffsetTimeDigitized;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifOffsetTimeOriginal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifPixelXDimension;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifPixelYDimension;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifRecommendedExposureIndex;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifRelatedSoundFile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSaturation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSceneCaptureType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSceneType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSensingMethod;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSensitivityType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSharpness;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifShutterSpeedValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSpatialFrequencyResponse;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSpectralSensitivity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifStandardOutputSensitivity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubjectArea;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubjectDistRange;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubjectDistance;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubjectLocation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubsecTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubsecTimeDigitized;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubsecTimeOrginal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifSubsecTimeOriginal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifUserComment;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExifWhiteBalance;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileContentsDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GIFDelayTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GIFDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GIFHasGlobalColorMap;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GIFImageColorMap;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GIFLoopCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GIFUnclampedDelayTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSAltitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSAltitudeRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSAreaInformation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDOP;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDateStamp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestBearing;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestBearingRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestDistance;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestDistanceRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestLatitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestLatitudeRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestLongitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDestLongitudeRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSDifferental;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSHPositioningError;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSImgDirection;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSImgDirectionRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSLatitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSLatitudeRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSLongitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSLongitudeRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSMapDatum;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSMeasureMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSSatellites;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSSpeed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSSpeedRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSStatus;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSTimeStamp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSTrack;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSTrackRef;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GPSVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GifCanvasPixelHeight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GifCanvasPixelWidth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GifFrameInfoArray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasAlpha;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeicsCanvasPixelHeight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeicsCanvasPixelWidth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeicsDelayTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeicsDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeicsFrameInfoArray;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeicsLoopCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeicsSUnclampedDelayTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Height;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCActionAdvised;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCByline;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCBylineTitle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCaptionAbstract;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCategory;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContact;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoAddress;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoCity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoCountry;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoEmails;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoPhones;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoPostalCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoStateProvince;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContactInfoWebURLs;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContentLocationCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCContentLocationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCopyrightNotice;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCountryPrimaryLocationCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCountryPrimaryLocationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCreatorContactInfo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCCredit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCDateCreated;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCDigitalCreationDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCDigitalCreationTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCEditStatus;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCEditorialUpdate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExpirationDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExpirationTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAboutCvTerm;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAboutCvTermCvId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAboutCvTermId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAboutCvTermName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAboutCvTermRefinedAbout;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAddlModelInfo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkCircaDateCreated;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkContentDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkContributionDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkCopyrightNotice;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkCopyrightOwnerId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkCopyrightOwnerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkCreator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkCreatorId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkDateCreated;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkLicensorId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkLicensorName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkOrObject;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkPhysicalDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkSourceInvUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkSourceInventoryNo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkStylePeriod;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtArtworkTitle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAudioBitrate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAudioBitrateMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtAudioChannelCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtCircaDateCreated;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtContainerFormat;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtContainerFormatIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtContainerFormatName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtContributor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtContributorIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtContributorName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtContributorRole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtControlledVocabularyTerm;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtCopyrightYear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtCreator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtCreatorIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtCreatorName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtCreatorRole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreen;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegionD;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegionH;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegionText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegionUnit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegionW;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegionX;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDataOnScreenRegionY;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDigitalImageGuid;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDigitalSourceFileType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDigitalSourceType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDopesheet;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDopesheetLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDopesheetLinkLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtDopesheetLinkLinkQualifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEmbdEncRightsExpr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEmbeddedEncodedRightsExpr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEmbeddedEncodedRightsExprLangId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEmbeddedEncodedRightsExprType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEpisode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEpisodeIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEpisodeName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEpisodeNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtEvent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtExternalMetadataLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtFeedIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtGenre;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtGenreCvId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtGenreCvTermId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtGenreCvTermName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtGenreCvTermRefinedAbout;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtHeadline;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtIPTCLastEdited;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLinkedEncRightsExpr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLinkedEncodedRightsExpr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLinkedEncodedRightsExprLangId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLinkedEncodedRightsExprType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationCity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationCountryCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationCountryName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationCreated;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationGpsAltitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationGpsLatitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationGpsLongitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationLocationId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationLocationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationProvinceState;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationShown;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationSublocation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtLocationWorldRegion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtMaxAvailHeight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtMaxAvailWidth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtModelAge;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtOrganisationInImageCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtOrganisationInImageName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonHeard;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonHeardIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonHeardName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageCharacteristic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageCvTermCvId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageCvTermId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageCvTermName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageCvTermRefinedAbout;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPersonInImageWDetails;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtProductInImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtProductInImageDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtProductInImageGtin;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtProductInImageName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPublicationEvent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPublicationEventDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPublicationEventIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtPublicationEventName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRating;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRatingRegion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionCity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionCountryCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionCountryName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionGpsAltitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionGpsLatitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionGpsLongitude;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionLocationId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionLocationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionProvinceState;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionSublocation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingRegionWorldRegion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingScaleMaxValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingScaleMinValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingSourceLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRatingValueLogoLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRegistryEntryRole;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRegistryId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRegistryItemId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtRegistryOrganisationId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtReleaseReady;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSeason;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSeasonIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSeasonName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSeasonNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSeries;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSeriesIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSeriesName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtShownEvent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtShownEventIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtShownEventName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtStorylineIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtStreamReady;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtStylePeriod;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSupplyChainSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSupplyChainSourceIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtSupplyChainSourceName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtTemporalCoverage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtTemporalCoverageFrom;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtTemporalCoverageTo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtTranscript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtTranscriptLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtTranscriptLinkLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtTranscriptLinkLinkQualifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoBitrate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoBitrateMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoDisplayAspectRatio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoEncodingProfile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoShotType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoShotTypeIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoShotTypeName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVideoStreamsCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtVisualColor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtWorkflowTag;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtWorkflowTagCvId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtWorkflowTagCvTermId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtWorkflowTagCvTermName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCExtWorkflowTagCvTermRefinedAbout;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCFixtureIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCHeadline;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCImageOrientation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCImageType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCKeywords;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCLanguageIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCObjectAttributeReference;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCObjectCycle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCObjectName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCObjectTypeReference;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCOriginalTransmissionReference;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCOriginatingProgram;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCProgramVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCProvinceState;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCReferenceDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCReferenceNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCReferenceService;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCReleaseDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCReleaseTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCRightsUsageTerms;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCScene;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCSpecialInstructions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCStarRating;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCSubLocation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCSubjectReference;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCSupplementalCategory;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCTimeCreated;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCUrgency;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IPTCWriterEditor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Images;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsFloat;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsIndexed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JFIFDensityUnit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JFIFDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JFIFIsProgressive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JFIFVersion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JFIFXDensity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JFIFYDensity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonAspectRatioInfo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonCameraSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonContinuousDrive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonFirmware;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonFlashExposureComp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonImageSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonLensModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerCanonOwnerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerFujiDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerMinoltaDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonCameraSerialNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonColorMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonDigitalZoom;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonFlashExposureComp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonFlashSetting;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonFocusDistance;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonFocusMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonISOSelection;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonISOSetting;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonImageAdjustment;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonLensAdapter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonLensInfo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonLensType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonSharpenMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonShootingMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonShutterCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerNikonWhiteBalanceMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerOlympusDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MakerPentaxDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NamedColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OpenExrAspectRatio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OpenExrDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Orientation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGAuthor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGChromaticities;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGComment;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGCompressionFilter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGCopyright;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGCreationTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGDelayTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGDisclaimer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGGamma;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGInterlaceType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGLoopCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGModificationTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGSoftware;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGTitle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGUnclampedDelayTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGWarning;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGXPixelsPerMeter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGYPixelsPerMeter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNGsRGBIntent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelFormat;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelHeight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelWidth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PrimaryImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RawDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFArtist;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFCompression;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFDateTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFDictionary;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFDocumentName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFHostComputer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFImageDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFMake;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFModel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFOrientation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFPhotometricInterpretation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFPrimaryChromaticities;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFResolutionUnit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFSoftware;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFTileLength;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFTileWidth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFTransferFunction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFWhitePoint;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFXResolution;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFFYResolution;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThumbnailImages;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Width;

	[Field("kCGImagePropertyAPNGCanvasPixelHeight", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString ApngCanvasPixelHeight
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_ApngCanvasPixelHeight == null)
			{
				_ApngCanvasPixelHeight = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAPNGCanvasPixelHeight");
			}
			return _ApngCanvasPixelHeight;
		}
	}

	[Field("kCGImagePropertyAPNGCanvasPixelWidth", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString ApngCanvasPixelWidth
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_ApngCanvasPixelWidth == null)
			{
				_ApngCanvasPixelWidth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAPNGCanvasPixelWidth");
			}
			return _ApngCanvasPixelWidth;
		}
	}

	[Field("kCGImagePropertyAPNGFrameInfoArray", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString ApngFrameInfoArray
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_ApngFrameInfoArray == null)
			{
				_ApngFrameInfoArray = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAPNGFrameInfoArray");
			}
			return _ApngFrameInfoArray;
		}
	}

	[Field("kCGImagePropertyAuxiliaryData", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString AuxiliaryData
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliaryData == null)
			{
				_AuxiliaryData = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAuxiliaryData");
			}
			return _AuxiliaryData;
		}
	}

	[Field("kCGImagePropertyAuxiliaryDataType", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString AuxiliaryDataType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliaryDataType == null)
			{
				_AuxiliaryDataType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAuxiliaryDataType");
			}
			return _AuxiliaryDataType;
		}
	}

	[Field("kCGImagePropertyBytesPerRow", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString BytesPerRow
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BytesPerRow == null)
			{
				_BytesPerRow = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyBytesPerRow");
			}
			return _BytesPerRow;
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

	[Field("kCGImagePropertyDNGActiveArea", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGActiveArea
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGActiveArea == null)
			{
				_DNGActiveArea = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGActiveArea");
			}
			return _DNGActiveArea;
		}
	}

	[Field("kCGImagePropertyDNGAnalogBalance", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGAnalogBalance
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGAnalogBalance == null)
			{
				_DNGAnalogBalance = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGAnalogBalance");
			}
			return _DNGAnalogBalance;
		}
	}

	[Field("kCGImagePropertyDNGAntiAliasStrength", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGAntiAliasStrength
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGAntiAliasStrength == null)
			{
				_DNGAntiAliasStrength = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGAntiAliasStrength");
			}
			return _DNGAntiAliasStrength;
		}
	}

	[Field("kCGImagePropertyDNGAsShotICCProfile", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGAsShotICCProfile
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGAsShotICCProfile == null)
			{
				_DNGAsShotICCProfile = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotICCProfile");
			}
			return _DNGAsShotICCProfile;
		}
	}

	[Field("kCGImagePropertyDNGAsShotNeutral", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGAsShotNeutral
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGAsShotNeutral == null)
			{
				_DNGAsShotNeutral = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotNeutral");
			}
			return _DNGAsShotNeutral;
		}
	}

	[Field("kCGImagePropertyDNGAsShotPreProfileMatrix", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGAsShotPreProfileMatrix
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGAsShotPreProfileMatrix == null)
			{
				_DNGAsShotPreProfileMatrix = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotPreProfileMatrix");
			}
			return _DNGAsShotPreProfileMatrix;
		}
	}

	[Field("kCGImagePropertyDNGAsShotProfileName", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGAsShotProfileName
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGAsShotProfileName == null)
			{
				_DNGAsShotProfileName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotProfileName");
			}
			return _DNGAsShotProfileName;
		}
	}

	[Field("kCGImagePropertyDNGAsShotWhiteXY", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGAsShotWhiteXY
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGAsShotWhiteXY == null)
			{
				_DNGAsShotWhiteXY = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGAsShotWhiteXY");
			}
			return _DNGAsShotWhiteXY;
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

	[Field("kCGImagePropertyDNGBaselineExposure", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBaselineExposure
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBaselineExposure == null)
			{
				_DNGBaselineExposure = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineExposure");
			}
			return _DNGBaselineExposure;
		}
	}

	[Field("kCGImagePropertyDNGBaselineExposureOffset", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBaselineExposureOffset
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBaselineExposureOffset == null)
			{
				_DNGBaselineExposureOffset = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineExposureOffset");
			}
			return _DNGBaselineExposureOffset;
		}
	}

	[Field("kCGImagePropertyDNGBaselineNoise", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBaselineNoise
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBaselineNoise == null)
			{
				_DNGBaselineNoise = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineNoise");
			}
			return _DNGBaselineNoise;
		}
	}

	[Field("kCGImagePropertyDNGBaselineSharpness", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBaselineSharpness
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBaselineSharpness == null)
			{
				_DNGBaselineSharpness = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBaselineSharpness");
			}
			return _DNGBaselineSharpness;
		}
	}

	[Field("kCGImagePropertyDNGBayerGreenSplit", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBayerGreenSplit
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBayerGreenSplit == null)
			{
				_DNGBayerGreenSplit = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBayerGreenSplit");
			}
			return _DNGBayerGreenSplit;
		}
	}

	[Field("kCGImagePropertyDNGBestQualityScale", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBestQualityScale
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBestQualityScale == null)
			{
				_DNGBestQualityScale = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBestQualityScale");
			}
			return _DNGBestQualityScale;
		}
	}

	[Field("kCGImagePropertyDNGBlackLevel", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBlackLevel
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBlackLevel == null)
			{
				_DNGBlackLevel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevel");
			}
			return _DNGBlackLevel;
		}
	}

	[Field("kCGImagePropertyDNGBlackLevelDeltaH", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBlackLevelDeltaHorizontal
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBlackLevelDeltaHorizontal == null)
			{
				_DNGBlackLevelDeltaHorizontal = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevelDeltaH");
			}
			return _DNGBlackLevelDeltaHorizontal;
		}
	}

	[Field("kCGImagePropertyDNGBlackLevelDeltaV", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBlackLevelDeltaVertical
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBlackLevelDeltaVertical == null)
			{
				_DNGBlackLevelDeltaVertical = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevelDeltaV");
			}
			return _DNGBlackLevelDeltaVertical;
		}
	}

	[Field("kCGImagePropertyDNGBlackLevelRepeatDim", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGBlackLevelRepeatDim
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGBlackLevelRepeatDim == null)
			{
				_DNGBlackLevelRepeatDim = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGBlackLevelRepeatDim");
			}
			return _DNGBlackLevelRepeatDim;
		}
	}

	[Field("kCGImagePropertyDNGCalibrationIlluminant1", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCalibrationIlluminant1
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCalibrationIlluminant1 == null)
			{
				_DNGCalibrationIlluminant1 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCalibrationIlluminant1");
			}
			return _DNGCalibrationIlluminant1;
		}
	}

	[Field("kCGImagePropertyDNGCalibrationIlluminant2", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCalibrationIlluminant2
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCalibrationIlluminant2 == null)
			{
				_DNGCalibrationIlluminant2 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCalibrationIlluminant2");
			}
			return _DNGCalibrationIlluminant2;
		}
	}

	[Field("kCGImagePropertyDNGCameraCalibration1", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCameraCalibration1
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCameraCalibration1 == null)
			{
				_DNGCameraCalibration1 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraCalibration1");
			}
			return _DNGCameraCalibration1;
		}
	}

	[Field("kCGImagePropertyDNGCameraCalibration2", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCameraCalibration2
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCameraCalibration2 == null)
			{
				_DNGCameraCalibration2 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraCalibration2");
			}
			return _DNGCameraCalibration2;
		}
	}

	[Field("kCGImagePropertyDNGCameraCalibrationSignature", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCameraCalibrationSignature
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCameraCalibrationSignature == null)
			{
				_DNGCameraCalibrationSignature = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCameraCalibrationSignature");
			}
			return _DNGCameraCalibrationSignature;
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

	[Field("kCGImagePropertyDNGCFALayout", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCfaLayout
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCfaLayout == null)
			{
				_DNGCfaLayout = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCFALayout");
			}
			return _DNGCfaLayout;
		}
	}

	[Field("kCGImagePropertyDNGCFAPlaneColor", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCfaPlaneColor
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCfaPlaneColor == null)
			{
				_DNGCfaPlaneColor = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCFAPlaneColor");
			}
			return _DNGCfaPlaneColor;
		}
	}

	[Field("kCGImagePropertyDNGChromaBlurRadius", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGChromaBlurRadius
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGChromaBlurRadius == null)
			{
				_DNGChromaBlurRadius = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGChromaBlurRadius");
			}
			return _DNGChromaBlurRadius;
		}
	}

	[Field("kCGImagePropertyDNGColorMatrix1", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGColorMatrix1
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGColorMatrix1 == null)
			{
				_DNGColorMatrix1 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGColorMatrix1");
			}
			return _DNGColorMatrix1;
		}
	}

	[Field("kCGImagePropertyDNGColorMatrix2", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGColorMatrix2
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGColorMatrix2 == null)
			{
				_DNGColorMatrix2 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGColorMatrix2");
			}
			return _DNGColorMatrix2;
		}
	}

	[Field("kCGImagePropertyDNGColorimetricReference", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGColorimetricReference
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGColorimetricReference == null)
			{
				_DNGColorimetricReference = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGColorimetricReference");
			}
			return _DNGColorimetricReference;
		}
	}

	[Field("kCGImagePropertyDNGCurrentICCProfile", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCurrentICCProfile
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCurrentICCProfile == null)
			{
				_DNGCurrentICCProfile = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCurrentICCProfile");
			}
			return _DNGCurrentICCProfile;
		}
	}

	[Field("kCGImagePropertyDNGCurrentPreProfileMatrix", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGCurrentPreProfileMatrix
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGCurrentPreProfileMatrix == null)
			{
				_DNGCurrentPreProfileMatrix = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGCurrentPreProfileMatrix");
			}
			return _DNGCurrentPreProfileMatrix;
		}
	}

	[Field("kCGImagePropertyDNGDefaultBlackRender", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGDefaultBlackRender
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGDefaultBlackRender == null)
			{
				_DNGDefaultBlackRender = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultBlackRender");
			}
			return _DNGDefaultBlackRender;
		}
	}

	[Field("kCGImagePropertyDNGDefaultCropOrigin", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGDefaultCropOrigin
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGDefaultCropOrigin == null)
			{
				_DNGDefaultCropOrigin = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultCropOrigin");
			}
			return _DNGDefaultCropOrigin;
		}
	}

	[Field("kCGImagePropertyDNGDefaultCropSize", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGDefaultCropSize
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGDefaultCropSize == null)
			{
				_DNGDefaultCropSize = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultCropSize");
			}
			return _DNGDefaultCropSize;
		}
	}

	[Field("kCGImagePropertyDNGDefaultScale", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGDefaultScale
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGDefaultScale == null)
			{
				_DNGDefaultScale = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultScale");
			}
			return _DNGDefaultScale;
		}
	}

	[Field("kCGImagePropertyDNGDefaultUserCrop", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGDefaultUserCrop
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGDefaultUserCrop == null)
			{
				_DNGDefaultUserCrop = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGDefaultUserCrop");
			}
			return _DNGDefaultUserCrop;
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

	[Field("kCGImagePropertyDNGExtraCameraProfiles", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGExtraCameraProfiles
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGExtraCameraProfiles == null)
			{
				_DNGExtraCameraProfiles = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGExtraCameraProfiles");
			}
			return _DNGExtraCameraProfiles;
		}
	}

	[Field("kCGImagePropertyDNGFixVignetteRadial", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGFixVignetteRadial
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGFixVignetteRadial == null)
			{
				_DNGFixVignetteRadial = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGFixVignetteRadial");
			}
			return _DNGFixVignetteRadial;
		}
	}

	[Field("kCGImagePropertyDNGForwardMatrix1", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGForwardMatrix1
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGForwardMatrix1 == null)
			{
				_DNGForwardMatrix1 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGForwardMatrix1");
			}
			return _DNGForwardMatrix1;
		}
	}

	[Field("kCGImagePropertyDNGForwardMatrix2", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGForwardMatrix2
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGForwardMatrix2 == null)
			{
				_DNGForwardMatrix2 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGForwardMatrix2");
			}
			return _DNGForwardMatrix2;
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

	[Field("kCGImagePropertyDNGLinearResponseLimit", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGLinearResponseLimit
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGLinearResponseLimit == null)
			{
				_DNGLinearResponseLimit = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGLinearResponseLimit");
			}
			return _DNGLinearResponseLimit;
		}
	}

	[Field("kCGImagePropertyDNGLinearizationTable", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGLinearizationTable
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGLinearizationTable == null)
			{
				_DNGLinearizationTable = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGLinearizationTable");
			}
			return _DNGLinearizationTable;
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

	[Field("kCGImagePropertyDNGMakerNoteSafety", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGMakerNoteSafety
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGMakerNoteSafety == null)
			{
				_DNGMakerNoteSafety = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGMakerNoteSafety");
			}
			return _DNGMakerNoteSafety;
		}
	}

	[Field("kCGImagePropertyDNGMaskedAreas", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGMaskedAreas
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGMaskedAreas == null)
			{
				_DNGMaskedAreas = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGMaskedAreas");
			}
			return _DNGMaskedAreas;
		}
	}

	[Field("kCGImagePropertyDNGNewRawImageDigest", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGNewRawImageDigest
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGNewRawImageDigest == null)
			{
				_DNGNewRawImageDigest = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGNewRawImageDigest");
			}
			return _DNGNewRawImageDigest;
		}
	}

	[Field("kCGImagePropertyDNGNoiseProfile", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGNoiseProfile
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGNoiseProfile == null)
			{
				_DNGNoiseProfile = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGNoiseProfile");
			}
			return _DNGNoiseProfile;
		}
	}

	[Field("kCGImagePropertyDNGNoiseReductionApplied", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGNoiseReductionApplied
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGNoiseReductionApplied == null)
			{
				_DNGNoiseReductionApplied = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGNoiseReductionApplied");
			}
			return _DNGNoiseReductionApplied;
		}
	}

	[Field("kCGImagePropertyDNGOpcodeList1", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOpcodeList1
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOpcodeList1 == null)
			{
				_DNGOpcodeList1 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOpcodeList1");
			}
			return _DNGOpcodeList1;
		}
	}

	[Field("kCGImagePropertyDNGOpcodeList2", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOpcodeList2
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOpcodeList2 == null)
			{
				_DNGOpcodeList2 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOpcodeList2");
			}
			return _DNGOpcodeList2;
		}
	}

	[Field("kCGImagePropertyDNGOpcodeList3", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOpcodeList3
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOpcodeList3 == null)
			{
				_DNGOpcodeList3 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOpcodeList3");
			}
			return _DNGOpcodeList3;
		}
	}

	[Field("kCGImagePropertyDNGOriginalBestQualityFinalSize", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOriginalBestQualityFinalSize
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOriginalBestQualityFinalSize == null)
			{
				_DNGOriginalBestQualityFinalSize = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalBestQualityFinalSize");
			}
			return _DNGOriginalBestQualityFinalSize;
		}
	}

	[Field("kCGImagePropertyDNGOriginalDefaultCropSize", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOriginalDefaultCropSize
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOriginalDefaultCropSize == null)
			{
				_DNGOriginalDefaultCropSize = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalDefaultCropSize");
			}
			return _DNGOriginalDefaultCropSize;
		}
	}

	[Field("kCGImagePropertyDNGOriginalDefaultFinalSize", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOriginalDefaultFinalSize
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOriginalDefaultFinalSize == null)
			{
				_DNGOriginalDefaultFinalSize = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalDefaultFinalSize");
			}
			return _DNGOriginalDefaultFinalSize;
		}
	}

	[Field("kCGImagePropertyDNGOriginalRawFileData", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOriginalRawFileData
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOriginalRawFileData == null)
			{
				_DNGOriginalRawFileData = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalRawFileData");
			}
			return _DNGOriginalRawFileData;
		}
	}

	[Field("kCGImagePropertyDNGOriginalRawFileDigest", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOriginalRawFileDigest
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOriginalRawFileDigest == null)
			{
				_DNGOriginalRawFileDigest = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalRawFileDigest");
			}
			return _DNGOriginalRawFileDigest;
		}
	}

	[Field("kCGImagePropertyDNGOriginalRawFileName", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGOriginalRawFileName
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGOriginalRawFileName == null)
			{
				_DNGOriginalRawFileName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGOriginalRawFileName");
			}
			return _DNGOriginalRawFileName;
		}
	}

	[Field("kCGImagePropertyDNGPreviewApplicationName", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGPreviewApplicationName
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGPreviewApplicationName == null)
			{
				_DNGPreviewApplicationName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewApplicationName");
			}
			return _DNGPreviewApplicationName;
		}
	}

	[Field("kCGImagePropertyDNGPreviewApplicationVersion", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGPreviewApplicationVersion
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGPreviewApplicationVersion == null)
			{
				_DNGPreviewApplicationVersion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewApplicationVersion");
			}
			return _DNGPreviewApplicationVersion;
		}
	}

	[Field("kCGImagePropertyDNGPreviewColorSpace", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGPreviewColorSpace
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGPreviewColorSpace == null)
			{
				_DNGPreviewColorSpace = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewColorSpace");
			}
			return _DNGPreviewColorSpace;
		}
	}

	[Field("kCGImagePropertyDNGPreviewDateTime", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGPreviewDateTime
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGPreviewDateTime == null)
			{
				_DNGPreviewDateTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewDateTime");
			}
			return _DNGPreviewDateTime;
		}
	}

	[Field("kCGImagePropertyDNGPreviewSettingsDigest", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGPreviewSettingsDigest
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGPreviewSettingsDigest == null)
			{
				_DNGPreviewSettingsDigest = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewSettingsDigest");
			}
			return _DNGPreviewSettingsDigest;
		}
	}

	[Field("kCGImagePropertyDNGPreviewSettingsName", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGPreviewSettingsName
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGPreviewSettingsName == null)
			{
				_DNGPreviewSettingsName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGPreviewSettingsName");
			}
			return _DNGPreviewSettingsName;
		}
	}

	[Field("kCGImagePropertyDNGPrivateData", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGPrivateData
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGPrivateData == null)
			{
				_DNGPrivateData = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGPrivateData");
			}
			return _DNGPrivateData;
		}
	}

	[Field("kCGImagePropertyDNGProfileCalibrationSignature", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileCalibrationSignature
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileCalibrationSignature == null)
			{
				_DNGProfileCalibrationSignature = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileCalibrationSignature");
			}
			return _DNGProfileCalibrationSignature;
		}
	}

	[Field("kCGImagePropertyDNGProfileCopyright", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileCopyright
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileCopyright == null)
			{
				_DNGProfileCopyright = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileCopyright");
			}
			return _DNGProfileCopyright;
		}
	}

	[Field("kCGImagePropertyDNGProfileEmbedPolicy", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileEmbedPolicy
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileEmbedPolicy == null)
			{
				_DNGProfileEmbedPolicy = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileEmbedPolicy");
			}
			return _DNGProfileEmbedPolicy;
		}
	}

	[Field("kCGImagePropertyDNGProfileHueSatMapData1", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileHueSatMapData1
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileHueSatMapData1 == null)
			{
				_DNGProfileHueSatMapData1 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapData1");
			}
			return _DNGProfileHueSatMapData1;
		}
	}

	[Field("kCGImagePropertyDNGProfileHueSatMapData2", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileHueSatMapData2
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileHueSatMapData2 == null)
			{
				_DNGProfileHueSatMapData2 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapData2");
			}
			return _DNGProfileHueSatMapData2;
		}
	}

	[Field("kCGImagePropertyDNGProfileHueSatMapDims", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileHueSatMapDims
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileHueSatMapDims == null)
			{
				_DNGProfileHueSatMapDims = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapDims");
			}
			return _DNGProfileHueSatMapDims;
		}
	}

	[Field("kCGImagePropertyDNGProfileHueSatMapEncoding", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileHueSatMapEncoding
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileHueSatMapEncoding == null)
			{
				_DNGProfileHueSatMapEncoding = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileHueSatMapEncoding");
			}
			return _DNGProfileHueSatMapEncoding;
		}
	}

	[Field("kCGImagePropertyDNGProfileLookTableData", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileLookTableData
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileLookTableData == null)
			{
				_DNGProfileLookTableData = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileLookTableData");
			}
			return _DNGProfileLookTableData;
		}
	}

	[Field("kCGImagePropertyDNGProfileLookTableDims", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileLookTableDims
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileLookTableDims == null)
			{
				_DNGProfileLookTableDims = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileLookTableDims");
			}
			return _DNGProfileLookTableDims;
		}
	}

	[Field("kCGImagePropertyDNGProfileLookTableEncoding", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileLookTableEncoding
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileLookTableEncoding == null)
			{
				_DNGProfileLookTableEncoding = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileLookTableEncoding");
			}
			return _DNGProfileLookTableEncoding;
		}
	}

	[Field("kCGImagePropertyDNGProfileName", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileName
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileName == null)
			{
				_DNGProfileName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileName");
			}
			return _DNGProfileName;
		}
	}

	[Field("kCGImagePropertyDNGProfileToneCurve", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGProfileToneCurve
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGProfileToneCurve == null)
			{
				_DNGProfileToneCurve = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGProfileToneCurve");
			}
			return _DNGProfileToneCurve;
		}
	}

	[Field("kCGImagePropertyDNGRawDataUniqueID", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGRawDataUniqueId
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGRawDataUniqueId == null)
			{
				_DNGRawDataUniqueId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGRawDataUniqueID");
			}
			return _DNGRawDataUniqueId;
		}
	}

	[Field("kCGImagePropertyDNGRawImageDigest", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGRawImageDigest
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGRawImageDigest == null)
			{
				_DNGRawImageDigest = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGRawImageDigest");
			}
			return _DNGRawImageDigest;
		}
	}

	[Field("kCGImagePropertyDNGRawToPreviewGain", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGRawToPreviewGain
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGRawToPreviewGain == null)
			{
				_DNGRawToPreviewGain = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGRawToPreviewGain");
			}
			return _DNGRawToPreviewGain;
		}
	}

	[Field("kCGImagePropertyDNGReductionMatrix1", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGReductionMatrix1
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGReductionMatrix1 == null)
			{
				_DNGReductionMatrix1 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGReductionMatrix1");
			}
			return _DNGReductionMatrix1;
		}
	}

	[Field("kCGImagePropertyDNGReductionMatrix2", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGReductionMatrix2
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGReductionMatrix2 == null)
			{
				_DNGReductionMatrix2 = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGReductionMatrix2");
			}
			return _DNGReductionMatrix2;
		}
	}

	[Field("kCGImagePropertyDNGRowInterleaveFactor", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGRowInterleaveFactor
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGRowInterleaveFactor == null)
			{
				_DNGRowInterleaveFactor = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGRowInterleaveFactor");
			}
			return _DNGRowInterleaveFactor;
		}
	}

	[Field("kCGImagePropertyDNGShadowScale", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGShadowScale
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGShadowScale == null)
			{
				_DNGShadowScale = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGShadowScale");
			}
			return _DNGShadowScale;
		}
	}

	[Field("kCGImagePropertyDNGSubTileBlockSize", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString DNGSubTileBlockSize
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGSubTileBlockSize == null)
			{
				_DNGSubTileBlockSize = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGSubTileBlockSize");
			}
			return _DNGSubTileBlockSize;
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

	[Field("kCGImagePropertyDNGWarpFisheye", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGWarpFisheye
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGWarpFisheye == null)
			{
				_DNGWarpFisheye = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGWarpFisheye");
			}
			return _DNGWarpFisheye;
		}
	}

	[Field("kCGImagePropertyDNGWarpRectilinear", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGWarpRectilinear
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGWarpRectilinear == null)
			{
				_DNGWarpRectilinear = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGWarpRectilinear");
			}
			return _DNGWarpRectilinear;
		}
	}

	[Field("kCGImagePropertyDNGWhiteLevel", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DNGWhiteLevel
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DNGWhiteLevel == null)
			{
				_DNGWhiteLevel = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyDNGWhiteLevel");
			}
			return _DNGWhiteLevel;
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

	[Field("kCGImagePropertyExifBodySerialNumber", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifBodySerialNumber
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifBodySerialNumber == null)
			{
				_ExifBodySerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifBodySerialNumber");
			}
			return _ExifBodySerialNumber;
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

	[Field("kCGImagePropertyExifCameraOwnerName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifCameraOwnerName
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifCameraOwnerName == null)
			{
				_ExifCameraOwnerName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifCameraOwnerName");
			}
			return _ExifCameraOwnerName;
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

	[Field("kCGImagePropertyExifISOSpeed", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifISOSpeed
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifISOSpeed == null)
			{
				_ExifISOSpeed = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeed");
			}
			return _ExifISOSpeed;
		}
	}

	[Field("kCGImagePropertyExifISOSpeedLatitudeyyy", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifISOSpeedLatitudeYyy
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifISOSpeedLatitudeYyy == null)
			{
				_ExifISOSpeedLatitudeYyy = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeedLatitudeyyy");
			}
			return _ExifISOSpeedLatitudeYyy;
		}
	}

	[Field("kCGImagePropertyExifISOSpeedLatitudezzz", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifISOSpeedLatitudeZzz
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifISOSpeedLatitudeZzz == null)
			{
				_ExifISOSpeedLatitudeZzz = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifISOSpeedLatitudezzz");
			}
			return _ExifISOSpeedLatitudeZzz;
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

	[Field("kCGImagePropertyExifLensMake", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifLensMake
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifLensModel
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifLensSerialNumber
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifLensSerialNumber == null)
			{
				_ExifLensSerialNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifLensSerialNumber");
			}
			return _ExifLensSerialNumber;
		}
	}

	[Field("kCGImagePropertyExifLensSpecification", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifLensSpecification
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifLensSpecification == null)
			{
				_ExifLensSpecification = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifLensSpecification");
			}
			return _ExifLensSpecification;
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

	[Field("kCGImagePropertyExifOffsetTime", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString ExifOffsetTime
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifOffsetTime == null)
			{
				_ExifOffsetTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifOffsetTime");
			}
			return _ExifOffsetTime;
		}
	}

	[Field("kCGImagePropertyExifOffsetTimeDigitized", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString ExifOffsetTimeDigitized
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifOffsetTimeDigitized == null)
			{
				_ExifOffsetTimeDigitized = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifOffsetTimeDigitized");
			}
			return _ExifOffsetTimeDigitized;
		}
	}

	[Field("kCGImagePropertyExifOffsetTimeOriginal", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString ExifOffsetTimeOriginal
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifOffsetTimeOriginal == null)
			{
				_ExifOffsetTimeOriginal = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifOffsetTimeOriginal");
			}
			return _ExifOffsetTimeOriginal;
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

	[Field("kCGImagePropertyExifRecommendedExposureIndex", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifRecommendedExposureIndex
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifRecommendedExposureIndex == null)
			{
				_ExifRecommendedExposureIndex = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifRecommendedExposureIndex");
			}
			return _ExifRecommendedExposureIndex;
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

	[Field("kCGImagePropertyExifSensitivityType", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifSensitivityType
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifSensitivityType == null)
			{
				_ExifSensitivityType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSensitivityType");
			}
			return _ExifSensitivityType;
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

	[Field("kCGImagePropertyExifStandardOutputSensitivity", "ImageIO")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ExifStandardOutputSensitivity
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifStandardOutputSensitivity == null)
			{
				_ExifStandardOutputSensitivity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifStandardOutputSensitivity");
			}
			return _ExifStandardOutputSensitivity;
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

	[Field("kCGImagePropertyExifSubsecTimeOriginal", "ImageIO")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	public static NSString ExifSubsecTimeOriginal
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ExifSubsecTimeOriginal == null)
			{
				_ExifSubsecTimeOriginal = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyExifSubsecTimeOriginal");
			}
			return _ExifSubsecTimeOriginal;
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

	[Field("kCGImagePropertyFileContentsDictionary", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString FileContentsDictionary
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileContentsDictionary == null)
			{
				_FileContentsDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyFileContentsDictionary");
			}
			return _FileContentsDictionary;
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

	[Field("kCGImagePropertyGPSHPositioningError", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString GPSHPositioningError
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_GPSHPositioningError == null)
			{
				_GPSHPositioningError = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGPSHPositioningError");
			}
			return _GPSHPositioningError;
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

	[Field("kCGImagePropertyGIFCanvasPixelHeight", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString GifCanvasPixelHeight
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_GifCanvasPixelHeight == null)
			{
				_GifCanvasPixelHeight = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFCanvasPixelHeight");
			}
			return _GifCanvasPixelHeight;
		}
	}

	[Field("kCGImagePropertyGIFCanvasPixelWidth", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString GifCanvasPixelWidth
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_GifCanvasPixelWidth == null)
			{
				_GifCanvasPixelWidth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFCanvasPixelWidth");
			}
			return _GifCanvasPixelWidth;
		}
	}

	[Field("kCGImagePropertyGIFFrameInfoArray", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString GifFrameInfoArray
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_GifFrameInfoArray == null)
			{
				_GifFrameInfoArray = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyGIFFrameInfoArray");
			}
			return _GifFrameInfoArray;
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

	[Field("kCGImagePropertyHEICSCanvasPixelHeight", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HeicsCanvasPixelHeight
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HeicsCanvasPixelHeight == null)
			{
				_HeicsCanvasPixelHeight = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHEICSCanvasPixelHeight");
			}
			return _HeicsCanvasPixelHeight;
		}
	}

	[Field("kCGImagePropertyHEICSCanvasPixelWidth", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HeicsCanvasPixelWidth
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HeicsCanvasPixelWidth == null)
			{
				_HeicsCanvasPixelWidth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHEICSCanvasPixelWidth");
			}
			return _HeicsCanvasPixelWidth;
		}
	}

	[Field("kCGImagePropertyHEICSDelayTime", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HeicsDelayTime
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HeicsDelayTime == null)
			{
				_HeicsDelayTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHEICSDelayTime");
			}
			return _HeicsDelayTime;
		}
	}

	[Field("kCGImagePropertyHEICSDictionary", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HeicsDictionary
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HeicsDictionary == null)
			{
				_HeicsDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHEICSDictionary");
			}
			return _HeicsDictionary;
		}
	}

	[Field("kCGImagePropertyHEICSFrameInfoArray", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HeicsFrameInfoArray
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HeicsFrameInfoArray == null)
			{
				_HeicsFrameInfoArray = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHEICSFrameInfoArray");
			}
			return _HeicsFrameInfoArray;
		}
	}

	[Field("kCGImagePropertyHEICSLoopCount", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HeicsLoopCount
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HeicsLoopCount == null)
			{
				_HeicsLoopCount = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHEICSLoopCount");
			}
			return _HeicsLoopCount;
		}
	}

	[Field("kCGImagePropertyHEICSUnclampedDelayTime", "ImageIO")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HeicsSUnclampedDelayTime
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HeicsSUnclampedDelayTime == null)
			{
				_HeicsSUnclampedDelayTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHEICSUnclampedDelayTime");
			}
			return _HeicsSUnclampedDelayTime;
		}
	}

	[Field("kCGImagePropertyHeight", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString Height
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Height == null)
			{
				_Height = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyHeight");
			}
			return _Height;
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

	[Field("kCGImagePropertyIPTCExtAboutCvTerm", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAboutCvTerm
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAboutCvTerm == null)
			{
				_IPTCExtAboutCvTerm = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTerm");
			}
			return _IPTCExtAboutCvTerm;
		}
	}

	[Field("kCGImagePropertyIPTCExtAboutCvTermCvId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAboutCvTermCvId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAboutCvTermCvId == null)
			{
				_IPTCExtAboutCvTermCvId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermCvId");
			}
			return _IPTCExtAboutCvTermCvId;
		}
	}

	[Field("kCGImagePropertyIPTCExtAboutCvTermId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAboutCvTermId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAboutCvTermId == null)
			{
				_IPTCExtAboutCvTermId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermId");
			}
			return _IPTCExtAboutCvTermId;
		}
	}

	[Field("kCGImagePropertyIPTCExtAboutCvTermName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAboutCvTermName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAboutCvTermName == null)
			{
				_IPTCExtAboutCvTermName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermName");
			}
			return _IPTCExtAboutCvTermName;
		}
	}

	[Field("kCGImagePropertyIPTCExtAboutCvTermRefinedAbout", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAboutCvTermRefinedAbout
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAboutCvTermRefinedAbout == null)
			{
				_IPTCExtAboutCvTermRefinedAbout = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAboutCvTermRefinedAbout");
			}
			return _IPTCExtAboutCvTermRefinedAbout;
		}
	}

	[Field("kCGImagePropertyIPTCExtAddlModelInfo", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAddlModelInfo
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAddlModelInfo == null)
			{
				_IPTCExtAddlModelInfo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAddlModelInfo");
			}
			return _IPTCExtAddlModelInfo;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkCircaDateCreated", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkCircaDateCreated
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkCircaDateCreated == null)
			{
				_IPTCExtArtworkCircaDateCreated = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCircaDateCreated");
			}
			return _IPTCExtArtworkCircaDateCreated;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkContentDescription", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkContentDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkContentDescription == null)
			{
				_IPTCExtArtworkContentDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkContentDescription");
			}
			return _IPTCExtArtworkContentDescription;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkContributionDescription", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkContributionDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkContributionDescription == null)
			{
				_IPTCExtArtworkContributionDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkContributionDescription");
			}
			return _IPTCExtArtworkContributionDescription;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkCopyrightNotice", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkCopyrightNotice
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkCopyrightNotice == null)
			{
				_IPTCExtArtworkCopyrightNotice = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCopyrightNotice");
			}
			return _IPTCExtArtworkCopyrightNotice;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkCopyrightOwnerID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkCopyrightOwnerId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkCopyrightOwnerId == null)
			{
				_IPTCExtArtworkCopyrightOwnerId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCopyrightOwnerID");
			}
			return _IPTCExtArtworkCopyrightOwnerId;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkCopyrightOwnerName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkCopyrightOwnerName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkCopyrightOwnerName == null)
			{
				_IPTCExtArtworkCopyrightOwnerName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCopyrightOwnerName");
			}
			return _IPTCExtArtworkCopyrightOwnerName;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkCreator", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkCreator
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkCreator == null)
			{
				_IPTCExtArtworkCreator = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCreator");
			}
			return _IPTCExtArtworkCreator;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkCreatorID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkCreatorId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkCreatorId == null)
			{
				_IPTCExtArtworkCreatorId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkCreatorID");
			}
			return _IPTCExtArtworkCreatorId;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkDateCreated", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkDateCreated
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkDateCreated == null)
			{
				_IPTCExtArtworkDateCreated = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkDateCreated");
			}
			return _IPTCExtArtworkDateCreated;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkLicensorID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkLicensorId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkLicensorId == null)
			{
				_IPTCExtArtworkLicensorId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkLicensorID");
			}
			return _IPTCExtArtworkLicensorId;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkLicensorName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkLicensorName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkLicensorName == null)
			{
				_IPTCExtArtworkLicensorName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkLicensorName");
			}
			return _IPTCExtArtworkLicensorName;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkOrObject", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkOrObject
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkOrObject == null)
			{
				_IPTCExtArtworkOrObject = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkOrObject");
			}
			return _IPTCExtArtworkOrObject;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkPhysicalDescription", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkPhysicalDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkPhysicalDescription == null)
			{
				_IPTCExtArtworkPhysicalDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkPhysicalDescription");
			}
			return _IPTCExtArtworkPhysicalDescription;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkSource", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkSource
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkSource == null)
			{
				_IPTCExtArtworkSource = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkSource");
			}
			return _IPTCExtArtworkSource;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkSourceInvURL", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkSourceInvUrl
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkSourceInvUrl == null)
			{
				_IPTCExtArtworkSourceInvUrl = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkSourceInvURL");
			}
			return _IPTCExtArtworkSourceInvUrl;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkSourceInventoryNo", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkSourceInventoryNo
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkSourceInventoryNo == null)
			{
				_IPTCExtArtworkSourceInventoryNo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkSourceInventoryNo");
			}
			return _IPTCExtArtworkSourceInventoryNo;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkStylePeriod", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkStylePeriod
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkStylePeriod == null)
			{
				_IPTCExtArtworkStylePeriod = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkStylePeriod");
			}
			return _IPTCExtArtworkStylePeriod;
		}
	}

	[Field("kCGImagePropertyIPTCExtArtworkTitle", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtArtworkTitle
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtArtworkTitle == null)
			{
				_IPTCExtArtworkTitle = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtArtworkTitle");
			}
			return _IPTCExtArtworkTitle;
		}
	}

	[Field("kCGImagePropertyIPTCExtAudioBitrate", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAudioBitrate
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAudioBitrate == null)
			{
				_IPTCExtAudioBitrate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAudioBitrate");
			}
			return _IPTCExtAudioBitrate;
		}
	}

	[Field("kCGImagePropertyIPTCExtAudioBitrateMode", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAudioBitrateMode
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAudioBitrateMode == null)
			{
				_IPTCExtAudioBitrateMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAudioBitrateMode");
			}
			return _IPTCExtAudioBitrateMode;
		}
	}

	[Field("kCGImagePropertyIPTCExtAudioChannelCount", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtAudioChannelCount
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtAudioChannelCount == null)
			{
				_IPTCExtAudioChannelCount = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtAudioChannelCount");
			}
			return _IPTCExtAudioChannelCount;
		}
	}

	[Field("kCGImagePropertyIPTCExtCircaDateCreated", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtCircaDateCreated
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtCircaDateCreated == null)
			{
				_IPTCExtCircaDateCreated = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCircaDateCreated");
			}
			return _IPTCExtCircaDateCreated;
		}
	}

	[Field("kCGImagePropertyIPTCExtContainerFormat", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtContainerFormat
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtContainerFormat == null)
			{
				_IPTCExtContainerFormat = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContainerFormat");
			}
			return _IPTCExtContainerFormat;
		}
	}

	[Field("kCGImagePropertyIPTCExtContainerFormatIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtContainerFormatIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtContainerFormatIdentifier == null)
			{
				_IPTCExtContainerFormatIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContainerFormatIdentifier");
			}
			return _IPTCExtContainerFormatIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtContainerFormatName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtContainerFormatName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtContainerFormatName == null)
			{
				_IPTCExtContainerFormatName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContainerFormatName");
			}
			return _IPTCExtContainerFormatName;
		}
	}

	[Field("kCGImagePropertyIPTCExtContributor", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtContributor
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtContributor == null)
			{
				_IPTCExtContributor = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributor");
			}
			return _IPTCExtContributor;
		}
	}

	[Field("kCGImagePropertyIPTCExtContributorIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtContributorIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtContributorIdentifier == null)
			{
				_IPTCExtContributorIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributorIdentifier");
			}
			return _IPTCExtContributorIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtContributorName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtContributorName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtContributorName == null)
			{
				_IPTCExtContributorName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributorName");
			}
			return _IPTCExtContributorName;
		}
	}

	[Field("kCGImagePropertyIPTCExtContributorRole", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtContributorRole
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtContributorRole == null)
			{
				_IPTCExtContributorRole = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtContributorRole");
			}
			return _IPTCExtContributorRole;
		}
	}

	[Field("kCGImagePropertyIPTCExtControlledVocabularyTerm", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtControlledVocabularyTerm
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtControlledVocabularyTerm == null)
			{
				_IPTCExtControlledVocabularyTerm = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtControlledVocabularyTerm");
			}
			return _IPTCExtControlledVocabularyTerm;
		}
	}

	[Field("kCGImagePropertyIPTCExtCopyrightYear", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtCopyrightYear
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtCopyrightYear == null)
			{
				_IPTCExtCopyrightYear = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCopyrightYear");
			}
			return _IPTCExtCopyrightYear;
		}
	}

	[Field("kCGImagePropertyIPTCExtCreator", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtCreator
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtCreator == null)
			{
				_IPTCExtCreator = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreator");
			}
			return _IPTCExtCreator;
		}
	}

	[Field("kCGImagePropertyIPTCExtCreatorIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtCreatorIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtCreatorIdentifier == null)
			{
				_IPTCExtCreatorIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreatorIdentifier");
			}
			return _IPTCExtCreatorIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtCreatorName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtCreatorName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtCreatorName == null)
			{
				_IPTCExtCreatorName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreatorName");
			}
			return _IPTCExtCreatorName;
		}
	}

	[Field("kCGImagePropertyIPTCExtCreatorRole", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtCreatorRole
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtCreatorRole == null)
			{
				_IPTCExtCreatorRole = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtCreatorRole");
			}
			return _IPTCExtCreatorRole;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreen", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreen
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreen == null)
			{
				_IPTCExtDataOnScreen = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreen");
			}
			return _IPTCExtDataOnScreen;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegion", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegion
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegion == null)
			{
				_IPTCExtDataOnScreenRegion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegion");
			}
			return _IPTCExtDataOnScreenRegion;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegionD", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegionD
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegionD == null)
			{
				_IPTCExtDataOnScreenRegionD = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionD");
			}
			return _IPTCExtDataOnScreenRegionD;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegionH", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegionH
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegionH == null)
			{
				_IPTCExtDataOnScreenRegionH = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionH");
			}
			return _IPTCExtDataOnScreenRegionH;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegionText", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegionText
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegionText == null)
			{
				_IPTCExtDataOnScreenRegionText = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionText");
			}
			return _IPTCExtDataOnScreenRegionText;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegionUnit", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegionUnit
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegionUnit == null)
			{
				_IPTCExtDataOnScreenRegionUnit = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionUnit");
			}
			return _IPTCExtDataOnScreenRegionUnit;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegionW", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegionW
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegionW == null)
			{
				_IPTCExtDataOnScreenRegionW = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionW");
			}
			return _IPTCExtDataOnScreenRegionW;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegionX", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegionX
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegionX == null)
			{
				_IPTCExtDataOnScreenRegionX = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionX");
			}
			return _IPTCExtDataOnScreenRegionX;
		}
	}

	[Field("kCGImagePropertyIPTCExtDataOnScreenRegionY", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDataOnScreenRegionY
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDataOnScreenRegionY == null)
			{
				_IPTCExtDataOnScreenRegionY = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDataOnScreenRegionY");
			}
			return _IPTCExtDataOnScreenRegionY;
		}
	}

	[Field("kCGImagePropertyIPTCExtDigitalImageGUID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDigitalImageGuid
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDigitalImageGuid == null)
			{
				_IPTCExtDigitalImageGuid = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDigitalImageGUID");
			}
			return _IPTCExtDigitalImageGuid;
		}
	}

	[Field("kCGImagePropertyIPTCExtDigitalSourceFileType", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDigitalSourceFileType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDigitalSourceFileType == null)
			{
				_IPTCExtDigitalSourceFileType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDigitalSourceFileType");
			}
			return _IPTCExtDigitalSourceFileType;
		}
	}

	[Field("kCGImagePropertyIPTCExtDigitalSourceType", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDigitalSourceType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDigitalSourceType == null)
			{
				_IPTCExtDigitalSourceType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDigitalSourceType");
			}
			return _IPTCExtDigitalSourceType;
		}
	}

	[Field("kCGImagePropertyIPTCExtDopesheet", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDopesheet
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDopesheet == null)
			{
				_IPTCExtDopesheet = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheet");
			}
			return _IPTCExtDopesheet;
		}
	}

	[Field("kCGImagePropertyIPTCExtDopesheetLink", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDopesheetLink
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDopesheetLink == null)
			{
				_IPTCExtDopesheetLink = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheetLink");
			}
			return _IPTCExtDopesheetLink;
		}
	}

	[Field("kCGImagePropertyIPTCExtDopesheetLinkLink", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDopesheetLinkLink
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDopesheetLinkLink == null)
			{
				_IPTCExtDopesheetLinkLink = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheetLinkLink");
			}
			return _IPTCExtDopesheetLinkLink;
		}
	}

	[Field("kCGImagePropertyIPTCExtDopesheetLinkLinkQualifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtDopesheetLinkLinkQualifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtDopesheetLinkLinkQualifier == null)
			{
				_IPTCExtDopesheetLinkLinkQualifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtDopesheetLinkLinkQualifier");
			}
			return _IPTCExtDopesheetLinkLinkQualifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtEmbdEncRightsExpr", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEmbdEncRightsExpr
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEmbdEncRightsExpr == null)
			{
				_IPTCExtEmbdEncRightsExpr = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbdEncRightsExpr");
			}
			return _IPTCExtEmbdEncRightsExpr;
		}
	}

	[Field("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExpr", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEmbeddedEncodedRightsExpr
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEmbeddedEncodedRightsExpr == null)
			{
				_IPTCExtEmbeddedEncodedRightsExpr = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbeddedEncodedRightsExpr");
			}
			return _IPTCExtEmbeddedEncodedRightsExpr;
		}
	}

	[Field("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprLangID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEmbeddedEncodedRightsExprLangId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEmbeddedEncodedRightsExprLangId == null)
			{
				_IPTCExtEmbeddedEncodedRightsExprLangId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprLangID");
			}
			return _IPTCExtEmbeddedEncodedRightsExprLangId;
		}
	}

	[Field("kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprType", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEmbeddedEncodedRightsExprType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEmbeddedEncodedRightsExprType == null)
			{
				_IPTCExtEmbeddedEncodedRightsExprType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEmbeddedEncodedRightsExprType");
			}
			return _IPTCExtEmbeddedEncodedRightsExprType;
		}
	}

	[Field("kCGImagePropertyIPTCExtEpisode", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEpisode
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEpisode == null)
			{
				_IPTCExtEpisode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisode");
			}
			return _IPTCExtEpisode;
		}
	}

	[Field("kCGImagePropertyIPTCExtEpisodeIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEpisodeIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEpisodeIdentifier == null)
			{
				_IPTCExtEpisodeIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisodeIdentifier");
			}
			return _IPTCExtEpisodeIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtEpisodeName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEpisodeName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEpisodeName == null)
			{
				_IPTCExtEpisodeName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisodeName");
			}
			return _IPTCExtEpisodeName;
		}
	}

	[Field("kCGImagePropertyIPTCExtEpisodeNumber", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEpisodeNumber
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEpisodeNumber == null)
			{
				_IPTCExtEpisodeNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEpisodeNumber");
			}
			return _IPTCExtEpisodeNumber;
		}
	}

	[Field("kCGImagePropertyIPTCExtEvent", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtEvent
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtEvent == null)
			{
				_IPTCExtEvent = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtEvent");
			}
			return _IPTCExtEvent;
		}
	}

	[Field("kCGImagePropertyIPTCExtExternalMetadataLink", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtExternalMetadataLink
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtExternalMetadataLink == null)
			{
				_IPTCExtExternalMetadataLink = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtExternalMetadataLink");
			}
			return _IPTCExtExternalMetadataLink;
		}
	}

	[Field("kCGImagePropertyIPTCExtFeedIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtFeedIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtFeedIdentifier == null)
			{
				_IPTCExtFeedIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtFeedIdentifier");
			}
			return _IPTCExtFeedIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtGenre", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtGenre
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtGenre == null)
			{
				_IPTCExtGenre = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenre");
			}
			return _IPTCExtGenre;
		}
	}

	[Field("kCGImagePropertyIPTCExtGenreCvId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtGenreCvId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtGenreCvId == null)
			{
				_IPTCExtGenreCvId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvId");
			}
			return _IPTCExtGenreCvId;
		}
	}

	[Field("kCGImagePropertyIPTCExtGenreCvTermId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtGenreCvTermId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtGenreCvTermId == null)
			{
				_IPTCExtGenreCvTermId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvTermId");
			}
			return _IPTCExtGenreCvTermId;
		}
	}

	[Field("kCGImagePropertyIPTCExtGenreCvTermName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtGenreCvTermName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtGenreCvTermName == null)
			{
				_IPTCExtGenreCvTermName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvTermName");
			}
			return _IPTCExtGenreCvTermName;
		}
	}

	[Field("kCGImagePropertyIPTCExtGenreCvTermRefinedAbout", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtGenreCvTermRefinedAbout
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtGenreCvTermRefinedAbout == null)
			{
				_IPTCExtGenreCvTermRefinedAbout = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtGenreCvTermRefinedAbout");
			}
			return _IPTCExtGenreCvTermRefinedAbout;
		}
	}

	[Field("kCGImagePropertyIPTCExtHeadline", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtHeadline
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtHeadline == null)
			{
				_IPTCExtHeadline = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtHeadline");
			}
			return _IPTCExtHeadline;
		}
	}

	[Field("kCGImagePropertyIPTCExtIPTCLastEdited", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtIPTCLastEdited
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtIPTCLastEdited == null)
			{
				_IPTCExtIPTCLastEdited = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtIPTCLastEdited");
			}
			return _IPTCExtIPTCLastEdited;
		}
	}

	[Field("kCGImagePropertyIPTCExtLinkedEncRightsExpr", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLinkedEncRightsExpr
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLinkedEncRightsExpr == null)
			{
				_IPTCExtLinkedEncRightsExpr = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncRightsExpr");
			}
			return _IPTCExtLinkedEncRightsExpr;
		}
	}

	[Field("kCGImagePropertyIPTCExtLinkedEncodedRightsExpr", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLinkedEncodedRightsExpr
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLinkedEncodedRightsExpr == null)
			{
				_IPTCExtLinkedEncodedRightsExpr = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncodedRightsExpr");
			}
			return _IPTCExtLinkedEncodedRightsExpr;
		}
	}

	[Field("kCGImagePropertyIPTCExtLinkedEncodedRightsExprLangID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLinkedEncodedRightsExprLangId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLinkedEncodedRightsExprLangId == null)
			{
				_IPTCExtLinkedEncodedRightsExprLangId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncodedRightsExprLangID");
			}
			return _IPTCExtLinkedEncodedRightsExprLangId;
		}
	}

	[Field("kCGImagePropertyIPTCExtLinkedEncodedRightsExprType", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLinkedEncodedRightsExprType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLinkedEncodedRightsExprType == null)
			{
				_IPTCExtLinkedEncodedRightsExprType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLinkedEncodedRightsExprType");
			}
			return _IPTCExtLinkedEncodedRightsExprType;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationCity", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationCity
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationCity == null)
			{
				_IPTCExtLocationCity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCity");
			}
			return _IPTCExtLocationCity;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationCountryCode", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationCountryCode
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationCountryCode == null)
			{
				_IPTCExtLocationCountryCode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCountryCode");
			}
			return _IPTCExtLocationCountryCode;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationCountryName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationCountryName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationCountryName == null)
			{
				_IPTCExtLocationCountryName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCountryName");
			}
			return _IPTCExtLocationCountryName;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationCreated", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationCreated
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationCreated == null)
			{
				_IPTCExtLocationCreated = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationCreated");
			}
			return _IPTCExtLocationCreated;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationGPSAltitude", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationGpsAltitude
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationGpsAltitude == null)
			{
				_IPTCExtLocationGpsAltitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationGPSAltitude");
			}
			return _IPTCExtLocationGpsAltitude;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationGPSLatitude", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationGpsLatitude
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationGpsLatitude == null)
			{
				_IPTCExtLocationGpsLatitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationGPSLatitude");
			}
			return _IPTCExtLocationGpsLatitude;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationGPSLongitude", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationGpsLongitude
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationGpsLongitude == null)
			{
				_IPTCExtLocationGpsLongitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationGPSLongitude");
			}
			return _IPTCExtLocationGpsLongitude;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationIdentifier == null)
			{
				_IPTCExtLocationIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationIdentifier");
			}
			return _IPTCExtLocationIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationLocationId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationLocationId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationLocationId == null)
			{
				_IPTCExtLocationLocationId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationLocationId");
			}
			return _IPTCExtLocationLocationId;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationLocationName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationLocationName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationLocationName == null)
			{
				_IPTCExtLocationLocationName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationLocationName");
			}
			return _IPTCExtLocationLocationName;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationProvinceState", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationProvinceState
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationProvinceState == null)
			{
				_IPTCExtLocationProvinceState = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationProvinceState");
			}
			return _IPTCExtLocationProvinceState;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationShown", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationShown
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationShown == null)
			{
				_IPTCExtLocationShown = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationShown");
			}
			return _IPTCExtLocationShown;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationSublocation", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationSublocation
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationSublocation == null)
			{
				_IPTCExtLocationSublocation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationSublocation");
			}
			return _IPTCExtLocationSublocation;
		}
	}

	[Field("kCGImagePropertyIPTCExtLocationWorldRegion", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtLocationWorldRegion
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtLocationWorldRegion == null)
			{
				_IPTCExtLocationWorldRegion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtLocationWorldRegion");
			}
			return _IPTCExtLocationWorldRegion;
		}
	}

	[Field("kCGImagePropertyIPTCExtMaxAvailHeight", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtMaxAvailHeight
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtMaxAvailHeight == null)
			{
				_IPTCExtMaxAvailHeight = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtMaxAvailHeight");
			}
			return _IPTCExtMaxAvailHeight;
		}
	}

	[Field("kCGImagePropertyIPTCExtMaxAvailWidth", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtMaxAvailWidth
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtMaxAvailWidth == null)
			{
				_IPTCExtMaxAvailWidth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtMaxAvailWidth");
			}
			return _IPTCExtMaxAvailWidth;
		}
	}

	[Field("kCGImagePropertyIPTCExtModelAge", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtModelAge
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtModelAge == null)
			{
				_IPTCExtModelAge = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtModelAge");
			}
			return _IPTCExtModelAge;
		}
	}

	[Field("kCGImagePropertyIPTCExtOrganisationInImageCode", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtOrganisationInImageCode
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtOrganisationInImageCode == null)
			{
				_IPTCExtOrganisationInImageCode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtOrganisationInImageCode");
			}
			return _IPTCExtOrganisationInImageCode;
		}
	}

	[Field("kCGImagePropertyIPTCExtOrganisationInImageName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtOrganisationInImageName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtOrganisationInImageName == null)
			{
				_IPTCExtOrganisationInImageName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtOrganisationInImageName");
			}
			return _IPTCExtOrganisationInImageName;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonHeard", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonHeard
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonHeard == null)
			{
				_IPTCExtPersonHeard = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonHeard");
			}
			return _IPTCExtPersonHeard;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonHeardIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonHeardIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonHeardIdentifier == null)
			{
				_IPTCExtPersonHeardIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonHeardIdentifier");
			}
			return _IPTCExtPersonHeardIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonHeardName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonHeardName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonHeardName == null)
			{
				_IPTCExtPersonHeardName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonHeardName");
			}
			return _IPTCExtPersonHeardName;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImage", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImage
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImage == null)
			{
				_IPTCExtPersonInImage = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImage");
			}
			return _IPTCExtPersonInImage;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageCharacteristic", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageCharacteristic
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageCharacteristic == null)
			{
				_IPTCExtPersonInImageCharacteristic = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCharacteristic");
			}
			return _IPTCExtPersonInImageCharacteristic;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageCvTermCvId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageCvTermCvId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageCvTermCvId == null)
			{
				_IPTCExtPersonInImageCvTermCvId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermCvId");
			}
			return _IPTCExtPersonInImageCvTermCvId;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageCvTermId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageCvTermId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageCvTermId == null)
			{
				_IPTCExtPersonInImageCvTermId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermId");
			}
			return _IPTCExtPersonInImageCvTermId;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageCvTermName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageCvTermName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageCvTermName == null)
			{
				_IPTCExtPersonInImageCvTermName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermName");
			}
			return _IPTCExtPersonInImageCvTermName;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageCvTermRefinedAbout", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageCvTermRefinedAbout
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageCvTermRefinedAbout == null)
			{
				_IPTCExtPersonInImageCvTermRefinedAbout = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageCvTermRefinedAbout");
			}
			return _IPTCExtPersonInImageCvTermRefinedAbout;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageDescription", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageDescription == null)
			{
				_IPTCExtPersonInImageDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageDescription");
			}
			return _IPTCExtPersonInImageDescription;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageId == null)
			{
				_IPTCExtPersonInImageId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageId");
			}
			return _IPTCExtPersonInImageId;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageName == null)
			{
				_IPTCExtPersonInImageName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageName");
			}
			return _IPTCExtPersonInImageName;
		}
	}

	[Field("kCGImagePropertyIPTCExtPersonInImageWDetails", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPersonInImageWDetails
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPersonInImageWDetails == null)
			{
				_IPTCExtPersonInImageWDetails = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPersonInImageWDetails");
			}
			return _IPTCExtPersonInImageWDetails;
		}
	}

	[Field("kCGImagePropertyIPTCExtProductInImage", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtProductInImage
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtProductInImage == null)
			{
				_IPTCExtProductInImage = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImage");
			}
			return _IPTCExtProductInImage;
		}
	}

	[Field("kCGImagePropertyIPTCExtProductInImageDescription", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtProductInImageDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtProductInImageDescription == null)
			{
				_IPTCExtProductInImageDescription = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImageDescription");
			}
			return _IPTCExtProductInImageDescription;
		}
	}

	[Field("kCGImagePropertyIPTCExtProductInImageGTIN", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtProductInImageGtin
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtProductInImageGtin == null)
			{
				_IPTCExtProductInImageGtin = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImageGTIN");
			}
			return _IPTCExtProductInImageGtin;
		}
	}

	[Field("kCGImagePropertyIPTCExtProductInImageName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtProductInImageName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtProductInImageName == null)
			{
				_IPTCExtProductInImageName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtProductInImageName");
			}
			return _IPTCExtProductInImageName;
		}
	}

	[Field("kCGImagePropertyIPTCExtPublicationEvent", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPublicationEvent
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPublicationEvent == null)
			{
				_IPTCExtPublicationEvent = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEvent");
			}
			return _IPTCExtPublicationEvent;
		}
	}

	[Field("kCGImagePropertyIPTCExtPublicationEventDate", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPublicationEventDate
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPublicationEventDate == null)
			{
				_IPTCExtPublicationEventDate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEventDate");
			}
			return _IPTCExtPublicationEventDate;
		}
	}

	[Field("kCGImagePropertyIPTCExtPublicationEventIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPublicationEventIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPublicationEventIdentifier == null)
			{
				_IPTCExtPublicationEventIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEventIdentifier");
			}
			return _IPTCExtPublicationEventIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtPublicationEventName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtPublicationEventName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtPublicationEventName == null)
			{
				_IPTCExtPublicationEventName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtPublicationEventName");
			}
			return _IPTCExtPublicationEventName;
		}
	}

	[Field("kCGImagePropertyIPTCExtRating", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRating
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRating == null)
			{
				_IPTCExtRating = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRating");
			}
			return _IPTCExtRating;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRatingRegion", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRatingRegion
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRatingRegion == null)
			{
				_IPTCExtRatingRatingRegion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRatingRegion");
			}
			return _IPTCExtRatingRatingRegion;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionCity", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionCity
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionCity == null)
			{
				_IPTCExtRatingRegionCity = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionCity");
			}
			return _IPTCExtRatingRegionCity;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionCountryCode", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionCountryCode
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionCountryCode == null)
			{
				_IPTCExtRatingRegionCountryCode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionCountryCode");
			}
			return _IPTCExtRatingRegionCountryCode;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionCountryName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionCountryName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionCountryName == null)
			{
				_IPTCExtRatingRegionCountryName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionCountryName");
			}
			return _IPTCExtRatingRegionCountryName;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionGPSAltitude", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionGpsAltitude
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionGpsAltitude == null)
			{
				_IPTCExtRatingRegionGpsAltitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionGPSAltitude");
			}
			return _IPTCExtRatingRegionGpsAltitude;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionGPSLatitude", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionGpsLatitude
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionGpsLatitude == null)
			{
				_IPTCExtRatingRegionGpsLatitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionGPSLatitude");
			}
			return _IPTCExtRatingRegionGpsLatitude;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionGPSLongitude", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionGpsLongitude
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionGpsLongitude == null)
			{
				_IPTCExtRatingRegionGpsLongitude = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionGPSLongitude");
			}
			return _IPTCExtRatingRegionGpsLongitude;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionIdentifier == null)
			{
				_IPTCExtRatingRegionIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionIdentifier");
			}
			return _IPTCExtRatingRegionIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionLocationId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionLocationId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionLocationId == null)
			{
				_IPTCExtRatingRegionLocationId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionLocationId");
			}
			return _IPTCExtRatingRegionLocationId;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionLocationName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionLocationName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionLocationName == null)
			{
				_IPTCExtRatingRegionLocationName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionLocationName");
			}
			return _IPTCExtRatingRegionLocationName;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionProvinceState", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionProvinceState
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionProvinceState == null)
			{
				_IPTCExtRatingRegionProvinceState = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionProvinceState");
			}
			return _IPTCExtRatingRegionProvinceState;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionSublocation", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionSublocation
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionSublocation == null)
			{
				_IPTCExtRatingRegionSublocation = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionSublocation");
			}
			return _IPTCExtRatingRegionSublocation;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingRegionWorldRegion", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingRegionWorldRegion
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingRegionWorldRegion == null)
			{
				_IPTCExtRatingRegionWorldRegion = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingRegionWorldRegion");
			}
			return _IPTCExtRatingRegionWorldRegion;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingScaleMaxValue", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingScaleMaxValue
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingScaleMaxValue == null)
			{
				_IPTCExtRatingScaleMaxValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingScaleMaxValue");
			}
			return _IPTCExtRatingScaleMaxValue;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingScaleMinValue", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingScaleMinValue
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingScaleMinValue == null)
			{
				_IPTCExtRatingScaleMinValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingScaleMinValue");
			}
			return _IPTCExtRatingScaleMinValue;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingSourceLink", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingSourceLink
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingSourceLink == null)
			{
				_IPTCExtRatingSourceLink = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingSourceLink");
			}
			return _IPTCExtRatingSourceLink;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingValue", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingValue
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingValue == null)
			{
				_IPTCExtRatingValue = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingValue");
			}
			return _IPTCExtRatingValue;
		}
	}

	[Field("kCGImagePropertyIPTCExtRatingValueLogoLink", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRatingValueLogoLink
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRatingValueLogoLink == null)
			{
				_IPTCExtRatingValueLogoLink = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRatingValueLogoLink");
			}
			return _IPTCExtRatingValueLogoLink;
		}
	}

	[Field("kCGImagePropertyIPTCExtRegistryEntryRole", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRegistryEntryRole
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRegistryEntryRole == null)
			{
				_IPTCExtRegistryEntryRole = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryEntryRole");
			}
			return _IPTCExtRegistryEntryRole;
		}
	}

	[Field("kCGImagePropertyIPTCExtRegistryID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRegistryId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRegistryId == null)
			{
				_IPTCExtRegistryId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryID");
			}
			return _IPTCExtRegistryId;
		}
	}

	[Field("kCGImagePropertyIPTCExtRegistryItemID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRegistryItemId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRegistryItemId == null)
			{
				_IPTCExtRegistryItemId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryItemID");
			}
			return _IPTCExtRegistryItemId;
		}
	}

	[Field("kCGImagePropertyIPTCExtRegistryOrganisationID", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtRegistryOrganisationId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtRegistryOrganisationId == null)
			{
				_IPTCExtRegistryOrganisationId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtRegistryOrganisationID");
			}
			return _IPTCExtRegistryOrganisationId;
		}
	}

	[Field("kCGImagePropertyIPTCExtReleaseReady", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtReleaseReady
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtReleaseReady == null)
			{
				_IPTCExtReleaseReady = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtReleaseReady");
			}
			return _IPTCExtReleaseReady;
		}
	}

	[Field("kCGImagePropertyIPTCExtSeason", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSeason
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSeason == null)
			{
				_IPTCExtSeason = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeason");
			}
			return _IPTCExtSeason;
		}
	}

	[Field("kCGImagePropertyIPTCExtSeasonIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSeasonIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSeasonIdentifier == null)
			{
				_IPTCExtSeasonIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeasonIdentifier");
			}
			return _IPTCExtSeasonIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtSeasonName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSeasonName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSeasonName == null)
			{
				_IPTCExtSeasonName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeasonName");
			}
			return _IPTCExtSeasonName;
		}
	}

	[Field("kCGImagePropertyIPTCExtSeasonNumber", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSeasonNumber
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSeasonNumber == null)
			{
				_IPTCExtSeasonNumber = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeasonNumber");
			}
			return _IPTCExtSeasonNumber;
		}
	}

	[Field("kCGImagePropertyIPTCExtSeries", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSeries
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSeries == null)
			{
				_IPTCExtSeries = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeries");
			}
			return _IPTCExtSeries;
		}
	}

	[Field("kCGImagePropertyIPTCExtSeriesIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSeriesIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSeriesIdentifier == null)
			{
				_IPTCExtSeriesIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeriesIdentifier");
			}
			return _IPTCExtSeriesIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtSeriesName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSeriesName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSeriesName == null)
			{
				_IPTCExtSeriesName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSeriesName");
			}
			return _IPTCExtSeriesName;
		}
	}

	[Field("kCGImagePropertyIPTCExtShownEvent", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtShownEvent
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtShownEvent == null)
			{
				_IPTCExtShownEvent = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtShownEvent");
			}
			return _IPTCExtShownEvent;
		}
	}

	[Field("kCGImagePropertyIPTCExtShownEventIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtShownEventIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtShownEventIdentifier == null)
			{
				_IPTCExtShownEventIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtShownEventIdentifier");
			}
			return _IPTCExtShownEventIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtShownEventName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtShownEventName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtShownEventName == null)
			{
				_IPTCExtShownEventName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtShownEventName");
			}
			return _IPTCExtShownEventName;
		}
	}

	[Field("kCGImagePropertyIPTCExtStorylineIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtStorylineIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtStorylineIdentifier == null)
			{
				_IPTCExtStorylineIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtStorylineIdentifier");
			}
			return _IPTCExtStorylineIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtStreamReady", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtStreamReady
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtStreamReady == null)
			{
				_IPTCExtStreamReady = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtStreamReady");
			}
			return _IPTCExtStreamReady;
		}
	}

	[Field("kCGImagePropertyIPTCExtStylePeriod", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtStylePeriod
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtStylePeriod == null)
			{
				_IPTCExtStylePeriod = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtStylePeriod");
			}
			return _IPTCExtStylePeriod;
		}
	}

	[Field("kCGImagePropertyIPTCExtSupplyChainSource", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSupplyChainSource
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSupplyChainSource == null)
			{
				_IPTCExtSupplyChainSource = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSupplyChainSource");
			}
			return _IPTCExtSupplyChainSource;
		}
	}

	[Field("kCGImagePropertyIPTCExtSupplyChainSourceIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSupplyChainSourceIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSupplyChainSourceIdentifier == null)
			{
				_IPTCExtSupplyChainSourceIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSupplyChainSourceIdentifier");
			}
			return _IPTCExtSupplyChainSourceIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtSupplyChainSourceName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtSupplyChainSourceName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtSupplyChainSourceName == null)
			{
				_IPTCExtSupplyChainSourceName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtSupplyChainSourceName");
			}
			return _IPTCExtSupplyChainSourceName;
		}
	}

	[Field("kCGImagePropertyIPTCExtTemporalCoverage", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtTemporalCoverage
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtTemporalCoverage == null)
			{
				_IPTCExtTemporalCoverage = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTemporalCoverage");
			}
			return _IPTCExtTemporalCoverage;
		}
	}

	[Field("kCGImagePropertyIPTCExtTemporalCoverageFrom", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtTemporalCoverageFrom
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtTemporalCoverageFrom == null)
			{
				_IPTCExtTemporalCoverageFrom = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTemporalCoverageFrom");
			}
			return _IPTCExtTemporalCoverageFrom;
		}
	}

	[Field("kCGImagePropertyIPTCExtTemporalCoverageTo", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtTemporalCoverageTo
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtTemporalCoverageTo == null)
			{
				_IPTCExtTemporalCoverageTo = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTemporalCoverageTo");
			}
			return _IPTCExtTemporalCoverageTo;
		}
	}

	[Field("kCGImagePropertyIPTCExtTranscript", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtTranscript
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtTranscript == null)
			{
				_IPTCExtTranscript = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscript");
			}
			return _IPTCExtTranscript;
		}
	}

	[Field("kCGImagePropertyIPTCExtTranscriptLink", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtTranscriptLink
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtTranscriptLink == null)
			{
				_IPTCExtTranscriptLink = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscriptLink");
			}
			return _IPTCExtTranscriptLink;
		}
	}

	[Field("kCGImagePropertyIPTCExtTranscriptLinkLink", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtTranscriptLinkLink
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtTranscriptLinkLink == null)
			{
				_IPTCExtTranscriptLinkLink = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscriptLinkLink");
			}
			return _IPTCExtTranscriptLinkLink;
		}
	}

	[Field("kCGImagePropertyIPTCExtTranscriptLinkLinkQualifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtTranscriptLinkLinkQualifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtTranscriptLinkLinkQualifier == null)
			{
				_IPTCExtTranscriptLinkLinkQualifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtTranscriptLinkLinkQualifier");
			}
			return _IPTCExtTranscriptLinkLinkQualifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoBitrate", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoBitrate
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoBitrate == null)
			{
				_IPTCExtVideoBitrate = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoBitrate");
			}
			return _IPTCExtVideoBitrate;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoBitrateMode", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoBitrateMode
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoBitrateMode == null)
			{
				_IPTCExtVideoBitrateMode = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoBitrateMode");
			}
			return _IPTCExtVideoBitrateMode;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoDisplayAspectRatio", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoDisplayAspectRatio
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoDisplayAspectRatio == null)
			{
				_IPTCExtVideoDisplayAspectRatio = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoDisplayAspectRatio");
			}
			return _IPTCExtVideoDisplayAspectRatio;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoEncodingProfile", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoEncodingProfile
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoEncodingProfile == null)
			{
				_IPTCExtVideoEncodingProfile = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoEncodingProfile");
			}
			return _IPTCExtVideoEncodingProfile;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoShotType", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoShotType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoShotType == null)
			{
				_IPTCExtVideoShotType = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoShotType");
			}
			return _IPTCExtVideoShotType;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoShotTypeIdentifier", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoShotTypeIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoShotTypeIdentifier == null)
			{
				_IPTCExtVideoShotTypeIdentifier = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoShotTypeIdentifier");
			}
			return _IPTCExtVideoShotTypeIdentifier;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoShotTypeName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoShotTypeName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoShotTypeName == null)
			{
				_IPTCExtVideoShotTypeName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoShotTypeName");
			}
			return _IPTCExtVideoShotTypeName;
		}
	}

	[Field("kCGImagePropertyIPTCExtVideoStreamsCount", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVideoStreamsCount
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVideoStreamsCount == null)
			{
				_IPTCExtVideoStreamsCount = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVideoStreamsCount");
			}
			return _IPTCExtVideoStreamsCount;
		}
	}

	[Field("kCGImagePropertyIPTCExtVisualColor", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtVisualColor
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtVisualColor == null)
			{
				_IPTCExtVisualColor = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtVisualColor");
			}
			return _IPTCExtVisualColor;
		}
	}

	[Field("kCGImagePropertyIPTCExtWorkflowTag", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtWorkflowTag
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtWorkflowTag == null)
			{
				_IPTCExtWorkflowTag = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTag");
			}
			return _IPTCExtWorkflowTag;
		}
	}

	[Field("kCGImagePropertyIPTCExtWorkflowTagCvId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtWorkflowTagCvId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtWorkflowTagCvId == null)
			{
				_IPTCExtWorkflowTagCvId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvId");
			}
			return _IPTCExtWorkflowTagCvId;
		}
	}

	[Field("kCGImagePropertyIPTCExtWorkflowTagCvTermId", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtWorkflowTagCvTermId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtWorkflowTagCvTermId == null)
			{
				_IPTCExtWorkflowTagCvTermId = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvTermId");
			}
			return _IPTCExtWorkflowTagCvTermId;
		}
	}

	[Field("kCGImagePropertyIPTCExtWorkflowTagCvTermName", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtWorkflowTagCvTermName
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtWorkflowTagCvTermName == null)
			{
				_IPTCExtWorkflowTagCvTermName = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvTermName");
			}
			return _IPTCExtWorkflowTagCvTermName;
		}
	}

	[Field("kCGImagePropertyIPTCExtWorkflowTagCvTermRefinedAbout", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString IPTCExtWorkflowTagCvTermRefinedAbout
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_IPTCExtWorkflowTagCvTermRefinedAbout == null)
			{
				_IPTCExtWorkflowTagCvTermRefinedAbout = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyIPTCExtWorkflowTagCvTermRefinedAbout");
			}
			return _IPTCExtWorkflowTagCvTermRefinedAbout;
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

	[Field("kCGImagePropertyImageCount", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString ImageCount
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ImageCount == null)
			{
				_ImageCount = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyImageCount");
			}
			return _ImageCount;
		}
	}

	[Field("kCGImagePropertyImages", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString Images
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Images == null)
			{
				_Images = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyImages");
			}
			return _Images;
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

	[Field("kCGImagePropertyMakerFujiDictionary", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString MakerFujiDictionary
	{
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_MakerFujiDictionary == null)
			{
				_MakerFujiDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerFujiDictionary");
			}
			return _MakerFujiDictionary;
		}
	}

	[Field("kCGImagePropertyMakerMinoltaDictionary", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString MakerMinoltaDictionary
	{
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_MakerMinoltaDictionary == null)
			{
				_MakerMinoltaDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerMinoltaDictionary");
			}
			return _MakerMinoltaDictionary;
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

	[Field("kCGImagePropertyMakerOlympusDictionary", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString MakerOlympusDictionary
	{
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString MakerPentaxDictionary
	{
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_MakerPentaxDictionary == null)
			{
				_MakerPentaxDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyMakerPentaxDictionary");
			}
			return _MakerPentaxDictionary;
		}
	}

	[Field("kCGImagePropertyNamedColorSpace", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString NamedColorSpace
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NamedColorSpace == null)
			{
				_NamedColorSpace = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyNamedColorSpace");
			}
			return _NamedColorSpace;
		}
	}

	[Field("kCGImagePropertyOpenEXRAspectRatio", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString OpenExrAspectRatio
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_OpenExrAspectRatio == null)
			{
				_OpenExrAspectRatio = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyOpenEXRAspectRatio");
			}
			return _OpenExrAspectRatio;
		}
	}

	[Field("kCGImagePropertyOpenEXRDictionary", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
	public static NSString OpenExrDictionary
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_OpenExrDictionary == null)
			{
				_OpenExrDictionary = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyOpenEXRDictionary");
			}
			return _OpenExrDictionary;
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

	[Field("kCGImagePropertyPNGComment", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString PNGComment
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGComment == null)
			{
				_PNGComment = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGComment");
			}
			return _PNGComment;
		}
	}

	[Field("kCGImagePropertyPNGCompressionFilter", "ImageIO")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString PNGCompressionFilter
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGCompressionFilter == null)
			{
				_PNGCompressionFilter = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGCompressionFilter");
			}
			return _PNGCompressionFilter;
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

	[Field("kCGImagePropertyAPNGDelayTime", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString PNGDelayTime
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGDelayTime == null)
			{
				_PNGDelayTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAPNGDelayTime");
			}
			return _PNGDelayTime;
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

	[Field("kCGImagePropertyPNGDisclaimer", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString PNGDisclaimer
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGDisclaimer == null)
			{
				_PNGDisclaimer = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGDisclaimer");
			}
			return _PNGDisclaimer;
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

	[Field("kCGImagePropertyAPNGLoopCount", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString PNGLoopCount
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGLoopCount == null)
			{
				_PNGLoopCount = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAPNGLoopCount");
			}
			return _PNGLoopCount;
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

	[Field("kCGImagePropertyPNGSource", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString PNGSource
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGSource == null)
			{
				_PNGSource = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGSource");
			}
			return _PNGSource;
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

	[Field("kCGImagePropertyAPNGUnclampedDelayTime", "ImageIO")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString PNGUnclampedDelayTime
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGUnclampedDelayTime == null)
			{
				_PNGUnclampedDelayTime = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyAPNGUnclampedDelayTime");
			}
			return _PNGUnclampedDelayTime;
		}
	}

	[Field("kCGImagePropertyPNGWarning", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString PNGWarning
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PNGWarning == null)
			{
				_PNGWarning = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPNGWarning");
			}
			return _PNGWarning;
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

	[Field("kCGImagePropertyPixelFormat", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString PixelFormat
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PixelFormat == null)
			{
				_PixelFormat = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPixelFormat");
			}
			return _PixelFormat;
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

	[Field("kCGImagePropertyPrimaryImage", "ImageIO")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString PrimaryImage
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PrimaryImage == null)
			{
				_PrimaryImage = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyPrimaryImage");
			}
			return _PrimaryImage;
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

	[Field("kCGImagePropertyTIFFTileLength", "ImageIO")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString TIFFTileLength
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TIFFTileLength == null)
			{
				_TIFFTileLength = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFTileLength");
			}
			return _TIFFTileLength;
		}
	}

	[Field("kCGImagePropertyTIFFTileWidth", "ImageIO")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString TIFFTileWidth
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TIFFTileWidth == null)
			{
				_TIFFTileWidth = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyTIFFTileWidth");
			}
			return _TIFFTileWidth;
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

	[Field("kCGImagePropertyThumbnailImages", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString ThumbnailImages
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ThumbnailImages == null)
			{
				_ThumbnailImages = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyThumbnailImages");
			}
			return _ThumbnailImages;
		}
	}

	[Field("kCGImagePropertyWidth", "ImageIO")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public static NSString Width
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Width == null)
			{
				_Width = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImagePropertyWidth");
			}
			return _Width;
		}
	}
}
