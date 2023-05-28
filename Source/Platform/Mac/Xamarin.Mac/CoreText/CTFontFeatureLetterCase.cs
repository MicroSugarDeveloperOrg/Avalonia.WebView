using Foundation;
using ObjCRuntime;

namespace CoreText;

[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
public class CTFontFeatureLetterCase : CTFontFeatureSelectors
{
	public enum Selector
	{
		UpperAndLowerCase,
		AllCaps,
		AllLowerCase,
		SmallCaps,
		InitialCaps,
		InitialCapsAndSmallCaps
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureLetterCase(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
