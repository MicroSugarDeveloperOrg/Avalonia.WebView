using Foundation;
using ObjCRuntime;

namespace LocalAuthentication;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class LAStatusExtensions
{
	[Field("LAErrorDomain", "LocalAuthentication")]
	private static NSString? _domain;

	public static NSString? GetDomain(this LAStatus self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.LocalAuthentication.Handle, "LAErrorDomain");
		}
		return _domain;
	}
}
