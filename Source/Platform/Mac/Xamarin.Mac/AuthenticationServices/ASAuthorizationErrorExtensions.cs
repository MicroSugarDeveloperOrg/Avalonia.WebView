using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ASAuthorizationErrorExtensions
{
	[Field("ASAuthorizationErrorDomain", "AuthenticationServices")]
	private static NSString? _domain;

	public static NSString? GetDomain(this ASAuthorizationError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.AuthenticationServices.Handle, "ASAuthorizationErrorDomain");
		}
		return _domain;
	}
}
