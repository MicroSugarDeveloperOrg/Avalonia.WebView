using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontFeatureSelectors
{
	public NSDictionary Dictionary { get; private set; }

	[Advice("Use one of descendant classes")]
	public NSNumber Identifier
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

	protected int FeatureWeak => (int)(NSNumber)Dictionary[CTFontFeatureSelectorKey.Identifier];

	public string Name
	{
		get
		{
			return Adapter.GetStringValue(Dictionary, CTFontFeatureSelectorKey.Name);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontFeatureSelectorKey.Name, value);
		}
	}

	public bool Default
	{
		get
		{
			return CFDictionary.GetBooleanValue(Dictionary.Handle, CTFontFeatureSelectorKey.Default.Handle);
		}
		set
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, CTFontFeatureSelectorKey.Default.Handle, value);
		}
	}

	public bool Setting
	{
		get
		{
			return CFDictionary.GetBooleanValue(Dictionary.Handle, CTFontFeatureSelectorKey.Setting.Handle);
		}
		set
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, CTFontFeatureSelectorKey.Setting.Handle, value);
		}
	}

	public CTFontFeatureSelectors()
		: this(new NSMutableDictionary())
	{
	}

	public CTFontFeatureSelectors(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}

	internal static CTFontFeatureSelectors Create(FontFeatureGroup featureGroup, NSDictionary dictionary)
	{
		return featureGroup switch
		{
			FontFeatureGroup.AllTypographicFeatures => new CTFontFeatureAllTypographicFeatures(dictionary), 
			FontFeatureGroup.Ligatures => new CTFontFeatureLigatures(dictionary), 
			FontFeatureGroup.CursiveConnection => new CTFontFeatureCursiveConnection(dictionary), 
			FontFeatureGroup.LetterCase => new CTFontFeatureLetterCase(dictionary), 
			FontFeatureGroup.VerticalSubstitution => new CTFontFeatureVerticalSubstitutionConnection(dictionary), 
			FontFeatureGroup.LinguisticRearrangement => new CTFontFeatureLinguisticRearrangementConnection(dictionary), 
			FontFeatureGroup.NumberSpacing => new CTFontFeatureNumberSpacing(dictionary), 
			FontFeatureGroup.SmartSwash => new CTFontFeatureSmartSwash(dictionary), 
			FontFeatureGroup.Diacritics => new CTFontFeatureDiacritics(dictionary), 
			FontFeatureGroup.VerticalPosition => new CTFontFeatureVerticalPosition(dictionary), 
			FontFeatureGroup.Fractions => new CTFontFeatureFractions(dictionary), 
			FontFeatureGroup.OverlappingCharacters => new CTFontFeatureOverlappingCharacters(dictionary), 
			FontFeatureGroup.TypographicExtras => new CTFontFeatureTypographicExtras(dictionary), 
			FontFeatureGroup.MathematicalExtras => new CTFontFeatureMathematicalExtras(dictionary), 
			FontFeatureGroup.OrnamentSets => new CTFontFeatureOrnamentSets(dictionary), 
			FontFeatureGroup.CharacterAlternatives => new CTFontFeatureCharacterAlternatives(dictionary), 
			FontFeatureGroup.DesignComplexity => new CTFontFeatureDesignComplexity(dictionary), 
			FontFeatureGroup.StyleOptions => new CTFontFeatureStyleOptions(dictionary), 
			FontFeatureGroup.CharacterShape => new CTFontFeatureCharacterShape(dictionary), 
			FontFeatureGroup.NumberCase => new CTFontFeatureNumberCase(dictionary), 
			FontFeatureGroup.TextSpacing => new CTFontFeatureTextSpacing(dictionary), 
			FontFeatureGroup.Transliteration => new CTFontFeatureTransliteration(dictionary), 
			FontFeatureGroup.Annotation => new CTFontFeatureAnnotation(dictionary), 
			FontFeatureGroup.KanaSpacing => new CTFontFeatureKanaSpacing(dictionary), 
			FontFeatureGroup.IdeographicSpacing => new CTFontFeatureIdeographicSpacing(dictionary), 
			FontFeatureGroup.UnicodeDecomposition => new CTFontFeatureUnicodeDecomposition(dictionary), 
			FontFeatureGroup.RubyKana => new CTFontFeatureRubyKana(dictionary), 
			FontFeatureGroup.CJKSymbolAlternatives => new CTFontFeatureCJKSymbolAlternatives(dictionary), 
			FontFeatureGroup.IdeographicAlternatives => new CTFontFeatureIdeographicAlternatives(dictionary), 
			FontFeatureGroup.CJKVerticalRomanPlacement => new CTFontFeatureCJKVerticalRomanPlacement(dictionary), 
			FontFeatureGroup.ItalicCJKRoman => new CTFontFeatureItalicCJKRoman(dictionary), 
			FontFeatureGroup.CaseSensitiveLayout => new CTFontFeatureCaseSensitiveLayout(dictionary), 
			FontFeatureGroup.AlternateKana => new CTFontFeatureAlternateKana(dictionary), 
			FontFeatureGroup.StylisticAlternatives => new CTFontFeatureStylisticAlternatives(dictionary), 
			FontFeatureGroup.ContextualAlternates => new CTFontFeatureContextualAlternates(dictionary), 
			FontFeatureGroup.LowerCase => new CTFontFeatureLowerCase(dictionary), 
			FontFeatureGroup.UpperCase => new CTFontFeatureUpperCase(dictionary), 
			FontFeatureGroup.CJKRomanSpacing => new CTFontFeatureCJKRomanSpacing(dictionary), 
			_ => new CTFontFeatureSelectors(dictionary), 
		};
	}
}
