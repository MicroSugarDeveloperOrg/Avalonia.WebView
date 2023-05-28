using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CNErrorCodeExtensions
{
	[Field("CNErrorDomain", "Contacts")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CNErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNErrorDomain");
		}
		return _domain;
	}
}
