using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontFeatureKey
{
	public static readonly NSString Identifier;

	public static readonly NSString Name;

	public static readonly NSString Exclusive;

	public static readonly NSString Selectors;

	static CTFontFeatureKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Identifier = Dlfcn.GetStringConstant(intPtr, "kCTFontFeatureTypeIdentifierKey");
			Name = Dlfcn.GetStringConstant(intPtr, "kCTFontFeatureTypeNameKey");
			Exclusive = Dlfcn.GetStringConstant(intPtr, "kCTFontFeatureTypeExclusiveKey");
			Selectors = Dlfcn.GetStringConstant(intPtr, "kCTFontFeatureTypeSelectorsKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
