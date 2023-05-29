using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontFeatureSettings
{
	public NSDictionary Dictionary { get; private set; }

	[Advice("Use FeatureGroup property instead")]
	public NSNumber TypeIdentifier
	{
		get
		{
			return (NSNumber)Dictionary[CTFontFeatureKey.Identifier];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontFeatureKey.Identifier, value);
		}
	}

	public FontFeatureGroup FeatureGroup => (FontFeatureGroup)(int)(NSNumber)Dictionary[CTFontFeatureKey.Identifier];

	[Advice("Use FeatureWeak or FeatureGroup instead")]
	public NSNumber SelectorIdentifier
	{
		get
		{
			return (NSNumber)Dictionary[CTFontFeatureSelectorKey.Identifier];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontFeatureSelectorKey.Identifier, value);
		}
	}

	public int FeatureWeak => (int)(NSNumber)Dictionary[CTFontFeatureSelectorKey.Identifier];

	public CTFontFeatureSettings(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
