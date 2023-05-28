using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class PHPhotosErrorExtensions
{
	[Field("PHPhotosErrorDomain", "Photos")]
	private static NSString? _domain;

	public static NSString? GetDomain(this PHPhotosError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHPhotosErrorDomain");
		}
		return _domain;
	}
}
