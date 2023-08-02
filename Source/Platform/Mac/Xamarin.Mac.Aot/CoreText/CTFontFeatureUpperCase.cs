using Foundation;

namespace CoreText;

public class CTFontFeatureUpperCase : CTFontFeatureSelectors
{
	public enum Selector
	{
		DefaultUpperCase,
		UpperCaseSmallCaps,
		UpperCasePetiteCaps
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureUpperCase(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
