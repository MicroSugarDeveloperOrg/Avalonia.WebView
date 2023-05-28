using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PHLivePhotoEditingErrorExtensions
{
	[Field("PHLivePhotoEditingErrorDomain", "Photos")]
	private static NSString? _domain;

	public static NSString? GetDomain(this PHLivePhotoEditingError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHLivePhotoEditingErrorDomain");
		}
		return _domain;
	}
}
