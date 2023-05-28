using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class CGPdfTagProperties : DictionaryContainer
{
	public string? ActualText
	{
		get
		{
			return GetStringValue(CGPdfTagPropertyKeys.ActualTextKey);
		}
		set
		{
			SetStringValue(CGPdfTagPropertyKeys.ActualTextKey, value);
		}
	}

	public string? AlternativeText
	{
		get
		{
			return GetStringValue(CGPdfTagPropertyKeys.AlternativeTextKey);
		}
		set
		{
			SetStringValue(CGPdfTagPropertyKeys.AlternativeTextKey, value);
		}
	}

	public string? TitleText
	{
		get
		{
			return GetStringValue(CGPdfTagPropertyKeys.TitleTextKey);
		}
		set
		{
			SetStringValue(CGPdfTagPropertyKeys.TitleTextKey, value);
		}
	}

	public string? LanguageText
	{
		get
		{
			return GetStringValue(CGPdfTagPropertyKeys.LanguageTextKey);
		}
		set
		{
			SetStringValue(CGPdfTagPropertyKeys.LanguageTextKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CGPdfTagProperties()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CGPdfTagProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
