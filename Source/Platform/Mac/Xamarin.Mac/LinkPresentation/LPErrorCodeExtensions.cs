using Foundation;
using ObjCRuntime;

namespace LinkPresentation;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class LPErrorCodeExtensions
{
	[Field("LPErrorDomain", "LinkPresentation")]
	private static NSString? _domain;

	public static NSString? GetDomain(this LPErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.LinkPresentation.Handle, "LPErrorDomain");
		}
		return _domain;
	}
}
