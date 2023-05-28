using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
internal static class VSCheckAccessOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CheckAccessOptionPrompt;

	[Field("VSCheckAccessOptionPrompt", "VideoSubscriberAccount")]
	public static NSString CheckAccessOptionPrompt
	{
		get
		{
			if (_CheckAccessOptionPrompt == null)
			{
				_CheckAccessOptionPrompt = Dlfcn.GetStringConstant(Libraries.VideoSubscriberAccount.Handle, "VSCheckAccessOptionPrompt");
			}
			return _CheckAccessOptionPrompt;
		}
	}
}
