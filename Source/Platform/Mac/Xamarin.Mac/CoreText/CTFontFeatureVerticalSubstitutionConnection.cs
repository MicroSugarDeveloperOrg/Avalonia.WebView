using Foundation;

namespace CoreText;

public class CTFontFeatureVerticalSubstitutionConnection : CTFontFeatureSelectors
{
	public enum Selector
	{
		SubstituteVerticalFormsOn,
		SubstituteVerticalFormsOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureVerticalSubstitutionConnection(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
