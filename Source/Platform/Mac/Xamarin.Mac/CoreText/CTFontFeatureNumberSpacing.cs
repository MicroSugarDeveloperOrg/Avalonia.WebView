using Foundation;

namespace CoreText;

public class CTFontFeatureNumberSpacing : CTFontFeatureSelectors
{
	public enum Selector
	{
		MonospacedNumbers,
		ProportionalNumbers,
		ThirdWidthNumbers,
		QuarterWidthNumbers
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureNumberSpacing(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
