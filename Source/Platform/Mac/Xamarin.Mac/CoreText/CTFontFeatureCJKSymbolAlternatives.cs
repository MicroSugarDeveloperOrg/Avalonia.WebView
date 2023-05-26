using Foundation;

namespace CoreText;

public class CTFontFeatureCJKSymbolAlternatives : CTFontFeatureSelectors
{
	public enum Selector
	{
		NoCJKSymbolAlternatives,
		CJKSymbolAltOne,
		CJKSymbolAltTwo,
		CJKSymbolAltThree,
		CJKSymbolAltFour,
		CJKSymbolAltFive
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureCJKSymbolAlternatives(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
