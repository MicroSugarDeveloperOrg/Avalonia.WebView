using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CIImageProviderOptions : DictionaryContainer
{
	public NSObject? TileSize
	{
		get
		{
			return base.Dictionary[CIImageProviderKeys.TileSizeKey];
		}
		set
		{
			SetNativeValue(CIImageProviderKeys.TileSizeKey, value);
		}
	}

	public NSObject? UserInfo
	{
		get
		{
			return base.Dictionary[CIImageProviderKeys.UserInfoKey];
		}
		set
		{
			SetNativeValue(CIImageProviderKeys.UserInfoKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CIImageProviderOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CIImageProviderOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
