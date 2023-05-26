using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public static class CTFontVariationAxisKey
{
	public static readonly NSString Identifier;

	public static readonly NSString MinimumValue;

	public static readonly NSString MaximumValue;

	public static readonly NSString DefaultValue;

	public static readonly NSString Name;

	static CTFontVariationAxisKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Identifier = Dlfcn.GetStringConstant(intPtr, "kCTFontVariationAxisIdentifierKey");
			MinimumValue = Dlfcn.GetStringConstant(intPtr, "kCTFontVariationAxisMinimumValueKey");
			MaximumValue = Dlfcn.GetStringConstant(intPtr, "kCTFontVariationAxisMaximumValueKey");
			DefaultValue = Dlfcn.GetStringConstant(intPtr, "kCTFontVariationAxisDefaultValueKey");
			Name = Dlfcn.GetStringConstant(intPtr, "kCTFontVariationAxisNameKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
