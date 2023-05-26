using Foundation;

namespace CoreText;

public class CTFontFeatureAlternateKana : CTFontFeatureSelectors
{
	public enum Selector
	{
		AlternateHorizKanaOn,
		AlternateHorizKanaOff,
		AlternateVertKanaOn,
		AlternateVertKanaOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureAlternateKana(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
