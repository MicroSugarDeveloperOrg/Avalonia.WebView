using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSToolbarItemEventArgs : NSNotificationEventArgs
{
	[Field("item", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSToolbarItem Item
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "item");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSToolbarItem>(ptr);
		}
	}

	public NSToolbarItemEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
