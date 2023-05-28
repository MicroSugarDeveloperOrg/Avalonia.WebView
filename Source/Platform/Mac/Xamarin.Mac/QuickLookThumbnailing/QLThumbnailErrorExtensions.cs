using Foundation;
using ObjCRuntime;

namespace QuickLookThumbnailing;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class QLThumbnailErrorExtensions
{
	[Field("QLThumbnailErrorDomain", "QuickLookThumbnailing")]
	private static NSString? _domain;

	public static NSString? GetDomain(this QLThumbnailError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.QuickLookThumbnailing.Handle, "QLThumbnailErrorDomain");
		}
		return _domain;
	}
}
