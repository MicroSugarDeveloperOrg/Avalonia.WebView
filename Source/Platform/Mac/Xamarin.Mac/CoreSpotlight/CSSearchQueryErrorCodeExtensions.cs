using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class CSSearchQueryErrorCodeExtensions
{
	[Field("CSSearchQueryErrorDomain", "CoreSpotlight")]
	private static NSString? _domain;

	public static NSString? GetDomain(this CSSearchQueryErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSSearchQueryErrorDomain");
		}
		return _domain;
	}
}
