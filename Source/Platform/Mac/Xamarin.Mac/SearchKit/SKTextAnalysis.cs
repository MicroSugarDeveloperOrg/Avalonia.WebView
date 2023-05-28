using Foundation;

namespace SearchKit;

public class SKTextAnalysis : DictionaryContainer
{
	public int? MinTermLength
	{
		get
		{
			return GetInt32Value(SKTextAnalysisKeys.MinTermLengthKey);
		}
		set
		{
			SetNumberValue(SKTextAnalysisKeys.MinTermLengthKey, value);
		}
	}

	public NSSet? StopWords
	{
		get
		{
			return base.Dictionary[SKTextAnalysisKeys.StopWordsKey] as NSSet;
		}
		set
		{
			SetNativeValue(SKTextAnalysisKeys.StopWordsKey, value);
		}
	}

	public NSDictionary? Substitutions
	{
		get
		{
			return GetNSDictionary(SKTextAnalysisKeys.SubstitutionsKey);
		}
		set
		{
			SetNativeValue(SKTextAnalysisKeys.SubstitutionsKey, value);
		}
	}

	public NSNumber? MaximumTerms
	{
		get
		{
			return base.Dictionary[SKTextAnalysisKeys.MaximumTermsKey] as NSNumber;
		}
		set
		{
			SetNativeValue(SKTextAnalysisKeys.MaximumTermsKey, value);
		}
	}

	public bool? ProximityIndexing
	{
		get
		{
			return GetBoolValue(SKTextAnalysisKeys.ProximityIndexingKey);
		}
		set
		{
			SetBooleanValue(SKTextAnalysisKeys.ProximityIndexingKey, value);
		}
	}

	public string? TermChars
	{
		get
		{
			return GetStringValue(SKTextAnalysisKeys.TermCharsKey);
		}
		set
		{
			SetStringValue(SKTextAnalysisKeys.TermCharsKey, value);
		}
	}

	public string? StartTermChars
	{
		get
		{
			return GetStringValue(SKTextAnalysisKeys.StartTermCharsKey);
		}
		set
		{
			SetStringValue(SKTextAnalysisKeys.StartTermCharsKey, value);
		}
	}

	public string? EndTermChars
	{
		get
		{
			return GetStringValue(SKTextAnalysisKeys.EndTermCharsKey);
		}
		set
		{
			SetStringValue(SKTextAnalysisKeys.EndTermCharsKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SKTextAnalysis()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SKTextAnalysis(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
