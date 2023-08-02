using Foundation;

namespace CoreText;

public class CTFontFeatureMathematicalExtras : CTFontFeatureSelectors
{
	public enum Selector
	{
		HyphenToMinusOn,
		HyphenToMinusOff,
		AsteriskToMultiplyOn,
		AsteriskToMultiplyOff,
		SlashToDivideOn,
		SlashToDivideOff,
		InequalityLigaturesOn,
		InequalityLigaturesOff,
		ExponentsOn,
		ExponentsOff,
		MathematicalGreekOn,
		MathematicalGreekOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureMathematicalExtras(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
