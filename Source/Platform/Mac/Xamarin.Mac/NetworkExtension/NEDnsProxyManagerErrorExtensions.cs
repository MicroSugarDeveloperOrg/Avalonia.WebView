using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NEDnsProxyManagerErrorExtensions
{
	[Field("NEDNSProxyErrorDomain", "NetworkExtension")]
	private static NSString? _domain;

	public static NSString? GetDomain(this NEDnsProxyManagerError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEDNSProxyErrorDomain");
		}
		return _domain;
	}
}
