using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public class AVUrlAssetOptions : DictionaryContainer
{
	public bool? PreferPreciseDurationAndTiming
	{
		get
		{
			return GetBoolValue(AVUrlAsset.PreferPreciseDurationAndTimingKey);
		}
		set
		{
			SetBooleanValue(AVUrlAsset.PreferPreciseDurationAndTimingKey, value);
		}
	}

	[Since(5, 0)]
	public AVAssetReferenceRestrictions? ReferenceRestrictions
	{
		get
		{
			return (AVAssetReferenceRestrictions?)GetInt32Value(AVUrlAsset.ReferenceRestrictionsKey);
		}
		set
		{
			SetNumberValue(AVUrlAsset.ReferenceRestrictionsKey, (int?)value);
		}
	}

	public AVUrlAssetOptions()
		: base(new NSMutableDictionary())
	{
	}

	public AVUrlAssetOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
