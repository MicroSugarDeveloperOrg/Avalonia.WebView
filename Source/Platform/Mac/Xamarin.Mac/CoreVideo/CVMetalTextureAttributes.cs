using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreVideo;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class CVMetalTextureAttributes : DictionaryContainer
{
	public MTLTextureUsage? Usage
	{
		get
		{
			return (MTLTextureUsage?)(uint?)GetNUIntValue(CVMetalTextureAttributesKeys.UsageKey);
		}
		set
		{
			SetNumberValue(CVMetalTextureAttributesKeys.UsageKey, (nuint?)(uint?)value);
		}
	}

	[Preserve(Conditional = true)]
	public CVMetalTextureAttributes()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CVMetalTextureAttributes(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
