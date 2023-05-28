using Foundation;

namespace CoreText;

public class CTFontFeatureLinguisticRearrangementConnection : CTFontFeatureSelectors
{
	public enum Selector
	{
		LinguisticRearrangementOn,
		LinguisticRearrangementOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureLinguisticRearrangementConnection(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
