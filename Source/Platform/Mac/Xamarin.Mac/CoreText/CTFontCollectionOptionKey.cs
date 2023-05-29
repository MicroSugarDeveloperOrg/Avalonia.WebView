using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public static class CTFontCollectionOptionKey
{
	public static readonly NSString RemoveDuplicates;

	static CTFontCollectionOptionKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			RemoveDuplicates = Dlfcn.GetStringConstant(intPtr, "kCTFontCollectionRemoveDuplicatesOption");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
