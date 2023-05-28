using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSApplicationDidFinishLaunchingEventArgs : NSNotificationEventArgs
{
	[Field("NSApplicationLaunchIsDefaultLaunchKey", "AppKit")]
	private static IntPtr k0;

	[Field("NSApplicationLaunchUserNotificationKey", "AppKit")]
	private static IntPtr k1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsLaunchDefault
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSApplicationLaunchIsDefaultLaunchKey");
			}
			IntPtr intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return nSNumber.BoolValue;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsLaunchFromUserNotification
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSApplicationLaunchUserNotificationKey");
			}
			NSDictionary userInfo = base.Notification.UserInfo;
			if (userInfo == null)
			{
				return false;
			}
			IntPtr intPtr = userInfo.LowlevelObjectForKey(k1);
			return intPtr != IntPtr.Zero;
		}
	}

	public NSApplicationDidFinishLaunchingEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
