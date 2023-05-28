using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTFontCollectionOptionKey
{
	public static readonly NSString RemoveDuplicates;

	static CTFontCollectionOptionKey()
	{
		RemoveDuplicates = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontCollectionRemoveDuplicatesOption");
	}
}
