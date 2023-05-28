using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ASWebAuthenticationSessionErrorCodeExtensions
{
	[Field("ASWebAuthenticationSessionErrorDomain", "AuthenticationServices")]
	private static NSString? _domain;

	public static NSString? GetDomain(this ASWebAuthenticationSessionErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.AuthenticationServices.Handle, "ASWebAuthenticationSessionErrorDomain");
		}
		return _domain;
	}
}
