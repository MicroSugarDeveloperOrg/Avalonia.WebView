using System;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "UNUserNotificationCenterDelegate", WrapperType = typeof(UNUserNotificationCenterDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentNotification", Selector = "userNotificationCenter:willPresentNotification:withCompletionHandler:", ParameterType = new Type[]
{
	typeof(UNUserNotificationCenter),
	typeof(UNNotification),
	typeof(Action<UNNotificationPresentationOptions>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity1V92)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveNotificationResponse", Selector = "userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:", ParameterType = new Type[]
{
	typeof(UNUserNotificationCenter),
	typeof(UNNotificationResponse),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenSettings", Selector = "userNotificationCenter:openSettingsForNotification:", ParameterType = new Type[]
{
	typeof(UNUserNotificationCenter),
	typeof(UNNotification)
}, ParameterByRef = new bool[] { false, false })]
public interface IUNUserNotificationCenterDelegate : INativeObject, IDisposable
{
}
