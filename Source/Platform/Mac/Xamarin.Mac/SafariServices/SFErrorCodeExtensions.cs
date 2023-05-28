using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SFErrorCodeExtensions
{
	[Field("SFErrorDomain", "SafariServices")]
	private static NSString? _domain;

	public static NSString? GetDomain(this SFErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.SafariServices.Handle, "SFErrorDomain");
		}
		return _domain;
	}
}
