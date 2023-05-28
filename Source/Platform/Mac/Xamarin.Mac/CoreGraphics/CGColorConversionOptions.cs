using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CGColorConversionOptions : DictionaryContainer
{
	public bool? BlackPointCompensation
	{
		get
		{
			return GetBoolValue(CGColorConversionInfo.BlackPointCompensationKey);
		}
		set
		{
			SetBooleanValue(CGColorConversionInfo.BlackPointCompensationKey, value);
		}
	}

	public CGSize? TrcSize
	{
		get
		{
			return GetCGSizeValue(CGColorConversionInfo.TrcSizeKey);
		}
		set
		{
			SetCGSizeValue(CGColorConversionInfo.TrcSizeKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CGColorConversionOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CGColorConversionOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
