using Foundation;

namespace CoreText;

public class CTFontFeatureCharacterShape : CTFontFeatureSelectors
{
	public enum Selector
	{
		TraditionalCharacters,
		SimplifiedCharacters,
		JIS1978Characters,
		JIS1983Characters,
		JIS1990Characters,
		TraditionalAltOne,
		TraditionalAltTwo,
		TraditionalAltThree,
		TraditionalAltFour,
		TraditionalAltFive,
		ExpertCharacters,
		JIS2004Characters,
		HojoCharacters,
		NLCCharacters,
		TraditionalNamesCharacters
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureCharacterShape(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
