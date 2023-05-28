using Foundation;
using ObjCRuntime;

namespace CoreText;

public class CTFontFeatureItalicCJKRoman : CTFontFeatureSelectors
{
	public enum Selector
	{
		[Deprecated(PlatformName.iOS, 5, 1, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
		NoCJKItalicRoman,
		[Deprecated(PlatformName.iOS, 5, 1, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
		CJKItalicRoman,
		CJKItalicRomanOn,
		CJKItalicRomanOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureItalicCJKRoman(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
