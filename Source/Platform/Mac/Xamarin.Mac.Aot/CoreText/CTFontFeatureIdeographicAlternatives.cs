using Foundation;

namespace CoreText;

public class CTFontFeatureIdeographicAlternatives : CTFontFeatureSelectors
{
	public enum Selector
	{
		NoIdeographicAlternatives,
		IdeographicAltOne,
		IdeographicAltTwo,
		IdeographicAltThree,
		IdeographicAltFour,
		IdeographicAltFive
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureIdeographicAlternatives(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
