using Foundation;

namespace CoreText;

public class CTFontFeatureOverlappingCharacters : CTFontFeatureSelectors
{
	public enum Selector
	{
		PreventOverlapOn,
		PreventOverlapOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureOverlappingCharacters(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
