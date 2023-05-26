using System;

namespace CoreText;

public enum FontFeatureGroup
{
	AllTypographicFeatures = 0,
	Ligatures = 1,
	CursiveConnection = 2,
	[Obsolete("Deprecated. Use LowerCase or UpperCase instead")]
	LetterCase = 3,
	VerticalSubstitution = 4,
	LinguisticRearrangement = 5,
	NumberSpacing = 6,
	SmartSwash = 8,
	Diacritics = 9,
	VerticalPosition = 10,
	Fractions = 11,
	OverlappingCharacters = 13,
	TypographicExtras = 14,
	MathematicalExtras = 15,
	OrnamentSets = 16,
	CharacterAlternatives = 17,
	DesignComplexity = 18,
	StyleOptions = 19,
	CharacterShape = 20,
	NumberCase = 21,
	TextSpacing = 22,
	Transliteration = 23,
	Annotation = 24,
	KanaSpacing = 25,
	IdeographicSpacing = 26,
	UnicodeDecomposition = 27,
	RubyKana = 28,
	CJKSymbolAlternatives = 29,
	IdeographicAlternatives = 30,
	CJKVerticalRomanPlacement = 31,
	ItalicCJKRoman = 32,
	CaseSensitiveLayout = 33,
	AlternateKana = 34,
	StylisticAlternatives = 35,
	ContextualAlternates = 36,
	LowerCase = 37,
	UpperCase = 38,
	CJKRomanSpacing = 103
}
