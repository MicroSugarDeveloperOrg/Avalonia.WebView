using System;
using Foundation;

namespace CoreText;

public class CTFontFeatureRubyKana : CTFontFeatureSelectors
{
	public enum Selector
	{
		[Obsolete("Deprecated. Use RubyKanaOn instead")]
		NoRubyKana,
		[Obsolete("Deprecated. Use RubyKanaOff instead")]
		RubyKana,
		RubyKanaOn,
		RubyKanaOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureRubyKana(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
