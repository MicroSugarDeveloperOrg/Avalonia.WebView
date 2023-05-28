using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSMenuItemEventArgs : NSNotificationEventArgs
{
	[Field("MenuItem", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenu MenuItem
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "MenuItem");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSMenu>(ptr);
		}
	}

	public NSMenuItemEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
