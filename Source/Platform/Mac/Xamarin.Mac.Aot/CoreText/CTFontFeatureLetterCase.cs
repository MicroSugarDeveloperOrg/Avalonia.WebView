using System;
using Foundation;

namespace CoreText;

[Obsolete("Deprecated")]
public class CTFontFeatureLetterCase : CTFontFeatureSelectors
{
	public enum Selector
	{
		UpperAndLowerCase,
		AllCaps,
		AllLowerCase,
		SmallCaps,
		InitialCaps,
		InitialCapsAndSmallCaps
	}

	public Selector Feature => Feature;

	public CTFontFeatureLetterCase(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
