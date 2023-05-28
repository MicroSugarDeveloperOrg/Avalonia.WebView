using Foundation;
using ObjCRuntime;

namespace SearchKit;

public static class SKTextAnalysisKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EndTermCharsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaximumTermsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinTermLengthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProximityIndexingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StartTermCharsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StopWordsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SubstitutionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TermCharsKey;

	[Field("kSKEndTermChars", "SearchKit")]
	public static NSString EndTermCharsKey
	{
		get
		{
			if (_EndTermCharsKey == null)
			{
				_EndTermCharsKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKEndTermChars");
			}
			return _EndTermCharsKey;
		}
	}

	[Field("kSKMaximumTerms", "SearchKit")]
	public static NSString MaximumTermsKey
	{
		get
		{
			if (_MaximumTermsKey == null)
			{
				_MaximumTermsKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKMaximumTerms");
			}
			return _MaximumTermsKey;
		}
	}

	[Field("kSKMinTermLength", "SearchKit")]
	public static NSString MinTermLengthKey
	{
		get
		{
			if (_MinTermLengthKey == null)
			{
				_MinTermLengthKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKMinTermLength");
			}
			return _MinTermLengthKey;
		}
	}

	[Field("kSKProximityIndexing", "SearchKit")]
	public static NSString ProximityIndexingKey
	{
		get
		{
			if (_ProximityIndexingKey == null)
			{
				_ProximityIndexingKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKProximityIndexing");
			}
			return _ProximityIndexingKey;
		}
	}

	[Field("kSKStartTermChars", "SearchKit")]
	public static NSString StartTermCharsKey
	{
		get
		{
			if (_StartTermCharsKey == null)
			{
				_StartTermCharsKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKStartTermChars");
			}
			return _StartTermCharsKey;
		}
	}

	[Field("kSKStopWords", "SearchKit")]
	public static NSString StopWordsKey
	{
		get
		{
			if (_StopWordsKey == null)
			{
				_StopWordsKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKStopWords");
			}
			return _StopWordsKey;
		}
	}

	[Field("kSKSubstitutions", "SearchKit")]
	public static NSString SubstitutionsKey
	{
		get
		{
			if (_SubstitutionsKey == null)
			{
				_SubstitutionsKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKSubstitutions");
			}
			return _SubstitutionsKey;
		}
	}

	[Field("kSKTermChars", "SearchKit")]
	public static NSString TermCharsKey
	{
		get
		{
			if (_TermCharsKey == null)
			{
				_TermCharsKey = Dlfcn.GetStringConstant(Libraries.SearchKit.Handle, "kSKTermChars");
			}
			return _TermCharsKey;
		}
	}
}
