using Foundation;

namespace CoreText;

public class CTFontFeatureTypographicExtras : CTFontFeatureSelectors
{
	public enum Selector
	{
		HyphensToEmDashOn,
		HyphensToEmDashOff,
		HyphenToEnDashOn,
		HyphenToEnDashOff,
		SlashedZeroOn,
		SlashedZeroOff,
		FormInterrobangOn,
		FormInterrobangOff,
		SmartQuotesOn,
		SmartQuotesOff,
		PeriodsToEllipsisOn,
		PeriodsToEllipsisOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureTypographicExtras(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
