using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CSIndexErrorCodeExtensions
{
	[Field("CSIndexErrorDomain", "CoreSpotlight")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CSIndexErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSIndexErrorDomain");
		}
		return _domain;
	}
}
