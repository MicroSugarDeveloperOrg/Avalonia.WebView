using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfDocumentAttributes : DictionaryContainer
{
	public string? Title
	{
		get
		{
			return GetStringValue(PdfDocumentAttributeKeys.TitleKey);
		}
		set
		{
			SetStringValue(PdfDocumentAttributeKeys.TitleKey, value);
		}
	}

	public string? Author
	{
		get
		{
			return GetStringValue(PdfDocumentAttributeKeys.AuthorKey);
		}
		set
		{
			SetStringValue(PdfDocumentAttributeKeys.AuthorKey, value);
		}
	}

	public string? Subject
	{
		get
		{
			return GetStringValue(PdfDocumentAttributeKeys.SubjectKey);
		}
		set
		{
			SetStringValue(PdfDocumentAttributeKeys.SubjectKey, value);
		}
	}

	public string? Creator
	{
		get
		{
			return GetStringValue(PdfDocumentAttributeKeys.CreatorKey);
		}
		set
		{
			SetStringValue(PdfDocumentAttributeKeys.CreatorKey, value);
		}
	}

	public string? Producer
	{
		get
		{
			return GetStringValue(PdfDocumentAttributeKeys.ProducerKey);
		}
		set
		{
			SetStringValue(PdfDocumentAttributeKeys.ProducerKey, value);
		}
	}

	public NSDate? CreationDate
	{
		get
		{
			return base.Dictionary[PdfDocumentAttributeKeys.CreationDateKey] as NSDate;
		}
		set
		{
			SetNativeValue(PdfDocumentAttributeKeys.CreationDateKey, value);
		}
	}

	public NSDate? ModificationDate
	{
		get
		{
			return base.Dictionary[PdfDocumentAttributeKeys.ModificationDateKey] as NSDate;
		}
		set
		{
			SetNativeValue(PdfDocumentAttributeKeys.ModificationDateKey, value);
		}
	}

	public string[]? Keywords
	{
		get
		{
			return GetArray(PdfDocumentAttributeKeys.KeywordsKey, (IntPtr ptr) => NSString.FromHandle(ptr));
		}
		set
		{
			SetArrayValue(PdfDocumentAttributeKeys.KeywordsKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public PdfDocumentAttributes()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public PdfDocumentAttributes(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
