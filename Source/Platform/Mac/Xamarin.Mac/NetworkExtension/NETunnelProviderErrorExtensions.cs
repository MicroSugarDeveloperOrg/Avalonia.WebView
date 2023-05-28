using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NETunnelProviderErrorExtensions
{
	[Field("NETunnelProviderErrorDomain", "NetworkExtension")]
	private static NSString? _domain;

	public static NSString? GetDomain(this NETunnelProviderError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NETunnelProviderErrorDomain");
		}
		return _domain;
	}
}
