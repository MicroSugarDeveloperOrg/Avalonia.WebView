using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public static class CTFontDescriptorAttributeKey
{
	public static readonly NSString Url;

	public static readonly NSString Name;

	public static readonly NSString DisplayName;

	public static readonly NSString FamilyName;

	public static readonly NSString StyleName;

	public static readonly NSString Traits;

	public static readonly NSString Variation;

	public static readonly NSString Size;

	public static readonly NSString Matrix;

	public static readonly NSString CascadeList;

	public static readonly NSString CharacterSet;

	public static readonly NSString Languages;

	public static readonly NSString BaselineAdjust;

	public static readonly NSString MacintoshEncodings;

	public static readonly NSString Features;

	public static readonly NSString FeatureSettings;

	public static readonly NSString FixedAdvance;

	public static readonly NSString FontOrientation;

	public static readonly NSString FontFormat;

	public static readonly NSString RegistrationScope;

	public static readonly NSString Priority;

	public static readonly NSString Enabled;

	static CTFontDescriptorAttributeKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Url = Dlfcn.GetStringConstant(intPtr, "kCTFontURLAttribute");
			Name = Dlfcn.GetStringConstant(intPtr, "kCTFontNameAttribute");
			DisplayName = Dlfcn.GetStringConstant(intPtr, "kCTFontDisplayNameAttribute");
			FamilyName = Dlfcn.GetStringConstant(intPtr, "kCTFontFamilyNameAttribute");
			StyleName = Dlfcn.GetStringConstant(intPtr, "kCTFontStyleNameAttribute");
			Traits = Dlfcn.GetStringConstant(intPtr, "kCTFontTraitsAttribute");
			Variation = Dlfcn.GetStringConstant(intPtr, "kCTFontVariationAttribute");
			Size = Dlfcn.GetStringConstant(intPtr, "kCTFontSizeAttribute");
			Matrix = Dlfcn.GetStringConstant(intPtr, "kCTFontMatrixAttribute");
			CascadeList = Dlfcn.GetStringConstant(intPtr, "kCTFontCascadeListAttribute");
			CharacterSet = Dlfcn.GetStringConstant(intPtr, "kCTFontCharacterSetAttribute");
			Languages = Dlfcn.GetStringConstant(intPtr, "kCTFontLanguagesAttribute");
			BaselineAdjust = Dlfcn.GetStringConstant(intPtr, "kCTFontBaselineAdjustAttribute");
			MacintoshEncodings = Dlfcn.GetStringConstant(intPtr, "kCTFontMacintoshEncodingsAttribute");
			Features = Dlfcn.GetStringConstant(intPtr, "kCTFontFeaturesAttribute");
			FeatureSettings = Dlfcn.GetStringConstant(intPtr, "kCTFontFeatureSettingsAttribute");
			FixedAdvance = Dlfcn.GetStringConstant(intPtr, "kCTFontFixedAdvanceAttribute");
			FontOrientation = Dlfcn.GetStringConstant(intPtr, "kCTFontOrientationAttribute");
			FontFormat = Dlfcn.GetStringConstant(intPtr, "kCTFontFormatAttribute");
			RegistrationScope = Dlfcn.GetStringConstant(intPtr, "kCTFontRegistrationScopeAttribute");
			Priority = Dlfcn.GetStringConstant(intPtr, "kCTFontPriorityAttribute");
			Enabled = Dlfcn.GetStringConstant(intPtr, "kCTFontEnabledAttribute");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
