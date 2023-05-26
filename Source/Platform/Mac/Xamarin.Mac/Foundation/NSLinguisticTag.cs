using ObjCRuntime;

namespace Foundation;

public static class NSLinguisticTag
{
	private static NSString _SchemeTokenType;

	private static NSString _SchemeLexicalClass;

	private static NSString _SchemeNameType;

	private static NSString _SchemeNameTypeOrLexicalClass;

	private static NSString _SchemeLemma;

	private static NSString _SchemeLanguage;

	private static NSString _SchemeScript;

	private static NSString _Word;

	private static NSString _Punctuation;

	private static NSString _Whitespace;

	private static NSString _Other;

	private static NSString _Noun;

	private static NSString _Verb;

	private static NSString _Adjective;

	private static NSString _Adverb;

	private static NSString _Pronoun;

	private static NSString _Determiner;

	private static NSString _Particle;

	private static NSString _Preposition;

	private static NSString _Number;

	private static NSString _Conjunction;

	private static NSString _Interjection;

	private static NSString _Classifier;

	private static NSString _Idiom;

	private static NSString _OtherWord;

	private static NSString _SentenceTerminator;

	private static NSString _OpenQuote;

	private static NSString _CloseQuote;

	private static NSString _OpenParenthesis;

	private static NSString _CloseParenthesis;

	private static NSString _WordJoiner;

	private static NSString _Dash;

	private static NSString _OtherPunctuation;

	private static NSString _ParagraphBreak;

	private static NSString _OtherWhitespace;

	private static NSString _PersonalName;

	private static NSString _PlaceName;

	private static NSString _OrganizationName;

	[Field("NSLinguisticTagSchemeTokenType", "Foundation")]
	public static NSString SchemeTokenType
	{
		get
		{
			if (_SchemeTokenType == null)
			{
				_SchemeTokenType = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSchemeTokenType");
			}
			return _SchemeTokenType;
		}
	}

	[Field("NSLinguisticTagSchemeLexicalClass", "Foundation")]
	public static NSString SchemeLexicalClass
	{
		get
		{
			if (_SchemeLexicalClass == null)
			{
				_SchemeLexicalClass = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSchemeLexicalClass");
			}
			return _SchemeLexicalClass;
		}
	}

	[Field("NSLinguisticTagSchemeNameType", "Foundation")]
	public static NSString SchemeNameType
	{
		get
		{
			if (_SchemeNameType == null)
			{
				_SchemeNameType = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSchemeNameType");
			}
			return _SchemeNameType;
		}
	}

	[Field("NSLinguisticTagSchemeNameTypeOrLexicalClass", "Foundation")]
	public static NSString SchemeNameTypeOrLexicalClass
	{
		get
		{
			if (_SchemeNameTypeOrLexicalClass == null)
			{
				_SchemeNameTypeOrLexicalClass = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSchemeNameTypeOrLexicalClass");
			}
			return _SchemeNameTypeOrLexicalClass;
		}
	}

	[Field("NSLinguisticTagSchemeLemma", "Foundation")]
	public static NSString SchemeLemma
	{
		get
		{
			if (_SchemeLemma == null)
			{
				_SchemeLemma = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSchemeLemma");
			}
			return _SchemeLemma;
		}
	}

	[Field("NSLinguisticTagSchemeLanguage", "Foundation")]
	public static NSString SchemeLanguage
	{
		get
		{
			if (_SchemeLanguage == null)
			{
				_SchemeLanguage = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSchemeLanguage");
			}
			return _SchemeLanguage;
		}
	}

	[Field("NSLinguisticTagSchemeScript", "Foundation")]
	public static NSString SchemeScript
	{
		get
		{
			if (_SchemeScript == null)
			{
				_SchemeScript = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSchemeScript");
			}
			return _SchemeScript;
		}
	}

	[Field("NSLinguisticTagWord", "Foundation")]
	public static NSString Word
	{
		get
		{
			if (_Word == null)
			{
				_Word = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagWord");
			}
			return _Word;
		}
	}

	[Field("NSLinguisticTagPunctuation", "Foundation")]
	public static NSString Punctuation
	{
		get
		{
			if (_Punctuation == null)
			{
				_Punctuation = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagPunctuation");
			}
			return _Punctuation;
		}
	}

	[Field("NSLinguisticTagWhitespace", "Foundation")]
	public static NSString Whitespace
	{
		get
		{
			if (_Whitespace == null)
			{
				_Whitespace = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagWhitespace");
			}
			return _Whitespace;
		}
	}

	[Field("NSLinguisticTagOther", "Foundation")]
	public static NSString Other
	{
		get
		{
			if (_Other == null)
			{
				_Other = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagOther");
			}
			return _Other;
		}
	}

	[Field("NSLinguisticTagNoun", "Foundation")]
	public static NSString Noun
	{
		get
		{
			if (_Noun == null)
			{
				_Noun = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagNoun");
			}
			return _Noun;
		}
	}

	[Field("NSLinguisticTagVerb", "Foundation")]
	public static NSString Verb
	{
		get
		{
			if (_Verb == null)
			{
				_Verb = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagVerb");
			}
			return _Verb;
		}
	}

	[Field("NSLinguisticTagAdjective", "Foundation")]
	public static NSString Adjective
	{
		get
		{
			if (_Adjective == null)
			{
				_Adjective = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagAdjective");
			}
			return _Adjective;
		}
	}

	[Field("NSLinguisticTagAdverb", "Foundation")]
	public static NSString Adverb
	{
		get
		{
			if (_Adverb == null)
			{
				_Adverb = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagAdverb");
			}
			return _Adverb;
		}
	}

	[Field("NSLinguisticTagPronoun", "Foundation")]
	public static NSString Pronoun
	{
		get
		{
			if (_Pronoun == null)
			{
				_Pronoun = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagPronoun");
			}
			return _Pronoun;
		}
	}

	[Field("NSLinguisticTagDeterminer", "Foundation")]
	public static NSString Determiner
	{
		get
		{
			if (_Determiner == null)
			{
				_Determiner = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagDeterminer");
			}
			return _Determiner;
		}
	}

	[Field("NSLinguisticTagParticle", "Foundation")]
	public static NSString Particle
	{
		get
		{
			if (_Particle == null)
			{
				_Particle = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagParticle");
			}
			return _Particle;
		}
	}

	[Field("NSLinguisticTagPreposition", "Foundation")]
	public static NSString Preposition
	{
		get
		{
			if (_Preposition == null)
			{
				_Preposition = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagPreposition");
			}
			return _Preposition;
		}
	}

	[Field("NSLinguisticTagNumber", "Foundation")]
	public static NSString Number
	{
		get
		{
			if (_Number == null)
			{
				_Number = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagNumber");
			}
			return _Number;
		}
	}

	[Field("NSLinguisticTagConjunction", "Foundation")]
	public static NSString Conjunction
	{
		get
		{
			if (_Conjunction == null)
			{
				_Conjunction = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagConjunction");
			}
			return _Conjunction;
		}
	}

	[Field("NSLinguisticTagInterjection", "Foundation")]
	public static NSString Interjection
	{
		get
		{
			if (_Interjection == null)
			{
				_Interjection = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagInterjection");
			}
			return _Interjection;
		}
	}

	[Field("NSLinguisticTagClassifier", "Foundation")]
	public static NSString Classifier
	{
		get
		{
			if (_Classifier == null)
			{
				_Classifier = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagClassifier");
			}
			return _Classifier;
		}
	}

	[Field("NSLinguisticTagIdiom", "Foundation")]
	public static NSString Idiom
	{
		get
		{
			if (_Idiom == null)
			{
				_Idiom = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagIdiom");
			}
			return _Idiom;
		}
	}

	[Field("NSLinguisticTagOtherWord", "Foundation")]
	public static NSString OtherWord
	{
		get
		{
			if (_OtherWord == null)
			{
				_OtherWord = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagOtherWord");
			}
			return _OtherWord;
		}
	}

	[Field("NSLinguisticTagSentenceTerminator", "Foundation")]
	public static NSString SentenceTerminator
	{
		get
		{
			if (_SentenceTerminator == null)
			{
				_SentenceTerminator = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagSentenceTerminator");
			}
			return _SentenceTerminator;
		}
	}

	[Field("NSLinguisticTagOpenQuote", "Foundation")]
	public static NSString OpenQuote
	{
		get
		{
			if (_OpenQuote == null)
			{
				_OpenQuote = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagOpenQuote");
			}
			return _OpenQuote;
		}
	}

	[Field("NSLinguisticTagCloseQuote", "Foundation")]
	public static NSString CloseQuote
	{
		get
		{
			if (_CloseQuote == null)
			{
				_CloseQuote = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagCloseQuote");
			}
			return _CloseQuote;
		}
	}

	[Field("NSLinguisticTagOpenParenthesis", "Foundation")]
	public static NSString OpenParenthesis
	{
		get
		{
			if (_OpenParenthesis == null)
			{
				_OpenParenthesis = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagOpenParenthesis");
			}
			return _OpenParenthesis;
		}
	}

	[Field("NSLinguisticTagCloseParenthesis", "Foundation")]
	public static NSString CloseParenthesis
	{
		get
		{
			if (_CloseParenthesis == null)
			{
				_CloseParenthesis = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagCloseParenthesis");
			}
			return _CloseParenthesis;
		}
	}

	[Field("NSLinguisticTagWordJoiner", "Foundation")]
	public static NSString WordJoiner
	{
		get
		{
			if (_WordJoiner == null)
			{
				_WordJoiner = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagWordJoiner");
			}
			return _WordJoiner;
		}
	}

	[Field("NSLinguisticTagDash", "Foundation")]
	public static NSString Dash
	{
		get
		{
			if (_Dash == null)
			{
				_Dash = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagDash");
			}
			return _Dash;
		}
	}

	[Field("NSLinguisticTagOtherPunctuation", "Foundation")]
	public static NSString OtherPunctuation
	{
		get
		{
			if (_OtherPunctuation == null)
			{
				_OtherPunctuation = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagOtherPunctuation");
			}
			return _OtherPunctuation;
		}
	}

	[Field("NSLinguisticTagParagraphBreak", "Foundation")]
	public static NSString ParagraphBreak
	{
		get
		{
			if (_ParagraphBreak == null)
			{
				_ParagraphBreak = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagParagraphBreak");
			}
			return _ParagraphBreak;
		}
	}

	[Field("NSLinguisticTagOtherWhitespace", "Foundation")]
	public static NSString OtherWhitespace
	{
		get
		{
			if (_OtherWhitespace == null)
			{
				_OtherWhitespace = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagOtherWhitespace");
			}
			return _OtherWhitespace;
		}
	}

	[Field("NSLinguisticTagPersonalName", "Foundation")]
	public static NSString PersonalName
	{
		get
		{
			if (_PersonalName == null)
			{
				_PersonalName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagPersonalName");
			}
			return _PersonalName;
		}
	}

	[Field("NSLinguisticTagPlaceName", "Foundation")]
	public static NSString PlaceName
	{
		get
		{
			if (_PlaceName == null)
			{
				_PlaceName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagPlaceName");
			}
			return _PlaceName;
		}
	}

	[Field("NSLinguisticTagOrganizationName", "Foundation")]
	public static NSString OrganizationName
	{
		get
		{
			if (_OrganizationName == null)
			{
				_OrganizationName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLinguisticTagOrganizationName");
			}
			return _OrganizationName;
		}
	}
}
