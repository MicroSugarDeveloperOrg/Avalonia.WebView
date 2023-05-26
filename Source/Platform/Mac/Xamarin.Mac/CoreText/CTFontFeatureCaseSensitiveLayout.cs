using Foundation;

namespace CoreText;

public class CTFontFeatureCaseSensitiveLayout : CTFontFeatureSelectors
{
	public enum Selector
	{
		CaseSensitiveLayoutOn,
		CaseSensitiveLayoutOff,
		CaseSensitiveSpacingOn,
		CaseSensitiveSpacingOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureCaseSensitiveLayout(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
