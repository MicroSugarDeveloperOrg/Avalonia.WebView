using Foundation;
using ObjCRuntime;

namespace ImageIO;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
public class CGImageAuxiliaryDataInfo : DictionaryContainer
{
	public CGImageMetadata Metadata
	{
		get
		{
			return GetNativeValue<CGImageMetadata>(CGImageAuxiliaryDataInfoKeys.MetadataKey);
		}
		set
		{
			SetNativeValue(CGImageAuxiliaryDataInfoKeys.MetadataKey, value);
		}
	}

	public NSData? Data
	{
		get
		{
			return base.Dictionary[CGImageAuxiliaryDataInfoKeys.DataKey] as NSData;
		}
		set
		{
			SetNativeValue(CGImageAuxiliaryDataInfoKeys.DataKey, value);
		}
	}

	public NSDictionary? DataDescription
	{
		get
		{
			return GetNSDictionary(CGImageAuxiliaryDataInfoKeys.DataDescriptionKey);
		}
		set
		{
			SetNativeValue(CGImageAuxiliaryDataInfoKeys.DataDescriptionKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CGImageAuxiliaryDataInfo()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CGImageAuxiliaryDataInfo(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
