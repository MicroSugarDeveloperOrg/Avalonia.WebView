using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class UNErrorCodeExtensions
{
	[Field("UNErrorDomain", "UserNotifications")]
	private static NSString? _domain;

	public static NSString? GetDomain(this UNErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.UserNotifications.Handle, "UNErrorDomain");
		}
		return _domain;
	}
}
