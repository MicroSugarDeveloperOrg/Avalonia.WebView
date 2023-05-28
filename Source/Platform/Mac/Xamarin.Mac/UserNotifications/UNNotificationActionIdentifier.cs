using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
internal static class UNNotificationActionIdentifier
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Default;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Dismiss;

	[Field("UNNotificationDefaultActionIdentifier", "UserNotifications")]
	public static NSString Default
	{
		get
		{
			if (_Default == null)
			{
				_Default = Dlfcn.GetStringConstant(Libraries.UserNotifications.Handle, "UNNotificationDefaultActionIdentifier");
			}
			return _Default;
		}
	}

	[Field("UNNotificationDismissActionIdentifier", "UserNotifications")]
	public static NSString Dismiss
	{
		get
		{
			if (_Dismiss == null)
			{
				_Dismiss = Dlfcn.GetStringConstant(Libraries.UserNotifications.Handle, "UNNotificationDismissActionIdentifier");
			}
			return _Dismiss;
		}
	}
}
