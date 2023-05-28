using System;
using Foundation;

namespace AppKit;

public class NSTextCheckingOptions : DictionaryContainer
{
	public NSOrthography? Orthography
	{
		get
		{
			return base.Dictionary[NSTextCheckingKey.OrthographyKey] as NSOrthography;
		}
		set
		{
			SetNativeValue(NSTextCheckingKey.OrthographyKey, value);
		}
	}

	public string[]? Quotes
	{
		get
		{
			return GetArray(NSTextCheckingKey.QuotesKey, (IntPtr ptr) => NSString.FromHandle(ptr));
		}
		set
		{
			SetArrayValue(NSTextCheckingKey.QuotesKey, value);
		}
	}

	public NSDictionary? Replacements
	{
		get
		{
			return GetNSDictionary(NSTextCheckingKey.ReplacementsKey);
		}
		set
		{
			SetNativeValue(NSTextCheckingKey.ReplacementsKey, value);
		}
	}

	public NSDate? ReferenceDate
	{
		get
		{
			return base.Dictionary[NSTextCheckingKey.ReferenceDateKey] as NSDate;
		}
		set
		{
			SetNativeValue(NSTextCheckingKey.ReferenceDateKey, value);
		}
	}

	public NSTimeZone? ReferenceTimeZone
	{
		get
		{
			return base.Dictionary[NSTextCheckingKey.ReferenceTimeZoneKey] as NSTimeZone;
		}
		set
		{
			SetNativeValue(NSTextCheckingKey.ReferenceTimeZoneKey, value);
		}
	}

	public NSUrl? DocumentUrl
	{
		get
		{
			return base.Dictionary[NSTextCheckingKey.DocumentUrlKey] as NSUrl;
		}
		set
		{
			SetNativeValue(NSTextCheckingKey.DocumentUrlKey, value);
		}
	}

	public string? DocumentTitle
	{
		get
		{
			return GetStringValue(NSTextCheckingKey.DocumentTitleKey);
		}
		set
		{
			SetStringValue(NSTextCheckingKey.DocumentTitleKey, value);
		}
	}

	public string? DocumentAuthor
	{
		get
		{
			return GetStringValue(NSTextCheckingKey.DocumentAuthorKey);
		}
		set
		{
			SetStringValue(NSTextCheckingKey.DocumentAuthorKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public NSTextCheckingOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public NSTextCheckingOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
