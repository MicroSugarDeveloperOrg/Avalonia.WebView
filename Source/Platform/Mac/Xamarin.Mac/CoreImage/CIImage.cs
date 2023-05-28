using System.ComponentModel;
using AppKit;
using AVFoundation;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ImageIO;
using IOSurface;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreImage;

[Register("CIImage", true)]
public class CIImage : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGImage = "CGImage";

	private static readonly IntPtr selCGImageHandle = Selector.GetHandle("CGImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoAdjustmentFiltersWithOptions_ = "autoAdjustmentFiltersWithOptions:";

	private static readonly IntPtr selAutoAdjustmentFiltersWithOptions_Handle = Selector.GetHandle("autoAdjustmentFiltersWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlackImage = "blackImage";

	private static readonly IntPtr selBlackImageHandle = Selector.GetHandle("blackImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlueImage = "blueImage";

	private static readonly IntPtr selBlueImageHandle = Selector.GetHandle("blueImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearImage = "clearImage";

	private static readonly IntPtr selClearImageHandle = Selector.GetHandle("clearImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCyanImage = "cyanImage";

	private static readonly IntPtr selCyanImageHandle = Selector.GetHandle("cyanImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefinition = "definition";

	private static readonly IntPtr selDefinitionHandle = Selector.GetHandle("definition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthData = "depthData";

	private static readonly IntPtr selDepthDataHandle = Selector.GetHandle("depthData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawAtPoint_FromRect_Operation_Fraction_ = "drawAtPoint:fromRect:operation:fraction:";

	private static readonly IntPtr selDrawAtPoint_FromRect_Operation_Fraction_Handle = Selector.GetHandle("drawAtPoint:fromRect:operation:fraction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_FromRect_Operation_Fraction_ = "drawInRect:fromRect:operation:fraction:";

	private static readonly IntPtr selDrawInRect_FromRect_Operation_Fraction_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmptyImage = "emptyImage";

	private static readonly IntPtr selEmptyImageHandle = Selector.GetHandle("emptyImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtent = "extent";

	private static readonly IntPtr selExtentHandle = Selector.GetHandle("extent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrayImage = "grayImage";

	private static readonly IntPtr selGrayImageHandle = Selector.GetHandle("grayImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGreenImage = "greenImage";

	private static readonly IntPtr selGreenImageHandle = Selector.GetHandle("greenImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByApplyingCGOrientation_ = "imageByApplyingCGOrientation:";

	private static readonly IntPtr selImageByApplyingCGOrientation_Handle = Selector.GetHandle("imageByApplyingCGOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByApplyingFilter_ = "imageByApplyingFilter:";

	private static readonly IntPtr selImageByApplyingFilter_Handle = Selector.GetHandle("imageByApplyingFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByApplyingFilter_WithInputParameters_ = "imageByApplyingFilter:withInputParameters:";

	private static readonly IntPtr selImageByApplyingFilter_WithInputParameters_Handle = Selector.GetHandle("imageByApplyingFilter:withInputParameters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByApplyingGaussianBlurWithSigma_ = "imageByApplyingGaussianBlurWithSigma:";

	private static readonly IntPtr selImageByApplyingGaussianBlurWithSigma_Handle = Selector.GetHandle("imageByApplyingGaussianBlurWithSigma:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByApplyingOrientation_ = "imageByApplyingOrientation:";

	private static readonly IntPtr selImageByApplyingOrientation_Handle = Selector.GetHandle("imageByApplyingOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByApplyingTransform_ = "imageByApplyingTransform:";

	private static readonly IntPtr selImageByApplyingTransform_Handle = Selector.GetHandle("imageByApplyingTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByApplyingTransform_HighQualityDownsample_ = "imageByApplyingTransform:highQualityDownsample:";

	private static readonly IntPtr selImageByApplyingTransform_HighQualityDownsample_Handle = Selector.GetHandle("imageByApplyingTransform:highQualityDownsample:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByClampingToExtent = "imageByClampingToExtent";

	private static readonly IntPtr selImageByClampingToExtentHandle = Selector.GetHandle("imageByClampingToExtent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByClampingToRect_ = "imageByClampingToRect:";

	private static readonly IntPtr selImageByClampingToRect_Handle = Selector.GetHandle("imageByClampingToRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByColorMatchingColorSpaceToWorkingSpace_ = "imageByColorMatchingColorSpaceToWorkingSpace:";

	private static readonly IntPtr selImageByColorMatchingColorSpaceToWorkingSpace_Handle = Selector.GetHandle("imageByColorMatchingColorSpaceToWorkingSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByColorMatchingWorkingSpaceToColorSpace_ = "imageByColorMatchingWorkingSpaceToColorSpace:";

	private static readonly IntPtr selImageByColorMatchingWorkingSpaceToColorSpace_Handle = Selector.GetHandle("imageByColorMatchingWorkingSpaceToColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByCompositingOverImage_ = "imageByCompositingOverImage:";

	private static readonly IntPtr selImageByCompositingOverImage_Handle = Selector.GetHandle("imageByCompositingOverImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByCroppingToRect_ = "imageByCroppingToRect:";

	private static readonly IntPtr selImageByCroppingToRect_Handle = Selector.GetHandle("imageByCroppingToRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByInsertingIntermediate = "imageByInsertingIntermediate";

	private static readonly IntPtr selImageByInsertingIntermediateHandle = Selector.GetHandle("imageByInsertingIntermediate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByInsertingIntermediate_ = "imageByInsertingIntermediate:";

	private static readonly IntPtr selImageByInsertingIntermediate_Handle = Selector.GetHandle("imageByInsertingIntermediate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByPremultiplyingAlpha = "imageByPremultiplyingAlpha";

	private static readonly IntPtr selImageByPremultiplyingAlphaHandle = Selector.GetHandle("imageByPremultiplyingAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageBySamplingLinear = "imageBySamplingLinear";

	private static readonly IntPtr selImageBySamplingLinearHandle = Selector.GetHandle("imageBySamplingLinear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageBySamplingNearest = "imageBySamplingNearest";

	private static readonly IntPtr selImageBySamplingNearestHandle = Selector.GetHandle("imageBySamplingNearest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageBySettingAlphaOneInExtent_ = "imageBySettingAlphaOneInExtent:";

	private static readonly IntPtr selImageBySettingAlphaOneInExtent_Handle = Selector.GetHandle("imageBySettingAlphaOneInExtent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageBySettingProperties_ = "imageBySettingProperties:";

	private static readonly IntPtr selImageBySettingProperties_Handle = Selector.GetHandle("imageBySettingProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageByUnpremultiplyingAlpha = "imageByUnpremultiplyingAlpha";

	private static readonly IntPtr selImageByUnpremultiplyingAlphaHandle = Selector.GetHandle("imageByUnpremultiplyingAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageTransformForCGOrientation_ = "imageTransformForCGOrientation:";

	private static readonly IntPtr selImageTransformForCGOrientation_Handle = Selector.GetHandle("imageTransformForCGOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageTransformForOrientation_ = "imageTransformForOrientation:";

	private static readonly IntPtr selImageTransformForOrientation_Handle = Selector.GetHandle("imageTransformForOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithBitmapData_BytesPerRow_Size_Format_ColorSpace_ = "imageWithBitmapData:bytesPerRow:size:format:colorSpace:";

	private static readonly IntPtr selImageWithBitmapData_BytesPerRow_Size_Format_ColorSpace_Handle = Selector.GetHandle("imageWithBitmapData:bytesPerRow:size:format:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithCGImage_ = "imageWithCGImage:";

	private static readonly IntPtr selImageWithCGImage_Handle = Selector.GetHandle("imageWithCGImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithCGImage_Options_ = "imageWithCGImage:options:";

	private static readonly IntPtr selImageWithCGImage_Options_Handle = Selector.GetHandle("imageWithCGImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithCGImageSource_Index_Options_ = "imageWithCGImageSource:index:options:";

	private static readonly IntPtr selImageWithCGImageSource_Index_Options_Handle = Selector.GetHandle("imageWithCGImageSource:index:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithCGLayer_ = "imageWithCGLayer:";

	private static readonly IntPtr selImageWithCGLayer_Handle = Selector.GetHandle("imageWithCGLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithCGLayer_Options_ = "imageWithCGLayer:options:";

	private static readonly IntPtr selImageWithCGLayer_Options_Handle = Selector.GetHandle("imageWithCGLayer:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithCVImageBuffer_ = "imageWithCVImageBuffer:";

	private static readonly IntPtr selImageWithCVImageBuffer_Handle = Selector.GetHandle("imageWithCVImageBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithCVImageBuffer_Options_ = "imageWithCVImageBuffer:options:";

	private static readonly IntPtr selImageWithCVImageBuffer_Options_Handle = Selector.GetHandle("imageWithCVImageBuffer:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithColor_ = "imageWithColor:";

	private static readonly IntPtr selImageWithColor_Handle = Selector.GetHandle("imageWithColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithContentsOfURL_ = "imageWithContentsOfURL:";

	private static readonly IntPtr selImageWithContentsOfURL_Handle = Selector.GetHandle("imageWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithContentsOfURL_Options_ = "imageWithContentsOfURL:options:";

	private static readonly IntPtr selImageWithContentsOfURL_Options_Handle = Selector.GetHandle("imageWithContentsOfURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithData_ = "imageWithData:";

	private static readonly IntPtr selImageWithData_Handle = Selector.GetHandle("imageWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithData_Options_ = "imageWithData:options:";

	private static readonly IntPtr selImageWithData_Options_Handle = Selector.GetHandle("imageWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithDepthData_ = "imageWithDepthData:";

	private static readonly IntPtr selImageWithDepthData_Handle = Selector.GetHandle("imageWithDepthData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithDepthData_Options_ = "imageWithDepthData:options:";

	private static readonly IntPtr selImageWithDepthData_Options_Handle = Selector.GetHandle("imageWithDepthData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithIOSurface_ = "imageWithIOSurface:";

	private static readonly IntPtr selImageWithIOSurface_Handle = Selector.GetHandle("imageWithIOSurface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithIOSurface_Options_ = "imageWithIOSurface:options:";

	private static readonly IntPtr selImageWithIOSurface_Options_Handle = Selector.GetHandle("imageWithIOSurface:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithImageProvider_Size__Format_ColorSpace_Options_ = "imageWithImageProvider:size::format:colorSpace:options:";

	private static readonly IntPtr selImageWithImageProvider_Size__Format_ColorSpace_Options_Handle = Selector.GetHandle("imageWithImageProvider:size::format:colorSpace:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithMTLTexture_Options_ = "imageWithMTLTexture:options:";

	private static readonly IntPtr selImageWithMTLTexture_Options_Handle = Selector.GetHandle("imageWithMTLTexture:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithPortaitEffectsMatte_ = "imageWithPortaitEffectsMatte:";

	private static readonly IntPtr selImageWithPortaitEffectsMatte_Handle = Selector.GetHandle("imageWithPortaitEffectsMatte:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithPortaitEffectsMatte_Options_ = "imageWithPortaitEffectsMatte:options:";

	private static readonly IntPtr selImageWithPortaitEffectsMatte_Options_Handle = Selector.GetHandle("imageWithPortaitEffectsMatte:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithSemanticSegmentationMatte_ = "imageWithSemanticSegmentationMatte:";

	private static readonly IntPtr selImageWithSemanticSegmentationMatte_Handle = Selector.GetHandle("imageWithSemanticSegmentationMatte:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithSemanticSegmentationMatte_Options_ = "imageWithSemanticSegmentationMatte:options:";

	private static readonly IntPtr selImageWithSemanticSegmentationMatte_Options_Handle = Selector.GetHandle("imageWithSemanticSegmentationMatte:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithTexture_Size_Flipped_ColorSpace_ = "imageWithTexture:size:flipped:colorSpace:";

	private static readonly IntPtr selImageWithTexture_Size_Flipped_ColorSpace_Handle = Selector.GetHandle("imageWithTexture:size:flipped:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBitmapData_BytesPerRow_Size_Format_ColorSpace_ = "initWithBitmapData:bytesPerRow:size:format:colorSpace:";

	private static readonly IntPtr selInitWithBitmapData_BytesPerRow_Size_Format_ColorSpace_Handle = Selector.GetHandle("initWithBitmapData:bytesPerRow:size:format:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBitmapImageRep_ = "initWithBitmapImageRep:";

	private static readonly IntPtr selInitWithBitmapImageRep_Handle = Selector.GetHandle("initWithBitmapImageRep:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGImage_ = "initWithCGImage:";

	private static readonly IntPtr selInitWithCGImage_Handle = Selector.GetHandle("initWithCGImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGImage_Options_ = "initWithCGImage:options:";

	private static readonly IntPtr selInitWithCGImage_Options_Handle = Selector.GetHandle("initWithCGImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGImageSource_Index_Options_ = "initWithCGImageSource:index:options:";

	private static readonly IntPtr selInitWithCGImageSource_Index_Options_Handle = Selector.GetHandle("initWithCGImageSource:index:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGLayer_ = "initWithCGLayer:";

	private static readonly IntPtr selInitWithCGLayer_Handle = Selector.GetHandle("initWithCGLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGLayer_Options_ = "initWithCGLayer:options:";

	private static readonly IntPtr selInitWithCGLayer_Options_Handle = Selector.GetHandle("initWithCGLayer:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCVImageBuffer_ = "initWithCVImageBuffer:";

	private static readonly IntPtr selInitWithCVImageBuffer_Handle = Selector.GetHandle("initWithCVImageBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCVImageBuffer_Options_ = "initWithCVImageBuffer:options:";

	private static readonly IntPtr selInitWithCVImageBuffer_Options_Handle = Selector.GetHandle("initWithCVImageBuffer:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCVPixelBuffer_ = "initWithCVPixelBuffer:";

	private static readonly IntPtr selInitWithCVPixelBuffer_Handle = Selector.GetHandle("initWithCVPixelBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCVPixelBuffer_Options_ = "initWithCVPixelBuffer:options:";

	private static readonly IntPtr selInitWithCVPixelBuffer_Options_Handle = Selector.GetHandle("initWithCVPixelBuffer:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithColor_ = "initWithColor:";

	private static readonly IntPtr selInitWithColor_Handle = Selector.GetHandle("initWithColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_Options_ = "initWithContentsOfURL:options:";

	private static readonly IntPtr selInitWithContentsOfURL_Options_Handle = Selector.GetHandle("initWithContentsOfURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Options_ = "initWithData:options:";

	private static readonly IntPtr selInitWithData_Options_Handle = Selector.GetHandle("initWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDepthData_ = "initWithDepthData:";

	private static readonly IntPtr selInitWithDepthData_Handle = Selector.GetHandle("initWithDepthData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDepthData_Options_ = "initWithDepthData:options:";

	private static readonly IntPtr selInitWithDepthData_Options_Handle = Selector.GetHandle("initWithDepthData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIOSurface_ = "initWithIOSurface:";

	private static readonly IntPtr selInitWithIOSurface_Handle = Selector.GetHandle("initWithIOSurface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIOSurface_Options_ = "initWithIOSurface:options:";

	private static readonly IntPtr selInitWithIOSurface_Options_Handle = Selector.GetHandle("initWithIOSurface:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImageProvider_Size__Format_ColorSpace_Options_ = "initWithImageProvider:size::format:colorSpace:options:";

	private static readonly IntPtr selInitWithImageProvider_Size__Format_ColorSpace_Options_Handle = Selector.GetHandle("initWithImageProvider:size::format:colorSpace:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMTLTexture_Options_ = "initWithMTLTexture:options:";

	private static readonly IntPtr selInitWithMTLTexture_Options_Handle = Selector.GetHandle("initWithMTLTexture:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPortaitEffectsMatte_ = "initWithPortaitEffectsMatte:";

	private static readonly IntPtr selInitWithPortaitEffectsMatte_Handle = Selector.GetHandle("initWithPortaitEffectsMatte:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPortaitEffectsMatte_Options_ = "initWithPortaitEffectsMatte:options:";

	private static readonly IntPtr selInitWithPortaitEffectsMatte_Options_Handle = Selector.GetHandle("initWithPortaitEffectsMatte:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSemanticSegmentationMatte_ = "initWithSemanticSegmentationMatte:";

	private static readonly IntPtr selInitWithSemanticSegmentationMatte_Handle = Selector.GetHandle("initWithSemanticSegmentationMatte:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSemanticSegmentationMatte_Options_ = "initWithSemanticSegmentationMatte:options:";

	private static readonly IntPtr selInitWithSemanticSegmentationMatte_Options_Handle = Selector.GetHandle("initWithSemanticSegmentationMatte:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTexture_Size_Flipped_ColorSpace_ = "initWithTexture:size:flipped:colorSpace:";

	private static readonly IntPtr selInitWithTexture_Size_Flipped_ColorSpace_Handle = Selector.GetHandle("initWithTexture:size:flipped:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagentaImage = "magentaImage";

	private static readonly IntPtr selMagentaImageHandle = Selector.GetHandle("magentaImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBuffer = "pixelBuffer";

	private static readonly IntPtr selPixelBufferHandle = Selector.GetHandle("pixelBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortraitEffectsMatte = "portraitEffectsMatte";

	private static readonly IntPtr selPortraitEffectsMatteHandle = Selector.GetHandle("portraitEffectsMatte");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProperties = "properties";

	private static readonly IntPtr selPropertiesHandle = Selector.GetHandle("properties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedImage = "redImage";

	private static readonly IntPtr selRedImageHandle = Selector.GetHandle("redImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionOfInterestForImage_InRect_ = "regionOfInterestForImage:inRect:";

	private static readonly IntPtr selRegionOfInterestForImage_InRect_Handle = Selector.GetHandle("regionOfInterestForImage:inRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSemanticSegmentationMatte = "semanticSegmentationMatte";

	private static readonly IntPtr selSemanticSegmentationMatteHandle = Selector.GetHandle("semanticSegmentationMatte");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhiteImage = "whiteImage";

	private static readonly IntPtr selWhiteImageHandle = Selector.GetHandle("whiteImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYellowImage = "yellowImage";

	private static readonly IntPtr selYellowImageHandle = Selector.GetHandle("yellowImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AutoAdjustCrop;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AutoAdjustEnhanceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AutoAdjustFeaturesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AutoAdjustLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AutoAdjustRedEyeKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage BlackImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("blackImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selBlackImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage BlueImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("blueImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selBlueImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual CGImage? CGImage
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("CGImage")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGImageHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGImageHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage ClearImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("clearImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selClearImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual CGColorSpace? ColorSpace
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("colorSpace")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage CyanImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("cyanImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selCyanImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Definition
	{
		[Export("definition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefinitionHandle));
			}
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefinitionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual AVDepthData? DepthData
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("depthData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDepthDataHandle));
			}
			return Runtime.GetNSObject<AVDepthData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDepthDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage EmptyImage
	{
		[Export("emptyImage")]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selEmptyImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Extent
	{
		[Export("extent")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtentHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtentHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage GrayImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("grayImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selGrayImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage GreenImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("greenImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selGreenImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage MagentaImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("magentaImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selMagentaImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual CVPixelBuffer? PixelBuffer
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("pixelBuffer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferHandle), owns: false);
			}
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual AVPortraitEffectsMatte? PortraitEffectsMatte
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("portraitEffectsMatte")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVPortraitEffectsMatte>(Messaging.IntPtr_objc_msgSend(base.Handle, selPortraitEffectsMatteHandle));
			}
			return Runtime.GetNSObject<AVPortraitEffectsMatte>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPortraitEffectsMatteHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CoreGraphics.CGImageProperties Properties
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakProperties != null) ? new NSMutableDictionary(WeakProperties) : null);
			return (nSMutableDictionary == null) ? null : new CoreGraphics.CGImageProperties(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage RedImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("redImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selRedImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual AVSemanticSegmentationMatte? SemanticSegmentationMatte
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("semanticSegmentationMatte")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVSemanticSegmentationMatte>(Messaging.IntPtr_objc_msgSend(base.Handle, selSemanticSegmentationMatteHandle));
			}
			return Runtime.GetNSObject<AVSemanticSegmentationMatte>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSemanticSegmentationMatteHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual NSUrl? Url
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("url")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSDictionary WeakProperties
	{
		[Export("properties")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertiesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage WhiteImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("whiteImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selWhiteImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static CIImage YellowImage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("yellowImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(class_ptr, selYellowImageHandle));
		}
	}

	[Field("kCIImageAutoAdjustCrop", "CoreImage")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	internal static NSString AutoAdjustCrop
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AutoAdjustCrop == null)
			{
				_AutoAdjustCrop = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustCrop");
			}
			return _AutoAdjustCrop;
		}
	}

	[Field("kCIImageAutoAdjustEnhance", "CoreImage")]
	internal static NSString AutoAdjustEnhanceKey
	{
		get
		{
			if (_AutoAdjustEnhanceKey == null)
			{
				_AutoAdjustEnhanceKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustEnhance");
			}
			return _AutoAdjustEnhanceKey;
		}
	}

	[Field("kCIImageAutoAdjustFeatures", "CoreImage")]
	internal static NSString AutoAdjustFeaturesKey
	{
		get
		{
			if (_AutoAdjustFeaturesKey == null)
			{
				_AutoAdjustFeaturesKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustFeatures");
			}
			return _AutoAdjustFeaturesKey;
		}
	}

	[Field("kCIImageAutoAdjustLevel", "CoreImage")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	internal static NSString AutoAdjustLevel
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AutoAdjustLevel == null)
			{
				_AutoAdjustLevel = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustLevel");
			}
			return _AutoAdjustLevel;
		}
	}

	[Field("kCIImageAutoAdjustRedEye", "CoreImage")]
	internal static NSString AutoAdjustRedEyeKey
	{
		get
		{
			if (_AutoAdjustRedEyeKey == null)
			{
				_AutoAdjustRedEyeKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAutoAdjustRedEye");
			}
			return _AutoAdjustRedEyeKey;
		}
	}

	[Field("kCIFormatA16", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatA16
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatA16");
		}
	}

	[Field("kCIFormatA8", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatA8
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatA8");
		}
	}

	[Field("kCIFormatABGR8", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatABGR8
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatABGR8");
		}
	}

	[Field("kCIFormatARGB8", "CoreImage")]
	public static int FormatARGB8 => Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatARGB8");

	[Field("kCIFormatAf", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatAf
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatAf");
		}
	}

	[Field("kCIFormatAh", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatAh
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatAh");
		}
	}

	[Field("kCIFormatBGRA8", "CoreImage")]
	public static int FormatBGRA8 => Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatBGRA8");

	[Field("kCIFormatL16", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatL16
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatL16");
		}
	}

	[Field("kCIFormatL8", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatL8
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatL8");
		}
	}

	[Field("kCIFormatLA16", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatLA16
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatLA16");
		}
	}

	[Field("kCIFormatLA8", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatLA8
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatLA8");
		}
	}

	[Field("kCIFormatLAf", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatLAf
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatLAf");
		}
	}

	[Field("kCIFormatLAh", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatLAh
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatLAh");
		}
	}

	[Field("kCIFormatLf", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatLf
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatLf");
		}
	}

	[Field("kCIFormatLh", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static int FormatLh
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatLh");
		}
	}

	[Field("kCIFormatR16", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatR16
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatR16");
		}
	}

	[Field("kCIFormatR8", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatR8
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatR8");
		}
	}

	[Field("kCIFormatRG16", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatRG16
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRG16");
		}
	}

	[Field("kCIFormatRG8", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatRG8
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRG8");
		}
	}

	[Field("kCIFormatRGBA16", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static int FormatRGBA16
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRGBA16");
		}
	}

	[Field("kCIFormatRGBA8", "CoreImage")]
	public static int FormatRGBA8 => Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRGBA8");

	[Field("kCIFormatRGBAf", "CoreImage")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static int FormatRGBAf
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRGBAf");
		}
	}

	[Field("kCIFormatRGBAh", "CoreImage")]
	public static int FormatRGBAh => Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRGBAh");

	[Field("kCIFormatRGf", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatRGf
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRGf");
		}
	}

	[Field("kCIFormatRGh", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatRGh
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRGh");
		}
	}

	[Field("kCIFormatRf", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatRf
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRf");
		}
	}

	[Field("kCIFormatRh", "CoreImage")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static int FormatRh
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetInt32(Libraries.CoreImage.Handle, "kCIFormatRh");
		}
	}

	private static CIFilter[] WrapFilters(NSArray filters)
	{
		if (filters == null)
		{
			return new CIFilter[0];
		}
		nuint count = filters.Count;
		if (count == (byte)0)
		{
			return new CIFilter[0];
		}
		CIFilter[] array = new CIFilter[(ulong)count];
		for (nuint nuint = (byte)0; nuint < count; ++nuint)
		{
			IntPtr filterHandle = filters.ValueAt(nuint);
			string filterName = CIFilter.GetFilterName(filterHandle);
			array[(ulong)nuint] = CIFilter.FromName(filterName, filterHandle);
		}
		return array;
	}

	public static CIImage FromCGImage(CGImage image, CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		using NSArray objects = NSArray.FromIntPtrs(new IntPtr[1] { colorSpace.Handle });
		using NSArray keys = NSArray.FromIntPtrs(new IntPtr[1] { CIImageInitializationOptionsKeys.ColorSpaceKey.Handle });
		using NSDictionary d = NSDictionary.FromObjectsAndKeysInternal(objects, keys);
		return FromCGImage(image, d);
	}

	public CIFilter[] GetAutoAdjustmentFilters()
	{
		return GetAutoAdjustmentFilters(null);
	}

	public CIFilter[] GetAutoAdjustmentFilters(CIAutoAdjustmentFilterOptions options)
	{
		NSDictionary opts = options?.ToDictionary();
		return WrapFilters(_GetAutoAdjustmentFilters(opts));
	}

	public static implicit operator CIImage(CGImage image)
	{
		return FromCGImage(image);
	}

	internal static int CIFormatToInt(CIFormat format)
	{
		return format switch
		{
			CIFormat.ARGB8 => FormatARGB8, 
			CIFormat.RGBAh => FormatRGBAh, 
			CIFormat.RGBA16 => FormatRGBA16, 
			CIFormat.RGBAf => FormatRGBAf, 
			CIFormat.kRGBAf => FormatRGBAf, 
			CIFormat.kBGRA8 => FormatBGRA8, 
			CIFormat.kRGBA8 => FormatRGBA8, 
			CIFormat.ABGR8 => FormatABGR8, 
			CIFormat.A8 => FormatA8, 
			CIFormat.A16 => FormatA16, 
			CIFormat.Ah => FormatAh, 
			CIFormat.Af => FormatAf, 
			CIFormat.R8 => FormatR8, 
			CIFormat.R16 => FormatR16, 
			CIFormat.Rh => FormatRh, 
			CIFormat.Rf => FormatRf, 
			CIFormat.RG8 => FormatRG8, 
			CIFormat.RG16 => FormatRG16, 
			CIFormat.RGh => FormatRGh, 
			CIFormat.RGf => FormatRGf, 
			_ => throw new ArgumentOutOfRangeException("format"), 
		};
	}

	public static CIImage FromData(NSData bitmapData, nint bytesPerRow, CGSize size, CIFormat pixelFormat, CGColorSpace colorSpace)
	{
		return FromData(bitmapData, bytesPerRow, size, CIFormatToInt(pixelFormat), colorSpace);
	}

	public static CIImage FromProvider(ICIImageProvider provider, nuint width, nuint height, CIFormat pixelFormat, CGColorSpace colorSpace, CIImageProviderOptions options)
	{
		return FromProvider(provider, width, height, CIFormatToInt(pixelFormat), colorSpace, options?.Dictionary);
	}

	public CIImage(ICIImageProvider provider, nuint width, nuint height, CIFormat pixelFormat, CGColorSpace colorSpace, CIImageProviderOptions options)
		: this(provider, width, height, CIFormatToInt(pixelFormat), colorSpace, options?.Dictionary)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIImage(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIImage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIImage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCGImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGImage image)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGImage_Handle, image.Handle), "initWithCGImage:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGImage_Handle, image.Handle), "initWithCGImage:");
		}
	}

	[Export("initWithCGImage:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGImage image, NSDictionary? d)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCGImage_Options_Handle, image.Handle, d?.Handle ?? IntPtr.Zero), "initWithCGImage:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCGImage_Options_Handle, image.Handle, d?.Handle ?? IntPtr.Zero), "initWithCGImage:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGImage image, CIImageInitializationOptionsWithMetadata? options)
		: this(image, options.GetDictionary())
	{
	}

	[Export("initWithCGImageSource:index:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGImageSource source, nuint index, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(base.Handle, selInitWithCGImageSource_Index_Options_Handle, source.Handle, index, options?.Handle ?? IntPtr.Zero), "initWithCGImageSource:index:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr(base.SuperHandle, selInitWithCGImageSource_Index_Options_Handle, source.Handle, index, options?.Handle ?? IntPtr.Zero), "initWithCGImageSource:index:options:");
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGImageSource source, nuint index, CIImageInitializationOptionsWithMetadata options)
		: this(source, index, options.GetDictionary())
	{
	}

	[Export("initWithCGLayer:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'CIImage (CGImage)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGLayer layer)
		: base(NSObjectFlag.Empty)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGLayer_Handle, layer.Handle), "initWithCGLayer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGLayer_Handle, layer.Handle), "initWithCGLayer:");
		}
	}

	[Export("initWithCGLayer:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'CIImage (CGImage)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGLayer layer, NSDictionary? d)
		: base(NSObjectFlag.Empty)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCGLayer_Options_Handle, layer.Handle, d?.Handle ?? IntPtr.Zero), "initWithCGLayer:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCGLayer_Options_Handle, layer.Handle, d?.Handle ?? IntPtr.Zero), "initWithCGLayer:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CGLayer layer, CIImageInitializationOptions? options)
		: this(layer, options.GetDictionary())
	{
	}

	[Export("initWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
	}

	[Export("initWithData:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSData data, NSDictionary? d)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithData_Options_Handle, data.Handle, d?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithData_Options_Handle, data.Handle, d?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSData data, CIImageInitializationOptionsWithMetadata? options)
		: this(data, options.GetDictionary())
	{
	}

	[Export("initWithBitmapData:bytesPerRow:size:format:colorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSData d, nint bytesPerRow, CGSize size, int pixelFormat, CGColorSpace? colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_CGSize_int_IntPtr(base.Handle, selInitWithBitmapData_BytesPerRow_Size_Format_ColorSpace_Handle, d.Handle, bytesPerRow, size, pixelFormat, colorSpace?.Handle ?? IntPtr.Zero), "initWithBitmapData:bytesPerRow:size:format:colorSpace:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_CGSize_int_IntPtr(base.SuperHandle, selInitWithBitmapData_BytesPerRow_Size_Format_ColorSpace_Handle, d.Handle, bytesPerRow, size, pixelFormat, colorSpace?.Handle ?? IntPtr.Zero), "initWithBitmapData:bytesPerRow:size:format:colorSpace:");
		}
	}

	[Export("initWithTexture:size:flipped:colorSpace:")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(int glTextureName, CGSize size, bool flipped, CGColorSpace? colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_int_CGSize_bool_IntPtr(base.Handle, selInitWithTexture_Size_Flipped_ColorSpace_Handle, glTextureName, size, flipped, colorSpace?.Handle ?? IntPtr.Zero), "initWithTexture:size:flipped:colorSpace:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_int_CGSize_bool_IntPtr(base.SuperHandle, selInitWithTexture_Size_Flipped_ColorSpace_Handle, glTextureName, size, flipped, colorSpace?.Handle ?? IntPtr.Zero), "initWithTexture:size:flipped:colorSpace:");
		}
	}

	[Export("initWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
		}
	}

	[Export("initWithContentsOfURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSUrl url, NSDictionary? d)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithContentsOfURL_Options_Handle, url.Handle, d?.Handle ?? IntPtr.Zero), "initWithContentsOfURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Options_Handle, url.Handle, d?.Handle ?? IntPtr.Zero), "initWithContentsOfURL:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSUrl url, CIImageInitializationOptions? options)
		: this(url, options.GetDictionary())
	{
	}

	[Export("initWithIOSurface:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(global::IOSurface.IOSurface surface)
		: base(NSObjectFlag.Empty)
	{
		if (surface == null)
		{
			throw new ArgumentNullException("surface");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIOSurface_Handle, surface.Handle), "initWithIOSurface:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIOSurface_Handle, surface.Handle), "initWithIOSurface:");
		}
	}

	[Export("initWithIOSurface:options:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(global::IOSurface.IOSurface surface, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (surface == null)
		{
			throw new ArgumentNullException("surface");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithIOSurface_Options_Handle, surface.Handle, options?.Handle ?? IntPtr.Zero), "initWithIOSurface:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithIOSurface_Options_Handle, surface.Handle, options?.Handle ?? IntPtr.Zero), "initWithIOSurface:options:");
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(global::IOSurface.IOSurface surface, CIImageInitializationOptions? options)
		: this(surface, options.GetDictionary())
	{
	}

	[Export("initWithCVImageBuffer:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CVImageBuffer imageBuffer)
		: base(NSObjectFlag.Empty)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCVImageBuffer_Handle, imageBuffer.Handle), "initWithCVImageBuffer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCVImageBuffer_Handle, imageBuffer.Handle), "initWithCVImageBuffer:");
		}
	}

	[Export("initWithCVImageBuffer:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CVImageBuffer imageBuffer, NSDictionary? dict)
		: base(NSObjectFlag.Empty)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCVImageBuffer_Options_Handle, imageBuffer.Handle, dict?.Handle ?? IntPtr.Zero), "initWithCVImageBuffer:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCVImageBuffer_Options_Handle, imageBuffer.Handle, dict?.Handle ?? IntPtr.Zero), "initWithCVImageBuffer:options:");
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CVImageBuffer imageBuffer, CIImageInitializationOptions? options)
		: this(imageBuffer, options.GetDictionary())
	{
	}

	[Export("initWithCVPixelBuffer:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CVPixelBuffer buffer)
		: base(NSObjectFlag.Empty)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCVPixelBuffer_Handle, buffer.Handle), "initWithCVPixelBuffer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCVPixelBuffer_Handle, buffer.Handle), "initWithCVPixelBuffer:");
		}
	}

	[Export("initWithCVPixelBuffer:options:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CVPixelBuffer buffer, NSDictionary? dict)
		: base(NSObjectFlag.Empty)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCVPixelBuffer_Options_Handle, buffer.Handle, dict?.Handle ?? IntPtr.Zero), "initWithCVPixelBuffer:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCVPixelBuffer_Options_Handle, buffer.Handle, dict?.Handle ?? IntPtr.Zero), "initWithCVPixelBuffer:options:");
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CVPixelBuffer buffer, CIImageInitializationOptions? options)
		: this(buffer, options.GetDictionary())
	{
	}

	[Export("initWithColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(CIColor color)
		: base(NSObjectFlag.Empty)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithColor_Handle, color.Handle), "initWithColor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithColor_Handle, color.Handle), "initWithColor:");
		}
	}

	[Export("initWithMTLTexture:options:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(IMTLTexture texture, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithMTLTexture_Options_Handle, texture.Handle, options?.Handle ?? IntPtr.Zero), "initWithMTLTexture:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithMTLTexture_Options_Handle, texture.Handle, options?.Handle ?? IntPtr.Zero), "initWithMTLTexture:options:");
		}
	}

	[Export("initWithBitmapImageRep:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(NSImageRep imageRep)
		: base(NSObjectFlag.Empty)
	{
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithBitmapImageRep_Handle, imageRep.Handle), "initWithBitmapImageRep:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithBitmapImageRep_Handle, imageRep.Handle), "initWithBitmapImageRep:");
		}
	}

	[Export("initWithImageProvider:size::format:colorSpace:options:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal CIImage(ICIImageProvider provider, nuint width, nuint height, int f, CGColorSpace? colorSpace, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_int_IntPtr_IntPtr(base.Handle, selInitWithImageProvider_Size__Format_ColorSpace_Options_Handle, provider.Handle, width, height, f, colorSpace?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero), "initWithImageProvider:size::format:colorSpace:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_int_IntPtr_IntPtr(base.SuperHandle, selInitWithImageProvider_Size__Format_ColorSpace_Options_Handle, provider.Handle, width, height, f, colorSpace?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero), "initWithImageProvider:size::format:colorSpace:options:");
		}
	}

	[Export("initWithPortaitEffectsMatte:options:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(AVPortraitEffectsMatte matte, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithPortaitEffectsMatte_Options_Handle, matte.Handle, options?.Handle ?? IntPtr.Zero), "initWithPortaitEffectsMatte:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithPortaitEffectsMatte_Options_Handle, matte.Handle, options?.Handle ?? IntPtr.Zero), "initWithPortaitEffectsMatte:options:");
		}
	}

	[Export("initWithPortaitEffectsMatte:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(AVPortraitEffectsMatte matte)
		: base(NSObjectFlag.Empty)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPortaitEffectsMatte_Handle, matte.Handle), "initWithPortaitEffectsMatte:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPortaitEffectsMatte_Handle, matte.Handle), "initWithPortaitEffectsMatte:");
		}
	}

	[Export("initWithSemanticSegmentationMatte:options:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(AVSemanticSegmentationMatte matte, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSemanticSegmentationMatte_Options_Handle, matte.Handle, options?.Handle ?? IntPtr.Zero), "initWithSemanticSegmentationMatte:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSemanticSegmentationMatte_Options_Handle, matte.Handle, options?.Handle ?? IntPtr.Zero), "initWithSemanticSegmentationMatte:options:");
		}
	}

	[Export("initWithSemanticSegmentationMatte:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(AVSemanticSegmentationMatte matte)
		: base(NSObjectFlag.Empty)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSemanticSegmentationMatte_Handle, matte.Handle), "initWithSemanticSegmentationMatte:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSemanticSegmentationMatte_Handle, matte.Handle), "initWithSemanticSegmentationMatte:");
		}
	}

	[Export("initWithDepthData:options:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(AVDepthData data, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDepthData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithDepthData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDepthData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithDepthData:options:");
		}
	}

	[Export("initWithDepthData:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage(AVDepthData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDepthData_Handle, data.Handle), "initWithDepthData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDepthData_Handle, data.Handle), "initWithDepthData:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("imageByApplyingGaussianBlurWithSigma:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByApplyingGaussianBlur(double sigma)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selImageByApplyingGaussianBlurWithSigma_Handle, sigma));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selImageByApplyingGaussianBlurWithSigma_Handle, sigma));
	}

	[Export("imageByApplyingCGOrientation:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByApplyingOrientation(CGImagePropertyOrientation orientation)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selImageByApplyingCGOrientation_Handle, (int)orientation));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selImageByApplyingCGOrientation_Handle, (int)orientation));
	}

	[Export("imageByClampingToRect:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByClamping(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selImageByClampingToRect_Handle, rect));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selImageByClampingToRect_Handle, rect));
	}

	[Export("imageByClampingToExtent")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByClampingToExtent()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageByClampingToExtentHandle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageByClampingToExtentHandle));
	}

	[Export("imageByColorMatchingColorSpaceToWorkingSpace:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage? CreateByColorMatchingColorSpaceToWorkingSpace(CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selImageByColorMatchingColorSpaceToWorkingSpace_Handle, colorSpace.Handle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selImageByColorMatchingColorSpaceToWorkingSpace_Handle, colorSpace.Handle));
	}

	[Export("imageByColorMatchingWorkingSpaceToColorSpace:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage? CreateByColorMatchingWorkingSpaceToColorSpace(CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selImageByColorMatchingWorkingSpaceToColorSpace_Handle, colorSpace.Handle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selImageByColorMatchingWorkingSpaceToColorSpace_Handle, colorSpace.Handle));
	}

	[Export("imageByCompositingOverImage:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByCompositingOverImage(CIImage dest)
	{
		if (dest == null)
		{
			throw new ArgumentNullException("dest");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selImageByCompositingOverImage_Handle, dest.Handle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selImageByCompositingOverImage_Handle, dest.Handle));
	}

	[Export("imageByApplyingFilter:withInputParameters:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByFiltering(string filterName, NSDictionary? inputParameters)
	{
		if (filterName == null)
		{
			throw new ArgumentNullException("filterName");
		}
		IntPtr arg = NSString.CreateNative(filterName);
		CIImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selImageByApplyingFilter_WithInputParameters_Handle, arg, inputParameters?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selImageByApplyingFilter_WithInputParameters_Handle, arg, inputParameters?.Handle ?? IntPtr.Zero)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("imageByApplyingFilter:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByFiltering(string filterName)
	{
		if (filterName == null)
		{
			throw new ArgumentNullException("filterName");
		}
		IntPtr arg = NSString.CreateNative(filterName);
		CIImage result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selImageByApplyingFilter_Handle, arg)) : Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selImageByApplyingFilter_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("imageByInsertingIntermediate")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByInsertingIntermediate()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageByInsertingIntermediateHandle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageByInsertingIntermediateHandle));
	}

	[Export("imageByInsertingIntermediate:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByInsertingIntermediate(bool cache)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selImageByInsertingIntermediate_Handle, cache));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selImageByInsertingIntermediate_Handle, cache));
	}

	[Export("imageByPremultiplyingAlpha")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByPremultiplyingAlpha()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageByPremultiplyingAlphaHandle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageByPremultiplyingAlphaHandle));
	}

	[Export("imageBySamplingLinear")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateBySamplingLinear()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageBySamplingLinearHandle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageBySamplingLinearHandle));
	}

	[Export("imageBySamplingNearest")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateBySamplingNearest()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageBySamplingNearestHandle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageBySamplingNearestHandle));
	}

	[Export("imageBySettingAlphaOneInExtent:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateBySettingAlphaOne(CGRect extent)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selImageBySettingAlphaOneInExtent_Handle, extent));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selImageBySettingAlphaOneInExtent_Handle, extent));
	}

	[Export("imageBySettingProperties:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateBySettingProperties(NSDictionary properties)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selImageBySettingProperties_Handle, properties.Handle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selImageBySettingProperties_Handle, properties.Handle));
	}

	[Export("imageByUnpremultiplyingAlpha")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateByUnpremultiplyingAlpha()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageByUnpremultiplyingAlphaHandle));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageByUnpremultiplyingAlphaHandle));
	}

	[Export("imageByApplyingOrientation:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage CreateWithOrientation(CIImageOrientation orientation)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selImageByApplyingOrientation_Handle, (int)orientation));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selImageByApplyingOrientation_Handle, (int)orientation));
	}

	[Export("drawAtPoint:fromRect:operation:fraction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(CGPoint point, CGRect srcRect, NSCompositingOperation op, nfloat delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGRect_UInt64_nfloat(base.Handle, selDrawAtPoint_FromRect_Operation_Fraction_Handle, point, srcRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGRect_UInt64_nfloat(base.SuperHandle, selDrawAtPoint_FromRect_Operation_Fraction_Handle, point, srcRect, (ulong)op, delta);
		}
	}

	[Export("drawInRect:fromRect:operation:fraction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(CGRect dstRect, CGRect srcRect, NSCompositingOperation op, nfloat delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_nfloat(base.Handle, selDrawInRect_FromRect_Operation_Fraction_Handle, dstRect, srcRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_UInt64_nfloat(base.SuperHandle, selDrawInRect_FromRect_Operation_Fraction_Handle, dstRect, srcRect, (ulong)op, delta);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("imageWithCGImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromCGImage(CGImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithCGImage_Handle, image.Handle));
	}

	[Export("imageWithCGImage:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromCGImage(CGImage image, NSDictionary? d)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithCGImage_Options_Handle, image.Handle, d?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromCGImage(CGImage image, CIImageInitializationOptionsWithMetadata? options)
	{
		return FromCGImage(image, options.GetDictionary());
	}

	[Export("imageWithCGImageSource:index:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromCGImageSource(CGImageSource source, nuint index, NSDictionary? options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(class_ptr, selImageWithCGImageSource_Index_Options_Handle, source.Handle, index, options?.Handle ?? IntPtr.Zero));
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromCGImageSource(CGImageSource source, nuint index, CIImageInitializationOptionsWithMetadata? options)
	{
		return FromCGImageSource(source, index, options.GetDictionary());
	}

	[Export("imageWithBitmapData:bytesPerRow:size:format:colorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CIImage FromData(NSData bitmapData, nint bytesPerRow, CGSize size, int pixelFormat, CGColorSpace? colorSpace)
	{
		if (bitmapData == null)
		{
			throw new ArgumentNullException("bitmapData");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_CGSize_int_IntPtr(class_ptr, selImageWithBitmapData_BytesPerRow_Size_Format_ColorSpace_Handle, bitmapData.Handle, bytesPerRow, size, pixelFormat, colorSpace?.Handle ?? IntPtr.Zero));
	}

	[Export("imageWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithData_Handle, data.Handle));
	}

	[Export("imageWithData:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromData(NSData data, NSDictionary? d)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithData_Options_Handle, data.Handle, d?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromData(NSData data, CIImageInitializationOptionsWithMetadata? options)
	{
		return FromData(data, options.GetDictionary());
	}

	[Export("imageWithDepthData:options:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage? FromDepthData(AVDepthData data, NSDictionary? options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithDepthData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("imageWithDepthData:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage? FromDepthData(AVDepthData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithDepthData_Handle, data.Handle));
	}

	[Export("imageWithCVImageBuffer:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromImageBuffer(CVImageBuffer imageBuffer)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithCVImageBuffer_Handle, imageBuffer.Handle));
	}

	[Export("imageWithCVImageBuffer:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromImageBuffer(CVImageBuffer imageBuffer, NSDictionary? dict)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithCVImageBuffer_Options_Handle, imageBuffer.Handle, dict?.Handle ?? IntPtr.Zero));
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromImageBuffer(CVImageBuffer imageBuffer, CIImageInitializationOptions options)
	{
		return FromImageBuffer(imageBuffer, options.GetDictionary());
	}

	[Export("imageWithCGLayer:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromLayer(CGLayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithCGLayer_Handle, layer.Handle));
	}

	[Export("imageWithCGLayer:options:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromLayer(CGLayer layer, NSDictionary options)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithCGLayer_Options_Handle, layer.Handle, options.Handle));
	}

	[Export("imageWithMTLTexture:options:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromMetalTexture(IMTLTexture texture, NSDictionary<NSString, NSObject>? options)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithMTLTexture_Options_Handle, texture.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("imageWithPortaitEffectsMatte:options:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage? FromPortraitEffectsMatte(AVPortraitEffectsMatte matte, NSDictionary? options)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithPortaitEffectsMatte_Options_Handle, matte.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("imageWithPortaitEffectsMatte:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage? FromPortraitEffectsMatte(AVPortraitEffectsMatte matte)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithPortaitEffectsMatte_Handle, matte.Handle));
	}

	[Export("imageWithImageProvider:size::format:colorSpace:options:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CIImage FromProvider(ICIImageProvider provider, nuint width, nuint height, int format, CGColorSpace? colorSpace, NSDictionary? options)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_int_IntPtr_IntPtr(class_ptr, selImageWithImageProvider_Size__Format_ColorSpace_Options_Handle, provider.Handle, width, height, format, colorSpace?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero));
	}

	[Export("imageWithSemanticSegmentationMatte:options:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage? FromSemanticSegmentationMatte(AVSemanticSegmentationMatte matte, NSDictionary? options)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithSemanticSegmentationMatte_Options_Handle, matte.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("imageWithSemanticSegmentationMatte:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage? FromSemanticSegmentationMatte(AVSemanticSegmentationMatte matte)
	{
		if (matte == null)
		{
			throw new ArgumentNullException("matte");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithSemanticSegmentationMatte_Handle, matte.Handle));
	}

	[Export("imageWithIOSurface:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromSurface(global::IOSurface.IOSurface surface)
	{
		if (surface == null)
		{
			throw new ArgumentNullException("surface");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithIOSurface_Handle, surface.Handle));
	}

	[Export("imageWithIOSurface:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromSurface(global::IOSurface.IOSurface surface, NSDictionary options)
	{
		if (surface == null)
		{
			throw new ArgumentNullException("surface");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithIOSurface_Options_Handle, surface.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromSurface(global::IOSurface.IOSurface surface, CIImageInitializationOptions options)
	{
		return FromSurface(surface, options.GetDictionary());
	}

	[Export("imageWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithContentsOfURL_Handle, url.Handle));
	}

	[Export("imageWithContentsOfURL:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromUrl(NSUrl url, NSDictionary? d)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selImageWithContentsOfURL_Options_Handle, url.Handle, d?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage FromUrl(NSUrl url, CIImageInitializationOptions? options)
	{
		return FromUrl(url, options.GetDictionary());
	}

	[Export("imageTransformForOrientation:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform GetImageTransform(CIImageOrientation orientation)
	{
		CGAffineTransform retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGAffineTransform_objc_msgSend_stret_int(out retval, base.Handle, selImageTransformForOrientation_Handle, (int)orientation);
		}
		else
		{
			Messaging.CGAffineTransform_objc_msgSendSuper_stret_int(out retval, base.SuperHandle, selImageTransformForOrientation_Handle, (int)orientation);
		}
		return retval;
	}

	[Export("imageTransformForCGOrientation:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform GetImageTransform(CGImagePropertyOrientation orientation)
	{
		CGAffineTransform retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGAffineTransform_objc_msgSend_stret_int(out retval, base.Handle, selImageTransformForCGOrientation_Handle, (int)orientation);
		}
		else
		{
			Messaging.CGAffineTransform_objc_msgSendSuper_stret_int(out retval, base.SuperHandle, selImageTransformForCGOrientation_Handle, (int)orientation);
		}
		return retval;
	}

	[Export("regionOfInterestForImage:inRect:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetRegionOfInterest(CIImage im, CGRect r)
	{
		if (im == null)
		{
			throw new ArgumentNullException("im");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect(out retval, base.Handle, selRegionOfInterestForImage_InRect_Handle, im.Handle, r);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect(out retval, base.SuperHandle, selRegionOfInterestForImage_InRect_Handle, im.Handle, r);
		}
		return retval;
	}

	[Export("imageByApplyingTransform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage ImageByApplyingTransform(CGAffineTransform matrix)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGAffineTransform(base.Handle, selImageByApplyingTransform_Handle, matrix));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selImageByApplyingTransform_Handle, matrix));
	}

	[Export("imageByApplyingTransform:highQualityDownsample:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage ImageByApplyingTransform(CGAffineTransform matrix, bool highQualityDownsample)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGAffineTransform_bool(base.Handle, selImageByApplyingTransform_HighQualityDownsample_Handle, matrix, highQualityDownsample));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform_bool(base.SuperHandle, selImageByApplyingTransform_HighQualityDownsample_Handle, matrix, highQualityDownsample));
	}

	[Export("imageByCroppingToRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage ImageByCroppingToRect(CGRect r)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selImageByCroppingToRect_Handle, r));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selImageByCroppingToRect_Handle, r));
	}

	[Export("imageWithColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage ImageWithColor(CIColor color)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageWithColor_Handle, color.Handle));
	}

	[Export("imageWithTexture:size:flipped:colorSpace:")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage ImageWithTexture(uint glTextureName, CGSize size, bool flipped, CGColorSpace? colorspace)
	{
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_UInt32_CGSize_bool_IntPtr(class_ptr, selImageWithTexture_Size_Flipped_ColorSpace_Handle, glTextureName, size, flipped, colorspace?.Handle ?? IntPtr.Zero));
	}

	[Export("autoAdjustmentFiltersWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSArray _GetAutoAdjustmentFilters(NSDictionary? opts)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAutoAdjustmentFiltersWithOptions_Handle, opts?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAutoAdjustmentFiltersWithOptions_Handle, opts?.Handle ?? IntPtr.Zero));
	}
}
