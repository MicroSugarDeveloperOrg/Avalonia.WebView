using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public static class CTFontTraitKey
{
	public static readonly NSString Symbolic;

	public static readonly NSString Weight;

	public static readonly NSString Width;

	public static readonly NSString Slant;

	static CTFontTraitKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Symbolic = Dlfcn.GetStringConstant(intPtr, "kCTFontSymbolicTrait");
			Weight = Dlfcn.GetStringConstant(intPtr, "kCTFontWeightTrait");
			Width = Dlfcn.GetStringConstant(intPtr, "kCTFontWidthTrait");
			Slant = Dlfcn.GetStringConstant(intPtr, "kCTFontSlantTrait");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
