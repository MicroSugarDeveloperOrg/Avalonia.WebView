using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class NSFontWeight
{
	[Field("NSFontWeightBlack", "AppKit")]
	public static nfloat Black => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightBlack");

	[Field("NSFontWeightBold", "AppKit")]
	public static nfloat Bold => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightBold");

	[Field("NSFontWeightHeavy", "AppKit")]
	public static nfloat Heavy => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightHeavy");

	[Field("NSFontWeightLight", "AppKit")]
	public static nfloat Light => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightLight");

	[Field("NSFontWeightMedium", "AppKit")]
	public static nfloat Medium => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightMedium");

	[Field("NSFontWeightRegular", "AppKit")]
	public static nfloat Regular => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightRegular");

	[Field("NSFontWeightSemibold", "AppKit")]
	public static nfloat Semibold => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightSemibold");

	[Field("NSFontWeightThin", "AppKit")]
	public static nfloat Thin => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightThin");

	[Field("NSFontWeightUltraLight", "AppKit")]
	public static nfloat UltraLight => Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSFontWeightUltraLight");
}
