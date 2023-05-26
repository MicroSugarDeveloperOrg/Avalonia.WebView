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

	public Selector Feature => Feature;

	public CTFontFeatureNumberSpacing(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
