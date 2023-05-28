using Foundation;
using ObjCRuntime;

namespace SystemConfiguration;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class StatusCodeExtensions
{
	[Field("kCFErrorDomainSystemConfiguration", "SystemConfiguration")]
	private static NSString? _domain;

	public static NSString? GetDomain(this StatusCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.SystemConfiguration.Handle, "kCFErrorDomainSystemConfiguration");
		}
		return _domain;
	}
}
