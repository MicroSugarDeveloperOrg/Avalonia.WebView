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

	public Selector Feature => Feature;

	public CTFontFeatureCursiveConnection(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
