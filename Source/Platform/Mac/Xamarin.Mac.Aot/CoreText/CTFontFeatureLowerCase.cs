using Foundation;

namespace CoreText;

public class CTFontFeatureLowerCase : CTFontFeatureSelectors
{
	public enum Selector
	{
		DefaultLowerCase,
		LowerCaseSmallCaps,
		LowerCasePetiteCaps
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureLowerCase(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
