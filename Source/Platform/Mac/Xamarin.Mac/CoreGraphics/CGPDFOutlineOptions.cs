using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class CGPDFOutlineOptions : DictionaryContainer
{
	public string? OutlineTitle
	{
		get
		{
			return GetStringValue(CGPDFOutlineKeys.OutlineTitleKey);
		}
		set
		{
			SetStringValue(CGPDFOutlineKeys.OutlineTitleKey, value);
		}
	}

	public NSDictionary[]? OutlineChildren
	{
		get
		{
			return GetArray<NSDictionary>(CGPDFOutlineKeys.OutlineChildrenKey);
		}
		set
		{
			SetArrayValue(CGPDFOutlineKeys.OutlineChildrenKey, value);
		}
	}

	public NSObject? OutlineDestination
	{
		get
		{
			return base.Dictionary[CGPDFOutlineKeys.OutlineDestinationKey];
		}
		set
		{
			SetNativeValue(CGPDFOutlineKeys.OutlineDestinationKey, value);
		}
	}

	public CGRect? DestinationRect
	{
		get
		{
			return GetCGRectValue(CGPDFOutlineKeys.DestinationRectKey);
		}
		set
		{
			SetCGRectValue(CGPDFOutlineKeys.DestinationRectKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CGPDFOutlineOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CGPDFOutlineOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
