using Foundation;

namespace CoreText;

public class CTFontFeatureCursiveConnection : CTFontFeatureSelectors
{
	public enum Selector
	{
		Unconnected,
		PartiallyConnected,
		Cursive
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureCursiveConnection(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
