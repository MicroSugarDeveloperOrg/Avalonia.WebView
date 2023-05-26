using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFilter", true)]
public class CIFilter : NSObject
{
	private static readonly IntPtr selInputKeysHandle = Selector.GetHandle("inputKeys");

	private static readonly IntPtr selOutputKeysHandle = Selector.GetHandle("outputKeys");

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetDefaultsHandle = Selector.GetHandle("setDefaults");

	private static readonly IntPtr selFilterWithName_Handle = Selector.GetHandle("filterWithName:");

	private static readonly IntPtr selFilterNamesInCategory_Handle = Selector.GetHandle("filterNamesInCategory:");

	private static readonly IntPtr selFilterNamesInCategories_Handle = Selector.GetHandle("filterNamesInCategories:");

	private static readonly IntPtr selApplyArgumentsOptions_Handle = Selector.GetHandle("apply:arguments:options:");

	private static readonly IntPtr selRegisterFilterNameConstructorClassAttributes_Handle = Selector.GetHandle("registerFilterName:constructor:classAttributes:");

	private static readonly IntPtr selLocalizedNameForFilterName_Handle = Selector.GetHandle("localizedNameForFilterName:");

	private static readonly IntPtr selLocalizedNameForCategory_Handle = Selector.GetHandle("localizedNameForCategory:");

	private static readonly IntPtr selLocalizedDescriptionForFilterName_Handle = Selector.GetHandle("localizedDescriptionForFilterName:");

	private static readonly IntPtr selLocalizedReferenceDocumentationForFilterName_Handle = Selector.GetHandle("localizedReferenceDocumentationForFilterName:");

	private static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle("setValue:forKey:");

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIFilter");

	private object __mt_Attributes_var;

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

	public override IntPtr ClassHandle => class_ptr;

	public virtual string[] InputKeys
	{
		[Export("inputKeys")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputKeysHandle));
		}
	}

	public virtual string[] OutputKeys
	{
		[Export("outputKeys")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputKeysHandle));
		}
	}

	public virtual NSDictionary Attributes
	{
		[Export("attributes")]
		get
		{
			return (NSDictionary)(__mt_Attributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle)))));
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
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
		return Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterWithName_Handle, nSString.Handle);
	}

	internal void SetFloat(string key, float value)
	{
		using NSString key2 = new NSString(key);
		SetValueForKey(new NSNumber(value), key2);
	}

	internal float GetFloat(string key)
	{
		using NSString key2 = new NSString(key);
		NSObject nSObject = ValueForKey(key2);
		if (nSObject is NSNumber)
		{
			return (nSObject as NSNumber).FloatValue;
		}
		return 0f;
	}

	internal CIVector GetVector(string key)
	{
		return ValueForKey(key) as CIVector;
	}

	internal CIColor GetColor(string key)
	{
		return ValueForKey(key) as CIColor;
	}

	internal CIImage GetInputImage()
	{
		return ValueForKey(CIFilterInputKey.Image) as CIImage;
	}

	internal void SetInputImage(CIImage value)
	{
		SetValueForKey(value, CIFilterInputKey.Image);
	}

	internal CIImage GetBackgroundImage()
	{
		return GetImage("inputBackgroundImage");
	}

	internal CIImage GetImage(string key)
	{
		using NSString key2 = new NSString(key);
		return ValueForKey(key2) as CIImage;
	}

	internal void SetBackgroundImage(CIImage value)
	{
		SetImage("inputBackgroundImage", value);
	}

	internal void SetImage(string key, CIImage value)
	{
		using NSString key2 = new NSString(key);
		SetValueForKey(value, key2);
	}

	internal static string GetFilterName(IntPtr filterHandle)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(filterHandle, selNameHandle));
	}

	internal static CIFilter FromName(string filterName, IntPtr handle)
	{
		return filterName switch
		{
			"CIAdditionCompositing" => new CIAdditionCompositing(handle), 
			"CIAffineTransform" => new CIAffineTransform(handle), 
			"CICheckerboardGenerator" => new CICheckerboardGenerator(handle), 
			"CIColorBlendMode" => new CIColorBlendMode(handle), 
			"CIColorBurnBlendMode" => new CIColorBurnBlendMode(handle), 
			"CIColorControls" => new CIColorControls(handle), 
			"CIColorCube" => new CIColorCube(handle), 
			"CIColorDodgeBlendMode" => new CIColorDodgeBlendMode(handle), 
			"CIColorInvert" => new CIColorInvert(handle), 
			"CIColorMatrix" => new CIColorMatrix(handle), 
			"CIColorMonochrome" => new CIColorMonochrome(handle), 
			"CIConstantColorGenerator" => new CIConstantColorGenerator(handle), 
			"CICrop" => new CICrop(handle), 
			"CIDarkenBlendMode" => new CIDarkenBlendMode(handle), 
			"CIDifferenceBlendMode" => new CIDifferenceBlendMode(handle), 
			"CIExclusionBlendMode" => new CIExclusionBlendMode(handle), 
			"CIExposureAdjust" => new CIExposureAdjust(handle), 
			"CIFalseColor" => new CIFalseColor(handle), 
			"CIGammaAdjust" => new CIGammaAdjust(handle), 
			"CIGaussianGradient" => new CIGaussianGradient(handle), 
			"CIHardLightBlendMode" => new CIHardLightBlendMode(handle), 
			"CIHighlightShadowAdjust" => new CIHighlightShadowAdjust(handle), 
			"CIHueAdjust" => new CIHueAdjust(handle), 
			"CIHueBlendMode" => new CIHueBlendMode(handle), 
			"CILightenBlendMode" => new CILightenBlendMode(handle), 
			"CILinearGradient" => new CILinearGradient(handle), 
			"CILuminosityBlendMode" => new CILuminosityBlendMode(handle), 
			"CIMaximumCompositing" => new CIMaximumCompositing(handle), 
			"CIMinimumCompositing" => new CIMinimumCompositing(handle), 
			"CIMultiplyBlendMode" => new CIMultiplyBlendMode(handle), 
			"CIMultiplyCompositing" => new CIMultiplyCompositing(handle), 
			"CIOverlayBlendMode" => new CIOverlayBlendMode(handle), 
			"CIRadialGradient" => new CIRadialGradient(handle), 
			"CISaturationBlendMode" => new CISaturationBlendMode(handle), 
			"CIScreenBlendMode" => new CIScreenBlendMode(handle), 
			"CISepiaTone" => new CISepiaTone(handle), 
			"CISoftLightBlendMode" => new CISoftLightBlendMode(handle), 
			"CISourceAtopCompositing" => new CISourceAtopCompositing(handle), 
			"CISourceInCompositing" => new CISourceInCompositing(handle), 
			"CISourceOutCompositing" => new CISourceOutCompositing(handle), 
			"CISourceOverCompositing" => new CISourceOverCompositing(handle), 
			"CIStraightenFilter" => new CIStraightenFilter(handle), 
			"CIStripesGenerator" => new CIStripesGenerator(handle), 
			"CITemperatureAndTint" => new CITemperatureAndTint(handle), 
			"CIToneCurve" => new CIToneCurve(handle), 
			"CIVibrance" => new CIVibrance(handle), 
			"CIWhitePointAdjust" => new CIWhitePointAdjust(handle), 
			"CIFaceBalance" => new CIFaceBalance(handle), 
			"CIAffineClamp" => new CIAffineClamp(handle), 
			"CIAffineTile" => new CIAffineTile(handle), 
			"CIBlendWithMask" => new CIBlendWithMask(handle), 
			"CIBarsSwipeTransition" => new CIBarsSwipeTransition(handle), 
			"CICopyMachineTransition" => new CICopyMachineTransition(handle), 
			"CIDisintegrateWithMaskTransition" => new CIDisintegrateWithMaskTransition(handle), 
			"CIDissolveTransition" => new CIDissolveTransition(handle), 
			"CIFlashTransition" => new CIFlashTransition(handle), 
			"CIModTransition" => new CIModTransition(handle), 
			"CISwipeTransition" => new CISwipeTransition(handle), 
			"CIBloom" => new CIBloom(handle), 
			"CICircularScreen" => new CICircularScreen(handle), 
			"CIDotScreen" => new CIDotScreen(handle), 
			"CIHatchedScreen" => new CIHatchedScreen(handle), 
			"CILineScreen" => new CILineScreen(handle), 
			"CIColorMap" => new CIColorMap(handle), 
			"CIColorPosterize" => new CIColorPosterize(handle), 
			"CIEightfoldReflectedTile" => new CIEightfoldReflectedTile(handle), 
			"CIFourfoldReflectedTile" => new CIFourfoldReflectedTile(handle), 
			"CIFourfoldRotatedTile" => new CIFourfoldRotatedTile(handle), 
			"CIFourfoldTranslatedTile" => new CIFourfoldTranslatedTile(handle), 
			"CISixfoldReflectedTile" => new CISixfoldReflectedTile(handle), 
			"CISixfoldRotatedTile" => new CISixfoldRotatedTile(handle), 
			"CITwelvefoldReflectedTile" => new CITwelvefoldReflectedTile(handle), 
			"CIGaussianBlur" => new CIGaussianBlur(handle), 
			"CIGloom" => new CIGloom(handle), 
			"CIHoleDistortion" => new CIHoleDistortion(handle), 
			"CIPinchDistortion" => new CIPinchDistortion(handle), 
			"CITwirlDistortion" => new CITwirlDistortion(handle), 
			"CIVortexDistortion" => new CIVortexDistortion(handle), 
			"CILanczosScaleTransform" => new CILanczosScaleTransform(handle), 
			"CIMaskToAlpha" => new CIMaskToAlpha(handle), 
			"CIMaximumComponent" => new CIMaximumComponent(handle), 
			"CIMinimumComponent" => new CIMinimumComponent(handle), 
			"CIPerspectiveTile" => new CIPerspectiveTile(handle), 
			"CIPerspectiveTransform" => new CIPerspectiveTransform(handle), 
			"CIPixellate" => new CIPixellate(handle), 
			"CIRandomGenerator" => new CIRandomGenerator(handle), 
			"CISharpenLuminance" => new CISharpenLuminance(handle), 
			"CIStarShineGenerator" => new CIStarShineGenerator(handle), 
			"CIUnsharpMask" => new CIUnsharpMask(handle), 
			"CICircleSplashDistortion" => new CICircleSplashDistortion(handle), 
			"CIDepthOfField" => new CIDepthOfField(handle), 
			"CIPageCurlTransition" => new CIPageCurlTransition(handle), 
			"CIRippleTransition" => new CIRippleTransition(handle), 
			_ => throw new NotImplementedException($"Unknown filter type returned: `{filterName}', returning a default CIFilter"), 
		};
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFilter(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIFilter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIFilter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setDefaults")]
	public virtual void SetDefaults()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetDefaultsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetDefaultsHandle);
		}
	}

	[Export("filterWithName:")]
	public static CIFilter FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		CIFilter result = (CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("filterNamesInCategory:")]
	public static string[] FilterNamesInCategory(string category)
	{
		if (category == null)
		{
			throw new ArgumentNullException("category");
		}
		IntPtr arg = NSString.CreateNative(category);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterNamesInCategory_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("filterNamesInCategories:")]
	internal static string[] _FilterNamesInCategories(string[] categories)
	{
		if (categories == null)
		{
			throw new ArgumentNullException("categories");
		}
		NSArray nSArray = NSArray.FromStrings(categories);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterNamesInCategories_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("apply:arguments:options:")]
	public virtual CIImage Apply(CIKernel k, NSArray args, NSDictionary options)
	{
		if (k == null)
		{
			throw new ArgumentNullException("k");
		}
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selApplyArgumentsOptions_Handle, k.Handle, args.Handle, options.Handle));
		}
		return (CIImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selApplyArgumentsOptions_Handle, k.Handle, args.Handle, options.Handle));
	}

	[Export("registerFilterName:constructor:classAttributes:")]
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRegisterFilterNameConstructorClassAttributes_Handle, arg, constructorObject.Handle, classAttributes.Handle);
		NSString.ReleaseNative(arg);
	}

	[Export("localizedNameForFilterName:")]
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

	[Export("localizedNameForCategory:")]
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

	[Export("localizedDescriptionForFilterName:")]
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

	[Export("localizedReferenceDocumentationForFilterName:")]
	public static NSUrl FilterLocalizedReferenceDocumentation(string filterName)
	{
		if (filterName == null)
		{
			throw new ArgumentNullException("filterName");
		}
		IntPtr arg = NSString.CreateNative(filterName);
		NSUrl result = (NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedReferenceDocumentationForFilterName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setValue:forKey:")]
	internal new virtual void SetValueForKey(NSObject value, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValueForKey_Handle, value?.Handle ?? IntPtr.Zero, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValueForKey_Handle, value?.Handle ?? IntPtr.Zero, key.Handle);
		}
	}

	[Export("valueForKey:")]
	internal new virtual NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, key.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Attributes_var = null;
		}
	}
}
