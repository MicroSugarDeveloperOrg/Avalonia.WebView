using System;
using ObjCRuntime;

namespace Foundation;

public class EncodingDetectionOptions : DictionaryContainer
{
	public NSStringEncoding[]? EncodingDetectionSuggestedEncodings
	{
		get
		{
			return GetArray(NSString.EncodingDetectionSuggestedEncodingsKey, delegate(IntPtr ptr)
			{
				using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(ptr);
				return (NSStringEncoding)nSNumber.Int32Value;
			});
		}
		set
		{
			SetArrayValue(NSString.EncodingDetectionSuggestedEncodingsKey, value);
		}
	}

	public NSStringEncoding[]? EncodingDetectionDisallowedEncodings
	{
		get
		{
			return GetArray(NSString.EncodingDetectionDisallowedEncodingsKey, delegate(IntPtr ptr)
			{
				using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(ptr);
				return (NSStringEncoding)nSNumber.Int32Value;
			});
		}
		set
		{
			SetArrayValue(NSString.EncodingDetectionDisallowedEncodingsKey, value);
		}
	}

	public bool? EncodingDetectionUseOnlySuggestedEncodings
	{
		get
		{
			return GetBoolValue(NSString.EncodingDetectionUseOnlySuggestedEncodingsKey);
		}
		set
		{
			SetBooleanValue(NSString.EncodingDetectionUseOnlySuggestedEncodingsKey, value);
		}
	}

	public bool? EncodingDetectionAllowLossy
	{
		get
		{
			return GetBoolValue(NSString.EncodingDetectionAllowLossyKey);
		}
		set
		{
			SetBooleanValue(NSString.EncodingDetectionAllowLossyKey, value);
		}
	}

	public bool? EncodingDetectionFromWindows
	{
		get
		{
			return GetBoolValue(NSString.EncodingDetectionFromWindowsKey);
		}
		set
		{
			SetBooleanValue(NSString.EncodingDetectionFromWindowsKey, value);
		}
	}

	public NSString? EncodingDetectionLossySubstitution
	{
		get
		{
			return GetNSStringValue(NSString.EncodingDetectionLossySubstitutionKey);
		}
		set
		{
			SetStringValue(NSString.EncodingDetectionLossySubstitutionKey, value);
		}
	}

	public NSString? EncodingDetectionLikelyLanguage
	{
		get
		{
			return GetNSStringValue(NSString.EncodingDetectionLikelyLanguageKey);
		}
		set
		{
			SetStringValue(NSString.EncodingDetectionLikelyLanguageKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public EncodingDetectionOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public EncodingDetectionOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
