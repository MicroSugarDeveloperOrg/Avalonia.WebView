using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Watch(6, 0)]
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

	public AVAssetReferenceRestrictions? ReferenceRestrictions
	{
		get
		{
			return (AVAssetReferenceRestrictions?)(ulong?)GetNUIntValue(AVUrlAsset.ReferenceRestrictionsKey);
		}
		set
		{
			SetNumberValue(AVUrlAsset.ReferenceRestrictionsKey, (nuint?)(ulong?)value);
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
