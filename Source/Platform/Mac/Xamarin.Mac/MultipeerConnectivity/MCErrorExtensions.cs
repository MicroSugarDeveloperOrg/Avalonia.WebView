using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MCErrorExtensions
{
	[Field("MCErrorDomain", "MultipeerConnectivity")]
	private static NSString? _domain;

	public static NSString? GetDomain(this MCError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.MultipeerConnectivity.Handle, "MCErrorDomain");
		}
		return _domain;
	}
}
