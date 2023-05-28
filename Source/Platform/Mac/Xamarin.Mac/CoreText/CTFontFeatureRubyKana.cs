using Foundation;
using ObjCRuntime;

namespace CoreText;

public class CTFontFeatureRubyKana : CTFontFeatureSelectors
{
	public enum Selector
	{
		[Deprecated(PlatformName.iOS, 5, 1, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
		NoRubyKana,
		[Deprecated(PlatformName.iOS, 5, 1, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, null)]
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
