using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSApplicationDidFinishLaunchingEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	private static IntPtr k1;

	public bool IsLaunchDefault
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSApplicationLaunchIsDefaultLaunchKey");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			using NSNumber nSNumber = new NSNumber(intPtr);
			return nSNumber.BoolValue;
		}
	}

	public bool IsLaunchFromUserNotification
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSApplicationLaunchUserNotificationKey");
			}
			if (base.Notification.UserInfo == null)
			{
				return false;
			}
			return base.Notification.UserInfo.LowlevelObjectForKey(k1) != IntPtr.Zero;
		}
	}

	public NSApplicationDidFinishLaunchingEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
