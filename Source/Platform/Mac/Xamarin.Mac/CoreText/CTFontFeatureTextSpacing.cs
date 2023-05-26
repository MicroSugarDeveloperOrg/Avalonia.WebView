using Foundation;

namespace CoreText;

public class CTFontFeatureTextSpacing : CTFontFeatureSelectors
{
	public enum Selector
	{
		ProportionalText,
		MonospacedText,
		HalfWidthText,
		ThirdWidthText,
		QuarterWidthText,
		AltProportionalText,
		AltHalfWidthText
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureTextSpacing(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
