using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSRemoteNotifications_NSApplication
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSApplicationLaunchUserNotificationKey;

	[Field("NSApplicationLaunchUserNotificationKey", "AppKit")]
	public static NSString NSApplicationLaunchUserNotificationKey
	{
		get
		{
			if (_NSApplicationLaunchUserNotificationKey == null)
			{
				_NSApplicationLaunchUserNotificationKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSApplicationLaunchUserNotificationKey");
			}
			return _NSApplicationLaunchUserNotificationKey;
		}
	}
}
