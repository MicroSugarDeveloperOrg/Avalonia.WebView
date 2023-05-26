using AppKit;
using WebKit;

namespace Foundation;

public class NSAttributedStringDocumentAttributes : DictionaryContainer
{
	public WebPreferences WebPreferences
	{
		get
		{
			base.Dictionary.TryGetValue(NSStringAttributeKey.NSWebPreferencesDocumentOption, out var value);
			return value as WebPreferences;
		}
		set
		{
			if (value == null)
			{
				RemoveValue(NSStringAttributeKey.NSWebPreferencesDocumentOption);
			}
			else
			{
				base.Dictionary[NSStringAttributeKey.NSWebPreferencesDocumentOption] = value;
			}
		}
	}

	public NSObject WebResourceLoadDelegate
	{
		get
		{
			base.Dictionary.TryGetValue(NSStringAttributeKey.NSWebResourceLoadDelegateDocumentOption, out var value);
			return value;
		}
		set
		{
			if (value == null)
			{
				RemoveValue(NSStringAttributeKey.NSWebResourceLoadDelegateDocumentOption);
			}
			else
			{
				base.Dictionary[NSStringAttributeKey.NSWebResourceLoadDelegateDocumentOption] = value;
			}
		}
	}

	public NSStringEncoding? StringEncoding
	{
		get
		{
			int? int32Value = GetInt32Value(NSStringAttributeKey.NSCharacterEncodingDocumentOption);
			if (!int32Value.HasValue)
			{
				return null;
			}
			return (NSStringEncoding)int32Value.Value;
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.NSCharacterEncodingDocumentOption, (int?)value);
		}
	}

	public NSString WeakDocumentType
	{
		get
		{
			return GetNSStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption);
		}
		set
		{
			SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, value);
		}
	}

	public NSDocumentType DocumentType
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption);
			if (nSStringValue == NSStringAttributeKey.NSPlainTextDocumentType)
			{
				return NSDocumentType.PlainText;
			}
			if (nSStringValue == NSStringAttributeKey.NSRtfTextDocumentType)
			{
				return NSDocumentType.RTF;
			}
			if (nSStringValue == NSStringAttributeKey.NSRtfdTextDocumentType)
			{
				return NSDocumentType.RTFD;
			}
			if (nSStringValue == NSStringAttributeKey.NSMacSimpleTextDocumentType)
			{
				return NSDocumentType.MacSimpleText;
			}
			if (nSStringValue == NSStringAttributeKey.NSHTMLTextDocumentType)
			{
				return NSDocumentType.HTML;
			}
			if (nSStringValue == NSStringAttributeKey.NSDocFormatTextDocumentType)
			{
				return NSDocumentType.DocFormat;
			}
			if (nSStringValue == NSStringAttributeKey.NSWordMLTextDocumentType)
			{
				return NSDocumentType.WordML;
			}
			if (nSStringValue == NSStringAttributeKey.NSWebArchiveTextDocumentType)
			{
				return NSDocumentType.WebArchive;
			}
			if (nSStringValue == NSStringAttributeKey.NSOfficeOpenXMLTextDocumentType)
			{
				return NSDocumentType.OfficeOpenXml;
			}
			if (nSStringValue == NSStringAttributeKey.NSOpenDocumentTextDocumentType)
			{
				return NSDocumentType.OpenDocument;
			}
			return NSDocumentType.Unknown;
		}
		set
		{
			switch (value)
			{
			case NSDocumentType.PlainText:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSPlainTextDocumentType);
				break;
			case NSDocumentType.RTFD:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSRtfdTextDocumentType);
				break;
			case NSDocumentType.RTF:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSRtfTextDocumentType);
				break;
			case NSDocumentType.HTML:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSHTMLTextDocumentType);
				break;
			case NSDocumentType.MacSimpleText:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSMacSimpleTextDocumentType);
				break;
			case NSDocumentType.DocFormat:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSDocFormatTextDocumentType);
				break;
			case NSDocumentType.WordML:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSWordMLTextDocumentType);
				break;
			case NSDocumentType.WebArchive:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSWebArchiveTextDocumentType);
				break;
			case NSDocumentType.OfficeOpenXml:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSOfficeOpenXMLTextDocumentType);
				break;
			case NSDocumentType.OpenDocument:
				SetStringValue(NSStringAttributeKey.NSDocumentTypeDocumentOption, NSStringAttributeKey.NSOpenDocumentTextDocumentType);
				break;
			}
		}
	}

	public NSDictionary WeakDefaultAttributes
	{
		get
		{
			base.Dictionary.TryGetValue(NSStringAttributeKey.NSDefaultAttributesDocumentOption, out var value);
			return value as NSDictionary;
		}
		set
		{
			if (value == null)
			{
				RemoveValue(NSStringAttributeKey.NSDefaultAttributesDocumentOption);
			}
			else
			{
				base.Dictionary[NSStringAttributeKey.NSDefaultAttributesDocumentOption] = value;
			}
		}
	}

	public NSUrl BaseUrl
	{
		get
		{
			return GetNativeValue<NSUrl>(NSStringAttributeKey.NSBaseURLDocumentOption);
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.NSBaseURLDocumentOption, value);
		}
	}

	public string TextEncodingName
	{
		get
		{
			return GetNSStringValue(NSStringAttributeKey.NSTextEncodingNameDocumentOption);
		}
		set
		{
			SetStringValue(NSStringAttributeKey.NSTextEncodingNameDocumentOption, (NSString)value);
		}
	}

	public float? TextSizeMultiplier
	{
		get
		{
			return GetFloatValue(NSStringAttributeKey.NSTextSizeMultiplierDocumentOption);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.NSTextSizeMultiplierDocumentOption, value);
		}
	}

	public float? Timeout
	{
		get
		{
			return GetFloatValue(NSStringAttributeKey.NSTimeoutDocumentOption);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.NSTimeoutDocumentOption, value);
		}
	}

	[Mac(10, 15)]
	[iOS(13, 0)]
	public NSUrl ReadAccessUrl
	{
		get
		{
			base.Dictionary.TryGetValue(NSAttributedStringDocumentReadingOptionKeys.ReadAccessUrlKey, out var value);
			return value as NSUrl;
		}
		set
		{
			if (value == null)
			{
				RemoveValue(NSAttributedStringDocumentReadingOptionKeys.ReadAccessUrlKey);
			}
			else
			{
				base.Dictionary[NSAttributedStringDocumentReadingOptionKeys.ReadAccessUrlKey] = value;
			}
		}
	}

	public NSAttributedStringDocumentAttributes()
		: base(new NSMutableDictionary())
	{
	}

	public NSAttributedStringDocumentAttributes(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
