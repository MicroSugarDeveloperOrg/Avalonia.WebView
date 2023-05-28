using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfDocumentWriteOptions : DictionaryContainer
{
	public string? OwnerPassword
	{
		get
		{
			return GetStringValue(PdfDocumentWriteOptionKeys.OwnerPasswordKey);
		}
		set
		{
			SetStringValue(PdfDocumentWriteOptionKeys.OwnerPasswordKey, value);
		}
	}

	public string? UserPassword
	{
		get
		{
			return GetStringValue(PdfDocumentWriteOptionKeys.UserPasswordKey);
		}
		set
		{
			SetStringValue(PdfDocumentWriteOptionKeys.UserPasswordKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public PdfDocumentWriteOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public PdfDocumentWriteOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
