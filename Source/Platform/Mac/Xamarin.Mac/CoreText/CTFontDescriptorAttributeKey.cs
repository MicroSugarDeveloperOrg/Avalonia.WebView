using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

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
		IntPtr handle = Libraries.CoreText.Handle;
		Url = Dlfcn.GetStringConstant(handle, "kCTFontURLAttribute");
		Name = Dlfcn.GetStringConstant(handle, "kCTFontNameAttribute");
		DisplayName = Dlfcn.GetStringConstant(handle, "kCTFontDisplayNameAttribute");
		FamilyName = Dlfcn.GetStringConstant(handle, "kCTFontFamilyNameAttribute");
		StyleName = Dlfcn.GetStringConstant(handle, "kCTFontStyleNameAttribute");
		Traits = Dlfcn.GetStringConstant(handle, "kCTFontTraitsAttribute");
		Variation = Dlfcn.GetStringConstant(handle, "kCTFontVariationAttribute");
		Size = Dlfcn.GetStringConstant(handle, "kCTFontSizeAttribute");
		Matrix = Dlfcn.GetStringConstant(handle, "kCTFontMatrixAttribute");
		CascadeList = Dlfcn.GetStringConstant(handle, "kCTFontCascadeListAttribute");
		CharacterSet = Dlfcn.GetStringConstant(handle, "kCTFontCharacterSetAttribute");
		Languages = Dlfcn.GetStringConstant(handle, "kCTFontLanguagesAttribute");
		BaselineAdjust = Dlfcn.GetStringConstant(handle, "kCTFontBaselineAdjustAttribute");
		MacintoshEncodings = Dlfcn.GetStringConstant(handle, "kCTFontMacintoshEncodingsAttribute");
		Features = Dlfcn.GetStringConstant(handle, "kCTFontFeaturesAttribute");
		FeatureSettings = Dlfcn.GetStringConstant(handle, "kCTFontFeatureSettingsAttribute");
		FixedAdvance = Dlfcn.GetStringConstant(handle, "kCTFontFixedAdvanceAttribute");
		FontOrientation = Dlfcn.GetStringConstant(handle, "kCTFontOrientationAttribute");
		FontFormat = Dlfcn.GetStringConstant(handle, "kCTFontFormatAttribute");
		RegistrationScope = Dlfcn.GetStringConstant(handle, "kCTFontRegistrationScopeAttribute");
		Priority = Dlfcn.GetStringConstant(handle, "kCTFontPriorityAttribute");
		Enabled = Dlfcn.GetStringConstant(handle, "kCTFontEnabledAttribute");
	}
}
