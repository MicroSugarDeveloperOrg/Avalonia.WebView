using Foundation;
using ObjCRuntime;

namespace NaturalLanguage;

[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public static class NLTag
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Adjective;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Adverb;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Classifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CloseParenthesis;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CloseQuote;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Conjunction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Dash;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Determiner;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Idiom;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Interjection;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Noun;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Number;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OpenParenthesis;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OpenQuote;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrganizationName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Other;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OtherPunctuation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OtherWhitespace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OtherWord;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ParagraphBreak;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Particle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersonalName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaceName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Preposition;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Pronoun;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Punctuation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SentenceTerminator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Verb;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Whitespace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Word;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WordJoiner;

	[Field("NLTagAdjective", "NaturalLanguage")]
	public static NSString Adjective
	{
		get
		{
			if (_Adjective == null)
			{
				_Adjective = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagAdjective");
			}
			return _Adjective;
		}
	}

	[Field("NLTagAdverb", "NaturalLanguage")]
	public static NSString Adverb
	{
		get
		{
			if (_Adverb == null)
			{
				_Adverb = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagAdverb");
			}
			return _Adverb;
		}
	}

	[Field("NLTagClassifier", "NaturalLanguage")]
	public static NSString Classifier
	{
		get
		{
			if (_Classifier == null)
			{
				_Classifier = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagClassifier");
			}
			return _Classifier;
		}
	}

	[Field("NLTagCloseParenthesis", "NaturalLanguage")]
	public static NSString CloseParenthesis
	{
		get
		{
			if (_CloseParenthesis == null)
			{
				_CloseParenthesis = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagCloseParenthesis");
			}
			return _CloseParenthesis;
		}
	}

	[Field("NLTagCloseQuote", "NaturalLanguage")]
	public static NSString CloseQuote
	{
		get
		{
			if (_CloseQuote == null)
			{
				_CloseQuote = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagCloseQuote");
			}
			return _CloseQuote;
		}
	}

	[Field("NLTagConjunction", "NaturalLanguage")]
	public static NSString Conjunction
	{
		get
		{
			if (_Conjunction == null)
			{
				_Conjunction = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagConjunction");
			}
			return _Conjunction;
		}
	}

	[Field("NLTagDash", "NaturalLanguage")]
	public static NSString Dash
	{
		get
		{
			if (_Dash == null)
			{
				_Dash = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagDash");
			}
			return _Dash;
		}
	}

	[Field("NLTagDeterminer", "NaturalLanguage")]
	public static NSString Determiner
	{
		get
		{
			if (_Determiner == null)
			{
				_Determiner = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagDeterminer");
			}
			return _Determiner;
		}
	}

	[Field("NLTagIdiom", "NaturalLanguage")]
	public static NSString Idiom
	{
		get
		{
			if (_Idiom == null)
			{
				_Idiom = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagIdiom");
			}
			return _Idiom;
		}
	}

	[Field("NLTagInterjection", "NaturalLanguage")]
	public static NSString Interjection
	{
		get
		{
			if (_Interjection == null)
			{
				_Interjection = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagInterjection");
			}
			return _Interjection;
		}
	}

	[Field("NLTagNoun", "NaturalLanguage")]
	public static NSString Noun
	{
		get
		{
			if (_Noun == null)
			{
				_Noun = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagNoun");
			}
			return _Noun;
		}
	}

	[Field("NLTagNumber", "NaturalLanguage")]
	public static NSString Number
	{
		get
		{
			if (_Number == null)
			{
				_Number = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagNumber");
			}
			return _Number;
		}
	}

	[Field("NLTagOpenParenthesis", "NaturalLanguage")]
	public static NSString OpenParenthesis
	{
		get
		{
			if (_OpenParenthesis == null)
			{
				_OpenParenthesis = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagOpenParenthesis");
			}
			return _OpenParenthesis;
		}
	}

	[Field("NLTagOpenQuote", "NaturalLanguage")]
	public static NSString OpenQuote
	{
		get
		{
			if (_OpenQuote == null)
			{
				_OpenQuote = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagOpenQuote");
			}
			return _OpenQuote;
		}
	}

	[Field("NLTagOrganizationName", "NaturalLanguage")]
	public static NSString OrganizationName
	{
		get
		{
			if (_OrganizationName == null)
			{
				_OrganizationName = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagOrganizationName");
			}
			return _OrganizationName;
		}
	}

	[Field("NLTagOther", "NaturalLanguage")]
	public static NSString Other
	{
		get
		{
			if (_Other == null)
			{
				_Other = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagOther");
			}
			return _Other;
		}
	}

	[Field("NLTagOtherPunctuation", "NaturalLanguage")]
	public static NSString OtherPunctuation
	{
		get
		{
			if (_OtherPunctuation == null)
			{
				_OtherPunctuation = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagOtherPunctuation");
			}
			return _OtherPunctuation;
		}
	}

	[Field("NLTagOtherWhitespace", "NaturalLanguage")]
	public static NSString OtherWhitespace
	{
		get
		{
			if (_OtherWhitespace == null)
			{
				_OtherWhitespace = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagOtherWhitespace");
			}
			return _OtherWhitespace;
		}
	}

	[Field("NLTagOtherWord", "NaturalLanguage")]
	public static NSString OtherWord
	{
		get
		{
			if (_OtherWord == null)
			{
				_OtherWord = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagOtherWord");
			}
			return _OtherWord;
		}
	}

	[Field("NLTagParagraphBreak", "NaturalLanguage")]
	public static NSString ParagraphBreak
	{
		get
		{
			if (_ParagraphBreak == null)
			{
				_ParagraphBreak = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagParagraphBreak");
			}
			return _ParagraphBreak;
		}
	}

	[Field("NLTagParticle", "NaturalLanguage")]
	public static NSString Particle
	{
		get
		{
			if (_Particle == null)
			{
				_Particle = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagParticle");
			}
			return _Particle;
		}
	}

	[Field("NLTagPersonalName", "NaturalLanguage")]
	public static NSString PersonalName
	{
		get
		{
			if (_PersonalName == null)
			{
				_PersonalName = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagPersonalName");
			}
			return _PersonalName;
		}
	}

	[Field("NLTagPlaceName", "NaturalLanguage")]
	public static NSString PlaceName
	{
		get
		{
			if (_PlaceName == null)
			{
				_PlaceName = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagPlaceName");
			}
			return _PlaceName;
		}
	}

	[Field("NLTagPreposition", "NaturalLanguage")]
	public static NSString Preposition
	{
		get
		{
			if (_Preposition == null)
			{
				_Preposition = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagPreposition");
			}
			return _Preposition;
		}
	}

	[Field("NLTagPronoun", "NaturalLanguage")]
	public static NSString Pronoun
	{
		get
		{
			if (_Pronoun == null)
			{
				_Pronoun = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagPronoun");
			}
			return _Pronoun;
		}
	}

	[Field("NLTagPunctuation", "NaturalLanguage")]
	public static NSString Punctuation
	{
		get
		{
			if (_Punctuation == null)
			{
				_Punctuation = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagPunctuation");
			}
			return _Punctuation;
		}
	}

	[Field("NLTagSentenceTerminator", "NaturalLanguage")]
	public static NSString SentenceTerminator
	{
		get
		{
			if (_SentenceTerminator == null)
			{
				_SentenceTerminator = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagSentenceTerminator");
			}
			return _SentenceTerminator;
		}
	}

	[Field("NLTagVerb", "NaturalLanguage")]
	public static NSString Verb
	{
		get
		{
			if (_Verb == null)
			{
				_Verb = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagVerb");
			}
			return _Verb;
		}
	}

	[Field("NLTagWhitespace", "NaturalLanguage")]
	public static NSString Whitespace
	{
		get
		{
			if (_Whitespace == null)
			{
				_Whitespace = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagWhitespace");
			}
			return _Whitespace;
		}
	}

	[Field("NLTagWord", "NaturalLanguage")]
	public static NSString Word
	{
		get
		{
			if (_Word == null)
			{
				_Word = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagWord");
			}
			return _Word;
		}
	}

	[Field("NLTagWordJoiner", "NaturalLanguage")]
	public static NSString WordJoiner
	{
		get
		{
			if (_WordJoiner == null)
			{
				_WordJoiner = Dlfcn.GetStringConstant(Libraries.NaturalLanguage.Handle, "NLTagWordJoiner");
			}
			return _WordJoiner;
		}
	}
}
