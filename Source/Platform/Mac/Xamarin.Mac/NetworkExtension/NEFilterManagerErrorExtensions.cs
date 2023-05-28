using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NEFilterManagerErrorExtensions
{
	[Field("NEFilterErrorDomain", "NetworkExtension")]
	private static NSString? _domain;

	public static NSString? GetDomain(this NEFilterManagerError self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEFilterErrorDomain");
		}
		return _domain;
	}
}
