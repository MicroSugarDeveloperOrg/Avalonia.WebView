using Foundation;
using ObjCRuntime;

namespace GameKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class GKGameSessionErrorCodeExtensions
{
	[Field("GKGameSessionErrorDomain", "GameKit")]
	private static NSString? _domain;

	public static NSString? GetDomain(this GKGameSessionErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.GameKit.Handle, "GKGameSessionErrorDomain");
		}
		return _domain;
	}
}
