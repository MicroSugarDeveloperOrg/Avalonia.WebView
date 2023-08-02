using Foundation;

namespace CoreText;

public class CTFontFeatureOrnamentSets : CTFontFeatureSelectors
{
	public enum Selector
	{
		NoOrnaments,
		Dingbats,
		PiCharacters,
		Fleurons,
		DecorativeBorders,
		InternationalSymbols,
		MathSymbols
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureOrnamentSets(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
