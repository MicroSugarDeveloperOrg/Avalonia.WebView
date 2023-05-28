using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class PHLivePhotoEditingOption : DictionaryContainer
{
	public bool? ShouldRenderAtPlaybackTime => GetBoolValue(PHLivePhotoEditingOptionKeys.ShouldRenderAtPlaybackTimeKey);

	[Preserve(Conditional = true)]
	public PHLivePhotoEditingOption()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public PHLivePhotoEditingOption(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
