using System;
using Foundation;

namespace CoreText;

public class CTFontFeatureSettings
{
	public NSDictionary Dictionary { get; private set; }

	public FontFeatureGroup FeatureGroup => (FontFeatureGroup)(int)(NSNumber)Dictionary[CTFontFeatureKey.Identifier];

	public int FeatureWeak => (int)(NSNumber)Dictionary[CTFontFeatureSelectorKey.Identifier];

	internal CTFontFeatureSettings(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
