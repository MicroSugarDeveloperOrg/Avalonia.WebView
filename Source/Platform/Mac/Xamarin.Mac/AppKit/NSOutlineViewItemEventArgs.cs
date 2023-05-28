using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSOutlineViewItemEventArgs : NSNotificationEventArgs
{
	[Field("NSObject", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject Item
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSObject");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSObject>(ptr);
		}
	}

	public NSOutlineViewItemEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
