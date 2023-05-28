using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NEVpnErrorExtensions
{
	[Field("NEVPNErrorDomain", "NetworkExtension")]
	private static NSString? _domain;

	public static NSString? GetDomain(this NEVpnError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEVPNErrorDomain");
		}
		return _domain;
	}
}
