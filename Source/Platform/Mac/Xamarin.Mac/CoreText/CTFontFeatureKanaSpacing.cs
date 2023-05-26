using Foundation;

namespace CoreText;

public class CTFontFeatureKanaSpacing : CTFontFeatureSelectors
{
	public enum Selector
	{
		FullWidthKana,
		ProportionalKana
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureKanaSpacing(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
