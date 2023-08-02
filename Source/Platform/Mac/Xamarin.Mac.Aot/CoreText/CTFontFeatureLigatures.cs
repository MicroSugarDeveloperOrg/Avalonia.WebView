using Foundation;

namespace CoreText;

public class CTFontFeatureLigatures : CTFontFeatureSelectors
{
	public enum Selector
	{
		RequiredLigaturesOn,
		RequiredLigaturesOff,
		CommonLigaturesOn,
		CommonLigaturesOff,
		RareLigaturesOn,
		RareLigaturesOff,
		LogosOn,
		LogosOff,
		RebusPicturesOn,
		RebusPicturesOff,
		DiphthongLigaturesOn,
		DiphthongLigaturesOff,
		SquaredLigaturesOn,
		SquaredLigaturesOff,
		AbbrevSquaredLigaturesOn,
		AbbrevSquaredLigaturesOff,
		SymbolLigaturesOn,
		SymbolLigaturesOff,
		ContextualLigaturesOn,
		ContextualLigaturesOff,
		HistoricalLigaturesOn,
		HistoricalLigaturesOff
	}

	public Selector Feature => (Selector)base.FeatureWeak;

	public CTFontFeatureLigatures(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
