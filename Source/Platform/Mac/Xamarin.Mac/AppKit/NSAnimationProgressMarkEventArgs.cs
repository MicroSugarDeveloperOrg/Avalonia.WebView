using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSAnimationProgressMarkEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public double Progress
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSAnimationProgressMark");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return 0.0;
			}
			using NSNumber nSNumber = new NSNumber(intPtr);
			return nSNumber.DoubleValue;
		}
	}

	public NSAnimationProgressMarkEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
