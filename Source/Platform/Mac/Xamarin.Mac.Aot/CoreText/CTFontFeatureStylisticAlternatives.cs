using Foundation;

namespace CoreText;

public class CTFontFeatureStylisticAlternatives : CTFontFeatureSelectors
{
	public enum Selector
	{
		NoStylisticAlternates = 0,
		StylisticAltOneOn = 2,
		StylisticAltOneOff = 3,
		StylisticAltTwoOn = 4,
		StylisticAltTwoOff = 5,
		StylisticAltThreeOn = 6,
		StylisticAltThreeOff = 7,
		StylisticAltFourOn = 8,
		StylisticAltFourOff = 9,
		StylisticAltFiveOn = 10,
		StylisticAltFiveOff = 11,
		StylisticAltSixOn = 12,
		StylisticAltSixOff = 13,
		StylisticAltSevenOn = 14,
		StylisticAltSevenOff = 15,
		StylisticAltEightOn = 16,
		StylisticAltEightOff = 17,
		StylisticAltNineOn = 18,
		StylisticAltNineOff = 19,
		StylisticAltTenOn = 20,
		StylisticAltTenOff = 21,
		StylisticAltElevenOn = 22,
		StylisticAltElevenOff = 23,
		StylisticAltTwelveOn = 24,
		StylisticAltTwelveOff = 25,
		StylisticAltThirteenOn = 26,
		StylisticAltThirteenOff = 27,
		StylisticAltFourteenOn = 28,
		StylisticAltFourteenOff = 29,
		StylisticAltFifteenOn = 30,
		StylisticAltFifteenOff = 31,
		StylisticAltSixteenOn = 32,
		StylisticAltSixteenOff = 33,
		StylisticAltSeventeenOn = 34,
		StylisticAltSeventeenOff = 35,
		StylisticAltEighteenOn = 36,
		StylisticAltEighteenOff = 37,
		StylisticAltNineteenOn = 38,
		StylisticAltNineteenOff = 39,
		StylisticAltTwentyOn = 40,
		StylisticAltTwentyOff = 41
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureStylisticAlternatives(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
