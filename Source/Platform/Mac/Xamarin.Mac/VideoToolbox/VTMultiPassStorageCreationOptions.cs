using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public class VTMultiPassStorageCreationOptions : DictionaryContainer
{
	public bool? DoNotDelete
	{
		get
		{
			return GetBoolValue(VTMultiPassStorageCreationOptionKeys.DoNotDelete);
		}
		set
		{
			SetBooleanValue(VTMultiPassStorageCreationOptionKeys.DoNotDelete, value);
		}
	}

	[Preserve(Conditional = true)]
	public VTMultiPassStorageCreationOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public VTMultiPassStorageCreationOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
