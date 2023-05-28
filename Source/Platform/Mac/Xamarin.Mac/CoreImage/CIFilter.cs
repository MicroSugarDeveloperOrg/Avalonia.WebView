using System;
using System.ComponentModel;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ImageKit;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFilter", true)]
public class CIFilter : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	private bool? supportsInputImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApply_Arguments_Options_ = "apply:arguments:options:";

	private static readonly IntPtr selApply_Arguments_Options_Handle = Selector.GetHandle("apply:arguments:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterNamesInCategories_ = "filterNamesInCategories:";

	private static readonly IntPtr selFilterNamesInCategories_Handle = Selector.GetHandle("filterNamesInCategories:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterNamesInCategory_ = "filterNamesInCategory:";

	private static readonly IntPtr selFilterNamesInCategory_Handle = Selector.GetHandle("filterNamesInCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterWithCVPixelBuffer_Properties_Options_ = "filterWithCVPixelBuffer:properties:options:";

	private static readonly IntPtr selFilterWithCVPixelBuffer_Properties_Options_Handle = Selector.GetHandle("filterWithCVPixelBuffer:properties:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterWithImageData_Options_ = "filterWithImageData:options:";

	private static readonly IntPtr selFilterWithImageData_Options_Handle = Selector.GetHandle("filterWithImageData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterWithImageURL_Options_ = "filterWithImageURL:options:";

	private static readonly IntPtr selFilterWithImageURL_Options_Handle = Selector.GetHandle("filterWithImageURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterWithName_ = "filterWithName:";

	private static readonly IntPtr selFilterWithName_Handle = Selector.GetHandle("filterWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterWithName_WithInputParameters_ = "filterWithName:withInputParameters:";

	private static readonly IntPtr selFilterWithName_WithInputParameters_Handle = Selector.GetHandle("filterWithName:withInputParameters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputKeys = "inputKeys";

	private static readonly IntPtr selInputKeysHandle = Selector.GetHandle("inputKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDescriptionForFilterName_ = "localizedDescriptionForFilterName:";

	private static readonly IntPtr selLocalizedDescriptionForFilterName_Handle = Selector.GetHandle("localizedDescriptionForFilterName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedNameForCategory_ = "localizedNameForCategory:";

	private static readonly IntPtr selLocalizedNameForCategory_Handle = Selector.GetHandle("localizedNameForCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedNameForFilterName_ = "localizedNameForFilterName:";

	private static readonly IntPtr selLocalizedNameForFilterName_Handle = Selector.GetHandle("localizedNameForFilterName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedReferenceDocumentationForFilterName_ = "localizedReferenceDocumentationForFilterName:";

	private static readonly IntPtr selLocalizedReferenceDocumentationForFilterName_Handle = Selector.GetHandle("localizedReferenceDocumentationForFilterName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputKeys = "outputKeys";

	private static readonly IntPtr selOutputKeysHandle = Selector.GetHandle("outputKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterFilterName_Constructor_ClassAttributes_ = "registerFilterName:constructor:classAttributes:";

	private static readonly IntPtr selRegisterFilterName_Constructor_ClassAttributes_Handle = Selector.GetHandle("registerFilterName:constructor:classAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaults = "setDefaults";

	private static readonly IntPtr selSetDefaultsHandle = Selector.GetHandle("setDefaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForKey_ = "setValue:forKey:";

	private static readonly IntPtr selSetValue_ForKey_Handle = Selector.GetHandle("setValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForKey_ = "valueForKey:";

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewForUIConfiguration_ExcludedKeys_ = "viewForUIConfiguration:excludedKeys:";

	private static readonly IntPtr selViewForUIConfiguration_ExcludedKeys_Handle = Selector.GetHandle("viewForUIConfiguration:excludedKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIFilter");

	public NSObject this[NSString key]
	{
		get
		{
			return ValueForKey(key);
		}
		set
		{
			SetValueForKey(value, key);
		}
	}

	public virtual CIImage OutputImage => ValueForKey(CIFilterOutputKey.Image) as CIImage;

	[Obsolete("Use 'InputImage' instead. If not available then the filter does not support it.")]
	public CIImage Image
	{
		get
		{
			return SupportsInputImage ? (ValueForKey(CIFilterInputKey.Image) as CIImage) : null;
		}
		set
		{
			if (!SupportsInputImage)
			{
				throw new ArgumentException("inputImage is not supported by this filter");
			}
			SetValueForKey(value, CIFilterInputKey.Image);
		}
	}

	private bool SupportsInputImage
	{
		get
		{
			if (!supportsInputImage.HasValue)
			{
				supportsInputImage = Array.IndexOf<string>(InputKeys, "inputImage") >= 0;
			}
			return supportsInputImage.Value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Attributes
	{
		[Export("attributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] InputKeys
	{
		[Export("inputKeys")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputKeysHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] OutputKeys
	{
		[Export("outputKeys")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputKeysHandle));
		}
	}

	[iOS(8, 0)]
	protected CIFilter()
	{
	}

	internal CIFilter(string name)
		: base(CreateFilter(name))
	{
	}

	public static string[] FilterNamesInCategories(params string[] categories)
	{
		return _FilterNamesInCategories(categories);
	}

	internal NSObject ValueForKey(string key)
	{
		using NSString key2 = new NSString(key);
		return ValueForKey(key2);
	}

	internal void SetValue(string key, NSObject value)
	{
		using NSString key2 = new NSString(key);
		SetValueForKey(value, key2);
	}

	internal static IntPtr CreateFilter(string name)
	{
		using NSString nSString = new NSString(name);
		return Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, Selector.GetHandle("filterWithName:"), nSString.Handle);
	}

	internal void SetFloat(string key, float value)
	{
		using NSString key2 = new NSString(key);
		SetValueForKey(new NSNumber(value), key2);
	}

	internal void SetInt(string key, int value)
	{
		using NSString key2 = new NSString(key);
		SetValueForKey(new NSNumber(value), key2);
	}

	internal void SetNInt(string key, nint value)
	{
		using NSString key2 = new NSString(key);
		SetValueForKey(new NSNumber(value), key2);
	}

	internal void SetBool(string key, bool value)
	{
		using NSString key2 = new NSString(key);
		SetValueForKey(new NSNumber(value ? 1 : 0), key2);
	}

	internal void SetValue(string key, CGPoint value)
	{
		using NSString key2 = new NSString(key);
		using CIVector value2 = new CIVector(value.X, value.Y);
		SetValueForKey(value2, key2);
	}

	internal void SetValue(string key, CGRect value)
	{
		using NSString key2 = new NSString(key);
		using CIVector value2 = new CIVector(value.X, value.Y, value.Width, value.Height);
		SetValueForKey(value2, key2);
	}

	internal T Get<T>(string key) where T : class
	{
		using NSString key2 = new NSString(key);
		return ValueForKey(key2) as T;
	}

	internal float GetFloat(string key)
	{
		return Get<NSNumber>(key)?.FloatValue ?? 0f;
	}

	internal int GetInt(string key)
	{
		return Get<NSNumber>(key)?.Int32Value ?? 0;
	}

	internal nint GetNInt(string key)
	{
		return Get<NSNumber>(key)?.NIntValue ?? default(nint);
	}

	internal bool GetBool(string key)
	{
		return Get<NSNumber>(key)?.BoolValue ?? false;
	}

	internal void SetHandle(string key, IntPtr handle)
	{
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("setValue:forKey:"), handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, Selector.GetHandle("setValue:forKey:"), handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	internal IntPtr GetHandle(string key)
	{
		IntPtr arg = NSString.CreateNative(key);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("valueForKey:"), arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("valueForKey:"), arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	internal CGPoint GetPoint(string key)
	{
		CIVector cIVector = Get<CIVector>(key);
		return (cIVector != null) ? new CGPoint(cIVector.X, cIVector.Y) : default(CGPoint);
	}

	internal CGRect GetRect(string key)
	{
		CIVector cIVector = Get<CIVector>(key);
		return (cIVector != null) ? new CGRect(cIVector.X, cIVector.Y, cIVector.Z, cIVector.W) : default(CGRect);
	}

	internal static string GetFilterName(IntPtr filterHandle)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(filterHandle, Selector.GetHandle("name")));
	}

	internal static CIFilter FromName(string filterName, IntPtr handle)
	{
		switch (filterName)
		{
		case "CIAdditionCompositing":
			return new CIAdditionCompositing(handle);
		case "CIAffineTransform":
			return new CIAffineTransform(handle);
		case "CICheckerboardGenerator":
			return new CICheckerboardGenerator(handle);
		case "CIColorBlendMode":
			return new CIColorBlendMode(handle);
		case "CIColorBurnBlendMode":
			return new CIColorBurnBlendMode(handle);
		case "CIColorControls":
			return new CIColorControls(handle);
		case "CIColorCube":
			return new CIColorCube(handle);
		case "CIColorDodgeBlendMode":
			return new CIColorDodgeBlendMode(handle);
		case "CIColorInvert":
			return new CIColorInvert(handle);
		case "CIColorMatrix":
			return new CIColorMatrix(handle);
		case "CIColorMonochrome":
			return new CIColorMonochrome(handle);
		case "CIConstantColorGenerator":
			return new CIConstantColorGenerator(handle);
		case "CICrop":
			return new CICrop(handle);
		case "CIDarkenBlendMode":
			return new CIDarkenBlendMode(handle);
		case "CIDifferenceBlendMode":
			return new CIDifferenceBlendMode(handle);
		case "CIExclusionBlendMode":
			return new CIExclusionBlendMode(handle);
		case "CIExposureAdjust":
			return new CIExposureAdjust(handle);
		case "CIFalseColor":
			return new CIFalseColor(handle);
		case "CIGammaAdjust":
			return new CIGammaAdjust(handle);
		case "CIGaussianGradient":
			return new CIGaussianGradient(handle);
		case "CIHardLightBlendMode":
			return new CIHardLightBlendMode(handle);
		case "CIHighlightShadowAdjust":
			return new CIHighlightShadowAdjust(handle);
		case "CIHueAdjust":
			return new CIHueAdjust(handle);
		case "CIHueBlendMode":
			return new CIHueBlendMode(handle);
		case "CILightenBlendMode":
			return new CILightenBlendMode(handle);
		case "CILinearGradient":
			return new CILinearGradient(handle);
		case "CILuminosityBlendMode":
			return new CILuminosityBlendMode(handle);
		case "CIMaximumCompositing":
			return new CIMaximumCompositing(handle);
		case "CIMinimumCompositing":
			return new CIMinimumCompositing(handle);
		case "CIMultiplyBlendMode":
			return new CIMultiplyBlendMode(handle);
		case "CIMultiplyCompositing":
			return new CIMultiplyCompositing(handle);
		case "CIOverlayBlendMode":
			return new CIOverlayBlendMode(handle);
		case "CIRadialGradient":
			return new CIRadialGradient(handle);
		case "CISaturationBlendMode":
			return new CISaturationBlendMode(handle);
		case "CIScreenBlendMode":
			return new CIScreenBlendMode(handle);
		case "CISepiaTone":
			return new CISepiaTone(handle);
		case "CISoftLightBlendMode":
			return new CISoftLightBlendMode(handle);
		case "CISourceAtopCompositing":
			return new CISourceAtopCompositing(handle);
		case "CISourceInCompositing":
			return new CISourceInCompositing(handle);
		case "CISourceOutCompositing":
			return new CISourceOutCompositing(handle);
		case "CISourceOverCompositing":
			return new CISourceOverCompositing(handle);
		case "CIStraightenFilter":
			return new CIStraightenFilter(handle);
		case "CIStripesGenerator":
			return new CIStripesGenerator(handle);
		case "CITemperatureAndTint":
			return new CITemperatureAndTint(handle);
		case "CIToneCurve":
			return new CIToneCurve(handle);
		case "CIVibrance":
			return new CIVibrance(handle);
		case "CIWhitePointAdjust":
			return new CIWhitePointAdjust(handle);
		case "CIFaceBalance":
			return new CIFaceBalance(handle);
		case "CIAffineClamp":
			return new CIAffineClamp(handle);
		case "CIAffineTile":
			return new CIAffineTile(handle);
		case "CIBlendWithMask":
			return new CIBlendWithMask(handle);
		case "CIBarsSwipeTransition":
			return new CIBarsSwipeTransition(handle);
		case "CICopyMachineTransition":
			return new CICopyMachineTransition(handle);
		case "CIDisintegrateWithMaskTransition":
			return new CIDisintegrateWithMaskTransition(handle);
		case "CIDissolveTransition":
			return new CIDissolveTransition(handle);
		case "CIFlashTransition":
			return new CIFlashTransition(handle);
		case "CIModTransition":
			return new CIModTransition(handle);
		case "CISwipeTransition":
			return new CISwipeTransition(handle);
		case "CIBloom":
			return new CIBloom(handle);
		case "CICircularScreen":
			return new CICircularScreen(handle);
		case "CIDotScreen":
			return new CIDotScreen(handle);
		case "CIHatchedScreen":
			return new CIHatchedScreen(handle);
		case "CILineScreen":
			return new CILineScreen(handle);
		case "CIColorMap":
			return new CIColorMap(handle);
		case "CIColorPosterize":
			return new CIColorPosterize(handle);
		case "CIEightfoldReflectedTile":
			return new CIEightfoldReflectedTile(handle);
		case "CIFourfoldReflectedTile":
			return new CIFourfoldReflectedTile(handle);
		case "CIFourfoldRotatedTile":
			return new CIFourfoldRotatedTile(handle);
		case "CIFourfoldTranslatedTile":
			return new CIFourfoldTranslatedTile(handle);
		case "CISixfoldReflectedTile":
			return new CISixfoldReflectedTile(handle);
		case "CISixfoldRotatedTile":
			return new CISixfoldRotatedTile(handle);
		case "CITwelvefoldReflectedTile":
			return new CITwelvefoldReflectedTile(handle);
		case "CIGaussianBlur":
			return new CIGaussianBlur(handle);
		case "CIGloom":
			return new CIGloom(handle);
		case "CIHoleDistortion":
			return new CIHoleDistortion(handle);
		case "CIPinchDistortion":
			return new CIPinchDistortion(handle);
		case "CITwirlDistortion":
			return new CITwirlDistortion(handle);
		case "CIVortexDistortion":
			return new CIVortexDistortion(handle);
		case "CILanczosScaleTransform":
			return new CILanczosScaleTransform(handle);
		case "CIMaskToAlpha":
			return new CIMaskToAlpha(handle);
		case "CIMaximumComponent":
			return new CIMaximumComponent(handle);
		case "CIMinimumComponent":
			return new CIMinimumComponent(handle);
		case "CIPerspectiveTile":
			return new CIPerspectiveTile(handle);
		case "CIPerspectiveTransform":
			return new CIPerspectiveTransform(handle);
		case "CIPixellate":
			return new CIPixellate(handle);
		case "CIRandomGenerator":
			return new CIRandomGenerator(handle);
		case "CISharpenLuminance":
			return new CISharpenLuminance(handle);
		case "CIStarShineGenerator":
			return new CIStarShineGenerator(handle);
		case "CIUnsharpMask":
			return new CIUnsharpMask(handle);
		case "CICircleSplashDistortion":
			return new CICircleSplashDistortion(handle);
		case "CIColorClamp":
			return new CIColorClamp(handle);
		case "CIDepthOfField":
			return new CIDepthOfField(handle);
		case "CIPageCurlTransition":
			return new CIPageCurlTransition(handle);
		case "CIRippleTransition":
			return new CIRippleTransition(handle);
		case "CILightTunnel":
			return new CILightTunnel(handle);
		case "CITriangleKaleidoscope":
			return new CITriangleKaleidoscope(handle);
		case "CIVignette":
			return new CIVignette(handle);
		case "CIBlendWithAlphaMask":
			return new CIBlendWithAlphaMask(handle);
		case "CIBumpDistortion":
			return new CIBumpDistortion(handle);
		case "CIBumpDistortionLinear":
			return new CIBumpDistortionLinear(handle);
		case "CIColorCrossPolynomial":
			return new CIColorCrossPolynomial(handle);
		case "CIColorCubeWithColorSpace":
			return new CIColorCubeWithColorSpace(handle);
		case "CIColorPolynomial":
			return new CIColorPolynomial(handle);
		case "CIConvolution3X3":
			return new CIConvolution3X3(handle);
		case "CIConvolution5X5":
			return new CIConvolution5X5(handle);
		case "CIConvolution7X7":
			return new CIConvolution7X7(handle);
		case "CIConvolution9Horizontal":
			return new CIConvolution9Horizontal(handle);
		case "CIConvolution9Vertical":
			return new CIConvolution9Vertical(handle);
		case "CILinearToSRGBToneCurve":
			return new CILinearToSRGBToneCurve(handle);
		case "CIPerspectiveTransformWithExtent":
			return new CIPerspectiveTransformWithExtent(handle);
		case "CIPhotoEffectChrome":
			return new CIPhotoEffectChrome(handle);
		case "CIPhotoEffectFade":
			return new CIPhotoEffectFade(handle);
		case "CIPhotoEffectInstant":
			return new CIPhotoEffectInstant(handle);
		case "CIPhotoEffectMono":
			return new CIPhotoEffectMono(handle);
		case "CIPhotoEffectNoir":
			return new CIPhotoEffectNoir(handle);
		case "CIPhotoEffectProcess":
			return new CIPhotoEffectProcess(handle);
		case "CIPhotoEffectTonal":
			return new CIPhotoEffectTonal(handle);
		case "CIPhotoEffectTransfer":
			return new CIPhotoEffectTransfer(handle);
		case "CIQRCodeGenerator":
			return new CIQRCodeGenerator(handle);
		case "CISmoothLinearGradient":
			return new CISmoothLinearGradient(handle);
		case "CISRGBToneCurveToLinear":
			return new CISRGBToneCurveToLinear(handle);
		case "CIVignetteEffect":
			return new CIVignetteEffect(handle);
		case "CIWhitePointAdjus":
			return new CIWhitePointAdjust(handle);
		case "CIAreaHistogram":
			return new CIAreaHistogram(handle);
		case "CIAztecCodeGenerator":
			return new CIAztecCodeGenerator(handle);
		case "CICode128BarcodeGenerator":
			return new CICode128BarcodeGenerator(handle);
		case "CIDivideBlendMode":
			return new CIDivideBlendMode(handle);
		case "CIGlassDistortion":
			return new CIGlassDistortion(handle);
		case "CIHistogramDisplayFilter":
			return new CIHistogramDisplayFilter(handle);
		case "CILinearBurnBlendMode":
			return new CILinearBurnBlendMode(handle);
		case "CILinearDodgeBlendMode":
			return new CILinearDodgeBlendMode(handle);
		case "CIPerspectiveCorrection":
			return new CIPerspectiveCorrection(handle);
		case "CIPinLightBlendMode":
			return new CIPinLightBlendMode(handle);
		case "CISubtractBlendMode":
			return new CISubtractBlendMode(handle);
		case "CIAccordionFoldTransition":
			return new CIAccordionFoldTransition(handle);
		case "CIAreaAverage":
			return new CIAreaAverage(handle);
		case "CIAreaMaximum":
			return new CIAreaMaximum(handle);
		case "CIAreaMaximumAlpha":
			return new CIAreaMaximumAlpha(handle);
		case "CIAreaMinimum":
			return new CIAreaMinimum(handle);
		case "CIAreaMinimumAlpha":
			return new CIAreaMinimumAlpha(handle);
		case "CIBoxBlur":
			return new CIBoxBlur(handle);
		case "CICircularWrap":
			return new CICircularWrap(handle);
		case "CICmykHalftone":
		case "CICMYKHalftone":
			return new CICmykHalftone(handle);
		case "CIColumnAverage":
			return new CIColumnAverage(handle);
		case "CIComicEffect":
			return new CIComicEffect(handle);
		case "CICrystallize":
			return new CICrystallize(handle);
		case "CIDiscBlur":
			return new CIDiscBlur(handle);
		case "CIDisplacementDistortion":
			return new CIDisplacementDistortion(handle);
		case "CIDroste":
			return new CIDroste(handle);
		case "CIEdges":
			return new CIEdges(handle);
		case "CIEdgeWork":
			return new CIEdgeWork(handle);
		case "CIGlassLozenge":
			return new CIGlassLozenge(handle);
		case "CIHeightFieldFromMask":
			return new CIHeightFieldFromMask(handle);
		case "CIHexagonalPixellate":
			return new CIHexagonalPixellate(handle);
		case "CIKaleidoscope":
			return new CIKaleidoscope(handle);
		case "CILenticularHaloGenerator":
			return new CILenticularHaloGenerator(handle);
		case "CILineOverlay":
			return new CILineOverlay(handle);
		case "CIMaskedVariableBlur":
			return new CIMaskedVariableBlur(handle);
		case "CIMedianFilter":
			return new CIMedianFilter(handle);
		case "CINoiseReduction":
			return new CINoiseReduction(handle);
		case "CIOpTile":
			return new CIOpTile(handle);
		case "CIPageCurlWithShadowTransition":
			return new CIPageCurlWithShadowTransition(handle);
		case "CIParallelogramTile":
			return new CIParallelogramTile(handle);
		case "CIPointillize":
			return new CIPointillize(handle);
		case "CIRowAverage":
			return new CIRowAverage(handle);
		case "CIShadedMaterial":
			return new CIShadedMaterial(handle);
		case "CISpotColor":
			return new CISpotColor(handle);
		case "CISpotLight":
			return new CISpotLight(handle);
		case "CIStretchCrop":
			return new CIStretchCrop(handle);
		case "CISunbeamsGenerator":
			return new CISunbeamsGenerator(handle);
		case "CITorusLensDistortion":
			return new CITorusLensDistortion(handle);
		case "CITriangleTile":
			return new CITriangleTile(handle);
		case "CIMotionBlur":
			return new CIMotionBlur(handle);
		case "CIZoomBlur":
			return new CIZoomBlur(handle);
		case "CIPDF417BarcodeGenerator":
		case "CIPdf417BarcodeGenerator":
			return new CIPdf417BarcodeGenerator(handle);
		case "CIAreaMinMaxRed":
			return new CIAreaMinMaxRed(handle);
		case "CIAttributedTextImageGenerator":
			return new CIAttributedTextImageGenerator(handle);
		case "CIBarcodeGenerator":
			return new CIBarcodeGenerator(handle);
		case "CIBicubicScaleTransform":
			return new CIBicubicScaleTransform(handle);
		case "CIBokehBlur":
			return new CIBokehBlur(handle);
		case "CIColorCubesMixedWithMask":
			return new CIColorCubesMixedWithMask(handle);
		case "CIColorCurves":
			return new CIColorCurves(handle);
		case "CIDepthBlurEffect":
			return new CIDepthBlurEffect(handle);
		case "CIDepthToDisparity":
			return new CIDepthToDisparity(handle);
		case "CIDisparityToDepth":
			return new CIDisparityToDepth(handle);
		case "CIEdgePreserveUpsampleFilter":
			return new CIEdgePreserveUpsampleFilter(handle);
		case "CILabDeltaE":
			return new CILabDeltaE(handle);
		case "CITextImageGenerator":
			return new CITextImageGenerator(handle);
		case "CIMorphologyGradient":
			return new CIMorphologyGradient(handle);
		case "CIMorphologyMaximum":
			return new CIMorphologyMaximum(handle);
		case "CIMorphologyMinimum":
			return new CIMorphologyMinimum(handle);
		case "CIBlendWithBlueMask":
			return new CIBlendWithBlueMask(handle);
		case "CIBlendWithRedMask":
			return new CIBlendWithRedMask(handle);
		default:
			throw new NotImplementedException($"Unknown filter type returned: `{filterName}', returning a default CIFilter");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFilter(NSCoder coder)
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
	protected CIFilter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIFilter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("apply:arguments:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage Apply(CIKernel k, NSArray? args, NSDictionary? options)
	{
		if (k == null)
		{
			throw new ArgumentNullException("k");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selApply_Arguments_Options_Handle, k.Handle, args?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selApply_Arguments_Options_Handle, k.Handle, args?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero));
	}

	[Export("localizedNameForCategory:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string CategoryLocalizedName(string category)
	{
		if (category == null)
		{
			throw new ArgumentNullException("category");
		}
		IntPtr arg = NSString.CreateNative(category);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedNameForCategory_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("filterWithImageURL:options:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter CreateRawFilter(NSUrl url, NSDictionary options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFilterWithImageURL_Options_Handle, url.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter CreateRawFilter(NSUrl url, CIRawFilterOptions options)
	{
		return CreateRawFilter(url, options.GetDictionary());
	}

	[Export("filterWithImageData:options:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter CreateRawFilter(NSData data, NSDictionary options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFilterWithImageData_Options_Handle, data.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter CreateRawFilter(NSData data, CIRawFilterOptions options)
	{
		return CreateRawFilter(data, options.GetDictionary());
	}

	[Export("filterWithCVPixelBuffer:properties:options:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter CreateRawFilter(CVPixelBuffer pixelBuffer, NSDictionary properties, NSDictionary options)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selFilterWithCVPixelBuffer_Properties_Options_Handle, pixelBuffer.Handle, properties.Handle, options.Handle));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter CreateRawFilter(CVPixelBuffer pixelBuffer, NSDictionary properties, CIRawFilterOptions options)
	{
		return CreateRawFilter(pixelBuffer, properties, options.GetDictionary());
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

	[Export("localizedDescriptionForFilterName:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string FilterLocalizedDescription(string filterName)
	{
		if (filterName == null)
		{
			throw new ArgumentNullException("filterName");
		}
		IntPtr arg = NSString.CreateNative(filterName);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedDescriptionForFilterName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedNameForFilterName:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string FilterLocalizedName(string filterName)
	{
		if (filterName == null)
		{
			throw new ArgumentNullException("filterName");
		}
		IntPtr arg = NSString.CreateNative(filterName);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedNameForFilterName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedReferenceDocumentationForFilterName:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl FilterLocalizedReferenceDocumentation(string filterName)
	{
		if (filterName == null)
		{
			throw new ArgumentNullException("filterName");
		}
		IntPtr arg = NSString.CreateNative(filterName);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedReferenceDocumentationForFilterName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("filterNamesInCategory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] FilterNamesInCategory(string? category)
	{
		IntPtr arg = NSString.CreateNative(category);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterNamesInCategory_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("filterWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		CIFilter nSObject = Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("filterWithName:withInputParameters:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilter GetFilter(string name, NSDictionary? inputParameters)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		CIFilter nSObject = Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFilterWithName_WithInputParameters_Handle, arg, inputParameters?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("viewForUIConfiguration:excludedKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKFilterUIView GetFilterUIView(NSDictionary configurationOptions, NSArray? excludedKeys)
	{
		if (configurationOptions == null)
		{
			throw new ArgumentNullException("configurationOptions");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<IKFilterUIView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selViewForUIConfiguration_ExcludedKeys_Handle, configurationOptions.Handle, excludedKeys?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<IKFilterUIView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selViewForUIConfiguration_ExcludedKeys_Handle, configurationOptions.Handle, excludedKeys?.Handle ?? IntPtr.Zero));
	}

	[Export("registerFilterName:constructor:classAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisterFilterName(string name, NSObject constructorObject, NSDictionary classAttributes)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (constructorObject == null)
		{
			throw new ArgumentNullException("constructorObject");
		}
		if (classAttributes == null)
		{
			throw new ArgumentNullException("classAttributes");
		}
		IntPtr arg = NSString.CreateNative(name);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRegisterFilterName_Constructor_ClassAttributes_Handle, arg, constructorObject.Handle, classAttributes.Handle);
		NSString.ReleaseNative(arg);
	}

	[Export("setDefaults")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDefaults()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetDefaultsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetDefaultsHandle);
		}
	}

	[Export("setValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual void SetValueForKey(NSObject? value, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForKey_Handle, value?.Handle ?? IntPtr.Zero, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForKey_Handle, value?.Handle ?? IntPtr.Zero, key.Handle);
		}
	}

	[Export("valueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, key.Handle));
	}

	[Export("filterNamesInCategories:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static string[] _FilterNamesInCategories(string[]? categories)
	{
		NSArray nSArray = ((categories == null) ? null : NSArray.FromStrings(categories));
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterNamesInCategories_Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return result;
	}
}
