using Foundation;

namespace CoreText;

public class CTFontFeatureDesignComplexity : CTFontFeatureSelectors
{
	public enum Selector
	{
		DesignLevel1,
		DesignLevel2,
		DesignLevel3,
		DesignLevel4,
		DesignLevel5
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureDesignComplexity(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
