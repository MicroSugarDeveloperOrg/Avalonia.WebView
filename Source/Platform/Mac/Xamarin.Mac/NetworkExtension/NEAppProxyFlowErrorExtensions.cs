using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NEAppProxyFlowErrorExtensions
{
	[Field("NEAppProxyErrorDomain", "NetworkExtension")]
	private static NSString? _domain;

	public static NSString? GetDomain(this NEAppProxyFlowError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEAppProxyErrorDomain");
		}
		return _domain;
	}
}
