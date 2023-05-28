using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTMultiPassStorageCreationOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DoNotDelete;

	[Field("kVTMultiPassStorageCreationOption_DoNotDelete", "VideoToolbox")]
	public static NSString DoNotDelete
	{
		get
		{
			if (_DoNotDelete == null)
			{
				_DoNotDelete = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTMultiPassStorageCreationOption_DoNotDelete");
			}
			return _DoNotDelete;
		}
	}
}
