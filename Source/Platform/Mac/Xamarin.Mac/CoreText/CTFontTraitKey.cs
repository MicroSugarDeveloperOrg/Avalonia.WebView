using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTFontTraitKey
{
	public static readonly NSString Symbolic;

	public static readonly NSString Weight;

	public static readonly NSString Width;

	public static readonly NSString Slant;

	static CTFontTraitKey()
	{
		IntPtr handle = Libraries.CoreText.Handle;
		Symbolic = Dlfcn.GetStringConstant(handle, "kCTFontSymbolicTrait");
		Weight = Dlfcn.GetStringConstant(handle, "kCTFontWeightTrait");
		Width = Dlfcn.GetStringConstant(handle, "kCTFontWidthTrait");
		Slant = Dlfcn.GetStringConstant(handle, "kCTFontSlantTrait");
	}
}
