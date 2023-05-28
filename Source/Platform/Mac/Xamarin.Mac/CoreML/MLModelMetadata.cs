using Foundation;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MLModelMetadata : DictionaryContainer
{
	public string? Description => GetStringValue(MLModelMetadataKeys.DescriptionKey);

	public string? VersionString => GetStringValue(MLModelMetadataKeys.VersionStringKey);

	public string? Author => GetStringValue(MLModelMetadataKeys.AuthorKey);

	public string? License => GetStringValue(MLModelMetadataKeys.LicenseKey);

	public string? CreatorDefined => GetStringValue(MLModelMetadataKeys.CreatorDefinedKey);

	[Preserve(Conditional = true)]
	public MLModelMetadata()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public MLModelMetadata(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
