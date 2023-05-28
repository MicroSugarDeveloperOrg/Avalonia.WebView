using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class VSErrorCodeExtensions
{
	[Field("VSErrorDomain", "VideoSubscriberAccount")]
	private static NSString? _domain;

	public static NSString? GetDomain(this VSErrorCode self)
	{
		if (_domain == null)
		{
			_domain = Dlfcn.GetStringConstant(Libraries.VideoSubscriberAccount.Handle, "VSErrorDomain");
		}
		return _domain;
	}
}
