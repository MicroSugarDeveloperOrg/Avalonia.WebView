using Foundation;
using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class WKErrorCodeExtensions
{
	[Field("WKErrorDomain", "WebKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this WKErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKErrorDomain");
		}
		return _domain;
	}
}
