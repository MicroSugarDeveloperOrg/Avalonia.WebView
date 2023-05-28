using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Protocol]
[Register("UNUserNotificationCenterDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class UNUserNotificationCenterDelegate : NSObject, IUNUserNotificationCenterDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public UNUserNotificationCenterDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected UNUserNotificationCenterDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNUserNotificationCenterDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("userNotificationCenter:openSettingsForNotification:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OpenSettings(UNUserNotificationCenter center, UNNotification? notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, [BlockProxy(typeof(Trampolines.NIDActionArity1V92))] Action<UNNotificationPresentationOptions> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
