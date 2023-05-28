using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTFontManagerErrorKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontUrlsKey;

	[Field("kCTFontManagerErrorFontURLsKey", "CoreText")]
	public static NSString FontUrlsKey
	{
		get
		{
			if (_FontUrlsKey == null)
			{
				_FontUrlsKey = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontManagerErrorFontURLsKey");
			}
			return _FontUrlsKey;
		}
	}
}
