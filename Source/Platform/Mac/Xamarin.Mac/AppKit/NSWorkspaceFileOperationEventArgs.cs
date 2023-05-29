using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSWorkspaceFileOperationEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public int FileType
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSOperationNumber");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return 0;
			}
			using NSNumber nSNumber = new NSNumber(intPtr);
			return nSNumber.Int32Value;
		}
	}

	public NSWorkspaceFileOperationEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
